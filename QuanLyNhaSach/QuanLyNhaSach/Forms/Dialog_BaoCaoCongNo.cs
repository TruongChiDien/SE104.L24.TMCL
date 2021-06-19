using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.Forms
{
    public partial class Dialog_BaoCaoCongNo : Form
    {
        private string date = "";
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public Dialog_BaoCaoCongNo()
        {
            InitializeComponent();
        }

        private void btnLapbaocao_Click(object sender, EventArgs e)
        {
            if (dtpNgaybaocao.Value == null)
            {
                MessageBox.Show("Vui lòng chọn tháng lập báo cáo!");
            }
            else
            {
                this.Dispose();
            }
        }
    }
}
