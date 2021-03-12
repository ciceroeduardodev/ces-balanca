using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES.APP.XGP.Classes
{
    public static class Contantes
    {
        public const string C_NomeSistema = "XGP - Gestão de Pesagem";

        public static string C_SenhaAdmin = string.Format("protecnica_{0}", DateTime.Now.ToString("yyyyMMdd"));
    }
}
