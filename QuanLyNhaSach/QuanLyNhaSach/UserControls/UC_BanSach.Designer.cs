
namespace QuanLyNhaSach.UserControls
{
    partial class UC_BanSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BanSach));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnXoa = new MaterialSurface.ContainedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThanhToan = new MaterialSurface.ContainedButton();
            this.txtTongcong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHuy = new MaterialSurface.ContainedButton();
            this.btnInHoaDon = new MaterialSurface.ContainedButton();
            this.prtDoc = new System.Drawing.Printing.PrintDocument();
            this.prtprvDoc = new System.Windows.Forms.PrintPreviewDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvSach = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSoluong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiatien = new System.Windows.Forms.TextBox();
            this.btnThem = new MaterialSurface.ContainedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.CbChude = new System.Windows.Forms.ComboBox();
            this.TxTimkiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.EffectType = MaterialSurface.ET.Custom;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnXoa.Icon = null;
            this.btnXoa.Location = new System.Drawing.Point(96, 28);
            this.btnXoa.MouseState = MaterialSurface.MouseState.OUT;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoa.Radius = 6;
            this.btnXoa.ShawdowDepth = 3;
            this.btnXoa.ShawdowOpacity = 50;
            this.btnXoa.Size = new System.Drawing.Size(335, 78);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa sản phẩm";
            this.btnXoa.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.dtgvHoaDon);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(1030, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 840);
            this.panel1.TabIndex = 16;
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.AllowUserToOrderColumns = true;
            this.dtgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSach,
            this.SL,
            this.GiaTien});
            this.dtgvHoaDon.GridColor = System.Drawing.Color.Gray;
            this.dtgvHoaDon.Location = new System.Drawing.Point(10, 2);
            this.dtgvHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvHoaDon.RowHeadersVisible = false;
            this.dtgvHoaDon.RowHeadersWidth = 82;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dtgvHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvHoaDon.RowTemplate.Height = 29;
            this.dtgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHoaDon.ShowRowErrors = false;
            this.dtgvHoaDon.Size = new System.Drawing.Size(523, 423);
            this.dtgvHoaDon.TabIndex = 52;
            this.dtgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHoaDon_CellContentClick);
            this.dtgvHoaDon.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHoaDon_CellDoubleClick);
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            // 
            // GiaTien
            // 
            this.GiaTien.HeaderText = "Giá Tiền";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Location = new System.Drawing.Point(10, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 143);
            this.panel2.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnThanhToan);
            this.panel4.Controls.Add(this.txtTongcong);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.btnHuy);
            this.panel4.Controls.Add(this.btnInHoaDon);
            this.panel4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(10, 597);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(523, 233);
            this.panel4.TabIndex = 17;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.EffectType = MaterialSurface.ET.Custom;
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThanhToan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnThanhToan.Icon = null;
            this.btnThanhToan.Location = new System.Drawing.Point(186, 137);
            this.btnThanhToan.MouseState = MaterialSurface.MouseState.OUT;
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThanhToan.Radius = 6;
            this.btnThanhToan.ShawdowDepth = 3;
            this.btnThanhToan.ShawdowOpacity = 50;
            this.btnThanhToan.Size = new System.Drawing.Size(200, 75);
            this.btnThanhToan.TabIndex = 31;
            this.btnThanhToan.Text = "Thanh toán và In hóa đơn";
            this.btnThanhToan.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTongcong
            // 
            this.txtTongcong.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTongcong.Enabled = false;
            this.txtTongcong.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTongcong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtTongcong.Location = new System.Drawing.Point(183, 40);
            this.txtTongcong.Name = "txtTongcong";
            this.txtTongcong.Size = new System.Drawing.Size(203, 42);
            this.txtTongcong.TabIndex = 30;
            this.txtTongcong.Text = "0";
            this.txtTongcong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(25, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tổng cộng:";
            // 
            // btnHuy
            // 
            this.btnHuy.EffectType = MaterialSurface.ET.Custom;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(412, 137);
            this.btnHuy.MouseState = MaterialSurface.MouseState.OUT;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnHuy.Radius = 6;
            this.btnHuy.ShawdowDepth = 3;
            this.btnHuy.ShawdowOpacity = 50;
            this.btnHuy.Size = new System.Drawing.Size(86, 75);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.EffectType = MaterialSurface.ET.Custom;
            this.btnInHoaDon.Enabled = false;
            this.btnInHoaDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInHoaDon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInHoaDon.Icon = null;
            this.btnInHoaDon.Location = new System.Drawing.Point(25, 137);
            this.btnInHoaDon.MouseState = MaterialSurface.MouseState.OUT;
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnInHoaDon.Radius = 6;
            this.btnInHoaDon.ShawdowDepth = 3;
            this.btnInHoaDon.ShawdowOpacity = 50;
            this.btnInHoaDon.Size = new System.Drawing.Size(137, 75);
            this.btnInHoaDon.TabIndex = 15;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // prtDoc
            // 
            this.prtDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDoc_PrintPage);
            // 
            // prtprvDoc
            // 
            this.prtprvDoc.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prtprvDoc.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prtprvDoc.ClientSize = new System.Drawing.Size(400, 300);
            this.prtprvDoc.Enabled = true;
            this.prtprvDoc.Icon = ((System.Drawing.Icon)(resources.GetObject("prtprvDoc.Icon")));
            this.prtprvDoc.Name = "prtprvDoc";
            this.prtprvDoc.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvSach);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtMaKH);
            this.panel3.Controls.Add(this.txtTongtien);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtTensach);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txbSoluong);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtGiatien);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.CbChude);
            this.panel3.Controls.Add(this.TxTimkiem);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1030, 840);
            this.panel3.TabIndex = 17;
            // 
            // dtgvSach
            // 
            this.dtgvSach.AllowUserToAddRows = false;
            this.dtgvSach.AllowUserToDeleteRows = false;
            this.dtgvSach.AllowUserToResizeRows = false;
            this.dtgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSach.BackgroundColor = System.Drawing.Color.White;
            this.dtgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSach.GridColor = System.Drawing.Color.Gray;
            this.dtgvSach.Location = new System.Drawing.Point(16, 361);
            this.dtgvSach.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvSach.Name = "dtgvSach";
            this.dtgvSach.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvSach.RowHeadersVisible = false;
            this.dtgvSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dtgvSach.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvSach.RowTemplate.Height = 29;
            this.dtgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSach.ShowRowErrors = false;
            this.dtgvSach.Size = new System.Drawing.Size(701, 469);
            this.dtgvSach.TabIndex = 51;
            this.dtgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSach_CellClick);
            this.dtgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSach_CellClick);
            this.dtgvSach.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSach_CellClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(711, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(297, 30);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(16, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 49;
            this.label8.Text = "Mã KH :";
            // 
            // txtMaKH
            // 
            this.txtMaKH.AccessibleName = "";
            this.txtMaKH.Location = new System.Drawing.Point(222, 139);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(272, 30);
            this.txtMaKH.TabIndex = 48;
            // 
            // txtTongtien
            // 
            this.txtTongtien.AccessibleName = "";
            this.txtTongtien.Enabled = false;
            this.txtTongtien.Location = new System.Drawing.Point(711, 309);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(297, 30);
            this.txtTongtien.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(16, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tên sách  :";
            // 
            // txtTensach
            // 
            this.txtTensach.AccessibleName = "";
            this.txtTensach.Enabled = false;
            this.txtTensach.Location = new System.Drawing.Point(222, 253);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.ReadOnly = true;
            this.txtTensach.Size = new System.Drawing.Size(272, 30);
            this.txtTensach.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(542, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Số lượng :";
            // 
            // txbSoluong
            // 
            this.txbSoluong.AccessibleName = "";
            this.txbSoluong.Location = new System.Drawing.Point(711, 250);
            this.txbSoluong.Name = "txbSoluong";
            this.txbSoluong.Size = new System.Drawing.Size(297, 30);
            this.txbSoluong.TabIndex = 39;
            this.txbSoluong.Text = "1";
            this.txbSoluong.TextChanged += new System.EventHandler(this.txbSoluong_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label10.Location = new System.Drawing.Point(542, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 24);
            this.label10.TabIndex = 38;
            this.label10.Text = "Tổng tiền sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(16, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Giá tiền :";
            // 
            // txtGiatien
            // 
            this.txtGiatien.AccessibleName = "";
            this.txtGiatien.BackColor = System.Drawing.SystemColors.Control;
            this.txtGiatien.Enabled = false;
            this.txtGiatien.Location = new System.Drawing.Point(222, 312);
            this.txtGiatien.Name = "txtGiatien";
            this.txtGiatien.Size = new System.Drawing.Size(272, 30);
            this.txtGiatien.TabIndex = 37;
            // 
            // btnThem
            // 
            this.btnThem.EffectType = MaterialSurface.ET.Custom;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnThem.Icon = null;
            this.btnThem.Location = new System.Drawing.Point(722, 361);
            this.btnThem.MouseState = MaterialSurface.MouseState.OUT;
            this.btnThem.Name = "btnThem";
            this.btnThem.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThem.Radius = 6;
            this.btnThem.ShawdowDepth = 3;
            this.btnThem.ShawdowOpacity = 50;
            this.btnThem.Size = new System.Drawing.Size(286, 80);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm vào danh sách";
            this.btnThem.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(420, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 36);
            this.label2.TabIndex = 35;
            this.label2.Text = "BÁN SÁCH";
            // 
            // CbChude
            // 
            this.CbChude.ForeColor = System.Drawing.Color.DimGray;
            this.CbChude.FormattingEnabled = true;
            this.CbChude.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách",
            "Thể loại ",
            "Tác giả"});
            this.CbChude.Location = new System.Drawing.Point(222, 188);
            this.CbChude.Name = "CbChude";
            this.CbChude.Size = new System.Drawing.Size(272, 31);
            this.CbChude.TabIndex = 34;
            this.CbChude.Text = "Chọn thể loại";
            this.CbChude.UseWaitCursor = true;
            // 
            // TxTimkiem
            // 
            this.TxTimkiem.AccessibleName = "";
            this.TxTimkiem.Location = new System.Drawing.Point(711, 189);
            this.TxTimkiem.Name = "TxTimkiem";
            this.TxTimkiem.Size = new System.Drawing.Size(297, 30);
            this.TxTimkiem.TabIndex = 33;
            this.TxTimkiem.TextChanged += new System.EventHandler(this.txbTimKiem_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(16, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tìm kiếm theo";
            // 
            // UC_BanSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UC_BanSach";
            this.Size = new System.Drawing.Size(1570, 840);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSurface.ContainedButton btnXoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private MaterialSurface.ContainedButton btnInHoaDon;
        private MaterialSurface.ContainedButton btnHuy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

        private System.Windows.Forms.TextBox txtTongcong;
        private MaterialSurface.ContainedButton btnThanhToan;
        private System.Drawing.Printing.PrintDocument prtDoc;
        private System.Windows.Forms.PrintPreviewDialog prtprvDoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSoluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiatien;
        private MaterialSurface.ContainedButton btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbChude;
        private System.Windows.Forms.TextBox TxTimkiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvSach;
        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.Label label10;
    }
}
