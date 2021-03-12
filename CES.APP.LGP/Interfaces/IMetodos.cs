using CES.MOD.CES.CES;
using CES.MOD.CES.Public;
using CES.MOD.CES.XGP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES.APP.XGP.Interfaces
{
    interface IMetodos
    {
        modXGP GetXGP(string pBAL_Token);

        List<modMOVIMENTO> GetEntradasPendentes(int pCLI_Id);

        List<modMOVIMENTO> GetSaidasTop100(int pCLI_Id);

        List<MOD.CES.CES.modPRODUTO> GetProduto(int pCLI_Id);

        List<MOD.CES.XGP.modENTIDADE> GetPessoaFisica(int pCLI_Id);

        List<MOD.CES.XGP.modENTIDADE> GetPessoaJuridica(int pCLI_Id);

        modBALANCA GetBalanca(string pBAL_Token);

        modCLIENTE GetCliente(modCLIENTE pCLI);

        string GetTicket(int pCLI_Id, int pBAL_Id);

        modMOVIMENTO PostEntrada(modMOVIMENTO pMOV, ref PostReturn pReturn);

        modMOVIMENTO PostSaida(modMOVIMENTO pMOV, ref PostReturn pReturn);

        modPRODUTO PostProduto(modPRODUTO pPRD, ref PostReturn pReturn);

        MOD.CES.XGP.modENTIDADE PostEntidade(MOD.CES.XGP.modENTIDADE pENT, ref PostReturn pReturn);

        modBALANCA PostConfigInicial(modCLIENTE pCLI, modBALANCA pBAL, ref PostReturn pReturn);

        bool DeleteProduto(modPRODUTO pPRD, ref PostReturn pReturn);

        bool DeleteEntidade(MOD.CES.XGP.modENTIDADE pENT, ref PostReturn pReturn);
    }
}
