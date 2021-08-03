using CES.APP.XGP.Classes;
using CES.APP.XGP.Interfaces;
using CES.MOD.CES.XGP;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES.APP.XGP
{
    static class Program
    {
        //public static modXGP _XGP { get; set; }
        public static modBALANCA _BAL { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                //System.Diagnostics.Debug.WriteLine(General.GetKey());

                //Mail.SendError( "Teste");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (!General.ValidarKey())
                {
                    General.MessageInformation("Solicite um chave válida para executar o aplicativo.");
                }
                else
                {

                    General.ExecuteScript();

                    Application.Run(new mdiPrincipal());
                }
            }
            catch (Exception pEx)
            {
                General.SetError(pEx, true);
            }
        }

    }
}
