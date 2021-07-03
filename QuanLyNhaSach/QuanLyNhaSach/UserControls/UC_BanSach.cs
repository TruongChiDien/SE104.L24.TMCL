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
namespace QuanLyNhaSach.UserControls
{
    public partial class UC_BanSach : UserControl
    {
        #region Properties
        YesNo msb = new YesNo();
        int tienthu;
        int total = 0;
        int soluong;
        string query;

        #endregion

        #region Method
        public UC_BanSach()
        {
            InitializeComponent();
            Grid_tb_loadData();
        }

        private void Grid_tb_loadData()
        {
            string query = "SELECT MaSach as 'Mã sách', TenSach as 'Tên sách',TheLoai as 'Thể loại',TacGia as 'Tác giả',DGBan as 'DG bán',SoLuong as 'Số lượng' FROM SACH";

            dtgvSach.DataSource = DataProvider.Instance.ExecuteQuery(query);
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

                string query = "SELECT * FROM SACH WHERE + " + chude + " like '" + TxTimkiem.Text + "%'";

                dtgvSach.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception)
            {

            }
        }

        private bool Print_HoaDon()
        {
            if(txtMaKH.Text == "")
            {
                msb.Messageshow("Nhập mã khách hàng!");
                return false;
            }
            int cnt = 0;
            query = string.Format("select count(*) from khachhang where MaKH = {0}", txtMaKH.Text);
            cnt = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            if (cnt == 0)
            {
                msb.Messageshow("Khách hàng không tồn tại!");
                return false;
            }
            query = string.Format("select HoTenKH from khachhang where MaKH = {0}", txtMaKH.Text);
            string tenKH = DataProvider.Instance.ExecuteScalar(query).ToString();

            query = string.Format("update ctcongno set PhatSinh += {0}, NoCuoi += {1} where MaKH = {2} and month(Thoigian) = {3} and year(ThoiGian) = {4}", txtTongcong.Text, txtTongcong.Text, txtMaKH.Text, DateTime.Now.Month, DateTime.Now.Year);
            DataProvider.Instance.ExecuteNonQuery(query);
            query = string.Format("update khachhang set NoKH += {0} where MaKH = {1} ", txtTongcong.Text, txtMaKH.Text);
            DataProvider.Instance.ExecuteNonQuery(query);

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "HÓA ĐƠN";
            printer.SubTitle = string.Format("Tên khách hàng: {0}                  Ngày lập hóa đơn: {1}/{2}/{3}", tenKH, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            printer.SubTitleAlignment = StringAlignment.Near;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PrintPreviewDataGridView(dtgvHoaDon);

            this.Clear();
            return true;
        }

        public void PrintPhieuThu(int total, bool allow)
        {
            if (allow == false)
                return;

            this.tienthu = total;

            this.prtDoc.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 970, 234);
            this.prtprvDoc.Document = this.prtDoc;
            if (this.prtprvDoc.ShowDialog() == DialogResult.OK)
                this.prtDoc.Print();
            this.Clear();
        }

        void showTotal()
        {
            int total = 0;
            for (int i = 0; i < dtgvHoaDon.Rows.Count-1; i++)
            {
                total += Convert.ToInt32(dtgvHoaDon.Rows[i].Cells[2].Value) * Convert.ToInt32(dtgvHoaDon.Rows[i].Cells[1].Value);
            }
            txtTongcong.Text = total.ToString();
            if(total != 0)
            {
                btnThanhToan.Enabled = true;
                btnInHoaDon.Enabled = true;
            }
        }

        private void Clear()
        {
            dtgvHoaDon.Rows.Clear();
            this.showTotal();
            btnInHoaDon.Enabled = false;
            btnThanhToan.Enabled = false;
        }
        #endregion

        #region Event

        private void txbTimKiem_TextChanged(object sender, EventArgs e)
        {
            Search_book();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            
            if (dtgvHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào được chọn");
            }
            else
            {
                int qty = 0;
                int n = dtgvHoaDon.Rows.Count - 1;
                for (int i = 0; i < n; i++)
                {
                    qty = Convert.ToInt32((dtgvHoaDon.Rows[i].Cells[1].Value).ToString());
                    string t_sach = (dtgvHoaDon.Rows[i].Cells[0].Value).ToString();
                    
                    string query = string.Format("update SACH set SoLuong -= {0} where TenSach = '{1}'", qty, t_sach);
                    DataProvider.Instance.ExecuteNonQuery(query);
                }

                this.Print_HoaDon();
            }
        }

        private void dtgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.CurrentRow.Selected = true;
            //txtTensach.Text = dataGridView1.Rows[e.RowIndex].Cells["TenSach"].FormattedValue.ToString();
            //txtTacgia.Text = dataGridView1.Rows[e.RowIndex].Cells["TacGia"].FormattedValue.ToString();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtGiatien.Text == "")
            {
                msb.Messageshow("Vui lòng chọn sách!");
                return;
            }
            
