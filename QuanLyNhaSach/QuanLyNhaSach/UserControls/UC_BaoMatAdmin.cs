using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyNhaSach.DA;
using QuanLyNhaSach.Forms;

namespace QuanLyNhaSach.UserControls
{
    public partial class UC_BaoMatAdmin : UserControl
    {
        YesNo msb = new YesNo();
        string query;
        public UC_BaoMatAdmin()
        {
            InitializeComponent();
        }

        private void UC_BaoMatAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {

            if (txbUsername.Text == "" || txbPassword.Text == "" || txbOldPass.Text == "" || txbXacNhan.Text == "")
            {
                msb.Messageshow("Vui lòng nhập đầy đủ thông tin!");
            }
            else if(Convert.ToInt32(DataProvider.Instance.ExecuteScalar("select count(*) from nhanvien where Username = '" + txbUsername.Text + "' and Password = '" + txbOldPass.Text + "'")) == 0)
            {
                msb.Messageshow("Sai tên đăng nhập hoặc mật khẩu!");
            }
            else
            {
                if (txbPassword.Text != txbXacNhan.Text)
                    msb.Messageshow("Xác thực mật khẩu mới không đúng!");
                else
                {
                    query = "update nhanvien set Password = '" + txbPassword.Text + "' where Username = '" + txbUsername.Text + "'";
                    int res = Convert.ToInt32(DataProvider.Instance.ExecuteNonQuery(query));
                    if (res == 1)
                        msb.Messageshow("Cập nhật mật khẩu thành công!");
                }
            }
        }
    }
}
