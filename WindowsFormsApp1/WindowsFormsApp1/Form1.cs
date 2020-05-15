using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        NhanVien nv = new NhanVien();
        public Form1()
        {
            InitializeComponent();
        }
        public void loadNhanVien()
        {
            listView1.Items.Clear();
            DataTable dt = nv.LayDSNhanVien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
                item.SubItems.Add(dt.Rows[i][4].ToString());
                item.SubItems.Add(dt.Rows[i][5].ToString());
                listView1.Items.Add(item);

            }
            listView1.Columns.Remove(MaBangCap);
        }
        public void loadBangCap()
        {
            DataTable dt = nv.LayDSBangCap();
            cbBangCap.DataSource = dt;
            cbBangCap.DisplayMember = "TenBangCap";
            cbBangCap.ValueMember = "MaBangCap";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadNhanVien();
            loadBangCap();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
               datePickerNgaySinh.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtAddress.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtPhone.Text = listView1.SelectedItems[0].SubItems[4].Text;
                cbBangCap.SelectedValue = listView1.SelectedItems[0].SubItems[5].Text;
            }
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
            txtLastName.Clear();
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
                nv.ThemNV(txtName.Text, datePickerNgaySinh.Value, txtAddress.Text, txtPhone.Text, (int)cbBangCap.SelectedValue);
                setNullforText();
                loadNhanVien();
            }
           
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            int IdNhanVien = Int16.Parse(item.Text);
         DialogResult dlrs = MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Warning !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlrs == DialogResult.Yes)
            {
                nv.XoaNV(IdNhanVien);
                setNullforText();
                loadNhanVien();
            }
            else
            {
                setNullforText();
                return;
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            int IdNhanVien = Int16.Parse(item.Text);
            int MaBangCap = Int16.Parse(cbBangCap.SelectedValue.ToString());
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
                nv.SuaNV(IdNhanVien, txtName.Text, datePickerNgaySinh.Value, txtAddress.Text, txtPhone.Text, MaBangCap);
                setNullforText();
                loadNhanVien();
            }
           
        }

        private void BtnQLyDocGia_Click(object sender, EventArgs e)
        {
            var QuanlyDG = new QlyDocGia();
            QuanlyDG.Show();
        }

        private void TxtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnQlySach_Click(object sender, EventArgs e)
        {
            var QuanLySachForm = new QlySach();
            QuanLySachForm.Show();
        }

        private void BtnQlyPM_Click(object sender, EventArgs e)
        {
            var QuanLyPM = new QlyPM();
            QuanLyPM.Show();
        }
    }
}
