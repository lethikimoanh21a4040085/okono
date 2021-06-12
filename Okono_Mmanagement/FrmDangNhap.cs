using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okono_Mmanagement
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            Function.OpenConnection();
        }
        public DataTable checklog(string username, string password)
        {
            Function.OpenConnection();
            string sql = "SELECT TenTaiKhoan, MatKhau FROM NhanVien WHERE TenTaiKhoan = '" + username + "' AND MatKhau ='" + password + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, Function.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = checklog(this.txtTenTaiKhoan.Text.Trim(), this.txtMatKhau.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                string chucvu = Function.GetFieldValues("SELECT MaChucVu FROM NhanVien WHERE TenTaiKhoan = '" + txtTenTaiKhoan.Text.Trim() + "'");
                if (chucvu == "OKONO01_CV02")
                {
                    this.Hide();
                    FrmTrangChu f = new FrmTrangChu();
                    f.Show();
                }
                else if (chucvu == "OKONO01_CV01")
                {
                    this.Hide();
                    FrmTrangChuNhanVien f = new FrmTrangChuNhanVien();
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Thông báo:");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Function.CloseConnetion();
            Application.Exit();
        }
    }
}
