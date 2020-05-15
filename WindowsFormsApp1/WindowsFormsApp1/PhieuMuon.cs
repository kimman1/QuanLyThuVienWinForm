using System;
using System.Data;
namespace WindowsFormsApp1
{
    class PhieuMuon
    {
        Connection con;
        public PhieuMuon()
        {
            con = new Connection();
        }
        public DataTable layDSPM()
        {
            String sql = "select PHIEUMUONSACH.MaPhieuMuon, NgayMuon, TenSach, DOCGIA.HoTenDocGia, PHIEUTHUTIEN.SoTienNo, PHIEUTHUTIEN.SoTienThu, NHANVIEN.HoTenNhanVien from PHIEUMUONSACH, CHITIETPHIEUMUON, SACH, DOCGIA, PHIEUTHUTIEN,NHANVIEN where PHIEUMUONSACH.MaPhieuMuon = CHITIETPHIEUMUON.MaPhieuMuon and CHITIETPHIEUMUON.MaSach = SACH.MaSach  and PHIEUMUONSACH.MaDocGia = DOCGIA.MaDocGia and PHIEUTHUTIEN.MaPhieuMuon = PHIEUMUONSACH.MaPhieuMuon and NHANVIEN.MaNhanVien = PHIEUTHUTIEN.MaNhanVien Order by PHIEUMUONSACH.MaPhieuMuon asc";
            DataTable dt = con.Execute(sql);
            return dt;
        }
        public DataTable layDSSach()
        {
            string sql = "select * from SACH";
            DataTable dt = con.Execute(sql);
            return dt;
        }
        public DataTable layDSDG()
        {
            string sql = "select * from DOCGIA";
            DataTable dt = con.Execute(sql);
            return dt;
        }
        public DataTable layDSNV()
        {
            string sql = "select * from NHANVIEN";
            DataTable dt = con.Execute(sql);
            return dt;
        }
        public int checkAvailable()
        {
            int returnVal = 0;
            string sql = "select * from PHIEUMUONSACH where not exists(select MaPhieuMuon from CHITIETPHIEUMUON where PHIEUMUONSACH.MaPhieuMuon = CHITIETPHIEUMUON.MaPhieuMuon)";
            DataTable dt = con.Execute(sql);
            returnVal = Int16.Parse(dt.Rows[0][0].ToString());
            return returnVal;
        }
        public int checkAvailablePHieuThuTien()
        {
            string sql = "select * from PhieuMuonSach where not exists (select MaPhieuMuon from PHIEUTHUTIEN where PHIEUMUONSACH.MaPhieuMuon = PHIEUTHUTIEN.MaPhieuMuon)";
            DataTable dt = con.Execute(sql);
            return (int)dt.Rows[0][0];
        }
        public void themPM(DateTime NgayMuon, int MaDocGia, int MaSach, int SoTienNo, int SoTienThu, int MaNV)
        {
            string sqlPM = string.Format("insert into PHIEUMUONSACH([NgayMuon],[MaDocGia]) values ('{0}','{1}')",NgayMuon,MaDocGia);
            con.ExecuteNonQuery(sqlPM);
            
            string sqlCTPM = string.Format("insert into CHITIETPHIEUMUON([MaSach], [MaPhieuMuon]) values ('{0}','{1}')",MaSach,checkAvailable());
            con.ExecuteNonQuery(sqlCTPM);

            int checkAvailablePTT = checkAvailablePHieuThuTien();

            string sqlPTT = string.Format("insert into PHIEUTHUTIEN([SoTienNo],[SoTienThu],[MaDocGia],[MaNhanVien],[MaPhieuMuon]) values ('{0}','{1}','{2}','{3}','{4}')",SoTienNo,SoTienThu,MaDocGia,MaNV,checkAvailablePTT);
            con.ExecuteNonQuery(sqlPTT);
            
        }
        public void suaPM(DateTime NgayMuon, int MaDocGia, int MaPhieuMuon, int MaSach, int SoTienNo, int SoTienThu)
        {
            string sqlPM = string.Format("update PHIEUMUONSACH set [NgayMuon] = '{0}', [MaDocGia] = '{1}' where [MaPhieuMuon] = '{2}'", NgayMuon, MaDocGia, MaPhieuMuon);
            con.ExecuteNonQuery(sqlPM);
            string sqlCTPM = string.Format("update CHITIETPHIEUMUON set [MaSach] = '{0}' where [MaPhieuMuon] = '{1}'", MaSach,MaPhieuMuon);
            con.ExecuteNonQuery(sqlCTPM);
            string sqlPTT = string.Format("update PHIEUTHUTIEN set [SoTienNo] = '{0}', [SoTienThu] = '{1}' where [MaPhieuMuon] = '{2}'", SoTienNo, SoTienThu,MaPhieuMuon);
            con.ExecuteNonQuery(sqlPTT);
        }
        public void xoaPM(int MaPhieuMuon)
        {
            string sqlPTT = string.Format("delete from PHIEUTHUTIEN where [MaPhieuMuon] = '{0}'", MaPhieuMuon);
            con.ExecuteNonQuery(sqlPTT);
            string sqlCTPM = string.Format("delete from CHITIETPHIEUMUON where [MaPhieuMuon] = '{0}'", MaPhieuMuon);
            con.ExecuteNonQuery(sqlCTPM);
            string sqlPM = string.Format("delete from PHIEUMUONSACH where [MaPhieuMuon] = '{0}'", MaPhieuMuon);
            con.ExecuteNonQuery(sqlPM);
        }
    }
}
