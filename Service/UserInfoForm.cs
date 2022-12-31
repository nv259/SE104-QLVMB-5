using DataAccess.DAO;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{

    public partial class UserInfoForm : Form
    {
        public UserInfoForm(Account account = null)
        {
            this.account = account;
            InitializeComponent();

            this.username_txtBox.Text = account.MaDangNhap;
            this.fullname_txtBox.Text = account.TenNguoiDung;
            this.id_txtBox.Text = account.DinhDanh;
            this.email_txtBox.Text = account.Email;
            this.phonenumber_txtBox.Text = account.Sdt;
            this.birthday_Dtp.Value = account.NgaySinh;

            this.oldPassword_txtBox.Enabled = false;
            this.oldPassword_txtBox.BackColor = Color.LightGray;
            this.newPassword_txtBox.Enabled = false;
            this.newPassword_txtBox.BackColor = Color.LightGray;
            this.confirmnewPassword_txtBox.Enabled = false;
            this.confirmnewPassword_txtBox.BackColor = Color.LightGray;
        }

        Account account;

        SHA512 sha512Hash = SHA512.Create();
        private string Convert_to_SHA512(string source)
        {
            byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
            byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
            string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

            return hash.ToString();
        }

        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
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

        public int CalculateAge(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                age--;

            return age;
        }

        private bool CheckAll()
        {
            string national_id = id_txtBox.Text.ToString();
            if (national_id.Length == 0)
            {
                MessageBox.Show("Mã định danh / CCCD không được để trống!");
                return false;
            }
            else if (national_id.Length != 12 || !national_id.All(char.IsDigit))
            {
                MessageBox.Show("Mã định danh / CCCD không đúng định dạng!");
                return false;
            }
            else
            {
                string query = "SELECT * FROM [dbo].NGUOIDUNG WHERE MaDangNhap != @MaDangNhap AND DinhDanh = @DinhDanh ";
                if (DataProvider.Instance.ExecuteQuery(query, new object[] { username_txtBox.Text.ToString().TrimEnd(), national_id }).Rows.Count > 0)
                {
                    MessageBox.Show("Mã định danh / CCCD bạn nhập đã được đăng ký bởi người dùng khác!");
                    return false;
                }
            }
            Regex validate_emailaddress = email_validation();

            if (email_txtBox.Text.Length == 0)
            {
                MessageBox.Show("Email không được để trống!");
                return false;
            } else if (validate_emailaddress.IsMatch(email_txtBox.Text.Trim()) != true)
            {
                MessageBox.Show("Email không đúng định dạng!");
                return false;
            } else
            {
                string query = "SELECT * FROM [dbo].NGUOIDUNG WHERE MaDangNhap != @MaDangNhap AND Email = @Email ";
                if (DataProvider.Instance.ExecuteQuery(query, new object[] { username_txtBox.Text.ToString().TrimEnd() , email_txtBox.Text.ToString() }).Rows.Count > 0)
                {
                    MessageBox.Show("Email bạn nhập đã được đăng ký bởi người dùng khác!");
                    return false;
                }
            }

            string phone_number = phonenumber_txtBox.Text.ToString();
            if (phone_number.Length == 0)
            {
                MessageBox.Show("Số điện thoại không được để trống!");
                return false;
            } else if (phone_number.Length != 10 || !phone_number.All(char.IsDigit) || phone_number[0] != '0')
            {
                MessageBox.Show("Số điện thoại không đúng định dạng!");
                return false;
            } else
            {
                string query = "SELECT * FROM [dbo].NGUOIDUNG WHERE MaDangNhap != @MaDangNhap AND SoDienThoai = @SoDienThoai ";
                if (DataProvider.Instance.ExecuteQuery(query, new object[] { username_txtBox.Text.ToString().TrimEnd(), phone_number }).Rows.Count > 0)
                {
                    MessageBox.Show("Số điện thoại bạn nhập đã được đăng ký bởi người dùng khác!");
                    return false;
                }
            }

            if (changePassword_chkBox.Checked)
            {
                string oldPassword = Convert_to_SHA512(this.oldPassword_txtBox.Text);
                string newPassword = this.newPassword_txtBox.Text;
                string confirmnewPassword = this.confirmnewPassword_txtBox.Text;
                if (oldPassword != account.MatKhau)
                {
                    MessageBox.Show("Mật khẩu cũ không khớp!");
                    return false;
                }
                else if (newPassword != confirmnewPassword)
                {
                    MessageBox.Show("Mật khẩu mới không khớp với xác nhận mật khẩu mới!");
                    return false;
                }
                else if (newPassword.Length < 8)
                {
                    MessageBox.Show("Mật khẩu phải ít nhất 8 ký tự!");
                    return false;
                }
            }

            if (fullname_txtBox.Text.Length == 0)
            {
                MessageBox.Show("Họ và tên không được để trống!");
                return false;
            }

            string[] chk = fullname_txtBox.Text.Trim().Split(' ');
            foreach (string s in chk)
            {
                if (s.Length < 2)
                {
                    MessageBox.Show("Họ và tên không đúng định dạng!");
                    return false;
                }

                if (!s.All(char.IsLetter))
                {
                    MessageBox.Show("Họ và tên không đúng định dạng!");
                    return false;
                }

                if (!char.IsUpper(s[0]))
                {
                    MessageBox.Show("Họ và tên không đúng định dạng!");
                    return false;
                }

                for (int i = 1; i < s.Length; ++i)
                    if (!char.IsLower(s[i]))
                    {
                        MessageBox.Show("Họ và tên không đúng định dạng!");
                        return false;
                    }
            }

            if (CalculateAge(birthday_Dtp.Value, DateTime.Now) < 18)
            {
                MessageBox.Show("Ngày sinh không hợp lệ (Phải đủ 18 tuổi trở lên)!");
                return false;
            }

            return true;
        }

        private void changePasswordCkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (changePassword_chkBox.Checked)
            {
                this.oldPassword_txtBox.Enabled = true;
                this.oldPassword_txtBox.BackColor = SystemColors.Control;
                this.newPassword_txtBox.Enabled = true;
                this.newPassword_txtBox.BackColor = SystemColors.Control;
                this.confirmnewPassword_txtBox.Enabled = true;
                this.confirmnewPassword_txtBox.BackColor = SystemColors.Control;
            } else
            {
                this.oldPassword_txtBox.Enabled = false;
                this.oldPassword_txtBox.BackColor = Color.LightGray;
                this.newPassword_txtBox.Enabled = false;
                this.newPassword_txtBox.BackColor = Color.LightGray;
                this.confirmnewPassword_txtBox.Enabled = false;
                this.confirmnewPassword_txtBox.BackColor = Color.LightGray;
            }
        }

        private void updateUserInfoBtn_Click(object sender, EventArgs e)
        {
            if (!CheckAll()) return;

            string MaDangNhap, MatKhau, TenNguoiDung, DinhDanh, SoDienThoai, Email;
            MaDangNhap = this.username_txtBox.Text;
            TenNguoiDung = this.fullname_txtBox.Text.Trim();
            
            if (changePassword_chkBox.Checked)
            {
                MatKhau = Convert_to_SHA512(this.newPassword_txtBox.Text);
            } else
            {
                MatKhau = account.MatKhau;
            }

            DinhDanh = this.id_txtBox.Text;
            SoDienThoai = this.phonenumber_txtBox.Text.Trim();
            Email = this.email_txtBox.Text;
            DateTime NgaySinh1 = birthday_Dtp.Value; 
            
            string query = "UPDATE [dbo].NGUOIDUNG SET MatKhau = @MatKhau , TenNguoiDung = @TenNguoiDung , DinhDanh = @DinhDanh , SoDienThoai = @SoDienThoai , Email = @Email , NgaySinh = @NgaySinh WHERE MaDangNhap = @MaDangNhap ";
            object i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MatKhau, TenNguoiDung, DinhDanh, SoDienThoai, Email , NgaySinh1.ToString("yyyy-MM-dd") , MaDangNhap });
            MessageBox.Show("Cập nhật thông tin thành công!");
            this.Close();
        }
    }
}
