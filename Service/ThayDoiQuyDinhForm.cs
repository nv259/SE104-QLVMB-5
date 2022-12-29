using DataAccess.DAO;
using DataAccess.DTO;
using System;
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
            alert_txtBox.Text = "";

            if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
            {
                alert_txtBox.Text = "Số sân bay trung gian bạn vừa nhập không hợp lệ!";
                return false;
            }

            input = BayToiThieu_Gio.Text;
            if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
            {
                alert_txtBox.Text = "Thời gian bay tối thiểu bạn vừa nhập không hợp lệ!";
                return false;
            } else if (0 > Convert.ToInt32(input) || 23 < Convert.ToInt32(input)) {
                alert_txtBox.Text = "Thời gian bay tối thiểu bạn vừa nhập không hợp lệ!";
                return false;
            }

            input = BayToiThieu_Phut.Text;
            if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
            {
                alert_txtBox.Text = "Thời gian bay tối thiểu bạn vừa nhập không hợp lệ!";
                return false;
            }
            else if (0 > Convert.ToInt32(input) || 59 < Convert.ToInt32(input))
            {
                alert_txtBox.Text = "Thời gian bay tối thiểu bạn vừa nhập không hợp lệ!";
                return false;
            }

            input = DungToiThieu_Gio.Text;
            if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
            {
                alert_txtBox.Text = "Thời gian dừng tối thiểu bạn vừa nhập không hợp lệ!";
                return false;
            }
            else if (0 > Convert.ToInt32(input) || 23 < Convert.ToInt32(input))
            {
                alert_txtBox.Text = "Thời gian dừng tối thiểu bạn vừa nhập không hợp lệ!";
                return false;
            }

            input = DungToiThieu_Phut.Text;
            if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
            {
                alert_txtBox.Text = "Thời gian dừng tối thiểu bạn vừa nhập không hợp lệ!";
                return false;
            }
            else if (0 > Convert.ToInt32(input) || 59 < Convert.ToInt32(input))
            {
                alert_txtBox.Text = "Thời gian dừng tối thiểu bạn vừa nhập không hợp lệ!";
                return false;
            }

            input = DungToiDa_Gio.Text;
            if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
            {
                alert_txtBox.Text = "Thời gian dừng tối đa bạn vừa nhập không hợp lệ!";
                return false;
            }
            else if (0 > Convert.ToInt32(input) || 23 < Convert.ToInt32(input))
            {
                alert_txtBox.Text = "Thời gian dừng tối đa bạn vừa nhập không hợp lệ!";
                return false;
            }

            input = DungToiDa_Phut.Text;
            if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
            {
                alert_txtBox.Text = "Thời gian dừng tối đa bạn vừa nhập không hợp lệ!";
                return false;
            }
            else if (0 > Convert.ToInt32(input) || 59 < Convert.ToInt32(input))
            {
                alert_txtBox.Text = "Thời gian dừng tối đa bạn vừa nhập không hợp lệ!";
                return false;
            }

            input = DungToiThieu_Gio.Text + ":" + DungToiThieu_Phut.Text + ":00";
            TimeSpan Min = TimeSpan.Parse(input);
            input = DungToiDa_Gio.Text + ":" + DungToiDa_Phut.Text + ":00";
            TimeSpan Max = TimeSpan.Parse(input);

            if (Min > Max)
            {
                alert_txtBox.Text = "Thời gian dừng tối đa phải không nhỏ hơn thời gian dừng tối thiểu!";
                return false;
            }

            input = DatVeChamNhat_txtBox.Text;
            if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
            {
                alert_txtBox.Text = "Thời gian đặt vé chậm nhất bạn vừa nhập không hợp lệ!";
                return false;
            }

            input = HuyVeChamNhat_txtBox.Text;
            if (input.Length == 0 || !input.All(char.IsDigit) || (input.Length > 1 && input[0] == '0'))
            {
                alert_txtBox.Text = "Thời gian hủy vé chậm nhất bạn vừa nhập không hợp lệ!";
                return false;
            }

            return true;
        }
        
        private void SSBTGTD_txtBox_TextChanged(object sender, EventArgs e)
        {
            check_all();
        }

        private void BayToiThieu_Gio_TextChanged(object sender, EventArgs e)
        {
            check_all();
        }

        private void BayToiThieu_Phut_TextChanged(object sender, EventArgs e)
        {
            check_all();
        }

        private void DungToiThieu_Gio_TextChanged(object sender, EventArgs e)
        {
            check_all();
        }

        private void DungToiThieu_Phut_TextChanged(object sender, EventArgs e)
        {
            check_all();
        }

        private void DungToiDa_Gio_TextChanged(object sender, EventArgs e)
        {
            check_all();
        }

        private void DungToiDa_Phut_TextChanged(object sender, EventArgs e)
        {
            check_all();
        }

        private void DatVeChamNhat_txtBox_TextChanged(object sender, EventArgs e)
        {
            check_all();
        }

        private void HuyVeChamNhat_txtBox_TextChanged(object sender, EventArgs e)
        {
            check_all();
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

            MessageBox.Show("Đã thay đổi thành công!");
            this.Close();
        }

        private void TGBayToiThieu_txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
