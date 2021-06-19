using QuanLyNhaSach.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyNhaSach.DA;

namespace QuanLyNhaSach.UserControls
{
    public partial class UC_KhachHang : UserControl
    {

        public UC_KhachHang()
        {
            InitializeComponent();
            dtgvKH.ColumnHeadersHeight = 28;
            Grid_Load();
        }

        #region Method

        private void Grid_Load()
        {
            string query = "SELECT MaKH AS [Mã Khách hàng], HoTenKH AS [Họ tên], NoKH AS [Nợ],  DiaChi AS [Địa Chỉ], DienThoai AS [Điện thoại], Email  FROM KHACHHANG";
            dtgvKH.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void Clear()
        {
            txbMaKH.Text = "";
            txbTenKH.Text = "";
            txbNo.Text = "0";
            txbEmail.Text = "";
            txbDienThoai.Text = "";
            txbDiaChi.Text = "";
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
        }

        private void SearchKH()
        {
            string chude = "MaKH";
            switch (cbChuDe.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Chọn loại tìm kiếm!");
                    break;
                case 1:
                    chude = "HoTenKH";
                    break;
                case 2:
                    chude = "DienThoai";
                    break;
            }
            try
            {
                string query = "SELECT * FROM KHACHHANG WHERE " + chude + " like N'%" + txbTimkiem.Text + "%'";

                dtgvKH.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception)
            {

            }
        }

        private void XoaKH()
        {
            if (txbMaKH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Khách hàng muốn xóa!");
            }
            else
            {
                string query = "DELETE FROM KHACHHANG WHERE MaKH = N'" + txbMaKH.Text + "'";
                DataProvider.Instance.ExecuteNonQuery(query);
                Clear();
                Grid_Load();
            }
        }

        private void SuaKH()
        {
            if (txbMaKH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Khách hàng muốn sửa!");
            }
            else
            {
                string query = "UPDATE KHACHHANG SET HoTenKH = N'" + txbTenKH.Text + "', DiaChi = N'" + txbDiaChi.Text + "', DienThoai = N'" + txbDienThoai.Text + "', NoKH = " + txbNo.Text + ", Email = N'" + txbEmail.Text + "' WHERE MaKH = N'" + txbMaKH.Text + "'";
                DataProvider.Instance.ExecuteNonQuery(query);
                Clear();
                Grid_Load();
            }

        }

        #endregion





        #region Events

        private void dtgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaKH.Text = dtgvKH.SelectedRows[0].Cells[0].Value.ToString();
            txbTenKH.Text = dtgvKH.SelectedRows[0].Cells[1].Value.ToString();
            txbDiaChi.Text = dtgvKH.SelectedRows[0].Cells[3].Value.ToString();
            txbDienThoai.Text = dtgvKH.SelectedRows[0].Cells[4].Value.ToString();
            txbNo.Text = dtgvKH.SelectedRows[0].Cells[2].Value.ToString();
            txbEmail.Text = dtgvKH.SelectedRows[0].Cells[5].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbTenKH.Text == "" || txbDiaChi.Text == "" || txbDienThoai.Text == "" || txbEmail.Text == "" || txbNo.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Khách hàng!");

            string query = "INSERT INTO KHACHHANG (HoTenKH, DiaChi, DienThoai, Email, NoKH) VALUES (N'" + txbTenKH.Text + "', N'" + txbDiaChi.Text + "', N'" + txbDienThoai.Text + "', N'" + txbEmail.Text + "', " + Convert.ToInt32(txbNo.Text) + ")";

            DataProvider.Instance.ExecuteNonQuery(query);
            Clear();
            Grid_Load();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        #endregion

        private void cbChuDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchKH();
        }

        private void txbTimkiem_TextChanged(object sender, EventArgs e)
        {
            SearchKH();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaKH();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaKH();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            prtdocBaocao.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (prtprevBaocao.ShowDialog() == DialogResult.OK)
            {
                prtdocBaocao.Print();
            }
        }

        private void prtdocBaocao_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridView dtgv_temp = new DataGridView();
            string query = "SELECT * FROM CONGNO CN, CTCONGNO, CT " +
                            "WHERE CN.MaNo == CT.MaNo AND ";
        }
    }
}
