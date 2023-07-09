namespace WindowsFormsApplication1
{
    partial class FormHoaDonDichVu
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
            this.dgv_chitietsdDV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_idkhachhang = new System.Windows.Forms.TextBox();
            this.txt_iddichvu = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thanhtoandichvu = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_tongtiendichvu = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_DichVu = new System.Windows.Forms.DataGridView();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietsdDV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1095, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn Dịch Vụ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_chitietsdDV
            // 
            this.dgv_chitietsdDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_chitietsdDV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_chitietsdDV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_chitietsdDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitietsdDV.Location = new System.Drawing.Point(37, 87);
            this.dgv_chitietsdDV.Name = "dgv_chitietsdDV";
            this.dgv_chitietsdDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_chitietsdDV.Size = new System.Drawing.Size(504, 182);
            this.dgv_chitietsdDV.TabIndex = 1;
            this.dgv_chitietsdDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitietsdDV_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_idkhachhang);
            this.groupBox1.Controls.Add(this.txt_iddichvu);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_thanhtoandichvu);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.txt_tongtiendichvu);
            this.groupBox1.Controls.Add(this.txt_soluong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(320, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 284);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Sử Dụng Dịch Vụ";
            // 
            // txt_idkhachhang
            // 
            this.txt_idkhachhang.Location = new System.Drawing.Point(164, 83);
            this.txt_idkhachhang.Name = "txt_idkhachhang";
            this.txt_idkhachhang.Size = new System.Drawing.Size(145, 26);
            this.txt_idkhachhang.TabIndex = 15;
            // 
            // txt_iddichvu
            // 
            this.txt_iddichvu.Location = new System.Drawing.Point(164, 42);
            this.txt_iddichvu.Name = "txt_iddichvu";
            this.txt_iddichvu.Size = new System.Drawing.Size(145, 26);
            this.txt_iddichvu.TabIndex = 14;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(315, 238);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(145, 29);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(13, 238);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(145, 29);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_thanhtoandichvu
            // 
            this.btn_thanhtoandichvu.Location = new System.Drawing.Point(164, 203);
            this.btn_thanhtoandichvu.Name = "btn_thanhtoandichvu";
            this.btn_thanhtoandichvu.Size = new System.Drawing.Size(145, 29);
            this.btn_thanhtoandichvu.TabIndex = 9;
            this.btn_thanhtoandichvu.Text = "Thanh Toán";
            this.btn_thanhtoandichvu.UseVisualStyleBackColor = true;
            this.btn_thanhtoandichvu.Click += new System.EventHandler(this.btn_thanhtoandichvu_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(164, 238);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(145, 29);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_tongtiendichvu
            // 
            this.txt_tongtiendichvu.Enabled = false;
            this.txt_tongtiendichvu.Location = new System.Drawing.Point(164, 162);
            this.txt_tongtiendichvu.Name = "txt_tongtiendichvu";
            this.txt_tongtiendichvu.ReadOnly = true;
            this.txt_tongtiendichvu.Size = new System.Drawing.Size(145, 26);
            this.txt_tongtiendichvu.TabIndex = 7;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(164, 121);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(145, 26);
            this.txt_soluong.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng Tiền Dịch Vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Dịch Vụ";
            // 
            // dgv_DichVu
            // 
            this.dgv_DichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DichVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DichVu.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_DichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DichVu.Location = new System.Drawing.Point(37, 300);
            this.dgv_DichVu.Name = "dgv_DichVu";
            this.dgv_DichVu.ReadOnly = true;
            this.dgv_DichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DichVu.Size = new System.Drawing.Size(264, 284);
            this.dgv_DichVu.TabIndex = 5;
            this.dgv_DichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DichVu_CellContentClick);
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhachHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_KhachHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Location = new System.Drawing.Point(547, 87);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.ReadOnly = true;
            this.dgv_KhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KhachHang.Size = new System.Drawing.Size(501, 182);
            this.dgv_KhachHang.TabIndex = 6;
            this.dgv_KhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhachHang_CellContentClick);
            // 
            // FormHoaDonDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 680);
            this.Controls.Add(this.dgv_KhachHang);
            this.Controls.Add(this.dgv_DichVu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_chitietsdDV);
            this.Controls.Add(this.label1);
            this.Name = "FormHoaDonDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHoaDonDichVu";
            this.Load += new System.EventHandler(this.FormHoaDonDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietsdDV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_chitietsdDV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_DichVu;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_thanhtoandichvu;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_tongtiendichvu;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idkhachhang;
        private System.Windows.Forms.TextBox txt_iddichvu;
    }
}