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

namespace QuanLyNhaSach.Forms
{

    public partial class PhieuNhap : Form
    {
        #region Properties
        private string ID;

        #endregion


        #region Methods
        public PhieuNhap(string id)
        {
            ID = id;
            InitializeComponent();
            this.label1.Text += " " + ID;
            Load_grid_phieu_nhap();
        }

        private void Load_grid_phieu_nhap()
        {
            string query = @"select a.MaSach [Mã sách], a.SL [Số lượng], DGNhap [Đơn giá nhập], DGBan [Đơn giá bán] 
                                from CTPHIEUNHAP a, SACH b
                                where MaPN= " + ID + " and a.MaSach=b.MaSach";
            Grid_TaoPhieuNhap.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        #endregion


        #region Events
        private void BtXuatPhieu_Click(object sender, EventArgs e)
        {
            string query = @"select a.MaSach [Mã sách], a.SL [Số lượng], DGNhap [Đơn giá nhập], DGBan [Đơn giá bán]
                                from CTPHIEUNHAP a, SACH b
                                where MaPN= " + ID + "and a.MaSach=b.MaSach";

            FormTempForPrint temp = new FormTempForPrint();
            temp.Setdtgv(DataProvider.Instance.ExecuteQuery(query));
            query = "select " + ID + " from PHIEUNHAP ";
            object MaPN = DataProvider.Instance.ExecuteScalar(query);
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Phiếu nhập - Mã: " + MaPN.ToString();
            query = "select NgayNhap as [GETDATE] from PHIEUNHAP where MaPN = " + ID;
            object Thoigian = DataProvider.Instance.ExecuteScalar(query);
            printer.SubTitle = "Thời gian: " + Thoigian.ToString();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            query = "select sum(SL * DGNhap) from SACH a, CTPHIEUNHAP b"
                    + " where MaPN = " + ID + " and a.MaSach = b.MaSach";
            object tong = DataProvider.Instance.ExecuteScalar(query);
            printer.Footer = "Tổng tiền nhập là: " + tong.ToString();
            printer.FooterAlignment = StringAlignment.Near;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PrintPreviewDataGridView(temp.Getdtgv());

            this.Dispose();
        }

        private void BtHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        #endregion

    }
}
