
namespace QuanLyNhaSach.Forms
{
    partial class Dialog_BaoCaoCongNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_BaoCaoCongNo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new MaterialSurface.ContainedButton();
            this.btnLapbaocao = new MaterialSurface.ContainedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpNgaybaocao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLapbaocao);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dtpNgaybaocao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 240);
            this.panel1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.EffectType = MaterialSurface.ET.Custom;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(285, 168);
            this.btnHuy.MouseState = MaterialSurface.MouseState.OUT;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnHuy.Radius = 6;
            this.btnHuy.ShawdowDepth = 3;
            this.btnHuy.ShawdowOpacity = 50;
            this.btnHuy.Size = new System.Drawing.Size(143, 46);
            this.btnHuy.TabIndex = 22;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLapbaocao
            // 
            this.btnLapbaocao.EffectType = MaterialSurface.ET.Custom;
            this.btnLapbaocao.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLapbaocao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLapbaocao.Icon = null;
            this.btnLapbaocao.Location = new System.Drawing.Point(18, 168);
            this.btnLapbaocao.MouseState = MaterialSurface.MouseState.OUT;
            this.btnLapbaocao.Name = "btnLapbaocao";
            this.btnLapbaocao.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLapbaocao.Radius = 6;
            this.btnLapbaocao.ShawdowDepth = 3;
            this.btnLapbaocao.ShawdowOpacity = 50;
            this.btnLapbaocao.Size = new System.Drawing.Size(134, 46);
            this.btnLapbaocao.TabIndex = 21;
            this.btnLapbaocao.Text = "Lập báo cáo";
            this.btnLapbaocao.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLapbaocao.UseVisualStyleBackColor = true;
            this.btnLapbaocao.Click += new System.EventHandler(this.btnLapbaocao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // dtpNgaybaocao
            // 
            this.dtpNgaybaocao.CustomFormat = "MM/yyyy";
            this.dtpNgaybaocao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaybaocao.Location = new System.Drawing.Point(167, 139);
            this.dtpNgaybaocao.Name = "dtpNgaybaocao";
            this.dtpNgaybaocao.ShowUpDown = true;
            this.dtpNgaybaocao.Size = new System.Drawing.Size(96, 27);
            this.dtpNgaybaocao.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(100, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Chọn tháng lập báo cáo";
            // 
            // Dialog_BaoCaoCongNo
            // 
            this.AcceptButton = this.btnLapbaocao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(472, 250);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(800, 400);
            this.Name = "Dialog_BaoCaoCongNo";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog_BaoCaoCongNo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSurface.ContainedButton btnHuy;
        private MaterialSurface.ContainedButton btnLapbaocao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpNgaybaocao;
        private System.Windows.Forms.Label label1;
    }
}