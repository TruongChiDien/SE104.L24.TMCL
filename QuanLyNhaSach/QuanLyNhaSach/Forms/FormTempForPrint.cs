using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.Forms
{
    public partial class FormTempForPrint : Form
    {
        #region Properties

        #endregion


        #region Methods
        public FormTempForPrint()
        {
            InitializeComponent();
        }

        public DataGridView Getdtgv()
        {
            return this.dtgvTemp;
        }

        public void Setdtgv(DataTable ds)
        {
            this.dtgvTemp.DataSource = ds;
        }


        #endregion


        #region Events

        #endregion


    }
}
