using CES.MOD.CES.CES;
using CES.MOD.CES.XGP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CES.MOD.CES.Public
{
    public class modSync
    {      
        public string Maquina { get; set; }
        public modCLIENTE Cliente { get; set; }
        public List<CES.modENTIDADE> Entidades { get; set; }
        public List<modPRODUTO> Produtos { get; set; }
        public modBALANCA Balanca { get; set; }
        public List<modMOVIMENTO> Movimentos { get; set; }
    }
}
