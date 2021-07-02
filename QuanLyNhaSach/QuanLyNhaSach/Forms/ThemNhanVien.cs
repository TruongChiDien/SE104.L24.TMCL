﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyNhaSach.DA;
namespace QuanLyNhaSach.Forms
{
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void containedButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool isTrueTxt()
        {
            bool isAlltrue = true;
            if (String.IsNullOrEmpty(TxTenNV.Text))
            {
                MessageBox.Show("Tên không được để trống!");
                isAlltrue = false;
            }
            else if (String.IsNullOrEmpty(TxSDT.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống!");
                isAlltrue = false;
            }
            else if (String.IsNullOrEmpty(TxEmail.Text))
            {
                MessageBox.Show("Email không được để trống!");
                isAlltrue = false;
            }
            else if (String.IsNullOrEmpty(TxDiachi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống!");
                isAlltrue = false;
            }
            else if (String.IsNullOrEmpty(TxUsername.Text))
            {
                MessageBox.Show("Username không được để trống!");
                isAlltrue = false;
            }
            else if (String.IsNullOrEmpty(TxPassword.Text))
            {
                MessageBox.Show("Password không được để trống!");
                isAlltrue = false;
            }
            else if (String.IsNullOrEmpty(CbType.Text))
            {
                MessageBox.Show("Type không được để trống!");
                isAlltrue = false;
            }

            return isAlltrue;
        }
        private void containedButton6_Click(object sender, EventArgs e)
        {
            if (!isTrueTxt())
                return;
            string query = @"select count(1) from NHANVIEN where Username = N'" + TxUsername.Text +"'";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            if (i == 0) 
            {
                query = string.Format("insert into NHANVIEN values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')"
                                , TxTenNV.Text, TxDiachi.Text, TxSDT.Text, TxEmail.Text, DtNgayvaolam.Value.ToString("yyyy-MM-dd"),
                                TxUsername.Text, TxPassword.Text, CbType.Text);
                DataProvider.Instance.ExecuteNonQuery(query);
                this.Dispose();
            }
            else
            {
                YesNo Noti = new YesNo();
                Noti.Messageshow("Tên đăng nhập đã tồn tại!");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxDiachi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
