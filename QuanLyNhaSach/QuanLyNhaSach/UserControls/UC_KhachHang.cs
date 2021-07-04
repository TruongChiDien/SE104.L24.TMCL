using QuanLyNhaSach.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyNhaSach.DA;
using DGVPrinterHelper;
using System.Drawing.Printing;

namespace QuanLyNhaSach.UserControls
{
    public partial class UC_KhachHang : UserControl
    {


        #region Properties
        YesNo msb = new YesNo();
        public int tienthu;
        #endregion

        #region Method
        public UC_KhachHang()
        {
            InitializeComponent();
            dtgvKH.ColumnHeadersHeight = 28;
            Grid_Load();
            if (CheckNo() == false) this.UpdateCongNo();
        }

        private void Grid_Load()
        {
            string query = "SELECT MaKH AS 'Mã Khách hàng', HoTenKH AS 'Họ tên', NoKH AS 'Nợ',  DiaChi AS 'Địa Chỉ', DienThoai AS 'Điện thoại', Email  FROM KHACHHANG";
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
            btnThutien.Enabled = false;
            txbNo.Enabled = true;
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

        private void ThemKH()
        {
            if (txbTenKH.Text == "" || txbDiaChi.Text == "" || txbDienThoai.Text == "" || txbEmail.Text == "" || txbNo.Text == "")
            {
                msb.Messageshow("Vui lòng nhập đầy đủ thông tin Khách hàng!");
                return;
            }
            string query = string.Format("select MaKH from khachhang where DienThoai = {0}", txbDienThoai.Text);
            int check = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            if (check != 0)
            {
                msb.Messageshow("Khách hàng đã tồn tại!");
                return;
            }
            query = "INSERT INTO KHACHHANG (HoTenKH, DiaChi, DienThoai, Email, NoKH) VALUES (N'" + txbTenKH.Text + "', N'" + txbDiaChi.Text + "', N'" + txbDienThoai.Text + "', N'" + txbEmail.Text + "', " + Convert.ToInt32(txbNo.Text) + ")";
            DataProvider.Instance.ExecuteNonQuery(query);

            query = string.Format("select MaKH from khachhang where DienThoai = {0}", txbDienThoai.Text);
            int MaKH = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));

            query = string.Format("insert into ctcongno values('{0}/{5}/{1}', {2}, {3}, 0, {4})", DateTime.Now.Month, DateTime.Now.Year, MaKH, txbNo.Text, txbNo.Text, DateTime.Now.Day);
            DataProvider.Instance.ExecuteNonQuery(query);

            Clear();
            Grid_Load();
        }

        private void XoaKH()
        {
            if (txbMaKH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Khách hàng muốn xóa!");
            }
            else
            {
                string query = "select count(*) from ctcongno where month(ThoiGian) = " + DateTime.Now.Month.ToString() + " and year(ThoiGian) = " + DateTime.Now.Year.ToString() + " and MaKH = " + txbMaKH.Text;
                int NoKH = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
                if (NoKH > 0)
                {
                    msb.Messageshow("Khách hàng này còn nợ, bạn có chắc là muốn xóa?");
                    if (msb.yes == false) return;
                }
                query = "DELETE FROM ctcongno WHERE MaKH = " + txbMaKH.Text;
                DataProvider.Instance.ExecuteNonQuery(query);
                query = "DELETE FROM khachhang WHERE MaKH = " + txbMaKH.Text;
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
                //Clear();
                Grid_Load();
            }
        }

