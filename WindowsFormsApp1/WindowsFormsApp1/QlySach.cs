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
    public partial class QlySach : Form
    {
        Sach sach;
        public QlySach()
        {
            InitializeComponent();
        }
        private void loadSach()
        {
            sach = new Sach();
            LVSach.Items.Clear();
            DataTable dt = sach.LayDSSach();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
                item.SubItems.Add(dt.Rows[i][4].ToString());
                item.SubItems.Add(dt.Rows[i][5].ToString());
                item.SubItems.Add(dt.Rows[i][6].ToString());
                LVSach.Items.Add(item);

            }
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

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void QlySach_Load(object sender, EventArgs e)
        {
            loadSach();
        }

        private void LVSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVSach.SelectedItems.Count > 0)
            {
                ListViewItem item = LVSach.SelectedItems[0];
                txtTenSach.Text = item.SubItems[1].Text;
                datePickerNXB.Text = item.SubItems[3].Text;
                txtNXB.Text = item.SubItems[4].Text;
                txtGiaTien.Text = item.SubItems[5].Text;
                txtTacGia.Text = item.SubItems[2].Text;
                datePickerNgayNhap.Text = item.SubItems[6].Text;
            }
            
        }

        private void BtnThemSach_Click(object sender, EventArgs e)
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
                setNulForText();
                sach.ThemSach(txtTenSach.Text, txtTacGia.Text, datePickerNXB.Value, txtNXB.Text, txtGiaTien.Text, datePickerNgayNhap.Value);
                loadSach();
            }
        }

        private void BtnXoaSach_Click(object sender, EventArgs e)
        {
             ListViewItem item = LVSach.SelectedItems[0];
             int idSach = Int16.Parse(item.Text);
             DialogResult dlrs = MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Warning !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
             if (dlrs == DialogResult.Yes)
             {
                 setNulForText();
                 sach.XoaSach(idSach);
                 loadSach();
             }
             else
             {
                 setNulForText();
                // return;
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
             
            ListViewItem item = LVSach.SelectedItems[0];
            int idSach = short.Parse(item.Text);
            sach.SuaSach(txtTenSach.Text, txtTacGia.Text, datePickerNXB.Value, txtNXB.Text, txtGiaTien.Text, datePickerNgayNhap.Value, idSach);
            setNulForText();
            loadSach();
            
            }

             

           
            
        }
        public void ErrorMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
