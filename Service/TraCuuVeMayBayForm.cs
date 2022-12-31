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
    public partial class TraCuuVeMayBayForm : Form
    {
        public TraCuuVeMayBayForm(Account account)
        {
            this.account = account;
            InitializeComponent();

            string query = "SELECT * FROM [dbo].CT_DATVE WHERE MaNguoiDat = @MaDangNhap ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { account.MaDangNhap });
            
            flight_comboBox.BeginUpdate();
            flight_comboBox.Items.Clear();
            flight_comboBox.Items.Add("All");

            foreach(DataRow dr in dt.Rows)
            {
                flight_comboBox.Items.Add(dr["MaChuyenBay"].ToString());
            }
            flight_comboBox.EndUpdate();

            from_comboBox.BeginUpdate();
            from_comboBox.Items.Clear();
            from_comboBox.BeginUpdate();
            to_comboBox.Items.Clear();

            query = "SELECT * FROM [dbo].SANBAY ";
            dt = DataProvider.Instance.ExecuteQuery(query);

            from_comboBox.Items.Add("All");
            to_comboBox.Items.Add("All");

            foreach(DataRow dr in dt.Rows)
            {
                from_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"].ToString());
                to_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"].ToString());
            }

            from_comboBox.EndUpdate();
            to_comboBox.EndUpdate();

            to_comboBox.SelectedItem = "All";
            from_comboBox.SelectedItem = "All";
            flight_comboBox.SelectedItem = "All";

            flightdate_chkBox.Checked = false;
            bookingdate_chkBox.Checked = false;
            flightdate_Dtp.Enabled = false;
            bookingdate_Dtp.Enabled = false;

            ListAll();
        }

        Account account;
        DataTable dt;

        private string get_Ma(string inp)
        {
            if (inp.Length == 0 || inp == "All") return inp;
            return inp.Substring(0, inp.IndexOf('|') - 1);
        }

        private void ListAll()
        {
            string MaChuyenBay = "All", SanBayDi = "All", SanBayDen = "All";
            if (flight_comboBox.SelectedItem != null && flight_comboBox.SelectedItem != "All") MaChuyenBay = flight_comboBox.SelectedItem.ToString();
            if (from_comboBox.SelectedItem != null && from_comboBox.SelectedItem != "All") SanBayDi = get_Ma(from_comboBox.SelectedItem.ToString());
            if (from_comboBox.SelectedItem != null && to_comboBox.SelectedItem != "All") SanBayDen = get_Ma(to_comboBox.SelectedItem.ToString());

            string MaChuyenBay1 = MaChuyenBay, SanBayDi1 = SanBayDi, SanBayDen1 = SanBayDen;

            string query = "SELECT * FROM [dbo].CT_DATVE JOIN CHUYENBAY ON CHUYENBAY.MaChuyenBay = CT_DATVE.MaChuyenBay JOIN [dbo].HANGVE ON HANGVE.MaHangVe = CT_DATVE.MaHangVe " +
                " WHERE MaNguoiDat = @MaNguoiDat AND ( @MaChuyenBay = 'All' OR @MaChuyenBay1 = CT_DATVE.MaChuyenBay ) AND ( @SanBayDi = 'All' OR @SanBayDi1 = CHUYENBAY.MaSanBayDi ) AND ( @SanBayDen = 'All' OR @SanBayDen1 = CHUYENBAY.MaSanBayDen ) ";
            if (!flightdate_chkBox.Checked)
                if (!bookingdate_chkBox.Checked)
                {
                    dt = DataProvider.Instance.ExecuteQuery(query, new object[] { account.MaDangNhap, MaChuyenBay, MaChuyenBay1, SanBayDi, SanBayDi1, SanBayDen, SanBayDen1 });
                } else
                {
                    string NgayDatMin = bookingdate_Dtp.Value.Date.ToString("yyyy-MM-dd") + " 00:00:00.000";
                    string NgayDatMax = bookingdate_Dtp.Value.Date.ToString("yyyy-MM-dd") + " 23:59:59.999";

                    query = query + " AND ( @NgayDatMin <= NgayLap ) AND ( NgayLap <= @NgayDatMax ) ";
                    dt = DataProvider.Instance.ExecuteQuery(query, new object[] { account.MaDangNhap, MaChuyenBay, MaChuyenBay1, SanBayDi, SanBayDi1, SanBayDen, SanBayDen1, NgayDatMin, NgayDatMax });
                }
            else
            {
                string NgayBayMin = flightdate_Dtp.Value.Date.ToString("yyyy-MM-dd") + " 00:00:00.000";
                string NgayBayMax = flightdate_Dtp.Value.Date.ToString("yyyy-MM-dd") + " 23:59:59.999";

                query = query + " AND ( @NgayBayMin <= NgayGioBay ) AND ( NgayGioBay <= @NgayBayMax ) ";

                if (!bookingdate_chkBox.Checked)
                {
                    dt = DataProvider.Instance.ExecuteQuery(query, new object[] { account.MaDangNhap, MaChuyenBay, MaChuyenBay1, SanBayDi, SanBayDi1, SanBayDen, SanBayDen1, NgayBayMin, NgayBayMax });
                } else
                {
                    string NgayDatMin = bookingdate_Dtp.Value.Date.ToString("yyyy-MM-dd") + " 00:00:00.000";
                    string NgayDatMax = bookingdate_Dtp.Value.Date.ToString("yyyy-MM-dd") + " 23:59:59.999";

                    query = query + " AND ( @NgayDatMin <= NgayLap ) AND ( NgayLap <= @NgayDatMax ) ";
                    dt = DataProvider.Instance.ExecuteQuery(query, new object[] { account.MaDangNhap, MaChuyenBay, MaChuyenBay1, SanBayDi, SanBayDi1, SanBayDen, SanBayDen1, NgayBayMin, NgayBayMax , NgayDatMin, NgayDatMax });
                }
            }

            bookinglist_Dgv.Rows.Clear();
            bookinglist_Dgv.ColumnCount = 8;
            bookinglist_Dgv.Columns[0].Name = "Mã chuyến bay";
            bookinglist_Dgv.Columns[1].Name = "Bay từ";
            bookinglist_Dgv.Columns[2].Name = "Bay đến";
            bookinglist_Dgv.Columns[3].Name = "Ngày giờ bay";
            bookinglist_Dgv.Columns[4].Name = "Thời gian bay";
            bookinglist_Dgv.Columns[5].Name = "Hạng vé";
            bookinglist_Dgv.Columns[6].Name = "Ngày lập vé";
            bookinglist_Dgv.Columns[7].Name = "Tình trạng vé";

            foreach(DataRow dr in dt.Rows)
            {
                bookinglist_Dgv.Rows.Add(dr["MaChuyenBay"].ToString(), dr["MaSanBayDi"].ToString(), dr["MaSanBayDen"].ToString(), dr["NgayGioBay"].ToString(), dr["ThoiGianBay"].ToString(), dr["TenHangVe"].ToString(), dr["NgayLap"].ToString(), dr["TinhTrang"].ToString());
            }
        }

        private void flight_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListAll();
        }

        private void from_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListAll();
        }

        private void to_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListAll();
        }

        private void flightdate_Dtp_ValueChanged(object sender, EventArgs e)
        {
            ListAll();
        }

        private void delete_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy vé?", "Notification", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            try
            {
                string maCB = Convert.ToString(bookinglist_Dgv.Rows[bookinglist_Dgv.SelectedRows[0].Index].Cells[0].Value);

                DateTime NgayGioBay = Convert.ToDateTime(bookinglist_Dgv.Rows[bookinglist_Dgv.SelectedRows[0].Index].Cells[3].Value);
                TimeSpan chk = NgayGioBay.Subtract(DateTime.Now);

                string query = "SELECT * FROM [dbo].THAMSO ";
                dt = DataProvider.Instance.ExecuteQuery(query);

                int tg_huy_ve_cham_nhat = int.MaxValue;

                foreach (DataRow dr in dt.Rows)
                {
                    tg_huy_ve_cham_nhat = Convert.ToInt32(dr["TGHuyChamNhat"]);
                }

                if (chk.Days >= tg_huy_ve_cham_nhat)
                {

                    query = "DELETE FROM [dbo].CT_DATVE WHERE MaChuyenBay = @MaChuyenBay AND MaNguoiDat = @MaNguoiDat";
                    DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maCB, this.account.MaDangNhap });
                    ListAll();

                    MessageBox.Show("Vé đã được hủy thành công!");
                }
                else
                {
                    MessageBox.Show("Đã quá hạn hủy vé này!");
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra! Vui lòng thử lại sau!");
            }
        }

        private void flightdate_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (flightdate_chkBox.Checked) flightdate_Dtp.Enabled = true;
            else flightdate_Dtp.Enabled = false;
            ListAll();
        }

        private void bookingdate_Dtp_ValueChanged(object sender, EventArgs e)
        {
            ListAll();
        }

        private void bookingdate_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bookingdate_chkBox.Checked) bookingdate_Dtp.Enabled = true;
            else bookingdate_Dtp.Enabled = false;
            ListAll();
        }
    }
}
