using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyNhaSach.DA;

namespace QuanLyNhaSach.Forms
{
    public partial class ThemSach : Form
    {
        public ThemSach()
        {
            InitializeComponent();
            Binding_the_loai();
        }

        private void Binding_the_loai()
        {
            string query = @"select TheLoai from SACH";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<string> ls = new List<string>();
            foreach (DataRow i in dt.Rows)
            {
                ls.Add(i[0].ToString());
            }
            CbTheLoai.DataSource = ls;
        }
        private void containedButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool isAllNumeric(string str)
        {
            bool isNumeric = true;
            foreach (char c in str)
            {
                if (!Char.IsNumber(c))
                {
                    isNumeric = false;
                    break;
                }
            }
            return isNumeric;
        }
        private bool isTextConstraintTypeSatisfied()
        {

            bool isAllTrue = true;
            if (!isAllNumeric(TxMasach.Text))
            {
                MessageBox.Show("Mã sách phải là kiểu số nguyên!");
                isAllTrue = false;
            }
            else if (String.IsNullOrEmpty(TxTenSach.Text))
            {
                MessageBox.Show("Tên sách không được trống!");
                isAllTrue = false;
            }
            else if (String.IsNullOrEmpty(TxTacGia.Text))
            {
                MessageBox.Show("Tác giả không được trống!");
                isAllTrue = false;
            }
            else if (String.IsNullOrEmpty(CbTheLoai.Text))
            {
                MessageBox.Show("Thể loại không được trống!");
                isAllTrue = false;
            }
            else if (!isAllNumeric(TxGianhap.Text))
            {
                MessageBox.Show("Giá nhập phải là kiểu số nguyên!");
                isAllTrue = false;
            }
            else if (!isAllNumeric(TxSoluong.Text))
            {
                MessageBox.Show("Số lượng phải là kiểu số nguyên!");
                isAllTrue = false;
            }
            else if (!isAllNumeric(TxGiaban.Text))
            {
                MessageBox.Show("Giá bán phải là kiểu số nguyên!");
                isAllTrue = false;
            }
            return isAllTrue;
        }

        private void add_new_books()
        {
            string query;
            try
            {
                //Check if a book existed
                query = " SELECT COUNT(1) FROM SACH WHERE MaSach = N'" + TxMasach.Text+"'";
                object i = 0;
                i = DataProvider.Instance.ExecuteScalar(query);
                //add book
                if (int.Parse(i.ToString()) == 0 ) 
                {
                    query = @"INSERT INTO SACH " +
                                         "VALUES(" + TxMasach.Text + ",'"
                                         + TxTenSach.Text + "','"
                                         + CbTheLoai.Text + "','"
                                         + TxTacGia.Text + "',"
                                         + TxGianhap.Text + ","
                                         + TxGiaban.Text + ","
                                         + TxSoluong.Text + ")";
                    DataProvider.Instance.ExecuteNonQuery(query);
                    query = @"insert into CTPHIEUNHAP values((select max(MaPN) from PHIEUNHAP),"
                            + TxMasach.Text + ", "
                            + TxSoluong.Text + ")";
                    DataProvider.Instance.ExecuteNonQuery(query);
                }
                else
                {
                    YesNo MesBox = new YesNo();
                    MesBox.Messageshow("Mã sách đã tồn tại, bạn có muốn thêm?");
                    bool Yes = MesBox.yes;
                    MesBox.Dispose();
                    if (Yes)
                    { 

                        query = @" update SACH set SoLuong = Soluong + " + TxSoluong.Text + " where Masach = " + TxMasach.Text;
                        DataProvider.Instance.ExecuteNonQuery(query);
                        query = @"insert into CTPHIEUNHAP values((select max(MaPN) from PHIEUNHAP),"
                                + TxMasach.Text + ", "
                                + TxSoluong.Text + ")";
                        DataProvider.Instance.ExecuteNonQuery(query);
                    }
                }
            }
            catch { }
        }
        private void containedButton6_Click(object sender, EventArgs e)
        {
            if (!isTextConstraintTypeSatisfied())
                return;
            string query = @"select SoLuong from SACH where MaSach = '" + TxMasach.Text + "'";
            object i = DataProvider.Instance.ExecuteScalar(query);
            query = @"select GiaTri from THAMSO where TenTS = 'MaxTon'";
            object j = DataProvider.Instance.ExecuteScalar(query);
            if (i != null)
                if (int.Parse(i.ToString()) > int.Parse(j.ToString()))
                    {
                        YesNo noti = new YesNo();
                        noti.Messageshow(" Số lượng tồn quá lớn, không được phép sách này nhập!");
                        return;
                    }
            query = @"select GiaTri from THAMSO where TenTS = 'MinNhap'";
            i = DataProvider.Instance.ExecuteScalar(query);
            if (int.Parse(i.ToString()) > int.Parse(TxSoluong.Text))
            {
                YesNo noti = new YesNo();
                noti.Messageshow(" Số lượng nhập quá ít! Phải lớn hơn: " + int.Parse(i.ToString()));
                return;
            }

            add_new_books();
            Binding_the_loai();
            this.Dispose();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
