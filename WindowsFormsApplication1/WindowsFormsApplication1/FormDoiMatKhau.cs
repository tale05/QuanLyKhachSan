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
    public partial class FormDoiMatKhau : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-U78MOGBM;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select count (*) From NHANVIEN Where USERNAME= N'" + txt_tendangnhap.Text + "' and PASS= N'" + txt_matkhaucu.Text + "'", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (txt_xacnhanmk.Text == txt_matkhaumoi.Text)
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("Update NHANVIEN set PASS = N'" + txt_matkhaumoi.Text + "' Where USERNAME= N'" + txt_tendangnhap.Text + "' and PASS = N'" + txt_matkhaucu.Text + "'", con);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    MessageBox.Show("Thành công", "Đổi Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
                else
                {
                    errorProvider1.SetError(txt_matkhaumoi, "Bạn chưa điền mật khẩu !");
                    errorProvider1.SetError(txt_xacnhanmk, "Mật khẩu mới chưa đúng !");
                }
            }
            else
            {
                errorProvider1.SetError(txt_tendangnhap, "Tên đăng nhập sai !");
                errorProvider1.SetError(txt_matkhaucu, "Mật khẩu cũ sai !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_tendangnhap.Clear();
            txt_matkhaucu.Clear();
            txt_matkhaumoi.Clear();
            txt_xacnhanmk.Clear();
            txt_tendangnhap.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMAIN frmMain = new FormMAIN();
            frmMain.Show();
            Hide();
        }
    }
}
