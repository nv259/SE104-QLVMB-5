using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class BookingDetail
    {
        public BookingDetail(DataRow dr) {
            ma_chuyen_bay = dr["MaChuyenBay"].ToString();
            ma_nguoi_dat = dr["MaNguoiDat"].ToString();
            ma_hang_ve = dr["MaHangVe"].ToString();
            tinh_trang = dr["TinhTrang"].ToString();
            ngay_lap = Convert.ToDateTime(dr["NgayLap"]);
        }

        private string ma_chuyen_bay, ma_nguoi_dat, ma_hang_ve, tinh_trang;
        private DateTime ngay_lap;
        
        public string MaChuyenBay { get { return ma_chuyen_bay; } set { ma_chuyen_bay = value; } }
        public string MaNguoiDat { get { return ma_nguoi_dat; } set { ma_nguoi_dat = value; } }
        public string MaHangVe { get { return ma_hang_ve; } set { ma_hang_ve = value; } }
        public string TinhTrang { get { return tinh_trang; } set { tinh_trang = value; } }
        public DateTime NgayLap { get { return ngay_lap; } set { ngay_lap = value; } }

    }
}
