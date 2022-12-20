using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

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
            string MaDangNhap, MatKhau, TenNguoiDung, DinhDanh, SoDienThoai;
            MaDangNhap = this.username_txtBox.Text;
            TenNguoiDung = this.lastName_txtBox.Text.Trim() + " " + this.firstName_txtBox.Text.Trim();
            MatKhau = this.pwd_txtBox.Text;
            DinhDanh = this.ID_txtBox.Text;
            SoDienThoai = this.PhoneNumber_txtBox.Text.Trim();

            if (CheckAll() && this.checkBox2.Checked)
            {
                string query = "INSERT INTO [dbo].NGUOIDUNG VALUES ( @MaDangNhap , @MatKhau , 2 , @TenNguoiDung , @DinhDanh , @SoDienThoai ) ";
                object i = DataProvider.Instance.ExecuteScalar(query, new object[] { MaDangNhap, MatKhau, TenNguoiDung, DinhDanh, SoDienThoai });
            }
        }

        private bool CheckAll()
        {
            Regex validate_emailaddress = email_validation();

            if (validate_emailaddress.IsMatch(this.email_txtBox.Text) != true)
            {
                this.alert_txtBox.Text = "Email không đúng!";
                return false;
            }
            else
            {
                this.alert_txtBox.Text = "";
            }

            string phone_number = this.PhoneNumber_txtBox.Text;

            if (!phone_number.All(char.IsDigit))
            {
                this.alert_txtBox.Text = "Số điện thoại không đúng!";
                return false;
            } else
            {
                this.alert_txtBox.Text = "";
            }


            string MaDangNhap = this.username_txtBox.Text;
            string query = "SELECT * FROM [dbo].NGUOIDUNG WHERE @MaDangNhap = MaDangNhap ";

            if (DataProvider.Instance.ExecuteQuery(query, new object[] { MaDangNhap }).Rows.Count > 0)
            {
                this.alert_txtBox.Text = "Tên đăng nhập đã tồn tại!";
                return false;
            }

            string pwd = this.pwd_txtBox.Text;
            string confirm_pwd = this.confirmPwd_txtBox.Text;

            if (pwd != confirm_pwd)
            {
                this.alert_txtBox.Text = "Mật khẩu chưa khớp!";
                return false;
            }
            else
            {
                this.alert_txtBox.Text = "";
            }

            return true;
        }

        private void username_txtBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void pwd_txtBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void confirmPwd_txtBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        private void email_txtBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void PhoneNumber_txtBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }
    }
}
