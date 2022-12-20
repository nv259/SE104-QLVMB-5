using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    internal class TicketDetail
    {
        public TicketDetail(DataRow dr)
        {
            ma_hang_ve = dr["MaHangVe"].ToString();
            ma_chuyen_bay = dr["MaChuyenBay"].ToString();
            so_luong = Convert.ToInt32(dr["SoLuong"]);
        }

        private string ma_hang_ve, ma_chuyen_bay;
        private int so_luong;

        public string MaHangVe { get { return ma_hang_ve;} set { ma_hang_ve = value; } }
        public string MaChuyenBay { get {  return ma_chuyen_bay;} set { ma_chuyen_bay = value; } }
        public int SoLuong { get { return so_luong;} set { so_luong = value; } }
    }
}
