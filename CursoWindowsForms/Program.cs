using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    static class Program
    {
        /// <summary>331212
        /// Ponto de entrada principal para o aplicativo.
        /// </su23131mmary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Menu_Flutuante());
        }
    }
}
