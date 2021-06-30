
namespace QuanLyNhaSach.Forms
{
    partial class Dashboard_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Admin));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnBaoMat = new System.Windows.Forms.Button();
            this.BtPhieuNhap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnKhoSach = new System.Windows.Forms.Button();
            this.panelTicked = new System.Windows.Forms.Panel();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelRealTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerRealTime = new System.Windows.Forms.Timer(this.components);
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.panelLeft.Controls.Add(this.btnBaoMat);
            this.panelLeft.Controls.Add(this.BtPhieuNhap);
            this.panelLeft.Controls.Add(this.button2);
            this.panelLeft.Controls.Add(this.btnKhoSach);
            this.panelLeft.Controls.Add(this.panelTicked);
            this.panelLeft.Controls.Add(this.btnNhanVien);
            this.panelLeft.Controls.Add(this.panel3);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(350, 927);
            this.panelLeft.TabIndex = 0;
            // 
            // btnBaoMat
            // 
            this.btnBaoMat.FlatAppearance.BorderSize = 0;
            this.btnBaoMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoMat.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBaoMat.ForeColor = System.Drawing.Color.White;
            this.btnBaoMat.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoMat.Image")));
            this.btnBaoMat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoMat.Location = new System.Drawing.Point(3, 698);
            this.btnBaoMat.Name = "btnBaoMat";
            this.btnBaoMat.Size = new System.Drawing.Size(340, 140);
            this.btnBaoMat.TabIndex = 6;
            this.btnBaoMat.Text = "Bảo mật";
            this.btnBaoMat.UseVisualStyleBackColor = true;
            this.btnBaoMat.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // BtPhieuNhap
            // 
            this.BtPhieuNhap.FlatAppearance.BorderSize = 0;
            this.BtPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPhieuNhap.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.BtPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("BtPhieuNhap.Image")));
            this.BtPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtPhieuNhap.Location = new System.Drawing.Point(5, 552);
            this.BtPhieuNhap.Name = "BtPhieuNhap";
            this.BtPhieuNhap.Size = new System.Drawing.Size(340, 140);
            this.BtPhieuNhap.TabIndex = 5;
            this.BtPhieuNhap.Text = "Tra phiếu nhập";
            this.BtPhieuNhap.UseVisualStyleBackColor = true;
            this.BtPhieuNhap.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(5, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(340, 140);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kho sách";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnKhoSach
            // 
            this.btnKhoSach.FlatAppearance.BorderSize = 0;
            this.btnKhoSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoSach.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKhoSach.ForeColor = System.Drawing.Color.White;
            this.btnKhoSach.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoSach.Image")));
            this.btnKhoSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoSach.Location = new System.Drawing.Point(10, 390);
            this.btnKhoSach.Name = "btnKhoSach";
            this.btnKhoSach.Size = new System.Drawing.Size(340, 140);
            this.btnKhoSach.TabIndex = 3;
            this.btnKhoSach.Text = "Kho sách";
            this.btnKhoSach.UseVisualStyleBackColor = true;
            this.btnKhoSach.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelTicked
            // 
            this.panelTicked.BackColor = System.Drawing.Color.White;
            this.panelTicked.Location = new System.Drawing.Point(1, 245);
            this.panelTicked.Name = "panelTicked";
            this.panelTicked.Size = new System.Drawing.Size(8, 140);
            this.panelTicked.TabIndex = 2;
            this.panelTicked.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTicked_Paint);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(10, 245);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(340, 140);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 240);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::QuanLyNhaSach.Properties.Resources.menu_64px1;
            this.button1.Location = new System.Drawing.Point(261, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 82);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book Store";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(350, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1260, 80);
            this.panel4.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(117, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 49);
            this.label8.TabIndex = 8;
            this.label8.Text = "Book Store";
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(1180, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 80);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.panel5.Controls.Add(this.labelRealTime);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(350, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1260, 163);
            this.panel5.TabIndex = 2;
            // 
            // labelRealTime
            // 
            this.labelRealTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRealTime.AutoSize = true;
            this.labelRealTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRealTime.ForeColor = System.Drawing.Color.White;
            this.labelRealTime.Location = new System.Drawing.Point(1019, 62);
            this.labelRealTime.Name = "labelRealTime";
            this.labelRealTime.Size = new System.Drawing.Size(144, 38);
            this.labelRealTime.TabIndex = 3;
            this.labelRealTime.Text = "realtime";
            this.labelRealTime.Click += new System.EventHandler(this.labelRealTime_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(327, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 38);
            this.label6.TabIndex = 7;
            this.label6.Text = "Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(190, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rules:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(316, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "<name>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 39);
            this.label3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerRealTime
            // 
            this.timerRealTime.Tick += new System.EventHandler(this.timerRealTime_Tick);
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(350, 243);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1260, 684);
            this.panelControl.TabIndex = 3;
            // 
            // Dashboard_Admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1610, 927);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard_Admin";
            this.Text = "Form_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelLeft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnKhoSach;
        private System.Windows.Forms.Panel panelTicked;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRealTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerRealTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtPhieuNhap;
        private System.Windows.Forms.Button btnBaoMat;
    }
}