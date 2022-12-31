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
    public partial class StaffForm : Form
    {
        public StaffForm(Account account)
        {
            InitializeComponent();

            this.account = account;
            fullName_txtBox.Text = account.TenNguoiDung;
            username_txtBox.Text = account.MaDangNhap;
            BirthDay.Value = account.NgaySinh;
            email_txtBox.Text = account.Email;
            phoneNumber_txtBox.Text = account.Sdt;
            ID_txtBox.Text = account.DinhDanh;

            ChangePass_chkBox.Checked = false;
            OldPassword_txtBox.Enabled = false;
            OldPassword_txtBox.BackColor = Color.LightGray;
            NewPassword_txtBox.Enabled = false;
            NewPassword_txtBox.BackColor = Color.LightGray;
            ConfirmNewPassword_txtBox.Enabled = false;
            ConfirmNewPassword_txtBox.BackColor = Color.LightGray;
        }

        Account account;

        private void makeReportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportForm f = new ReportForm();
            f.ShowDialog();
            this.Show();
        }

        private void LookUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TraCuuChuyenBay tracuu = new TraCuuChuyenBay();
            tracuu.ShowDialog();
            this.Show();
        }

        private void RecordFlightBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LichChuyenBayForm lichChuyenBayForm = new LichChuyenBayForm();
            lichChuyenBayForm.ShowDialog();
            this.Show();
        }

        private void changeRuleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThayDoiQuyDinhForm f = new ThayDoiQuyDinhForm();
            f.ShowDialog();
            this.Show();
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bill f = new Bill();
            f.ShowDialog();
            this.Show();
        }

        private void ChangePass_Btn_CheckedChanged(object sender, EventArgs e)
        {
            if (!ChangePass_chkBox.Checked)
            {
                OldPassword_txtBox.Enabled = false;
                OldPassword_txtBox.BackColor = Color.LightGray;
                NewPassword_txtBox.Enabled = false;
                NewPassword_txtBox.BackColor = Color.LightGray;
                ConfirmNewPassword_txtBox.Enabled = false;
                ConfirmNewPassword_txtBox.BackColor = Color.LightGray;
            } else
            {
                OldPassword_txtBox.Enabled = true;
                OldPassword_txtBox.BackColor = Color.White;
                NewPassword_txtBox.Enabled = true;
                NewPassword_txtBox.BackColor = Color.White;
                ConfirmNewPassword_txtBox.Enabled = true;
                ConfirmNewPassword_txtBox.BackColor = Color.White;
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
            string national_id = ID_txtBox.Text.ToString();
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
            }
            else if (validate_emailaddress.IsMatch(email_txtBox.Text.Trim()) != true)
            {
                MessageBox.Show("Email không đúng định dạng!");
                return false;
            }
            else
            {
                string query = "SELECT * FROM [dbo].NGUOIDUNG WHERE MaDangNhap != @MaDangNhap AND Email = @Email ";
                if (DataProvider.Instance.ExecuteQuery(query, new object[] { username_txtBox.Text.ToString().TrimEnd(), email_txtBox.Text.ToString() }).Rows.Count > 0)
                {
                    MessageBox.Show("Email bạn nhập đã được đăng ký bởi người dùng khác!");
                    return false;
                }
            }

            string phone_number = phoneNumber_txtBox.Text.ToString();
            if (phone_number.Length == 0)
            {
                MessageBox.Show("Số điện thoại không được để trống!");
                return false;
            }
            else if (phone_number.Length != 10 || !phone_number.All(char.IsDigit) || phone_number[0] != '0')
            {
                MessageBox.Show("Số điện thoại không đúng định dạng!");
                return false;
            }
            else
            {
                string query = "SELECT * FROM [dbo].NGUOIDUNG WHERE MaDangNhap != @MaDangNhap AND SoDienThoai = @SoDienThoai ";
                if (DataProvider.Instance.ExecuteQuery(query, new object[] { username_txtBox.Text.ToString().TrimEnd(), phone_number }).Rows.Count > 0)
                {
                    MessageBox.Show("Số điện thoại bạn nhập đã được đăng ký bởi người dùng khác!");
                    return false;
                }
            }

            if (ChangePass_chkBox.Checked)
            {
                string oldPassword = Convert_to_SHA512(this.OldPassword_txtBox.Text);
                string newPassword = this.NewPassword_txtBox.Text;
                string confirmnewPassword = this.ConfirmNewPassword_txtBox.Text;
                if (oldPassword != account.MatKhau)
                {
                    MessageBox.Show("Mật khẩu cũ không khớp!");
                    return false;
                }
                else if (NewPassword_txtBox != ConfirmNewPassword)
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

            if (fullName_txtBox.Text.Length == 0)
            {
                MessageBox.Show("Họ và tên không được để trống!");
                return false;
            }

            string[] chk = fullName_txtBox.Text.Trim().Split(' ');
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

            if (CalculateAge(BirthDay.Value, DateTime.Now) < 18)
            {
                MessageBox.Show("Ngày sinh không hợp lệ (Phải đủ 18 tuổi trở lên)!");
                return false;
            }

            return true;
        }


        private void UpdateInfo_Btn_Click(object sender, EventArgs e)
        {
            if (!CheckAll()) return;

            string MaDangNhap, MatKhau, TenNguoiDung, DinhDanh, SoDienThoai, Email;
            MaDangNhap = this.username_txtBox.Text;
            TenNguoiDung = this.fullName_txtBox.Text.Trim();

            if (ChangePass_chkBox.Checked)
            {
                MatKhau = Convert_to_SHA512(NewPassword_txtBox.Text);
            }
            else
            {
                MatKhau = account.MatKhau;
            }

            DinhDanh = this.ID_txtBox.Text;
            SoDienThoai = this.phoneNumber_txtBox.Text.Trim();
            Email = this.email_txtBox.Text;
            DateTime NgaySinh1 = BirthDay.Value;

            string query = "UPDATE [dbo].NGUOIDUNG SET MatKhau = @MatKhau , TenNguoiDung = @TenNguoiDung , DinhDanh = @DinhDanh , SoDienThoai = @SoDienThoai , Email = @Email , NgaySinh = @NgaySinh WHERE MaDangNhap = @MaDangNhap ";
            object i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MatKhau, TenNguoiDung, DinhDanh, SoDienThoai, Email, NgaySinh1.ToString("yyyy-MM-dd"), MaDangNhap });
            
            MessageBox.Show("Cập nhật thông tin thành công!");

            account = AccountDAO.Instance.GetAccountByUserName(this.username_txtBox.Text);

            this.account = account;
            fullName_txtBox.Text = account.TenNguoiDung;
            username_txtBox.Text = account.MaDangNhap;
            BirthDay.Value = account.NgaySinh;
            email_txtBox.Text = account.Email;
            phoneNumber_txtBox.Text = account.Sdt;
            ID_txtBox.Text = account.DinhDanh;

            ChangePass_chkBox.Checked = false;
            OldPassword_txtBox.Enabled = false;
            OldPassword_txtBox.Text = "";
            NewPassword_txtBox.Enabled = false;
            NewPassword_txtBox.Text = "";
            ConfirmNewPassword_txtBox.Enabled = false;
            ConfirmNewPassword_txtBox.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportForm f = new ReportForm();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bill f = new Bill();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TraCuuChuyenBay tracuu = new TraCuuChuyenBay();
            tracuu.ShowDialog();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LichChuyenBayForm lichChuyenBayForm = new LichChuyenBayForm();
            lichChuyenBayForm.ShowDialog();
            this.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThayDoiQuyDinhForm f = new ThayDoiQuyDinhForm();
            f.ShowDialog();
            this.Show();
        }

        private void publicAnnoucementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiện chưa có thông báo nào!");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Notification", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            //IsLogout = true;
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Notification", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            Application.Exit();
        }

        private void cancelTicket_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TraCuuVeMayBayForm f = new TraCuuVeMayBayForm();
            f.ShowDialog();
            this.Show();
        }
    }
}
