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
    public partial class Form1 : Form
    {
        //NhanVien nv = new NhanVien();
        BUS_NV busNV = new BUS_NV();
        int id = -1;
        int idBangCap;
        public Form1()
        {
            InitializeComponent();
        }
        public void loadNhanVien()
        {

            //DataTable dt = nv.LayDSNhanVien();
            //GridViewIndex.DataSource = nvDao.ListNV();
            busNV.HienThiDSNV(GridViewIndex);
        }
        public void loadBangCap()
        {
            /*DataTable dt = nv.LayDSBangCap();
            cbBangCap.DataSource = null;
            cbBangCap.DataSource = dt;
            cbBangCap.DisplayMember = "TenBangCap";
            cbBangCap.ValueMember = "MaBangCap";*/
            busNV.HienThiDSBC(cbBangCap);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadNhanVien();
            loadBangCap();
        }

       
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlrs = MessageBox.Show("Bạn có chắc chắn muốn thoát !", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlrs == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (dlrs == DialogResult.No)
            {
                return;
            }
        }
        public void setNullforText()
        {
            txtAddress.Clear();
            
            txtName.Clear();
            txtPhone.Clear();
            datePickerNgaySinh.Value = DateTime.Now;
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Nhập Tên Nhân Viên", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAddress.Text.Equals(""))
            {
                MessageBox.Show("Nhập Địa Chỉ", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPhone.Text.Equals(""))
            {
                MessageBox.Show("Nhập Tên Nhân Viên", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((DateTime.Now.Year - datePickerNgaySinh.Value.Year) < 18)
            {
                MessageBox.Show("Vui lòng chọn ngày sinh. Lưu ý: Tuổi phải lớn hơn 18", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //nv.ThemNV(txtName.Text, datePickerNgaySinh.Value, txtAddress.Text, txtPhone.Text, (int)cbBangCap.SelectedValue);
                busNV.ThemNV(txtName.Text, datePickerNgaySinh.Value, txtAddress.Text, txtPhone.Text, (int)cbBangCap.SelectedValue);
                setNullforText();
                loadNhanVien();
            }
           
        }
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                ErrorMessage("Vui lòng chọn nhân viên để xóa!!!", "DataError");
            }
            else
            {
                DialogResult dlrs = MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Warning !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlrs == DialogResult.Yes)
                {
                    busNV.XoaNV(id);
                    setNullforText();
                    loadNhanVien();
                    id = -1;
                }
                else
                {
                    setNullforText();
                    id = -1;
                    return;
                }
            }
         
        }
        private void BtnSua_Click(object sender, EventArgs e)
        {
          
            int IdNhanVien = id;
            int MaBangCap = (int) cbBangCap.SelectedValue;
            if (IdNhanVien == -1)
            {
                ErrorMessage("Vui lòng chọn nhân viên để sửa !!!!", "Data Error");
            }
            else 
            {
                if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Nhập Tên Nhân Viên", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtAddress.Text.Equals(""))
                {
                    MessageBox.Show("Nhập Địa Chỉ", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPhone.Text.Equals(""))
                {
                    MessageBox.Show("Nhập Tên Nhân Viên", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((DateTime.Now.Year - datePickerNgaySinh.Value.Year) < 18)
                {
                    MessageBox.Show("Vui lòng chọn ngày sinh. Lưu ý: Tuổi phải lớn hơn 18", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //nv.SuaNV(IdNhanVien, txtName.Text, datePickerNgaySinh.Value, txtAddress.Text, txtPhone.Text, MaBangCap);
                    busNV.SuaNV(IdNhanVien, txtName.Text, datePickerNgaySinh.Value, txtAddress.Text, txtPhone.Text, MaBangCap);
                    setNullforText();
                    loadNhanVien();
                    id = -1;
                }

            }

        }

        private void BtnQLyDocGia_Click(object sender, EventArgs e)
        {
            var QuanlyDG = new QlyDocGia();
            QuanlyDG.Show();
        }

        private void BtnQlySach_Click(object sender, EventArgs e)
        {
            var QuanLySachForm = new QuanLySach();
            QuanLySachForm.Show();
        }

        private void BtnQlyPM_Click(object sender, EventArgs e)
        {
            var QuanLyPM = new QlyPM();
            QuanLyPM.Show();
        }

        private void GridViewIndex_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GridViewIndex.Rows[e.RowIndex];
                id = (int)row.Cells[0].Value;
                txtName.Text = row.Cells[1].Value.ToString();
                datePickerNgaySinh.Value = (DateTime)row.Cells[2].Value;
                txtAddress.Text = row.Cells[3].Value.ToString();
                txtPhone.Text = row.Cells[6].Value.ToString();
                cbBangCap.SelectedValue = row.Cells[5].Value;
                idBangCap = (int) row.Cells[5].Value;
            }
        }
        public void ErrorMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnQLyPTT_Click(object sender, EventArgs e)
        {
            var FormPhieuThuTien = new FormPhieuThuTien();
            FormPhieuThuTien.Show();
        }
    }
}
