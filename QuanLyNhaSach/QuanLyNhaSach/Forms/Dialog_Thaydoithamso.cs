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


    public partial class Dialog_Thaydoithamso : Form
    {
        public Dialog_Thaydoithamso()
        {
            InitializeComponent();
            string query3 = string.Format("select Giatri from THAMSO where TenTS='notoida'");

            string query4 = string.Format("select Giatri from THAMSO where TenTS='tonkho'");
            int notoida_default = (Int32)DataProvider.Instance.ExecuteScalar(query3);
            int tonkho_default = (Int32)DataProvider.Instance.ExecuteScalar(query4);

            txtNoToiDa.Text = notoida_default.ToString();
            txbTonKhoToiDa.Text = tonkho_default.ToString();

        }


        #region Properties
        YesNo msb = new YesNo();
        private bool Ok;


        #endregion

        #region Event
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtNoToiDa.Text == "" || txtNoToiDa.Text == "0"|| txbTonKhoToiDa.Text == "" || txbTonKhoToiDa.Text == "0")
            {
                msb.Messageshow("Số tiền nợ tối đa không hợp lệ ");
                return;
            }
            if ( txbTonKhoToiDa.Text == "" || txbTonKhoToiDa.Text == "0")
            {
                msb.Messageshow("Số sách tồn kho tối đa không hợp lệ !");
                return;
            }
            string query = string.Format("update THAMSO set GiaTri='{0}' where TenTS='tonkho' ;update THAMSO set GiaTri='{1}' where TenTS='notoida' ",txbTonKhoToiDa.Text,txtNoToiDa.Text);

            DataProvider.Instance.ExecuteNonQuery(query);

            this.Ok = true;
            this.Dispose();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Ok = false;
            this.Dispose();
        }
        #endregion
    }
}
