using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Catalogo
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmInicioSesion inicioSesion = new frmInicioSesion();
            if (inicioSesion.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmPrincipal());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
