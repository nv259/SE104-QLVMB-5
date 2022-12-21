using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class Parameters
    {
        public Parameters(DataRow dr) {
            so_san_bay_tg_toi_da = Convert.ToInt32(dr["SoSanBayTGToiDa"]);
            tg_dat_ve_cham_nhat = Convert.ToInt32(dr["TGDatVeChamNhat"]);
            tg_huy_cham_nhat = Convert.ToInt32(dr["TGHuyChamNhat"]);
            tg_bay_toi_thieu = TimeSpan.Parse(dr["TGBayToiThieu"].ToString());
            tg_dung_toi_thieu = TimeSpan.Parse(dr["TGDungToiThieu"].ToString());
            tg_dung_toi_da = TimeSpan.Parse(dr["TGDungToiDa"].ToString());
        }

        public Parameters() { }

        private int so_san_bay_tg_toi_da, tg_dat_ve_cham_nhat, tg_huy_cham_nhat;
        private TimeSpan tg_bay_toi_thieu;
        private TimeSpan tg_dung_toi_thieu, tg_dung_toi_da;

        public int SoSanBayTGToiDa { get { return so_san_bay_tg_toi_da; } set { so_san_bay_tg_toi_da = value; } }
        public int TGDatVeChamNhat { get { return tg_dat_ve_cham_nhat; } set { tg_dat_ve_cham_nhat = value; } }
        public int TGHuyChamNhat { get { return tg_huy_cham_nhat; } set { tg_huy_cham_nhat = value; } }
        public TimeSpan TGBayToiThieu { get { return tg_bay_toi_thieu; } set { tg_bay_toi_thieu = value; } }
        public TimeSpan TGDungToiThieu { get { return tg_dung_toi_thieu; } set { tg_dung_toi_thieu = value; } }
        public TimeSpan TGDungToiDa { get { return tg_dung_toi_da; } set { tg_dung_toi_da= value; } }
    }
}
