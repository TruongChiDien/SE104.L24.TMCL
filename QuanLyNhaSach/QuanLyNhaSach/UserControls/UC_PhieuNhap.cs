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
using DGVPrinterHelper;
namespace QuanLyNhaSach.UserControls
{
    public partial class UC_PhieuNhap : UserControl
    {
        public UC_PhieuNhap()
        {
            InitializeComponent();
            Grid_tb_loadData();
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
            try
            {
                string ID = Grid_PhieuNhap.Rows[a].Cells[1].FormattedValue.ToString();
            
            PhieuNhap PN = new PhieuNhap(ID);
            PN.Show();
            }
            catch { }
        }

        private void Grid_tb_loadData()
        {
            string query = "SELECT MaPN [Mã phiếu nhập], NgayNhap [Ngày nhập] FROM PHIEUNHAP";

            Grid_PhieuNhap.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void Grid_tb_books_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM PHIEUNHAP Where MaPN like '" + textBox1.Text + "%'"; ;

            Grid_PhieuNhap.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
