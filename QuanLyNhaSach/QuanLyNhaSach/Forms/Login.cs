using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyNhaSach.DA;

namespace QuanLyNhaSach.Forms
{
    public partial class Login : Form
    {
        YesNo msb = new YesNo();
        
        public Login()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from NHANVIEN where Username='" + txtuser.Text + "' and Password='" + txtpassword.Text + "'";
            DataTable dta = DataProvider.Instance.ExecuteQuery(query);
            if (dta.Rows.Count > 0)
            {
                if (dta.Rows[0]["type"].ToString() == "nhanvien")
                {
                    msb.Messageshow("Đăng nhập thành công nhân viên");
                    Dashboard_NhanVien dn = new Dashboard_NhanVien();
                    dn.Show();
                    this.Hide();
                }
                else
                {
                    msb.Messageshow("Đăng nhập thành công admin");
                    Dashboard_Admin da = new Dashboard_Admin();
                    da.Show();
                    this.Hide();
                }
            }
            else
            {
                msb.Messageshow("Sai tài khoản hoặc mật khẩu!");
            }
        }

    }
}
