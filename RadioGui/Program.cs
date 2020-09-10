/// <summary>
/// Name: Kevin Davis
/// Project: Radio GUI
/// Class: CMPS 4143
/// Date: 08/30/2020
/// Description: A simple GUI Design of a Radio Interface taken from the C# text book.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioGui
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
