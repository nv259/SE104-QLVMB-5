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

            SanBayDi1_listBox.BeginUpdate();
            SanBayDen1_listBox.BeginUpdate();
            SanBayDi1_listBox.Items.Clear();
            SanBayDen1_listBox.Items.Clear();
        
            foreach (DataRow dr in dt.Rows)
            {
                SanBayDi1_listBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"].ToString());
                SanBayDen1_listBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"].ToString());
            }

            SanBayDi1_listBox.EndUpdate();
            SanBayDen1_listBox.EndUpdate();

            query = "SELECT * FROM [dbo].HANGVE ";
            dt = DataProvider.Instance.ExecuteQuery(query);

            HangVe_grid.Columns.Clear();
            HangVe_grid.ColumnCount = 3;
            HangVe_grid.Columns[0].Name = "MaHangVe";
            HangVe_grid.Columns[1].Name = "TenHangVe";
            HangVe_grid.Columns[2].Name = "SoLuong";
            HangVe_grid.Columns[0].ReadOnly = true;
            HangVe_grid.Columns[1].ReadOnly = true;
            HangVe_grid.Columns[2].ValueType = typeof(int);

            foreach(DataRow dr in dt.Rows)
            {
                HangVe_grid.Rows.Add(dr["MaHangVe"].ToString(), dr["TenHangVe"].ToString(), "0");
            }

            HangVe_grid.AllowUserToAddRows = false;
            HangVe_grid.AllowUserToDeleteRows = false;
            HangVe_grid.AllowUserToOrderColumns = false;
            HangVe_grid.AllowUserToResizeColumns = false;
            HangVe_grid.AllowUserToResizeRows = false;
        }

        private bool check_all()
        {
            string query = "SELECT * FROM [dbo].THAMSO ";
            Parameter para = new Parameter(DataProvider.Instance.ExecuteQuery(query).Rows[0]);

            this.alert_txtBox.Text = "";

            if (MaChuyenBay1_txtBox.Text.Length == 0)
            {
                this.alert_txtBox.Text = "Chưa nhập mã chuyến bay!";
                return false;
            } else
            {
                if (!this.alert_txtBox.Text.All(char.IsLetterOrDigit))
                {
                    this.alert_txtBox.Text = "Mã chuyến bay không đúng định dạng!";
                    return false;
                }       
            }

            if (SanBayDi1_listBox.SelectedItem == null)
            {
                this.alert_txtBox.Text = "Chưa chọn sân bay đi!";
                return false;
            }

            if (SanBayDen1_listBox.SelectedItem == null)
            {
                this.alert_txtBox.Text = "Chưa chọn sân bay đến!";
                return false;
            }

            if (GiaVe1_txtBox.Text.Length == 0)
            {
                this.alert_txtBox.Text = "Chưa nhập giá vé!";
                return false;
            } else
            {
                decimal temp;
                if (!Decimal.TryParse(this.GiaVe1_txtBox.Text, out temp))
                {
                    this.alert_txtBox.Text = "Giá vé không đúng định dạng!";
                    return false;
                }
            }

            string chk_ngaygiobay = this.NgayGioBay1_txtBox.Text.TrimEnd();
            if (chk_ngaygiobay.Length == 0)
            {
                this.alert_txtBox.Text = "Chưa nhập ngày - giờ bay!";
                return false;
            } else
            {
                DateTime ngay_gio_bay;
                if (!DateTime.TryParseExact(chk_ngaygiobay, "dd-MM-yyyy HH:mm", null,
                DateTimeStyles.None, out ngay_gio_bay))
                {
                    this.alert_txtBox.Text = "Ngày - giờ bay không hợp lệ";
                    return false;
                }

                if (ngay_gio_bay.Subtract(DateTime.Now).Days < Math.Max(para.TGDatVeChamNhat, para.TGHuyChamNhat) + 2)
                {
                    this.alert_txtBox.Text = "Ngày - giờ bay không đảm bảo khách hàng có thể mua vé hoặc hủy vé!";
                    return false;
                }
            }

            string chk_thoigianbay = this.ThoiGianBay1_txtBox.Text.TrimEnd();
            if (chk_thoigianbay.Length == 0)
            {
                this.alert_txtBox.Text = "Chưa nhập thời gian bay!";
                return false;
            }
            else
            {
                DateTime thoigianbay;

                if (!DateTime.TryParseExact(chk_thoigianbay, "HH:mm", null,
                DateTimeStyles.None, out thoigianbay))
                {
                    this.alert_txtBox.Text = "Thời gian bay không đúng định dạng!";
                    return false;
                }

                if (thoigianbay < Convert.ToDateTime(para.TGBayToiThieu.ToString()))
                {
                    this.alert_txtBox.Text = "Thời gian bay không đáp ứng được thời gian bay tối thiểu!";
                    return false;
                }
            }

            return true;
        }

        private void MaChuyenBay1_txtBox_TextChanged(object sender, EventArgs e)
        {
            check_all();
        }

        private void LichChuyenBayForm_Load(object sender, EventArgs e)
        {

        }

        private void NgayGioBay1_txtBox_TextChanged(object sender, EventArgs e)
        {
            check_all();
        }

        private void ThoiGianBay1_txtBox_TextChanged(object sender, EventArgs e)
        {
            check_all();
        }

        private void GiaVe1_txtBox_TextChanged(object sender, EventArgs e)
        {
            check_all();
        }

        private void SanBayDi1_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_all();
        }

        private void SanBayDen1_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_all();
        }

    }
}
