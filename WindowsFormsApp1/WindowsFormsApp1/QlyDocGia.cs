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
    public partial class QlyDocGia : Form
    {
        public QlyDocGia()
        {
            InitializeComponent();
        }
        private void loadDocGia()
        {
            DocGia dg = new DocGia();
            LVDocGia.Items.Clear();
            DataTable dt = dg.LayDSDocGia();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
                item.SubItems.Add(dt.Rows[i][4].ToString());
                item.SubItems.Add(dt.Rows[i][5].ToString());
                item.SubItems.Add(dt.Rows[i][6].ToString());
                item.SubItems.Add(dt.Rows[i][7].ToString());
                LVDocGia.Items.Add(item);

            }
            
        }

        private void QlyDocGia_Load(object sender, EventArgs e)
        {
            loadDocGia();
        }

        private void LVDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVDocGia.SelectedItems.Count > 0)
            {
                txtNameDG.Text = LVDocGia.SelectedItems[0].SubItems[1].Text;
                datePickerNSDG.Text = LVDocGia.SelectedItems[0].SubItems[2].Text;
                txtAddressDG.Text = LVDocGia.SelectedItems[0].SubItems[3].Text;
                txtEmailDG.Text = LVDocGia.SelectedItems[0].SubItems[4].Text;
                datePickerNgayLapThe.Text = LVDocGia.SelectedItems[0].SubItems[5].Text;
                datePickerNgayHetHan.Text = LVDocGia.SelectedItems[0].SubItems[6].Text;
                txtTienNo.Text = LVDocGia.SelectedItems[0].SubItems[7].Text;

            }
        }

        

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }
        private void setNullForText()
        {
            txtAddressDG.Clear();
            txtEmailDG.Clear();
            txtNameDG.Clear();
            txtTienNo.Clear();
            datePickerNgayHetHan.Value = DateTime.Now;
            datePickerNgayLapThe.Value = DateTime.Now;
            datePickerNSDG.Value = DateTime.Now;
        }
        private void BtnThoatDocGia_Click(object sender, EventArgs e)
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

        private void BtnThemDocGia_Click(object sender, EventArgs e)
        {
            DocGia dg = new DocGia();
            dg.ThemDocGia(txtNameDG.Text, datePickerNSDG.Value, txtAddressDG.Text, txtEmailDG.Text, datePickerNgayLapThe.Value, datePickerNgayHetHan.Value, Int16.Parse(txtTienNo.Text));
            loadDocGia();
        }
        private void BtnSuaDocGia_Click(object sender, EventArgs e)
        {
            ListViewItem item = LVDocGia.SelectedItems[0];
            int IdDocGia = Int16.Parse(item.Text);
            DocGia dg = new DocGia();
            dg.SuaDocGia(txtNameDG.Text, datePickerNSDG.Value, txtAddressDG.Text, txtEmailDG.Text, datePickerNgayLapThe.Value, datePickerNgayHetHan.Value, Int16.Parse(txtTienNo.Text),IdDocGia);
            
            loadDocGia();
            setNullForText();
        }

        private void BtnXoaDocGia_Click(object sender, EventArgs e)
        {
            ListViewItem item = LVDocGia.SelectedItems[0];
            int IdDocGia = Int16.Parse(item.Text);
            DocGia dg = new DocGia();
            dg.XoaDocGia(IdDocGia);
            loadDocGia();
            setNullForText();
        }
    }
}
