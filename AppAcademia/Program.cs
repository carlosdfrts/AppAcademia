using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace AppAcademia
{
    internal static class Program
    {
        static string bancoPath = Globais.caminhoBanco;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
