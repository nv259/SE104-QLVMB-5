using DataAccess.DAO;
using Microsoft.Office.Interop.Excel;
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
using Excel = Microsoft.Office.Interop.Excel;

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

        string type = "";

        private void makeReportBtn_Click(object sender, EventArgs e)
        {
            if (this.reportYearDgv.Visible)
            {
                type = "Year";
                Load_dtgv_reportYearDgv();
            }
            else if (this.reportMonthDgv.Visible)
            {
                type = "Month";
                Load_dtgv_reportMonthDgv();
            }
            else
                return;
        }

        private void exportToExcelBtn_Click(object sender, EventArgs e)
        {
            Excel._Application app = new Excel.Application();
            Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = null;
            app.Visible = true;
            //// get the reference of first sheet. By default its name is Sheet1.  
            //// store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Report";
            //// changing the name of active sheet  

            if (type == "Month")
            {
                worksheet.Cells.Font.Name = "Times New Roman";
                worksheet.Cells.Font.Size = 13;
                worksheet.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                Excel.Range range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 5]];
                range.Merge();
                
                range.Value = "BÁO CÁO DOANH THU BÁN VÉ CÁC CHUYẾN BAY";
                range.Cells.Font.Bold = true;
                range.Cells.Font.Size = 16;

                range = worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 5]];
                range.Merge();
                range.Value = "Tháng: " + monthComboBox.SelectedItem.ToString() + "/" + yearTxtBox.Text.ToString();

                worksheet.Cells[3, 1] = "STT"; worksheet.Cells[3, 1].Font.Bold = true;
                worksheet.Cells[3, 2] = "Chuyến bay"; worksheet.Cells[3, 2].Font.Bold = true;
                worksheet.Cells[3, 3] = "Số vé"; worksheet.Cells[3, 3].Font.Bold = true;
                worksheet.Cells[3, 4] = "Doanh thu"; worksheet.Cells[3, 4].Font.Bold = true;
                worksheet.Cells[3, 5] = "Tỉ lệ"; worksheet.Cells[3, 5].Font.Bold = true;

                worksheet.Range[worksheet.Cells[3, 1], worksheet.Cells[3, 5]].Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
                worksheet.Range[worksheet.Cells[3, 1], worksheet.Cells[3, 5]].Cells.Borders.Weight = XlBorderWeight.xlMedium;

                worksheet.Columns[1].ColumnWidth = 8;
                worksheet.Columns[2].ColumnWidth = 50;
                worksheet.Columns[3].ColumnWidth = 15;
                worksheet.Columns[4].ColumnWidth = 15;
                worksheet.Columns[5].ColumnWidth = 15;

                for(int row = 0; row < reportMonthDgv.Rows.Count - 1; ++row)
                {
                    worksheet.Cells[row + 4, 1] = (row + 1).ToString();
                    for(int column = 0; column < Math.Min(reportMonthDgv.Columns.Count, 4); ++column)
                    {
                        if (reportMonthDgv.Rows[row].Cells[column].Value != null)
                        worksheet.Cells[row + 4, column + 2] = reportMonthDgv.Rows[row].Cells[column].Value.ToString();
                    }

                    worksheet.Range[worksheet.Cells[row + 4, 1], worksheet.Cells[row + 4, 5]].Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Range[worksheet.Cells[row + 4, 1], worksheet.Cells[row + 4, 5]].Cells.Borders.Weight = XlBorderWeight.xlMedium;
                }

                range = worksheet.Range[worksheet.Cells[reportMonthDgv.Rows.Count + 3, 1], worksheet.Cells[reportMonthDgv.Rows.Count + 3, 5]];
                range.Merge();

                range.Value = "Tổng doanh thu: " + totalIncome.Text.ToString();
                range.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            } else if (type == "Year")
            {

                worksheet.Cells.Font.Name = "Times New Roman";
                worksheet.Cells.Font.Size = 13;
                worksheet.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                Excel.Range range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 5]];
                range.Merge();

                range.Value = "BÁO CÁO DOANH THU NĂM";
                range.Cells.Font.Bold = true;
                range.Cells.Font.Size = 16;

                range = worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 5]];
                range.Merge();
                range.Value = "Năm: " + yearTxtBox.Text.ToString();

                worksheet.Cells[3, 1] = "STT"; worksheet.Cells[3, 1].Font.Bold = true;
                worksheet.Cells[3, 2] = "Tháng"; worksheet.Cells[3, 2].Font.Bold = true;
                worksheet.Cells[3, 3] = "Số chuyến bay"; worksheet.Cells[3, 3].Font.Bold = true;
                worksheet.Cells[3, 4] = "Doanh thu"; worksheet.Cells[3, 4].Font.Bold = true;
                worksheet.Cells[3, 5] = "Tỉ lệ"; worksheet.Cells[3, 5].Font.Bold = true;

                worksheet.Range[worksheet.Cells[3, 1], worksheet.Cells[3, 5]].Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
                worksheet.Range[worksheet.Cells[3, 1], worksheet.Cells[3, 5]].Cells.Borders.Weight = XlBorderWeight.xlMedium;

                worksheet.Columns[1].ColumnWidth = 8;
                worksheet.Columns[2].ColumnWidth = 22.5;
                worksheet.Columns[3].ColumnWidth = 22.5;
                worksheet.Columns[4].ColumnWidth = 22.5;
                worksheet.Columns[5].ColumnWidth = 22.5;

                for (int row = 0; row < reportYearDgv.Rows.Count - 1; ++row)
                {
                    worksheet.Cells[row + 4, 1] = (row + 1).ToString();
                    for (int column = 0; column < Math.Min(reportYearDgv.Columns.Count, 4); ++column)
                    {
                        if (reportYearDgv.Rows[row].Cells[column].Value != null)
                            worksheet.Cells[row + 4, column + 2] = reportYearDgv.Rows[row].Cells[column].Value.ToString();
                    }

                    worksheet.Range[worksheet.Cells[row + 4, 1], worksheet.Cells[row + 4, 5]].Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Range[worksheet.Cells[row + 4, 1], worksheet.Cells[row + 4, 5]].Cells.Borders.Weight = XlBorderWeight.xlMedium;
                }

                range = worksheet.Range[worksheet.Cells[reportYearDgv.Rows.Count + 3, 1], worksheet.Cells[reportYearDgv.Rows.Count + 3, 5]];
                range.Merge();

                range.Value = "Tổng doanh thu: " + totalIncome.Text.ToString();
                range.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            }
        }
    }
}
