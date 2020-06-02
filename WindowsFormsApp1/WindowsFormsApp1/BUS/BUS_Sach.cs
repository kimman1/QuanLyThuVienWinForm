using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.BUS
{
    class BUS_Sach
    {
        SachDAO sachdao;
        public BUS_Sach()
        {
            sachdao = new SachDAO();
        }
        public void HienThiDSSach(DataGridView dg)
        {
            dg.DataSource = null;
            dg.DataSource = sachdao.listSach();
        }
        public void ThemSach(string tenSach, string tacGia, DateTime NamXuatBan, string NhaXuatBan, string triGia, DateTime NgayNhap)
        {
            SACH sach = new SACH();
            sach.TenSach = tenSach;
            sach.TacGia = tacGia;
            sach.NamXuatBan = NamXuatBan;
            sach.NhaXuatBan = NhaXuatBan;
            sach.TriGia = triGia;
            sach.NgayNhap = NgayNhap;
            sachdao.addSach(sach);
        }
        public void xoaSach(int idSach)
        {
            int result = sachdao.deleteSach(idSach);
            if (result == 0 || result == -1)
            {
                MessageBox.Show("Có lỗi trong quá trình xóa. Kiểm tra Phiếu Mượn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Xóa thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
