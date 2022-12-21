using DataAccess.DTO;
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
    public partial class UserForm : Form
    {
        public UserForm(Account account = null)
        {
            InitializeComponent();
            this.account = account;

            this.userName_txtBox.Text = account.MaDangNhap;
            this.fullName_txtBox.Text = account.TenNguoiDung;
            this.ID_txtBox.Text = account.DinhDanh;
            this.email_txtBox.Text = account.Email;
            this.phoneNumber_txtBox.Text = account.Sdt;
        }

        Account account;

        private void userInfo_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void changeInfoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            UserInfoForm userInfoForm = new UserInfoForm(this.account);
            userInfoForm.ShowDialog();

            this.Show();
        }
    }
}
