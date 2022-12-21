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
using System.Security.Cryptography;
using System.Collections.Specialized;
using System.Globalization;

namespace Service
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        SHA512 sha512Hash = SHA512.Create();
        private string Convert_to_SHA512(string source)
        {
            byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
            byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
            string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

            return hash.ToString();
        }
        private void regBtn_Click(object sender, EventArgs e)
        {
            string MaDangNhap, MatKhau, TenNguoiDung, DinhDanh, SoDienThoai, Email, NgaySinh;
            MaDangNhap = this.username_txtBox.Text;
            TenNguoiDung = this.fullName_txtBox.Text.Trim();
            MatKhau = Convert_to_SHA512(this.pwd_txtBox.Text);
            DinhDanh = this.ID_txtBox.Text;
            SoDienThoai = this.PhoneNumber_txtBox.Text.Trim();
            Email = this.email_txtBox.Text;
            NgaySinh = Convert.ToDateTime(this.NgaySinh_txtBox.Text.TrimEnd().ToString()).ToString("yyyy-MM-dd");

            if (CheckAll() && this.checkBox2.Checked)
            {
                string query = "INSERT INTO [dbo].NGUOIDUNG VALUES ( @MaDangNhap , @MatKhau , '2' , @TenNguoiDung , @DinhDanh , @SoDienThoai , @Email , @NgaySinh ) ";
                object i = DataProvider.Instance.ExecuteScalar(query, new object[] { MaDangNhap, MatKhau, TenNguoiDung, DinhDanh, SoDienThoai , Email , NgaySinh });
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
            this.alert_txtBox.Text = "";

            if (this.fullName_txtBox.Text.Length == 0)
            {
                this.alert_txtBox.Text = "Cần nhập họ và tên!";
                return false;
            } 

            Regex validate_emailaddress = email_validation();
            if (this.email_txtBox.Text.Length == 0)
            {
                this.alert_txtBox.Text = "Cần nhập Email!";
                return false;
            }

            if (validate_emailaddress.IsMatch(this.email_txtBox.Text.Trim()) != true)
            {
                this.alert_txtBox.Text = "Email không đúng!";
                return false;
            } else {
                string email = this.email_txtBox.Text;
                string Query = "SELECT * FROM [dbo].NGUOIDUNG WHERE Email = @email ";
                if (DataProvider.Instance.ExecuteQuery(Query, new object[] { email }).Rows.Count > 0)
                {
                    this.alert_txtBox.Text = "Email đã tồn tại!";
                    return false;
                }
                else this.alert_txtBox.Text = "";
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
                this.alert_txtBox.Text = "Cần nhập tên đăng nhập!";
                return false;
            }

            string query = "SELECT * FROM [dbo].NGUOIDUNG WHERE @MaDangNhap = MaDangNhap ";

            if (DataProvider.Instance.ExecuteQuery(query, new object[] { MaDangNhap }).Rows.Count > 0)
            {
                this.alert_txtBox.Text = "Tên đăng nhập đã tồn tại!";
                return false;
            }

            if (NgaySinh_txtBox.Text.Length == 0)
            {
                this.alert_txtBox.Text = "Chưa nhập ngày sinh!";
                return false;
            }

            DateTime temp;
            if (!DateTime.TryParseExact(NgaySinh_txtBox.Text.TrimEnd(), "dd-MM-yyyy", null, DateTimeStyles.None, out temp))
            {
                this.alert_txtBox.Text = "Ngày sinh không đúng định dạng!";
                return false;
            }

            string pwd = this.pwd_txtBox.Text;
            string confirm_pwd = this.confirmPwd_txtBox.Text;

            if (pwd.Length == 0)
            {
                this.alert_txtBox.Text = "Cần nhập mật khẩu";
                return false;
            } else if (pwd.Length < 8)
            {
                this.alert_txtBox.Text = "Mật khẩu phải có ít nhất 8 ký tự!";
                return false;
            }

            if (pwd != confirm_pwd)
            {
                this.alert_txtBox.Text = "Mật khẩu chưa khớp!";
                return false;
            }
            else this.alert_txtBox.Text = "";

            if (this.ID_txtBox.Text.Length == 0)
            {
                this.alert_txtBox.Text = "Cần nhập mã định danh!";
                return false;
            }
            else if (this.ID_txtBox.Text.Length != 0 && this.ID_txtBox.Text.Length != 12)
            {
                this.alert_txtBox.Text = "Mã định danh không hợp lệ!";
                return false;
            }
            else if (ID_txtBox.Text.Length > 0 && !ID_txtBox.Text.All(char.IsDigit))
            {
                this.alert_txtBox.Text = "Mã định danh không hợp lệ!";
                return false;
            }
            else
            {
                string id = this.ID_txtBox.Text;
                string Query = "SELECT * FROM [dbo].NGUOIDUNG WHERE DinhDanh = @id ";
                if (DataProvider.Instance.ExecuteQuery(Query, new object[] { id }).Rows.Count > 0)
                {
                    this.alert_txtBox.Text = "Mã định danh đã tồn tại!";
                    return false;
                }
                else this.alert_txtBox.Text = "";
            }

            string phone_number = this.PhoneNumber_txtBox.Text.Trim();
            if (phone_number.Length == 0)
            { 
                this.alert_txtBox.Text = "Cần nhập số điện thoại!";
                return false;
            }

            if (phone_number.Length != 10 || !phone_number.All(char.IsDigit) || phone_number[0] != '0')
            {
                this.alert_txtBox.Text = "Số điện thoại không đúng!";
                return false;
            }
            else
            {
                string phone = this.PhoneNumber_txtBox.Text;
                string Query = "SELECT * FROM [dbo].NGUOIDUNG WHERE SoDienThoai = @phone ";
                if (DataProvider.Instance.ExecuteQuery(Query, new object[] { phone }).Rows.Count > 0)
                {
                    this.alert_txtBox.Text = "Số điện thoại đã tồn tại!";
                    return false;
                }
                else this.alert_txtBox.Text = "";
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
            CheckAll();
        }

        private void ID_txtBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }
    }
}
