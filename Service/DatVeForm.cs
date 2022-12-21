using DataAccess.DAO;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class DatVeForm : Form
    {
        public DatVeForm()
        {
            InitializeComponent();
        }

        private string MaSanBayDi = "", MaSanBayDen = "";

        private string MaChuyenBay = "";

        private void flightListLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flightListLstBox.SelectedItem != null)
            {
                MaChuyenBay = flightListLstBox.SelectedItem.ToString();
                MaChuyenBay = MaChuyenBay.Substring(0, MaChuyenBay.IndexOf('|') - 1);
            }

            string query = "SELECT * FROM [dbo].CHUYENBAY WHERE MaChuyenBay = @MaChuyenBay ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaChuyenBay });
        }

        private void modify_masanbay()
        {
            if (fromComboBox.SelectedItem != null)
            {
                MaSanBayDi = fromComboBox.SelectedItem.ToString();
                MaSanBayDi = MaSanBayDi.Substring(0, MaSanBayDi.IndexOf('|') - 1);
            }

            if (toComboBox.SelectedItem != null)
            {
                MaSanBayDen = toComboBox.SelectedItem.ToString();
                MaSanBayDen = MaSanBayDen.Substring(0, MaSanBayDen.IndexOf('|') - 1);
            }
        }

        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modify_masanbay();

            string query = "SELECT * FROM [dbo].SANBAY WHERE MaSanBay != @MaSanBayDi AND MaSanBay != @MaSanBayDen  ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaSanBayDi, MaSanBayDen });

            toComboBox.BeginUpdate();
            toComboBox.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                toComboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"]);
            }

            toComboBox.EndUpdate();
        }

        private void toComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modify_masanbay();

            string query = "SELECT * FROM [dbo].SANBAY WHERE MaSanBay != @MaSanBayDi AND MaSanBay != @MaSanBayDen  ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaSanBayDi, MaSanBayDen });

            fromComboBox.BeginUpdate();
            fromComboBox.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                fromComboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"]);
            }

            fromComboBox.EndUpdate();
        }

        private void DatVeForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [dbo].SANBAY ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            fromComboBox.BeginUpdate();
            toComboBox.BeginUpdate();
            fromComboBox.Items.Clear();
            toComboBox.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                toComboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"]);
                fromComboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"]);
            }

            fromComboBox.EndUpdate();
            toComboBox.EndUpdate();

            query = "SELECT * FROM [dbo].THAMSO ";
            dt = DataProvider.Instance.ExecuteQuery(query);

            int tg_dat_ve_cham_nhat = int.MaxValue;

            foreach (DataRow dr in dt.Rows)
            {
                tg_dat_ve_cham_nhat = Convert.ToInt32(dr["TGDatVeChamNhat"]);
            }


            query = "SELECT * FROM [dbo].CHUYENBAY ";
            dt = DataProvider.Instance.ExecuteQuery(query);

            flightListLstBox.BeginUpdate();
            flightListLstBox.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                DateTime NgayGioBay = Convert.ToDateTime(dr["NgayGioBay"]);
                TimeSpan chk = NgayGioBay.Subtract(DateTime.Now);
                if (chk.Days >= tg_dat_ve_cham_nhat) flightListLstBox.Items.Add(dr["MaChuyenBay"].ToString().TrimEnd() + " | " + dr["MaSanBayDi"].ToString().TrimEnd() + " | " + dr["MaSanBayDen"].ToString().TrimEnd() + " | " + dr["NgayGioBay"].ToString());
            }

            flightListLstBox.EndUpdate();
        }

        private void list_flight()
        {
            modify_masanbay();

            flightListLstBox.BeginUpdate();
            flightListLstBox.Items.Clear();
            
            if (ngayBayDtp.Value == null)
            {
                flightListLstBox.EndUpdate();
                return;
            }

            string ngaybay = DateTime.Parse(ngayBayDtp.Value.ToString()).ToString("yyyy-MM-dd");

            string query = "SELECT * FROM [dbo].THAMSO ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            int tg_dat_ve_cham_nhat = int.MaxValue;

            foreach (DataRow dr in dt.Rows)
            {
                tg_dat_ve_cham_nhat = Convert.ToInt32(dr["TGDatVeChamNhat"]);
            }

            DateTime ngaybaymin = Convert.ToDateTime(ngaybay + " 00:00:00.000");
            DateTime ngaybaymax = Convert.ToDateTime(ngaybay + " 23:59:59.999");

            query = "SELECT * FROM [dbo].CHUYENBAY WHERE NgayGioBay >= @ngaybaymin AND NgayGioBay <= @ngaybaymax AND MaSanBayDi = @MaSanBayDi AND MaSanBayDen = @MaSanBayDen ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { ngaybaymin , ngaybaymax , MaSanBayDi, MaSanBayDen });

            foreach (DataRow dr in dt.Rows)
            {
                DateTime NgayGioBay = Convert.ToDateTime(dr["NgayGioBay"]);
                TimeSpan chk = NgayGioBay.Subtract(DateTime.Now);
                if (chk.Days >= tg_dat_ve_cham_nhat) flightListLstBox.Items.Add(dr["MaChuyenBay"].ToString().TrimEnd() + " | " + dr["MaSanBayDi"].ToString().TrimEnd() + " | " + dr["MaSanBayDen"].ToString().TrimEnd() + " | " + dr["NgayGioBay"].ToString());
            }

            flightListLstBox.EndUpdate();
        }

        private void ngayBayDtp_ValueChanged(object sender, EventArgs e)
        {
            modify_masanbay();
        }

        private void flightInfoLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Find_Btn_Click(object sender, EventArgs e)
        {
            list_flight();
        }
    }
}
