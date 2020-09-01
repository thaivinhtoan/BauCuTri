using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLL
    {
        public ThanhVien Login(ThanhVien current_tv)
        {
            current_tv = new DAL.DAL().Login(current_tv);
            return current_tv;
        }

        public int GetMaTV(ThanhVien thanhVien)
        {
            int MaTV = new DAL.DAL().GetMaTV(thanhVien);
            return MaTV;
        }

        public DSUngVien[] GetDSUngViens(ThanhVien thanhVien)
        {
            return new DAL.DAL().GetDSUngViens(thanhVien);
        }

        public bool createBauChon(ThanhVien thanhVien, List<DSUngVien> dSUngViens)
        {
            return new DAL.DAL().createBauChon(thanhVien, dSUngViens);

        }
        public ThongTinCaNhan GetThongTinCaNhan(ThanhVien thanhVien)
        {
            return new DAL.DAL().GetThongTinCaNhan(thanhVien);
        }

        public List<ThongBao> GetThongBaos(ThanhVien thanhVien)
        {
            return new DAL.DAL().GetThongBaos(thanhVien);
        }

        public List<DSBauCu> GetDSBauCus(ThanhVien thanhVien)
        {
            return new DAL.DAL().GetDSBauCus(thanhVien);
        }
    }
}
