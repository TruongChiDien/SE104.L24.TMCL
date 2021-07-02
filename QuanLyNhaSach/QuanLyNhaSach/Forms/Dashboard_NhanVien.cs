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
    public partial class Dashboard_NhanVien : Form
    {
        #region Properties
        int PanelWidth;
        bool isCollapsed;

        #endregion


        #region Method
        public Dashboard_NhanVien()
        {
            InitializeComponent();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            timerRealTime.Start();
            UC_BanSach ubs = new UC_BanSach();
            AddControlToPanel(ubs);
        }
        private void movePanelTicked(Control btn)
        {
            panelTicked.Top = btn.Top;
            panelTicked.Height = btn.Height;
        }
        private void AddControlToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        #endregion


        #region Event
        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnBanSach_Click(object sender, EventArgs e)
        {
            movePanelTicked(btnBanSach);
            UC_BanSach ubs = new UC_BanSach();
            AddControlToPanel(ubs);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            movePanelTicked(btnKhachHang);
            UC_KhachHang ukh = new UC_KhachHang();
            AddControlToPanel(ukh);
        }

        private void timerRealTime_Tick_1(object sender, EventArgs e)
        {
            //real time
            DateTime dt = DateTime.Now;
            labelRealTime.Text = dt.ToString("HH:mm:ss");
        }

        private void btnBaoMat_Click(object sender, EventArgs e)
        {
            DialogBaoMat dBaoMat = new DialogBaoMat();
            dBaoMat.ShowDialog();
        }
        #endregion

    }
}
