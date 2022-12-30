﻿using DataAccess.DAO;
using DataAccess.DTO;
using System.Security.Cryptography;
using System.Text;

namespace Service
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        { 
            InitializeComponent();

            if (Properties.Settings.Default.remember)
            {
                Username_txtBox.Text = Properties.Settings.Default.username;
                PasswordtxtBox.Text = Properties.Settings.Default.password;
                rmb_txtBox.Checked = true;
            } else
            {
                Username_txtBox.Text = "";
                PasswordtxtBox.Text = "";
                rmb_txtBox.Checked = false;
            }
        }

        SHA512 sha512Hash = SHA512.Create();
        
        private string Convert_to_SHA512(string source)
        {
            byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
            byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
            string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

            return hash.ToString();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string MaDangNhap = this.Username_txtBox.Text;
            string MatKhau = Convert_to_SHA512(this.PasswordtxtBox.Text);

            string query = "SELECT * FROM [dbo].NGUOIDUNG WHERE MaDangNhap = @MaDangNhap AND MatKhau = @MatKhau";

            if (DataProvider.Instance.ExecuteQuery(query, new object[] { MaDangNhap, MatKhau }).Rows.Count > 0)
            {
                if (this.rmb_txtBox.Checked)
                {
                    Properties.Settings.Default.username = Username_txtBox.Text;
                    Properties.Settings.Default.password = PasswordtxtBox.Text;
                    Properties.Settings.Default.remember = true;
                    Properties.Settings.Default.Save();
                } else
                {
                    Properties.Settings.Default.username = "";
                    Properties.Settings.Default.password = "";
                    Properties.Settings.Default.remember = false;
                    Properties.Settings.Default.Save();
                }

                this.Hide();

                Account account = AccountDAO.Instance.GetAccountByUserName(MaDangNhap);

                if (account.MaNhom == "0")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog();
                } else if (account.MaNhom == "1")
                {
                    StaffForm staffForm = new StaffForm(account);
                    staffForm.ShowDialog();
                } else
                {
                    UserForm userForm = new UserForm(account);
                    userForm.ShowDialog();
                }

                try
                {
                    this.Show();
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
                this.PasswordtxtBox.Text = "";

                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.remember = false;
                Properties.Settings.Default.Save();
            }
        }

        private void regBtn_click(object sender, EventArgs e)
        {
            this.Hide();

            RegisterForm f = new RegisterForm();
            f.ShowDialog();

            this.Show();
        }
    }
}