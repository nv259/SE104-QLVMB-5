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
        public UserForm(string MaDangNhap)
        {
            Account acc = AccountDAO.Instance.GetAccountByUserName(MaDangNhap);

            InitializeComponent();
        }

        private void userInfo_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
