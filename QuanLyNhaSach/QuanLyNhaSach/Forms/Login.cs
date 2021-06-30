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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=MSI\\ANHDUNGSQL;Initial Catalog=E:\\CNPM\\QLNS\\QLNS.MDF;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("select * from NHANVIEN where Username='" + txtuser.Text + "' and Password='" + txtpassword.Text + "'", con);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        if (dt.Rows[i][6].ToString() == "user")
            //        {
            //            MessageBox.Show("You are login as User " + dt.Rows[i][6]);
            //            Dashboard_NhanVien da = new Dashboard_NhanVien();
            //            da.Show();
            //            this.Hide();
            //        }
            //    }
            //}

            try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\QLNS2\QLNS.mdf;Integrated Security=True;Connect Timeout=30");

                //conn.Open();
                //SqlCommand cmd = new SqlCommand("select * from NHANVIEN where Username='" + txtuser.Text + "' and Password='" + txtpassword.Text + "' and Type='nhanvien'", conn);
                //SqlDataReader dta = cmd.ExecuteReader();

                //string query = @"INSERT INTO PHIEUNHAP VALUES((SELECT CONVERT(DATETIME, GETDATE())))";
                //SqlDataReader dta = DataProvider.Instance.ExecuteNonQuery(query);
                string query = "select * from NHANVIEN where Username='" + txtuser.Text + "' and Password='" + txtpassword.Text + "' and Type='nhanvien'";
                DataTable dta = DataProvider.Instance.ExecuteQuery(query);
                if (dta.Rows.Count > 0)
                {


                    MessageBox.Show("Thanh cong dang nhap user");
                    Dashboard_NhanVien da = new Dashboard_NhanVien();
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
            Dashboard_NhanVien da = new Dashboard_NhanVien();
            da.Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            using (Login_Admin la = new Login_Admin())
            {
           
                la.Show();
                //this.Hide();               
            }
        }
    }
}
