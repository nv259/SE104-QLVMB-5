using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Service
{
    public partial class ReportForm : Form
    {
        private BindingSource monthIncome = new BindingSource();
        private BindingSource yearIncome = new BindingSource();
        public ReportForm()
        {
            InitializeComponent();
            reportMonthDgv.DataSource = monthIncome;
            reportYearDgv.DataSource = yearIncome;
            //this.reportMonthBtn.Hide();
            //this.reportYearBtn.Hide();
            //this.reportMonthDgv.Hide();
            this.reportYearDgv.Hide();
            this.yearTxtBox.Show();
            this.monthComboBox.Hide();
        }

        private void reportMonthBtn_Click(object sender, EventArgs e)
        {
            this.monthComboBox.Show();
            this.reportYearDgv.Hide();
            this.reportMonthDgv.Show();
        }
        private void reportYearBtn_Click(object sender, EventArgs e)
        {
            this.monthComboBox.Hide();
            this.reportYearDgv.Show();
            this.reportMonthDgv.Hide();
        }

        private void Load_dtgv_reportYearDgv()
        {
            string year = this.yearTxtBox.Text;
            string query = "SELECT MONTH(NgayGioBay) as 'Tháng', COUNT(CHUYENBAY.MaChuyenBay) as 'Số chuyến bay', " +
                "SUM(DoanhThu) as 'Doanh thu', 100 * SUM(DoanhThu)/(SELECT SUM(DoanhThu) " +
                "from (select CHUYENBAY.MaChuyenBay, SUM(CHUYENBAY.GiaCoBan * HANGVE.TiLeGiaVe) as DoanhThu " +
                "from [dbo].CT_DATVE " +
                "join [dbo].CHUYENBAY on CT_DATVE.MaChuyenBay = CHUYENBAY.MaChuyenBay " +
                "join [dbo].HANGVE on CT_DATVE.MaHangVe = HANGVE.MaHangVe " +
                "where YEAR(NgayGioBay) = @year " +
                "GROUP BY CHUYENBAY.MaChuyenBay) temp ) " +
                "as 'Tỉ lệ' from [dbo].ChuyenBay " +
                "join (select CHUYENBAY.MaChuyenBay, SUM(CHUYENBAY.GiaCoBan * HANGVE.TiLeGiaVe) as DoanhThu " +
                "from [dbo].CT_DATVE join [dbo].CHUYENBAY on CT_DATVE.MaChuyenBay = CHUYENBAY.MaChuyenBay " +
                "join [dbo].HANGVE on CT_DATVE.MaHangVe = HANGVE.MaHangVe " +
                "GROUP BY CHUYENBAY.MaChuyenBay ) as temp2 on ChuyenBay.MaChuyenBay = temp2.MaChuyenBay " +
                "where YEAR(NgayGioBay) = @year2 " +
                "group by month(NgayGioBay) " +
                "order by month(NgayGioBay)";
            reportYearDgv.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { year, year });
            int total = 0;
            for (int i = 0; i < reportYearDgv.Rows.Count; ++i)
            {
                total += Convert.ToInt32(reportYearDgv.Rows[i].Cells[2].Value);
            }
            this.totalIncome.Text = total.ToString();
        }

        private void Load_dtgv_reportMonthDgv()
        {
            string year = this.yearTxtBox.Text;
            string month = this.monthComboBox.Text;
            string query = "SELECT CT_DATVE.MaChuyenBay as 'Mã chuyến bay', " +
                "COUNT(*) as 'Số vé', SUM(CHUYENBAY.GiaCoBan * HANGVE.TiLeGiaVe) as 'Doanh thu', " +
                "SUM(CHUYENBAY.GiaCoBan * HANGVE.TiLeGiaVe) * 100 as 'Tỉ Lệ' " +
                "FROM CT_DATVE JOIN CHUYENBAY on CT_DATVE.MaChuyenBay = CHUYENBAY.MaChuyenBay " +
                "JOIN HANGVE on CT_DATVE.MaHangVe = HANGVE.MaHangVe " +
                "where YEAR(CHUYENBAY.NgayGioBay) = @year AND MONTH(CHUYENBAY.NgayGioBay) = @month " +
                "GROUP BY CT_DATVE.MaChuyenBay";
            reportMonthDgv.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { year, month });
            int total = 0;
            for (int i = 0; i < reportMonthDgv.Rows.Count; ++i)
            {
                total += Convert.ToInt32(reportMonthDgv.Rows[i].Cells[2].Value);
            }
            this.totalIncome.Text = total.ToString();
            if (total > 0) 
            for (int i = 0; i < reportMonthDgv.Rows.Count; ++i)
                reportMonthDgv.Rows[i].Cells[3].Value = Convert.ToInt32(reportMonthDgv.Rows[i].Cells[3].Value) / total;
        }

        private void makeReportBtn_Click(object sender, EventArgs e)
        {
            if (this.reportYearDgv.Visible)
            {
                Load_dtgv_reportYearDgv();
            }
            else if (this.reportMonthDgv.Visible)
            {
                Load_dtgv_reportMonthDgv();
            }
            else
                return;
        }

        private void exportToExcelBtn_Click(object sender, EventArgs e)
        {
            //// creating Excel Application  
            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //// creating new WorkBook within Excel application  
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //// creating new Excelsheet in workbook  
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //// see the excel sheet behind the program  
            //app.Visible = true;
            //// get the reference of first sheet. By default its name is Sheet1.  
            //// store its reference to worksheet  
            //worksheet = workbook.Sheets["Sheet1"];
            //worksheet = workbook.ActiveSheet;
            //// changing the name of active sheet  
            //worksheet.Name = "Exported from gridview";
            //// storing header part in Excel  
            //for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            //{
            //    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            //}
            //// storing Each row and column value to excel sheet  
            //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //    {
            //        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
            //    }
            //}
            //// save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //// Exit from the application  
            //app.Quit();
        }
    }
}