            if (txbSoluong.Text == "")
            {
                MessageBox.Show("Nhập số lượng");
                return;
            }

            int tsl = Convert.ToInt32(txbSoluong.Text);
            if(dtgvHoaDon.Rows.Count == 1)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dtgvHoaDon);
                newRow.Cells[0].Value = txtTensach.Text;
                newRow.Cells[1].Value = txbSoluong.Text;
                newRow.Cells[2].Value = txtGiatien.Text;

                dtgvHoaDon.Rows.Add(newRow);
                showTotal();
            }
            else
            {
                int n = dtgvHoaDon.Rows.Count;
                int id = -1;
                for(int i = 0; i<n-1; i++)
                {
                    if (txtTensach.Text == dtgvHoaDon.Rows[i].Cells[0].Value.ToString())
                    {
                        tsl += Convert.ToInt32(dtgvHoaDon.Rows[i].Cells[1].Value);
                        id = i;
                    }
                }
                if(tsl == Convert.ToInt32(txbSoluong.Text))
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dtgvHoaDon);
                    newRow.Cells[0].Value = txtTensach.Text;
                    newRow.Cells[1].Value = txbSoluong.Text;
                    newRow.Cells[2].Value = txtGiatien.Text;

                    dtgvHoaDon.Rows.Add(newRow);
                    showTotal();
                }
                else if (tsl > soluong)
                {
                    msb.Messageshow("Số lượng sách không đủ!");
                    return;
                }
                else if(id != -1)
                {
                    dtgvHoaDon.Rows[id].Cells[1].Value = Convert.ToInt32(dtgvHoaDon.Rows[id].Cells[1].Value) + Convert.ToInt32(txbSoluong.Text);
                }
                
                showTotal();
            }
        }

        private void dtgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvSach.CurrentRow.Selected = true;
            if (e.RowIndex != -1)
            {
                txtTensach.Text = dtgvSach.Rows[e.RowIndex].Cells["Tên sách"].FormattedValue.ToString();
                txtGiatien.Text = dtgvSach.Rows[e.RowIndex].Cells["DG bán"].FormattedValue.ToString();
                soluong = Convert.ToInt32(dtgvSach.Rows[e.RowIndex].Cells["Số lượng"].FormattedValue.ToString());
                if (txbSoluong.Text == "")
                {
                    return;
                }
                total = Convert.ToInt32(txbSoluong.Text) * Convert.ToInt32(txtGiatien.Text);
                txtTongtien.Text = Convert.ToString(total);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rowIndex = dtgvHoaDon.CurrentCell.RowIndex;
            dtgvHoaDon.Rows.RemoveAt(rowIndex);
            if(dtgvHoaDon.Rows.Count == 1)
            {
                btnInHoaDon.Enabled = false;
                btnThanhToan.Enabled = false;
            }
        }

        private void txbSoluong_TextChanged(object sender, EventArgs e)
        {
            if (txbSoluong.Text != "")
            {
                if (Convert.ToInt32(txbSoluong.Text) > soluong)
                {
                    MessageBox.Show("Số lượng hàng không đủ");
                }
                else
                {
                    total = Convert.ToInt32(txbSoluong.Text) * Convert.ToInt32(txtGiatien.Text);
                }
            }
          
            txtTongtien.Text = Convert.ToString(total);

        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dtgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell oneCell in dtgvHoaDon.SelectedCells)
            {
                if (oneCell.Selected)
                    dtgvHoaDon.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtgvHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào được chọn");
            }
            else
            {
                int total = Convert.ToInt32(txtTongtien.Text);
                bool allow = this.Print_HoaDon();
                this.PrintPhieuThu(total, allow);
            }
            
        }

        private void prtDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string query = string.Format("select * from khachhang where MaKH  = {0}", txtMaKH.Text);
            DataTable t = DataProvider.Instance.ExecuteQuery(query);
            string TenKH = t.Rows[0]["HoTenKH"].ToString();
            string DiaChi = t.Rows[0]["DiaChi"].ToString();
            string DienThoai = t.Rows[0]["DienThoai"].ToString();
            string Email = t.Rows[0]["Email"].ToString();

            e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(12, 9, 926, 50));
            e.Graphics.DrawString("PHIẾU THU TIỀN", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(376, 26));
            e.Graphics.DrawString("Họ tên khách hàng: " + TenKH, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(32, 86));
            e.Graphics.DrawString("Địa chỉ: " + DiaChi, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(533, 86));
            e.Graphics.DrawString("Điện thoại: " + DienThoai, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(32, 124));
            e.Graphics.DrawString("Email: " + Email, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(533, 124));
            e.Graphics.DrawString("Ngày thu tiền: " + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(32, 170));
            e.Graphics.DrawString("Số tiền thu: " + tienthu.ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(533, 170));

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Clear();
        }        
    }
    #endregion

}
