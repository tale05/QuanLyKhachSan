namespace WindowsFormsApplication1
{
    partial class FormKhachHang
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
            this.lb_thongtinKH = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_khoitao = new System.Windows.Forms.Button();
            this.txt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_quoctich = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_gioitinh = new System.Windows.Forms.ComboBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nhapmaKH_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.btn_returnfrmMain = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_thongtinKH
            // 
            this.lb_thongtinKH.AutoSize = true;
            this.lb_thongtinKH.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongtinKH.Location = new System.Drawing.Point(311, 9);
            this.lb_thongtinKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_thongtinKH.Name = "lb_thongtinKH";
            this.lb_thongtinKH.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.lb_thongtinKH.Size = new System.Drawing.Size(515, 58);
            this.lb_thongtinKH.TabIndex = 0;
            this.lb_thongtinKH.Text = "THÔNG TIN KHÁCH HÀNG";
            this.lb_thongtinKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_khoitao);
            this.groupBox1.Controls.Add(this.txt_ngaysinh);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_cmnd);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_quoctich);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbo_gioitinh);
            this.groupBox1.Controls.Add(this.txt_makh);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1006, 371);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Thông Tin";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(300, 312);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(107, 34);
            this.btn_edit.TabIndex = 23;
            this.btn_edit.Text = "Chỉnh Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_khoitao
            // 
            this.btn_khoitao.Location = new System.Drawing.Point(187, 312);
            this.btn_khoitao.Name = "btn_khoitao";
            this.btn_khoitao.Size = new System.Drawing.Size(107, 34);
            this.btn_khoitao.TabIndex = 22;
            this.btn_khoitao.Text = "Khởi Tạo";
            this.btn_khoitao.UseVisualStyleBackColor = true;
            this.btn_khoitao.Click += new System.EventHandler(this.btn_khoitao_Click);
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.txt_ngaysinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_ngaysinh.Location = new System.Drawing.Point(199, 176);
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.Size = new System.Drawing.Size(256, 29);
            this.txt_ngaysinh.TabIndex = 21;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(752, 312);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(107, 34);
            this.btn_reset.TabIndex = 20;
            this.btn_reset.Text = "Nhập Lại";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(639, 311);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(107, 34);
            this.btn_sua.TabIndex = 19;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(526, 312);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(107, 34);
            this.btn_xoa.TabIndex = 18;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(413, 312);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(107, 34);
            this.btn_them.TabIndex = 17;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(681, 242);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(256, 26);
            this.txt_diachi.TabIndex = 8;
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Location = new System.Drawing.Point(681, 59);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(256, 26);
            this.txt_cmnd.TabIndex = 5;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(681, 119);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(256, 26);
            this.txt_sdt.TabIndex = 6;
            // 
            // txt_quoctich
            // 
            this.txt_quoctich.Location = new System.Drawing.Point(681, 179);
            this.txt_quoctich.Name = "txt_quoctich";
            this.txt_quoctich.Size = new System.Drawing.Size(256, 26);
            this.txt_quoctich.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhập Địa Chỉ KH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nhập Quốc Tịch KH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nhập SDT  KH";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nhập CMND KH";
            // 
            // cbo_gioitinh
            // 
            this.cbo_gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_gioitinh.FormattingEnabled = true;
            this.cbo_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_gioitinh.Location = new System.Drawing.Point(199, 242);
            this.cbo_gioitinh.Name = "cbo_gioitinh";
            this.cbo_gioitinh.Size = new System.Drawing.Size(256, 27);
            this.cbo_gioitinh.TabIndex = 4;
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(199, 59);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(256, 26);
            this.txt_makh.TabIndex = 1;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(199, 119);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(256, 26);
            this.txt_hoten.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập Giới Tính KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập Ngày Sinh KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Họ Tên KH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã KH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(103, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tìm Kiếm Nhân Viên Theo Mã KH";
            // 
            // txt_nhapmaKH_search
            // 
            this.txt_nhapmaKH_search.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhapmaKH_search.Location = new System.Drawing.Point(420, 454);
            this.txt_nhapmaKH_search.Name = "txt_nhapmaKH_search";
            this.txt_nhapmaKH_search.Size = new System.Drawing.Size(165, 27);
            this.txt_nhapmaKH_search.TabIndex = 21;
            this.txt_nhapmaKH_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(591, 454);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(107, 29);
            this.btn_search.TabIndex = 22;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvKhachHang.Location = new System.Drawing.Point(60, 502);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(1006, 236);
            this.dgvKhachHang.TabIndex = 23;
            this.dgvKhachHang.Click += new System.EventHandler(this.dgvKhachHang_Click);
            // 
            // btn_returnfrmMain
            // 
            this.btn_returnfrmMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_returnfrmMain.Location = new System.Drawing.Point(959, 755);
            this.btn_returnfrmMain.Name = "btn_returnfrmMain";
            this.btn_returnfrmMain.Size = new System.Drawing.Size(107, 29);
            this.btn_returnfrmMain.TabIndex = 24;
            this.btn_returnfrmMain.Text = "Trang Chủ >>";
            this.btn_returnfrmMain.UseVisualStyleBackColor = true;
            this.btn_returnfrmMain.Click += new System.EventHandler(this.btn_returnfrmMain_Click);
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 797);
            this.Controls.Add(this.btn_returnfrmMain);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_nhapmaKH_search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_thongtinKH);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKhachHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_thongtinKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_quoctich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_gioitinh;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nhapmaKH_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DateTimePicker txt_ngaysinh;
        private System.Windows.Forms.Button btn_khoitao;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_returnfrmMain;
    }
}