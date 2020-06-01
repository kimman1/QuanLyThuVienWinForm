using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1
{
    public partial class FormPhieuThuTien : Form
    {
        BUS_PhieuThuTien busptt = new BUS_PhieuThuTien();
        public FormPhieuThuTien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void loadForm()
        {
            busptt.layDSPTT(GridViewPTT);
        }
        private void FormPhieuThuTien_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
