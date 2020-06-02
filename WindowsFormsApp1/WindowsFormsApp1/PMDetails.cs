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
        int idSach = -1;
        int flagThemclick = -1;
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
            //busPM.loadComboNV(cbHoTenNV);
        }
        public void loadGridView()
        {
            busPM.layPMDetail(idPM, GridViewPMDetail,checklistSach);
        }
        public void loadchecklistbox()
        {
            busPM.loadCheckList(checklistSach);
        }
        public void loadForm()
        {
            loadchecklistbox();
           
            loadCbSach();
            loadcbNV();
            loadGridView();
        }
        private void PMDetails_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            
            GridViewPMDetail.Enabled = false;
            List<CHITIETPHIEUMUON> listctpm = new List<CHITIETPHIEUMUON>();
            if (checklistSach.CheckedItems.Count != 0)
            {
                foreach (var item in checklistSach.CheckedItems)
                {
                    if (checklistSach.GetItemCheckState(checklistSach.Items.IndexOf(item)) != CheckState.Indeterminate)
                    {
                        string tenSach = (item as SACH).TenSach;
                        int idSach = (item as SACH).MaSach;
                        CHITIETPHIEUMUON ctpm = new CHITIETPHIEUMUON();
                        ctpm.MaPhieuMuon = idPM;
                        ctpm.MaSach = idSach;
                        listctpm.Add(ctpm);
                    }
                   
                }
                if (listctpm.Count > 0)
                {
                    busPM.themPMDetailTemp(listctpm, GridViewPMDetail);
                    flagThemclick = 1;
                }
                else
                {
                    ErrorMessage("Vui lòng chọn ít nhất 1 tựa sách!!!", "Data Check Error");
                }
                
            }
            else
            {
                
                ErrorMessage("Vui lòng chọn ít nhất 1 tựa sách!!!", "Data Check Error");
                loadForm();
            }
            
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            /*if (idCTPM == -1)
            {
                ErrorMessage("Vui lòng chọn CTPM","Data Error Check");
            }
            else
            {
                busPM.xoaPMDetail(idCTPM);
                loadForm();
                idCTPM = -1;
            }*/
            /*for (int i = 0; i < GridViewPMDetail.Rows.Count; i++)
            {
                if (GridViewPMDetail.Rows[i].Selected == true)
                {
                    MessageBox.Show(GridViewPMDetail.Rows[i].Cells["MaSach"].Value.ToString());
                }
            }*/
           
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
                idPM = (int)row.Cells["MaPhieuMuon"].Value;
                idSach = (int)row.Cells["MaSach"].Value;
                cbTenSach.Text = row.Cells[4].Value.ToString();
                
            }
        }

        private void BtnTraSach_Click(object sender, EventArgs e)
        {
                List<int> listID = new List<int>();
                foreach (DataGridViewRow check in GridViewPMDetail.Rows)
                {
                    if ((bool)check.Cells["status"].FormattedValue)
                    {
                        listID.Add((int)check.Cells["MaSach"].Value);

                    }
                   
                }
            if (listID.Count > 0)
            {
                foreach (int idSach in listID)
                {
                    busPM.traSachPMDetail(idPM, idSach, datePickerNgayTra.Value);
                }
                loadForm();
            }
            else
            {
                ErrorMessage("Vui lòng chọn ít nhất 1 Chi tiết phiếu!!!","Data Error");
            }
           
           
        }

        private void btnXoaCheckBox_Click(object sender, EventArgs e)
        {
           /* if (idCTPM != -1)
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
            }*/
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (flagThemclick != -1)
            {
                if (GridViewPMDetail.Rows.Count > 0)
                {
                    for (int i = 0; i < GridViewPMDetail.Rows.Count; i++)
                    {
                        int idSach = (int)GridViewPMDetail.Rows[i].Cells["MaSach"].Value;
                        busPM.themPMDetail(idSach, idPM);
                        flagThemclick = -1;
                    }

                }
            }
            else
            {
                ErrorMessage("Vui lòng chọn ít nhất 1 tựa sách!!!","Data Check Error");
            }
            GridViewPMDetail.Enabled = true;
            loadForm();
        }
    }
}
