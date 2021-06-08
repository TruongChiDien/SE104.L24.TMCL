using QuanLyNhaSach.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.UserControls
{
    public partial class UC_KhachHang : UserControl
    {
        private ThemKhachHang tkhm;

        public UC_KhachHang()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ThemKhachHang tkh = new ThemKhachHang())
            {
                tkh.ShowDialog();
            }    
            
        }
    }
}
