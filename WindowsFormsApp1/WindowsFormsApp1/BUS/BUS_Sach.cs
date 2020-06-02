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
    }
}
