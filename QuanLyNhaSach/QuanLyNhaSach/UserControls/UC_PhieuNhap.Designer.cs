
namespace QuanLyNhaSach.UserControls
{
    partial class UC_PhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.Deletebook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.txbTimKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1570, 76);
            this.panel1.TabIndex = 0;
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Location = new System.Drawing.Point(1277, 27);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(250, 27);
            this.txbTimKiem.TabIndex = 21;
            this.txbTimKiem.TextChanged += new System.EventHandler(this.txbTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(969, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tìm kiếm phiếu nhâp:";
            // 
            // dtgvPhieuNhap
            // 
            this.dtgvPhieuNhap.AllowUserToAddRows = false;
            this.dtgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPhieuNhap.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletebook});
            this.dtgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvPhieuNhap.Location = new System.Drawing.Point(0, 76);
            this.dtgvPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvPhieuNhap.Name = "dtgvPhieuNhap";
            this.dtgvPhieuNhap.ReadOnly = true;
            this.dtgvPhieuNhap.RowHeadersVisible = false;
            this.dtgvPhieuNhap.RowHeadersWidth = 82;
            this.dtgvPhieuNhap.RowTemplate.Height = 41;
            this.dtgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPhieuNhap.Size = new System.Drawing.Size(1570, 764);
            this.dtgvPhieuNhap.TabIndex = 1;
            this.dtgvPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPhieuNhap_CellContentClick);
            // 
            // Deletebook
            // 
            this.Deletebook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Deletebook.DefaultCellStyle = dataGridViewCellStyle2;
            this.Deletebook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebook.HeaderText = "Hiện phiếu";
            this.Deletebook.MinimumWidth = 6;
            this.Deletebook.Name = "Deletebook";
            this.Deletebook.ReadOnly = true;
            this.Deletebook.Text = "O";
            this.Deletebook.ToolTipText = "Xóa sách này";
            this.Deletebook.UseColumnTextForButtonValue = true;
            this.Deletebook.Width = 87;
            // 
            // UC_PhieuNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.dtgvPhieuNhap);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_PhieuNhap";
            this.Size = new System.Drawing.Size(1570, 840);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridView dtgvPhieuNhap;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewButtonColumn Deletebook;
        private System.Windows.Forms.TextBox txbTimKiem;
    }
}
