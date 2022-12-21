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
        private Account account;
        public DatVeForm(Account account)
        {
            InitializeComponent();
            this.account = account;
            ID_txtBox.Text = account.DinhDanh;
            phone_txtBox.Text = account.Sdt;
            name_txtBox.Text = account.TenNguoiDung;
            ngSinhBox.Text = account.NgaySinh.ToString();
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
            maChuyenBay_txtBox.DataBindings.Clear();
            timeGoTxtBox.DataBindings.Clear();
            timeGoneTxtBox.DataBindings.Clear();
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

            /*try { MaSanBayDi = this.fromComboBox.Text; MaSanBayDen = this.toComboBox.Text; } catch { }*/

            DateTime ngaybaymin = Convert.ToDateTime(ngaybay + " 00:00:00.000");

            query = "SELECT cb.MaChuyenBay, sb1.TenSanBay as 'Từ', sb2.TenSanBay as 'Đến', " +
                    "convert(char(5), cb.NgayGioBay, 108) as timeGo, " +
                    "convert(char(5), cast(cb.NgayGioBay as datetime) + cast(cb.ThoiGianBay as datetime), 108) as timeGone, " +
                    "CONVERT(VARCHAR(10), cb.NgayGioBay, 111) as 'Thời gian khởi hành', cb.GiaCoBan as 'Giá cơ bản' " +
                    "FROM [dbo].CHUYENBAY cb JOIN [dbo].SANBAY sb1 ON cb.MaSanBayDi = sb1.MaSanBay " +
                    "JOIN [dbo].SANBAY sb2 ON cb.MaSanBayDen = sb2.MaSanBay " +
                    "WHERE cb.MaSanBayDi like '%" + MaSanBayDi + "%' AND cb.MaSanBayDen like '%" + MaSanBayDen + "%' AND NgayGioBay >= @ngaybaymin ";
            flightDtgv.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { ngaybaymin });
            
            flightDtgv.Columns["MaChuyenBay"].Visible = false;
            flightDtgv.Columns["TimeGo"].Visible = false;
            flightDtgv.Columns["TimeGone"].Visible = false;
            timeGoTxtBox.DataBindings.Add("Text", flightDtgv.DataSource, "TimeGo");
            timeGoneTxtBox.DataBindings.Add("Text", flightDtgv.DataSource, "TimeGone");
            maChuyenBay_txtBox.DataBindings.Add("Text", flightDtgv.DataSource, "MaChuyenBay");
            
        }

        private void ngayBayDtp_ValueChanged(object sender, EventArgs e)
        {
            modify_masanbay();

            list_flight();
        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            Bill f = new Bill(account);
            f.ShowDialog();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.toComboBox.Text = "";
            this.fromComboBox.Text = "";

            modify_masanbay();
            list_flight();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Find_Btn_Click(object sender, EventArgs e)
        {
            list_flight();
        }
    }
}
