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
            if (ChuyenBay_comboBox.SelectedItem != null) MaChuyenBay = ChuyenBay_comboBox.SelectedItem.ToString();
            if (SanBayDi_comboBox.SelectedItem != null) SanBayDi = get_Ma(SanBayDi_comboBox.SelectedItem.ToString());
            if (SanBayDen_comboBox.SelectedItem != null) SanBayDen = get_Ma(SanBayDen_comboBox.SelectedItem.ToString());

            string MaChuyenBay1 = MaChuyenBay, SanBayDi1 = SanBayDi, SanBayDen1 = SanBayDen;

            string query = "SELECT * FROM [dbo].CHUYENBAY " +
                " WHERE ( @MaChuyenBay = 'None' OR @MaChuyenBay1 = CT_DATVE.MaChuyenBay ) AND ( @SanBayDi = 'None' OR @SanBayDi1 = CHUYENBAY.MaSanBayDi ) AND ( @SanBayDen = 'None' OR @SanBayDen1 = CHUYENBAY.MaSanBayDen ) ";
        }
    }
}
