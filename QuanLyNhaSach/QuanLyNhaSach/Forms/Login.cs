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
        #region Properties
        YesNo msb = new YesNo();
        #endregion


        #region Method
        private void DangNhap()
        {
            string query = "select * from NHANVIEN where Username='" + txtuser.Text + "' and Password='" + txtpassword.Text + "'";
            DataTable dta = DataProvider.Instance.ExecuteQuery(query);
            if (dta.Rows.Count > 0)
            {
                if (dta.Rows[0]["type"].ToString() == "nhanvien")
                {
                    msb.Messageshow("Đăng nhập thành công nhân viên");
                    Dashboard_NhanVien dn = new Dashboard_NhanVien();
                    this.Hide();
                    dn.ShowDialog();
                    this.Show();
                }
                else
                {
                    msb.Messageshow("Đăng nhập thành công admin");
                    Dashboard_Admin da = new Dashboard_Admin();
                    this.Hide();
                    da.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                msb.Messageshow("Sai tài khoản hoặc mật khẩu!");
            }
        }
        
        #endregion


        #region Event
        public Login()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DangNhap();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        
        #endregion

    }
}
