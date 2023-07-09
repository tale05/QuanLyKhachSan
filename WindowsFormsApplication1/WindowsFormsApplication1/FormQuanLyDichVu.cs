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
    public partial class FormQuanLyDichVu : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=LAPTOP-U78MOGBM;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormQuanLyDichVu()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM DICHVU";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvLoaiPhong.DataSource = table;
        }

        private void FormQuanLyDichVu_Load(object sender, EventArgs e)
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
                    txt_madichvu.Focus();
                }
            }
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            dgvLoaiPhong.Enabled = false;
        }

        private void dgvLoaiPhong_Click(object sender, EventArgs e)
        {
            int i;
            i = dgvLoaiPhong.CurrentRow.Index;
            txt_madichvu.Text = dgvLoaiPhong.Rows[i].Cells[0].Value.ToString();
            txt_tendichvu.Text = dgvLoaiPhong.Rows[i].Cells[1].Value.ToString();
            txt_dongiadichvu.Text = dgvLoaiPhong.Rows[i].Cells[2].Value.ToString();
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
            txt_tendichvu.Focus();
        }

        private void FormQuanLyDichVu_FormClosing(object sender, FormClosingEventArgs e)
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
            txt_madichvu.Enabled = false;
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
                if (txt_madichvu.Text == string.Empty)
                    MessageBox.Show("Bạn chưa nhập mã dịch vụ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (txt_tendichvu.Text == string.Empty)
                        MessageBox.Show("Bạn chưa nhập tên dịch vụ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (txt_dongiadichvu.Text == string.Empty)
                            MessageBox.Show("Bạn chưa nhập đơn giá", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (IsChar(txt_dongiadichvu.Text) == true)
                                MessageBox.Show("Đơn Giá Phải Là Số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                cmd = con.CreateCommand();
                                //cmd.CommandText = @"INSERT INTO DICHVU VALUES(N'" + txt_madichvu.Text + @"',N'" + txt_tendichvu.Text + @"',N'" + txt_dongiadichvu.Text + "')";
                                cmd.CommandText = @"exec ThemDichvu @iddichvu = '" + txt_madichvu.Text + @"', @tenDichvu = N'" + txt_tendichvu.Text + @"', @dongia = " + double.Parse(txt_dongiadichvu.Text) + @"";
                                cmd.ExecuteNonQuery();
                                LoadData();
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi, Không Được Nhập Trùng Mã Dich Vu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd = con.CreateCommand();
                cmd.CommandText = @"DELETE FROM DICHVU WHERE IDDICHVU = '" + txt_madichvu.Text + "'";
                cmd.ExecuteNonQuery();
                LoadData();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_madichvu.Enabled = false;
            cmd = con.CreateCommand();
            //cmd.CommandText = @"UPDATE DICHVU SET IDDICHVU = N'" + txt_madichvu.Text + @"', TENDICHVU = N'" + txt_tendichvu.Text + @"', DONGIA = N'" + txt_dongiadichvu.Text + "' WHERE (IDDICHVU = N'" + txt_madichvu.Text + @"')";
            cmd.CommandText = @"exec Capnhatdichvu @iddichvu = '" + txt_madichvu.Text + @"', @dongia = '" + double.Parse(txt_dongiadichvu.Text) + @"'";
            cmd.ExecuteNonQuery();
            LoadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nhapmadichvu_search.Text == string.Empty)
                {
                    LoadData();
                    MessageBox.Show("Chưa Nhập Thông Tin");
                }
                else
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = @"SELECT * FROM DICHVU WHERE IDDICHVU = '" + txt_nhapmadichvu_search.Text + "'";
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
