using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.Common;
namespace WindowsFormsApp1.BUS
{
    class BUS_DG
    {
        DocGiaDAO dgDAO = new DocGiaDAO();
        MessClass mess = new MessClass();
        public void HienThiDG(DataGridView dg)
        {
            dg.DataSource = null;
            dg.DataSource = dgDAO.listDG();
        }
        public void ThemDG(string HoTenDG, DateTime NgaySinh, string DiaChi, string email, DateTime NgayLapThe, DateTime NgayHetHan, string TienNo)
        {
            DOCGIA dg = new DOCGIA();
            dg.HoTenDocGia = HoTenDG;
            dg.NgaySinh = NgaySinh;
            dg.DiaChi = DiaChi;
            dg.Email = email;
            dg.NgayLapThe = NgayLapThe;
            dg.NgayHetHan = NgayHetHan;
            dg.TienNo = int.Parse(TienNo);
            dgDAO.addDG(dg);
        }
        public void SuaDG(int idDG,string HoTenDG, DateTime NgaySinh, string DiaChi, string email, DateTime NgayLapThe, DateTime NgayHetHan, string TienNo)
        {
            DOCGIA dg = new DOCGIA();
            dg.HoTenDocGia = HoTenDG;
            dg.NgaySinh = NgaySinh;
            dg.DiaChi = DiaChi;
            dg.Email = email;
            dg.NgayLapThe = NgayLapThe;
            dg.NgayHetHan = NgayHetHan;
            dg.TienNo = int.Parse(TienNo);
            dgDAO.editDG(idDG, dg);
        }
        public void XoaDG(int idDG)
        {
            int result = dgDAO.deleteDG(idDG);
            
            if (result == 0)
            {
                mess.ErrorMessage("Có lỗi trong quá trình xóa. Kiểm tra Phiếu Mượn", "Error");
               
            }
            else
            {
                mess.InfoMessage("Xoá thành công", "Information");
               
            }
        }
    }
}
