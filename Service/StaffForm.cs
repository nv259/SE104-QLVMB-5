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

        private void sellTicketBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellTicketForm f = new SellTicketForm();
            f.ShowDialog();
            this.Show();
        }
    }
}
