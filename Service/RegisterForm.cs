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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void alert_txtBox_TextChanged(object sender, EventArgs e)
        {
            
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
