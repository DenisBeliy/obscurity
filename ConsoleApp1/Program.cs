using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

using ConsoleApp1.logo;
namespace ConsoleApp1
{
    class Program
    {
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);


        static void Main(string[] args)
        {
            ConsoleFullScreen();
            Thread.Sleep(500); 
            Greetings.PrintLogotips();
            Console.ReadLine();
        }

        private static void ConsoleFullScreen()
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3);
        }
    }
}
