using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    class PhieuThuTienDAO
    {
        QLTVDataContext db = new QLTVDataContext();
        public IEnumerable<PhieuThuTienViewModel> listPTT()
        {

            IEnumerable<PhieuThuTienViewModel> listptt = from o in db.PHIEUTHUTIENs
                                                  join a in db.DOCGIAs on o.MaDocGia equals a.MaDocGia
                                                  join p in db.NHANVIENs on o.MaNhanVien equals p.MaNhanVien
                                                  select new PhieuThuTienViewModel
                                                  {
                                                      MaPhieuThuTien = o.MaPhieuThuTien,
                                                      MaDocGia =  (int)o.MaDocGia,
                                                      MaNhanVien = (int)o.MaNhanVien,
                                                      TenDocGia = a.HoTenDocGia,
                                                      TenNhanVien = p.HoTenNhanVien,
                                                      NgayLapPhieuThu  = DateTime.Now
                                                  };
          
            return listptt;

        }
    }
    public class PhieuThuTienViewModel
    {
        public int MaPhieuThuTien { get; set; }
        public int MaDocGia { get; set; }
        public int MaNhanVien { get; set; }
        public string TenDocGia { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgayLapPhieuThu { get; set; }
    }
}
