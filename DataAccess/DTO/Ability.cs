using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{ 
    internal class Ability
    {
        public Ability(DataRow dr)
        {
            ma_chuc_nang = dr["MaChucNang"].ToString();
            ten_chuc_nang = dr["TenChucNang"].ToString();
            ten_man_hinh_duoc_load = dr["TenManHinhDuocLoad"].ToString();
        }

        private string ma_chuc_nang, ten_chuc_nang, ten_man_hinh_duoc_load;
        
        public string MaChucNang { get { return ma_chuc_nang;} set { ma_chuc_nang = value; } }
        public string TenChucNang { get { return ten_chuc_nang;} set { ten_chuc_nang = value; } }
        public string TenManHinhDuocLoad { get { return ten_man_hinh_duoc_load; } set { ten_man_hinh_duoc_load = value; } }
    }
}
