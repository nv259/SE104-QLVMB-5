using DataAccess.DTO;
using DataAccess.DAO;
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
    public partial class UserForm : Form
    {
        private BindingSource flightList = new BindingSource();
        private BindingSource ticketList = new BindingSource();
        public UserForm(Account account = null)
        {
            InitializeComponent();
            this.account = account;

            this.username_txtBox.Text = account.MaDangNhap;
            this.fullname_txtBox.Text = account.TenNguoiDung;
            this.ID_txtBox.Text = account.DinhDanh;
            this.email_txtBox.Text = account.Email;
            this.phonenumber_txtBox.Text = account.Sdt;
            flights_Dgv.DataSource = flightList;
            Load_dtgv_flightDgv();
            Load_dtgv_ticketDgv();
            
        }

        private void Load_dtgv_flightDgv()
        {
            string query = "SELECT SB1.TenSanBay as 'Đi từ', SB2.TenSanBay as 'Đi đến', NgayGioBay as 'Thời gian khởi hành' FROM [dbo].CHUYENBAY " +
                "join [dbo].SANBAY as SB1 on CHUYENBAY.MaSanBayDi = SB1.MaSanBay " +
                "join [dbo].SANBAY as SB2 on CHUYENBAY.MaSanBayDen = SB2.MaSanBay " +
                "WHERE NgayGioBay >= GETDATE()";
            flightList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void Load_dtgv_ticketDgv()
        {
            string query = "SELECT SB1.TenSanBay as 'Đi từ', SB2.TenSanBay as 'Đi đến', TenHangVe, NgayLap, TinhTrang " +
                "FROM [dbo].CT_DATVE " +
                "join [dbo].HANGVE on CT_DATVE.MaHangVe = HANGVE.MaHangVe " +
                "join [dbo].CHUYENBAY on CT_DATVE.MaChuyenBay = CHUYENBAY.MaChuyenBay " +
                "join [dbo].SANBAY as SB1 on CHUYENBAY.MaSanBayDi = SB1.MaSanBay " +
                "join [dbo].SANBAY as SB2 on CHUYENBAY.MaSanBayDen = SB2.MaSanBay " +
                "WHERE MaNguoiDat = @MaDangNhap";
            ticketList.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { this.account.MaDangNhap});
            //int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { this.userName_txtBox.Text });

        }

        private Account account;
        public bool IsLogout = false;

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Notification", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            IsLogout = true;
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Notification", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            Application.Exit();
        }

        private void bookingTicket_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();

                DatVeForm f = new DatVeForm(this.account);
                f.ShowDialog();

                this.Show();
            }
            catch { }
        }

        private void LookUp_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            TraCuuVeMayBayForm tracuu = new TraCuuVeMayBayForm(this.account);
            tracuu.ShowDialog();

            this.Show();
        }

        private void setting_Btn_Click(object sender, EventArgs e)
        {

            this.Hide();

            UserInfoForm userInfoForm = new UserInfoForm(this.account);
            userInfoForm.ShowDialog();

            this.account = AccountDAO.Instance.GetAccountByUserName(this.account.MaDangNhap);

            this.username_txtBox.Text = account.MaDangNhap;
            this.fullname_txtBox.Text = account.TenNguoiDung;
            this.ID_txtBox.Text = account.DinhDanh;
            this.email_txtBox.Text = account.Email;
            this.phonenumber_txtBox.Text = account.Sdt;
            //flightDgv.DataSource = flightList;

            this.Show();
        }

        private void publicAnnoucementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiện chưa có thông báo nào!");
        }
    }
}
