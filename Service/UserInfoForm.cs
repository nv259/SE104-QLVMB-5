using DataAccess.DAO;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            this.usernameTxtBox.Text = account.MaDangNhap;
            this.fullNameTxtBox.Text = account.TenNguoiDung;
            this.idTxtBox.Text = account.DinhDanh;
            this.emailTxtBox.Text = account.Email;
            this.phoneTxtBox.Text = account.Sdt;

            this.oldPasswordTxtBox.ReadOnly = true;
            this.oldPasswordTxtBox.Enabled = false;
            this.oldPasswordTxtBox.BackColor = Color.LightGray;
            this.newPasswordTxtBox.ReadOnly = true;
            this.newPasswordTxtBox.Enabled = false;
            this.newPasswordTxtBox.BackColor = Color.LightGray;
            this.confirmnewPasswordTxtBox.ReadOnly = true;
            this.confirmnewPasswordTxtBox.Enabled = false;
            this.confirmnewPasswordTxtBox.BackColor = Color.LightGray;
        }

        Account account;

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void idTxtBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

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

        private bool CheckAll()
        {
            Regex validate_emailaddress = email_validation();

            if (validate_emailaddress.IsMatch(this.emailTxtBox.Text.Trim()) != true)
            {
                this.alert_txtBox.Text = "Email không đúng!";
                return false;
            }
            else
            {
                this.alert_txtBox.Text = "";
            }

            string phone_number = this.phoneTxtBox.Text.Trim();
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

            if (changePasswordCkBox.Checked)
            {
                string oldPassword = Convert_to_SHA512(this.oldPasswordTxtBox.Text);
                string newPassword = this.newPasswordTxtBox.Text;
                string confirmnewPassword = this.confirmnewPasswordTxtBox.Text;
                if (oldPassword != account.MatKhau)
                {
                    this.alert_txtBox.Text = "Mật khẩu cũ không khớp!";
                    return false;
                } else if (newPassword != confirmnewPassword)
                {
                    this.alert_txtBox.Text = "Mật khẩu mới không khớp với xác nhận mật khẩu mới!";
                    return false;
                } else
                {
                    this.alert_txtBox.Text = "";
                }
            }

            return true;
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void changePasswordCkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (changePasswordCkBox.Checked)
            {
                this.oldPasswordTxtBox.ReadOnly = false;
                this.oldPasswordTxtBox.Enabled = true;
                this.oldPasswordTxtBox.BackColor = SystemColors.Control;
                this.newPasswordTxtBox.ReadOnly = false;
                this.newPasswordTxtBox.Enabled = true;
                this.newPasswordTxtBox.BackColor = SystemColors.Control;
                this.confirmnewPasswordTxtBox.ReadOnly = false;
                this.confirmnewPasswordTxtBox.Enabled = true;
                this.confirmnewPasswordTxtBox.BackColor = SystemColors.Control;
                CheckAll();
            } else
            {
                this.oldPasswordTxtBox.ReadOnly = true;
                this.oldPasswordTxtBox.Enabled = false;
                this.oldPasswordTxtBox.BackColor = Color.LightGray;
                this.newPasswordTxtBox.ReadOnly = true;
                this.newPasswordTxtBox.Enabled = false;
                this.newPasswordTxtBox.BackColor = Color.LightGray;
                this.confirmnewPasswordTxtBox.ReadOnly = true;
                this.confirmnewPasswordTxtBox.Enabled = false;
                this.confirmnewPasswordTxtBox.BackColor = Color.LightGray;
                CheckAll();
            }
        }

        private void fullNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void emailTxtBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void phoneTxtBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void oldPasswordTxtBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void newPasswordTxtBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void updateUserInfoBtn_Click(object sender, EventArgs e)
        {
            string MaDangNhap, MatKhau, TenNguoiDung, DinhDanh, SoDienThoai, Email;
            MaDangNhap = this.usernameTxtBox.Text;
            TenNguoiDung = this.fullNameTxtBox.Text.Trim();
            
            if (changePasswordCkBox.Checked)
            {
                MatKhau = Convert_to_SHA512(this.newPasswordTxtBox.Text);
            } else
            {
                MatKhau = account.MatKhau;
            }

            DinhDanh = this.idTxtBox.Text;
            SoDienThoai = this.phoneTxtBox.Text.Trim();
            Email = this.emailTxtBox.Text;
             
            if (CheckAll())
            {
                string query = "UPDATE [dbo].NGUOIDUNG SET MatKhau = @MatKhau , TenNguoiDung = @TenNguoiDung , DinhDanh = @DinhDanh , SoDienThoai = @SoDienThoai , Email = @Email WHERE MaDangNhap = @MaDangNhap ";
                object i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MatKhau, TenNguoiDung, DinhDanh, SoDienThoai, Email , MaDangNhap });
                MessageBox.Show("Chỉnh sửa thông tin thành công!");
                this.Close();
            }
        }
    }
}
