using DataAccess.DAO;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class Bill : Form
    {
        private Account acc;
        public Bill(Account acc = null, string maCB = null)
        {
            this.acc = acc;
            string query;
            DataTable dt;
            InitializeComponent();
            if (acc == null) // is staff
            {
                cb_txtBox.Hide();
                query = "SELECT MaChuyenBay FROM [dbo].CHUYENBAY";
                dt = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow dr in dt.Rows)
                {
                    chuyenBayComboBox.Items.Add(dr["MaChuyenBay"].ToString());
                }

                Ticket_label.Text = "Bán vé máy bay";
                Dat_hoac_Ban_Btn.Text = "Bán vé";
            }
            else // is user
            {
                Dat_hoac_Ban_Btn.Text = "Đặt vé";
                Ticket_label.Text = "Đặt vé máy bay";
                chuyenBayComboBox.Hide();
            }
            if (acc != null) 
            {
                this.name_txtBox.Text = this.acc.TenNguoiDung;
                this.ID_txtBox.Text = this.acc.DinhDanh;
                this.phone_txtBox.Text = this.acc.Sdt;
                this.email_txtBox.Text = this.acc.Email;
                this.Birthday_Dtp.Value = this.acc.NgaySinh;
                this.name_txtBox.ReadOnly = true;
                this.ID_txtBox.ReadOnly = true;
                this.phone_txtBox.ReadOnly = true;
                this.email_txtBox.ReadOnly = true;
                this.Birthday_Dtp.Enabled = false;
                this.cb_txtBox.Text = maCB;
            }
            else {
                this.name_txtBox.Text = string.Empty;
                this.ID_txtBox.Text = string.Empty;
                this.phone_txtBox.Text = string.Empty;
                this.email_txtBox.Text = string.Empty;
                this.Birthday_Dtp.Value = DateTime.Now;
                this.name_txtBox.ReadOnly = false;
                this.ID_txtBox.ReadOnly = false;
                this.phone_txtBox.ReadOnly = false;
                this.email_txtBox.ReadOnly = false;
                this.Birthday_Dtp.Enabled = true;
            }

            query = "SELECT TenHangVe FROM [dbo].HANGVE";
            dt = DataProvider.Instance.ExecuteQuery(query);

            ticket_cmbBox.BeginUpdate();
            ticket_cmbBox.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                ticket_cmbBox.Items.Add(dr["TenHangVe"].ToString());
            }

            ticket_cmbBox.EndUpdate();
            ticket_cmbBox.SelectedItem = null;
            ticket_cmbBox.Text = "";

            this.ngDatVeBox.Value = DateTime.Now;
        }

        private void cb_cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT GiaCoBan FROM [dbo].CHUYENBAY WHERE MaChuyenBay = @MaChuyenBay";
            DataTable dt;
            string MaChuyenBay;

            if (acc != null)
            {
                MaChuyenBay = cb_txtBox.Text;
            }
            else if (chuyenBayComboBox.SelectedItem != null)
            {
                MaChuyenBay = chuyenBayComboBox.SelectedItem.ToString();
            }
            else MaChuyenBay = "";

            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaChuyenBay.Trim() });
            decimal GiaCoBan = 0;
            foreach (DataRow dr in dt.Rows)
            {
                GiaCoBan = (decimal)dr["GiaCoBan"];
                break;
            }

            query = "SELECT TiLeGiaVe FROM [dbo].HANGVE WHERE TenHangVe = @TenHangVe";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { this.ticket_cmbBox.Text });
            double TiLe = 0;
            foreach (DataRow dr in dt.Rows)
            {
                TiLe = (double)dr["TiLeGiaVe"];
                break;
            }

            this.Cost_txtBox.Text = ((decimal) TiLe * GiaCoBan).ToString() + " vnd";
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

        private void Dat_hoac_Ban_Btn_Click(object sender, EventArgs e)
        {
            string maCB;
            if (this.acc != null)
                maCB = this.cb_txtBox.Text.Trim();
            else
            {
                if (chuyenBayComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Chưa chọn mã chuyến bay!");
                    return;
                }
                else
                    maCB = this.chuyenBayComboBox.Text.Trim();
            }

            if (ticket_cmbBox.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn hạng vé!");
                return;
            }


            string ticket_type = this.ticket_cmbBox.Text.Trim();
            string fName = this.name_txtBox.Text;
            string id = this.ID_txtBox.Text;
            string phone = this.phone_txtBox.Text;
            string email = this.email_txtBox.Text;

            if (this.acc == null)
            {
                string national_id = ID_txtBox.Text.ToString();
                if (national_id.Length == 0)
                {
                    MessageBox.Show("Mã định danh / CCCD không được để trống!");
                    return;
                }
                else if (national_id.Length != 12 || !national_id.All(char.IsDigit))
                {
                    MessageBox.Show("Mã định danh / CCCD không đúng định dạng!");
                    return;
                }
                else
                {
                    string Query = "SELECT * FROM [dbo].BANVE WHERE MaChuyenBay != @MaChuyenBay AND DinhDanh = @DinhDanh ";
                    if (DataProvider.Instance.ExecuteQuery(Query, new object[] { maCB.Trim(), national_id }).Rows.Count > 0)
                    {
                        MessageBox.Show("Mã định danh / CCCD đã được bán vé ứng với chuyến bay đã chọn!");
                        return;
                    }
                }
                Regex validate_emailaddress = email_validation();

                if (email_txtBox.Text.Length == 0)
                {
                    MessageBox.Show("Email không được để trống!");
                    return;
                }
                else if (validate_emailaddress.IsMatch(email_txtBox.Text.Trim()) != true)
                {
                    MessageBox.Show("Email không đúng định dạng!");
                    return;
                }

                string phone_number = phone_txtBox.Text.ToString();
                if (phone_number.Length == 0)
                {
                    MessageBox.Show("Số điện thoại không được để trống!");
                    return;
                }
                else if (phone_number.Length != 10 || !phone_number.All(char.IsDigit) || phone_number[0] != '0')
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng!");
                    return;
                }

                if (name_txtBox.Text.Length == 0)
                {
                    MessageBox.Show("Họ và tên không được để trống!");
                    return;
                }

                string[] chk = name_txtBox.Text.Trim().Split(' ');
                foreach (string s in chk)
                {
                    if (s.Length < 2)
                    {
                        MessageBox.Show("Họ và tên không đúng định dạng!");
                        return;
                    }

                    if (!s.All(char.IsLetter))
                    {
                        MessageBox.Show("Họ và tên không đúng định dạng!");
                        return;
                    }

                    if (!char.IsUpper(s[0]))
                    {
                        MessageBox.Show("Họ và tên không đúng định dạng!");
                        return;
                    }

                    for (int i = 1; i < s.Length; ++i)
                        if (!char.IsLower(s[i]))
                        {
                            MessageBox.Show("Họ và tên không đúng định dạng!");
                            return;
                        }
                }

                if (CalculateAge(Birthday_Dtp.Value, DateTime.Now) < 18)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ (Phải đủ 18 tuổi trở lên)!");
                    return;
                }
            }

            string query = "SELECT SoLuong FROM [dbo].CT_HANGVE cthv JOIN [dbo].CHUYENBAY cb ON cthv.MaChuyenBay = cb.MaChuyenBay " +
                            "JOIN [dbo].HANGVE hv ON cthv.MaHangVe = hv.MaHangVe " + "WHERE cthv.MaChuyenBay = @maCB AND hv.TenHangVe = @TenHangVe";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maCB, ticket_type });
            Int16 total = 0;
            foreach (DataRow dr in dt.Rows)
            {
                total = (Int16)dr["SoLuong"];
                break;
            }

            query = "SELECT COUNT(*) AS 'sl' FROM [dbo].CT_DATVE ctdv JOIN [dbo].HANGVE hv ON ctdv.MaHangVe = hv.MaHangVe WHERE ctdv.MaChuyenBay = @maCB AND hv.TenHangVe = @TenHangVe";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maCB, ticket_type });
            int booked = 0;
            foreach (DataRow dr in dt.Rows)
            {
                booked = (int)dr["sl"];
                break;
            }

            if (total - booked <= 0)
                MessageBox.Show("Xin lỗi bạn, hạng vé bạn chọn dành cho chuyến bay này đã hết suất :(");
            else
            {
                query = "SELECT MaHangVe FROM [dbo].HANGVE WHERE TenHangVe = @TenHangVe";
                dt = DataProvider.Instance.ExecuteQuery(query, new object[] { ticket_type });
                string MaHangVe = "";
                foreach (DataRow dr in dt.Rows)
                {
                    MaHangVe = dr["MaHangVe"].ToString();
                    break;
                }

                if (acc == null) // is staff
                {
                    try
                    {
                        query = "INSERT INTO [dbo].BANVE VALUES( @maCB , @MaHangVe , @NgLap , @TenKhachHang , @DinhDanh , @SoDienThoai , @Email )";
                        dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maCB, MaHangVe, Convert.ToDateTime(this.ngDatVeBox.Text).ToString("yyyy-MM-dd"), fName, id, phone, email });
                        query = "INSERT INTO [dbo].CT_DATVE (MaChuyenBay, MaHangVe, NgayLap, TinhTrang) " +
                            "VALUES( @maCB , @MaHangVe , @NgLap , @TinhTrang )";
                        dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maCB, MaHangVe, Convert.ToDateTime(this.ngDatVeBox.Text).ToString("yyyy-MM-dd"), "Done" });
                        MessageBox.Show("Vé đã được đặt thành công!");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error: Mỗi hành khách chỉ được đặt một vé. Hãy hủy vé cũ trước khi đặt vé mới.");
                    }

                } else // is user
                try
                {
                    query = "INSERT INTO [dbo].CT_DATVE VALUES( @maCB , @MaNgDat , @MaHangVe , @NgLap , @TinhTrang )";
                    dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maCB, acc.MaDangNhap, MaHangVe, Convert.ToDateTime(this.ngDatVeBox.Text).ToString("yyyy-MM-dd"), "Done", });
                    MessageBox.Show("Vé đã được đặt thành công!");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Error: Mỗi hành khách chỉ được đặt một vé. Hãy hủy vé cũ trước khi đặt vé mới.");
                    this.Close();
                }
             }
        }
    }
}
