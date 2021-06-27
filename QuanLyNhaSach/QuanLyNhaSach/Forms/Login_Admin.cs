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
    public partial class Login_Admin : Form
    {
        public Login_Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CNPM\Quan ly nha sach\QLNS.mdf;Integrated Security=True;Connect Timeout=30");

                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from NHANVIEN where Username='" + txtuser.Text + "' and Password='" + txtpassword.Text + "' and Type='admin'", conn);
                SqlDataReader dta = cmd.ExecuteReader();

                if (dta.HasRows)
                {
                    dta.Read();

                    MessageBox.Show("Thanh cong dang nhap Admin");
                    Dashboard_Admin da = new Dashboard_Admin();
                    da.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
