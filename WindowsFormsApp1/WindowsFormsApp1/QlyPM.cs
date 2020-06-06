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

        private void loadCBNV()
        {
           
            busPM.loadComboNV(cbHoTenNV);
            
         }
        private void loadCBDocGia()
        {

            busPM.loadCBDG(cbHoTenDocGia);
        }
        private void setNullForText()
        {
          
            datePickerNM.Value = DateTime.Now;
            loadCBDocGia();
            loadCBNV();
        }
        private void loadForm()
        {
            loadPM();
            loadCBDocGia();
            loadCBNV();
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
                DialogResult dlrs = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlrs == DialogResult.Yes)
                {
                    busPM.xoaPM(id);
                    loadForm();
                    id = -1;
                }
                else
                {
                    id = -1;
                    return;
                }
                
            }
            else 
            {
                ErrorMessage("Vui lòng chọn Phiếu Mượn để xóa","Missing ID");
            }
            
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            int MaDocGia = -1 ;
            int MaNV = -1;
 
            if (cbHoTenDocGia.SelectedItem != null)
            {
                MaDocGia =(int)cbHoTenDocGia.SelectedValue;
            }
            if (cbHoTenNV.SelectedItem != null)
            {
                MaNV = (int)cbHoTenNV.SelectedValue;
            }
            if (MaDocGia.Equals(-1))
            {
                ErrorMessage("Vui lòng chọn Độc Giả", "Missing Customer ID");
            }
            else if (MaNV.Equals(-1))
            {
                ErrorMessage("Vui lòng chọn Nhân Viên", "Missing Employee ID");
            }
            else
            {

                busPM.themPM(MaDocGia, MaNV);
                loadForm();
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
                loadForm();
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

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            setNullForText();
        }
    }
}
