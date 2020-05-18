using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QlyDocGia : Form
    {
        int id;
        public QlyDocGia()
        {
            InitializeComponent();
        }
        private void loadDocGia()
        {
            DocGia dg = new DocGia();
            DataTable dt = dg.LayDSDocGia();
            GridViewDG.DataSource = dt;
        }

        private void QlyDocGia_Load(object sender, EventArgs e)
        {
            loadDocGia();
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

            DocGia dg = new DocGia();
            dg.SuaDocGia(txtNameDG.Text, datePickerNSDG.Value, txtAddressDG.Text, txtEmailDG.Text, datePickerNgayLapThe.Value, datePickerNgayHetHan.Value, Int16.Parse(txtTienNo.Text), id);
            loadDocGia();
            setNullForText();
        }

        private void BtnXoaDocGia_Click(object sender, EventArgs e)
        {

            DocGia dg = new DocGia();
            dg.XoaDocGia(id);
            loadDocGia();
            setNullForText();
        }

        private void GridViewDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = GridViewDG.Rows[e.RowIndex];
                id = (int)row.Cells[0].Value;
                txtNameDG.Text = row.Cells[1].Value.ToString();
                datePickerNSDG.Value = (DateTime)row.Cells[2].Value;
                txtAddressDG.Text = row.Cells[3].Value.ToString();
                txtEmailDG.Text = row.Cells[4].Value.ToString();
                datePickerNgayLapThe.Value = (DateTime)row.Cells[5].Value;
                datePickerNgayHetHan.Value = (DateTime)row.Cells[6].Value;
                txtTienNo.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
