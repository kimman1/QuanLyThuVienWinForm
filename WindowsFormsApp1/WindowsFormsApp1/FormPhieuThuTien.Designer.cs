namespace WindowsFormsApp1
{
    partial class FormPhieuThuTien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTenSach = new System.Windows.Forms.ComboBox();
            this.cbHoTenNV = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoTienThu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHoTenDocGia = new System.Windows.Forms.ComboBox();
            this.txtTienNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datePickerNM = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaCheckBox = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GridViewPTT = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPTT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1108, 75);
            this.label1.TabIndex = 7;
            this.label1.Text = "Phiếu Thu Tiền";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTenSach);
            this.groupBox1.Controls.Add(this.cbHoTenNV);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSoTienThu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbHoTenDocGia);
            this.groupBox1.Controls.Add(this.txtTienNo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.datePickerNM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1108, 305);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // cbTenSach
            // 
            this.cbTenSach.FormattingEnabled = true;
            this.cbTenSach.Location = new System.Drawing.Point(122, 78);
            this.cbTenSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTenSach.Name = "cbTenSach";
            this.cbTenSach.Size = new System.Drawing.Size(298, 28);
            this.cbTenSach.TabIndex = 22;
            // 
            // cbHoTenNV
            // 
            this.cbHoTenNV.FormattingEnabled = true;
            this.cbHoTenNV.Location = new System.Drawing.Point(714, 143);
            this.cbHoTenNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbHoTenNV.Name = "cbHoTenNV";
            this.cbHoTenNV.Size = new System.Drawing.Size(298, 28);
            this.cbHoTenNV.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(597, 145);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Họ tên NV:";
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.Location = new System.Drawing.Point(712, 88);
            this.txtSoTienThu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(298, 26);
            this.txtSoTienThu.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số tiền thu:";
            // 
            // cbHoTenDocGia
            // 
            this.cbHoTenDocGia.FormattingEnabled = true;
            this.cbHoTenDocGia.Location = new System.Drawing.Point(122, 197);
            this.cbHoTenDocGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbHoTenDocGia.Name = "cbHoTenDocGia";
            this.cbHoTenDocGia.Size = new System.Drawing.Size(298, 28);
            this.cbHoTenDocGia.TabIndex = 17;
            // 
            // txtTienNo
            // 
            this.txtTienNo.Location = new System.Drawing.Point(712, 197);
            this.txtTienNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTienNo.Name = "txtTienNo";
            this.txtTienNo.Size = new System.Drawing.Size(298, 26);
            this.txtTienNo.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(603, 202);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tiền Nợ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Họ tên độc giả:";
            // 
            // datePickerNM
            // 
            this.datePickerNM.Location = new System.Drawing.Point(122, 145);
            this.datePickerNM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datePickerNM.Name = "datePickerNM";
            this.datePickerNM.Size = new System.Drawing.Size(298, 26);
            this.datePickerNM.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày mượn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sách:";
            // 
            // btnXoaCheckBox
            // 
            this.btnXoaCheckBox.Location = new System.Drawing.Point(385, 404);
            this.btnXoaCheckBox.Name = "btnXoaCheckBox";
            this.btnXoaCheckBox.Size = new System.Drawing.Size(128, 83);
            this.btnXoaCheckBox.TabIndex = 24;
            this.btnXoaCheckBox.Text = "Xóa danh sách đã chọn";
            this.btnXoaCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(898, 404);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 83);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(772, 404);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(117, 83);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(646, 404);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 83);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(520, 404);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 83);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GridViewPTT);
            this.groupBox3.Location = new System.Drawing.Point(13, 507);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1155, 331);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chung";
            // 
            // GridViewPTT
            // 
            this.GridViewPTT.AllowUserToAddRows = false;
            this.GridViewPTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewPTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status});
            this.GridViewPTT.Location = new System.Drawing.Point(9, 29);
            this.GridViewPTT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridViewPTT.Name = "GridViewPTT";
            this.GridViewPTT.RowHeadersWidth = 62;
            this.GridViewPTT.Size = new System.Drawing.Size(1137, 292);
            this.GridViewPTT.TabIndex = 19;
            // 
            // status
            // 
            this.status.HeaderText = "GiveBookBack";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.Width = 150;
            // 
            // FormPhieuThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 967);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnXoaCheckBox);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormPhieuThuTien";
            this.Text = "FormPhieuThuTien";
            this.Load += new System.EventHandler(this.FormPhieuThuTien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTenSach;
        private System.Windows.Forms.ComboBox cbHoTenNV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoTienThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHoTenDocGia;
        private System.Windows.Forms.TextBox txtTienNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePickerNM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoaCheckBox;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView GridViewPTT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
    }
}