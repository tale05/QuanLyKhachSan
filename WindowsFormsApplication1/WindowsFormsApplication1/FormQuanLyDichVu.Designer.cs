namespace WindowsFormsApplication1
{
    partial class FormQuanLyDichVu
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_nhapmadichvu_search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_khoitao = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_dongiadichvu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_madichvu = new System.Windows.Forms.TextBox();
            this.txt_tendichvu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_returnfrmMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_thongtinKH
            // 
            this.lb_thongtinKH.AutoSize = true;
            this.lb_thongtinKH.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongtinKH.Location = new System.Drawing.Point(351, 4);
            this.lb_thongtinKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_thongtinKH.Name = "lb_thongtinKH";
            this.lb_thongtinKH.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.lb_thongtinKH.Size = new System.Drawing.Size(409, 58);
            this.lb_thongtinKH.TabIndex = 39;
            this.lb_thongtinKH.Text = "THÔNG TIN DỊCH VỤ";
            this.lb_thongtinKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(305, 178);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(107, 34);
            this.btn_edit.TabIndex = 23;
            this.btn_edit.Text = "Chỉnh Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_nhapmadichvu_search
            // 
            this.txt_nhapmadichvu_search.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhapmadichvu_search.Location = new System.Drawing.Point(438, 320);
            this.txt_nhapmadichvu_search.Name = "txt_nhapmadichvu_search";
            this.txt_nhapmadichvu_search.Size = new System.Drawing.Size(165, 27);
            this.txt_nhapmadichvu_search.TabIndex = 41;
            this.txt_nhapmadichvu_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(97, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(313, 22);
            this.label9.TabIndex = 42;
            this.label9.Text = "Tìm Kiếm Dịch Vụ Theo Mã Dịch Vụ";
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiPhong.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLoaiPhong.Location = new System.Drawing.Point(54, 364);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.ReadOnly = true;
            this.dgvLoaiPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(1006, 257);
            this.dgvLoaiPhong.TabIndex = 44;
            this.dgvLoaiPhong.Click += new System.EventHandler(this.dgvLoaiPhong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_khoitao);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.txt_dongiadichvu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_madichvu);
            this.groupBox1.Controls.Add(this.txt_tendichvu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1006, 231);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Thông Tin";
            // 
            // btn_khoitao
            // 
            this.btn_khoitao.Location = new System.Drawing.Point(192, 178);
            this.btn_khoitao.Name = "btn_khoitao";
            this.btn_khoitao.Size = new System.Drawing.Size(107, 34);
            this.btn_khoitao.TabIndex = 22;
            this.btn_khoitao.Text = "Khởi Tạo";
            this.btn_khoitao.UseVisualStyleBackColor = true;
            this.btn_khoitao.Click += new System.EventHandler(this.btn_khoitao_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(757, 178);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(107, 34);
            this.btn_reset.TabIndex = 20;
            this.btn_reset.Text = "Nhập Lại";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(644, 177);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(107, 34);
            this.btn_sua.TabIndex = 19;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(531, 178);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(107, 34);
            this.btn_xoa.TabIndex = 18;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(418, 178);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(107, 34);
            this.btn_them.TabIndex = 17;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_dongiadichvu
            // 
            this.txt_dongiadichvu.Location = new System.Drawing.Point(683, 87);
            this.txt_dongiadichvu.Name = "txt_dongiadichvu";
            this.txt_dongiadichvu.Size = new System.Drawing.Size(256, 26);
            this.txt_dongiadichvu.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Đơn Giá Dịch Vụ";
            // 
            // txt_madichvu
            // 
            this.txt_madichvu.Location = new System.Drawing.Point(199, 59);
            this.txt_madichvu.Name = "txt_madichvu";
            this.txt_madichvu.Size = new System.Drawing.Size(256, 26);
            this.txt_madichvu.TabIndex = 1;
            // 
            // txt_tendichvu
            // 
            this.txt_tendichvu.Location = new System.Drawing.Point(199, 119);
            this.txt_tendichvu.Name = "txt_tendichvu";
            this.txt_tendichvu.Size = new System.Drawing.Size(256, 26);
            this.txt_tendichvu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Tên Dịch Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã Dịch Vụ";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(609, 320);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(107, 29);
            this.btn_search.TabIndex = 43;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_returnfrmMain
            // 
            this.btn_returnfrmMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_returnfrmMain.Location = new System.Drawing.Point(953, 640);
            this.btn_returnfrmMain.Name = "btn_returnfrmMain";
            this.btn_returnfrmMain.Size = new System.Drawing.Size(107, 29);
            this.btn_returnfrmMain.TabIndex = 45;
            this.btn_returnfrmMain.Text = "Trang Chủ >>";
            this.btn_returnfrmMain.UseVisualStyleBackColor = true;
            this.btn_returnfrmMain.Click += new System.EventHandler(this.btn_returnfrmMain_Click);
            // 
            // FormQuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 686);
            this.Controls.Add(this.lb_thongtinKH);
            this.Controls.Add(this.txt_nhapmadichvu_search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvLoaiPhong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_returnfrmMain);
            this.Name = "FormQuanLyDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLyDichVu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQuanLyDichVu_FormClosing);
            this.Load += new System.EventHandler(this.FormQuanLyDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_thongtinKH;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_nhapmadichvu_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvLoaiPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_khoitao;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_dongiadichvu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_madichvu;
        private System.Windows.Forms.TextBox txt_tendichvu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_returnfrmMain;
    }
}