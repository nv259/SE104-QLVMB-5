﻿using DataAccess.DAO;
using DataAccess.DTO;


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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string MaDangNhap = this.Username_txtBox.Text;
            string MatKhau = this.PasswordtxtBox.Text;

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

                UserForm user_form = new UserForm(MaDangNhap);
                user_form.ShowDialog();

                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
                this.PasswordtxtBox.Text = "";
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

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