using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class QlyPM : Form
    {
        int id =-1 ;
        BUS_PM busPM = new BUS_PM();
        public QlyPM()
        {
            InitializeComponent();
        }
        private void loadPM()
        {
            busPM.layDSPM(GridViewPTT);
        }
       /* private void loadCBSach()
        {
            cbTenSach.DataSource = null;
            PhieuMuon pm = new PhieuMuon();
            DataTable dt = pm.layDSSach();
            cbTenSach.DataSource = dt;
            cbTenSach.DisplayMember = "TenSach";
            cbTenSach.ValueMember = "MaSach";
            cbTenSach.SelectedIndex = -1;
            cbTenSach.Text = "--Select--";

        }*/
        private void loadCBNV()
        {
            //cbHoTenNV.Items.Clear();
            cbHoTenNV.DataSource = null;
            PhieuMuon pm = new PhieuMuon();
            DataTable dt = pm.layDSNV();
            cbHoTenNV.DisplayMember = "HoTenNhanVien";
            cbHoTenNV.ValueMember = "MaNhanVien";
            cbHoTenNV.DataSource = dt;
            cbHoTenNV.SelectedIndex = -1;
            cbHoTenNV.Text = "--Select--";
        }
        private void loadCBDocGia()
        {
       
            cbHoTenDocGia.DataSource = null;
            PhieuMuon pm = new PhieuMuon();
            DataTable dt = pm.layDSDG();
            cbHoTenDocGia.DisplayMember = "HoTenDocGia";
            cbHoTenDocGia.ValueMember = "MaDocGia";
            cbHoTenDocGia.DataSource = dt;
            cbHoTenDocGia.SelectedIndex = -1;
            cbHoTenDocGia.Text = "--Select--";
        }
        private void setNullForText()
        {
            txtSoTienThu.Clear();
            txtTienNo.Clear();
            datePickerNM.Value = DateTime.Now;
            loadCBDocGia();
            loadCBNV();
            //loadCBSach();
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
            if (id != -1)
            {
                // PhieuMuon pm = new PhieuMuon();
                //pm.xoaPM(id);
                busPM.xoaPM(id);
                setNullForText();
                loadPM();
                id = -1;
            }
            else 
            {
                ErrorMessage("Vui lòng chọn Phiếu Mượn để xóa","Missing ID");
            }
            
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            int MaDocGia = -1 ;
            int MaSach = -1;
            int MaNV = -1;
            
            
            DataRowView rowDocGia = (DataRowView)cbHoTenDocGia.SelectedItem;
            if (rowDocGia != null)
            {
                 MaDocGia = (int)rowDocGia[0];
            }
           /* DataRowView rowSach = (DataRowView)cbTenSach.SelectedItem;
            if (rowSach != null)
            {
                MaSach = (int)rowSach[0];
            }*/
            DataRowView rowNV = (DataRowView)cbHoTenNV.SelectedItem;
            if (rowNV != null)
            {
                MaNV = (int)rowNV[0];
            }
            if (MaDocGia.Equals(-1))
            {
                ErrorMessage("Vui lòng chọn Độc Giả", "Missing Customer ID");
            }
            else 
            {
                if (txtTienNo.Text.Trim().Equals("") && txtSoTienThu.Text.Trim().Equals(""))
                {
                    txtSoTienThu.Text = "0";
                    txtTienNo.Text = "0";
                }
                //PhieuMuon pm = new PhieuMuon();
                //pm.themPM(DateTime.Now, MaDocGia, MaSach, Int32.Parse(txtTienNo.Text), Int32.Parse(txtSoTienThu.Text), MaNV);
                busPM.themPM(MaDocGia,MaNV);
                setNullForText();
                loadPM();

            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            int MaDocGia = 0;
           // int MaSach = 0;
            if (id == -1)
            {
                ErrorMessage("Vui lòng chọn PM để sửa!!!","Data Error");
            }
            else 
            {
                DataRowView rowDocGia = (DataRowView)cbHoTenDocGia.SelectedItem;
                if (rowDocGia != null)
                {
                    MaDocGia = (int)rowDocGia[0];
                }
                /* DataRowView rowSach = (DataRowView)cbTenSach.SelectedItem;
                 if (rowSach != null)
                 {
                     MaSach = (int)rowSach[0];
                 }
                 PhieuMuon pm = new PhieuMuon();
                 pm.suaPM(datePickerNM.Value, MaDocGia, id, MaSach, Int32.Parse(txtTienNo.Text), Int32.Parse(txtSoTienThu.Text));
                 */
                busPM.suaPM(id, MaDocGia);
                setNullForText();
                loadPM();
                id = -1;
            }
        }

        private void GridViewPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GridViewPTT.Rows[e.RowIndex];
                id = (int)row.Cells[1].Value;
                /* datePickerNM.Value =(DateTime)row.Cells[2].Value;
                 cbTenSach.Text = row.Cells[3].Value.ToString();
                 cbHoTenDocGia.Text = row.Cells[4].Value.ToString();
                 txtTienNo.Text = row.Cells[5].Value.ToString();
                 txtSoTienThu.Text = row.Cells[6].Value.ToString();
                
                 if (Convert.ToString(row.Cells[8].Value) != string.Empty)
                 {
                     datePickerNgayTra.Value = (DateTime)row.Cells[8].Value;
                 }
                 else
                 {

                     ErrorMessage("Không tìm thấy ngày trả!!!", "DateCheckError");
                 }
                 */
                datePickerNM.Value = (DateTime)row.Cells[2].Value;
                cbHoTenDocGia.Text = row.Cells[3].Value.ToString();
                cbHoTenNV.Text = row.Cells[5].Value.ToString();
            }
        }
        public void ErrorMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoaList_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                //PhieuMuon pm = new PhieuMuon();
                List<int> listID = new List<int>();
                foreach (DataGridViewRow check in GridViewPTT.Rows)
                {
                    if ((bool)check.Cells["status"].FormattedValue)
                    {
                        listID.Add((int)check.Cells["MaPhieuMuon"].Value);
                    }
                }
                foreach (int a in listID)
                {
                    busPM.xoaPM(a);
                }
                id = -1;
                loadPM();
            }
            else 
            {
                ErrorMessage("Vui lòng chọn ít nhất một checkbox", "Missing ID");
            }
            
        }

        private void GridViewPM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PMDetails pm = new PMDetails(id);
            pm.Show();
        }

    }
}
