using CES.MOD.CES.CES;
using System.Collections.Generic;

namespace CES.MOD.CES.XGP
{
    public class modXGP
    {
        public modBALANCA BAL = new modBALANCA();
        public modXGP_Estrutura Current = new modXGP_Estrutura();
        public modXGP_Estrutura ToSync = new modXGP_Estrutura();       

    }

    public class modXGP_Estrutura
    {        
        public List<modENTIDADE> PFs = new List<modENTIDADE>();
        public List<modENTIDADE> PJs = new List<modENTIDADE>();
        public List<modPRODUTO> PRDs = new List<modPRODUTO>();
        public List<modMOVIMENTO> MOVs_EntradasPendentes = new List<modMOVIMENTO>();
        public List<modMOVIMENTO> MOVs_SaidasTop100 = new List<modMOVIMENTO>();
    }
}
