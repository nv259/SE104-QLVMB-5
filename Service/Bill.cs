using DataAccess.DAO;
using DataAccess.DTO;
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
    public partial class Bill : Form
    {
        private Airport airport;
        private Ticket[] tickets = TicketDAO.Instance.GetAllTicketType();
        public Bill(Account acc = null)
        {

            InitializeComponent();

            this.name_txtBox.Text = acc.TenNguoiDung;
            this.ID_txtBox.Text = acc.DinhDanh;
            this.phone_txtBox.Text = acc.Sdt;
            this.email_txtBox.Text = acc.Email;

            this.ticket_cmbBox.DataSource = tickets;
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void cb_cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cost_txtBox.Text = (21520378).ToString();
        }
    }
}
