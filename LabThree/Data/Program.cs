using System;
using System.Windows.Forms;

namespace LabThree
{
    public delegate void MyDelegate(string name, int ram, double cpuFreq, int cpuCount);
    public delegate void MyDelegateProcess(string name, string User, double CPU,
        double Mem, string Path, string Info, int Priority);
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
