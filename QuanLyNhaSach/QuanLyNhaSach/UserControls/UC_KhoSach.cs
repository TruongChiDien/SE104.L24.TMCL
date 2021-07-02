using QuanLyNhaSach.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyNhaSach.DA;

namespace QuanLyNhaSach.UserControls
{
    public partial class UC_KhoSach : UserControl
    {
        public UC_KhoSach()
        {
            InitializeComponent();
            Grid_tb_loadData();
            Grid_tb_books.Columns["Deletebook"].DisplayIndex = 7;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = @"INSERT INTO PHIEUNHAP VALUES((SELECT CONVERT(DATETIME, GETDATE())))";
            DataProvider.Instance.ExecuteNonQuery(query);
            using (TaoPhieuNhap ts = new TaoPhieuNhap())
            {

                try
                {
                    DataProvider.Instance.ExecuteNonQuery(@"drop table SACHPHU");
                }
                catch { }
                query = @"select * into SACHPHU from SACH";
                DataProvider.Instance.ExecuteNonQuery(query);
                ts.ShowDialog();
            }

            Grid_tb_loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;
            string ID = Grid_tb_books.Rows[a].Cells[1].FormattedValue.ToString();
            YesNo Messagebox = new Forms.YesNo();
            bool Yes = Messagebox.Messageshow("Bạn có muốn xóa sách?");
            Messagebox.Dispose();

            if (Yes)
            {
                string query = @"DELETE FROM SACH WHERE MaSach = " + ID;

                DataProvider.Instance.ExecuteNonQuery(query);

                Grid_tb_loadData();
            }  
        }

        private void Grid_tb_loadData()
        {
            string query = "select MaSach [Mã Sách], TenSach [Tên Sách], TheLoai [Thể Loại], TacGia [Tác Giả], DGNhap [Đơn giá nhập], DGBan [Đơn giá bán], SoLuong [Số lượng] from SACH";

            Grid_tb_books.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void Grid_tb_books_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {
            string chude = "MaSach";
            switch (CbChude.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Chọn chủ dề!");
                    break;
                case 1:
                    chude = "TenSach";
                    break;
                case 2:
                    chude = "TheLoai";
                    break;
                case 3:
                    chude = "TacGia";
                    break;
            }
            try
            {
                string query = "SELECT * FROM SACH WHERE + " + chude + " like '" + TxTimkiem.Text + "%'";

                Grid_tb_books.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception)
            {

            }
        }

        private void Search_book()
        {

            string chude = "MaSach";
            switch (CbChude.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Chọn chủ dề!");
                    return;
                case 1:
                    chude = "TenSach";
                    break;
                case 2:
                    chude = "TheLoai";
                    break;
                case 3:
                    chude = "TacGia";
                    break;
            }
            try
            {
                string query = "select MaSach [Mã Sách], TenSach [Tên Sách], TheLoai [Thể Loại], TacGia [Tác Giả], DGNhap [Đơn giá nhập], DGBan [Đơn giá bán], SoLuong [Số lượng] from SACH WHERE + " + chude + " like '%" + TxTimkiem.Text + "%'";

                Grid_tb_books.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception)
            {

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search_book();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_book();
        }
    }
}
