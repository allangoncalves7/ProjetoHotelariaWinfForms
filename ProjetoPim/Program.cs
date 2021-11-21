using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPim
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
            //Application.Run(new FormReserva()); 
            //Application.Run(new Funcionario());
            //Application.Run(new FormQuarto());
            //Application.Run(new Servico());
            //Application.Run(new Pagamento());
            Application.Run(new FormHospede());
        }
    }
}
