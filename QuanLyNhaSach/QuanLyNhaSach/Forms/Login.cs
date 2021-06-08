using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            using (Dashboard_NhanVien da = new Dashboard_NhanVien()) 
            {
                da.ShowDialog();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            using (Login_Admin la = new Login_Admin())
            {
                la.ShowDialog();               
            }
        }
    }
}
