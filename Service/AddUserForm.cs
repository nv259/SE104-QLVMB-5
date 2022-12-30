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

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string MaDangNhap = this.userName_txtBox.Text;
                string MaNhom = this.userRole_comboBox.Text;

                // Account
                string query = "SELECT * FROM [dbo].NGUOIDUNG WHERE MaDangNhap = @MaDangNhap";
                if (DataProvider.Instance.ExecuteQuery(query, new object[] { MaDangNhap }).Rows.Count > 0)
                {
                    MessageBox.Show("User đã tồn tại");
                    return;
                }

                query = "INSERT INTO [dbo].NGUOIDUNG VALUES ( @MaDangNhap , @MatKhau , @MaNhom , @TenNguoiDung , @DinhDanh , @SoDienThoai , @Email ,  @NgaySinh )";
                int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaDangNhap, "1A8462AD95FC28007C67106DC6667AC2637FC1E9CAE30025EF5B46C5F6E9F9312FD48661626D85610A35844E5FC658DD1F5298630138D9F67EFE3074921C41B0", MaNhom, "default", "default", "0000000000", "default@gmail.com", "01/01/2001" });

                MessageBox.Show("Đã thêm user mới!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("User đã tồn tại!");
            }
        }
    }
}
