using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace AppAcademia
{
    internal static class Program
    {
        static string bancoPath = Path.Combine(Globais.caminhoBanco, Globais.nomeBanco);

        [STAThread]
        static void Main()
        {
            MessageBox.Show("Banco usado: " + Globais.caminhoBanco);
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar o programa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
