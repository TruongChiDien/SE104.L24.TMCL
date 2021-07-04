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
        #region Properties

        #endregion


        #region Methods
        public UC_KhoSach()
        {
            InitializeComponent();
            dtgvSach_loadData();
            dtgvSach.Columns["Deletebook"].DisplayIndex = 7;
        }

        private void dtgvSach_loadData()
        {
            string query = "select MaSach [Mã Sách], TenSach [Tên Sách], TheLoai [Thể Loại], TacGia [Tác Giả], DGNhap [Đơn giá nhập], DGBan [Đơn giá bán], SoLuong [Số lượng] from SACH";

            dtgvSach.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void Search_book()
        {

            string chude = "MaSach";
            switch (cbChuDe.SelectedIndex)
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
                string query = "select MaSach [Mã Sách], TenSach [Tên Sách], TheLoai [Thể Loại], TacGia [Tác Giả], DGNhap [Đơn giá nhập], DGBan [Đơn giá bán], SoLuong [Số lượng] from SACH WHERE + " + chude + " like '%" + txbChuDe.Text + "%'";

                dtgvSach.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception)
            {

            }
        }


        #endregion


        #region Events
        private void btnTaoPhieu_Click(object sender, EventArgs e)
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

            dtgvSach_loadData();
        }

        private void dtgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;
            string ID = dtgvSach.Rows[a].Cells[1].FormattedValue.ToString();
            YesNo Messagebox = new Forms.YesNo();
            bool Yes = Messagebox.Messageshow("Bạn có muốn xóa sách?");
            Messagebox.Dispose();

            if (Yes)
            {
                string query = @"DELETE FROM SACH WHERE MaSach = " + ID;

                DataProvider.Instance.ExecuteNonQuery(query);

                dtgvSach_loadData();
            }  
        }


        private void dtgvSach_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {
            string chude = "MaSach";
            switch (cbChuDe.SelectedIndex)
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
                string query = "SELECT * FROM SACH WHERE + " + chude + " like '" + txbChuDe.Text + "%'";

                dtgvSach.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception)
            {

            }
        }

        private void txbChuDe_TextChanged(object sender, EventArgs e)
        {
            Search_book();
        }

        private void cbChuDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_book();
        }

<<<<<<< HEAD
        private void button2_Click(object sender, EventArgs e)
        {
            ThamSo TS = new ThamSo();
            TS.ShowDialog();
        }
=======
        #endregion
>>>>>>> 583d3710025f256b1edb0e76d267414c5f0c4b91
    }
}
