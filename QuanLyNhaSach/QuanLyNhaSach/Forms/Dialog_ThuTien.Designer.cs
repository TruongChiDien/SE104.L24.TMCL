
namespace QuanLyNhaSach.Forms
{
    partial class Dialog_ThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_ThuTien));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTienthu = new System.Windows.Forms.TextBox();
            this.btnLapphieuthu = new MaterialSurface.ContainedButton();
            this.btnHuy = new MaterialSurface.ContainedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(178, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(136, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn Số Tiền Thu";
            // 
            // txbTienthu
            // 
            this.txbTienthu.Location = new System.Drawing.Point(136, 153);
            this.txbTienthu.Name = "txbTienthu";
            this.txbTienthu.Size = new System.Drawing.Size(173, 27);
            this.txbTienthu.TabIndex = 4;
            this.txbTienthu.Text = "0";
            this.txbTienthu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTienthu_KeyPress);
            // 
            // btnLapphieuthu
            // 
            this.btnLapphieuthu.EffectType = MaterialSurface.ET.Custom;
            this.btnLapphieuthu.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLapphieuthu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLapphieuthu.Icon = null;
            this.btnLapphieuthu.Location = new System.Drawing.Point(46, 192);
            this.btnLapphieuthu.MouseState = MaterialSurface.MouseState.OUT;
            this.btnLapphieuthu.Name = "btnLapphieuthu";
            this.btnLapphieuthu.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLapphieuthu.Radius = 6;
            this.btnLapphieuthu.ShawdowDepth = 3;
            this.btnLapphieuthu.ShawdowOpacity = 50;
            this.btnLapphieuthu.Size = new System.Drawing.Size(134, 46);
            this.btnLapphieuthu.TabIndex = 17;
            this.btnLapphieuthu.Text = "Lập phiếu thu";
            this.btnLapphieuthu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLapphieuthu.UseVisualStyleBackColor = true;
            this.btnLapphieuthu.Click += new System.EventHandler(this.btnLapphieuthu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.EffectType = MaterialSurface.ET.Custom;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(291, 192);
            this.btnHuy.MouseState = MaterialSurface.MouseState.OUT;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnHuy.Radius = 6;
            this.btnHuy.ShawdowDepth = 3;
            this.btnHuy.ShawdowOpacity = 50;
            this.btnHuy.Size = new System.Drawing.Size(143, 46);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // Dialog_ThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(472, 250);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLapphieuthu);
            this.Controls.Add(this.txbTienthu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(800, 400);
            this.Name = "Dialog_ThuTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTienthu;
        private MaterialSurface.ContainedButton btnLapphieuthu;
        private MaterialSurface.ContainedButton btnHuy;
    }
}