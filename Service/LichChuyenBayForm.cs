using System;
using DataAccess.DAO;
using DataAccess.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class LichChuyenBayForm : Form
    {
        public LichChuyenBayForm()
        {
            InitializeComponent();

            this.CreatedDate1_txtBox.Text = DateTime.Now.ToString();

            string query = "SELECT * FROM [dbo].SANBAY ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            SanBayDi1_comboBox.BeginUpdate();
            SanBayDen1_comboBox.BeginUpdate();
            TrungGian_comboBox.BeginUpdate();
            SanBayDi1_comboBox.Items.Clear();
            SanBayDen1_comboBox.Items.Clear();
            TrungGian_comboBox.Items.Clear();
        
            foreach (DataRow dr in dt.Rows)
            {
                SanBayDi1_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"].ToString());
                SanBayDen1_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"].ToString());
                TrungGian_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"].ToString());
            }

            SanBayDi1_comboBox.EndUpdate();
            SanBayDen1_comboBox.EndUpdate();
            TrungGian_comboBox.EndUpdate();

            query = "SELECT * FROM [dbo].HANGVE ";
            dt = DataProvider.Instance.ExecuteQuery(query);

            HangVe_comboBox.BeginUpdate();
            HangVe_comboBox.Items.Clear();

            foreach(DataRow dr in dt.Rows)
            {
                HangVe_comboBox.Items.Add(dr["MaHangVe"].ToString());
            }

            HangVe_comboBox.EndUpdate();

            HangVe_Dgv.Columns.Clear();
            HangVe_Dgv.ColumnCount = 3;
            HangVe_Dgv.Columns[0].Name = "Mã hạng vé";
            HangVe_Dgv.Columns[1].Name = "Tên hạng vé";
            HangVe_Dgv.Columns[2].Name = "Số lượng";
            HangVe_Dgv.Columns[0].ReadOnly = true;
            HangVe_Dgv.Columns[1].ReadOnly = true;

            foreach(DataRow dr in dt.Rows)
            {
                HangVe_Dgv.Rows.Add(dr["MaHangVe"].ToString(), dr["TenHangVe"].ToString(), "0");
            }

            TrungGian_Dgv.ColumnCount = 3;
            TrungGian_Dgv.Columns[0].Name = "Sân bay trung gian";
            TrungGian_Dgv.Columns[1].Name = "Thời gian dừng";
            TrungGian_Dgv.Columns[2].Name = "Ghi chú";

            query = "SELECT * FROM [dbo].THAMSO ";
            para = new Parameters(DataProvider.Instance.ExecuteQuery(query).Rows[0]);

            TrungGian1_comboBox.Enabled = false;
            DeleteTrungGian_Btn.Enabled = false;
        }

        Parameters para;

        private string MASANBAY (string input)
        {
            if (input == null || input.Length == 0)
            {
                return "";
            }

            return input.Substring(0, input.IndexOf('|') - 1);
        }

        public static bool IsUnicode(string input)
        {
            var asciiBytesCount = Encoding.ASCII.GetByteCount(input);
            var unicodBytesCount = Encoding.UTF8.GetByteCount(input);
            return asciiBytesCount != unicodBytesCount;
        }

        private bool check_all()
        {
            if (MaChuyenBay1_txtBox.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập mã chuyến bay!");
                return false;
            } else
            {
                if (!MaChuyenBay1_txtBox.Text.All(char.IsLetterOrDigit) || IsUnicode(MaChuyenBay1_txtBox.Text.ToString()))
                {
                    MessageBox.Show("Mã chuyến bay không đúng định dạng!");
                    return false;
                } else
                {
                    string MaChuyenBay = MaChuyenBay1_txtBox.Text;
                    string query = "SELECT * FROM [dbo].CHUYENBAY WHERE MaChuyenBay = @MaChuyenBay ";
                    if (DataProvider.Instance.ExecuteQuery(query, new object[] { MaChuyenBay }).Rows.Count > 0)
                    {
                        MessageBox.Show("Mã chuyến bay đã tồn tại!");
                        return false;
                    }
                }   

                if (MaChuyenBay1_txtBox.Text.Length < 6)
                {
                    MessageBox.Show("Mã chuyến bay quá ngắn (tối thiểu 6 kí tự)!");
                    return false;
                }

                if (MaChuyenBay1_txtBox.Text.Length > 10)
                {
                    MessageBox.Show("Mã chuyến bay quá dài (tối đa 10 kí tự)!");
                    return false;
                }
            }

            if (GiaVe1_txtBox.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập giá vé!");
                return false;
            } else
            {
                decimal temp;
                if (!Decimal.TryParse(this.GiaVe1_txtBox.Text, out temp))
                {
                    MessageBox.Show("Giá vé không đúng định dạng!");
                    return false;
                }
            }

            if (SanBayDi1_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn sân bay đi!");
                return false;
            }

            if (SanBayDen1_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn sân bay đến!");
                return false;
            }

            if (SanBayDi1_comboBox.SelectedItem.ToString() == SanBayDen1_comboBox.SelectedItem.ToString())
            {
                MessageBox.Show("Sân bay đi và sân bay đến phải khác nhau!");
                return false;
            }

            string chk_ngaygiobay = this.NgayGioBay1_txtBox.Text.TrimEnd();
            if (chk_ngaygiobay.Length == 0)
            {
                MessageBox.Show("Chưa nhập ngày - giờ bay!");
                return false;
            } else
            {
                DateTime ngay_gio_bay;
                if (!DateTime.TryParseExact(chk_ngaygiobay, "dd-MM-yyyy HH:mm", null,
                DateTimeStyles.None, out ngay_gio_bay))
                {
                    MessageBox.Show("Ngày - giờ bay không hợp lệ");
                    return false;
                }

                if (ngay_gio_bay.Subtract(DateTime.Now).Days < Math.Max(para.TGDatVeChamNhat, para.TGHuyChamNhat) + 2)
                {
                    MessageBox.Show("Ngày - giờ bay không đảm bảo khách hàng có thể mua vé hoặc hủy vé!");
                    return false;
                }
            }

            string chk_thoigianbay = this.ThoiGianBay1_txtBox.Text.TrimEnd();
            if (chk_thoigianbay.Length == 0)
            {
                MessageBox.Show("Chưa nhập thời gian bay!");
                return false;
            }
            else
            {
                DateTime thoigianbay;

                if (!DateTime.TryParseExact(chk_thoigianbay, "HH:mm", null,
                DateTimeStyles.None, out thoigianbay))
                {
                    MessageBox.Show("Thời gian bay không đúng định dạng!");
                    return false;
                }

                if (thoigianbay < Convert.ToDateTime(para.TGBayToiThieu.ToString()))
                {
                    MessageBox.Show("Thời gian bay không đáp ứng được thời gian bay tối thiểu!");
                    return false;
                }
            }

            foreach(DataGridViewRow row in HangVe_Dgv.Rows)
            {
                if (row.Cells["Số lượng"].Value == null)
                {
                    MessageBox.Show("Chưa nhập số lượng ở hạng vé: " + row.Cells["Tên hạng vé"].Value.ToString());
                    return false;
                }

                string chk_SoLuong = row.Cells["Số lượng"].Value.ToString();
                if (chk_SoLuong.Length == 0)
                {
                    MessageBox.Show("Chưa nhập số lượng ở hạng vé: " + row.Cells["Tên hạng vé"].Value.ToString());
                    return false;
                }

                if (!chk_SoLuong.All(char.IsDigit) || (chk_SoLuong.Length > 1 && chk_SoLuong[0] == '0'))
                {
                    MessageBox.Show("Số lượng vé không đúng định dạng ở hạng vé: " + row.Cells["Tên hạng vé"].Value.ToString());
                    return false;
                }
            }


            bool allZero = true;
            foreach (DataGridViewRow row in HangVe_Dgv.Rows)
            {
                if (Convert.ToInt32(row.Cells["Số lượng"].Value.ToString()) != 0) allZero = false;
            }

            if (allZero)
            {
                MessageBox.Show("Tổng số ghế các hạng vé luôn nguyên dương!!");
                return false;
            }

            return true;
        }

        private void RecordBtn_Click(object sender, EventArgs e)
        {
            if (!check_all()) return;

            string MaChuyenBay = MaChuyenBay1_txtBox.Text;
            Decimal GiaVe = Convert.ToDecimal(GiaVe1_txtBox.Text);
            string MaSanBayDi = MASANBAY(SanBayDi1_comboBox.SelectedItem.ToString());
            string MaSanBayDen = MASANBAY(SanBayDen1_comboBox.SelectedItem.ToString());
            string NgayGioBay = DateTime.ParseExact(NgayGioBay1_txtBox.Text.TrimEnd(), "dd-MM-yyyy HH:mm", null, DateTimeStyles.None).ToString("yyyy-MM-dd HH:mm");
            string ThoiGianBay = ThoiGianBay1_txtBox.Text.TrimEnd();

            string query = "INSERT INTO [dbo].CHUYENBAY VALUES ( @MaChuyenBay , @MaSanBayDi , @MaSanBayDen , @NgayGioBay , @ThoiGianBay , @GiaVe )";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaChuyenBay, MaSanBayDi, MaSanBayDen, NgayGioBay, ThoiGianBay, GiaVe });

            foreach (DataGridViewRow row in HangVe_Dgv.Rows)
            {
                string MaHangVe = row.Cells["Mã hạng vé"].Value.ToString();
                int SoLuong = Convert.ToInt32(row.Cells["Số lượng"].Value);
                query = "INSERT INTO [dbo].CT_HANGVE VALUES ( @MaHangVe , @MaChuyenBay , @SoLuong )";
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaHangVe , MaChuyenBay, SoLuong });
            }

            foreach(DataGridViewRow row in TrungGian_Dgv.Rows)
            {
                string trunggian = row.Cells["Sân bay trung gian"].Value.ToString();
                string thoigiandung = row.Cells["Thời gian dừng"].Value.ToString();
                string ghichu = row.Cells["Ghi chú"].Value.ToString();

                query = "INSERT INTO [dbo].TRUNGGIAN VALUES ( @trunggian , @MaChuyenBay , @thoigiandung , @ghichu )";
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { MASANBAY(trunggian) , MaChuyenBay , thoigiandung, ghichu });
            }

            MessageBox.Show("Đã ghi nhận chuyến bay thành công!");
            this.Close();
        }

        private void HangVe_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HangVe_comboBox.SelectedItem == null)
            {
                SoLuong_txtBox.Text = string.Empty;
                TenHangVe_txtBox.Text = string.Empty;
                return;
            }

            string MaHangVe = HangVe_comboBox.SelectedItem.ToString();
            string query = "SELECT * FROM [dbo].HANGVE WHERE MaHangVe = @MaHangVe ";
            TenHangVe_txtBox.Text = DataProvider.Instance.ExecuteQuery(query, new object[] { MaHangVe }).Rows[0]["TenHangVe"].ToString();
            
            foreach(DataGridViewRow row in HangVe_Dgv.Rows)
            {
                if (row.Cells["Mã hạng vé"].Value.ToString() == MaHangVe)
                {
                    SoLuong_txtBox.Text = row.Cells["Số lượng"].Value.ToString();
                    break;
                }
            }
        }

        private void Change_Btn_Click(object sender, EventArgs e)
        {
            if (HangVe_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn được mã hạng vé!");
                return;
            }

            if (SoLuong_txtBox.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập số lượng!");
                return;
            }

            if (!SoLuong_txtBox.Text.All(char.IsDigit) || (SoLuong_txtBox.Text.Length > 1 && SoLuong_txtBox.Text[0] == '0')) {
                MessageBox.Show("Số lượng không đúng định dạng");
                return;
            }

            string MaHangVe = HangVe_comboBox.SelectedItem.ToString();
            foreach (DataGridViewRow row in HangVe_Dgv.Rows)
            {
                if (row.Cells["Mã hạng vé"].Value.ToString() == MaHangVe)
                {
                    row.Cells["Số lượng"].Value = SoLuong_txtBox.Text;
                    break;
                }
            }
        }

        private void AddTrungGian_Btn_Click(object sender, EventArgs e)
        {
            if (TrungGian_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn được sân bay trung gian!");
                return;
            }

            string ThoiGianDung = ThoiGianDung_txtBox.Text.TrimEnd();
            DateTime temp;
            if (!DateTime.TryParseExact(ThoiGianDung, "HH:mm", null, DateTimeStyles.None, out temp))
            {
                MessageBox.Show("Thời gian dừng không đúng định dạng!");
                return;
            }

            if (temp < Convert.ToDateTime(para.TGDungToiThieu.ToString()) || temp > Convert.ToDateTime(para.TGDungToiDa.ToString()))
            {
                MessageBox.Show("Thời gian dừng không đáp ứng điều kiện dừng tối thiểu và dừng tối đa!");
                return;
            }

            TrungGian_Dgv.Rows.Add(TrungGian_comboBox.SelectedItem.ToString(), ThoiGianDung, GhiChu_RichTxtBox.Text);

            SanBayDi1_comboBox.BeginUpdate();
            SanBayDen1_comboBox.BeginUpdate();
            TrungGian_comboBox.BeginUpdate();
            SanBayDi1_comboBox.Items.Clear();
            SanBayDen1_comboBox.Items.Clear();
            TrungGian_comboBox.Items.Clear();

            string query = "SELECT * FROM [dbo].SANBAY ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow dr in dt.Rows)
            {
                bool Find = false;
                foreach(DataGridViewRow row in TrungGian_Dgv.Rows)
                if (MASANBAY(row.Cells["Sân bay trung gian"].Value.ToString()) == dr["MaSanBay"].ToString().TrimEnd())
                {
                    Find = true;
                    break;
                }

                if (Find) continue;

                SanBayDi1_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"].ToString());
                SanBayDen1_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"].ToString());
                TrungGian_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"].ToString());
            }

            SanBayDi1_comboBox.EndUpdate();
            SanBayDen1_comboBox.EndUpdate();
            TrungGian_comboBox.EndUpdate();
            SanBayDi1_comboBox.Text = "";
            SanBayDen1_comboBox.Text = "";
            TrungGian_comboBox.Text = "";
            SanBayDi1_comboBox.SelectedItem = null;
            SanBayDen1_comboBox.SelectedItem = null;
            TrungGian_comboBox.SelectedItem = null;

            TrungGian1_comboBox.BeginUpdate();
            TrungGian1_comboBox.Items.Clear();
            foreach (DataGridViewRow row in TrungGian_Dgv.Rows)
            {
                TrungGian1_comboBox.Items.Add(row.Cells["Sân bay trung gian"].Value.ToString());
            }

            TrungGian1_comboBox.EndUpdate();
            TrungGian1_comboBox.Text = "";
            TrungGian1_comboBox.SelectedItem = null;
            GhiChu_RichTxtBox.Text = "";
            ThoiGianBay1_txtBox.Text = "";
            MessageBox.Show("Đã thêm thành công!");

            if (TrungGian1_comboBox.Items.Count == para.SoSanBayTGToiDa)
            {
                TrungGian_comboBox.Enabled = false;
                ThoiGianDung_txtBox.Enabled = false;
                GhiChu_RichTxtBox.Enabled = false;
                AddTrungGian_Btn.Enabled = false;
            }

            if (TrungGian1_comboBox.Items.Count > 0)
            {
                TrungGian1_comboBox.Enabled = true;
                DeleteTrungGian_Btn.Enabled = true;
            }
        }

        private void DeleteTrungGian_Btn_Click(object sender, EventArgs e)
        {
            if (TrungGian1_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn được sân bay trung gian!");
                return;
            }

            string SanBay = TrungGian1_comboBox.SelectedItem.ToString();
            foreach(DataGridViewRow row in TrungGian_Dgv.Rows)
            {
                if (row.Cells["Sân bay trung gian"].Value.ToString() == SanBay)
                {
                    TrungGian_Dgv.Rows.Remove(row);
                    break;
                }
            }

            SanBayDi1_comboBox.BeginUpdate();
            SanBayDen1_comboBox.BeginUpdate();
            TrungGian_comboBox.BeginUpdate();
            SanBayDi1_comboBox.Items.Clear();
            SanBayDen1_comboBox.Items.Clear();
            TrungGian_comboBox.Items.Clear();

            string query = "SELECT * FROM [dbo].SANBAY ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow dr in dt.Rows)
            {
                bool Find = false;
                foreach (DataGridViewRow row in TrungGian_Dgv.Rows)
                    if (MASANBAY(row.Cells["Sân bay trung gian"].Value.ToString()) == dr["MaSanBay"].ToString().TrimEnd())
                    {
                        Find = true;
                        break;
                    }

                if (Find) continue;

                SanBayDi1_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"].ToString());
                SanBayDen1_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"].ToString());
                TrungGian_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"].ToString());
            }

            SanBayDi1_comboBox.EndUpdate();
            SanBayDen1_comboBox.EndUpdate();
            TrungGian_comboBox.EndUpdate();
            SanBayDi1_comboBox.Text = "";
            SanBayDen1_comboBox.Text = "";
            TrungGian_comboBox.Text = "";
            SanBayDi1_comboBox.SelectedItem = null;
            SanBayDen1_comboBox.SelectedItem = null;
            TrungGian_comboBox.SelectedItem = null;

            TrungGian1_comboBox.BeginUpdate();
            TrungGian1_comboBox.Items.Clear();
            foreach (DataGridViewRow row in TrungGian_Dgv.Rows)
            {
                TrungGian1_comboBox.Items.Add(row.Cells["Sân bay trung gian"].Value.ToString());
            }

            TrungGian1_comboBox.EndUpdate();
            TrungGian1_comboBox.Text = "";
            TrungGian1_comboBox.SelectedItem = null;
            GhiChu_RichTxtBox.Text = "";
            ThoiGianBay1_txtBox.Text = "";
            MessageBox.Show("Đã xóa thành công!");

            if (TrungGian1_comboBox.Items.Count < para.SoSanBayTGToiDa)
            {
                TrungGian_comboBox.Enabled = true;
                ThoiGianDung_txtBox.Enabled = true;
                GhiChu_RichTxtBox.Enabled = true;
                AddTrungGian_Btn.Enabled = true;
            }

            if (TrungGian1_comboBox.Items.Count == 0)
            {
                TrungGian1_comboBox.Enabled = false;
                DeleteTrungGian_Btn.Enabled = false;
            }
        }
    }
}
