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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            string MaDangNhap = this.username_txtBox.Text;
            string MatKhau = this.pwd_txtBox.Text;
            string TenNguoiDung = this.lastName_txtBox.Text + this.firstName_txtBox.Text;
            string DinhDanh = this.ID_txtBox.Text.Trim();
            string SoDienThoai = this.PhoneNumber_txtBox.Text.Trim();

            if (CheckAll())
            {
                string query = "INSERT INTO [dbo].NGUOIDUNG VALUES( @MaDangNhap , @MatKhau , 2 , @TenNguoiDung , @DinhDanh , @SoDienThoai )";
                object i = DataProvider.Instance.ExecuteScalar(query, new object[] { MaDangNhap, MatKhau, TenNguoiDung, DinhDanh, SoDienThoai });
            }
        }
    }
}
