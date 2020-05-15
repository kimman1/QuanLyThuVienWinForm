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
        public QlyPM()
        {
            InitializeComponent();
        }
        private void loadPM()
        {
            LVPM.Items.Clear();
            PhieuMuon pm = new PhieuMuon();
            DataTable dt = pm.layDSPM();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][4].ToString());
                item.SubItems.Add(dt.Rows[i][5].ToString());
                item.SubItems.Add(dt.Rows[i][6].ToString());
                
                LVPM.Items.Add(item);
            }
        }
        private void loadCBSach()
        {
           // cbTenSach.Items.Clear();
            cbTenSach.DataSource = null;
            PhieuMuon pm = new PhieuMuon();
            DataTable dt = pm.layDSSach();
            cbTenSach.DisplayMember = "TenSach";
            cbTenSach.ValueMember = "MaSach";
            cbTenSach.DataSource = dt;
            
        }
        private void loadCBNV()
        {
            //cbHoTenNV.Items.Clear();
            cbTenSach.DataSource = null;
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
        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void QlyPM_Load(object sender, EventArgs e)
        {
            setNullForText();
            loadPM();
            loadCBSach();
            loadCBNV();
            loadCBDocGia();
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

        private void LVPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVPM.SelectedItems.Count > 0)
            {
                System.Windows.Forms.ListViewItem item = LVPM.SelectedItems[0];
                txtTienNo.Text = item.SubItems[4].Text;
                txtSoTienThu.Text = item.SubItems[5].Text;
                datePickerNM.Text = item.SubItems[3].Text;
                cbHoTenDocGia.Text = item.SubItems[2].Text;
                cbTenSach.Text = item.SubItems[1].Text;
                cbHoTenNV.Text = item.SubItems[6].Text;
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            int MaPM = 0;
            System.Windows.Forms.ListViewItem item = LVPM.SelectedItems[0];
            MaPM = Int16.Parse(item.Text);
            PhieuMuon pm = new PhieuMuon();
            pm.xoaPM(MaPM);
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
            int MaNV = 0;
            int MaPM = 0;
            System.Windows.Forms.ListViewItem item = LVPM.SelectedItems[0];
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
            MaPM = Int16.Parse(item.Text);
            PhieuMuon pm = new PhieuMuon();
            pm.suaPM(datePickerNM.Value, MaDocGia, MaPM, MaSach,Int32.Parse(txtTienNo.Text),Int32.Parse(txtSoTienThu.Text));
            setNullForText();
            loadPM();
           
        }
    }
}
