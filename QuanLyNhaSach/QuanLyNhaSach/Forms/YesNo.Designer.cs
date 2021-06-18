
namespace QuanLyNhaSach.Forms
{
    partial class YesNo
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
         public bool Messageshow(string message)
        {
            TxMessage.Text = message;
            this.ShowDialog();
            return this.yes;
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtNo = new MaterialSurface.ContainedButton();
            this.BtYes = new MaterialSurface.ContainedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BtNo);
            this.panel1.Controls.Add(this.BtYes);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 227);
            this.panel1.TabIndex = 75;
            // 
            // BtNo
            // 
            this.BtNo.EffectType = MaterialSurface.ET.Custom;
            this.BtNo.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtNo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtNo.Icon = null;
            this.BtNo.Location = new System.Drawing.Point(44, 161);
            this.BtNo.Margin = new System.Windows.Forms.Padding(2);
            this.BtNo.MouseState = MaterialSurface.MouseState.OUT;
            this.BtNo.Name = "BtNo";
            this.BtNo.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BtNo.Radius = 6;
            this.BtNo.ShawdowDepth = 3;
            this.BtNo.ShawdowOpacity = 50;
            this.BtNo.Size = new System.Drawing.Size(166, 50);
            this.BtNo.TabIndex = 1;
            this.BtNo.Text = "Hủy";
            this.BtNo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtNo.UseVisualStyleBackColor = true;
            this.BtNo.Click += new System.EventHandler(this.BtNo_Click_1);
            // 
            // BtYes
            // 
            this.BtYes.EffectType = MaterialSurface.ET.Custom;
            this.BtYes.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtYes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtYes.Icon = null;
            this.BtYes.Location = new System.Drawing.Point(227, 161);
            this.BtYes.Margin = new System.Windows.Forms.Padding(2);
            this.BtYes.MouseState = MaterialSurface.MouseState.OUT;
            this.BtYes.Name = "BtYes";
            this.BtYes.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BtYes.Radius = 6;
            this.BtYes.ShawdowDepth = 3;
            this.BtYes.ShawdowOpacity = 50;
            this.BtYes.Size = new System.Drawing.Size(166, 50);
            this.BtYes.TabIndex = 0;
            this.BtYes.Text = "Đồng ý";
            this.BtYes.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtYes.UseVisualStyleBackColor = true;
            this.BtYes.Click += new System.EventHandler(this.BtYes_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxMessage);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 169);
            this.panel2.TabIndex = 0;
            // 
            // TxMessage
            // 
            this.TxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxMessage.Font = new System.Drawing.Font("Segoe UI Black", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.TxMessage.Location = new System.Drawing.Point(0, 0);
            this.TxMessage.Margin = new System.Windows.Forms.Padding(20);
            this.TxMessage.Name = "TxMessage";
            this.TxMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxMessage.Size = new System.Drawing.Size(429, 169);
            this.TxMessage.TabIndex = 77;
            this.TxMessage.Text = "Message\r\n";
            this.TxMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(447, 247);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YesNo";
            this.Padding = new System.Windows.Forms.Padding(100);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TxMessage;
        private MaterialSurface.ContainedButton BtNo;
        private MaterialSurface.ContainedButton BtYes;
    }
}