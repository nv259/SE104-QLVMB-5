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

            flight_comboBox.BeginUpdate();
            flight_comboBox.Items.Clear();
            flight_comboBox.Items.Add("All");

            foreach (DataRow dr in dt.Rows)
            {
                flight_comboBox.Items.Add(dr["MaChuyenBay"].ToString());
            }
            flight_comboBox.EndUpdate();

            from_comboBox.BeginUpdate();
            from_comboBox.Items.Clear();
            to_comboBox.BeginUpdate();
            to_comboBox.Items.Clear();

            query = "SELECT * FROM [dbo].SANBAY ";
            dt = DataProvider.Instance.ExecuteQuery(query);

            flight_comboBox.Items.Add("All");
            from_comboBox.Items.Add("All");
            to_comboBox.Items.Add("All");

            foreach (DataRow dr in dt.Rows)
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
            flightdate_Dtp.Enabled = false;

            ListAll();
        }

        public static string get_Ma(string input)
        {
            if (input == null || input == string.Empty) return "";
            return input.Substring(0, input.IndexOf('|') - 1);
        }

        public void ListAll()
        {
            string MaChuyenBay = "All", SanBayDi = "All", SanBayDen = "All";
            if (flight_comboBox.SelectedItem != null && flight_comboBox.SelectedItem != "All") MaChuyenBay = flight_comboBox.SelectedItem.ToString();
            if (from_comboBox.SelectedItem != null && from_comboBox.SelectedItem != "All") SanBayDi = get_Ma(from_comboBox.SelectedItem.ToString());
            if (to_comboBox.SelectedItem != null && to_comboBox.SelectedItem != "All") SanBayDen = get_Ma(to_comboBox.SelectedItem.ToString());

            string MaChuyenBay1 = MaChuyenBay, SanBayDi1 = SanBayDi, SanBayDen1 = SanBayDen;

            string query = "SELECT cb.MaChuyenBay, MaSanBayDi, MaSanBayDen, NgayGioBay, ThoiGianBay, (("
                               + "SELECT SUM(cthv.SoLuong) FROM[dbo].CT_HANGVE cthv "
                               + "WHERE cb.MaChuyenBay = cthv.MaChuyenBay) - (SELECT COUNT(*) FROM[dbo].CT_DATVE ctdv "
                               + "WHERE cb.MaChuyenBay = ctdv.MaChuyenBay)) SoGheTrong, (SELECT COUNT(*) FROM[dbo].CT_DATVE ctdv "
                               + "WHERE cb.MaChuyenBay = ctdv.MaChuyenBay) SoGheDaDat "
                               + "FROM[dbo].CHUYENBAY cb "
                               + "WHERE ( @MaChuyenBay = 'All' OR @MaChuyenBay1 = cb.MaChuyenBay ) AND ( @SanBayDi = 'All' OR @SanBayDi1 = cb.MaSanBayDi ) AND ( @SanBayDen = 'All' OR @SanBayDen1 = cb.MaSanBayDen ) ";
            DataTable dt;

            if (!flightdate_chkBox.Checked)
                dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaChuyenBay, MaChuyenBay1, SanBayDi, SanBayDi1, SanBayDen, SanBayDen1 });
            else
            {
                string NgayBayMin = flightdate_Dtp.Value.Date.ToString("yyyy-MM-dd") + " 00:00:00.000";
                string NgayBayMax = flightdate_Dtp.Value.Date.ToString("yyyy-MM-dd") + " 23:59:59.999";

                query = query + " AND ( @NgayBayMin <= NgayGioBay ) AND ( NgayGioBay <= @NgayBayMax ) ";
                dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaChuyenBay, MaChuyenBay1, SanBayDi, SanBayDi1, SanBayDen, SanBayDen1 , NgayBayMin , NgayBayMax });
            }

            flight_Dgv.Rows.Clear();
            flight_Dgv.ColumnCount = 8;
            flight_Dgv.Columns[0].Name = "STT";
            flight_Dgv.Columns[1].Name = "Mã chuyến bay";
            flight_Dgv.Columns[2].Name = "Sân bay đi";
            flight_Dgv.Columns[3].Name = "Sân bay đến";
            flight_Dgv.Columns[4].Name = "Khởi hành";
            flight_Dgv.Columns[5].Name = "Thời gian bay";
            flight_Dgv.Columns[6].Name = "Số ghế trống";
            flight_Dgv.Columns[7].Name = "Số ghế đã đặt";

            for(int i = 0; i < dt.Rows.Count; ++i)
            {
                DataRow dr = dt.Rows[i];
                flight_Dgv.Rows.Add((i + 1).ToString(), dr["MaChuyenBay"].ToString().TrimEnd(), dr["MaSanBayDi"].ToString().TrimEnd(), dr["MaSanBayDen"].ToString().TrimEnd(), dr["NgayGioBay"].ToString(), dr["ThoiGianBay"].ToString(), dr["SoGheTrong"].ToString(), dr["SoGheDaDat"].ToString());
            }
        }

        private void flightdate_chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (flightdate_chkBox.Checked) flightdate_Dtp.Enabled = true;
            else flightdate_Dtp.Enabled = false;

            ListAll();
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
    }
}
