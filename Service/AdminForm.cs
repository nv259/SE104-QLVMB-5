using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class AdminForm : Form
    {
        private BindingSource userList = new BindingSource();
        public AdminForm()
        {
            InitializeComponent();
            user_dtgv.DataSource = userList;
            Add_Binding();
            Load_dtgv();
        }

        private void Add_Binding()
        {
            userName_txtBox.DataBindings.Add("Text", user_dtgv.DataSource, "Tên đăng nhập");
            ID_txtBox.DataBindings.Add("Text", user_dtgv.DataSource, "Định danh");
            Name_txtBox.DataBindings.Add("Text", user_dtgv.DataSource, "Họ và tên");
            phone_txtBox.DataBindings.Add("Text", user_dtgv.DataSource, "Số điện thoại");
            email_txtBox.DataBindings.Add("Text", user_dtgv.DataSource, "Email");
            userRole_comboBox.DataBindings.Add("Text", user_dtgv.DataSource, "Role");
        }

        private void Load_dtgv()
        {
            string query = "SELECT MaDangNhap as 'Tên đăng nhập', MaNhom as 'Role', TenNguoiDung as 'Họ và tên', DinhDanh as 'Định danh', SoDienThoai as 'Số điện thoại', Email FROM [dbo].NGUOIDUNG WHERE MaDangNhap like " + "'%" + DataProvider.LocDau(this.searchTxtBox.Text) + "%' ";
            userList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            Load_dtgv();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE [dbo].NGUOIDUNG SET MatKhau = N'1A8462AD95FC28007C67106DC6667AC2637FC1E9CAE30025EF5B46C5F6E9F9312FD48661626D85610A35844E5FC658DD1F5298630138D9F67EFE3074921C41B0' WHERE MaDangNhap = @MaDangNhap ";
            int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName_txtBox.Text });
            MessageBox.Show("Đã đặt lại mật khẩu thành công!");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE [dbo].NGUOIDUNG SET MaNhom = @role WHERE MaDangNhap = @MaDangNhap ";
            int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { this.userRole_comboBox.Text, this.userName_txtBox.Text });
            MessageBox.Show("Quyền User đã được thay đổi!");
            Load_dtgv();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [dbo].CT_DATVE WHERE MaDangNhap = @MaDangNhap ";
            if (DataProvider.Instance.ExecuteQuery(query, new object[] { this.userName_txtBox.Text }).Rows.Count > 0)
            {
                MessageBox.Show("Không thể xóa user này!");
                return;
            }

            query = "DELETE FROM [dbo].NGUOIDUNG WHERE MaDangNhap = @MaDangNhap ";
            int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { this.userName_txtBox.Text });
            MessageBox.Show("User đã được xóa!");
            Load_dtgv();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddUserForm f = new AddUserForm();
            f.ShowDialog();
            Load_dtgv();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Notification", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

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
    }
}
