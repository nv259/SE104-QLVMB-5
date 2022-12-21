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
    public partial class TraCuuVeMayBayForm : Form
    {
        public TraCuuVeMayBayForm(Account account)
        {
            this.account = account;
            InitializeComponent();

            TenDangNhap_txtBox.Text = account.MaDangNhap;
            HoVaTen_txtBox.Text = account.TenNguoiDung;
            MaDinhDanh_txtBox.Text = account.DinhDanh;
            NgaySinh_txtBox.Text = account.NgaySinh.ToString();
            Email_txtBox.Text = account.Email;
            SoDienThoai_txtBox.Text = account.Sdt;

            string query = "SELECT * FROM [dbo].CT_DATVE WHERE MaChuyenBay = @MaChuyenBay ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { account.MaDangNhap });
            
            ChuyenBay_comboBox.BeginUpdate();
            ChuyenBay_comboBox.Items.Clear();
            ChuyenBay_comboBox.Items.Add("None");

            foreach(DataRow dr in dt.Rows)
            {
                ChuyenBay_comboBox.Items.Add(dr["MaSanBay"].ToString());
            }
            ChuyenBay_comboBox.EndUpdate();

            SanBayDi_comboBox.BeginUpdate();
            SanBayDi_comboBox.Items.Clear();
            SanBayDi_comboBox.BeginUpdate();
            SanBayDen_comboBox.Items.Clear();

            query = "SELECT * FROM [dbo].SANBAY ";
            dt = DataProvider.Instance.ExecuteQuery(query);

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
        }

        Account account;
        DataTable dt;

        private string MASANBAY(string inp)
        {
            if (inp.Length == 0 || inp == "None") return inp;
            return inp.Substring(0, inp.IndexOf('|') - 1);
        }

        private void ListAll ()
        {
            string MaChuyenBay = "None", SanBayDi = "None", SanBayDen = "None";
            if (ChuyenBay_comboBox.SelectedItem != null) MaChuyenBay = ChuyenBay_comboBox.SelectedItem.ToString();
            if (SanBayDi_comboBox.SelectedItem != null) SanBayDi = MASANBAY(SanBayDi_comboBox.SelectedItem.ToString());
            if (SanBayDen_comboBox.SelectedItem != null) SanBayDen = MASANBAY(SanBayDen_comboBox.SelectedItem.ToString());
            string NgayBay = Convert.ToDateTime(NgayBay_datetime.Value.ToString()).ToString("yyyy-MM-dd");

            string NgayBayMin = NgayBay + " 00:00:00.000";
            string NgayBayMax = NgayBay + " 23:59:59.999";

            string MaChuyenBay1 = MaChuyenBay, SanBayDi1 = SanBayDi, SanBayDen1 = SanBayDen;

            string query = "SELECT * FROM [dbo].CT_DATVE JOIN CHUYENBAY ON CHUYENBAY.MaChuyenBay = CT_DATVE.MaChuyenBay JOIN [dbo].HANGVE ON HANGVE.MaHangVe = CT_DATVE.MaHangVe " +
                " WHERE ( @MaChuyenBay = 'None' OR @MaChuyenBay1 = CT_DATVE.MaChuyenBay ) AND ( @SanBayDi = 'None' OR @SanBayDi1 = CHUYENBAY.MaSanBayDi ) AND " +
                "( @SanBayDen = 'None' OR @SanBayDen1 = CHUYENBAY.MaSanBayDen ) AND @NgayBayMin <= CHUYENBAY.NgayGioBay AND CHUYENBAY.NgayGioBay <= @NgayBayMax ";

            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaChuyenBay, MaChuyenBay1, SanBayDi, SanBayDi1, SanBayDen, SanBayDen1, NgayBayMin, NgayBayMax });

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
                FullInfo.Rows.Add(dr["MaChuyenBay"].ToString(), dr["SanBayDi"].ToString(), dr["SanBayDen"].ToString(), dr["NgayGioBay"].ToString(), dr["ThoiGianBay"].ToString(), dr["TenHangVe"].ToString(), dr["NgayLap"].ToString(), dr["TinhTrang"].ToString());
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
    }
}
