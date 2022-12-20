using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class Airport
    {
        public Airport(DataRow dr) { ma_san_bay = dr["MaSanBay"].ToString(); ten_san_bay = dr["TenSanBay"].ToString(); }

        private string ma_san_bay, ten_san_bay;

        public string MaSanBay { get { return ma_san_bay; } set { ma_san_bay = value; } }
        public string TenSanBay { get { return ten_san_bay; } set { ten_san_bay = value; } }
    }
}
