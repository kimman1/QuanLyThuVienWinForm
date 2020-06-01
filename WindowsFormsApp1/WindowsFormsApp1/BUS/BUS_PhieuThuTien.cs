using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.BUS
{
    class BUS_PhieuThuTien
    {
        PhieuThuTienDAO pttDAO;
        public BUS_PhieuThuTien()
        {
            pttDAO = new PhieuThuTienDAO();
        }
        public void layDSPTT(DataGridView dg)
        {
            dg.DataSource = null;
            dg.DataSource = pttDAO.listPTT();
        }

    }
}
