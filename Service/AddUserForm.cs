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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }
        private bool IsLowerChar(char ch)
        {
            if ('a' <= ch && ch <= 'z') return true;
            return false;
        }

        private bool IsDigit(char ch)
        {
            if ('0' <= ch && ch <= '9') return true;
            return false;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            int i;
            string MaDangNhap = this.username_txtBox.Text;
            if (MaDangNhap.Length > 0)
            {
                if (!IsLowerChar(MaDangNhap[0]))
                {
                    MessageBox.Show("Tên đăng nhập không đúng định dạng!");
                    return;
                }

                for (i = 0; i < MaDangNhap.Length; ++i)
                    if (!IsDigit(MaDangNhap[i]) && !IsLowerChar(MaDangNhap[i]))
                    {
                        MessageBox.Show("Tên đăng nhập không đúng định dạng!");
                        return;
                    }

                if (MaDangNhap.Length < 3)
                {
                    MessageBox.Show("Tên đăng nhập cần ít nhất 3 kí tự!");
                    return;
                }

                if (MaDangNhap.Length > 15)
                {
                    MessageBox.Show("Tên đăng nhập chỉ được tối đa 15 kí tự!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống!");
                return;
            }

            if (userRole_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn quyền người dùng!");
                return;
            }

            MaDangNhap = this.username_txtBox.Text;
            string MaNhom = this.userRole_comboBox.Text;

            // Account
            string query = "SELECT * FROM [dbo].NGUOIDUNG WHERE MaDangNhap = @MaDangNhap";
            if (DataProvider.Instance.ExecuteQuery(query, new object[] { MaDangNhap }).Rows.Count > 0)
            {
                MessageBox.Show("User đã tồn tại");
                return;
            }

            query = "INSERT INTO [dbo].NGUOIDUNG VALUES ( @MaDangNhap , @MatKhau , @MaNhom , @TenNguoiDung , NULL , @SoDienThoai , NULL ,  @NgaySinh )";
            i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaDangNhap, "1A8462AD95FC28007C67106DC6667AC2637FC1E9CAE30025EF5B46C5F6E9F9312FD48661626D85610A35844E5FC658DD1F5298630138D9F67EFE3074921C41B0", MaNhom, "default", "0000000000", "2001-01-01" });

            MessageBox.Show("Đã thêm user mới!");
        }
    }
}
