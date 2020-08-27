using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocusPreventer
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length >= 2)
            {
                if((!args[1].Contains("class") && !args[1].Contains("title") && !args[1].Contains("both")) || args[1].Contains("both") && args.Length < 4)
                {
                    MessageBox.Show("FocusPreventer.exe /class (class)\nFocusPreventer.exe /title (title)\nFocusPreventer.exe /both (class) (title)", "FocusPreventer Command-line Arguments");
                    return;
                }
            }
            Application.Run(new FocusPreventer());
        }
    }
}
