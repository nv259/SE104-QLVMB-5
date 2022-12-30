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

            TenDangNhap_txtBox.Text = account.MaDangNhap;
            HoVaTen_txtBox.Text = account.TenNguoiDung;
            MaDinhDanh_txtBox.Text = account.DinhDanh;
            NgaySinh_txtBox.Text = DateOnly.FromDateTime(account.NgaySinh).ToString("dd-MM-yyyy");
            Email_txtBox.Text = account.Email;
            SoDienThoai_txtBox.Text = account.Sdt;

            string query = "SELECT * FROM [dbo].CT_DATVE WHERE MaNguoiDat = @MaDangNhap ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { account.MaDangNhap });
            
            ChuyenBay_comboBox.BeginUpdate();
            ChuyenBay_comboBox.Items.Clear();
            ChuyenBay_comboBox.Items.Add("None");

            foreach(DataRow dr in dt.Rows)
            {
                ChuyenBay_comboBox.Items.Add(dr["MaChuyenBay"].ToString());
            }
            ChuyenBay_comboBox.EndUpdate();

            SanBayDi_comboBox.BeginUpdate();
            SanBayDi_comboBox.Items.Clear();
            SanBayDi_comboBox.BeginUpdate();
            SanBayDen_comboBox.Items.Clear();

            query = "SELECT * FROM [dbo].SANBAY ";
            dt = DataProvider.Instance.ExecuteQuery(query);

            ChuyenBay_comboBox.Items.Add("None");
            SanBayDi_comboBox.Items.Add("None");
            SanBayDen_comboBox.Items.Add("None");

            foreach(DataRow dr in dt.Rows)
            {
                SanBayDi_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"].ToString());
                SanBayDen_comboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"].ToString());
            }

            SanBayDi_comboBox.EndUpdate();
            SanBayDen_comboBox.EndUpdate();

            SanBayDen_comboBox.SelectedItem = "None";
            SanBayDi_comboBox.SelectedItem = "None";
            ChuyenBay_comboBox.SelectedItem = "None";

            NgayBay_chkBox.Checked = false;
            NgayBay_datetime.Enabled = false;

            ListAll();
        }

        Account account;
        DataTable dt;

        private string get_Ma(string inp)
        {
            if (inp.Length == 0 || inp == "None") return inp;
            return inp.Substring(0, inp.IndexOf('|') - 1);
        }

        private void ListAll()
        {
            string MaChuyenBay = "None", SanBayDi = "None", SanBayDen = "None";
            if (ChuyenBay_comboBox.SelectedItem != null && ChuyenBay_comboBox.SelectedItem != "None") MaChuyenBay = ChuyenBay_comboBox.SelectedItem.ToString();
            if (SanBayDi_comboBox.SelectedItem != null && SanBayDi_comboBox.SelectedItem != "None") SanBayDi = get_Ma(SanBayDi_comboBox.SelectedItem.ToString());
            if (SanBayDi_comboBox.SelectedItem != null && SanBayDen_comboBox.SelectedItem != "None") SanBayDen = get_Ma(SanBayDen_comboBox.SelectedItem.ToString());

            string MaChuyenBay1 = MaChuyenBay, SanBayDi1 = SanBayDi, SanBayDen1 = SanBayDen;

            string query = "SELECT * FROM [dbo].CT_DATVE JOIN CHUYENBAY ON CHUYENBAY.MaChuyenBay = CT_DATVE.MaChuyenBay JOIN [dbo].HANGVE ON HANGVE.MaHangVe = CT_DATVE.MaHangVe " +
                " WHERE ( @MaChuyenBay = 'None' OR @MaChuyenBay1 = CT_DATVE.MaChuyenBay ) AND ( @SanBayDi = 'None' OR @SanBayDi1 = CHUYENBAY.MaSanBayDi ) AND ( @SanBayDen = 'None' OR @SanBayDen1 = CHUYENBAY.MaSanBayDen ) ";
            if (!NgayBay_chkBox.Checked)
                dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaChuyenBay, MaChuyenBay1, SanBayDi, SanBayDi1, SanBayDen, SanBayDen1 });
            else
            {
                string NgayBayMin = NgayBay_datetime.Value.Date.ToString("yyyy-MM-dd") + " 00:00:00.000";
                string NgayBayMax = NgayBay_datetime.Value.Date.ToString("yyyy-MM-dd") + " 23:59:59.999";

                query = query + " AND ( @NgayBayMin <= NgayGioBay ) AND ( NgayGioBay <= @NgayBayMax ) ";
                dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaChuyenBay, MaChuyenBay1, SanBayDi, SanBayDi1, SanBayDen, SanBayDen1, NgayBayMin, NgayBayMax });
            }

            FullInfo.Rows.Clear();
            FullInfo.ColumnCount = 8;
            FullInfo.Columns[0].Name = "Mã chuyến bay";
            FullInfo.Columns[1].Name = "Bay từ";
            FullInfo.Columns[2].Name = "Bay đến";
            FullInfo.Columns[3].Name = "Ngày giờ bay";
            FullInfo.Columns[4].Name = "Thời gian bay";
            FullInfo.Columns[5].Name = "Hạng vé";
            FullInfo.Columns[6].Name = "Ngày lập vé";
            FullInfo.Columns[7].Name = "Tình trạng vé";

            foreach(DataRow dr in dt.Rows)
            {
                FullInfo.Rows.Add(dr["MaChuyenBay"].ToString(), dr["MaSanBayDi"].ToString(), dr["MaSanBayDen"].ToString(), dr["NgayGioBay"].ToString(), dr["ThoiGianBay"].ToString(), dr["TenHangVe"].ToString(), dr["NgayLap"].ToString(), dr["TinhTrang"].ToString());
            }
        }

        private void ChuyenBay_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListAll();
        }

        private void SanBayDi_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListAll();
        }

        private void SanBayDen_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListAll();
        }

        private void NgayBay_datetime_ValueChanged(object sender, EventArgs e)
        {
            ListAll();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string maCB = Convert.ToString(FullInfo.Rows[FullInfo.SelectedRows[0].Index].Cells[0].Value);

            DateTime NgayGioBay = Convert.ToDateTime(FullInfo.Rows[FullInfo.SelectedRows[0].Index].Cells[3].Value);
            TimeSpan chk = NgayGioBay.Subtract(DateTime.Now);

            string query = "SELECT * FROM [dbo].THAMSO ";
            dt = DataProvider.Instance.ExecuteQuery(query);

            int tg_huy_ve_cham_nhat = int.MaxValue;

            foreach (DataRow dr in dt.Rows)
            {
                tg_huy_ve_cham_nhat = Convert.ToInt32(dr["TGHuyVeChamNhat"]);
            }

            if (chk.Days <= tg_huy_ve_cham_nhat) {

                query = "DELETE FROM [dbo].CT_DATVE WHERE MaChuyenBay = @MaChuyenBay AND MaNguoiDat = @MaNguoiDat AND DinhDanh = @DinhDanh";
                DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maCB, this.TenDangNhap_txtBox.Text, this.MaDinhDanh_txtBox.Text });
                ListAll();

                MessageBox.Show("Vé đã được hủy thành công!");
            }
            else
            {
                MessageBox.Show("Đã quá hạn hủy vé này!");
            }
        }

        private void NgayBay_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NgayBay_chkBox.Checked) NgayBay_datetime.Enabled = true;
            else NgayBay_datetime.Enabled = false;
        }
    }
}
