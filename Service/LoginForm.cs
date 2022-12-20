using DataAccess.DAO;
using DataAccess.DTO;


namespace Service
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        { 
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string MaDangNhap = this.Username_txtBox.Text;
            string MatKhau = this.PasswordtxtBox.Text;

            string query = "SELECT * FROM [dbo].NGUOIDUNG WHERE MaDangNhap = @MaDangNhap AND MatKhau = @MatKhau";

            if (DataProvider.Instance.ExecuteQuery(query, new object[] { MaDangNhap, MatKhau }).Rows.Count > 0)
            {
                if (this.rmb_txtBox.Checked)
                    File.WriteAllText(path, MaDangNhap + Environment.NewLine + MatKhau);

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