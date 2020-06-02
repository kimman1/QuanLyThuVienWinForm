using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
