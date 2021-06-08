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
    public partial class UC_KhoSach : UserControl
    {
        public UC_KhoSach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ThemSach ts = new ThemSach())
            {
                ts.ShowDialog();
            }
        }
    }
}
