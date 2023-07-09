namespace WindowsFormsApplication1
{
    partial class FormHoaDon
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
            this.gbo_PhieuDatPhong = new System.Windows.Forms.GroupBox();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TongTien_Phong_DV = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_tiendichvu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_hotenkhachhang = new System.Windows.Forms.TextBox();
            this.txt_idphieudatphong = new System.Windows.Forms.TextBox();
            this.txt_idkhachhang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.txt_tongtienhoadon = new System.Windows.Forms.TextBox();
            this.txt_dongiaphong = new System.Windows.Forms.TextBox();
            this.txt_tongsongay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_hotennhanvien = new System.Windows.Forms.TextBox();
            this.cbo_idnhanvien = new System.Windows.Forms.ComboBox();
            this.cbo_trangthai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ngaylaphoadon = new System.Windows.Forms.DateTimePicker();
            this.txt_idhoadon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_khoitao = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_phieudatphong = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_timkiem_idphieu = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gbo_PhieuDatPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieudatphong)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1430, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn Thanh Toán";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbo_PhieuDatPhong
            // 
            this.gbo_PhieuDatPhong.Controls.Add(this.dgv_HoaDon);
            this.gbo_PhieuDatPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_PhieuDatPhong.Location = new System.Drawing.Point(52, 86);
            this.gbo_PhieuDatPhong.Name = "gbo_PhieuDatPhong";
            this.gbo_PhieuDatPhong.Size = new System.Drawing.Size(1288, 268);
            this.gbo_PhieuDatPhong.TabIndex = 1;
            this.gbo_PhieuDatPhong.TabStop = false;
            this.gbo_PhieuDatPhong.Text = "Thông Tin Hóa Đơn";
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HoaDon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Location = new System.Drawing.Point(6, 19);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.ReadOnly = true;
            this.dgv_HoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HoaDon.Size = new System.Drawing.Size(1276, 243);
            this.dgv_HoaDon.TabIndex = 0;
            this.dgv_HoaDon.Click += new System.EventHandler(this.dgv_HoaDon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TongTien_Phong_DV);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_tiendichvu);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_hotenkhachhang);
            this.groupBox1.Controls.Add(this.txt_idphieudatphong);
            this.groupBox1.Controls.Add(this.txt_idkhachhang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_thanhtoan);
            this.groupBox1.Controls.Add(this.txt_tongtienhoadon);
            this.groupBox1.Controls.Add(this.txt_dongiaphong);
            this.groupBox1.Controls.Add(this.txt_tongsongay);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_hotennhanvien);
            this.groupBox1.Controls.Add(this.cbo_idnhanvien);
            this.groupBox1.Controls.Add(this.cbo_trangthai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_ngaylaphoadon);
            this.groupBox1.Controls.Add(this.txt_idhoadon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 262);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // txt_TongTien_Phong_DV
            // 
            this.txt_TongTien_Phong_DV.Enabled = false;
            this.txt_TongTien_Phong_DV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien_Phong_DV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TongTien_Phong_DV.Location = new System.Drawing.Point(444, 190);
            this.txt_TongTien_Phong_DV.Name = "txt_TongTien_Phong_DV";
            this.txt_TongTien_Phong_DV.ReadOnly = true;
            this.txt_TongTien_Phong_DV.Size = new System.Drawing.Size(160, 26);
            this.txt_TongTien_Phong_DV.TabIndex = 41;
            this.txt_TongTien_Phong_DV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(341, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 19);
            this.label13.TabIndex = 40;
            this.label13.Text = "TỔNG TIỀN";
            // 
            // txt_tiendichvu
            // 
            this.txt_tiendichvu.Enabled = false;
            this.txt_tiendichvu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tiendichvu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tiendichvu.Location = new System.Drawing.Point(445, 148);
            this.txt_tiendichvu.Name = "txt_tiendichvu";
            this.txt_tiendichvu.ReadOnly = true;
            this.txt_tiendichvu.Size = new System.Drawing.Size(160, 26);
            this.txt_tiendichvu.TabIndex = 39;
            this.txt_tiendichvu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(341, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 19);
            this.label12.TabIndex = 38;
            this.label12.Text = "Tiền Dịch Vụ";
            // 
            // txt_hotenkhachhang
            // 
            this.txt_hotenkhachhang.Enabled = false;
            this.txt_hotenkhachhang.Location = new System.Drawing.Point(185, 74);
            this.txt_hotenkhachhang.Name = "txt_hotenkhachhang";
            this.txt_hotenkhachhang.ReadOnly = true;
            this.txt_hotenkhachhang.Size = new System.Drawing.Size(134, 25);
            this.txt_hotenkhachhang.TabIndex = 37;
            // 
            // txt_idphieudatphong
            // 
            this.txt_idphieudatphong.Enabled = false;
            this.txt_idphieudatphong.Location = new System.Drawing.Point(154, 110);
            this.txt_idphieudatphong.Name = "txt_idphieudatphong";
            this.txt_idphieudatphong.ReadOnly = true;
            this.txt_idphieudatphong.Size = new System.Drawing.Size(165, 25);
            this.txt_idphieudatphong.TabIndex = 36;
            // 
            // txt_idkhachhang
            // 
            this.txt_idkhachhang.Enabled = false;
            this.txt_idkhachhang.Location = new System.Drawing.Point(128, 74);
            this.txt_idkhachhang.Name = "txt_idkhachhang";
            this.txt_idkhachhang.ReadOnly = true;
            this.txt_idkhachhang.Size = new System.Drawing.Size(51, 25);
            this.txt_idkhachhang.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "ID Khách Hàng";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhtoan.Location = new System.Drawing.Point(345, 224);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(260, 27);
            this.btn_thanhtoan.TabIndex = 33;
            this.btn_thanhtoan.Text = "Thanh Toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // txt_tongtienhoadon
            // 
            this.txt_tongtienhoadon.Enabled = false;
            this.txt_tongtienhoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtienhoadon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tongtienhoadon.Location = new System.Drawing.Point(445, 112);
            this.txt_tongtienhoadon.Name = "txt_tongtienhoadon";
            this.txt_tongtienhoadon.ReadOnly = true;
            this.txt_tongtienhoadon.Size = new System.Drawing.Size(160, 26);
            this.txt_tongtienhoadon.TabIndex = 19;
            this.txt_tongtienhoadon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_dongiaphong
            // 
            this.txt_dongiaphong.Enabled = false;
            this.txt_dongiaphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dongiaphong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_dongiaphong.Location = new System.Drawing.Point(445, 72);
            this.txt_dongiaphong.Name = "txt_dongiaphong";
            this.txt_dongiaphong.ReadOnly = true;
            this.txt_dongiaphong.Size = new System.Drawing.Size(160, 26);
            this.txt_dongiaphong.TabIndex = 18;
            this.txt_dongiaphong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_tongsongay
            // 
            this.txt_tongsongay.Enabled = false;
            this.txt_tongsongay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongsongay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tongsongay.Location = new System.Drawing.Point(445, 33);
            this.txt_tongsongay.Name = "txt_tongsongay";
            this.txt_tongsongay.ReadOnly = true;
            this.txt_tongsongay.Size = new System.Drawing.Size(160, 26);
            this.txt_tongsongay.TabIndex = 17;
            this.txt_tongsongay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(341, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "Đơn Giá Phòng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(341, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tiền Phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(341, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tổng Số Ngày";
            // 
            // txt_hotennhanvien
            // 
            this.txt_hotennhanvien.Enabled = false;
            this.txt_hotennhanvien.Location = new System.Drawing.Point(209, 150);
            this.txt_hotennhanvien.Name = "txt_hotennhanvien";
            this.txt_hotennhanvien.ReadOnly = true;
            this.txt_hotennhanvien.Size = new System.Drawing.Size(110, 25);
            this.txt_hotennhanvien.TabIndex = 13;
            // 
            // cbo_idnhanvien
            // 
            this.cbo_idnhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_idnhanvien.FormattingEnabled = true;
            this.cbo_idnhanvien.Location = new System.Drawing.Point(116, 149);
            this.cbo_idnhanvien.Name = "cbo_idnhanvien";
            this.cbo_idnhanvien.Size = new System.Drawing.Size(86, 25);
            this.cbo_idnhanvien.TabIndex = 12;
            this.cbo_idnhanvien.SelectedIndexChanged += new System.EventHandler(this.cbo_idnhanvien_SelectedIndexChanged);
            // 
            // cbo_trangthai
            // 
            this.cbo_trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_trangthai.FormattingEnabled = true;
            this.cbo_trangthai.Items.AddRange(new object[] {
            "Chưa Thanh Toán",
            "Đã Thanh Toán"});
            this.cbo_trangthai.Location = new System.Drawing.Point(108, 226);
            this.cbo_trangthai.Name = "cbo_trangthai";
            this.cbo_trangthai.Size = new System.Drawing.Size(211, 25);
            this.cbo_trangthai.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Trạng Thái";
            // 
            // txt_ngaylaphoadon
            // 
            this.txt_ngaylaphoadon.CustomFormat = "dd-mm-yyyy";
            this.txt_ngaylaphoadon.Enabled = false;
            this.txt_ngaylaphoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaylaphoadon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ngaylaphoadon.Location = new System.Drawing.Point(209, 191);
            this.txt_ngaylaphoadon.Name = "txt_ngaylaphoadon";
            this.txt_ngaylaphoadon.Size = new System.Drawing.Size(110, 26);
            this.txt_ngaylaphoadon.TabIndex = 7;
            // 
            // txt_idhoadon
            // 
            this.txt_idhoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idhoadon.Location = new System.Drawing.Point(108, 33);
            this.txt_idhoadon.Name = "txt_idhoadon";
            this.txt_idhoadon.Size = new System.Drawing.Size(211, 26);
            this.txt_idhoadon.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày Lập Hóa Đơn Hiện Tại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID Phiếu Đặt Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Hóa Đơn";
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(415, 374);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(107, 34);
            this.btn_edit.TabIndex = 29;
            this.btn_edit.Text = "Chỉnh Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_khoitao
            // 
            this.btn_khoitao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khoitao.Location = new System.Drawing.Point(302, 374);
            this.btn_khoitao.Name = "btn_khoitao";
            this.btn_khoitao.Size = new System.Drawing.Size(107, 34);
            this.btn_khoitao.TabIndex = 28;
            this.btn_khoitao.Text = "Khởi Tạo";
            this.btn_khoitao.UseVisualStyleBackColor = true;
            this.btn_khoitao.Click += new System.EventHandler(this.btn_khoitao_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(867, 374);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(107, 34);
            this.btn_reset.TabIndex = 27;
            this.btn_reset.Text = "Nhập Lại";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(754, 373);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(107, 34);
            this.btn_sua.TabIndex = 26;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(641, 374);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(107, 34);
            this.btn_xoa.TabIndex = 25;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(528, 374);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(107, 34);
            this.btn_them.TabIndex = 24;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_phieudatphong);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(685, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 262);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Phiếu Đặt Phòng";
            // 
            // dgv_phieudatphong
            // 
            this.dgv_phieudatphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phieudatphong.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_phieudatphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieudatphong.Location = new System.Drawing.Point(3, 22);
            this.dgv_phieudatphong.Name = "dgv_phieudatphong";
            this.dgv_phieudatphong.ReadOnly = true;
            this.dgv_phieudatphong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_phieudatphong.Size = new System.Drawing.Size(414, 233);
            this.dgv_phieudatphong.TabIndex = 0;
            this.dgv_phieudatphong.Click += new System.EventHandler(this.dgv_phieudatphong_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 31;
            this.label9.Text = "Theo Mã Phiếu";
            // 
            // txt_timkiem_idphieu
            // 
            this.txt_timkiem_idphieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem_idphieu.Location = new System.Drawing.Point(6, 55);
            this.txt_timkiem_idphieu.Name = "txt_timkiem_idphieu";
            this.txt_timkiem_idphieu.Size = new System.Drawing.Size(212, 26);
            this.txt_timkiem_idphieu.TabIndex = 32;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_timkiem_idphieu);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1111, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 130);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(46, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 27);
            this.button1.TabIndex = 31;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1204, 643);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 27);
            this.button2.TabIndex = 33;
            this.button2.Text = "Trang Chủ >>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1204, 609);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 27);
            this.button3.TabIndex = 34;
            this.button3.Text = "Đặt Phòng >>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1111, 643);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 27);
            this.button5.TabIndex = 35;
            this.button5.Text = "Load Lại";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1430, 704);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_khoitao);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbo_PhieuDatPhong);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.gbo_PhieuDatPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieudatphong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbo_PhieuDatPhong;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txt_ngaylaphoadon;
        private System.Windows.Forms.TextBox txt_idhoadon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_trangthai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_khoitao;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_phieudatphong;
        private System.Windows.Forms.ComboBox cbo_idnhanvien;
        private System.Windows.Forms.TextBox txt_hotennhanvien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_timkiem_idphieu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_tongtienhoadon;
        private System.Windows.Forms.TextBox txt_dongiaphong;
        private System.Windows.Forms.TextBox txt_tongsongay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_idkhachhang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_idphieudatphong;
        private System.Windows.Forms.TextBox txt_hotenkhachhang;
        private System.Windows.Forms.TextBox txt_TongTien_Phong_DV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_tiendichvu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
    }
}