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
        int PanelWidth;
        bool isCollapsed;
        public Dashboard_NhanVien()
        {
            InitializeComponent();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            timerRealTime.Start();
            UC_BanSach ubs = new UC_BanSach();
            AddControlToPanel(ubs);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 91)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelRealTime.Text = dt.ToString("HH:mm:ss");
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

        private void labelRealTime_Click(object sender, EventArgs e)
        {

        }

        private void timerRealTime_Tick_1(object sender, EventArgs e)
        {
            //real time
            DateTime dt = DateTime.Now;
            labelRealTime.Text = dt.ToString("HH:mm:ss");
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTicked_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
