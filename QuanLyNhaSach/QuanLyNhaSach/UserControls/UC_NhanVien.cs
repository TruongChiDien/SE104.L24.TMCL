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
            int a = e.RowIndex;
            string ID = Grid_nhanvien.Rows[a].Cells[1].FormattedValue.ToString();
            YesNo Messagebox = new Forms.YesNo();
            bool Yes = Messagebox.Messageshow("Bạn có muốn xóa nhân viên?");
            Messagebox.Dispose();

            if (Yes)
            {
                string query = @"DELETE FROM NHANVIEN WHERE MaNV = " + ID;

                DataProvider.Instance.ExecuteNonQuery(query);

                Grid_nhanvien_load();
            }
        }
    }
}
