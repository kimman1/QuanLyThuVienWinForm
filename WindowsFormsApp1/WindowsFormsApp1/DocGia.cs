using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApp1
{
    class DocGia
    {
        Connection con;
        public DocGia()
        {
            con = new Connection();
        }
        public DataTable LayDSDocGia()
        {
            string sql = "select * from DOCGIA";
            DataTable dt = con.Execute(sql);
            return dt;
        }
        public void ThemDocGia(String TenDocGia, DateTime NgaySinhDG, String DiaChiDG, String Email, DateTime NgayLapThe, DateTime NgayHetHan, int TienNo)
        {
            string sql = string.Format("insert into DOCGIA([HoTenDocGia],[NgaySinh],[DiaChi],[Email],[NgayLapThe],[NgayHetHan],[TienNo]) values (N'{0}','{1}',N'{2}','{3}','{4}','{5}',{6})",TenDocGia,NgaySinhDG,DiaChiDG,Email,NgayLapThe,NgayHetHan,TienNo);
            con.ExecuteNonQuery(sql);
            
        }
        public void SuaDocGia(String TenDocGia, DateTime NgaySinhDG, String DiaChiDG, String Email, DateTime NgayLapThe, DateTime NgayHetHan, int TienNo, int MaDocGia)
        {
            string sql = string.Format("update DOCGIA set [HoTenDocGia] = N'{0}', [NgaySinh] =  '{1}', [DiaChi]  = N'{2}', [Email] = '{3}', [NgayLapThe] = '{4}', [NgayHetHan] = '{5}', [TienNo] =  '{6}' where [MaDocGia] = '{7}' ",TenDocGia,NgaySinhDG,DiaChiDG,Email,NgayLapThe,NgayHetHan,TienNo, MaDocGia);
            con.ExecuteNonQuery(sql);

        }
        public void XoaDocGia(int IDDocGia)
        {
            string sql = ("delete from DOCGIA where MaDocGia =") + IDDocGia;
            con.ExecuteNonQuery(sql);
        }
    }
}
