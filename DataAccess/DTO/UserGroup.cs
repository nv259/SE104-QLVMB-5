using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessq.DTO
{
    internal class UserGroup
    {
        public UserGroup(DataRow dr)
        {
            ma_nhom = dr["MaNhom"].ToString();
            ten_nhom = dr["TenNhom"].ToString();
        }

        private string ma_nhom, ten_nhom;

        public string MaNhom { get { return ma_nhom; } set { ma_nhom = value; } }
        public string TenNhom { get { return ten_nhom; } set { ten_nhom = value; } }
    }
}
