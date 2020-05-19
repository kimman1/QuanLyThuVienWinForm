using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QuanLySach : Form
    {
        Sach sach;
        int id;
        public QuanLySach()
        {
            InitializeComponent();
        }
        private void loadSach()
        {
            sach = new Sach();
            DataTable dt = sach.LayDSSach();
            GridViewSach.DataSource = dt;
        }
        private void QuanLySach_Load(object sender, EventArgs e)
        {
            loadSach();
        }

        private void GridViewSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GridViewSach.Rows[e.RowIndex];
                id = (int)row.Cells[0].Value;
                txtTenSach.Text = row.Cells[1].Value.ToString();
                txtTacGia.Text = row.Cells[2].Value.ToString();
                datePickerNXB.Value = (DateTime)row.Cells[3].Value;
                txtNXB.Text = row.Cells[4].Value.ToString();
                txtGiaTien.Text = row.Cells[5].Value.ToString();
                datePickerNgayNhap.Value = (DateTime)row.Cells[6].Value;
            }
        }

        private void BtnThemSach_Click(object sender, EventArgs e)
        {
            sach = new Sach();
            if (txtTenSach.Text.Equals(""))
            {
                ErrorMessage("Điền tên sách!!!", "Error");
            }
            else if (txtNXB.Text.Equals(""))
            {
                ErrorMessage("Điền tên NXB!!!", "Error");
            }
            else if (txtGiaTien.Text.Equals(""))
            {
                ErrorMessage("Điền giá tiền!!!", "Error");
            }
            else if (txtTacGia.Text.Equals(""))
            {
                ErrorMessage("Điền tên tác giả!!!", "Error");
            }
            else if (datePickerNXB.Value.Year.Equals(DateTime.Now.Year) && datePickerNXB.Value.Month.Equals(DateTime.Now.Month) && datePickerNXB.Value.Day.Equals(DateTime.Now.Day))
            {
                ErrorMessage("Xem lại Ngày Xuất Bản", "Error");
            }
            else
            {
                sach.ThemSach(txtTenSach.Text, txtTacGia.Text, datePickerNXB.Value, txtNXB.Text, txtGiaTien.Text, datePickerNgayNhap.Value);
                setNulForText();
                loadSach();
            }
        }
        public void ErrorMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void setNulForText()
        {
            txtGiaTien.Clear();
            txtNXB.Clear();
            txtTacGia.Clear();
            txtTenSach.Clear();
            datePickerNgayNhap.Value = DateTime.Now;
            datePickerNXB.Value = DateTime.Now;
        }

        private void BtnXoaSach_Click(object sender, EventArgs e)
        {
            DialogResult dlrs = MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Warning !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlrs == DialogResult.Yes)
            {
                sach = new Sach();
                sach.XoaSach(id);
                setNulForText();
                loadSach();
            }
            else
            {
                setNulForText();
                
            }
            
        }

        private void BtnSuaSach_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text.Equals(""))
            {
                ErrorMessage("Điền tên sách!!!", "Error");
            }
            else if (txtNXB.Text.Equals(""))
            {
                ErrorMessage("Điền tên NXB!!!", "Error");
            }
            else if (txtGiaTien.Text.Equals(""))
            {
                ErrorMessage("Điền giá tiền!!!", "Error");
            }
            else if (txtTacGia.Text.Equals(""))
            {
                ErrorMessage("Điền tên tác giả!!!", "Error");
            }
            else if (datePickerNXB.Value.Year.Equals(DateTime.Now.Year) && datePickerNXB.Value.Month.Equals(DateTime.Now.Month) && datePickerNXB.Value.Day.Equals(DateTime.Now.Day))
            {
                ErrorMessage("Xem lại Ngày Xuất Bản", "Error");
            }
            else
            {
                sach = new Sach();
                sach.SuaSach(txtTenSach.Text, txtTacGia.Text, datePickerNXB.Value, txtNXB.Text, txtGiaTien.Text, datePickerNgayNhap.Value, id);
                setNulForText();
                loadSach();
            }
            
        }

        private void BtnThoatSach_Click(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sach = new Sach();
            DataTable dt = sach.TimKiemSach(txtSearch.Text);
            GridViewSach.DataSource = null;
            GridViewSach.DataSource = dt;
        }
    }
}
