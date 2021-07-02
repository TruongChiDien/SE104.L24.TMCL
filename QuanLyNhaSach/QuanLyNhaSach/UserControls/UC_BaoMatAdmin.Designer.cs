
namespace QuanLyNhaSach.UserControls
{
    partial class UC_BaoMatAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BaoMatAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbXacNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLuuThayDoi = new MaterialSurface.ContainedButton();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txbOldPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtHuy = new MaterialSurface.ContainedButton();
            this.btnQuit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.BtHuy);
            this.panel1.Controls.Add(this.txbXacNhan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbPassword);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnLuuThayDoi);
            this.panel1.Controls.Add(this.txbUsername);
            this.panel1.Controls.Add(this.txbOldPass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 484);
            this.panel1.TabIndex = 0;
            // 
            // txbXacNhan
            // 
            this.txbXacNhan.Location = new System.Drawing.Point(343, 287);
            this.txbXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.txbXacNhan.Name = "txbXacNhan";
            this.txbXacNhan.PasswordChar = '*';
            this.txbXacNhan.Size = new System.Drawing.Size(299, 27);
            this.txbXacNhan.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(106, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 24);
            this.label3.TabIndex = 123;
            this.label3.Text = "Nhập lại mật khẩu mới:";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(343, 235);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(299, 27);
            this.txbPassword.TabIndex = 116;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(189, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 24);
            this.label7.TabIndex = 121;
            this.label7.Text = "Mật khẩu mới:";
            // 
            // btnLuuThayDoi
            // 
            this.btnLuuThayDoi.EffectType = MaterialSurface.ET.Custom;
            this.btnLuuThayDoi.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuuThayDoi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLuuThayDoi.Icon = null;
            this.btnLuuThayDoi.Location = new System.Drawing.Point(207, 369);
            this.btnLuuThayDoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuThayDoi.MouseState = MaterialSurface.MouseState.OUT;
            this.btnLuuThayDoi.Name = "btnLuuThayDoi";
            this.btnLuuThayDoi.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLuuThayDoi.Radius = 6;
            this.btnLuuThayDoi.ShawdowDepth = 3;
            this.btnLuuThayDoi.ShawdowOpacity = 50;
            this.btnLuuThayDoi.Size = new System.Drawing.Size(167, 50);
            this.btnLuuThayDoi.TabIndex = 117;
            this.btnLuuThayDoi.Text = "Lưu thay đổi";
            this.btnLuuThayDoi.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLuuThayDoi.UseVisualStyleBackColor = true;
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(342, 148);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.PasswordChar = '*';
            this.txbUsername.Size = new System.Drawing.Size(299, 27);
            this.txbUsername.TabIndex = 114;
            // 
            // txbOldPass
            // 
            this.txbOldPass.Location = new System.Drawing.Point(343, 186);
            this.txbOldPass.Margin = new System.Windows.Forms.Padding(2);
            this.txbOldPass.Name = "txbOldPass";
            this.txbOldPass.PasswordChar = '*';
            this.txbOldPass.Size = new System.Drawing.Size(299, 27);
            this.txbOldPass.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(175, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 119;
            this.label4.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(161, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 23);
            this.label2.TabIndex = 120;
            this.label2.Text = "Mật khẩu hiện tại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(301, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 37);
            this.label1.TabIndex = 118;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // BtHuy
            // 
            this.BtHuy.EffectType = MaterialSurface.ET.Custom;
            this.BtHuy.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtHuy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtHuy.Icon = null;
            this.BtHuy.Location = new System.Drawing.Point(463, 369);
            this.BtHuy.Margin = new System.Windows.Forms.Padding(2);
            this.BtHuy.MouseState = MaterialSurface.MouseState.OUT;
            this.BtHuy.Name = "BtHuy";
            this.BtHuy.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BtHuy.Radius = 6;
            this.BtHuy.ShawdowDepth = 3;
            this.BtHuy.ShawdowOpacity = 50;
            this.BtHuy.Size = new System.Drawing.Size(178, 50);
            this.BtHuy.TabIndex = 124;
            this.BtHuy.Text = "Hủy";
            this.BtHuy.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtHuy.UseVisualStyleBackColor = true;
            this.BtHuy.Click += new System.EventHandler(this.BtHuy_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.Location = new System.Drawing.Point(733, 2);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(49, 56);
            this.btnQuit.TabIndex = 125;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // UC_BaoMatAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_BaoMatAdmin";
            this.Size = new System.Drawing.Size(804, 503);
            this.Load += new System.EventHandler(this.UC_BaoMatAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbXacNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label7;
        private MaterialSurface.ContainedButton btnLuuThayDoi;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txbOldPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSurface.ContainedButton BtHuy;
        private System.Windows.Forms.Button btnQuit;
    }
}
