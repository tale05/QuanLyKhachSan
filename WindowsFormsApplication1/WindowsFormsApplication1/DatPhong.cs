using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class DatPhong : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=LAPTOP-U78MOGBM;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public DatPhong()
        {
            InitializeComponent();
        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            LoadData();
            LoadCbo_KhachHang();
            LoadCbo_LoaiPhong();
            cbo_loaiphong.SelectedIndex = 0;
            LoadCbo_KhachHang_Makh();
            LoadCbo_TenDichVu();
            //LoadCbo_Phong_Maphong();
        }
        public void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM PHIEUDATPHONG";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgv_phieudatphong.DataSource = table;
        }
        public void LoadCbo_TenDichVu()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM DICHVU", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbo_dichvu.Items.Add(sqlReader["TENDICHVU"].ToString());
            }

            sqlReader.Close();
        }
        public void LoadCbo_KhachHang()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM KHACHHANG", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbo_tenkh.Items.Add(sqlReader["HOTENKHACHHANG"].ToString());
                cbo_tenkh.SelectedIndex = 0;
            }

            sqlReader.Close();
        }
        public void LoadCbo_KhachHang_Makh()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM KHACHHANG", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbo_makh.Items.Add(sqlReader["IDKHACHHANG"].ToString());
            }

            sqlReader.Close();
        }
        public void LoadCbo_Phong_Maphong()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM PHONG", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbo_maphong.Items.Add(sqlReader["IDPHONG"].ToString());
            }
            sqlReader.Close();
        }
        public void LoadCbo_LoaiPhong()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM LOAIPHONG", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbo_loaiphong.Items.Add(sqlReader["TENLOAIPHONG"].ToString());
            }

            sqlReader.Close();
        }

        private void dgv_phieudatphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_phieudatphong.CurrentRow.Index;
            txt_maphieu.Text = dgv_phieudatphong.Rows[i].Cells[0].Value.ToString();
            cbo_makh.Text = dgv_phieudatphong.Rows[i].Cells[1].Value.ToString();
            cbo_maphong.Text = dgv_phieudatphong.Rows[i].Cells[2].Value.ToString();
            dtp_checkin.Text = dgv_phieudatphong.Rows[i].Cells[3].Value.ToString();
            dtp_checkout.Text = dgv_phieudatphong.Rows[i].Cells[4].Value.ToString();
            txt_soluong.Text = dgv_phieudatphong.Rows[i].Cells[5].Value.ToString();

            //-------------------------

            try
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM KHACHHANG WHERE IDKHACHHANG = N'" + cbo_makh.Text + "'", con);
                con = new SqlConnection(str);
                con.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    cbo_tenkh.Text = sqlReader["HOTENKHACHHANG"].ToString();
                }
                sqlReader.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //-------------------------

            SqlCommand sqlCmd1 = new SqlCommand("SELECT * FROM PHONG WHERE IDPHONG = '" + cbo_maphong.Text + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader1 = sqlCmd1.ExecuteReader();

            while (sqlReader1.Read())
            {
                txt_maloaiphong.Text = sqlReader1["IDLOAIPHONG"].ToString();
            }

            //-------------------------

            SqlCommand sqlCmd2 = new SqlCommand("SELECT * FROM LOAIPHONG WHERE IDLOAIPHONG = '" + txt_maloaiphong.Text + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader2 = sqlCmd2.ExecuteReader();

            while (sqlReader2.Read())
            {
                cbo_loaiphong.Text = sqlReader2["TENLOAIPHONG"].ToString();
            }

            //-------------------------

            SqlCommand sqlCmd3 = new SqlCommand("SELECT * FROM PHONG WHERE IDPHONG = '" + cbo_maphong.Text + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader3 = sqlCmd3.ExecuteReader();

            while (sqlReader3.Read())
            {
                txt_tenphong.Text = sqlReader3["TENPHONG"].ToString();
            }
        }


        private void cbo_tenkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM KHACHHANG WHERE HOTENKHACHHANG = N'" + cbo_tenkh.Text + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbo_makh.Text = sqlReader["IDKHACHHANG"].ToString();
            }
            sqlReader.Close();
        }

        private void cbo_loaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM LOAIPHONG WHERE TENLOAIPHONG = N'" + cbo_loaiphong.Text + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                txt_maloaiphong.Text = sqlReader["IDLOAIPHONG"].ToString();
            }
            sqlReader.Close();

            SqlCommand sqlCmd1 = new SqlCommand("SELECT IDPHONG FROM PHONG WHERE IDLOAIPHONG = '" + txt_maloaiphong.Text + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader1 = sqlCmd1.ExecuteReader();
            cbo_maphong.Items.Clear();
            while (sqlReader1.Read())
            {
                cbo_maphong.Items.Add(sqlReader1["IDPHONG"].ToString());
            }

            sqlReader1.Close();
        }

        private void cbo_maphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT TENPHONG, TRANGTHAI FROM PHONG WHERE IDPHONG = '" + cbo_maphong.Text + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                txt_tenphong.Text = sqlReader["TENPHONG"].ToString();
            }
            sqlReader.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            FormKhachHang frmKH = new FormKhachHang();
            frmKH.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cbo_tenkh.SelectedIndex = 0;
            cbo_makh.SelectedIndex = 0;
            cbo_loaiphong.SelectedIndex = 0;
            txt_maloaiphong.Text = string.Empty;
            txt_soluong.Text = string.Empty;
            dtp_checkin.Text = string.Empty;
            dtp_checkout.Text = string.Empty;
            txt_maphieu.Text = string.Empty;
            cbo_makh.Text = string.Empty;
            cbo_maphong.Text = string.Empty;
            txt_tenphong.Text = string.Empty;
        }
        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = @"DELETE FROM PHIEUDATPHONG WHERE IDPHIEUDATPHONG = '" + txt_maphieu.Text + "'";
                    cmd.ExecuteNonQuery();
                    LoadData();
                    cmd = con.CreateCommand();
                    cmd.CommandText = @"UPDATE PHONG SET TRANGTHAI = N'Trống' WHERE (IDPHONG = N'" + cbo_maphong.Text + @"')";
                    cmd.ExecuteNonQuery();

                    cbo_tenkh.SelectedIndex = 0;
                    cbo_makh.SelectedIndex = 0;
                    cbo_loaiphong.SelectedIndex = 0;
                    txt_maloaiphong.Text = string.Empty;
                    txt_soluong.Text = string.Empty;
                    dtp_checkin.Text = string.Empty;
                    dtp_checkout.Text = string.Empty;
                    txt_maphieu.Text = string.Empty;
                    cbo_makh.Text = string.Empty;
                    cbo_maphong.Text = string.Empty;
                    txt_tenphong.Text = string.Empty;

                }
                catch
                {
                    MessageBox.Show("Lỗi !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DatPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r; r = MessageBox.Show(
                "Bạn có muốn thoát?",
                "Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMAIN frm = new FormMAIN();
            frm.Show();
            Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_maphieu_search.Text == string.Empty)
                {
                    LoadData();
                    MessageBox.Show("Chưa Nhập Thông Tin");
                }
                else
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = @"EXEC TimKiemPhieuDatPhong @idphieu = '" + txt_maphieu_search.Text.ToUpper().Trim() + @"'";
                    adapter.SelectCommand = cmd;
                    table.Clear();
                    adapter.Fill(table);
                    dgv_phieudatphong.DataSource = table;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormHoaDon.TimKiemTheoMaPhieu = txt_maphieu.Text.Trim();
            FormHoaDon frmHoaDon = new FormHoaDon();
            frmHoaDon.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormHoaDon frmHoaDon = new FormHoaDon();
            frmHoaDon.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText =
                    @"EXEC CapNhatTinhTrangPhong @idphong = '" + cbo_maphong.Text + "'" +
                    @"SET DATEFORMAT DMY EXEC TraPhong @IdPhieuDatPhong = '" + txt_maphieu.Text + "', @CheckOut = '" + dtp_checkout.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trả phòng thành công");
                LoadData();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.Substring(err.Message.IndexOf('\n')), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static double dongiadichvu, tongtiendichvu;

        private void button7_Click_1(object sender, EventArgs e)
        {
            DatPhong frm = new DatPhong();
            frm.Show();
            this.Dispose(false);
        }

        string iddichvu = string.Empty;
        private void btn_themdichvu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("EXEC ChonDichVu @DichVu = N'" + cbo_dichvu.Text + "'", con);
                con = new SqlConnection(str);
                con.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    dongiadichvu = double.Parse(sqlReader[0].ToString());
                    iddichvu = sqlReader[1].ToString();
                    tongtiendichvu = dongiadichvu * int.Parse(txt_soluongDV.Text);
                    txt_tongtienDV.Text = tongtiendichvu.ToString();

                    cmd = con.CreateCommand();
                    cmd.CommandText = @"INSERT INTO CHITIETSUDUNG_DICHVU(IDDICHVU, IDKHACHHANG, SOLUONG, TONGTIENDICHVU) VALUES('" + iddichvu.Trim() + @"', '" + cbo_makh.Text + @"'," + int.Parse(txt_soluongDV.Text) + "," + tongtiendichvu + @")";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm Dịch Vụ Thành Công", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sqlReader.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_soluong_Leave(object sender, EventArgs e)
        {
            if (IsChar(txt_soluong.Text) == true)
                MessageBox.Show("Phải Nhập Số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (cbo_loaiphong.SelectedIndex == 0)
                {
                    if (int.Parse(txt_soluong.Text) > 2)
                    {
                        MessageBox.Show("Phòng Đơn Chỉ Được Ở 1 Người", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_soluong.Focus();
                    }
                }
                if (cbo_loaiphong.SelectedIndex == 1)
                {
                    if (int.Parse(txt_soluong.Text) > 4)
                    {
                        MessageBox.Show("Phòng ĐÔi Chỉ Được Ở Tối Đa 4 Người", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_soluong.Focus();
                    }
                }
                if (cbo_loaiphong.SelectedIndex == 2)
                {
                    if (int.Parse(txt_soluong.Text) > 2)
                    {
                        MessageBox.Show("Phòng VIP Chỉ Được Ở Tối Đa 1 Người", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_soluong.Focus();
                    }
                }
            }

        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public bool IsChar(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormQuanLyPhong frm = new FormQuanLyPhong();
            frm.Show();
            Hide();
        }

        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_loaiphong.Text == "")
                    MessageBox.Show("Bắt Buộc Chọn Loại Phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (txt_soluong.Text.Trim() == "")
                        MessageBox.Show("Bắt Buộc Nhập Số Người Ở", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (dtp_checkin.Text == "")
                            MessageBox.Show("Bắt Buộc Chọn Check-In", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (txt_maphieu.Text.Trim() == "")
                                MessageBox.Show("Bắt Buộc Nhập Mã Phiếu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                if (cbo_maphong.Text == "")
                                    MessageBox.Show("Bắt Buộc Chọn Mã Phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                {
                                    //SqlCommand sqlCmd = new SqlCommand(@"SELECT TRANGTHAI FROM PHONG WHERE TENPHONG = N'" + txt_tenphong.Text.Trim() + @"'", con);
                                    SqlCommand sqlCmd = new SqlCommand(@"EXEC XemTrangThaiPhongDatPhong @tenphong = '" + txt_tenphong.Text.Trim() + @"'", con);
                                    con = new SqlConnection(str);
                                    con.Open();
                                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                                    while (sqlReader.Read())
                                    {
                                        if (txt_maphieu.Text == string.Empty)
                                            MessageBox.Show("Chưa Nhập Mã Phiếu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        if (sqlReader[0].ToString() == "Có Khách")
                                            MessageBox.Show("Phòng Đã Có Khách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        if (sqlReader[0].ToString() == "Trống")
                                        {
                                            cmd = con.CreateCommand();
                                            cmd.CommandText = @"SET DATEFORMAT DMY INSERT INTO PHIEUDATPHONG(IDPHIEUDATPHONG,IDKHACHHANG,IDPHONG,CHECKIN,SONGUOI)
                                                              VALUES('" + txt_maphieu.Text.ToUpper().Trim() + @"','"
                                                              + cbo_makh.Text + @"','" + cbo_maphong.Text + @"','"
                                                              + dtp_checkin.Text + @"'," + txt_soluong.Text + ")";
                                            cmd.ExecuteNonQuery();
                                            cmd = con.CreateCommand();
                                            cmd.CommandText = @"EXEC CapNhatPhongDaDat @idphong = '" + cbo_maphong.Text + "'";
                                            cmd.ExecuteNonQuery();
                                            MessageBox.Show("Thêm thành công");
                                            LoadData();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi, Không Được Trùng Mã Phiếu Đặt Phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
