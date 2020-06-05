using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowsFormsApp1.DAO
{
    class SachDAO
    {
        QLTVDataContext db = new QLTVDataContext();
        public IEnumerable<SACH> listSach()
        {
            var p = db.SACHes.Select(s => s);
            return p;
        }
        public void addSach(SACH sach)
        {
            bool isDuplicate = db.SACHes.Any(s => s.TacGia.Trim() == sach.TacGia.Trim() && s.TenSach.Trim() == sach.TenSach.Trim());
            if (isDuplicate != true)
            {
                db.SACHes.InsertOnSubmit(sach);
                db.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Sách thêm đã có trong kho dữ liệu!!!","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }

        }
        public int deleteSach(int idSach)
        {
            int? returnvalue = -1;
            db.deleteSach(idSach, ref returnvalue);
            return (int)returnvalue;
        }
        public List<SACH> findSach(string searchString)
        {
            string seachstring = searchString.Trim();
           var p = db.SACHes.Where(s => s.TenSach.Contains(seachstring) || s.TacGia.Contains(seachstring) || s.NhaXuatBan.Contains(seachstring)).ToList();
            return p;
        }

    }
}
