using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
namespace WindowsFormsApp1.BUS
{
    class BUS_NV
    {
        NhanVienDAO nvDAO;
        public BUS_NV()
        {
            nvDAO = new NhanVienDAO();
        }
        public void HienThiDSNV(DataGridView dg)
        {
            dg.DataSource = nvDAO.ListNV();
        }
        public void HienThiDSBC(ComboBox cb)
        {
            cb.DataSource = null;
            cb.DataSource = nvDAO.listBangCap();
            cb.DisplayMember = "TenBangCap";
            cb.ValueMember = "MaBangCap";
        }
        
        public void ThemNV(String HoTenNhanVien, DateTime NgaySinh, String DiaChi, String DienThoai, int MaBangCap)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.HoTenNhanVien = HoTenNhanVien;
            nv.NgaySinh = NgaySinh;
            nv.DiaChi = DiaChi;
            nv.DienThoai = DienThoai;
            nv.MaBangCap = MaBangCap;
            nvDAO.AddNV(nv);
        }
        public void XoaNV(int idNV)
        {
            nvDAO.DeleteNV(idNV);
        }
        public void SuaNV(int idNV, string name, DateTime NgaySinh, string address, string phone, int MaBangCap)
        {
            string ngaysinhConvert = NgaySinh.ToString("yyyy-MM-dd");
            NHANVIEN nv = new NHANVIEN();
            nv.MaNhanVien = idNV;
            nv.HoTenNhanVien = name;
            nv.NgaySinh = DateTime.Parse(ngaysinhConvert);
            nv.DiaChi = address;
            nv.DienThoai = phone;
            nv.MaBangCap = MaBangCap;
            nvDAO.EditNV(nv);
        }

    }
}
