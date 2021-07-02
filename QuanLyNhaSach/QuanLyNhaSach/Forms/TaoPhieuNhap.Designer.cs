
namespace QuanLyNhaSach.Forms
{
    partial class TaoPhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaoPhieuNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Grid_TaoPhieuNhap = new System.Windows.Forms.DataGridView();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtXuatPhieu = new System.Windows.Forms.Button();
            this.BtHuy = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtThemSach = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_TaoPhieuNhap)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtXuatPhieu);
            this.panel1.Controls.Add(this.BtHuy);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 802);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Grid_TaoPhieuNhap);
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 628);
            this.panel2.TabIndex = 14;
            // 
            // Grid_TaoPhieuNhap
            // 
            this.Grid_TaoPhieuNhap.AllowUserToAddRows = false;
            this.Grid_TaoPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_TaoPhieuNhap.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_TaoPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_TaoPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xoa});
            this.Grid_TaoPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_TaoPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.Grid_TaoPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.Grid_TaoPhieuNhap.Name = "Grid_TaoPhieuNhap";
            this.Grid_TaoPhieuNhap.ReadOnly = true;
            this.Grid_TaoPhieuNhap.RowHeadersVisible = false;
            this.Grid_TaoPhieuNhap.RowHeadersWidth = 82;
            this.Grid_TaoPhieuNhap.RowTemplate.Height = 41;
            this.Grid_TaoPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_TaoPhieuNhap.Size = new System.Drawing.Size(1180, 628);
            this.Grid_TaoPhieuNhap.TabIndex = 2;
            // 
            // Xoa
            // 
            this.Xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Xoa.DefaultCellStyle = dataGridViewCellStyle1;
            this.Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            this.Xoa.Text = "X";
            this.Xoa.ToolTipText = "Xóa sách này";
            this.Xoa.UseColumnTextForButtonValue = true;
            this.Xoa.Width = 54;
            // 
            // BtXuatPhieu
            // 
            this.BtXuatPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BtXuatPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtXuatPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtXuatPhieu.ForeColor = System.Drawing.Color.White;
            this.BtXuatPhieu.Location = new System.Drawing.Point(603, 739);
            this.BtXuatPhieu.Name = "BtXuatPhieu";
            this.BtXuatPhieu.Size = new System.Drawing.Size(587, 71);
            this.BtXuatPhieu.TabIndex = 13;
            this.BtXuatPhieu.Text = "Xuất phiếu";
            this.BtXuatPhieu.UseVisualStyleBackColor = false;
            this.BtXuatPhieu.Click += new System.EventHandler(this.BtXuatPhieu_Click);
            // 
            // BtHuy
            // 
            this.BtHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BtHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtHuy.ForeColor = System.Drawing.Color.White;
            this.BtHuy.Location = new System.Drawing.Point(-10, 739);
            this.BtHuy.Name = "BtHuy";
            this.BtHuy.Size = new System.Drawing.Size(618, 71);
            this.BtHuy.TabIndex = 12;
            this.BtHuy.Text = "Hủy";
            this.BtHuy.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.panel3.Controls.Add(this.BtThemSach);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1181, 100);
            this.panel3.TabIndex = 11;
            // 
            // BtThemSach
            // 
            this.BtThemSach.BackColor = System.Drawing.Color.SeaGreen;
            this.BtThemSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtThemSach.ForeColor = System.Drawing.Color.White;
            this.BtThemSach.Location = new System.Drawing.Point(887, 0);
            this.BtThemSach.Name = "BtThemSach";
            this.BtThemSach.Size = new System.Drawing.Size(313, 100);
            this.BtThemSach.TabIndex = 10;
            this.BtThemSach.Text = "Thêm sách";
            this.BtThemSach.UseVisualStyleBackColor = false;
            this.BtThemSach.Click += new System.EventHandler(this.BtThemSach_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo phiếu nhập";
            // 
            // TaoPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1200, 820);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaoPhieuNhap";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_TaoPhieuNhap)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewButtonColumn Deletebook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Grid_TaoPhieuNhap;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.Button BtXuatPhieu;
        private System.Windows.Forms.Button BtHuy;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtThemSach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}