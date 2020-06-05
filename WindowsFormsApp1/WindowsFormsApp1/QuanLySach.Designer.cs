namespace WindowsFormsApp1
{
    partial class QuanLySach
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GridViewSach = new System.Windows.Forms.DataGridView();
            this.btnThoatSach = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.datePickerNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datePickerNXB = new System.Windows.Forms.DateTimePicker();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GridViewSach);
            this.groupBox3.Location = new System.Drawing.Point(56, 528);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1094, 331);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chung";
            // 
            // GridViewSach
            // 
            this.GridViewSach.AllowUserToAddRows = false;
            this.GridViewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewSach.Location = new System.Drawing.Point(15, 29);
            this.GridViewSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridViewSach.Name = "GridViewSach";
            this.GridViewSach.RowHeadersWidth = 62;
            this.GridViewSach.Size = new System.Drawing.Size(1056, 292);
            this.GridViewSach.TabIndex = 0;
            this.GridViewSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewSach_CellClick);
            // 
            // btnThoatSach
            // 
            this.btnThoatSach.Location = new System.Drawing.Point(387, 25);
            this.btnThoatSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoatSach.Name = "btnThoatSach";
            this.btnThoatSach.Size = new System.Drawing.Size(117, 83);
            this.btnThoatSach.TabIndex = 3;
            this.btnThoatSach.Text = "Thoát";
            this.btnThoatSach.UseVisualStyleBackColor = true;
            this.btnThoatSach.Click += new System.EventHandler(this.BtnThoatSach_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(135, 25);
            this.btnXoaSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(117, 83);
            this.btnXoaSach.TabIndex = 1;
            this.btnXoaSach.Text = "Xoá";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.BtnXoaSach_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(46, -185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1108, 75);
            this.label1.TabIndex = 21;
            this.label1.Text = "Danh mục nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoatSach);
            this.groupBox2.Controls.Add(this.btnXoaSach);
            this.groupBox2.Controls.Add(this.btnThemSach);
            this.groupBox2.Location = new System.Drawing.Point(567, 366);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(582, 152);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(9, 25);
            this.btnThemSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(117, 83);
            this.btnThemSach.TabIndex = 0;
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.BtnThemSach_Click);
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(122, 246);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(298, 26);
            this.txtGiaTien.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 251);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Trị giá:";
            // 
            // datePickerNgayNhap
            // 
            this.datePickerNgayNhap.CustomFormat = "";
            this.datePickerNgayNhap.Location = new System.Drawing.Point(732, 137);
            this.datePickerNgayNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datePickerNgayNhap.Name = "datePickerNgayNhap";
            this.datePickerNgayNhap.Size = new System.Drawing.Size(298, 26);
            this.datePickerNgayNhap.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày Nhập:";
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(122, 186);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(298, 26);
            this.txtNXB.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(57, -5);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1096, 77);
            this.label8.TabIndex = 23;
            this.label8.Text = "DANH MỤC SÁCH";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.groupBox1.Location = new System.Drawing.Point(56, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1096, 305);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nhà Xuất Bản:";
            // 
            // datePickerNXB
            // 
            this.datePickerNXB.CustomFormat = "";
            this.datePickerNXB.Location = new System.Drawing.Point(122, 126);
            this.datePickerNXB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datePickerNXB.Name = "datePickerNXB";
            this.datePickerNXB.Size = new System.Drawing.Size(298, 26);
            this.datePickerNXB.TabIndex = 8;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(732, 88);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(296, 26);
            this.txtTacGia.TabIndex = 7;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(122, 69);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(298, 26);
            this.txtTenSach.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tác giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày Xuất Bản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sách:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(41, 421);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 53);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(185, 421);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(307, 53);
            this.txtSearch.TabIndex = 25;
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 877);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuanLySach";
            this.Text = "QuanLySach";
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThoatSach;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker datePickerNgayNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePickerNXB;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridViewSach;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}