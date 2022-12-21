using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class Ticket
    {
        public Ticket(DataRow dr)
        {
            ma_hang_ve = dr["MaHangVe"].ToString();
            ten_hang_ve = dr["TenHangVe"].ToString();
            ti_le_gia_ve = Convert.ToDouble(dr["TiLeGiaVe"]);
        }

        private string ma_hang_ve, ten_hang_ve;
        private double ti_le_gia_ve;

        public string MaHangVe { get { return ma_hang_ve;} set { ma_hang_ve = value; } }
        public string TenHangVe { get { return ten_hang_ve;} set {  ten_hang_ve = value; } }
        public double TiLeGiaVe { get { return  ti_le_gia_ve; } set { ti_le_gia_ve = value; } }
    }
}
