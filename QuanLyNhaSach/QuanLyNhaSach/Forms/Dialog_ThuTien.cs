using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.Forms
{
    public partial class Dialog_ThuTien : Form
    {

        #region Properties
        private int tienthu;
        private bool ok;
        YesNo msb = new YesNo();

        #endregion


        #region Methods
        public int Tienthu
        {
            set { tienthu = value; }
            get { return tienthu; }
        }

        public bool Ok
        {
            get { return ok; }
            set { ok = value; }
        }

        public Dialog_ThuTien()
        {
            InitializeComponent();
        }

        #endregion


        #region Events
        private void btnLapphieuthu_Click(object sender, EventArgs e)
        {
            if (txbTienthu.Text == "" || txbTienthu.Text == "0")
            {
                msb.Messageshow("Số tiền thu không hợp lệ!");
                return;
            }
            this.Tienthu = Convert.ToInt32(this.txbTienthu.Text);
            if (this.Tienthu < 0)
            {
                msb.Messageshow("Số tiền thu phải là số dương!");
                return;
            }
            else
            {
                this.Ok = true;
                this.Dispose();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Ok = false;
            this.Dispose();
        }

        private void txbTienthu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion

    }
}
