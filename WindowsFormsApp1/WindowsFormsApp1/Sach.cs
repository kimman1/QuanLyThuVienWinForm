﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WindowsFormsApp1
{
    class Sach
    {
        Connection con;
        public Sach()
        {
            con = new Connection(); 
        }
        public DataTable LayDSSach()
        {
            string sql = "select * from SACH";
            DataTable dt = con.Execute(sql);
            return dt;
        }
        public void ThemSach(string TenSach, string TacGia, DateTime NamXuatBan, string NXB, string TriGia, DateTime NgayNhap)
        {
            string sql = string.Format("insert into SACH([TenSach],[TacGia],[NamXuatBan],[NhaXuatBan],[TriGia],[NgayNhap]) values (N'{0}',N'{1}','{2}',N'{3}','{4}','{5}')",TenSach,TacGia,NamXuatBan,NXB,TriGia,NgayNhap);
            con.ExecuteNonQuery(sql);
        }
        public void SuaSach(string TenSach, string TacGia, DateTime NamXuatBan, string NXB, string TriGia, DateTime NgayNhap, int idSach)
        {
            string namxuatban = NamXuatBan.ToString("yyyy-MM-dd");
            string ngaynhap = NgayNhap.ToString("yyyy-MM-dd");
            string sql = string.Format("update SACH set [TenSach] = N'{0}', [TacGia] = N'{1}', [NamXuatBan] = '{2}', [NhaXuatBan] = N'{3}',[TriGia] = '{4}',[NgayNhap] =  '{5}' where [MaSach] = '{6}' ", TenSach,TacGia,namxuatban,NXB,TriGia,ngaynhap,idSach);
            con.ExecuteNonQuery(sql);
        }
        public void XoaSach(int idSach)
        {
            string sql = ("delete from SACH where MaSach =") + idSach;
            con.ExecuteNonQuery(sql);
        }

        public DataTable TimKiemSach(string seachString)
        {
            string sql = "select * from SACH where TenSach like '%" + seachString + "%'";
            DataTable dt =  con.Execute(sql);
            return dt;
        }
        
    }
}
