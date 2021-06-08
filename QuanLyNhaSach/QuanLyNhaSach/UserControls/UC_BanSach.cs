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
    public partial class UC_BanSach : UserControl
    {
        public UC_BanSach()
        {
            InitializeComponent();
        }

        private void UC_BanSach_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void containedButton5_Click(object sender, EventArgs e)
        {
            using (HoanThanhDonHang htdh = new HoanThanhDonHang())
            {
                htdh.ShowDialog();
            }
        }
    }
}
