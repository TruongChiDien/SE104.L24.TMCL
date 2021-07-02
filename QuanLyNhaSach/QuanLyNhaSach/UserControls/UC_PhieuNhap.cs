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

        #region Properties

        #endregion


        #region Methods
        public UC_PhieuNhap()
        {
            InitializeComponent();
            dtgvPhieuNhap_Load();
        }
        private void dtgvPhieuNhap_Load()
        {
            string query = "SELECT MaPN [Mã phiếu nhập], NgayNhap [Ngày nhập] FROM PHIEUNHAP";

            dtgvPhieuNhap.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }


        #endregion


        #region Events
        
        private void dtgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;
            try
            {
                string ID = dtgvPhieuNhap.Rows[a].Cells[1].FormattedValue.ToString();
            
            PhieuNhap PN = new PhieuNhap(ID);
            PN.Show();
            }
            catch { }
        }

        private void txbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM PHIEUNHAP Where MaPN like '" + txbTimKiem.Text + "%'"; ;

            dtgvPhieuNhap.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        #endregion
    }
}
