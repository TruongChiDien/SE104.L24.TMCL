using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.Forms
{
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void containedButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool isTrueTxt()
        {
            bool isAlltrue = true;
            if (String.IsNullOrEmpty(TxTenNV.Text))
            {
                MessageBox.Show("Tên không được để trống!");
                isAlltrue = false;
            }
            else if (String.IsNullOrEmpty(TxSDT.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống!");
                isAlltrue = false;
            }
            else if (String.IsNullOrEmpty(TxSDT.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống!");
                isAlltrue = false;
            }

            return isAlltrue;
        }
        private void containedButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DtNgayvaolam.Value.ToString("yyyy-MM-dd"));
            this.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
