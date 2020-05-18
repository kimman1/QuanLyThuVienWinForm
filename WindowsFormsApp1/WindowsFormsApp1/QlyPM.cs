using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QlyPM : Form
    {
        int id;
        public QlyPM()
        {
            InitializeComponent();
        }
        private void loadPM()
        {
            //LVPM.Items.Clear();
            PhieuMuon pm = new PhieuMuon();
            DataTable dt = pm.layDSPM();
            GridViewPM.DataSource = dt;
           
        }
        private void loadCBSach()
        {
            cbTenSach.DataSource = null;
            PhieuMuon pm = new PhieuMuon();
            DataTable dt = pm.layDSSach();
            cbTenSach.DataSource = dt;
            cbTenSach.DisplayMember = "TenSach";
            cbTenSach.ValueMember = "MaSach";
            

        }
        private void loadCBNV()
        {
            //cbHoTenNV.Items.Clear();
            cbHoTenNV.DataSource = null;
            PhieuMuon pm = new PhieuMuon();
            DataTable dt = pm.layDSNV();
            cbHoTenNV.DisplayMember = "HoTenNhanVien";
            cbHoTenNV.ValueMember = "MaNhanVien";
            cbHoTenNV.DataSource = dt;
        }
        private void loadCBDocGia()
        {
           // cbHoTenDocGia.Items.Clear();
            cbHoTenDocGia.DataSource = null;
            PhieuMuon pm = new PhieuMuon();
            DataTable dt = pm.layDSDG();
         
            cbHoTenDocGia.DisplayMember = "HoTenDocGia";
            cbHoTenDocGia.ValueMember = "MaDocGia";
            cbHoTenDocGia.DataSource = dt;
        }
        private void setNullForText()
        {
            txtSoTienThu.Clear();
            txtTienNo.Clear();
            datePickerNM.Value = DateTime.Now;
            loadCBDocGia();
            loadCBNV();
            loadCBSach();
        }

        private void QlyPM_Load(object sender, EventArgs e)
        {
            setNullForText();
            loadPM();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {

            DialogResult dlrs = MessageBox.Show("Bạn có chắc chắn muốn thoát !", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlrs == DialogResult.Yes)
            {
                this.Close();
            }
            if (dlrs == DialogResult.No)
            {
                return;
            }
        }

       

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            
            PhieuMuon pm = new PhieuMuon();
            pm.xoaPM(id);
            setNullForText();
            loadPM();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            int MaDocGia = 0 ;
            int MaSach = 0;
            int MaNV = 0;
            PhieuMuon pm = new PhieuMuon();
            
            DataRowView rowDocGia = (DataRowView)cbHoTenDocGia.SelectedItem;
            if (rowDocGia != null)
            {
                 MaDocGia = (int)rowDocGia[0];
            }
            DataRowView rowSach = (DataRowView)cbTenSach.SelectedItem;
            if (rowSach != null)
            {
                MaSach = (int)rowSach[0];
            }
            DataRowView rowNV = (DataRowView)cbHoTenNV.SelectedItem;
            if (rowNV != null)
            {
                MaNV = (int)rowNV[0];
            }
            pm.themPM(datePickerNM.Value, MaDocGia ,MaSach,Int32.Parse(txtTienNo.Text),Int32.Parse(txtSoTienThu.Text),MaNV);
              setNullForText();
              loadPM();
          
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            int MaDocGia = 0;
            int MaSach = 0;
   
            DataRowView rowDocGia = (DataRowView)cbHoTenDocGia.SelectedItem;
            if (rowDocGia != null)
            {
                MaDocGia = (int)rowDocGia[0];
            }
            DataRowView rowSach = (DataRowView)cbTenSach.SelectedItem;
            if (rowSach != null)
            {
                MaSach = (int)rowSach[0];
            }
           
            PhieuMuon pm = new PhieuMuon();
            pm.suaPM(datePickerNM.Value, MaDocGia, id, MaSach,Int32.Parse(txtTienNo.Text),Int32.Parse(txtSoTienThu.Text));
            setNullForText();
            loadPM();
           
        }

        private void GridViewPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = GridViewPM.Rows[e.RowIndex];
                id = (int)row.Cells[0].Value;
                datePickerNM.Value =(DateTime)row.Cells[1].Value;
                cbTenSach.Text = row.Cells[2].Value.ToString();
                cbHoTenDocGia.Text = row.Cells[3].Value.ToString();
                txtTienNo.Text = row.Cells[4].Value.ToString();
                txtSoTienThu.Text = row.Cells[5].Value.ToString();
                cbHoTenNV.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
