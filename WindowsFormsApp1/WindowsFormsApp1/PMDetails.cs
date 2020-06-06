using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.Common;
namespace WindowsFormsApp1
{
    public partial class PMDetails : Form
    {
        int idPM = -1;
        int idSach = -1;
        int flagThemclick = -1;
        MessClass mess = new MessClass();
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
                    mess.ErrorMessage("Vui lòng chọn ít nhất 1 tựa sách!!!", "Data Check Error");
                }
                
            }
            else
            {
                
                mess.ErrorMessage("Vui lòng chọn ít nhất 1 tựa sách!!!", "Data Check Error");
                loadForm();
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
                mess.ErrorMessage("Vui lòng chọn ít nhất 1 Chi tiết phiếu!!!","Data Error");
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thêm. Vui lòng kiểm tra thật kỹ !!!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
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
                    mess.ErrorMessage("Vui lòng chọn ít nhất 1 tựa sách!!!", "Data Check Error");
                }
                GridViewPMDetail.Enabled = true;
                loadForm();
            }
            else
            {
                return;
            }
        }
            
    }
}
