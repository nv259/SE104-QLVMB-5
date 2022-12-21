using DataAccess.DAO;
using DataAccess.DTO;
using System;
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
        public DatVeForm()
        {
            InitializeComponent();
            list_flight();
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

            string query = "SELECT * FROM [dbo].SANBAY WHERE MaSanBay != @MaSanBayDi ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaSanBayDi });

            toComboBox.BeginUpdate();
            toComboBox.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                toComboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"]);
            }

            toComboBox.EndUpdate();

            list_flight();
        }

        private void toComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modify_masanbay();

            string query = "SELECT * FROM [dbo].SANBAY WHERE MaSanBay != @MaSanBayDen  ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaSanBayDen });

            fromComboBox.BeginUpdate();
            fromComboBox.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                fromComboBox.Items.Add(dr["MaSanBay"].ToString().TrimEnd() + " | " + dr["TenSanBay"]);
            }

            fromComboBox.EndUpdate();
            list_flight();
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
        }

        private void list_flight()
        {
            modify_masanbay();

            string ngaybay = DateTime.Parse(ngayBayDtp.Value.ToString()).ToString("yyyy-MM-dd");

            // GET THAMSO
            string query = "SELECT * FROM [dbo].THAMSO ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            Parameters thamso = new Parameters();
            foreach (DataRow dr in dt.Rows)
            {
                thamso = new Parameters(dr);
                break;
            }

            DateTime ngaybaymin = Convert.ToDateTime(ngaybay + " 00:00:00.000");

            query = "SELECT sb1.TenSanBay as 'Từ', sb2.TenSanBay as 'Đến', cb.ThoiGianBay as 'Thời gian khởi hành', cb.GiaCoBan as 'Giá cơ bản' " +
                    "FROM [dbo].CHUYENBAY cb JOIN [dbo].SANBAY sb1 ON cb.MaSanBayDi = sb1.MaSanBay " +
                    "JOIN [dbo].SANBAY sb2 ON cb.MaSanBayDen = sb2.MaSanBay " +
                    "WHERE cb.MaSanBayDi like '%" + MaSanBayDi + "%' AND cb.MaSanBayDen like '%" + MaSanBayDen + "%' AND NgayGioBay >= @ngaybaymin";
            flightDtgv.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { ngaybaymin });
        }

        private void ngayBayDtp_ValueChanged(object sender, EventArgs e)
        {
            modify_masanbay();

            list_flight();
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
