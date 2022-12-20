using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    internal class Flight
    {
        public Flight(DataRow dr) {
            ma_chuyen_bay = dr["MaChuyenBay"].ToString();
            ma_san_bay_di = dr["MaSanBayDi"].ToString();
            ma_san_bay_den = dr["MaSanBayDen"].ToString();
            ngay_gio_bay = Convert.ToDateTime(dr["NgayGioBay"]);
            thoi_gian_bay = TimeSpan.Parse(dr["ThoiGianBay"].ToString());
            gia_co_ban = SqlMoney.Parse(dr["GiaCoBan"].ToString());
        }

        private string ma_chuyen_bay, ma_san_bay_di, ma_san_bay_den;
        private DateTime ngay_gio_bay;
        private TimeSpan thoi_gian_bay;
        private SqlMoney gia_co_ban;
        
        public string MaChuyenBay { get { return ma_chuyen_bay;  } set { ma_chuyen_bay = value; } }
        public string MaSanBayDi { get { return ma_san_bay_di; } set { ma_san_bay_di = value; } }
        public string MaSanBayDen { get { return ma_san_bay_den; } set { ma_san_bay_den = value; } }
        public DateTime NgayGiaBay { get { return ngay_gio_bay; } set { ngay_gio_bay = value; } }
        public TimeSpan ThoiGianBay { get { return thoi_gian_bay; } set { thoi_gian_bay = value; } }
        public SqlMoney GiaCoBan { get { return  gia_co_ban; } set {  gia_co_ban = value; } }
    }
}
