using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccess.DTO
{
    public class Decentralization
    {
        public Decentralization(DataRow dr) {
            ma_nhom = dr["MaNhom"].ToString();
            ma_chuc_nang = dr["MaChucNang"].ToString();
        }

        private string ma_nhom, ma_chuc_nang;

        public string MaNhom { get { return ma_nhom; } set { ma_nhom = value; } }
        public string MaChucNang { get { return ma_chuc_nang; } set { ma_chuc_nang = value; } }
    }
}
