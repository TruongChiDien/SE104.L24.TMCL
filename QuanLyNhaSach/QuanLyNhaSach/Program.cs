using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Forms.Login());
            //Application.Run(new Forms.Dashboard_Admin()) ;
            // Application.Run(new Forms.YesNo());
            //Application.Run(new Forms.Dashboard_Admin()) ;
            //Application.Run(new Forms.Dashboard_NhanVien());

        }
    }
}
