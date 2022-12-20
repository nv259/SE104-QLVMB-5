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
using System.ComponentModel.Design;

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
            string MaDangNhap, MatKhau, TenNguoiDung, DinhDanh, SoDienThoai, Email;
            MaDangNhap = this.username_txtBox.Text;
            TenNguoiDung = this.fullName_txtBox.Text.Trim();
            MatKhau = this.pwd_txtBox.Text;
            DinhDanh = this.ID_txtBox.Text;
            SoDienThoai = this.PhoneNumber_txtBox.Text.Trim();
            Email = this.email_txtBox.Text;

            if (CheckAll() && this.checkBox2.Checked)
            {
                string query = "INSERT INTO [dbo].NGUOIDUNG VALUES ( @MaDangNhap , @MatKhau , '2' , @TenNguoiDung , @DinhDanh , @SoDienThoai , @Email ) ";
                object i = DataProvider.Instance.ExecuteScalar(query, new object[] { MaDangNhap, MatKhau, TenNguoiDung, DinhDanh, SoDienThoai , Email });
                MessageBox.Show("Tạo tài khoản thành công!");
                this.Close();
            }
        }

        private bool IsLowerChar(char ch)
        {
            if ('a' <= ch && ch <= 'z') return true;
            return false;
        }

        private bool IsDigit(char ch)
        {
            if ('0' <= ch && ch <= '9') return true;
            return false;
        }

        private bool CheckAll()
        {
            Regex validate_emailaddress = email_validation();

            if (validate_emailaddress.IsMatch(this.email_txtBox.Text.Trim()) != true)
            {
                this.alert_txtBox.Text = "Email không đúng!";
                return false;
            }
            else
            {
                this.alert_txtBox.Text = "";
            }

            string MaDangNhap = this.username_txtBox.Text;
            if (MaDangNhap.Length > 0)
            {
                if (!IsLowerChar(MaDangNhap[0]))
                {
                    this.alert_txtBox.Text = "Tên đăng nhập không hợp lệ";
                    return false;
                }

                this.alert_txtBox.Text = "";

                for (int i = 0; i < MaDangNhap.Length; ++i)
                    if (!IsDigit(MaDangNhap[i]) && !IsLowerChar(MaDangNhap[i]))
                    {
                        this.alert_txtBox.Text = "Tên đăng nhập không hợp lệ";
                        return false;
                    }
            } else
            {
                return false;
            }
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

            string phone_number = this.PhoneNumber_txtBox.Text.Trim();
            if (phone_number.Length == 12 && phone_number.Substring(0, 3) == "+84")
            {
                phone_number = phone_number.Remove(0, 3);
                if (!phone_number.All(char.IsDigit))
                {
                    this.alert_txtBox.Text = "Số điện thoại không đúng!";
                    return false;
                }
                else
                {
                    this.alert_txtBox.Text = "";
                }
            }
            else if (phone_number.Length != 10 || !phone_number.All(char.IsDigit) || phone_number[0] != '0')
            {
                this.alert_txtBox.Text = "Số điện thoại không đúng!";
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

        private void firstName_txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
