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
    public partial class FormKhachHang : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=LAPTOP-U78MOGBM;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormKhachHang()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM KHACHHANG";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvKhachHang.DataSource = table;
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            txt_ngaysinh.CustomFormat = "dd/MM/yyyy";
            txt_ngaysinh.Format = DateTimePickerFormat.Custom;
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = false;
                    txt_ngaysinh.Enabled = false;
                    cbo_gioitinh.Enabled = false;
                }
            }
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            con = new SqlConnection(str);
            con.Open();
            LoadData();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txt_makh.Text == string.Empty)
            //        MessageBox.Show("Bạn chưa nhập đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    else
            //    {
            //        if (IsChar(txt_sdt.Text) == true)
            //            MessageBox.Show("Phải Nhập Số Cho SDT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        else
            //        {
            //            if (IsChar(txt_cmnd.Text) == true)
            //                MessageBox.Show("Phải Nhập Số Cho CMND", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            else
            //            {
            //                if (txt_hoten.Text == string.Empty)
            //                    MessageBox.Show("Phải Nhập Họ Tên Khách Hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                else
            //                {
            //                    if (IsNumber(txt_hoten.Text) == true)
            //                        MessageBox.Show("Họ Tên Phải Là Kí Tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                    else
            //                    {
            //                        //cmd = con.CreateCommand();
            //                        //cmd.CommandText = @"SET DATEFORMAT DMY INSERT INTO KHACHHANG VALUES(N'" + txt_makh.Text + @"',N'" + txt_hoten.Text + @"',N'" + txt_ngaysinh.Text + @"',N'" + cbo_gioitinh.Text + @"',N'" + txt_cmnd.Text + @"',N'" + txt_sdt.Text + @"',N'" + txt_quoctich.Text + @"',N'" + txt_diachi.Text + @"')";
            //                        //cmd.ExecuteNonQuery();
            //                        //MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                        //LoadData();
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Lỗi, Không Được Nhập Trùng Mã Khách Hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "SET DATEFORMAT DMY EXEC nhap_kt_khachhang @id= '" + txt_makh.Text + "',@hoten = N'" + txt_hoten.Text + "',@ngaysinh= '" + txt_ngaysinh.Text + "',@gioitinh=N'" + cbo_gioitinh.Text + "',@CMND='" + txt_cmnd.Text + "',@SDT = '" + txt_sdt.Text + "',@quoctich = N'" + txt_quoctich.Text + "',@diachi = N'" + txt_diachi.Text + "'";
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message.Substring(err.Message.IndexOf('\n')), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = @"EXEC XoaKhachHang @idkhachhang = '" + txt_makh.Text + "'";
                    cmd.ExecuteNonQuery();
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvKhachHang.CurrentRow.Index;
            txt_makh.Text = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
            txt_hoten.Text = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
            txt_ngaysinh.Text = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
            cbo_gioitinh.Text = dgvKhachHang.Rows[i].Cells[3].Value.ToString();
            txt_cmnd.Text = dgvKhachHang.Rows[i].Cells[4].Value.ToString();
            txt_sdt.Text = dgvKhachHang.Rows[i].Cells[5].Value.ToString();
            txt_quoctich.Text = dgvKhachHang.Rows[i].Cells[6].Value.ToString();
            txt_diachi.Text = dgvKhachHang.Rows[i].Cells[7].Value.ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                    cbo_gioitinh.Text = string.Empty;
                    txt_makh.Focus();
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                txt_makh.Enabled = false;
                cmd = con.CreateCommand();
                //cmd.CommandText = @"UPDATE KHACHHANG SET IDKHACHHANG = N'" + txt_makh.Text + @"', HOTENKHACHHANG = N'" + txt_hoten.Text + @"', GIOITINH = N'" + cbo_gioitinh.Text + @"', NGAYSINH = N'" + txt_ngaysinh.Text + @"', CMND = N'" + txt_cmnd.Text + @"', DIACHI = N'" + txt_diachi.Text + @"', SDT = N'" + txt_sdt.Text + "'    WHERE   (IDKHACHHANG = N'" + txt_makh.Text + @"')";
                cmd.CommandText = @"EXEC UpdateKhachHang @id ='" + txt_makh.Text + @"',@hoten =N'" + txt_hoten.Text + @"',@ngaysinh ='" + txt_ngaysinh.Text + @"', @gioitinh ='" + cbo_gioitinh.Text + @"',@CMND ='" + txt_cmnd.Text + @"',@SDT ='" + txt_sdt.Text + @"',@quoctich =N'" + txt_quoctich.Text + @"',@diachi=N'" + txt_diachi.Text + @"'";
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btn_khoitao_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                    cbo_gioitinh.Text = string.Empty;
                    txt_ngaysinh.Text = string.Empty;
                    item.Enabled = true;
                    txt_ngaysinh.Enabled = true;
                    cbo_gioitinh.Enabled = true;
                    txt_makh.Focus();
                }
            }
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            dgvKhachHang.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_them.Enabled = false;
            dgvKhachHang.Enabled = true;

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = true;
                    txt_ngaysinh.Enabled = true;
                    cbo_gioitinh.Enabled = true;
                }
            }
            txt_makh.Enabled = false;
        }

        private void FormKhachHang_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_returnfrmMain_Click(object sender, EventArgs e)
        {
            FormMAIN frmMain = new FormMAIN();
            frmMain.Show();
            Hide();
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            int i;
            i = dgvKhachHang.CurrentRow.Index;
            txt_makh.Text = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
            txt_hoten.Text = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
            txt_ngaysinh.Text = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
            cbo_gioitinh.Text = dgvKhachHang.Rows[i].Cells[3].Value.ToString();
            txt_cmnd.Text = dgvKhachHang.Rows[i].Cells[4].Value.ToString();
            txt_sdt.Text = dgvKhachHang.Rows[i].Cells[5].Value.ToString();
            txt_quoctich.Text = dgvKhachHang.Rows[i].Cells[6].Value.ToString();
            txt_diachi.Text = dgvKhachHang.Rows[i].Cells[7].Value.ToString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nhapmaKH_search.Text == string.Empty)
                {
                    LoadData();
                    MessageBox.Show("Chưa Nhập Thông Tin");
                }
                else
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = @"EXEC TimKiemKhachHang @TenKhachHang = N'" + txt_nhapmaKH_search.Text + "'";
                    adapter.SelectCommand = cmd;
                    table.Clear();
                    adapter.Fill(table);
                    dgvKhachHang.DataSource = table;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        //------------------------------------------
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
    }
}
