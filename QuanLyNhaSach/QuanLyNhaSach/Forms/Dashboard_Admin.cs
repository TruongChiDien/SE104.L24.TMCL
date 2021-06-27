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
        int PanelWidth;
        bool isCollapsed;
        public Dashboard_Admin()
        {
            InitializeComponent();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            timerRealTime.Start();
            UC_NhanVien unv = new UC_NhanVien();
            AddControlToPanel(unv);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AddControlToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //btn NhanVien
            moveTickedPanel(btnNhanVien);
            UC_NhanVien unv = new UC_NhanVien();
            AddControlToPanel(unv);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //shutdown app
            this.Dispose();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //navigation bar left
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

       
        
        private void moveTickedPanel(Control btn)
        {
            panelTicked.Top = btn.Top;
            panelTicked.Height = btn.Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // btn KhoSach
            moveTickedPanel(btnKhoSach);
            UC_KhoSach uks = new UC_KhoSach();
            AddControlToPanel(uks);
        }

        private void timerRealTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelRealTime.Text = dt.ToString("HH:mm:ss");
        }

        private void panelTicked_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelRealTime_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            // btn KhoSach
            moveTickedPanel(btnKhoSach);
            UC_KhoSach uks = new UC_KhoSach();
            AddControlToPanel(uks);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moveTickedPanel(BtPhieuNhap);
            UC_PhieuNhap uks = new UC_PhieuNhap();
            AddControlToPanel(uks);
        }
    }
}
