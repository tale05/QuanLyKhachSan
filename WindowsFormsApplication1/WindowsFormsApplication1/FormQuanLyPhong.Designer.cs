namespace WindowsFormsApplication1
{
    partial class FormQuanLyPhong
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
            this.btn_returnfrmMain = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_khoitao = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_nhapmaphong_search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.txt_tenphong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_trangthai = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbo_maloaiphong = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_thongtinKH = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_returnfrmMain
            // 
            this.btn_returnfrmMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_returnfrmMain.Location = new System.Drawing.Point(1283, 780);
            this.btn_returnfrmMain.Margin = new System.Windows.Forms.Padding(4);
            this.btn_returnfrmMain.Name = "btn_returnfrmMain";
            this.btn_returnfrmMain.Size = new System.Drawing.Size(143, 36);
            this.btn_returnfrmMain.TabIndex = 31;
            this.btn_returnfrmMain.Text = "Trang Chủ >>";
            this.btn_returnfrmMain.UseVisualStyleBackColor = true;
            this.btn_returnfrmMain.Click += new System.EventHandler(this.btn_returnfrmMain_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(824, 386);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(143, 36);
            this.btn_search.TabIndex = 29;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(407, 219);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(143, 42);
            this.btn_edit.TabIndex = 23;
            this.btn_edit.Text = "Chỉnh Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_khoitao
            // 
            this.btn_khoitao.Location = new System.Drawing.Point(256, 219);
            this.btn_khoitao.Margin = new System.Windows.Forms.Padding(4);
            this.btn_khoitao.Name = "btn_khoitao";
            this.btn_khoitao.Size = new System.Drawing.Size(143, 42);
            this.btn_khoitao.TabIndex = 22;
            this.btn_khoitao.Text = "Khởi Tạo";
            this.btn_khoitao.UseVisualStyleBackColor = true;
            this.btn_khoitao.Click += new System.EventHandler(this.btn_khoitao_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(1009, 219);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(143, 42);
            this.btn_reset.TabIndex = 20;
            this.btn_reset.Text = "Nhập Lại";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(859, 218);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(143, 42);
            this.btn_sua.TabIndex = 19;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(708, 219);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(143, 42);
            this.btn_xoa.TabIndex = 18;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(557, 219);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(143, 42);
            this.btn_them.TabIndex = 17;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_nhapmaphong_search
            // 
            this.txt_nhapmaphong_search.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhapmaphong_search.Location = new System.Drawing.Point(596, 386);
            this.txt_nhapmaphong_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nhapmaphong_search.Name = "txt_nhapmaphong_search";
            this.txt_nhapmaphong_search.Size = new System.Drawing.Size(219, 32);
            this.txt_nhapmaphong_search.TabIndex = 27;
            this.txt_nhapmaphong_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(141, 388);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(420, 26);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tìm Kiếm Khách Hàng Theo Mã Phòng\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(700, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nhập Trạng Thái";
            // 
            // txt_maphong
            // 
            this.txt_maphong.Location = new System.Drawing.Point(265, 73);
            this.txt_maphong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(340, 30);
            this.txt_maphong.TabIndex = 1;
            // 
            // txt_tenphong
            // 
            this.txt_tenphong.Location = new System.Drawing.Point(265, 146);
            this.txt_tenphong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenphong.Name = "txt_tenphong";
            this.txt_tenphong.Size = new System.Drawing.Size(340, 30);
            this.txt_tenphong.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Tên Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã Phòng";
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPhong.Location = new System.Drawing.Point(84, 441);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(1341, 316);
            this.dgvPhong.TabIndex = 30;
            this.dgvPhong.Click += new System.EventHandler(this.dgvPhong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbo_trangthai);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbo_maloaiphong);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_khoitao);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_maphong);
            this.groupBox1.Controls.Add(this.txt_tenphong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(84, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1341, 284);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Thông Tin";
            // 
            // cbo_trangthai
            // 
            this.cbo_trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_trangthai.FormattingEnabled = true;
            this.cbo_trangthai.Items.AddRange(new object[] {
            "Trống",
            "Có Khách"});
            this.cbo_trangthai.Location = new System.Drawing.Point(908, 146);
            this.cbo_trangthai.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_trangthai.Name = "cbo_trangthai";
            this.cbo_trangthai.Size = new System.Drawing.Size(357, 30);
            this.cbo_trangthai.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1149, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "Xem Loại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbo_maloaiphong
            // 
            this.cbo_maloaiphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_maloaiphong.FormattingEnabled = true;
            this.cbo_maloaiphong.Location = new System.Drawing.Point(908, 71);
            this.cbo_maloaiphong.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_maloaiphong.Name = "cbo_maloaiphong";
            this.cbo_maloaiphong.Size = new System.Drawing.Size(223, 30);
            this.cbo_maloaiphong.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(700, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nhập Mã Loại Phòng";
            // 
            // lb_thongtinKH
            // 
            this.lb_thongtinKH.AutoSize = true;
            this.lb_thongtinKH.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongtinKH.Location = new System.Drawing.Point(501, -2);
            this.lb_thongtinKH.Name = "lb_thongtinKH";
            this.lb_thongtinKH.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.lb_thongtinKH.Size = new System.Drawing.Size(486, 73);
            this.lb_thongtinKH.TabIndex = 25;
            this.lb_thongtinKH.Text = "THÔNG TIN PHÒNG";
            this.lb_thongtinKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1132, 780);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 36);
            this.button2.TabIndex = 32;
            this.button2.Text = "Đặt Phòng >>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1511, 832);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_returnfrmMain);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_nhapmaphong_search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_thongtinKH);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQuanLyPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLyPhong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQuanLyPhong_FormClosing);
            this.Load += new System.EventHandler(this.FormQuanLyPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_returnfrmMain;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_khoitao;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_nhapmaphong_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_maphong;
        private System.Windows.Forms.TextBox txt_tenphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_thongtinKH;
        private System.Windows.Forms.ComboBox cbo_maloaiphong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbo_trangthai;
        private System.Windows.Forms.Button button2;
    }
}