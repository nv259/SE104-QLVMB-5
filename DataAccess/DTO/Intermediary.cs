using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    internal class Intermediary
    {
        public Intermediary(DataRow dr) {
            ma_chuyen_bay = dr["MaChuyenBay"].ToString();
            ma_san_bay = dr["MaSanBay"].ToString();
            ghi_chu = dr["GhiChu"].ToString();
            thoi_gian_dung = Convert.ToDateTime(dr["ThoiGianDung"]);
        }

        private string ma_chuyen_bay, ma_san_bay, ghi_chu;
        private DateTime thoi_gian_dung;

        public string MaChuyenBay { get { return ma_chuyen_bay;} set { ma_chuyen_bay = value; } }
        public string MaSanBay { get { return ma_san_bay;} set { ma_san_bay = value; } }
        public string GhiChu { get {  return ghi_chu;} set {  ghi_chu = value; } }
        public DateTime ThoiGianDung { get { return thoi_gian_dung; } set { thoi_gian_dung = value; } }
    }
}
