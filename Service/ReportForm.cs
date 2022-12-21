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
            this.reportMonthBtn.Hide();
            this.reportYearBtn.Hide();
            this.reportMonthDgv.Hide();
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
            string query = "SELECT MONTH(NgayGioBay) as 'Tháng', COUNT(MaChuyenBay) as 'Số chuyến bay, " +
                "SUM(DoanhThu) as 'Doanh thu', 100*SUM(DoanhThu)/(SELECT SUM(DoanhThu) from temp where YEAR(NgayGioBay) = @year) " +
                "as 'Tỉ lệ' " +
                "from [dbo].ChuyenBay " +
                "join (" +
                    "select CHUYENBAY.MaChuyenBay, SUM(CHUYENBAY.GiaCoBan * HANGVE.TiLeGiaVe) as DoanhThu " +
                    "from [dbo].CT_DATVE " +
                    "join [dbo].CHUYENBAY on CT_DATVE.MaChuyenBay = CHUYENBAY.MaChuyenBay " +
                    "join [dbo].HANGVE on CT_DATVE.MaHangVe = HANGVE.MaHangVe " +
                    "GROUP BY CHUYENBAY.MaChuyenBay " +
                    ") as temp on ChuyenBay.MaChuyenBay = temp.MaChuyenBay " +
                "where YEAR(NgayGioBay) = @year";
            reportYearDgv.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void Load_dtgv_reportMonthDgv()
        {
            string year = this.yearTxtBox.Text;
            string month = this.monthComboBox.Text;
            string query = " ";
            reportMonthDgv.DataSource = DataProvider.Instance.ExecuteQuery(query);
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


    }
}
