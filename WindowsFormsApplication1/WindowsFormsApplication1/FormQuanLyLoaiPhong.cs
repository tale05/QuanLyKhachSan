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
    public partial class FormQuanLyLoaiPhong : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=LAPTOP-U78MOGBM;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormQuanLyLoaiPhong()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM LOAIPHONG";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvLoaiPhong.DataSource = table;
        }

        private void FormQuanLyLoaiPhong_Load(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = false;
                }
            }
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            con = new SqlConnection(str);
            con.Open();
            LoadData();
        }

        private void btn_khoitao_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                    item.Enabled = true;
                    txt_maloaiphong.Focus();
                }
            }
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            dgvLoaiPhong.Enabled = false;
        }

        private void dgvPhong_Click(object sender, EventArgs e)
        {
            int i;
            i = dgvLoaiPhong.CurrentRow.Index;
            txt_maloaiphong.Text = dgvLoaiPhong.Rows[i].Cells[0].Value.ToString();
            txt_tenloaiphong.Text = dgvLoaiPhong.Rows[i].Cells[1].Value.ToString();
            txt_dongia.Text = dgvLoaiPhong.Rows[i].Cells[2].Value.ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
            txt_tenloaiphong.Focus();
        }

        private void FormQuanLyLoaiPhong_FormClosing(object sender, FormClosingEventArgs e)
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
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_maloaiphong.Text == string.Empty)
                    MessageBox.Show("Bạn chưa nhập mã loại phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (txt_tenloaiphong.Text == string.Empty)
                        MessageBox.Show("Bạn chưa nhập tên loại phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (txt_dongia.Text == string.Empty)
                            MessageBox.Show("Bạn chưa nhập đơn giá loại phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (IsChar(txt_dongia.Text) == true)
                                MessageBox.Show("Đơn Giá Phải Là Số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                cmd = con.CreateCommand();
                                cmd.CommandText = @"INSERT INTO LOAIPHONG VALUES(N'" + txt_maloaiphong.Text + @"',N'" + txt_tenloaiphong.Text + @"',N'" + txt_dongia.Text + "')";
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
                MessageBox.Show("Lỗi, Không Được Nhập Trùng Mã Loại Phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd = con.CreateCommand();
                cmd.CommandText = @"DELETE FROM LOAIPHONG WHERE IDLOAIPHONG = '" + txt_maloaiphong.Text + "'";
                cmd.ExecuteNonQuery();
                LoadData();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_maloaiphong.Enabled = false;
            cmd = con.CreateCommand();
            cmd.CommandText = @"UPDATE LOAIPHONG SET IDLOAIPHONG = N'" + txt_maloaiphong.Text + @"', TENLOAIPHONG = N'" + txt_tenloaiphong.Text + @"', DONGIA = N'" + txt_dongia.Text + "' WHERE (IDLOAIPHONG = N'" + txt_maloaiphong.Text + @"')";
            cmd.ExecuteNonQuery();
            LoadData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_them.Enabled = false;
            dgvLoaiPhong.Enabled = true;

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = true;
                }
            }
            txt_maloaiphong.Enabled = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nhapmaloaiphong_search.Text == string.Empty)
                {
                    LoadData();
                    MessageBox.Show("Chưa Nhập Thông Tin");
                }
                else
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = @"SELECT * FROM LOAIPHONG WHERE IDLOAIPHONG = '" + txt_nhapmaloaiphong_search.Text + "'";
                    adapter.SelectCommand = cmd;
                    table.Clear();
                    adapter.Fill(table);
                    dgvLoaiPhong.DataSource = table;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
