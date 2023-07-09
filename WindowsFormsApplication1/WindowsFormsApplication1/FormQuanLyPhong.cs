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
    public partial class FormQuanLyPhong : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=LAPTOP-U78MOGBM;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormQuanLyPhong()
        {
            InitializeComponent();
        }

        private void FormQuanLyPhong_Load(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    cbo_maloaiphong.Enabled = false;
                    item.Enabled = false;
                }
            }
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            con = new SqlConnection(str);
            con.Open();
            LoadData();
            LoadCbo_Maloaiphong();
        }
        public void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "EXEC Showtoanbophong";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvPhong.DataSource = table;
        }
        public void LoadCbo_Maloaiphong()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM LOAIPHONG", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbo_maloaiphong.Items.Add(sqlReader["IDLOAIPHONG"].ToString());
            }

            sqlReader.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_maphong.Text.Trim() == string.Empty)
                    MessageBox.Show("Bắt Buộc Nhập Mã Phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (txt_tenphong.Text == string.Empty)
                        MessageBox.Show("Chưa Nhập Đủ Thông Tin, Mời Nhập Đủ Thông Tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (cbo_maloaiphong.Text == string.Empty)
                            MessageBox.Show("Chưa Nhập Đủ Thông Tin, Mời Nhập Đủ Thông Tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (cbo_trangthai.Text == string.Empty)
                                MessageBox.Show("Chưa Nhập Đủ Thông Tin, Mời Nhập Đủ Thông Tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                cmd = con.CreateCommand();
                                cmd.CommandText = @"INSERT INTO PHONG VALUES(N'" + txt_maphong.Text + @"',N'" + cbo_maloaiphong.Text + @"',N'" + txt_tenphong.Text + @"',N'" + cbo_trangthai.Text + "')";
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi, Không Được Trùng Mã Phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_khoitao_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                    cbo_maloaiphong.Text = string.Empty;
                    cbo_maloaiphong.Enabled = true;
                    item.Enabled = true;
                    txt_maphong.Focus();
                }
            }
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            dgvPhong.Enabled = false;
        }

        private void dgvPhong_Click(object sender, EventArgs e)
        {
            int i;
            i = dgvPhong.CurrentRow.Index;
            txt_maphong.Text = dgvPhong.Rows[i].Cells[0].Value.ToString();
            cbo_maloaiphong.Text = dgvPhong.Rows[i].Cells[1].Value.ToString();
            txt_tenphong.Text = dgvPhong.Rows[i].Cells[2].Value.ToString();
            cbo_trangthai.Text = dgvPhong.Rows[i].Cells[3].Value.ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                    cbo_maloaiphong.Text = string.Empty;
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_maphong.Enabled = false;
            cmd = con.CreateCommand();
            cmd.CommandText = @"UPDATE PHONG SET IDPHONG = N'" + txt_maphong.Text + @"', IDLOAIPHONG = N'" + cbo_maloaiphong.Text + @"', TENPHONG = N'" + txt_tenphong.Text + @"', TRANGTHAI = N'" + cbo_trangthai.Text + "' WHERE (IDPHONG = N'" + txt_maphong.Text + @"')";
            cmd.ExecuteNonQuery();
            LoadData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_them.Enabled = false;
            dgvPhong.Enabled = true;

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = true;
                    cbo_maloaiphong.Enabled = true;
                }
            }
            txt_maphong.Enabled = false;
        }

        private void FormQuanLyPhong_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd = con.CreateCommand();
                cmd.CommandText = @"DELETE FROM PHONG WHERE IDPHONG = '" + txt_maphong.Text + "'";
                cmd.ExecuteNonQuery();
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormQuanLyLoaiPhong frmQLLoaiPhong = new FormQuanLyLoaiPhong();
            frmQLLoaiPhong.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nhapmaphong_search.Text == string.Empty)
                {
                    LoadData();
                    MessageBox.Show("Chưa Nhập Thông Tin");
                }
                else
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = @"SELECT * FROM PHONG WHERE IDPHONG = '" + txt_nhapmaphong_search.Text + "'";
                    adapter.SelectCommand = cmd;
                    table.Clear();
                    adapter.Fill(table);
                    dgvPhong.DataSource = table;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatPhong frm = new DatPhong();
            frm.Show();
            Hide();
        }
    }
}
