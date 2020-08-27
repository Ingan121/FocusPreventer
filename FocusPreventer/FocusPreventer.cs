using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocusPreventer
{
    public partial class FocusPreventer : Form
    {
        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_NOACTIVATE = 0x08000000;

        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindow(IntPtr hWnd);

        public static string GetWindowTitle(IntPtr hWnd)
        {
            var length = GetWindowTextLength(hWnd);
            var title = new StringBuilder(length);
            GetWindowText(hWnd, title, length);
            return title.ToString();
        }

        public void SetWindowUnfocusable(IntPtr hWnd)
        {
            if (IsWindow(hWnd))
            {
                SetWindowLong(hWnd, GWL_EXSTYLE, GetWindowLong(hWnd, GWL_EXSTYLE) | WS_EX_NOACTIVATE);
            }
            else
            {
                MessageBox.Show("Window Not Found", "404");
            }
        }

        public FocusPreventer()
        {
            InitializeComponent();
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length >= 3)
            {
                if (args[1].Contains("class"))
                {
                    IntPtr hWnd = new IntPtr(FindWindow(args[2], null));
                    SetWindowUnfocusable(hWnd);
                }
                else if (args[1].Contains("title"))
                {
                    IntPtr hWnd = new IntPtr(FindWindow(null, args[2]));
                    SetWindowUnfocusable(hWnd);
                }
                else if (args[1].Contains("both"))
                {
                    IntPtr hWnd = new IntPtr(FindWindow(args[2], args[3]));
                    SetWindowUnfocusable(hWnd);
                }
                Close();
            }
        }

        private void PreventFocusFromClassBtn_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = new IntPtr(FindWindow(textBox.Text, null));
            SetWindowUnfocusable(hWnd);
            //MessageBox.Show(GetWindowTitle(hWnd));
        }

        private void PreventFocusFromTitleBtn_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = new IntPtr(FindWindow(null, textBox2.Text));
            SetWindowUnfocusable(hWnd);
            //MessageBox.Show(GetWindowTitle(hWnd));
        }

        private void PreventFocusFromBothBtn_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = new IntPtr(FindWindow(textBox.Text, textBox2.Text));
            SetWindowUnfocusable(hWnd);
            //MessageBox.Show(GetWindowTitle(hWnd));
        }

        private void GitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://github.com/Ingan121/FocusPreventer");
    }
}