using DataAccess.DAO;
using DataAccess.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class DatVeForm : Form
    {
        private string maCB = "None";
        private Account account;
        public DatVeForm(Account account)
        {
            InitializeComponent();
            this.account = account;
            ID_txtBox.Text = account.DinhDanh;
            phone_txtBox.Text = account.Sdt;
            name_txtBox.Text = account.TenNguoiDung;
            ngSinhBox.Text = account.NgaySinh.ToString();
                
            string query = "SELECT * FROM [dbo].THAMSO ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            int tg_dat_ve_cham_nhat = int.MaxValue;

            foreach (DataRow dr in dt.Rows)
            {
                tg_dat_ve_cham_nhat = Convert.ToInt32(dr["TGDatVeChamNhat"]);
            }

            //ngayBayDtp.MinDate = DateTime.Now.AddDays(tg_dat_ve_cham_nhat);
            ngayBayDtp.Value = DateTime.Now.AddDays(tg_dat_ve_cham_nhat);

            query = "SELECT * FROM [dbo].SANBAY ";
            dt = DataProvider.Instance.ExecuteQuery(query);

            fromComboBox.BeginUpdate();
            toComboBox.BeginUpdate();
            fromComboBox.Items.Clear();
            toComboBox.Items.Clear();

            fromComboBox.Items.Add("All");
            fromComboBox.SelectedItem = "All";
            toComboBox.Items.Add("All");
            toComboBox.SelectedItem = "All";

            foreach (DataRow dr in dt.Rows)
            {
                fromComboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"].ToString());
                toComboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"].ToString());
            }

            fromComboBox.EndUpdate();
            toComboBox.EndUpdate();

            list_flight();
        }

        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_flight();
        }

        private void toComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_flight();
        }

        private void DatVeForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [dbo].THAMSO ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            int tg_dat_ve_cham_nhat = int.MaxValue;

            foreach (DataRow dr in dt.Rows)
            {
                tg_dat_ve_cham_nhat = Convert.ToInt32(dr["TGDatVeChamNhat"]);
            }

            ngayBayDtp.MinDate = DateTime.Now.AddDays(tg_dat_ve_cham_nhat);
            ngayBayDtp.Value = DateTime.Now.AddDays(tg_dat_ve_cham_nhat);

            list_flight();
        }

        public static string get_Ma(string input)
        {
            if (input == null || input == string.Empty) return "";
            return input.Substring(0, input.IndexOf('|') - 1);
        }

        private void list_flight()
        {
            string MaChuyenBay = "All", SanBayDi = "All", SanBayDen = "All";
            if (fromComboBox.SelectedItem != null && fromComboBox.SelectedItem != "All") SanBayDi = get_Ma(fromComboBox.SelectedItem.ToString());
            if (toComboBox.SelectedItem != null && toComboBox.SelectedItem != "All") SanBayDen = get_Ma(toComboBox.SelectedItem.ToString());
            string ngaybay = DateTime.Parse(ngayBayDtp.Value.ToString()).ToString("dd-MM-yyyy");

            string query = "SELECT * FROM [dbo].THAMSO ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            Parameters thamso = new Parameters();
            foreach (DataRow dr in dt.Rows)
            {
                thamso = new Parameters(dr);
                break;
            }

            string MaChuyenBay1 = MaChuyenBay, SanBayDi1 = SanBayDi, SanBayDen1 = SanBayDen;

            DateTime ngaybaymin = Convert.ToDateTime(ngaybay + " 00:00:00.000");
            if (Convert.ToDateTime(ngaybay + " 00:00:00.000") < DateTime.Now.AddDays(thamso.TGDatVeChamNhat)) ngaybaymin = DateTime.Now.AddDays(thamso.TGDatVeChamNhat);

            query = "SELECT cb.MaChuyenBay, MaSanBayDi, MaSanBayDen, NgayGioBay, GiaCoBan "
                    + "FROM[dbo].CHUYENBAY cb "
                     + "WHERE ( @MaChuyenBay = 'All' OR @MaChuyenBay1 = cb.MaChuyenBay ) AND ( @SanBayDi = 'All' OR @SanBayDi1 = cb.MaSanBayDi ) AND ( @SanBayDen = 'All' OR @SanBayDen1 = cb.MaSanBayDen ) AND NgayGioBay >= @NgayGioBay";
            
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaChuyenBay, MaChuyenBay1, SanBayDi, SanBayDi1, SanBayDen, SanBayDen1, ngaybaymin.ToString("yyyy-MM-dd HH:mm:ss")});

            flightDtgv.Rows.Clear();
            flightDtgv.ColumnCount = 6;
            flightDtgv.Columns[0].Name = "STT";
            flightDtgv.Columns[1].Name = "Mã chuyến bay";
            flightDtgv.Columns[2].Name = "Bay từ";
            flightDtgv.Columns[3].Name = "Bay đến";
            flightDtgv.Columns[4].Name = "Ngày - giờ bay";
            flightDtgv.Columns[5].Name = "Giá cơ bản";

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                DataRow dr = dt.Rows[i];
                flightDtgv.Rows.Add((i + 1).ToString(), dr["MaChuyenBay"].ToString().TrimEnd(), dr["MaSanBayDi"].ToString().TrimEnd(), dr["MaSanBayDen"].ToString().TrimEnd(), dr["NgayGioBay"].ToString(), dr["GiaCoBan"].ToString());
            }
        }

        private void ngayBayDtp_ValueChanged(object sender, EventArgs e)
        {
            list_flight();
        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            if (maCB == null || maCB == "None")
            {
                MessageBox.Show("Vui lòng chọn chuyến bay!");
                return;
            }
            
            Bill f = new Bill(account, maCB.Trim());
            f.ShowDialog();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            maCB = "None";
            toComboBox.SelectedItem = "All";
            fromComboBox.SelectedItem = "All";

            string query = "SELECT * FROM [dbo].THAMSO ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            int tg_dat_ve_cham_nhat = int.MaxValue;

            foreach (DataRow dr in dt.Rows)
            {
                tg_dat_ve_cham_nhat = Convert.ToInt32(dr["TGDatVeChamNhat"]);
            }

            ngayBayDtp.MinDate = DateTime.Now.AddDays(tg_dat_ve_cham_nhat);
            ngayBayDtp.Value = DateTime.Now.AddDays(tg_dat_ve_cham_nhat);

            list_flight();
            intermediaryDtgv.DataSource = new DataTable();
            ticketDtgv.DataSource = new DataTable();
            maChuyenBay_txtBox.Text = "";
            timeGoTxtBox.Text = "";
            timeGoneTxtBox.Text = "";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flightDtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maCB = Convert.ToString(flightDtgv.Rows[flightDtgv.SelectedRows[0].Index].Cells[1].Value);
            maChuyenBay_txtBox.Text = maCB;

            string query = "SELECT * FROM [dbo].CHUYENBAY WHERE @MaChuyenBay = MaChuyenBay ";
            DataRow dr = DataProvider.Instance.ExecuteQuery(query, new object[] { maCB }).Rows[0];

            timeGoTxtBox.Text = dr["NgayGioBay"].ToString();
            timeGoneTxtBox.Text = Convert.ToDateTime(dr["NgayGioBay"].ToString()).Add(TimeSpan.Parse(dr["ThoiGianBay"].ToString())).ToString();

            query = "SELECT sb.TenSanBay as 'Tên sân bay', tg.ThoiGianDung as 'Thời gian dừng' " +
                "from [dbo].TRUNGGIAN  tg join [dbo].SANBAY sb on tg.MaSanBay = sb.MaSanBay " +
                "where tg.MaChuyenBay = @MaChuyenBay ";

            intermediaryDtgv.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { maCB });

            query = "SELECT hv.TenHangVe as 'Tên hạng vé', hv.TiLeGiaVe as 'Tỉ lệ giá vé', cthv.SoLuong as 'Số Lượng' " +
                "from [dbo].CT_HANGVE cthv join [dbo].HANGVE hv on cthv.MaHangVe = hv.MaHangVe " +
                "where cthv.MaChuyenBay = @MaChuyenBay ";

            ticketDtgv.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { maCB });
        }

        private void Find_Btn_Click(object sender, EventArgs e)
        {
            list_flight();
        }
    }
}
