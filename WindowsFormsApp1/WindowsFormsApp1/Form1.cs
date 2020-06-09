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
using WindowsFormsApp1.Common;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MessClass mess = new MessClass();
        BUS_NV busNV = new BUS_NV();
        int id = -1;
        int idBangCap;
        public Form1()
        {
            InitializeComponent();
        }
        public void loadNhanVien()
        {

            busNV.HienThiDSNV(GridViewIndex);
            GridViewIndex.Columns["HoTenNV"].Width = GridViewIndex.Width * 2/ 10;
            GridViewIndex.Columns["DienThoai"].Width = GridViewIndex.Width * 2 / 10;
        }
        public void loadBangCap()
        {
           
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
                mess.ErrorMessage("Nhập Tên Nhân Viên", "Error!!!");
                
            }
            else if (txtAddress.Text.Equals(""))
            {
                mess.ErrorMessage("Nhập Địa Chỉ", "Error!!!");
           
            }
            else if (txtPhone.Text.Equals(""))
            {
                mess.ErrorMessage("Nhập SDT Nhân Viên", "Error!!!");
               
            }
            else if ((DateTime.Now.Year - datePickerNgaySinh.Value.Year) < 18)
            {
                mess.ErrorMessage("Vui lòng chọn ngày sinh. Lưu ý: Tuổi phải lớn hơn 18", "Error!!!");
            }
            else
            {
                
                busNV.ThemNV(txtName.Text, datePickerNgaySinh.Value, txtAddress.Text, txtPhone.Text, (int)cbBangCap.SelectedValue);
                setNullforText();
                loadNhanVien();
                loadBangCap();
            }
           
        }
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                mess.ErrorMessage("Vui lòng chọn nhân viên để xóa!!!", "DataError");
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
                    
                }
            }
         
        }
        private void BtnSua_Click(object sender, EventArgs e)
        {
          
            int IdNhanVien = id;
            int MaBangCap = (int) cbBangCap.SelectedValue;
            if (IdNhanVien == -1)
            {
                mess.ErrorMessage("Vui lòng chọn nhân viên để sửa !!!!", "Data Error");
            }
            else 
            {
                if (txtName.Text.Equals(""))
                {
                    mess.ErrorMessage("Nhập Tên Nhân Viên", "Error!!!");
                   
                }
                else if (txtAddress.Text.Equals(""))
                {
                    mess.ErrorMessage("Nhập Địa Chỉ", "Error!!!");
                }
                else if (txtPhone.Text.Equals(""))
                {
                    mess.ErrorMessage("Nhập Tên Nhân Viên", "Error!!!");
                  
                }
                else if ((DateTime.Now.Year - datePickerNgaySinh.Value.Year) < 18)
                {
                    mess.ErrorMessage("Vui lòng chọn ngày sinh. Lưu ý: Tuổi phải lớn hơn 18", "Error!!!");
                   
                }
                else
                {
                   
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

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            setNullforText();
        }
    }
}
