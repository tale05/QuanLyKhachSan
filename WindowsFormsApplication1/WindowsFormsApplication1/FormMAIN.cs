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
    public partial class FormMAIN : Form
    {

        public FormMAIN()
        {
            InitializeComponent();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang frmKH = new FormKhachHang();
            frmKH.Show();
            Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
            Hide();
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatPhong frmDatPhong = new DatPhong();
            frmDatPhong.Show();
            Hide();
        }

        private void quảnLýPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormQuanLyPhong frmQLPhong = new FormQuanLyPhong();
            frmQLPhong.Show();
            Hide();
        }


        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau frmDoiMatKhau = new FormDoiMatKhau();
            frmDoiMatKhau.Show();
            Hide();
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyDichVu frmQLDichVu = new FormQuanLyDichVu();
            frmQLDichVu.Show();
            Hide();
        }

        private void quảnLýLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyLoaiPhong frmQLLoaiPhong = new FormQuanLyLoaiPhong();
            frmQLLoaiPhong.Show();
            Hide();
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDon frmHoaDon = new FormHoaDon();
            frmHoaDon.Show();
            Hide();
        }

        private void FormMAIN_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKe frmThongKe = new FormThongKe();
            frmThongKe.Show();
            Hide();
        }

        private void quảnLýHóaĐơnDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDonDichVu frmHDDV = new FormHoaDonDichVu();
            frmHDDV.Show();
            Hide();
        }

        private void thốngKêHóaĐơnSửDụngDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKeHoaDonDV frm = new FormThongKeHoaDonDV();
            frm.Show();
            Hide();
        }
        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien frm = new FormNhanVien();
            frm.Show();
            Hide();
        }

        private void FormMAIN_FormClosing(object sender, FormClosingEventArgs e)
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
