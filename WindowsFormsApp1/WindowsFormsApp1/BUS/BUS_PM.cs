﻿using System;
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
        PhieuMuonDAO pmDAO;
        public BUS_PM()
        {
            pmDAO = new PhieuMuonDAO();
        }
        public void layDSPM(DataGridView dg)
        {
            dg.DataSource = pmDAO.listPM();
        }
        public void themPM(int MaDocGia)
        {
            PHIEUMUONSACH pm = new PHIEUMUONSACH();
            pm.NgayMuon = DateTime.Now;
            pm.MaDocGia = MaDocGia;
            pmDAO.AddPM(pm);
        }
        public void xoaPM(int MaDocGia)
        {
            int result = pmDAO.DeletePM(MaDocGia);
            if (result == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xóa. Kiểm tra chi tiết PM", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                MessageBox.Show("Có lỗi trong quá trình xóa", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
        public void layPMDetail(int idPM, DataGridView dg)
        {
            dg.DataSource = pmDAO.listCTTPM(idPM);
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
    }
}