using QuanLyNhaSach.DA;
using QuanLyNhaSach.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.Forms
{
    public partial class Dashboard_Admin : Form
    {

        #region Properties
        int PanelWidth;
        bool isCollapsed;

        #endregion


        #region Method
        public Dashboard_Admin()
        {
            InitializeComponent();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            timerRealTime.Start();
            UC_NhanVien unv = new UC_NhanVien();
            AddControlToPanel(unv);
        }
        private void AddControlToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }
        private void moveTickedPanel(Control btn)
        {
            panelTicked.Top = btn.Top;
            panelTicked.Height = btn.Height;
        }

        #endregion


        #region Event
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            //btn NhanVien
            moveTickedPanel(btnNhanVien);
            UC_NhanVien unv = new UC_NhanVien();
            AddControlToPanel(unv);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //shutdown app
            this.Dispose();
        }

        private void timerRealTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelRealTime.Text = dt.ToString("HH:mm:ss");
        }

        private void btnKhoSach_Click(object sender, EventArgs e)
        {
            // btn KhoSach
            moveTickedPanel(btnKhoSach);
            UC_KhoSach uks = new UC_KhoSach();
            AddControlToPanel(uks);
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            moveTickedPanel(btnPhieuNhap);
            UC_PhieuNhap upn = new UC_PhieuNhap();
            AddControlToPanel(upn);
        }

        private void btnBaoMat_Click(object sender, EventArgs e)
        {
            DialogBaoMat dBaoMat = new DialogBaoMat();
            dBaoMat.ShowDialog();
        }

        #endregion
    }
}
