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
                query = " SELECT COUNT(1) FROM SACH WHERE MaSach = " + TxMasach.Text;
                int i = 0;
                i = DataProvider.Instance.ExecuteNonQuery(query);
                //add book
                if (i == 0 ) 
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
                }
                else
                {
                    YesNo MesBox = new YesNo();
                    MesBox.Messageshow("Mã sách đã tồn tại, bạn có muốn cập nhật lại?");
                    bool Yes = MesBox.yes;
                    MesBox.Dispose();
                    if (Yes)
                    { 
                        query = @"DELETE FROM SACH WHERE MaSach = " + TxMasach.Text;
                        DataProvider.Instance.ExecuteNonQuery(query);

                        query = @"INSERT INTO SACH " +
                                             "VALUES(" + TxMasach.Text + ",'"
                                             + TxTenSach.Text + "','"
                                             + CbTheLoai.Text + "','"
                                             + TxTacGia.Text + "',"
                                             + TxGianhap.Text + ","
                                             + TxGiaban.Text + ","
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
            add_new_books();
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
