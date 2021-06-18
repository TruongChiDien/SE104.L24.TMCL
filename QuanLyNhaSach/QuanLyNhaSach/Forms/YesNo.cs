using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.Forms
{
    public partial class YesNo : Form
    {
        public bool yes;
        public YesNo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void containedButton6_Click(object sender, EventArgs e)
        {

        }

        private void BtNo_Click(object sender, EventArgs e)
        {
        }

        private void BtYes_Click(object sender, EventArgs e)
        {
            this.yes = true;
            this.Hide();
        }

        private void BtNo_Click_1(object sender, EventArgs e)
        {
            this.yes = false;
            this.Hide();
        }
    }
}
