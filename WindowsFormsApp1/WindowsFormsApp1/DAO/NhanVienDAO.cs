using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    
    class NhanVienDAO
    {
        QLTVDataContext db = new QLTVDataContext();
        public IEnumerable<NhanVienViewModel> ListNV()
        {
            IEnumerable<NhanVienViewModel> listnv = from o in db.NHANVIENs
                                                          join p in db.BANGCAPs
                                                          on o.MaBangCap equals p.MaBangCap
                                                          select new NhanVienViewModel
                                                          {
                                                              BangCap = p.TenBangCap,
                                                              DiaChi = o.DiaChi,
                                                              HoTenNV = o.HoTenNhanVien,
                                                              NgaySinh = (DateTime)o.NgaySinh,
                                                              MaNV = o.MaNhanVien,
                                                              MaBangCap =(int) o.MaBangCap,
                                                              DienThoai = o.DienThoai
                                                              
                                                          };
            return listnv;
        }
        public List<BANGCAP> listBangCap()
        {
            var p = db.BANGCAPs.Select(s => s).ToList();
            return p;
        }
        public void DeleteNV(int idNhanVien)
        {
            var p = db.NHANVIENs.Where(s => s.MaNhanVien == idNhanVien).FirstOrDefault();
            db.NHANVIENs.DeleteOnSubmit(p);
            db.SubmitChanges();
        }
        public void AddNV(NHANVIEN nv)
        {
            /*NHANVIEN nv = new NHANVIEN();
            nv.HoTenNhanVien = HoTenNhanVien;
            nv.NgaySinh = NgaySinh;
            nv.DiaChi = DiaChi;
            nv.DienThoai = DienThoai;
            nv.MaBangCap = MaBangCap;*/
            db.NHANVIENs.InsertOnSubmit(nv);
            db.SubmitChanges();
        }
        public void EditNV(NHANVIEN nv)
        {
            var p = db.NHANVIENs.Where(s => s.MaNhanVien == nv.MaNhanVien).FirstOrDefault();
            p.HoTenNhanVien = nv.HoTenNhanVien;
            p.MaBangCap = nv.MaBangCap;
            p.NgaySinh = nv.NgaySinh;
            p.DiaChi = nv.DiaChi;
            p.DienThoai = nv.DienThoai;
            db.SubmitChanges();
        }
    }
    public class NhanVienViewModel
    {
        public int MaNV { get; set; }
        public string HoTenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string BangCap { get; set; }
        public int MaBangCap { get; set; }
        public string DienThoai { get; set; }

    }
}
