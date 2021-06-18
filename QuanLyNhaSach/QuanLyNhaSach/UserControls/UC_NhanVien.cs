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
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
            Grid_nhanvien_load();
            this.Grid_nhanvien.Columns["CDelete"].DisplayIndex = 6;

        }

        private void Grid_nhanvien_load()
        {
            string query = @"SELECT * FROM NHANVIEN";
            Grid_nhanvien.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (ThemNhanVien tnv = new ThemNhanVien())
            {
                tnv.ShowDialog();
            }
        }

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void Grid_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
