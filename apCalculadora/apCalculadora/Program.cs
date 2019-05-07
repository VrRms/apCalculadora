using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// NOMES: MATEUS DE PADUA VICENTE E VITOR RAMOS
/// RAs  : 18186 E 18171
/// </summary>

namespace apCalculadora
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCalculadora());
        }
    }
}
