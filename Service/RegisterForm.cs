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
            if (this.fullName_txtBox.Text.Length == 0)
            {
                MessageBox.Show("Họ và tên không được để trống!");
                return false;
            }

            string[] chk = fullName_txtBox.Text.Trim().Split(' ');
            foreach(string s in chk)
            {
                if (s.Length < 2)
                {
                    MessageBox.Show("Họ và tên không đúng định dạng!");
                    return false;
                }

                if (!s.All(char.IsLetter)) {
                    MessageBox.Show("Họ và tên không đúng định dạng!");
                    return false;
                }

                if (!char.IsUpper(s[0]))
                {
                    MessageBox.Show("Họ và tên không đúng định dạng!");
                    return false;
                }

                for(int i = 1; i < s.Length; ++i)
                if (!char.IsLower(s[i]))
                    {
                        MessageBox.Show("Họ và tên không đúng định dạng!");
                        return false;
                    }
            }


            Regex validate_emailaddress = email_validation();
            if (this.email_txtBox.Text.Length == 0)
            {
                MessageBox.Show("Email không được để trống!");
                return false;
            }

            if (validate_emailaddress.IsMatch(this.email_txtBox.Text.Trim()) != true)
            {
                MessageBox.Show("Email không đúng định dạng!");
                return false;
            } else {
                string email = this.email_txtBox.Text;
                string Query = "SELECT * FROM [dbo].NGUOIDUNG WHERE Email = @email ";
                if (DataProvider.Instance.ExecuteQuery(Query, new object[] { email }).Rows.Count > 0)
                {
                    MessageBox.Show("Email đã tồn tại!");
                    return false;
                }
            }

            string MaDangNhap = this.username_txtBox.Text;
            if (MaDangNhap.Length > 0)
            {
                if (!IsLowerChar(MaDangNhap[0]))
                {
                    MessageBox.Show("Tên đăng nhập không đúng định dạng!");
                    return false;
                }

                for (int i = 0; i < MaDangNhap.Length; ++i)
                    if (!IsDigit(MaDangNhap[i]) && !IsLowerChar(MaDangNhap[i]))
                    {
                        MessageBox.Show("Tên đăng nhập không đúng định dạng!");
                        return false;
                    }

                if (MaDangNhap.Length < 3)
                {
                    MessageBox.Show("Tên đăng nhập cần ít nhất 3 kí tự!");
                    return false;
                } 

                if (MaDangNhap.Length > 15)
                {
                    MessageBox.Show("Tên đăng nhập chỉ được tối đa 15 kí tự!");
                    return false;
                }
            } else
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống!");
                return false;
            }

            string query = "SELECT * FROM [dbo].NGUOIDUNG WHERE @MaDangNhap = MaDangNhap ";

            if (DataProvider.Instance.ExecuteQuery(query, new object[] { MaDangNhap }).Rows.Count > 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                return false;
            }

            if (CalculateAge(BirthDay_Dtp.Value, DateTime.Now) < 18)
            {
                MessageBox.Show("Ngày sinh không hợp lệ (Phải đủ 18 tuổi trở lên)!");
                return false;
            }

            string pwd = this.pwd_txtBox.Text;
            string confirm_pwd = this.confirmPwd_txtBox.Text;

            if (pwd.Length == 0)
            {
                MessageBox.Show("Mật khẩu không được bỏ trống");
                return false;
            } else if (pwd.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự!");
                return false;
            }

            if (pwd != confirm_pwd)
            {
                MessageBox.Show("Mật khẩu chưa khớp!");
                return false;
            }

            if (this.ID_txtBox.Text.Length == 0)
            {
                MessageBox.Show("Cần nhập mã định danh / CCCD!");
                return false;
            }
            else if (this.ID_txtBox.Text.Length != 0 && this.ID_txtBox.Text.Length != 12)
            {
                MessageBox.Show("Mã định danh / CCCD không hợp lệ!");
                return false;
            }
            else if (ID_txtBox.Text.Length > 0 && !ID_txtBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Mã định danh / CCCD không hợp lệ!");
                return false;
            }
            else
            {
                string id = this.ID_txtBox.Text;
                string Query = "SELECT * FROM [dbo].NGUOIDUNG WHERE DinhDanh = @id ";
                if (DataProvider.Instance.ExecuteQuery(Query, new object[] { id }).Rows.Count > 0)
                {
                    MessageBox.Show("Mã định danh đã tồn tại!");
                    return false;
                }
            }

            string phone_number = this.PhoneNumber_txtBox.Text.Trim();
            if (phone_number.Length == 0)
            {
                MessageBox.Show("Số điện thoại không được để trống!");
                return false;
            }

            if (phone_number.Length != 10 || !phone_number.All(char.IsDigit) || phone_number[0] != '0')
            {
                MessageBox.Show("Số điện thoại không đúng định dạng!");
                return false;
            }
            else
            {
                string phone = this.PhoneNumber_txtBox.Text;
                string Query = "SELECT * FROM [dbo].NGUOIDUNG WHERE SoDienThoai = @phone ";
                if (DataProvider.Instance.ExecuteQuery(Query, new object[] { phone }).Rows.Count > 0)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại!");
                    return false;
                }
            }

            if (!Agree_chkBox.Checked)
            {
                MessageBox.Show("Bạn chưa đồng ý với các điều khoản dịch vụ!");
                return false;
            }

            return true;
        }

        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        private void Register_Btn_Click(object sender, EventArgs e)
        {
            string MaDangNhap, MatKhau, TenNguoiDung, DinhDanh, SoDienThoai, Email, NgaySinh;
            MaDangNhap = this.username_txtBox.Text;
            TenNguoiDung = this.fullName_txtBox.Text.Trim();
            MatKhau = Convert_to_SHA512(this.pwd_txtBox.Text);
            DinhDanh = this.ID_txtBox.Text;
            SoDienThoai = this.PhoneNumber_txtBox.Text.Trim();
            Email = this.email_txtBox.Text;
            NgaySinh = Convert.ToDateTime(this.BirthDay_Dtp.Value).ToString("yyyy-MM-dd");

            if (CheckAll())
            {
                string query = "INSERT INTO [dbo].NGUOIDUNG VALUES ( @MaDangNhap , @MatKhau , '2' , @TenNguoiDung , @DinhDanh , @SoDienThoai , @Email , @NgaySinh ) ";
                object i = DataProvider.Instance.ExecuteScalar(query, new object[] { MaDangNhap, MatKhau, TenNguoiDung, DinhDanh, SoDienThoai, Email, NgaySinh });
                MessageBox.Show("Tạo tài khoản thành công!");
                this.Close();
            }
        }
    }
}