        public void PrintPhieuThu()
        {
            Dialog_ThuTien t_thutien = new Dialog_ThuTien();
            t_thutien.ShowDialog();
            if (t_thutien.Ok == false) return;

            tienthu = t_thutien.Tienthu;
            string query = string.Format("select * from ctcongno where MaKH = {0} and month(ThoiGian) = {1} and year(ThoiGian) = {2}", Convert.ToInt32(txbMaKH.Text), DateTime.Now.Month, DateTime.Now.Year);
            DataTable dtt = DataProvider.Instance.ExecuteQuery(query);
            int NoCuoi = Convert.ToInt32(dtt.Rows[0]["NoCuoi"]);
            int PhatSinh = Convert.ToInt32(dtt.Rows[0]["PhatSinh"]);
            bool bigger = false;
            while (tienthu > NoCuoi)
            {
                msb.Messageshow("Bạn muốn thu số tiền lớn hơn số tiền khách đang nợ?");
                if (msb.yes == true)
                {
                    bigger = true;
                    break;
                }
                Dialog_ThuTien t_thutien1 = new Dialog_ThuTien();
                t_thutien1.ShowDialog();
                if (t_thutien1.Ok == false) return;
                tienthu = t_thutien1.Tienthu;
            }
            if(bigger == false)
            {
                query = string.Format("update ctcongno set PhatSinh = {0}, NoCuoi = {1} where MaKH = {2} and month(ThoiGian) = {3} and year(ThoiGian) = {4}", PhatSinh - tienthu, NoCuoi - tienthu, Convert.ToInt32(txbMaKH.Text), DateTime.Now.Month, DateTime.Now.Year);
                DataProvider.Instance.ExecuteNonQuery(query);
                query = string.Format("update khachhang set NoKH = {0} where MaKH = {1}", NoCuoi - tienthu, Convert.ToInt32(txbMaKH.Text));
                DataProvider.Instance.ExecuteNonQuery(query);
            }

            this.prtDoc.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 970, 234);
            this.prtprevDoc.Document = this.prtDoc;
            if (this.prtprevDoc.ShowDialog() == DialogResult.OK)
                this.prtDoc.Print();
            Grid_Load();
        }

        private bool CheckNo()
        {
            int month, year;
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
            string query = "select count(*) from ctcongno where month(ThoiGian) = " + month.ToString() + " and year(ThoiGian) = " + year.ToString();
            int res = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            if (res == 0) return false;
            return true;
        }

        private void UpdateCongNo()
        {
            string query = "select * from khachhang";
            DataTable t_dtt = DataProvider.Instance.ExecuteQuery(query);
            if (t_dtt.Columns.Count > 1)
            {
                foreach (DataRow item in t_dtt.Rows)
                {
                    query = string.Format("insert into ctcongno values('{0}/1/{1}', {2}, {3}, 0, {4})", DateTime.Now.Month, DateTime.Now.Year, Convert.ToInt32(item["MaKH"]), Convert.ToInt32(item["NoKH"]), Convert.ToInt32(item["NoKH"]));
                    DataProvider.Instance.ExecuteNonQuery(query);
                }
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
            btnThutien.Enabled = true;
            btnThem.Enabled = false;
            txbNo.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemKH();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

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
            Dialog_BaoCaoCongNo d = new Dialog_BaoCaoCongNo();
            d.ShowDialog();
            if (d.Ok == false) return;

            string query = "select * from ctcongno where month(ThoiGian) =" + d.Date.Month + " and year(ThoiGian) = " + d.Date.Year;

            object makh = DataProvider.Instance.ExecuteScalar(query);

            if (makh == null)
            {
                msb.Messageshow("Chưa có thông tin công nợ tháng " + d.Date.Month + " năm " + d.Date.Year);
                //MessageBox.Show("Chưa có thông tin công nợ tháng " + d.Date.Month + " năm " + d.Date.Year);
                return;
            }

            query = "select kh.HoTenKH as [Khách Hàng], ct.NoDau as [Nợ đầu], ct.PhatSinh as [Phát sinh], ct.NoCuoi as [Nợ cuối] from CTCONGNO ct, khachhang kh where ct.MaKH = kh.MaKH and month(ThoiGian) =" + d.Date.Month + " and year(ThoiGian) = " + d.Date.Year;

            FormTempForPrint temp = new FormTempForPrint();
            temp.Setdtgv(DataProvider.Instance.ExecuteQuery(query));
            

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Báo Cáo Công Nợ";
            printer.SubTitle = string.Format("Tháng {0} Năm {1}", d.Date.Month, d.Date.Year);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.PrintPreviewDataGridView(temp.Getdtgv());
        }
        
        private void btnThutien_Click(object sender, EventArgs e)
        {
            this.PrintPhieuThu();
        }

        private void prtDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(12, 9, 926, 50));
            e.Graphics.DrawString("PHIẾU THU TIỀN", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(376, 26));
            e.Graphics.DrawString("Họ tên khách hàng: " + this.txbTenKH.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(32, 86));
            e.Graphics.DrawString("Địa chỉ: " + this.txbDiaChi.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(533, 86));
            e.Graphics.DrawString("Điện thoại: " + this.txbDienThoai.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(32, 124));
            e.Graphics.DrawString("Email: " + this.txbEmail.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(533, 124));
            e.Graphics.DrawString("Ngày thu tiền: " + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(32, 170));
            e.Graphics.DrawString("Số tiền thu: " + tienthu.ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(533, 170));
        }

        private void dtgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvKH.CurrentRow.Selected = true;
            if (e.RowIndex == -1)
                return;
            txbMaKH.Text = dtgvKH.Rows[e.RowIndex].Cells["Mã Khách hàng"].FormattedValue.ToString();
            txbTenKH.Text = dtgvKH.Rows[e.RowIndex].Cells["Họ tên"].FormattedValue.ToString();
            txbDiaChi.Text = dtgvKH.Rows[e.RowIndex].Cells["Địa Chỉ"].FormattedValue.ToString();
            txbDienThoai.Text = dtgvKH.Rows[e.RowIndex].Cells["Điện Thoại"].FormattedValue.ToString();
            txbEmail.Text = dtgvKH.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
            txbNo.Text = dtgvKH.Rows[e.RowIndex].Cells["Nợ"].FormattedValue.ToString();
            
        }

        #endregion

        private void txbDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnThem_Click(this, new EventArgs());
            }
        }

        private void txbDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }


}
