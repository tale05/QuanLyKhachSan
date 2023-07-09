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
    public partial class FormNhanVien : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=LAPTOP-U78MOGBM;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormNhanVien()
        {
            InitializeComponent();
        }
        public void LoadDataNhanVien()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM NHANVIEN";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvNhanVien.DataSource = table;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = false;
                    txt_ngaysinhnv.Enabled = false;
                }
            }
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            con = new SqlConnection(str);
            con.Open();
            LoadDataNhanVien();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                //cmd.CommandText = "SET DATEFORMAT DMY EXEC nhap_kt_khachhang @id= '" + txt_makh.Text + "',@hoten = N'" + txt_hoten.Text + "',@ngaysinh= '" + txt_ngaysinh.Text + "',@gioitinh=N'" + cbo_gioitinh.Text + "',@CMND='" + txt_cmnd.Text + "',@SDT = '" + txt_sdt.Text + "',@quoctich = N'" + txt_quoctich.Text + "',@diachi = N'" + txt_diachi.Text + "'";
                cmd.CommandText = "SET DATEFORMAT DMY EXEC ThemNhanvien @id= '" + txt_manv.Text + "',@hoten = N'" + txt_hotennv.Text + "',@ngaysinh= '" + txt_ngaysinhnv.Text + "',@cmnd='" + txt_cmndnv.Text + "',@diachi='" + txt_diachinv.Text + "',@email = '" + txt_emailnv.Text + "',@sdt = '" + txt_sdtnv.Text + "',@taikhoan = '" + txt_usernamenv.Text + "',@password='" + txt_passwordnv.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataNhanVien();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message.Substring(err.Message.IndexOf('\n')), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_khoitao_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                    txt_ngaysinhnv.Text = string.Empty;
                    item.Enabled = true;
                    txt_ngaysinhnv.Enabled = true;
                    txt_manv.Focus();
                }
            }
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            dgvNhanVien.Enabled = false;
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            txt_manv.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txt_hotennv.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            txt_ngaysinhnv.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txt_cmndnv.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            txt_diachinv.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            txt_emailnv.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            txt_sdtnv.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
            txt_usernamenv.Text = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
            txt_passwordnv.Text = dgvNhanVien.Rows[i].Cells[8].Value.ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                    txt_manv.Focus();
                }
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
                    cmd.CommandText = @"EXEC XoaNhanVien @idnhanvien = '" + txt_manv.Text + "'";
                    cmd.ExecuteNonQuery();
                    LoadDataNhanVien();
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_them.Enabled = false;
            dgvNhanVien.Enabled = true;

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = true;
                    txt_ngaysinhnv.Enabled = true;
                }
            }
            txt_manv.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                txt_manv.Enabled = false;
                cmd = con.CreateCommand();
                cmd.CommandText = @"SET DATEFORMAT DMY EXEC UpdateNhanvien @id = '" + txt_manv.Text + @"', @hoten = N'" + txt_hotennv.Text + @"', @ngaysinh = '" + DateTime.Parse(txt_ngaysinhnv.Text) + @"', @cmnd = '" + txt_cmndnv.Text + @"', @diachi = N'" + txt_diachinv.Text + @"', @email = '" + txt_emailnv.Text + @"', @sdt = '" + txt_sdtnv.Text + @"', @taikhoan = '" + txt_usernamenv.Text + @"', @password = '" + txt_passwordnv.Text + @"'";
                cmd.ExecuteNonQuery();
                LoadDataNhanVien();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_returnfrmMain_Click(object sender, EventArgs e)
        {
            FormMAIN frmMain = new FormMAIN();
            frmMain.Show();
            Hide();
        }

        private void FormNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
