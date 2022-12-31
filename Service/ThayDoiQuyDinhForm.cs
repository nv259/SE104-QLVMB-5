using DataAccess.DAO;
using DataAccess.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class ThayDoiQuyDinhForm : Form
    {
        public ThayDoiQuyDinhForm()
        {
            InitializeComponent();

            SoSBTGToiDa_chkBox.Checked = false;
            SSBTGTD_txtBox.Enabled = false;
            SSBTGTD_txtBox.BackColor = Color.LightGray;

            TGBTT_chkBox.Checked = false;
            BayToiThieu_Gio.BackColor = Color.LightGray;
            BayToiThieu_Phut.BackColor = Color.LightGray;
            BayToiThieu_Gio.Enabled = false;
            BayToiThieu_Phut.Enabled = false;

            TGDTT_chkBox.Checked = false;
            DungToiThieu_Gio.BackColor = Color.LightGray;
            DungToiThieu_Phut.BackColor = Color.LightGray;
            DungToiThieu_Gio.Enabled = false;
            DungToiThieu_Phut.Enabled = false;

            TGDTD_chkBox.Checked = false;
            DungToiDa_Gio.BackColor = Color.LightGray;
            DungToiDa_Phut.BackColor = Color.LightGray;
            DungToiDa_Gio.Enabled = false;
            DungToiDa_Phut.Enabled = false;

            TGDVCN_chkBox.Checked = false;
            DatVeChamNhat_txtBox.Enabled = false;
            DatVeChamNhat_txtBox.BackColor = Color.LightGray;

            TGHVCN_chkBox.Checked = false;
            HuyVeChamNhat_txtBox.Enabled = false;
            HuyVeChamNhat_txtBox.BackColor = Color.LightGray;
             
            string query = "SELECT * FROM [dbo].SANBAY ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            MaSB_TD_comboBox.BeginUpdate();
            MaSB_TD_comboBox.Items.Clear();
            MaSB_Xoa_comboBox.BeginUpdate();
            MaSB_Xoa_comboBox.Items.Clear();
            SanBay_listView.BeginUpdate();
            SanBay_listView.Items.Clear();

            foreach(DataRow dr in dt.Rows)
            {
                MaSB_TD_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd());
                MaSB_Xoa_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd());
                SanBay_listView.Items.Add(new ListViewItem(new string[]{ dr["MaSanBay"].ToString() , dr["TenSanBay"].ToString() }));
            }

            MaSB_TD_comboBox.EndUpdate();
            MaSB_Xoa_comboBox.EndUpdate();
            SanBay_listView.EndUpdate();

            query = "SELECT * FROM [dbo].HANGVE ";
            dt = DataProvider.Instance.ExecuteQuery(query);

            MaHV_TD_comboBox.BeginUpdate();
            MaHV_TD_comboBox.Items.Clear();
            MaHV_Xoa_comboBox.BeginUpdate();
            MaHV_Xoa_comboBox.Items.Clear();
            HangVe_listView.BeginUpdate();
            HangVe_listView.Items.Clear();

            foreach(DataRow dr in dt.Rows)
            {
                MaHV_TD_comboBox.Items.Add(dr["MaHangVe"].ToString().TrimEnd());
                MaHV_Xoa_comboBox.Items.Add(dr["MaHangVe"].ToString().TrimEnd());
                HangVe_listView.Items.Add(new ListViewItem(new string[] { dr["MaHangVe"].ToString() , dr["TenHangVe"].ToString() , dr["TiLeGiaVe"].ToString() }));
            }

            MaHV_TD_comboBox.EndUpdate();
            MaHV_Xoa_comboBox.EndUpdate();
            HangVe_listView.EndUpdate();

            if (MaSB_TD_comboBox.Items.Count == 0)
            {
                MaSB_TD_comboBox.Enabled = false;
                TenSB_TD_txtBox.Enabled = false;
                ThayDoiTTSB_Btn.Enabled = false;
            } else
            {
                MaSB_TD_comboBox.Enabled = true;
                TenSB_TD_txtBox.Enabled = true;
                ThayDoiTTSB_Btn.Enabled = true;
            }

            if (MaSB_Xoa_comboBox.Items.Count < 2)
            {
                MaSB_Xoa_comboBox.Enabled = false;
                XoaSanBay_Btn.Enabled = false;
            }

            if (MaHV_TD_comboBox.Items.Count == 0)
            {
                MaHV_TD_comboBox.Enabled = false;
                TenHV_TD_txtBox.Enabled = false;
                TLGV_TD_txtBox.Enabled = false;
                ThayDoiTTHV_Btn.Enabled = false;
            } else
            {
                MaHV_TD_comboBox.Enabled = true;
                TenHV_TD_txtBox.Enabled = true;
                TLGV_TD_txtBox.Enabled = true;
                ThayDoiTTHV_Btn.Enabled = true;
            }

            if (MaHV_Xoa_comboBox.Items.Count <= 1)
            {
                MaHV_Xoa_comboBox.Enabled = false;
                XoaHangVe_Btn.Enabled = false;
            } else
            {
                MaHV_Xoa_comboBox.Enabled = true;
                XoaHangVe_Btn.Enabled = true;
            }
        }

        private void SoSBTGToiDa_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SoSBTGToiDa_chkBox.Checked)
            {
                SSBTGTD_txtBox.Enabled = true;
                SSBTGTD_txtBox.BackColor = Color.White;
            } else
            {
                SSBTGTD_txtBox.Enabled = false;
                SSBTGTD_txtBox.BackColor = Color.LightGray;
            }
        }

        private void TGBTT_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!TGBTT_chkBox.Checked)
            {
                BayToiThieu_Gio.BackColor = Color.LightGray;
                BayToiThieu_Phut.BackColor = Color.LightGray;
                BayToiThieu_Gio.Enabled = false;
                BayToiThieu_Phut.Enabled = false;
            } else
            {
                BayToiThieu_Gio.BackColor = Color.White;
                BayToiThieu_Phut.BackColor = Color.White;
                BayToiThieu_Gio.Enabled = true;
                BayToiThieu_Phut.Enabled = true;
            }
        }

        private void TGDTT_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!TGDTT_chkBox.Checked)
            {
                DungToiThieu_Gio.BackColor = Color.LightGray;
                DungToiThieu_Phut.BackColor = Color.LightGray;
                DungToiThieu_Gio.Enabled = false;
                DungToiThieu_Phut.Enabled = false;
            }
            else
            {
                DungToiThieu_Gio.BackColor = Color.White;
                DungToiThieu_Phut.BackColor = Color.White;
                DungToiThieu_Gio.Enabled = true;
                DungToiThieu_Phut.Enabled = true;
            }
        }

        private void TGDTD_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!TGDTD_chkBox.Checked)
            {
                DungToiDa_Gio.BackColor = Color.LightGray;
                DungToiDa_Phut.BackColor = Color.LightGray;
                DungToiDa_Gio.Enabled = false;
                DungToiDa_Phut.Enabled = false;
            }
            else
            {
                DungToiDa_Gio.BackColor = Color.White;
                DungToiDa_Phut.BackColor = Color.White;
                DungToiDa_Gio.Enabled = true;
                DungToiDa_Phut.Enabled = true;
            }
        }

        private void TGDVCN_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TGDVCN_chkBox.Checked)
            {
                DatVeChamNhat_txtBox.Enabled = true;
                DatVeChamNhat_txtBox.BackColor = Color.White;
            } else
            {
                DatVeChamNhat_txtBox.Enabled = false;
                DatVeChamNhat_txtBox.BackColor = Color.LightGray;
            }
        }

        private void TGHVCN_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TGHVCN_chkBox.Checked)
            {
                HuyVeChamNhat_txtBox.Enabled = true;
                HuyVeChamNhat_txtBox.BackColor = Color.White;
            }
            else
            {
                HuyVeChamNhat_txtBox.Enabled = false;
                HuyVeChamNhat_txtBox.BackColor = Color.LightGray;
            }
        }

        private void ThayDoiQuyDinhForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM THAMSO";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            info = new Parameters(dt.Rows[0]);

            SSBTGTD_txtBox.Text = info.SoSanBayTGToiDa.ToString();
            BayToiThieu_Gio.Text = info.TGBayToiThieu.Hours.ToString();
            BayToiThieu_Phut.Text = info.TGBayToiThieu.Minutes.ToString();
            DungToiThieu_Gio.Text = info.TGDungToiThieu.Hours.ToString();
            DungToiThieu_Phut.Text = info.TGDungToiThieu.Minutes.ToString();
            DungToiDa_Gio.Text = info.TGDungToiDa.Hours.ToString();
            DungToiDa_Phut.Text = info.TGDungToiDa.Minutes.ToString();
            DatVeChamNhat_txtBox.Text = info.TGDatVeChamNhat.ToString();
            HuyVeChamNhat_txtBox.Text = info.TGHuyChamNhat.ToString();
        }

        Parameters info;

        private bool check_all()
        {
            string input = SSBTGTD_txtBox.Text;

            if (SoSBTGToiDa_chkBox.Checked )
            {
                if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
                {
                    MessageBox.Show("Số sân bay trung gian bạn vừa nhập không hợp lệ!");
                    return false;
                }
            }

            if (TGBTT_chkBox.Checked)
            {
                input = BayToiThieu_Gio.Text;
                if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
                {
                    MessageBox.Show("Thời gian bay tối thiểu bạn vừa nhập không hợp lệ!");
                    return false;
                }
                else if (0 > Convert.ToInt32(input) || 23 < Convert.ToInt32(input))
                {
                    MessageBox.Show("Thời gian bay tối thiểu bạn vừa nhập không hợp lệ!");
                    return false;
                }

                input = BayToiThieu_Phut.Text;
                if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
                {
                    MessageBox.Show("Thời gian bay tối thiểu bạn vừa nhập không hợp lệ!");
                    return false;
                }
                else if (0 > Convert.ToInt32(input) || 59 < Convert.ToInt32(input))
                {
                    MessageBox.Show("Thời gian bay tối thiểu bạn vừa nhập không hợp lệ!");
                    return false;
                }
            }

            if (TGDTT_chkBox.Checked)
            {
                input = DungToiThieu_Gio.Text;
                if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
                {
                    MessageBox.Show("Thời gian dừng tối thiểu bạn vừa nhập không hợp lệ!");
                    return false;
                }
                else if (0 > Convert.ToInt32(input) || 23 < Convert.ToInt32(input))
                {
                    MessageBox.Show("Thời gian dừng tối thiểu bạn vừa nhập không hợp lệ!");
                    return false;
                }

                input = DungToiThieu_Phut.Text;
                if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
                {
                    MessageBox.Show("Thời gian dừng tối thiểu bạn vừa nhập không hợp lệ!");
                    return false;
                }
                else if (0 > Convert.ToInt32(input) || 59 < Convert.ToInt32(input))
                {
                    MessageBox.Show("Thời gian dừng tối thiểu bạn vừa nhập không hợp lệ!");
                    return false;
                }
            }

            if (TGDTD_chkBox.Checked)
            {
                input = DungToiDa_Gio.Text;
                if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
                {
                    MessageBox.Show("Thời gian dừng tối đa bạn vừa nhập không hợp lệ!");
                    return false;
                }
                else if (0 > Convert.ToInt32(input) || 23 < Convert.ToInt32(input))
                {
                    MessageBox.Show("Thời gian dừng tối đa bạn vừa nhập không hợp lệ!");
                    return false;
                }

                input = DungToiDa_Phut.Text;
                if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
                {
                    MessageBox.Show("Thời gian dừng tối đa bạn vừa nhập không hợp lệ!");
                    return false;
                }
                else if (0 > Convert.ToInt32(input) || 59 < Convert.ToInt32(input))
                {
                    MessageBox.Show("Thời gian dừng tối đa bạn vừa nhập không hợp lệ!");
                    return false;
                }
            }

            if (TGDTT_chkBox.Checked || TGDTD_chkBox.Checked) {
                input = DungToiThieu_Gio.Text + ":" + DungToiThieu_Phut.Text + ":00";
                TimeSpan Min = info.TGDungToiThieu;
                if (TGDTT_chkBox.Checked) Min = TimeSpan.Parse(input);
                input = DungToiDa_Gio.Text + ":" + DungToiDa_Phut.Text + ":00";
                TimeSpan Max = info.TGDungToiDa;
                if (TGDTD_chkBox.Checked) Max = TimeSpan.Parse(input);

                if (Min > Max)
                {
                    MessageBox.Show("Thời gian dừng tối đa phải không nhỏ hơn thời gian dừng tối thiểu!");
                    return false;
                }
            }

            if (TGDVCN_chkBox.Checked)
            {
                input = DatVeChamNhat_txtBox.Text;
                if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
                {
                    MessageBox.Show("Thời gian đặt vé chậm nhất bạn vừa nhập không hợp lệ!");
                    return false;
                }
            }

            if (TGHVCN_chkBox.Checked)
            {
                input = HuyVeChamNhat_txtBox.Text;
                if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
                {
                    MessageBox.Show("Thời gian hủy vé chậm nhất bạn vừa nhập không hợp lệ!");
                    return false;
                }
            }

            return true;
        }

        private void change_Btn_Click(object sender, EventArgs e)
        {
            if (!check_all()) return;

            int SoSanBayTGToiDa = info.SoSanBayTGToiDa;
            string TGBayToiThieu = info.TGBayToiThieu.Hours.ToString() + ":" + info.TGBayToiThieu.Minutes.ToString() + ":00";
            string TGDungToiThieu = info.TGDungToiThieu.Hours.ToString() + ":" + info.TGDungToiThieu.Minutes.ToString() + ":00";
            string TGDungToiDa = info.TGDungToiDa.Hours.ToString() + ":" + info.TGDungToiDa.Minutes.ToString() + ":00";
            int TGDatVeChamNhat = info.TGDatVeChamNhat;
            int TGHuyVeChamNhat = info.TGHuyChamNhat;

            if (SoSBTGToiDa_chkBox.Checked) SoSanBayTGToiDa = Convert.ToInt32(SSBTGTD_txtBox.Text);
            if (TGBTT_chkBox.Checked) TGBayToiThieu = BayToiThieu_Gio.Text + ":" + BayToiThieu_Phut.Text + ":00";
            if (TGDTT_chkBox.Checked) TGDungToiThieu = DungToiThieu_Gio.Text + ":" + DungToiThieu_Phut.Text + ":00";
            if (TGDTD_chkBox.Checked) TGDungToiDa = DungToiDa_Gio.Text + ":" + DungToiDa_Phut.Text + ":00";
            if (TGDVCN_chkBox.Checked) TGDatVeChamNhat = Convert.ToInt32(DatVeChamNhat_txtBox.Text);
            if (TGHVCN_chkBox.Checked) TGHuyVeChamNhat = Convert.ToInt32(HuyVeChamNhat_txtBox.Text);

            string query = "UPDATE [dbo].THAMSO SET SoSanBayTGToiDa = @SoSanBayTGToiDa , TGBayToiThieu = @TGBayToiThieu , TGDungToiThieu = @TGDungToiThieu , TGDungToiDa = @TGDungToiDa , TGDatVeChamNhat = @TGDatVeChamNhat , TGHuyChamNhat = @TGHuyVeChamNhat ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { SoSanBayTGToiDa , TGBayToiThieu , TGDungToiThieu , TGDungToiDa , TGDatVeChamNhat , TGHuyVeChamNhat });

            MessageBox.Show("Đã thay đổi các tham số khác thành công!");
        }
        
        public static bool IsUnicode(string input)
        {
            var asciiBytesCount = Encoding.ASCII.GetByteCount(input);
            var unicodBytesCount = Encoding.UTF8.GetByteCount(input);
            return asciiBytesCount != unicodBytesCount;
        }

        private void ThemSanBay_Btn_Click(object sender, EventArgs e)
        {
            string chk = MaSB_Them_txtBox.Text;
            if (chk.Length == 0 )
            {
                MessageBox.Show("Thêm sân bay: Chưa nhập mã sân bay!");
                return;
            }

            if (!chk.All(char.IsLetterOrDigit) || IsUnicode(chk))
            {
                MessageBox.Show("Thêm sân bay: Mã sân bay không đúng định dạng!");
                return;
            }

            if (chk.Length > 10)
            {
                MessageBox.Show("Thêm sân bay: Mã sân bay quá dài (tối đa 10 ký tự)!");
                return;
            }

            if (chk.Length < 3)
            {
                MessageBox.Show("Thêm sân bay: Mã sân bay quá ngắn (tối thiểu 3 ký tự)!");
                return;
            }

            string query = "SELECT * FROM [dbo].SANBAY WHERE MaSanBay = @MaSanBay ";
            if (DataProvider.Instance.ExecuteQuery(query, new object[] { chk }).Rows.Count > 0)
            {
                MessageBox.Show("Thêm sân bay: Mã sân bay đã tồn tại!");
                return;
            }

            chk = TenSB_Them_txtBox.Text;
            if (chk.Length == 0)
            {
                MessageBox.Show("Thêm sân bay: Tên sân bay không được để trống!");
                return;
            }

            string[] chk_a = TenSB_Them_txtBox.Text.Trim().Split(' ');
            foreach (string s in chk_a)
            {
                if (!s.All(char.IsLetterOrDigit))
                {
                    MessageBox.Show("Thêm sân bay: Tên sân bay không đúng định dạng!");
                    return;
                }
            }

            string insert = "INSERT INTO [dbo].SANBAY VALUES ( @MaSanBay , @TenSanBay )";
            DataProvider.Instance.ExecuteNonQuery(insert, new object[] { MaSB_Them_txtBox.Text.ToString(), TenSB_Them_txtBox.Text.ToString() });

            query = "SELECT * FROM [dbo].SANBAY";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            MaSB_TD_comboBox.BeginUpdate();
            MaSB_TD_comboBox.Items.Clear();
            MaSB_Xoa_comboBox.BeginUpdate();
            MaSB_Xoa_comboBox.Items.Clear();
            SanBay_listView.BeginUpdate();
            SanBay_listView.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                MaSB_TD_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd());
                MaSB_Xoa_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd());
                SanBay_listView.Items.Add(new ListViewItem(new string[] { dr["MaSanBay"].ToString(), dr["TenSanBay"].ToString() }));
            }

            MaSB_TD_comboBox.EndUpdate();
            MaSB_Xoa_comboBox.EndUpdate();
            SanBay_listView.EndUpdate();
            MaSB_TD_comboBox.SelectedItem = null;
            MaSB_Xoa_comboBox.SelectedItem = null;
            MaSB_TD_comboBox.Text = "";
            MaSB_Xoa_comboBox.Text = "";
            TenSB_TD_txtBox.Text = "";
            TenSB_Them_txtBox.Text = "";
            MaSB_Them_txtBox.Text = "";

            MessageBox.Show("Thêm sân bay thành công!");

            if (MaSB_TD_comboBox.Items.Count == 0)
            {
                MaSB_TD_comboBox.Enabled = false;
                TenSB_TD_txtBox.Enabled = false;
                ThayDoiTTSB_Btn.Enabled = false;
            }
            else
            {
                MaSB_TD_comboBox.Enabled = true;
                TenSB_TD_txtBox.Enabled = true;
                ThayDoiTTSB_Btn.Enabled = true;
            }

            if (MaSB_Xoa_comboBox.Items.Count < 2)
            {
                MaSB_Xoa_comboBox.Enabled = false;
                XoaSanBay_Btn.Enabled = false;
            }
        }
        private void ThayDoiTTSB_Btn_Click(object sender, EventArgs e)
        {
            if (MaSB_TD_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Thay đổi thông tin sân bay: Vui lòng chọn mã sân bay!");
                return;
            }

            if (TenSB_TD_txtBox.Text.Length == 0)
            {
                MessageBox.Show("Thay đổi thông tin sân bay: Tên sân bay không được để trống!");
                return;
            }

            string[] chk_a = TenSB_TD_txtBox.Text.Trim().Split(' ');
            foreach (string s in chk_a)
            {
                if (!s.All(char.IsLetterOrDigit))
                {
                    MessageBox.Show("Thay đổi thông tin sân bay: Tên sân bay không đúng định dạng!");
                    return;
                }
            }

            string update = "UPDATE [dbo].SANBAY SET TenSanBay = @TenSanBay WHERE MaSanBay = @MaSanBay ";
            DataProvider.Instance.ExecuteNonQuery(update, new object[] { TenSB_TD_txtBox.Text.ToString(), MaSB_TD_comboBox.SelectedItem.ToString() });

            string query = "SELECT * FROM [dbo].SANBAY";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            SanBay_listView.BeginUpdate();
            SanBay_listView.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                MaSB_TD_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd());
                MaSB_Xoa_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd());
                SanBay_listView.Items.Add(new ListViewItem(new string[] { dr["MaSanBay"].ToString(), dr["TenSanBay"].ToString() }));
            }

            SanBay_listView.EndUpdate();
            MaSB_Xoa_comboBox.SelectedItem = null;
            MaSB_Xoa_comboBox.Text = "";
            TenSB_Them_txtBox.Text = "";
            MaSB_Them_txtBox.Text = "";

            MessageBox.Show("Thay đổi thông tin sân bay thành công!");
        }

        private void MaSB_TD_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MaSB_TD_comboBox.SelectedItem == null)
            {
                TenSB_TD_txtBox.Text = string.Empty;
                return;     
            }

            string query = "SELECT TenSanBay FROM [dbo].SANBAY WHERE MaSanBay = @MaSanBay ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaSB_TD_comboBox.SelectedItem.ToString() });

            TenSB_TD_txtBox.Text = dt.Rows[0]["TenSanBay"].ToString();
        }

        private void XoaSanBay_Btn_Click(object sender, EventArgs e)
        {
            if (MaSB_Xoa_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Xóa sân bay: Vui lòng chọn mã sân bay!");
                return;
            }

            string query = "SELECT * FROM [dbo].CHUYENBAY WHERE MaSanBayDi = @MaSanBay1 OR MaSanBayDen = @MaSanBay2 ";
            if (DataProvider.Instance.ExecuteQuery(query, new object[] { MaSB_Xoa_comboBox.SelectedItem.ToString() , MaSB_Xoa_comboBox.SelectedItem.ToString() }).Rows.Count > 0)
            {
                MessageBox.Show("Không thể xóa sân bay này!");
                return;
            }

            query = "SELECT * FROM [dbo].TRUNGGIAN WHERE MaSanBay = @MaSanBay ";
            if (DataProvider.Instance.ExecuteQuery(query, new object[] { MaSB_Xoa_comboBox.SelectedItem.ToString() }).Rows.Count > 0)
            {
                MessageBox.Show("Không thể xóa sân bay này!");
                return;
            }

            string delete = "DELETE FROM [dbo].SANBAY WHERE MaSanBay = @MaSanBay ";
            DataProvider.Instance.ExecuteNonQuery(delete, new object[] { MaSB_Xoa_comboBox.SelectedItem.ToString() });

            query = "SELECT * FROM [dbo].SANBAY";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            MaSB_TD_comboBox.BeginUpdate();
            MaSB_TD_comboBox.Items.Clear();
            MaSB_Xoa_comboBox.BeginUpdate();
            MaSB_Xoa_comboBox.Items.Clear();
            SanBay_listView.BeginUpdate();
            SanBay_listView.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                MaSB_TD_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd());
                MaSB_Xoa_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd());
                SanBay_listView.Items.Add(new ListViewItem(new string[] { dr["MaSanBay"].ToString(), dr["TenSanBay"].ToString() }));
            }

            MaSB_TD_comboBox.EndUpdate();
            MaSB_Xoa_comboBox.EndUpdate();
            SanBay_listView.EndUpdate();
            MaSB_TD_comboBox.SelectedItem = null;
            MaSB_Xoa_comboBox.SelectedItem = null;
            MaSB_TD_comboBox.Text = "";
            MaSB_Xoa_comboBox.Text = "";
            TenSB_TD_txtBox.Text = "";
            TenSB_Them_txtBox.Text = "";
            MaSB_Them_txtBox.Text = "";

            MessageBox.Show("Xóa sân bay thành công!");

            if (MaSB_TD_comboBox.Items.Count == 0)
            {
                MaSB_TD_comboBox.Enabled = false;
                TenSB_TD_txtBox.Enabled = false;
                ThayDoiTTSB_Btn.Enabled = false;
            }
            else
            {
                MaSB_TD_comboBox.Enabled = true;
                TenSB_TD_txtBox.Enabled = true;
                ThayDoiTTSB_Btn.Enabled = true;
            }

            if (MaSB_Xoa_comboBox.Items.Count < 2)
            {
                MaSB_Xoa_comboBox.Enabled = false;
                XoaSanBay_Btn.Enabled = false;
            }
        }

        private void ThemHangVe_Btn_Click(object sender, EventArgs e)
        {
            string chk = MaHV_Them_txtBox.Text;
            if (chk.Length == 0)
            {
                MessageBox.Show("Thêm hạng vé: Chưa nhập mã hạng vé!");
                return;
            }

            if (!chk.All(char.IsLetterOrDigit) || IsUnicode(chk))
            {
                MessageBox.Show("Thêm hạng vé: Mã hạng vé không đúng định dạng!");
                return;
            }

            if (chk.Length > 10)
            {
                MessageBox.Show("Thêm hạng vé: Mã hạng vé quá dài (tối đa 10 ký tự)!");
                return;
            }

            if (chk.Length < 3)
            {
                MessageBox.Show("Thêm hạng vé: Mã hạng vé quá ngắn (tối thiểu 3 ký tự)!");
                return;
            }

            string query = "SELECT * FROM [dbo].HANGVE WHERE MaHangVe = @MaHangVe ";
            if (DataProvider.Instance.ExecuteQuery(query, new object[] { chk }).Rows.Count > 0)
            {
                MessageBox.Show("Thêm hạng vé: Mã hạng vé đã tồn tại!");
                return;
            }

            chk = TenHV_Them_txtBox.Text;
            if (chk.Length == 0)
            {
                MessageBox.Show("Thêm hạng vé: Tên hạng vé không được để trống!");
                return;
            }

            string[] chk_a = TenHV_Them_txtBox.Text.Trim().Split(' ');
            foreach (string s in chk_a)
            {
                if (!s.All(char.IsLetterOrDigit))
                {
                    MessageBox.Show("Thêm hạng vé: Tên hạng vé không đúng định dạng!");
                    return;
                }
            }

            chk = TLGV_Them_txtBox.Text;
            if (chk.Length == 0)
            {
                MessageBox.Show("Thêm hạng vé: Tỉ lệ giá vé không được để trống!");
                return;
            }

            Decimal TiLe;
            if (!Decimal.TryParse(chk, out TiLe))
            {
                MessageBox.Show("Thêm hạng vé: Tỉ lệ giá vé không đúng định dạng!");
                return;
            }

            if (TiLe <= 0)
            {
                MessageBox.Show("Thêm hạng vé: Tỉ lệ giá vé phải lớn hơn 0!");
                return;
            }

            string insert = "INSERT INTO [dbo].HANGVE VALUES ( @MaHangVe , @TenHangVe , @TiLeGiaVe )";
            DataProvider.Instance.ExecuteNonQuery(insert, new object[] { MaHV_Them_txtBox.Text.ToString(), TenHV_Them_txtBox.Text.ToString() , TiLe });

            query = "SELECT * FROM [dbo].HANGVE ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            MaHV_TD_comboBox.BeginUpdate();
            MaHV_TD_comboBox.Items.Clear();
            MaHV_Xoa_comboBox.BeginUpdate();
            MaHV_Xoa_comboBox.Items.Clear();
            HangVe_listView.BeginUpdate();
            HangVe_listView.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                MaHV_TD_comboBox.Items.Add(dr["MaHangVe"].ToString().TrimEnd());
                MaHV_Xoa_comboBox.Items.Add(dr["MaHangVe"].ToString().TrimEnd());
                HangVe_listView.Items.Add(new ListViewItem(new string[] { dr["MaHangVe"].ToString(), dr["TenHangVe"].ToString(), dr["TiLeGiaVe"].ToString() }));
            }

            MaHV_TD_comboBox.EndUpdate();
            MaHV_Xoa_comboBox.EndUpdate();
            HangVe_listView.EndUpdate();
            MaHV_TD_comboBox.SelectedItem = null;
            MaHV_Xoa_comboBox.SelectedItem = null;
            MaHV_TD_comboBox.Text = "";
            TenHV_TD_txtBox.Text = "";
            TLGV_TD_txtBox.Text = "";
            MaHV_Xoa_comboBox.Text = "";
            TenHV_Them_txtBox.Text = "";
            MaHV_Them_txtBox.Text = "";
            TLGV_Them_txtBox.Text = "";

            MessageBox.Show("Thêm hạng vé thành công!");

            if (MaHV_TD_comboBox.Items.Count == 0)
            {
                MaHV_TD_comboBox.Enabled = false;
                TenHV_TD_txtBox.Enabled = false;
                TLGV_TD_txtBox.Enabled = false;
                ThayDoiTTHV_Btn.Enabled = false;
            }
            else
            {
                MaHV_TD_comboBox.Enabled = true;
                TenHV_TD_txtBox.Enabled = true;
                TLGV_TD_txtBox.Enabled = true;
                ThayDoiTTHV_Btn.Enabled = true;
            }

            if (MaHV_Xoa_comboBox.Items.Count <= 1)
            {
                MaHV_Xoa_comboBox.Enabled = false;
                XoaHangVe_Btn.Enabled = false;
            }
            else
            {
                MaHV_Xoa_comboBox.Enabled = true;
                XoaHangVe_Btn.Enabled = true;
            }
        }

        private void MaHV_TD_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MaHV_TD_comboBox.SelectedItem == null)
            {
                TenHV_TD_txtBox.Text = string.Empty;
                return;
            }

            string query = "SELECT TenHangVe, TiLeGiaVe FROM [dbo].HANGVE WHERE MaHangVe = @MaHangVe ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaHV_TD_comboBox.SelectedItem.ToString() });

            TenHV_TD_txtBox.Text = dt.Rows[0]["TenHangVe"].ToString();
            TLGV_TD_txtBox.Text = dt.Rows[0]["TiLeGiaVe"].ToString();
        }

        private void ThayDoiTTHV_Btn_Click(object sender, EventArgs e)
        {
            if (MaHV_TD_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Thay đổi thông tin hạng vé: Vui lòng chọn mã hạng vé!");
                return;
            }

            if (TenHV_TD_txtBox.Text.Length == 0)
            {
                MessageBox.Show("Thay đổi thông tin hạng vé: Tên hạng vé không được để trống!");
                return;
            }

            string[] chk_a = TenHV_TD_txtBox.Text.Trim().Split(' ');
            foreach (string s in chk_a)
            {
                if (!s.All(char.IsLetterOrDigit))
                {
                    MessageBox.Show("Thay đổi thông tin hạng vé: Tên hạng vé không đúng định dạng!");
                    return;
                }
            }

            string chk = TLGV_TD_txtBox.Text;
            if (chk.Length == 0)
            {
                MessageBox.Show("Thay đổi thông tin hạng vé: Tỉ lệ giá vé không được để trống!");
                return;
            }

            Decimal TiLe;
            if (!Decimal.TryParse(chk, out TiLe))
            {
                MessageBox.Show("Thay đổi thông tin hạng vé: Tỉ lệ giá vé không đúng định dạng!");
                return;
            }

            if (TiLe <= 0)
            {
                MessageBox.Show("Thay đổi thông tin hạng vé: Tỉ lệ giá vé phải lớn hơn 0!");
                return;
            }

            string update = "UPDATE [dbo].HANGVE SET TenHangVe = @TenHangVe , TiLeGiaVe = @TiLeGiaVe WHERE MaHangVe = @MaHangVe ";
            DataProvider.Instance.ExecuteNonQuery(update, new object[] { TenHV_TD_txtBox.Text.ToString(), TiLe , MaHV_TD_comboBox.SelectedItem.ToString() });

            string query = "SELECT * FROM [dbo].HANGVE ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            HangVe_listView.BeginUpdate();
            HangVe_listView.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                HangVe_listView.Items.Add(new ListViewItem(new string[] { dr["MaHangVe"].ToString(), dr["TenHangVe"].ToString(), dr["TiLeGiaVe"].ToString() }));
            }

            HangVe_listView.EndUpdate();
            MaHV_Xoa_comboBox.SelectedItem = null;
            MaHV_Xoa_comboBox.Text = "";
            TenHV_Them_txtBox.Text = "";
            MaHV_Them_txtBox.Text = "";
            TLGV_Them_txtBox.Text = "";

            MessageBox.Show("Thay đổi thông tin hạng vé thành công!");
        }

        private void XoaHangVe_Btn_Click(object sender, EventArgs e)
        {
            if (MaHV_Xoa_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Xóa hạng vé: Vui lòng chọn mã hạng vé!");
                return;
            }

            string query = "SELECT * FROM [dbo].CT_HANGVE WHERE @MaHangVe = MaHangVe ";
            if (DataProvider.Instance.ExecuteQuery(query, new object[] { MaHV_Xoa_comboBox.SelectedItem.ToString() }).Rows.Count > 0)
            {
                MessageBox.Show("Không thể xóa hạng vé này!");
                return;
            }

            string delete = "DELETE FROM [dbo].HANGVE WHERE MaHangVe = @MaHangVe ";
            DataProvider.Instance.ExecuteNonQuery(delete, new object[] { MaHV_Xoa_comboBox.SelectedItem.ToString() });

            query = "SELECT * FROM [dbo].HANGVE ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            MaHV_TD_comboBox.BeginUpdate();
            MaHV_TD_comboBox.Items.Clear();
            MaHV_Xoa_comboBox.BeginUpdate();
            MaHV_Xoa_comboBox.Items.Clear();
            HangVe_listView.BeginUpdate();
            HangVe_listView.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                MaHV_TD_comboBox.Items.Add(dr["MaHangVe"].ToString().TrimEnd());
                MaHV_Xoa_comboBox.Items.Add(dr["MaHangVe"].ToString().TrimEnd());
                HangVe_listView.Items.Add(new ListViewItem(new string[] { dr["MaHangVe"].ToString(), dr["TenHangVe"].ToString(), dr["TiLeGiaVe"].ToString() }));
            }

            MaHV_TD_comboBox.EndUpdate();
            MaHV_Xoa_comboBox.EndUpdate();
            HangVe_listView.EndUpdate();
            MaHV_TD_comboBox.SelectedItem = null;
            MaHV_Xoa_comboBox.SelectedItem = null;
            MaHV_TD_comboBox.Text = "";
            TenHV_TD_txtBox.Text = "";
            TLGV_TD_txtBox.Text = "";
            MaHV_Xoa_comboBox.Text = "";
            TenHV_Them_txtBox.Text = "";
            MaHV_Them_txtBox.Text = "";
            TLGV_Them_txtBox.Text = "";

            MessageBox.Show("Xóa hạng vé thành công!");

            if (MaHV_TD_comboBox.Items.Count == 0)
            {
                MaHV_TD_comboBox.Enabled = false;
                TenHV_TD_txtBox.Enabled = false;
                TLGV_TD_txtBox.Enabled = false;
                ThayDoiTTHV_Btn.Enabled = false;
            }
            else
            {
                MaHV_TD_comboBox.Enabled = true;
                TenHV_TD_txtBox.Enabled = true;
                TLGV_TD_txtBox.Enabled = true;
                ThayDoiTTHV_Btn.Enabled = true;
            }

            if (MaHV_Xoa_comboBox.Items.Count <= 1)
            {
                MaHV_Xoa_comboBox.Enabled = false;
                XoaHangVe_Btn.Enabled = false;
            }
            else
            {
                MaHV_Xoa_comboBox.Enabled = true;
                XoaHangVe_Btn.Enabled = true;
            }
        }
    }
}
