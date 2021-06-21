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
        private DateTime date;
        private bool ok;
        
        public bool Ok
        {
            get { return ok; }
            set { ok = value; }
        }
        public DateTime Date
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
                date = dtpNgaybaocao.Value;
                this.Ok = true;
                this.Dispose();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Ok = false;
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Danh trinh");
        }
    }
}
