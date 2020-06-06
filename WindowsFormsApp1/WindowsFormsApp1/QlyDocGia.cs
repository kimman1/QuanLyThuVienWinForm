using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1
{
    public partial class QlyDocGia : Form
    {
        int id = -1;
        BUS_DG busdg = new BUS_DG();
        public QlyDocGia()
        {
            InitializeComponent();
        }
        private void loadDocGia()
        {
            
            busdg.HienThiDG(GridViewDG);
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
            if (checkNullForm() == false)
            {
                
                if (txtTienNo.Text.Trim().Equals(""))
                {
                    txtTienNo.Text = "0";
                }
                if (checkDateTime() == false)
                {
                    //DocGia dg = new DocGia();
                    //dg.ThemDocGia(txtNameDG.Text, datePickerNSDG.Value, txtAddressDG.Text, txtEmailDG.Text, datePickerNgayLapThe.Value, datePickerNgayHetHan.Value, Int16.Parse(txtTienNo.Text));
                    busdg.ThemDG(txtNameDG.Text, datePickerNSDG.Value, txtAddressDG.Text, txtEmailDG.Text, datePickerNgayLapThe.Value, datePickerNgayHetHan.Value, txtTienNo.Text);
                    loadDocGia();
                }
                
            }
            
            
        }
        private void BtnSuaDocGia_Click(object sender, EventArgs e)
        {

            if (id == -1)
            {
                ErrorMessage("Vui lòng chọn Độc Giả!!!","Data Check Error");
            }
            else
            {
                if (checkNullForm() == false)
                {
                    if (txtTienNo.Text.Equals(""))
                    {
                        txtTienNo.Text = "0";
                    }
                    if (checkDateTime() == false)
                    {
                        // DocGia dg = new DocGia();
                        //dg.SuaDocGia(txtNameDG.Text, datePickerNSDG.Value, txtAddressDG.Text, txtEmailDG.Text, datePickerNgayLapThe.Value, datePickerNgayHetHan.Value, Int16.Parse(txtTienNo.Text), id);
                        busdg.SuaDG(id, txtNameDG.Text, datePickerNSDG.Value, txtAddressDG.Text, txtEmailDG.Text, datePickerNgayLapThe.Value, datePickerNgayHetHan.Value,txtTienNo.Text);
                        loadDocGia();
                        setNullForText();
                        id = -1;

                    }
                }
            }
            
        }

        private void BtnXoaDocGia_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                ErrorMessage("Vui lòng chọn độc giả!!!","Data Check Error");
            }
            else 
            {
                DialogResult dlrs = MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Warning !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlrs == DialogResult.Yes)
                {
                    //  DocGia dg = new DocGia();
                    // dg.XoaDocGia(id);
                    busdg.XoaDG(id);
                    loadDocGia();
                    setNullForText();
                    id = -1;
                }
                else
                {
                    setNullForText();
                    id = -1;
                }

            }


        }

        private void GridViewDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
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
        public void ErrorMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool checkNullForm()
        {
            bool status = false;
            if (txtNameDG.Text.Trim().Equals(""))
            {
                ErrorMessage("Vui lòng điền tên độc giả !!!", "Missing Customer Name");
                status = true;
            }
            else if (txtEmailDG.Text.Trim().Equals(""))
            {
                ErrorMessage("Vui lòng điền Email!!!", "Missing Customer Email");
                status = true;
            }
            else if (txtAddressDG.Text.Trim().Equals(""))
            {
                ErrorMessage("Vui lòng đièn địa chỉ !!!", "Missing Customer address");
                status = true;
            }
            
            return status;
        }
        private bool checkDateTime()
        {
            bool status = false;
            DateTime now = DateTime.Now;
            if (datePickerNSDG.Value.Day.Equals(now.Day) && datePickerNSDG.Value.Month.Equals(now.Month) && datePickerNSDG.Value.Year.Equals(now.Year))
            {
                ErrorMessage("Vui lòng kiểm tra lại ngày sinh!!!","Wrong birthday!");
                status = true;
            }
            return status;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            setNullForText();
        }
    }
}
