using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = E:\CNPM\Quan ly nha sach\QLNS.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection con = new SqlConnection(connectionstring);
            SqlDataAdapter da;
            con.Open();
            string StrAddBooks = @"INSERT INTO SACH " +
                                  "VALUES("+TxMasach.Text+",'"
                                  +TxTenSach.Text+"','"
                                  +CbTheLoai.Text+"','"
                                  +TxTacGia.Text+"',"
                                  +TxGianhap.Text+","
                                  +TxGiaban.Text+","
                                  +TxSoluong.Text+")";
            SqlCommand cmd = new SqlCommand(StrAddBooks,con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm sách thành công!");
            con.Close();
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
    }
}
