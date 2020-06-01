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
    public partial class PMDetails : Form
    {
        int idPM = -1;
        int idCTPM = -1;
        BUS_PM busPM = new BUS_PM();
        public PMDetails(int id)
        {
            InitializeComponent();
            this.idPM = id;
        }
        public void loadCbSach()
        {
            busPM.loadComboSach(cbTenSach);
        }
        public void loadcbNV()
        {
            busPM.loadComboNV(cbHoTenNV);
        }
        public void loadGridView()
        {
            busPM.layPMDetail(idPM, GridViewPMDetail);
        }
        public void loadForm()
        {
            loadGridView();
            loadCbSach();
            loadcbNV();
        }
        private void PMDetails_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            int MaSach = -1;
            if (cbTenSach.SelectedValue != null)
            {
                MaSach = (int)cbTenSach.SelectedValue;
            }
            if (MaSach.Equals(-1))
            {
                ErrorMessage("Vui lòng chọn Sách", "Missing Book ID");
            }
            else
            {
                MaSach = (int)cbTenSach.SelectedValue;
                busPM.themPMDetail(MaSach, idPM);
                loadForm();
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (idCTPM == -1)
            {
                ErrorMessage("Vui lòng chọn CTPM","Data Error Check");
            }
            else
            {
                busPM.xoaPMDetail(idCTPM);
                loadForm();
                idCTPM = -1;
            }
           
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (idCTPM == -1)
            {
                ErrorMessage("Vui lòng chọn CTPM","Data Error Check");
            }
            else
            {
                busPM.suaPMDetail((int)cbTenSach.SelectedValue, idCTPM);
                loadForm();
                idCTPM = -1;
            }
          
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
        public void ErrorMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GridViewPMDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GridViewPMDetail.Rows[e.RowIndex];
                idCTPM = (int)row.Cells[1].Value;
                cbTenSach.Text = row.Cells[5].Value.ToString();
                
            }
        }

        private void BtnTraSach_Click(object sender, EventArgs e)
        {
            if (idCTPM == -1)
            {
                ErrorMessage("Vui lòng check ít nhất 1 Chi tiết Phiếu!!!","Data Check Error");
            }
            else
            {
                List<int> listID = new List<int>();
                foreach (DataGridViewRow check in GridViewPMDetail.Rows)
                {
                    if ((bool)check.Cells["status"].FormattedValue)
                    {
                        listID.Add((int)check.Cells["MaCTPM"].Value);

                    }
                    else
                    {
                        idCTPM = -1;
                    }
                    
                }
                foreach (int id in listID)
                {
                    busPM.traSachPMDetail(id, datePickerNgayTra.Value);
                }
                idCTPM = -1;
                loadForm();
            }
            
        }

        private void btnXoaCheckBox_Click(object sender, EventArgs e)
        {
            if (idCTPM != -1)
            {
                //PhieuMuon pm = new PhieuMuon();
                List<int> listID = new List<int>();
                foreach (DataGridViewRow check in GridViewPMDetail.Rows)
                {
                    if ((bool)check.Cells["status"].FormattedValue)
                    {
                        listID.Add((int)check.Cells["MaCTPM"].Value);
                    }
                    else
                    {
                        idCTPM = -1;
                    }
                    
                }
                foreach (int a in listID)
                {
                    busPM.xoaPMDetail(a);
                }
                idCTPM = -1;
                loadForm();
                
            }
            else
            {
                ErrorMessage("Vui lòng chọn ít nhất một checkbox", "Missing ID");
            }
        }
    }
}
