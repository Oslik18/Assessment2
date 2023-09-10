using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            LoginFile fileLog = new LoginFile();
            fileLog.LoadFile("login.txt");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
