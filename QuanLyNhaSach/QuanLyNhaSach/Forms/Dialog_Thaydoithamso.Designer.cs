
namespace QuanLyNhaSach.Forms
{
    partial class Dialog_Thaydoithamso
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new MaterialSurface.ContainedButton();
            this.btnLuu = new MaterialSurface.ContainedButton();
            this.txtNoToiDa = new System.Windows.Forms.TextBox();
            this.txbTonKhoToiDa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.txtNoToiDa);
            this.panel1.Controls.Add(this.txbTonKhoToiDa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 281);
            this.panel1.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.EffectType = MaterialSurface.ET.Custom;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(296, 204);
            this.btnHuy.MouseState = MaterialSurface.MouseState.OUT;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnHuy.Radius = 6;
            this.btnHuy.ShawdowDepth = 3;
            this.btnHuy.ShawdowOpacity = 50;
            this.btnHuy.Size = new System.Drawing.Size(143, 46);
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.EffectType = MaterialSurface.ET.Custom;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(43, 205);
            this.btnLuu.MouseState = MaterialSurface.MouseState.OUT;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLuu.Radius = 6;
            this.btnLuu.ShawdowDepth = 3;
            this.btnLuu.ShawdowOpacity = 50;
            this.btnLuu.Size = new System.Drawing.Size(134, 46);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtNoToiDa
            // 
            this.txtNoToiDa.Location = new System.Drawing.Point(266, 101);
            this.txtNoToiDa.MaxLength = 9;
            this.txtNoToiDa.Name = "txtNoToiDa";
            this.txtNoToiDa.Size = new System.Drawing.Size(173, 27);
            this.txtNoToiDa.TabIndex = 21;
            this.txtNoToiDa.Text = "0";
            // 
            // txbTonKhoToiDa
            // 
            this.txbTonKhoToiDa.Location = new System.Drawing.Point(266, 55);
            this.txbTonKhoToiDa.MaxLength = 9;
            this.txbTonKhoToiDa.Name = "txbTonKhoToiDa";
            this.txbTonKhoToiDa.Size = new System.Drawing.Size(173, 27);
            this.txbTonKhoToiDa.TabIndex = 21;
            this.txbTonKhoToiDa.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(22, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nợ tối đa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sách tồn kho tối thiểu";
            // 
            // Dialog_Thaydoithamso
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(537, 303);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dialog_Thaydoithamso";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSurface.ContainedButton btnHuy;
        private MaterialSurface.ContainedButton btnLuu;
        private System.Windows.Forms.TextBox txbTonKhoToiDa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoToiDa;
        private System.Windows.Forms.Label label2;
    }
}