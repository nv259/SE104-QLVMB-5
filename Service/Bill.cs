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
    public partial class Bill : Form
    {
        private Account acc;
        public Bill(Account acc = null, string maCB = null)
        {
            this.acc = acc;
            InitializeComponent();

            if (acc != null) 
            {
                this.name_txtBox.Text = this.acc.TenNguoiDung;
                this.ID_txtBox.Text = this.acc.DinhDanh;
                this.phone_txtBox.Text = this.acc.Sdt;
                this.email_txtBox.Text = this.acc.Email;
            }
            else {
                this.name_txtBox.Text = string.Empty;
                this.ID_txtBox.Text = string.Empty;
                this.phone_txtBox.Text = string.Empty;
                this.email_txtBox.Text = string.Empty;
            }

            string query = "SELECT TenHangVe FROM [dbo].HANGVE";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                ticket_cmbBox.Items.Add(dr["TenHangVe"].ToString());
            }

            this.cb_txtBox.Text = maCB;
        }

        private void cb_cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT GiaCoBan FROM [dbo].CHUYENBAY WHERE MaChuyenBay = @MaChuyenBay";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { this.cb_txtBox.Text.Trim() });
            decimal GiaCoBan = 1;
            foreach (DataRow dr in dt.Rows)
            {
                GiaCoBan = (decimal)dr["GiaCoBan"];
                break;
            }

            query = "SELECT TiLeGiaVe FROM [dbo].HANGVE WHERE TenHangVe = @TenHangVe";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { this.ticket_cmbBox.Text });
            double TiLe = 1;
            foreach (DataRow dr in dt.Rows)
            {
                TiLe = (double)dr["TiLeGiaVe"];
                break;
            }

            this.Cost_txtBox.Text = ((decimal) TiLe * GiaCoBan).ToString() + " vnd";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maCB = this.cb_txtBox.Text.Trim();
            string ticket_type = this.ticket_cmbBox.Text.Trim();
            string fName = this.name_txtBox.Text;
            string id = this.ID_txtBox.Text;
            string phone = this.phone_txtBox.Text;
            string email = this.email_txtBox.Text;

            string query = "SELECT SoLuong FROM [dbo].CT_HANGVE cthv JOIN [dbo].CHUYENBAY cb ON cthv.MaChuyenBay = cb.MaChuyenBay " +
                            "JOIN [dbo].HANGVE hv ON cthv.MaHangVe = hv.MaHangVe " + "WHERE cthv.MaChuyenBay = @maCB AND hv.TenHangVe = @TenHangVe";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maCB, ticket_type });

            Int16 total = 0;
            foreach (DataRow dr in dt.Rows)
            {
                total = (Int16)dr["SoLuong"];
                break;
            }

            query = "SELECT COUNT(*) AS 'sl' FROM [dbo].CT_DATVE ctdv JOIN [dbo].HANGVE hv ON ctdv.MaHangVe = hv.MaHangVe WHERE ctdv.MaChuyenBay = @maCB AND hv.TenHangVe = @TenHangVe";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maCB, ticket_type });
            int booked = 0;
            foreach (DataRow dr in dt.Rows)
            {
                booked = (int)dr["sl"];
                break;
            }

            if (total - booked <= 0)
                MessageBox.Show("Xin lỗi bạn, hạng vé bạn chọn dành cho chuyến bay này đã hết suất :(");
            else
            {
                query = "SELECT MaHangVe FROM [dbo].HANGVE WHERE TenHangVe = @TenHangVe";
                dt = DataProvider.Instance.ExecuteQuery(query, new object[] { ticket_type });
                string MaHangVe = "";
                foreach (DataRow dr in dt.Rows)
                {
                    MaHangVe = dr["MaHangVe"].ToString();
                    break;
                }

                if (acc.MaNhom == "1") // is staff
                {
                    try
                    {
                        query = "INSERT INTO [dbo].BANVE VALUES( @maCB, @MaHangVe, @NgLap, @TenKhachHang, @DinhDanh, @SoDienThoai, @Email)";
                        dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maCB, MaHangVe, this.ngDatVeBox.Text, fName, id, phone, email });
                        query = "INSERT INTO [dbo].CT_DATVE (MaChuyenBay, MaHangVe, NgayLap, TinhTrang" +
                            "VALUES( @maCB , @MaHangVe , @NgLap , @TinhTrang )";
                        dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maCB, MaHangVe, this.ngDatVeBox.Text, "Done" });
                        MessageBox.Show("Vé đã được đặt thành công!");
                    }
                    catch
                    {
                        MessageBox.Show("Error: Mỗi hành khách chỉ được đặt một vé. Hãy hủy vé cũ trước khi đặt vé mới.");
                    }

                } else // is user
                try
                {
                    query = "INSERT INTO [dbo].CT_DATVE VALUES( @maCB , @MaNgDat , @MaHangVe , @NgLap , @TinhTrang )";
                    dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maCB, acc.MaDangNhap, MaHangVe, this.ngDatVeBox.Text, "Done", });
                    MessageBox.Show("Vé đã được đặt thành công!");
                }
                catch
                {
                    MessageBox.Show("Error: Mỗi hành khách chỉ được đặt một vé. Hãy hủy vé cũ trước khi đặt vé mới.");
                }
             }
        }

        private void ngDatVeBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
