
namespace QuanLyNhaSach.UserControls
{
    partial class UC_NhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Grid_nhanvien = new System.Windows.Forms.DataGridView();
            this.CDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1570, 76);
            this.panel1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::QuanLyNhaSach.Properties.Resources.Add_to_Collection_60px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 76);
            this.button1.TabIndex = 20;
            this.button1.Text = "Thêm nhân viên";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Grid_nhanvien
            // 
            this.Grid_nhanvien.AllowUserToAddRows = false;
            this.Grid_nhanvien.AllowUserToDeleteRows = false;
            this.Grid_nhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_nhanvien.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CDelete});
            this.Grid_nhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_nhanvien.Location = new System.Drawing.Point(0, 76);
            this.Grid_nhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.Grid_nhanvien.Name = "Grid_nhanvien";
            this.Grid_nhanvien.ReadOnly = true;
            this.Grid_nhanvien.RowHeadersVisible = false;
            this.Grid_nhanvien.RowHeadersWidth = 82;
            this.Grid_nhanvien.RowTemplate.Height = 29;
            this.Grid_nhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_nhanvien.ShowRowErrors = false;
            this.Grid_nhanvien.Size = new System.Drawing.Size(1570, 764);
            this.Grid_nhanvien.TabIndex = 20;
            this.Grid_nhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_nhanvien_CellContentClick);
            // 
            // CDelete
            // 
            this.CDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CDelete.HeaderText = "Xóa";
            this.CDelete.MinimumWidth = 6;
            this.CDelete.Name = "CDelete";
            this.CDelete.ReadOnly = true;
            this.CDelete.Text = "X";
            this.CDelete.ToolTipText = "X";
            this.CDelete.UseColumnTextForButtonValue = true;
            this.CDelete.Width = 41;
            // 
            // UC_NhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.Grid_nhanvien);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_NhanVien";
            this.Size = new System.Drawing.Size(1570, 840);
            this.Load += new System.EventHandler(this.UC_NhanVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_nhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Grid_nhanvien;
        private System.Windows.Forms.DataGridViewButtonColumn CDelete;
    }
}
