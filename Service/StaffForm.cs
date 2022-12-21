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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void makeReportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportForm f = new ReportForm();
            f.ShowDialog();
            this.Show();
        }

        private void traCuuBtn_Click(object sender, EventArgs e)
        {

        }

        private void RecordFlightBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            LichChuyenBayForm lichChuyenBayForm = new LichChuyenBayForm();
            lichChuyenBayForm.ShowDialog();

            this.Show();
        }

        private void changeRuleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThayDoiQuyDinhForm f = new ThayDoiQuyDinhForm();
            f.ShowDialog();
            this.Show();
        }
    }
}
