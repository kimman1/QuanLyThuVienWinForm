using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class NhanVien
    {
        Connection con;
        public NhanVien()
        {
            con = new Connection();
        }
        public DataTable LayDSNhanVien()
        {
            string sql = "select * from NHANVIEN ";
            DataTable dt = con.Execute(sql);
            return dt;
        }
        public DataTable LayDSBangCap()
        {
            string sql = "select * from BANGCAP";
            DataTable dt = con.Execute(sql);
            return dt;
        }
        public void ThemNV(String HoTenNhanVien, DateTime NgaySinh, String DiaChi, String DienThoai, int MaBangCap)
        {
            
            string str = string.Format("insert into NHANVIEN([HoTenNhanVien],[NgaySinh],[DiaChi],[DienThoai],[MaBangCap]) values (N'{0}','{1}',N'{2}','{3}',{4})",HoTenNhanVien,NgaySinh,DiaChi,DienThoai,MaBangCap);
            con.ExecuteNonQuery(str);
        }
        public void XoaNV(int IDNhanVien)
        {
            string sql = ("delete from NHANVIEN where MaNhanVien =") + IDNhanVien;
            con.ExecuteNonQuery(sql);
        }
        public void SuaNV(int idNhanVien,String HoTenNhanVien, DateTime NgaySinh, String DiaChi, String DienThoai, int MaBangCap)
        {
            string str = string.Format("update NHANVIEN set [HoTenNhanVien] = N'{0}', [NgaySinh] = '{1}', [DiaChi] = N'{2}', [DienThoai] = '{3}', [MaBangCap] = '{4}' where [MaNhanVien] = {5}", HoTenNhanVien,NgaySinh,DiaChi,DienThoai,MaBangCap, idNhanVien);
            con.ExecuteNonQuery(str);
        }
    }
}
