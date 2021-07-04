using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyNhaSach.DA;

namespace QuanLyNhaSach.Forms
{
    public partial class ThamSo : Form
    {
        public bool yes;
        public ThamSo()
        {
            InitializeComponent();
        }

        
        private void BtYes_Click(object sender, EventArgs e)
        {
            if ( !isAllNumeric(TxMaxTon.Text + TxMinNhap.Text))
            {
                YesNo noti = new YesNo();
                noti.Messageshow("Phải nhập số nguyên !");
                return;
            }
            string query = @" update THAMSO set GiaTri = N'" + TxMaxTon.Text + "' where TenTS = N'MaxTon'";
            DataProvider.Instance.ExecuteNonQuery(query);
            query = @" update THAMSO set GiaTri = N'" + TxMinNhap.Text + "' where TenTS = N'MinNhap'";
            DataProvider.Instance.ExecuteNonQuery(query);
            this.Dispose();
        }

        private bool isAllNumeric(string str)
        {
            bool isNumeric = true;
            foreach (char c in str)
            {
                if (!Char.IsNumber(c))
                {
                    isNumeric = false;
                    break;
                }
            }
            return isNumeric;
        }
        private void BtNo_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
