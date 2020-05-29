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
            //int MaNV = -1;
            /* DataRowView rowSach = (DataRowView)cbTenSach.SelectedItem;
             if (rowSach != null)
             {
                 MaSach = (int)rowSach[0];
             }
             DataRowView rowNV = (DataRowView)cbHoTenNV.SelectedItem;
             if (rowNV != null)
             {
                 MaNV = (int)rowNV[0];
             }*/
            MaSach = (int)cbTenSach.SelectedValue;
            //MaNV = (int)cbHoTenNV.SelectedValue;
            if (MaSach.Equals(-1))
            {
                ErrorMessage("Vui lòng chọn Sách", "Missing Book ID");
            }
            else
            {
                busPM.themPMDetail(MaSach, idPM);
                loadForm();
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            busPM.suaPMDetail((int)cbTenSach.SelectedValue, idCTPM);
            loadForm();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {

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
    }
}
