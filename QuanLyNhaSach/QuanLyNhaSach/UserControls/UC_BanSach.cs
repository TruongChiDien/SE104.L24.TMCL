using QuanLyNhaSach.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyNhaSach.DA;
using DGVPrinterHelper;
namespace QuanLyNhaSach.UserControls
{
    public partial class UC_BanSach : UserControl
    {
        public UC_BanSach()
        {
            InitializeComponent();
            Grid_tb_loadData();

        }

        private void Grid_tb_loadData()
        {
            string query = "SELECT MaSach, TenSach,TheLoai,TacGia,DGBan FROM SACH";

            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void UC_BanSach_Load(object sender, EventArgs e)
        {
            Search_book();
        
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search_book();
            if (String.IsNullOrEmpty(txtSoluong.Text))
            {
                MessageBox.Show("Nhập số lượng sách", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //dataGridView1.Rows.Clear();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void containedButton5_Click(object sender, EventArgs e)
        {
            //using (HoanThanhDonHang htdh = new HoanThanhDonHang())
            //{
            //    htdh.ShowDialog();
            //}

            //FormTempForPrint Inhoadon = new FormTempForPrint();


            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Hoa Don";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PrintPreviewDataGridView(dataGridView2);


            //List<sach> lst = new List<sach>();
            //lst.Clear();

            //for( int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            //{
            //    lst.Add(new sach { Tensach = dataGridView2.Rows[0].Cells[1].Value.ToString(),
            //                        int.Parse(dataGridView2)
            //    });
            //}

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetFontAndColors()
        {
            dataGridView1.Font = new Font("Tahoma", 15);
            dataGridView1.ForeColor = Color.Blue;
            dataGridView1.BackColor = Color.Beige;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            txtTensach.Text = dataGridView1.Rows[e.RowIndex].Cells["TenSach"].FormattedValue.ToString();
            txtTacgia.Text = dataGridView1.Rows[e.RowIndex].Cells["TacGia"].FormattedValue.ToString();

        }

        int n = 0;
        private void containedButton6_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView2);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txtTensach.Text;
                newRow.Cells[2].Value = txtSoluong.Text;
                newRow.Cells[3].Value = txtGiatien.Text;

                dataGridView2.Rows.Add(newRow);
                n++;
                showTotal();
            }
            catch { }
            //dataGridView2.Rows.Add(newRow);
         
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            txtTensach.Text = dataGridView1.Rows[e.RowIndex].Cells["TenSach"].FormattedValue.ToString();
            txtTacgia.Text = dataGridView1.Rows[e.RowIndex].Cells["TacGia"].FormattedValue.ToString();
            txtTheloai.Text = dataGridView1.Rows[e.RowIndex].Cells["TheLoai"].FormattedValue.ToString();
            txtGiatien.Text = dataGridView1.Rows[e.RowIndex].Cells["DGBan"].FormattedValue.ToString();
            int total = Convert.ToInt32(txtSoluong.Text) * Convert.ToInt32(txtGiatien.Text);
            txtTongtien.Text = Convert.ToString(total);
        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void containedButton1_Click(object sender, EventArgs e)
        {

        }

        private void containedButton2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.RemoveAt(rowIndex);
        }

        private void containedButton3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Quantity_book()
        {

            if (txtSoluong.Text ==null)
            {
                MessageBox.Show("Nhập số lượng");
                return;
            }
        }
            private void Search_book()
        {

            string chude = "MaSach";
            switch (CbChude.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Chọn chủ dề!");
                    return;
                case 1:
                    chude = "TenSach";
                    
                    break;
                case 2:
                    chude = "TheLoai";
                   
                    break;
                case 3:
                    chude = "TacGia";
                    
                    break;
            }
            try
            {
                
                string query = "SELECT * FROM SACH WHERE + " + chude + " like '" + TxTimkiem.Text + "%'";

                dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception)
            {

            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoluong.Text == null)
            {
                MessageBox.Show("Nhập số lượng");
                return;
            }
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            

            // If you want, you can allow decimal (float) numbers

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView2.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridView2.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void txtTongcong_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            
        }
        void showTotal()
        {
            int total = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                total += Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value);
            }
            txtTongcong.Text = total.ToString();
        }
        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            
        }

        private void containedButton1_Click_1(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Hoa Don";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PrintPreviewDataGridView(dataGridView2);
        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }
    }

    public class sach
    {
        public string Tensach { get; set; }
        public int SL { get; set; }
        public int Giatien { get; set; }
    }
}
