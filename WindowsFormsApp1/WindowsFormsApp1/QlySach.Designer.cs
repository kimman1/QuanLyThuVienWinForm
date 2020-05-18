namespace WindowsFormsApp1
{
    partial class QlySach
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
            this.LVSach = new System.Windows.Forms.ListView();
            this.MaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TacGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamXuatBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NhaXuatBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TriGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.datePickerNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datePickerNXB = new System.Windows.Forms.DateTimePicker();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoatSach = new System.Windows.Forms.Button();
            this.btnSuaSach = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LVSach
            // 
            this.LVSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSach,
            this.TenSach,
            this.TacGia,
            this.NamXuatBan,
            this.NhaXuatBan,
            this.TriGia,
            this.NgayNhap});
            this.LVSach.HideSelection = false;
            this.LVSach.Location = new System.Drawing.Point(14, 19);
            this.LVSach.Name = "LVSach";
            this.LVSach.Size = new System.Drawing.Size(717, 181);
            this.LVSach.TabIndex = 1;
            this.LVSach.UseCompatibleStateImageBehavior = false;
            this.LVSach.View = System.Windows.Forms.View.Details;
            this.LVSach.SelectedIndexChanged += new System.EventHandler(this.LVSach_SelectedIndexChanged);
            // 
            // MaSach
            // 
            this.MaSach.Text = "Mã Sách";
            // 
            // TenSach
            // 
            this.TenSach.Text = "Tên Sách";
            // 
            // TacGia
            // 
            this.TacGia.Text = "Tác Giả";
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.Text = "Năm Xuất Bản";
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.Text = "Nhà Xuất Bản";
            // 
            // TriGia
            // 
            this.TriGia.DisplayIndex = 6;
            this.TriGia.Text = "Trị Giá";
            // 
            // NgayNhap
            // 
            this.NgayNhap.DisplayIndex = 5;
            this.NgayNhap.Text = "Ngày Nhập";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(81, 172);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(200, 20);
            this.txtGiaTien.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Trị giá:";
            // 
            // datePickerNgayNhap
            // 
            this.datePickerNgayNhap.CustomFormat = "";
            this.datePickerNgayNhap.Location = new System.Drawing.Point(488, 101);
            this.datePickerNgayNhap.Name = "datePickerNgayNhap";
            this.datePickerNgayNhap.Size = new System.Drawing.Size(200, 20);
            this.datePickerNgayNhap.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày Nhập:";
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(81, 133);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(200, 20);
            this.txtNXB.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nhà Xuất Bản:";
            // 
            // datePickerNXB
            // 
            this.datePickerNXB.CustomFormat = "";
            this.datePickerNXB.Location = new System.Drawing.Point(81, 94);
            this.datePickerNXB.Name = "datePickerNXB";
            this.datePickerNXB.Size = new System.Drawing.Size(200, 20);
            this.datePickerNXB.TabIndex = 8;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(488, 69);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(199, 20);
            this.txtTacGia.TabIndex = 7;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(81, 57);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(200, 20);
            this.txtTenSach.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tác giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày Xuất Bản:";
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
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sách:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoatSach);
            this.groupBox2.Controls.Add(this.btnSuaSach);
            this.groupBox2.Controls.Add(this.btnXoaSach);
            this.groupBox2.Controls.Add(this.btnThemSach);
            this.groupBox2.Location = new System.Drawing.Point(376, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 99);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // btnThoatSach
            // 
            this.btnThoatSach.Location = new System.Drawing.Point(258, 28);
            this.btnThoatSach.Name = "btnThoatSach";
            this.btnThoatSach.Size = new System.Drawing.Size(78, 54);
            this.btnThoatSach.TabIndex = 3;
            this.btnThoatSach.Text = "Thoát";
            this.btnThoatSach.UseVisualStyleBackColor = true;
            this.btnThoatSach.Click += new System.EventHandler(this.BtnThoatSach_Click);
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.Location = new System.Drawing.Point(174, 28);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(78, 54);
            this.btnSuaSach.TabIndex = 2;
            this.btnSuaSach.Text = "Sửa";
            this.btnSuaSach.UseVisualStyleBackColor = true;
            this.btnSuaSach.Click += new System.EventHandler(this.BtnSuaSach_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(90, 28);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(78, 54);
            this.btnXoaSach.TabIndex = 1;
            this.btnXoaSach.Text = "Xoá";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.BtnXoaSach_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(6, 28);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(78, 54);
            this.btnThemSach.TabIndex = 0;
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.BtnThemSach_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(33, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(731, 50);
            this.label8.TabIndex = 18;
            this.label8.Text = "DANH MỤC SÁCH";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGiaTien);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.datePickerNgayNhap);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNXB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.datePickerNXB);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(33, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 198);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LVSach);
            this.groupBox3.Location = new System.Drawing.Point(33, 366);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(729, 215);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chung";
            // 
            // QlySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "QlySach";
            this.Text = "QlySach";
            this.Load += new System.EventHandler(this.QlySach_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LVSach;
        private System.Windows.Forms.ColumnHeader MaSach;
        private System.Windows.Forms.ColumnHeader TenSach;
        private System.Windows.Forms.ColumnHeader TacGia;
        private System.Windows.Forms.ColumnHeader NamXuatBan;
        private System.Windows.Forms.ColumnHeader NhaXuatBan;
        private System.Windows.Forms.ColumnHeader NgayNhap;
        private System.Windows.Forms.ColumnHeader TriGia;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker datePickerNgayNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePickerNXB;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoatSach;
        private System.Windows.Forms.Button btnSuaSach;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}