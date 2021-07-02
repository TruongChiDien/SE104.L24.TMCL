
namespace QuanLyNhaSach.UserControls
{
    partial class UC_KhoSach
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
            this.txbChuDe = new System.Windows.Forms.TextBox();
            this.cbChuDe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaoPhieu = new System.Windows.Forms.Button();
            this.dtgvSach = new System.Windows.Forms.DataGridView();
            this.Deletebook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.txbChuDe);
            this.panel1.Controls.Add(this.cbChuDe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTaoPhieu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1570, 76);
            this.panel1.TabIndex = 0;
            // 
            // txbChuDe
            // 
            this.txbChuDe.AcceptsReturn = true;
            this.txbChuDe.BackColor = System.Drawing.Color.White;
            this.txbChuDe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbChuDe.Location = new System.Drawing.Point(1253, 29);
            this.txbChuDe.Margin = new System.Windows.Forms.Padding(2);
            this.txbChuDe.Name = "txbChuDe";
            this.txbChuDe.Size = new System.Drawing.Size(286, 30);
            this.txbChuDe.TabIndex = 21;
            this.txbChuDe.TextChanged += new System.EventHandler(this.txbChuDe_TextChanged);
            // 
            // cbChuDe
            // 
            this.cbChuDe.BackColor = System.Drawing.Color.White;
            this.cbChuDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbChuDe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbChuDe.FormattingEnabled = true;
            this.cbChuDe.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách",
            "Thể loại",
            "Tác giả"});
            this.cbChuDe.Location = new System.Drawing.Point(1038, 29);
            this.cbChuDe.Margin = new System.Windows.Forms.Padding(2);
            this.cbChuDe.Name = "cbChuDe";
            this.cbChuDe.Size = new System.Drawing.Size(170, 31);
            this.cbChuDe.TabIndex = 3;
            this.cbChuDe.Text = "Chủ đề tìm kiếm";
            this.cbChuDe.SelectedIndexChanged += new System.EventHandler(this.cbChuDe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(883, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tìm kiếm:";
            // 
            // btnTaoPhieu
            // 
            this.btnTaoPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.btnTaoPhieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTaoPhieu.FlatAppearance.BorderSize = 0;
            this.btnTaoPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoPhieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTaoPhieu.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTaoPhieu.Image = global::QuanLyNhaSach.Properties.Resources.Add_to_Collection_60px;
            this.btnTaoPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoPhieu.Location = new System.Drawing.Point(0, 0);
            this.btnTaoPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaoPhieu.Name = "btnTaoPhieu";
            this.btnTaoPhieu.Size = new System.Drawing.Size(324, 76);
            this.btnTaoPhieu.TabIndex = 19;
            this.btnTaoPhieu.Text = "Tạo phiếu nhập";
            this.btnTaoPhieu.UseVisualStyleBackColor = false;
            this.btnTaoPhieu.Click += new System.EventHandler(this.btnTaoPhieu_Click);
            // 
            // dtgvSach
            // 
            this.dtgvSach.AllowUserToAddRows = false;
            this.dtgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSach.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletebook});
            this.dtgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSach.Location = new System.Drawing.Point(0, 76);
            this.dtgvSach.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvSach.Name = "dtgvSach";
            this.dtgvSach.ReadOnly = true;
            this.dtgvSach.RowHeadersVisible = false;
            this.dtgvSach.RowHeadersWidth = 82;
            this.dtgvSach.RowTemplate.Height = 41;
            this.dtgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSach.Size = new System.Drawing.Size(1570, 764);
            this.dtgvSach.TabIndex = 1;
            this.dtgvSach.AllowUserToDeleteRowsChanged += new System.EventHandler(this.dtgvSach_AllowUserToDeleteRowsChanged);
            this.dtgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSach_CellContentClick);
            // 
            // Deletebook
            // 
            this.Deletebook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Deletebook.DefaultCellStyle = dataGridViewCellStyle2;
            this.Deletebook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebook.HeaderText = "Xóa";
            this.Deletebook.MinimumWidth = 6;
            this.Deletebook.Name = "Deletebook";
            this.Deletebook.ReadOnly = true;
            this.Deletebook.Text = "X";
            this.Deletebook.ToolTipText = "Xóa sách này";
            this.Deletebook.UseColumnTextForButtonValue = true;
            this.Deletebook.Width = 41;
            // 
            // UC_KhoSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.dtgvSach);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_KhoSach";
            this.Size = new System.Drawing.Size(1570, 840);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTaoPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txbChuDe;
        private System.Windows.Forms.ComboBox cbChuDe;
        private System.Windows.Forms.DataGridView dtgvSach;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewButtonColumn Deletebook;
    }
}
