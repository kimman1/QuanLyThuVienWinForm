namespace WindowsFormsApp1
{
    partial class QlyPM
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
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GridViewPM = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btnXoaCheckBox = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(27, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(739, 50);
            this.label8.TabIndex = 18;
            this.label8.Text = "DANH MỤC PHIẾU MƯỢN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(378, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 99);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(258, 28);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 54);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(174, 28);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 54);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(90, 28);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 54);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 54);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GridViewPM);
            this.groupBox3.Location = new System.Drawing.Point(37, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(729, 215);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chung";
            // 
            // GridViewPM
            // 
            this.GridViewPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewPM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status});
            this.GridViewPM.Location = new System.Drawing.Point(6, 19);
            this.GridViewPM.Name = "GridViewPM";
            this.GridViewPM.RowHeadersWidth = 62;
            this.GridViewPM.Size = new System.Drawing.Size(717, 190);
            this.GridViewPM.TabIndex = 19;
            this.GridViewPM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewPM_CellClick);
            this.GridViewPM.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewPM_CellDoubleClick);
            // 
            // status
            // 
            this.status.HeaderText = "GiveBookBack";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.Width = 150;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, -86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 49);
            this.label1.TabIndex = 16;
            this.label1.Text = "Danh mục nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sách:";
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
            this.groupBox1.Location = new System.Drawing.Point(27, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 198);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbTenSach
            // 
            this.cbTenSach.FormattingEnabled = true;
            this.cbTenSach.Location = new System.Drawing.Point(81, 51);
            this.cbTenSach.Name = "cbTenSach";
            this.cbTenSach.Size = new System.Drawing.Size(200, 21);
            this.cbTenSach.TabIndex = 22;
            // 
            // cbHoTenNV
            // 
            this.cbHoTenNV.FormattingEnabled = true;
            this.cbHoTenNV.Location = new System.Drawing.Point(476, 93);
            this.cbHoTenNV.Name = "cbHoTenNV";
            this.cbHoTenNV.Size = new System.Drawing.Size(200, 21);
            this.cbHoTenNV.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(398, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Họ tên NV:";
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.Location = new System.Drawing.Point(475, 57);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(200, 20);
            this.txtSoTienThu.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số tiền thu:";
            // 
            // cbHoTenDocGia
            // 
            this.cbHoTenDocGia.FormattingEnabled = true;
            this.cbHoTenDocGia.Location = new System.Drawing.Point(81, 128);
            this.cbHoTenDocGia.Name = "cbHoTenDocGia";
            this.cbHoTenDocGia.Size = new System.Drawing.Size(200, 21);
            this.cbHoTenDocGia.TabIndex = 17;
            // 
            // txtTienNo
            // 
            this.txtTienNo.Location = new System.Drawing.Point(475, 128);
            this.txtTienNo.Name = "txtTienNo";
            this.txtTienNo.Size = new System.Drawing.Size(200, 20);
            this.txtTienNo.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(402, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tiền Nợ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Họ tên độc giả:";
            // 
            // datePickerNM
            // 
            this.datePickerNM.Location = new System.Drawing.Point(81, 94);
            this.datePickerNM.Name = "datePickerNM";
            this.datePickerNM.Size = new System.Drawing.Size(200, 20);
            this.datePickerNM.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày mượn:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnXoaCheckBox
            // 
            this.btnXoaCheckBox.Location = new System.Drawing.Point(289, 308);
            this.btnXoaCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaCheckBox.Name = "btnXoaCheckBox";
            this.btnXoaCheckBox.Size = new System.Drawing.Size(85, 54);
            this.btnXoaCheckBox.TabIndex = 19;
            this.btnXoaCheckBox.Text = "Xóa danh sách đã chọn";
            this.btnXoaCheckBox.UseVisualStyleBackColor = true;
            this.btnXoaCheckBox.Click += new System.EventHandler(this.btnXoaList_Click);
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(200, 308);
            this.btnTraSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(85, 54);
            this.btnTraSach.TabIndex = 20;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.BtnTraSach_Click);
            // 
            // QlyPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 487);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.btnXoaCheckBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "QlyPM";
            this.Text = "QlyPM";
            this.Load += new System.EventHandler(this.QlyPM_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTienNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePickerNM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHoTenDocGia;
        private System.Windows.Forms.TextBox txtSoTienThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHoTenNV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView GridViewPM;
        private System.Windows.Forms.ComboBox cbTenSach;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.Button btnXoaCheckBox;
        private System.Windows.Forms.Button btnTraSach;
    }
}