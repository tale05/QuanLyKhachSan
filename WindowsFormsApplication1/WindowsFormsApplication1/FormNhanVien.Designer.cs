namespace WindowsFormsApplication1
{
    partial class FormNhanVien
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
            this.txt_ngaysinhnv = new System.Windows.Forms.DateTimePicker();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_passwordnv = new System.Windows.Forms.TextBox();
            this.txt_cmndnv = new System.Windows.Forms.TextBox();
            this.txt_sdtnv = new System.Windows.Forms.TextBox();
            this.txt_usernamenv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nhapmaNV_search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_hotennv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_thongtinKH = new System.Windows.Forms.Label();
            this.txt_emailnv = new System.Windows.Forms.TextBox();
            this.txt_diachinv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_returnfrmMain
            // 
            this.btn_returnfrmMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_returnfrmMain.Location = new System.Drawing.Point(961, 789);
            this.btn_returnfrmMain.Name = "btn_returnfrmMain";
            this.btn_returnfrmMain.Size = new System.Drawing.Size(107, 29);
            this.btn_returnfrmMain.TabIndex = 31;
            this.btn_returnfrmMain.Text = "Trang Chủ >>";
            this.btn_returnfrmMain.UseVisualStyleBackColor = true;
            this.btn_returnfrmMain.Click += new System.EventHandler(this.btn_returnfrmMain_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(591, 502);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(107, 29);
            this.btn_search.TabIndex = 29;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(287, 371);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(107, 34);
            this.btn_edit.TabIndex = 23;
            this.btn_edit.Text = "Chỉnh Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_khoitao
            // 
            this.btn_khoitao.Location = new System.Drawing.Point(174, 371);
            this.btn_khoitao.Name = "btn_khoitao";
            this.btn_khoitao.Size = new System.Drawing.Size(107, 34);
            this.btn_khoitao.TabIndex = 22;
            this.btn_khoitao.Text = "Khởi Tạo";
            this.btn_khoitao.UseVisualStyleBackColor = true;
            this.btn_khoitao.Click += new System.EventHandler(this.btn_khoitao_Click);
            // 
            // txt_ngaysinhnv
            // 
            this.txt_ngaysinhnv.CustomFormat = "dd/MM/yyyy";
            this.txt_ngaysinhnv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaysinhnv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_ngaysinhnv.Location = new System.Drawing.Point(199, 176);
            this.txt_ngaysinhnv.Name = "txt_ngaysinhnv";
            this.txt_ngaysinhnv.Size = new System.Drawing.Size(256, 29);
            this.txt_ngaysinhnv.TabIndex = 21;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(739, 371);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(107, 34);
            this.btn_reset.TabIndex = 20;
            this.btn_reset.Text = "Nhập Lại";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(626, 370);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(107, 34);
            this.btn_sua.TabIndex = 19;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(513, 371);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(107, 34);
            this.btn_xoa.TabIndex = 18;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(400, 371);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(107, 34);
            this.btn_them.TabIndex = 17;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_passwordnv
            // 
            this.txt_passwordnv.Location = new System.Drawing.Point(681, 242);
            this.txt_passwordnv.Name = "txt_passwordnv";
            this.txt_passwordnv.Size = new System.Drawing.Size(256, 26);
            this.txt_passwordnv.TabIndex = 8;
            // 
            // txt_cmndnv
            // 
            this.txt_cmndnv.Location = new System.Drawing.Point(681, 59);
            this.txt_cmndnv.Name = "txt_cmndnv";
            this.txt_cmndnv.Size = new System.Drawing.Size(256, 26);
            this.txt_cmndnv.TabIndex = 5;
            // 
            // txt_sdtnv
            // 
            this.txt_sdtnv.Location = new System.Drawing.Point(681, 119);
            this.txt_sdtnv.Name = "txt_sdtnv";
            this.txt_sdtnv.Size = new System.Drawing.Size(256, 26);
            this.txt_sdtnv.TabIndex = 6;
            // 
            // txt_usernamenv
            // 
            this.txt_usernamenv.Location = new System.Drawing.Point(681, 179);
            this.txt_usernamenv.Name = "txt_usernamenv";
            this.txt_usernamenv.Size = new System.Drawing.Size(256, 26);
            this.txt_usernamenv.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tạo Password NV";
            // 
            // txt_nhapmaNV_search
            // 
            this.txt_nhapmaNV_search.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhapmaNV_search.Location = new System.Drawing.Point(420, 502);
            this.txt_nhapmaNV_search.Name = "txt_nhapmaNV_search";
            this.txt_nhapmaNV_search.Size = new System.Drawing.Size(165, 27);
            this.txt_nhapmaNV_search.TabIndex = 27;
            this.txt_nhapmaNV_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(103, 507);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(310, 22);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tìm Kiếm Khách Hàng Theo Mã NV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tạo Username NV";
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
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(199, 59);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(256, 26);
            this.txt_manv.TabIndex = 1;
            // 
            // txt_hotennv
            // 
            this.txt_hotennv.Location = new System.Drawing.Point(199, 119);
            this.txt_hotennv.Name = "txt_hotennv";
            this.txt_hotennv.Size = new System.Drawing.Size(256, 26);
            this.txt_hotennv.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập Email NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Họ Tên NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã NV";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvNhanVien.Location = new System.Drawing.Point(62, 537);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1006, 236);
            this.dgvNhanVien.TabIndex = 30;
            this.dgvNhanVien.Click += new System.EventHandler(this.dgvNhanVien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_diachinv);
            this.groupBox1.Controls.Add(this.txt_emailnv);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_khoitao);
            this.groupBox1.Controls.Add(this.txt_ngaysinhnv);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.txt_passwordnv);
            this.groupBox1.Controls.Add(this.txt_cmndnv);
            this.groupBox1.Controls.Add(this.txt_sdtnv);
            this.groupBox1.Controls.Add(this.txt_usernamenv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_manv);
            this.groupBox1.Controls.Add(this.txt_hotennv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(62, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1006, 426);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Thông Tin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nhập CMND NV";
            // 
            // lb_thongtinKH
            // 
            this.lb_thongtinKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_thongtinKH.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongtinKH.Location = new System.Drawing.Point(0, 0);
            this.lb_thongtinKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_thongtinKH.Name = "lb_thongtinKH";
            this.lb_thongtinKH.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.lb_thongtinKH.Size = new System.Drawing.Size(1130, 58);
            this.lb_thongtinKH.TabIndex = 25;
            this.lb_thongtinKH.Text = "THÔNG TIN NHÂN VIÊN";
            this.lb_thongtinKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_emailnv
            // 
            this.txt_emailnv.Location = new System.Drawing.Point(199, 242);
            this.txt_emailnv.Name = "txt_emailnv";
            this.txt_emailnv.Size = new System.Drawing.Size(256, 26);
            this.txt_emailnv.TabIndex = 24;
            // 
            // txt_diachinv
            // 
            this.txt_diachinv.Location = new System.Drawing.Point(199, 304);
            this.txt_diachinv.Name = "txt_diachinv";
            this.txt_diachinv.Size = new System.Drawing.Size(256, 26);
            this.txt_diachinv.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "Nhập Địa Chỉ NV";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 830);
            this.Controls.Add(this.btn_returnfrmMain);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_nhapmaNV_search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_thongtinKH);
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
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
        private System.Windows.Forms.DateTimePicker txt_ngaysinhnv;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_passwordnv;
        private System.Windows.Forms.TextBox txt_cmndnv;
        private System.Windows.Forms.TextBox txt_sdtnv;
        private System.Windows.Forms.TextBox txt_usernamenv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nhapmaNV_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_hotennv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_thongtinKH;
        private System.Windows.Forms.TextBox txt_emailnv;
        private System.Windows.Forms.TextBox txt_diachinv;
        private System.Windows.Forms.Label label10;
    }
}