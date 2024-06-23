using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalGlicNow
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Global.LerAppConfig();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            //Abrir o formulário Login 
            Form login = new FrmLogin();
            Application.Run(login);

            //Abrir o formulário Cadastro
            Form cadastro = new FrmCadastro();
            if (login.Tag.ToString() == "Cadastro")
            {
                Application.Run(cadastro);
            }
            if (login.DialogResult == DialogResult.OK || cadastro.DialogResult == DialogResult.OK)
            {
                Application.Run(new FrmPrincipal());
            }


            /*
             Application.Run(new FrmPrincipal());
             */


        }
    }
}
