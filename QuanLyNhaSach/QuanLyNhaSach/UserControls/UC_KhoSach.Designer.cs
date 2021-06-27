
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxTimkiem = new System.Windows.Forms.TextBox();
            this.CbChude = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Grid_tb_books = new System.Windows.Forms.DataGridView();
            this.Deletebook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_tb_books)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.TxTimkiem);
            this.panel1.Controls.Add(this.CbChude);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 76);
            this.panel1.TabIndex = 0;
            // 
            // TxTimkiem
            // 
            this.TxTimkiem.AcceptsReturn = true;
            this.TxTimkiem.BackColor = System.Drawing.Color.White;
            this.TxTimkiem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxTimkiem.Location = new System.Drawing.Point(682, 25);
            this.TxTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.TxTimkiem.Name = "TxTimkiem";
            this.TxTimkiem.Size = new System.Drawing.Size(226, 30);
            this.TxTimkiem.TabIndex = 21;
            this.TxTimkiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CbChude
            // 
            this.CbChude.BackColor = System.Drawing.Color.White;
            this.CbChude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbChude.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbChude.FormattingEnabled = true;
            this.CbChude.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách",
            "Thể loại",
            "Tác giả"});
            this.CbChude.Location = new System.Drawing.Point(510, 25);
            this.CbChude.Margin = new System.Windows.Forms.Padding(2);
            this.CbChude.Name = "CbChude";
            this.CbChude.Size = new System.Drawing.Size(170, 31);
            this.CbChude.TabIndex = 3;
            this.CbChude.Text = "Chủ đề tìm kiếm";
            this.CbChude.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(401, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tìm kiếm:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Image = global::QuanLyNhaSach.Properties.Resources.Add_to_Collection_60px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 76);
            this.button1.TabIndex = 19;
            this.button1.Text = "Tạo phiếu nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Grid_tb_books
            // 
            this.Grid_tb_books.AllowUserToAddRows = false;
            this.Grid_tb_books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_tb_books.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_tb_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_tb_books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletebook});
            this.Grid_tb_books.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_tb_books.Location = new System.Drawing.Point(0, 76);
            this.Grid_tb_books.Margin = new System.Windows.Forms.Padding(2);
            this.Grid_tb_books.Name = "Grid_tb_books";
            this.Grid_tb_books.ReadOnly = true;
            this.Grid_tb_books.RowHeadersVisible = false;
            this.Grid_tb_books.RowHeadersWidth = 82;
            this.Grid_tb_books.RowTemplate.Height = 41;
            this.Grid_tb_books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_tb_books.Size = new System.Drawing.Size(1087, 498);
            this.Grid_tb_books.TabIndex = 1;
            this.Grid_tb_books.AllowUserToDeleteRowsChanged += new System.EventHandler(this.Grid_tb_books_AllowUserToDeleteRowsChanged);
            this.Grid_tb_books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Deletebook
            // 
            this.Deletebook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Deletebook.DefaultCellStyle = dataGridViewCellStyle1;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grid_tb_books);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_KhoSach";
            this.Size = new System.Drawing.Size(1087, 574);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_tb_books)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox TxTimkiem;
        private System.Windows.Forms.ComboBox CbChude;
        private System.Windows.Forms.DataGridView Grid_tb_books;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewButtonColumn Deletebook;
    }
}
