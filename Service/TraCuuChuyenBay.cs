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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Service
{
    public partial class TraCuuChuyenBay : Form
    {
        public TraCuuChuyenBay()
        {
            InitializeComponent();

            string query = "SELECT * FROM [dbo].CHUYENBAY ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            ChuyenBay_comboBox.BeginUpdate();
            ChuyenBay_comboBox.Items.Clear();
            ChuyenBay_comboBox.Items.Add("None");

            foreach (DataRow dr in dt.Rows)
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

            foreach (DataRow dr in dt.Rows)
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

        public static string get_Ma(string input)
        {
            if (input == null || input == string.Empty) return "";
            return input.Substring(0, input.IndexOf('|') - 1);
        }

        public void ListAll()
        {
            string MaChuyenBay = "None", SanBayDi = "None", SanBayDen = "None";
            if (ChuyenBay_comboBox.SelectedItem != null && ChuyenBay_comboBox.SelectedItem != "None") MaChuyenBay = ChuyenBay_comboBox.SelectedItem.ToString();
            if (SanBayDi_comboBox.SelectedItem != null && SanBayDi_comboBox.SelectedItem != "None") SanBayDi = get_Ma(SanBayDi_comboBox.SelectedItem.ToString());
            if (SanBayDi_comboBox.SelectedItem != null && SanBayDen_comboBox.SelectedItem != "None") SanBayDen = get_Ma(SanBayDen_comboBox.SelectedItem.ToString());

            string MaChuyenBay1 = MaChuyenBay, SanBayDi1 = SanBayDi, SanBayDen1 = SanBayDen;

            string query = "SELECT cb.MaChuyenBay, MaSanBayDi, MaSanBayDen, NgayGioBay, ThoiGianBay, (("
                               + "SELECT SUM(cthv.SoLuong) FROM[dbo].CT_HANGVE cthv "
                               + "WHERE cb.MaChuyenBay = cthv.MaChuyenBay) - (SELECT COUNT(*) FROM[dbo].CT_DATVE ctdv "
                               + "WHERE cb.MaChuyenBay = ctdv.MaChuyenBay)) SoGheTrong, (SELECT COUNT(*) FROM[dbo].CT_DATVE ctdv "
                               + "WHERE cb.MaChuyenBay = ctdv.MaChuyenBay) SoGheDaDat "
                               + "FROM[dbo].CHUYENBAY cb "
                               + "WHERE ( @MaChuyenBay = 'None' OR @MaChuyenBay1 = cb.MaChuyenBay ) AND ( @SanBayDi = 'None' OR @SanBayDi1 = cb.MaSanBayDi ) AND ( @SanBayDen = 'None' OR @SanBayDen1 = cb.MaSanBayDen ) ";
            DataTable dt;

            if (!NgayBay_chkBox.Checked)
                dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaChuyenBay, MaChuyenBay1, SanBayDi, SanBayDi1, SanBayDen, SanBayDen1 });
            else
            {
                string NgayBayMin = NgayBay_datetime.Value.Date.ToString("yyyy-MM-dd") + " 00:00:00.000";
                string NgayBayMax = NgayBay_datetime.Value.Date.ToString("yyyy-MM-dd") + " 23:59:59.999";

                query = query + " AND ( @NgayBayMin <= NgayGioBay ) AND ( NgayGioBay <= @NgayBayMax ) ";
                dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaChuyenBay, MaChuyenBay1, SanBayDi, SanBayDi1, SanBayDen, SanBayDen1 , NgayBayMin , NgayBayMax });
            }

            FullInfo.Rows.Clear();
            FullInfo.ColumnCount = 8;
            FullInfo.Columns[0].Name = "STT";
            FullInfo.Columns[1].Name = "Mã chuyến bay";
            FullInfo.Columns[2].Name = "Sân bay đi";
            FullInfo.Columns[3].Name = "Sân bay đến";
            FullInfo.Columns[4].Name = "Khởi hành";
            FullInfo.Columns[5].Name = "Thời gian bay";
            FullInfo.Columns[6].Name = "Số ghế trống";
            FullInfo.Columns[7].Name = "Số ghế đã đặt";

            for(int i = 0; i < dt.Rows.Count; ++i)
            {
                DataRow dr = dt.Rows[i];
                FullInfo.Rows.Add((i + 1).ToString(), dr["MaChuyenBay"].ToString().TrimEnd(), dr["MaSanBayDi"].ToString().TrimEnd(), dr["MaSanBayDen"].ToString().TrimEnd(), dr["NgayGioBay"].ToString(), dr["ThoiGianBay"].ToString(), dr["SoGheTrong"].ToString(), dr["SoGheDaDat"].ToString());
            }
        }

        private void NgayBay_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NgayBay_chkBox.Checked) NgayBay_datetime.Enabled = true;
            else NgayBay_datetime.Enabled = false;

            ListAll();
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
