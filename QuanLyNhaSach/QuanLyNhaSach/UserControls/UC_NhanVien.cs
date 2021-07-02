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

        #region Properties

        #endregion


        #region Methods
        public UC_NhanVien()
        {
            InitializeComponent();
            dtgvNhanVien_load();
            this.dtgvNhanVien.Columns["CDelete"].DisplayIndex = 9;

        }
        private void dtgvNhanVien_load()
        {
            string query = @"SELECT MaNV [Mã nhân viên], HoTenNV [Họ tên nhân viên], DiaChi [Địa chỉ], DienThoai [Điện thoại], Email [Email], NgayVaoLam [Ngày vào làm], Username [Tên đăng nhập], Password [Mật khẩu], type [Chứ vụ] FROM NHANVIEN";
            dtgvNhanVien.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        #endregion


        #region Events

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (ThemNhanVien tnv = new ThemNhanVien())
            {
                tnv.ShowDialog();
            }
            this.dtgvNhanVien_load();
        }

        private void dtgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;
            string ID = dtgvNhanVien.Rows[a].Cells[1].FormattedValue.ToString();
            YesNo Messagebox = new Forms.YesNo();
            bool Yes = Messagebox.Messageshow("Bạn có muốn xóa nhân viên?");
            Messagebox.Dispose();

            if (Yes)
            {
                string query = @"DELETE FROM NHANVIEN WHERE MaNV = " + ID;

                DataProvider.Instance.ExecuteNonQuery(query);

                dtgvNhanVien_load();
            }
        }

        #endregion
    }
}
