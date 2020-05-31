using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    class DocGiaDAO
    {
        QLTVDataContext db = new QLTVDataContext();
        public List<DOCGIA> listDG()
        {
            List<DOCGIA> listdg = db.DOCGIAs.Select(s => s).ToList();
            return listdg;
        }
        public void addDG(DOCGIA dg)
        {
            db.DOCGIAs.InsertOnSubmit(dg);
            db.SubmitChanges();
        }
        public void editDG(int idDG, DOCGIA dg)
        {
            DOCGIA a = db.DOCGIAs.Where(s => s.MaDocGia == idDG).FirstOrDefault();
            a.HoTenDocGia = dg.HoTenDocGia;
            a.NgayHetHan = dg.NgayHetHan;
            a.NgayLapThe = dg.NgayLapThe;
            a.NgaySinh = dg.NgaySinh;
            a.DiaChi = dg.DiaChi;
            a.Email = dg.Email;
            a.TienNo = dg.TienNo;
            db.SubmitChanges();
        }
        public int deleteDG(int idDG)
        {
            int? result = -1; 
            db.deleteDG(idDG, ref result);
            db.SubmitChanges();
            return (int)result;
        }

    }
}
