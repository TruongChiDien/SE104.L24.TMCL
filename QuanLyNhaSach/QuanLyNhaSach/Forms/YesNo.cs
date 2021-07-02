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
        #region Properties
        public bool yes;

        #endregion


        #region Methods
        public YesNo()
        {
            InitializeComponent();
        }

        #endregion


        #region Events
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

        #endregion

    }
}
