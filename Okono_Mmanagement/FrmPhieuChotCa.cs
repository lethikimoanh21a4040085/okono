using Okono_Mmanagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace Okono
{
    public partial class FrmPhieuChotCa : Form
    {
        public FrmPhieuChotCa()
        {
            InitializeComponent();
        }

        ChiTietPhieuChotCa chiTietPhieuChotCa = new ChiTietPhieuChotCa();
        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cbMaNhanVien.SelectedItem == null ||
                tbThoiGian.Text == null ||
                tbTienThucTe.Text == null ||
                tbTienThucTe.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường!");
            } else
            {
                // Lay danh sach hoa don ban
                string hoaDonBanQuery = String.Format("SELECT TongTien FROM HoaDonBan WHERE MaNhanVien='{0}' AND NgayBan='{1}'",
                    cbMaNhanVien.SelectedValue, tbThoiGian.Text);
                SqlDataAdapter hdbSqlData = new SqlDataAdapter(hoaDonBanQuery, Function.conn);
                DataTable hdbTable = new DataTable();
                hdbSqlData.Fill(hdbTable);
                int tongTien = 0;
                foreach (DataRow row in hdbTable.Rows)
                {
                    tongTien += Int32.Parse(row[0].ToString());
                }
                chiTietPhieuChotCa = new ChiTietPhieuChotCa();
                chiTietPhieuChotCa.TienHeThong = tongTien;
                chiTietPhieuChotCa.ThoiGian = tbThoiGian.Text;
                chiTietPhieuChotCa.CaLamViec = cbCaLamViec.Text;
                chiTietPhieuChotCa.TienThucTe = Convert.ToInt32(tbTienThucTe.Text);
                chiTietPhieuChotCa.ChenhLech = chiTietPhieuChotCa.TienHeThong - chiTietPhieuChotCa.TienThucTe;
                List<ChiTietPhieuChotCa> danhSachChiTietPhieuChotCa = new List<ChiTietPhieuChotCa>();
                danhSachChiTietPhieuChotCa.Add(chiTietPhieuChotCa);
                gridViewChenhLech.DataSource = danhSachChiTietPhieuChotCa;
                gridViewChenhLech.Columns[0].HeaderText = "Thời Gian";
                gridViewChenhLech.Columns[1].HeaderText = "Ca Làm Việc";
                gridViewChenhLech.Columns[2].HeaderText = "Tiền Thực Tế";
                gridViewChenhLech.Columns[3].HeaderText = "Tiền Hệ Thống";
                gridViewChenhLech.Columns[4].HeaderText = "Chênh Lệch";
            }
        }

        DataTable nhanVienTable = new DataTable();
        DataTable caLamViecTable = new DataTable();
        private void FrmPhieuChotCa_Load(object sender, EventArgs e)
        {
            // Lay danh sach nhan vien
            string nhanVienQuery = "SELECT MaNhanVien, TenNhanVien FROM NhanVien";
            SqlDataAdapter nhanVienSqlData = new SqlDataAdapter(nhanVienQuery, Function.conn);
            nhanVienSqlData.Fill(nhanVienTable);
            cbMaNhanVien.DataSource = nhanVienTable;
            cbMaNhanVien.ValueMember = nhanVienTable.Columns[0].ColumnName;
            cbMaNhanVien.DisplayMember = nhanVienTable.Columns[0].ColumnName;
            cbMaNhanVien.SelectedItem = null;

            // Lay danh sach ca lam viec
            string caLamViecQuery = "SELECT TenCaLamViec FROM CaLamViec";
            SqlDataAdapter caLamViecSqlData = new SqlDataAdapter(caLamViecQuery, Function.conn);
            caLamViecSqlData.Fill(caLamViecTable);
            cbCaLamViec.DataSource = caLamViecTable;
            cbCaLamViec.ValueMember = caLamViecTable.Columns[0].ColumnName;
            cbCaLamViec.DisplayMember = caLamViecTable.Columns[0].ColumnName;
            cbCaLamViec.SelectedItem = null;

            tbThoiGian.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void cbMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaNhanVien.SelectedItem == null)
            {
                tbTenNhanVien.Text = "";
            }
            else
            {
                tbTenNhanVien.Text = nhanVienTable.Rows[cbMaNhanVien.SelectedIndex].ItemArray[1].ToString();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            DataTable tblThongtinHD;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = (COMExcel.Worksheet)exBook.Worksheets[1];
            // Định dạng chung
            exRange = (COMExcel.Range)exSheet.Cells[1, 1];
            exRange.Range["A1:G50"].Font.Name = "Times new roman";
            exRange.Range["A1:D3"].Font.Size = 10;
            exRange.Range["A1:D3"].Font.Name = "Times new roman";
            exRange.Range["A1:G3"].Font.Bold = true;
            exRange.Range["A1:D3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 25;
            exRange.Range["A1:D1"].MergeCells = true;
            exRange.Range["A1:D1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:D2"].MergeCells = true;
            exRange.Range["A2:D2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:D2"].Value = "72 Khương Trung - Thanh Xuân - Hà Nội";
            exRange.Range["A3:D3"].MergeCells = true;
            exRange.Range["A3:D3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:D3"].Value = "Điện thoại: (04)37562222";
            exRange.Range["A7:A7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B7:B7"].Value = "Tên nhân viên: ";
            exRange.Range["C7:D7"].MergeCells = true;
            exRange.Range["C7:D7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["C7:D7"].Value = tbTenNhanVien.Text;
            exRange.Range["A5:D5"].Font.Size = 16;
            exRange.Range["A5:E5"].Font.Name = "Times new roman";
            exRange.Range["A5:D5"].Font.Bold = true;
            exRange.Range["A5:D5"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["A5:D5"].MergeCells = true;
            exRange.Range["A5:D5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A5:D5"].Value = "PHIẾU CHỐT CA";
            // Biểu diễn thông tin chung của phieu chot ca
            // Ngay
            DateTime d = DateTime.Now;
            exRange.Range["A1:D1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã Nhân Viên:";
            exRange.Range["C6:D6"].MergeCells = true;
            exRange.Range["C6:D6"].Value = cbMaNhanVien.SelectedValue;
            //Tạo dòng tiêu đề bảng
            exRange.Range["A8:G8"].Font.Bold = true;
            exRange.Range["A8:E8"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C8:E8"].ColumnWidth = 12;
            exRange.Range["A8:A8"].Value = "Thời Gian";
            exRange.Range["B8:B8"].Value = "Tiền Thực Tế";
            exRange.Range["C8:C8"].Value = "Tiền Hệ Thống";
            exRange.Range["D8:D8"].Value = "Chênh Lệch";
            //Điền số thứ tự vào cột 1 từ dòng 4
            exSheet.Cells[9, 1] = chiTietPhieuChotCa.ThoiGian;
            exSheet.Cells[9, 2] = chiTietPhieuChotCa.TienThucTe;
            exSheet.Cells[9, 3] = chiTietPhieuChotCa.TienHeThong;
            exSheet.Cells[9, 4] = chiTietPhieuChotCa.ChenhLech;
            exRange.Font.Bold = true;
            exRange = (COMExcel.Range)exSheet.Cells[1, 12]; //Ô A1 
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exSheet.Name = "PHIẾU CHỐT CA";
            exApp.Visible = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xoa tat ca
            cbMaNhanVien.SelectedItem = null;
            cbCaLamViec.SelectedItem = null;
            tbTenNhanVien.Text = null;
            tbThoiGian.Text = null;
            tbTienThucTe.Text= "0";
        }
    }
}
