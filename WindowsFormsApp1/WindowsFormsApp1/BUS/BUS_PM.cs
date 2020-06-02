using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.BUS
{
    class BUS_PM
    {
        PhieuMuonDAO pmDAO = new PhieuMuonDAO();
        
        public void layDSPM(DataGridView dg)
        {
            dg.DataSource = pmDAO.listPM();
        }
        public void themPM(int MaDocGia, int MaNhanVien)
        {
            PHIEUMUONSACH pm = new PHIEUMUONSACH();
            pm.NgayMuon = DateTime.Now;
            pm.MaDocGia = MaDocGia;
            pm.MaNhanVien = MaNhanVien;
            pmDAO.AddPM(pm);
        }
        public void xoaPM(int MaDocGia)
        {
            int result = pmDAO.PMtest(MaDocGia); //pmDAO.DeletePM(MaDocGia);
             if (result == 0 || result == -1)
             {
                 MessageBox.Show("Có lỗi trong quá trình xóa. Kiểm tra chi tiết PM", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else 
             {
                 MessageBox.Show("Xoá thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
            //pmDAO.PMtest(MaDocGia);
        }
        public void suaPM(int idPM, int MaDocGia)
        {
            pmDAO.SuaPM(MaDocGia, idPM);
        }
        /***********************Chi Tiet Phieu Muon***************************/
        public void loadComboSach(ComboBox cb)
        {
            cb.DataSource = null;
            cb.DataSource = pmDAO.loadCBSach();
            cb.DisplayMember = "TenSach";
            cb.ValueMember = "MaSach";
            cb.SelectedIndex = -1;
            cb.Text = "--Select--";
        }
        public void loadComboNV(ComboBox cb)
        {
            cb.DataSource = null;
            cb.DataSource = pmDAO.loadcbNV();
            cb.DisplayMember = "HoTenNhanVien";
            cb.ValueMember = "MaNhanVien";
            cb.SelectedIndex = -1;
            cb.Text = "--Select--";
        }
        public void loadCheckList(CheckedListBox ck)
        {
            ck.DataSource = null;
            ck.DataSource = pmDAO.loadCBSach();
            ck.DisplayMember = "TenSach";
            ck.ValueMember = "MaSach";
            ck.SelectedIndex = -1;
            //ck.SetItemChecked(0, true);
            


        }
        public void layPMDetail(int idPM, DataGridView dg, CheckedListBox ck)
        {
            dg.DataSource = pmDAO.listCTTPM(idPM);
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                 for (int j = 0; j < ck.Items.Count; j++)
                 {
                     var item = ck.Items[j];
                    if (dg.Rows[i].Cells["MaSach"].Value != null)
                    {
                        if ((item as SACH).MaSach == (int)dg.Rows[i].Cells["MaSach"].Value)
                        {
                            ck.SetItemChecked(j, true);
                            ck.SetItemCheckState(j, CheckState.Indeterminate);
                        }
                    }
                         
                 }
            }
           
        }
        public void themPMDetailTemp(List<CHITIETPHIEUMUON> listctpm , DataGridView dg)
        {
            dg.DataSource = null;
            dg.DataSource = listctpm;
        }
        public void themPMDetail(int MaSach, int MaPhieuMuon)
        {
            
            CHITIETPHIEUMUON ctpm = new CHITIETPHIEUMUON();
            ctpm.MaPhieuMuon = MaPhieuMuon;
            ctpm.MaSach = MaSach;
            pmDAO.AddPMDetail(ctpm);
     
        }
        public void suaPMDetail(int MaSach, int idCTPM)
        {
            CHITIETPHIEUMUON ctpm = new CHITIETPHIEUMUON();
            ctpm.MaSach = MaSach;
           // ctpm.NgayTra = NgayTra;
            pmDAO.EditPMDetail(ctpm, idCTPM);
        }
        public void xoaPMDetail(int idCTPM)
        {
            pmDAO.DeletePMDetail(idCTPM);

        }
        public void traSachPMDetail(int idPM,int idSach, DateTime NgayTra)
        {
          
                pmDAO.GiveBookBackDetail(idPM,idSach, NgayTra);
            
            
        }
    }
}
