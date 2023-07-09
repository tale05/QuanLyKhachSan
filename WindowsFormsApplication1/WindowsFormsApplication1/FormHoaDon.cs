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
    public partial class FormHoaDon : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=LAPTOP-U78MOGBM;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        //-------------------------------------
        SqlConnection con1;
        SqlCommand cmd1;
        string str1 = "Data Source=LAPTOP-U78MOGBM;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataTable table1 = new DataTable();
        //-------------------------------------
        public static string TimKiemTheoMaPhieu;
        public FormHoaDon()
        {
            InitializeComponent();
        }
        private void LoadData_HoaDon()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM HOADON";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgv_HoaDon.DataSource = table;
        }
        private void LoadData_PhieuDatPhong()
        {
            cmd1 = con1.CreateCommand();
            cmd1.CommandText = "SELECT * FROM PHIEUDATPHONG";
            adapter1.SelectCommand = cmd1;
            table1.Clear();
            adapter1.Fill(table1);
            dgv_phieudatphong.DataSource = table1;
        }
        private void LoadData_CboIDNhanVien()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM NHANVIEN", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbo_idnhanvien.Items.Add(sqlReader["IDNHANVIEN"].ToString());
            }

            sqlReader.Close();
        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = false;
                    cbo_trangthai.Enabled = false;
                    cbo_idnhanvien.Enabled = false;
                    txt_idphieudatphong.Enabled = false;
                }
            }
            txt_tiendichvu.Text = string.Empty;
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;

            //-------------------------------

            con = new SqlConnection(str);
            con.Open();
            LoadData_HoaDon();
            LoadData_CboIDNhanVien();
            txt_timkiem_idphieu.Text = TimKiemTheoMaPhieu;

            //--------------------------------

            con1 = new SqlConnection(str1);
            con1.Open();
            LoadData_PhieuDatPhong();
            con1.Close();
        }

        private void dgv_HoaDon_Click(object sender, EventArgs e)
        {
            int i;
            i = dgv_HoaDon.CurrentRow.Index;
            txt_idhoadon.Text = dgv_HoaDon.Rows[i].Cells[0].Value.ToString();
            txt_idkhachhang.Text = dgv_HoaDon.Rows[i].Cells[1].Value.ToString();
            txt_idphieudatphong.Text = dgv_HoaDon.Rows[i].Cells[2].Value.ToString();
            cbo_idnhanvien.Text = dgv_HoaDon.Rows[i].Cells[3].Value.ToString();
            txt_ngaylaphoadon.Text = dgv_HoaDon.Rows[i].Cells[4].Value.ToString();
            cbo_trangthai.Text = dgv_HoaDon.Rows[i].Cells[5].Value.ToString();
            txt_TongTien_Phong_DV.Text = dgv_HoaDon.Rows[i].Cells[6].Value.ToString();
          
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            //int count = 0;
            //count = dgv_HoaDon.Rows.Count;
            //string chuoi = string.Empty;
            //int chuoi2 = 0;
            //chuoi = Convert.ToString(dgv_HoaDon.Rows[count - 2].Cells[0].Value);
            //chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            //if (chuoi2 + 1 < 10)
            //    txt_idhoadon.Text = "HD0" + (chuoi2 + 1).ToString();
            //else
            //    txt_idhoadon.Text = "HD" + (chuoi2 + 1).ToString();
            try
            {
                if (txt_idhoadon.Text == string.Empty)
                    MessageBox.Show("Chưa Nhập Mã Phiếu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    cmd = con.CreateCommand();
                    //cmd.CommandText = @"INSERT INTO HOADON VALUES(N'" + txt_idhoadon.Text.ToUpper().Trim() + @"','" + txt_idkhachhang.Text + @"','" + txt_idphieudatphong.Text + @"','" + cbo_idnhanvien.Text + @"','" + DateTime.Now.ToString() + @"','" + cbo_trangthai.Text + @"'," + float.Parse(txt_TongTien_Phong_DV.Text) + ")";
                    cmd.CommandText = @"exec themHoadon '" + txt_idhoadon.Text.ToUpper().Trim() + @"','" + txt_idkhachhang.Text + @"','" + txt_idphieudatphong.Text + @"','" + cbo_idnhanvien.Text + @"','" + DateTime.Now.ToString() + @"',N'" + cbo_trangthai.Text + @"'," + float.Parse(txt_TongTien_Phong_DV.Text) + @"";
                    cmd.ExecuteNonQuery();
                    LoadData_HoaDon();
                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message.Substring(err.Message.IndexOf('\n')), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                cmd = con.CreateCommand();
                cmd.CommandText = @"DELETE HOADON WHERE IDHOADON = '" + txt_idhoadon.Text + "'";
                cmd.ExecuteNonQuery();
                LoadData_HoaDon();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = @"UPDATE HOADON SET TRANGTHAIHD = N'" + cbo_trangthai.Text + @"' WHERE (IDHOADON = N'" + txt_idhoadon.Text + @"')";
                cmd.ExecuteNonQuery();
                cmd = con.CreateCommand();
                LoadData_HoaDon();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_khoitao_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    cbo_trangthai.Text = string.Empty;
                    item.Enabled = true;
                    cbo_trangthai.Enabled = true;
                    cbo_trangthai.Text = string.Empty;
                    txt_idphieudatphong.Enabled = true;
                    txt_idphieudatphong.Text = string.Empty;
                    cbo_idnhanvien.Enabled = true;
                    cbo_idnhanvien.Text = string.Empty;
                    txt_idhoadon.Focus();
                }
            }
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            dgv_HoaDon.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_thanhtoan.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_them.Enabled = false;
            dgv_HoaDon.Enabled = true;

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = true;
                    cbo_trangthai.Enabled = true;
                    txt_idphieudatphong.Enabled = true;
                }
            }
            txt_idhoadon.Enabled = false;
            txt_idphieudatphong.Enabled = false;
            cbo_idnhanvien.Enabled = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = true;
                    item.Text = string.Empty;
                    cbo_trangthai.Enabled = true;
                    txt_idphieudatphong.Enabled = true;
                    cbo_trangthai.Text = string.Empty;
                    txt_idphieudatphong.Text = string.Empty;
                    cbo_idnhanvien.Enabled = true;
                    cbo_idnhanvien.Text = string.Empty;
                }
            }
            txt_idhoadon.Focus();
        }

        private void cbo_idnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT HOTENNHANVIEN FROM NHANVIEN WHERE IDNHANVIEN = '" + cbo_idnhanvien.Text + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                txt_hotennhanvien.Text = sqlReader["HOTENNHANVIEN"].ToString();
            }
            sqlReader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_timkiem_idphieu.Text == string.Empty)
                {
                    LoadData_PhieuDatPhong();
                    MessageBox.Show("Chưa Nhập Thông Tin");
                }
                else
                {
                    cmd1 = con1.CreateCommand();
                    cmd1.CommandText = @"SELECT * FROM PHIEUDATPHONG WHERE IDPHIEUDATPHONG = '" + txt_timkiem_idphieu.Text + "'";
                    adapter.SelectCommand = cmd1;
                    table1.Clear();
                    adapter.Fill(table1);
                    dgv_phieudatphong.DataSource = table1;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        string maphong = string.Empty;
        private void dgv_phieudatphong_Click(object sender, EventArgs e)
        {
            int i;
            i = dgv_phieudatphong.CurrentRow.Index;
            txt_idphieudatphong.Text = dgv_phieudatphong.Rows[i].Cells[0].Value.ToString();
            txt_idkhachhang.Text = dgv_phieudatphong.Rows[i].Cells[1].Value.ToString();
            maphong = dgv_phieudatphong.Rows[i].Cells[2].Value.ToString();

            string maloaiphong = string.Empty;
            //--------------------------------

            SqlCommand sqlCmd1 =
                    new SqlCommand(@"SELECT PHONG.IDLOAIPHONG FROM PHONG WHERE IDPHONG = '" + maphong + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader1 = sqlCmd1.ExecuteReader();

            while (sqlReader1.Read())
            {
                maloaiphong = sqlReader1[0].ToString();
            }

            sqlReader1.Close();

            //--------------------------------

            SqlCommand sqlCmd2 =
                    new SqlCommand(@"SELECT LOAIPHONG.DONGIA FROM LOAIPHONG WHERE IDLOAIPHONG='" + maloaiphong + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader2 = sqlCmd2.ExecuteReader();

            while (sqlReader2.Read())
            {
                txt_dongiaphong.Text = sqlReader2[0].ToString();
            }

            sqlReader2.Close();

            //--------------------------------

            SqlCommand sqlCmd =
                    new SqlCommand(@"SELECT DATEDIFF(DAY,PHIEUDATPHONG.CHECKIN, PHIEUDATPHONG.CHECKOUT)
                                    FROM PHIEUDATPHONG
                                    WHERE(PHIEUDATPHONG.IDPHIEUDATPHONG = '" + txt_idphieudatphong.Text + "')", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                txt_tongsongay.Text = sqlReader[0].ToString();
            }

            sqlReader.Close();

            //--------------------------------

            SqlCommand sqlCmd3 =
                    new SqlCommand(@"SELECT * FROM KHACHHANG WHERE IDKHACHHANG = '" + txt_idkhachhang.Text.Trim().ToUpper() + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader3 = sqlCmd3.ExecuteReader();

            while (sqlReader3.Read())
            {
                txt_hotenkhachhang.Text = sqlReader3["HOTENKHACHHANG"].ToString();
            }

            sqlReader3.Close();
        }

        double dongialoaiphong;
        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                string maloaiphong = string.Empty;
                //--------------------------------

                SqlCommand sqlCmd1 =
                        new SqlCommand(@"SELECT PHONG.IDLOAIPHONG FROM PHONG WHERE IDPHONG = '" + maphong + "'", con);
                con = new SqlConnection(str);
                con.Open();
                SqlDataReader sqlReader1 = sqlCmd1.ExecuteReader();

                while (sqlReader1.Read())
                {
                    maloaiphong = sqlReader1[0].ToString();
                }

                sqlReader1.Close();

                //--------------------------------

                SqlCommand sqlCmd2 =
                        new SqlCommand(@"SELECT LOAIPHONG.DONGIA FROM LOAIPHONG WHERE IDLOAIPHONG='" + maloaiphong + "'", con);
                con = new SqlConnection(str);
                con.Open();
                SqlDataReader sqlReader2 = sqlCmd2.ExecuteReader();

                while (sqlReader2.Read())
                {
                    dongialoaiphong = double.Parse(sqlReader2[0].ToString());
                }

                sqlReader2.Close();

                //--------------------------------

                SqlCommand sqlCmd3 =
                    new SqlCommand(@"DECLARE @TienDichVu INT SET @TienDichVu = dbo.TongTienDichVuCuaKhachHang('" + txt_idkhachhang.Text.Trim().ToUpper() + "') SELECT @TienDichVu AS TIENDICHVU", con);
                con = new SqlConnection(str);
                con.Open();
                SqlDataReader sqlReader3 = sqlCmd3.ExecuteReader();

                while (sqlReader3.Read())
                {
                    txt_tiendichvu.Text = sqlReader3[0].ToString();
                }

                sqlReader3.Close();

                double tongtienphong, tonghoadon;
                tongtienphong = dongialoaiphong * double.Parse(txt_tongsongay.Text);
                tonghoadon = tongtienphong + int.Parse(txt_tiendichvu.Text);
                txt_tongtienhoadon.Text = (int.Parse(txt_tongsongay.Text) * double.Parse(txt_dongiaphong.Text)).ToString();
                txt_TongTien_Phong_DV.Text = tonghoadon.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMAIN frmMAIN = new FormMAIN();
            frmMAIN.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatPhong dp = new DatPhong();
            dp.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormHoaDon frmHoaDon = new FormHoaDon();
            frmHoaDon.Show();
            this.Dispose(false);
        }
    }
}
