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
    public partial class AdminForm : Form
    {
        private BindingSource userList = new BindingSource();
        public AdminForm()
        {
            ///MonthlyUpdate();
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
            string query = "DELETE FROM [dbo].NGUOIDUNG WHERE MaDangNhap = @MaDangNhap ";
            int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { this.userName_txtBox.Text });
            MessageBox.Show("User đã được xóa!");
            Load_dtgv();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string MaDangNhap = this.userName_txtBox.Text;
                string MaNhom = this.userRole_comboBox.Text;

                // Account
                string query = "INSERT INTO [dbo].NGUOIDUNG VALUES ( @MaDangNhap , @MatKhau , @MaNhom , @TenNguoiDung , @DinhDanh , @SoDienThoai , @Email ) ";
                int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaDangNhap, "1A8462AD95FC28007C67106DC6667AC2637FC1E9CAE30025EF5B46C5F6E9F9312FD48661626D85610A35844E5FC658DD1F5298630138D9F67EFE3074921C41B0", MaNhom, this.Name_txtBox.Text, this.ID_txtBox.Text, this.phone_txtBox.Text, this.email_txtBox.Text });

                MessageBox.Show("Đã thêm user mới!");
                Load_dtgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("User đã tồn tại!");
            }
        }

        /*        public void MonthlyUpdate()
                {
                    DateTime dt = DateTime.Now;
                    //int today_day = Convert.ToInt32(dt.Day);
                    int today_month = Convert.ToInt32(dt.Month);

                    string query = "SELECT TOP 1 (id) FROM dbo.KHTN2021 ORDER BY id DESC ";
                    int id = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));

                    query = "SELECT * FROM dbo.KHTN2021 WHERE id = @id ";
                    DataTable dtbl = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
                    DataRow row = dtbl.Rows[0];

                    #region split data
                    int db_current_income, db_current_outcome, db_num_months, db_current_charge, db_nxt_charge, db_current_month;
                    db_current_income = Convert.ToInt32(row["current_income"]);
                    db_current_outcome = Convert.ToInt32(row["current_outcome"]);
                    db_current_charge = Convert.ToInt32(row["charge"]);
                    db_nxt_charge = Convert.ToInt32(row["next_month_charge"]);
                    db_current_month = Convert.ToInt32(row["current_month"]);
                    #endregion

                    query = "SELECT COUNT(*) FROM dbo.MonthlyFunding WHERE funded = 1";
                    int num_person = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));

                    if (db_current_month == today_month)
                    {
                        return;
                    }

                    int i;

                    db_current_income += num_person * db_current_charge;
                    query = "UPDATE dbo.KHTN2021 SET current_income = @db_current_income , num_months = num_months + 1 WHERE id = @id ";
                    i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { db_current_income, id });

                    if (db_current_charge != db_nxt_charge)
                    {
                        query = "INSERT INTO dbo.KHTN2021 (charge, next_month_charge, current_month) " +
                                "VALUES ( @charge , @next_month_charge , @current_month ) ";
                        i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { db_nxt_charge, db_nxt_charge, today_month });
                        id++;
                    }

                    query = "UPDATE dbo.KHTN2021 SET current_month = @today_month WHERE id = @id ";
                    i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { today_month, id });
                    IncreaseDebt();
                    ResetFundedColumn();
                }

                void IncreaseDebt()
                {
                    string query = "SELECT MSSV FROM dbo.MonthlyFunding WHERE funded = 0 ";
                    DataTable dtbl = new DataTable();
                    dtbl = DataProvider.Instance.ExecuteQuery(query);

                    foreach (DataRow dr in dtbl.Rows)
                    {
                        int mssv = Convert.ToInt32(dr["MSSV"]);
                        query = "UPDATE dbo.MonthlyFunding SET debt = debt + 1 WHERE MSSV = @mssv ";

                        int i = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mssv });
                    }
                }

                void ResetFundedColumn()
                {
                    string query = "UPDATE dbo.MonthlyFunding SET funded = 0 ";
                    int i = DataProvider.Instance.ExecuteNonQuery(query);
                }*/
    }
}
