using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowsFormsApp1.DAO
{
    class PhieuMuonDAO
    {
        QLTVDataContext db = new QLTVDataContext();
        public IEnumerable<PhieuMuonViewModel> listPM()
        {
            IEnumerable<PhieuMuonViewModel> listpm = from o in db.PHIEUMUONSACHes
                                                     join p in db.DOCGIAs on o.MaDocGia equals p.MaDocGia
                                                     join a in db.NHANVIENs on o.MaNhanVien equals a.MaNhanVien
                                                   
                                                     select new PhieuMuonViewModel
                                                     {
                                                         MaPhieuMuon = o.MaPhieuMuon,
                                                         NgayMuon = (DateTime)o.NgayMuon,
                                                         HoTenDocGia = p.HoTenDocGia,
                                                         MaNhanVien = a.MaNhanVien,
                                                         TenNV = a.HoTenNhanVien
                                                     };
            return listpm;
        }
        public IEnumerable<CTPMViewModel> listCTTPM(int idPM)
        {
            //var p = db.CHITIETPHIEUMUONs.Where(s => s.MaPhieuMuon == idPM);
            IEnumerable<CTPMViewModel> listCTPM = from o in db.CHITIETPHIEUMUONs
                                                    join p in db.SACHes
                                                    on o.MaSach equals p.MaSach
                                                    where (o.MaPhieuMuon == idPM)
                                                    select new CTPMViewModel
                                                    {
                                                        MaCTPM = o.MaCTPM,
                                                        MaPhieuMuon = o.MaPhieuMuon,
                                                        MaSach = o.MaSach,
                                                        NgayTra = o.NgayTra.ToString(),
                                                        Sach = p.TenSach
                                                        
                                                    };
            return listCTPM;
        }
        public void AddPM(PHIEUMUONSACH pm)
        {
            db.PHIEUMUONSACHes.InsertOnSubmit(pm);
            db.SubmitChanges();
        }
        public void SuaPM(int MaDocGia,  int idPM)
        {
            
            var p = db.PHIEUMUONSACHes.Where(s => s.MaPhieuMuon == idPM).FirstOrDefault();
            p.MaDocGia = MaDocGia;
            db.SubmitChanges();
        }
        public int DeletePM(int idPM)
        {
            int result = db.deletePM(idPM);
            
            db.SubmitChanges();
            return result;
        }
        /****************************** Chi tiet PM**************************/
        public void AddPMDetail(CHITIETPHIEUMUON pm)
        {
            db.CHITIETPHIEUMUONs.InsertOnSubmit(pm);
            db.SubmitChanges();
        }
        public void EditPMDetail(CHITIETPHIEUMUON pm, int idCTPM)
        {
            var p = db.CHITIETPHIEUMUONs.Where(s => s.MaCTPM == idCTPM).FirstOrDefault();
            p.MaSach = pm.MaSach;
            //p.MaCTPM = pm.MaCTPM;
            //p.MaPhieuMuon = pm.MaPhieuMuon;
           // p.NgayTra = pm.NgayTra;
            db.SubmitChanges();
        }
        public void DeletePMDetail(int idPMDetails)
           {
            CHITIETPHIEUMUON p = db.CHITIETPHIEUMUONs.Where(s => s.MaCTPM == idPMDetails).FirstOrDefault();
               db.CHITIETPHIEUMUONs.DeleteOnSubmit(p);
               db.SubmitChanges();
           }
        public void GiveBookBackDetail(int idCTPM,DateTime NgayTra)
        {
            CHITIETPHIEUMUON p = db.CHITIETPHIEUMUONs.Where(s => s.MaCTPM == idCTPM).FirstOrDefault();
            p.NgayTra = NgayTra;
            db.SubmitChanges();
        }
        public List<SACH> loadCBSach()
        {
            List<SACH> listSach = db.SACHes.Select(s => s).ToList();
            return listSach;
        }
        public List<NHANVIEN> loadcbNV()
        {
            List<NHANVIEN> listNV = db.NHANVIENs.Select(s => s).ToList();
            return listNV;
        }
    }
    public class PhieuMuonViewModel
    {
        public int MaPhieuMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public string HoTenDocGia { get; set; }
        public int MaNhanVien { get; set; }
        public string TenNV { get; set; }
        /* public int SoTienNo { get; set; }
         public int SoTienThu { get; set; }
         public string HoTenNV { get; set; }
         public DateTime NgayTra { get; set; }*/
    }
    public class CTPMViewModel
    {
        public int MaCTPM { get; set; }
        public int MaPhieuMuon { get; set; }
        public int MaSach { get; set; }
        public string NgayTra { get; set; }
        public string Sach { get; set; } 
     
    }
}
