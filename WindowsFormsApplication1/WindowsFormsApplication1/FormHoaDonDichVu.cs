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
    public partial class FormHoaDonDichVu : Form
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
        SqlConnection con2;
        SqlCommand cmd2;
        string str2 = "Data Source=LAPTOP-U78MOGBM;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataTable table2 = new DataTable();
        public FormHoaDonDichVu()
        {
            InitializeComponent();
        }

        private void FormHoaDonDichVu_Load(object sender, EventArgs e)
        {
            //--------------------------------
            con = new SqlConnection(str);
            con.Open();
            LoadData1();
            con.Close();
            //--------------------------------
            con1 = new SqlConnection(str1);
            con1.Open();
            LoadData2();
            con1.Close();
            //--------------------------------
            con2 = new SqlConnection(str2);
            con2.Open();
            LoadData3();
            con2.Close();
        }
        private void LoadData1()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM DICHVU";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgv_DichVu.DataSource = table;
        }
        private void LoadData2()
        {
            cmd1 = con1.CreateCommand();
            cmd1.CommandText = "SELECT * FROM KHACHHANG";
            adapter1.SelectCommand = cmd1;
            table1.Clear();
            adapter1.Fill(table1);
            dgv_KhachHang.DataSource = table1;
        }
        private void LoadData3()
        {
            cmd2 = con2.CreateCommand();
            cmd2.CommandText = "SELECT * FROM CHITIETSUDUNG_DICHVU";
            adapter2.SelectCommand = cmd2;
            table2.Clear();
            adapter2.Fill(table2);
            dgv_chitietsdDV.DataSource = table2;
        }

        private void dgv_DichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_DichVu.CurrentRow.Index;
            txt_iddichvu.Text = dgv_DichVu.Rows[i].Cells[0].Value.ToString().Trim().ToUpper();
        }

        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_KhachHang.CurrentRow.Index;
            txt_idkhachhang.Text = dgv_KhachHang.Rows[i].Cells[0].Value.ToString().Trim().ToUpper();
        }
        double dongiaDV, tong;
        private void btn_thanhtoandichvu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand(@"SELECT DICHVU.DONGIA FROM DICHVU WHERE (IDDICHVU = '" + txt_iddichvu.Text.Trim() + @"')", con);
                con = new SqlConnection(str);
                con.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    dongiaDV = double.Parse(sqlReader[0].ToString());
                }

                sqlReader.Close();

                tong = dongiaDV * double.Parse(txt_soluong.Text);
                txt_tongtiendichvu.Text = tong.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_iddichvu.Text == string.Empty)
                    MessageBox.Show("Bạn chưa nhập thông tin");
                else
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = @"INSERT INTO CHITIETSUDUNG_DICHVU VALUES(N'" + txt_iddichvu.Text + @"',N'" + txt_idkhachhang.Text + @"',N'" + int.Parse(txt_soluong.Text) + @"',N'" + double.Parse(txt_tongtiendichvu.Text) + "')";
                    cmd.ExecuteNonQuery();
                    LoadData3();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    cmd.CommandText = @"DELETE FROM CHITIETSUDUNG_DICHVU WHERE IDKHACHHANG = '" + txt_idkhachhang.Text.Trim() + "'";
                    cmd.ExecuteNonQuery();
                    LoadData3();
                }
                catch
                {
                    MessageBox.Show("Lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txt_iddichvu.Text = "";
            txt_idkhachhang.Text = "";
            txt_soluong.Text = "";
            txt_tongtiendichvu.Text = "";
        }

        private void dgv_chitietsdDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_chitietsdDV.CurrentRow.Index;
            txt_iddichvu.Text = dgv_chitietsdDV.Rows[i].Cells[0].Value.ToString();
            txt_idkhachhang.Text = dgv_chitietsdDV.Rows[i].Cells[1].Value.ToString();
            txt_soluong.Text = dgv_chitietsdDV.Rows[i].Cells[2].Value.ToString();
            txt_tongtiendichvu.Text = dgv_chitietsdDV.Rows[i].Cells[3].Value.ToString();
        }
    }
}
