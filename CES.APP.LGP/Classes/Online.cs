using CES.APP.XGP.Interfaces;
using CES.MOD.CES.CES;
using CES.MOD.CES.Public;
using CES.MOD.CES.XGP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES.APP.XGP.Classes
{
    public class Online : IMetodos
    {
        public bool DeleteEntidade(MOD.CES.XGP.modENTIDADE pENT, ref PostReturn pReturn)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProduto(modPRODUTO pPRD, ref PostReturn pReturn)
        {
            throw new NotImplementedException();
        }

        public modBALANCA GetBalanca(string pBAL_Token)
        {
            return Api.Get<modBALANCA>(string.Format("XGP/GetBalanca?pBAL_Token={0}", pBAL_Token));
        }

        public modCLIENTE GetCliente(modCLIENTE pCLI)
        {
            throw new NotImplementedException();
        }

        public List<modMOVIMENTO> GetEntradasPendentes(int pCLI_Id)
        {
            return Api.Get<List<modMOVIMENTO>>(string.Format("XGP/GetEntradasPendentes?pCLI_Id={0}", pCLI_Id));
        }

        public List<MOD.CES.XGP.modENTIDADE> GetPessoaFisica(int pCLI_Id)
        {
            return Api.Get<List<MOD.CES.XGP.modENTIDADE>>(string.Format("XGP/GetEntidades?pCLI_Id={0}&pENT_Tipo=F", pCLI_Id));
        }

        public List<MOD.CES.XGP.modENTIDADE> GetPessoaJuridica(int pCLI_Id)
        {
            return Api.Get<List<MOD.CES.XGP.modENTIDADE>>(string.Format("XGP/GetEntidades?pCLI_Id={0}&pENT_Tipo=J", pCLI_Id));
        }

        public List<modPRODUTO> GetProduto(int pCLI_Id)
        {
            return Api.Get<List<modPRODUTO>>(string.Format("CES/GetProdutos?pCLI_Id={0}", pCLI_Id));
        }

        public List<modMOVIMENTO> GetSaidasTop100(int pCLI_Id)
        {
            return Api.Get<List<modMOVIMENTO>>(string.Format("XGP/GetSaidasTop100?pCLI_Id={0}", pCLI_Id));
        }

        public string GetTicket(int pCLI_Id, int pBAL_Id)
        {
            return Api.Get<string>(string.Format("XGP/GetTicket?pCLI_Id={0}&pBAL_Id={1}", pCLI_Id, pBAL_Id));
        }

        public modXGP GetXGP(string pBAL_Token)
        {
            return Api.Get<modXGP>(string.Format("XGP/GetXGP?pBAL_Token={0}", pBAL_Token));
        }

        public modBALANCA PostConfigInicial(modCLIENTE pCLI, modBALANCA pBAL, ref PostReturn pReturn)
        {
            throw new NotImplementedException();
        }

        public MOD.CES.XGP.modENTIDADE PostEntidade(MOD.CES.XGP.modENTIDADE pENT, ref PostReturn pReturn)
        {
            return Api.Post<MOD.CES.XGP.modENTIDADE>("XGP/PostEntidade", pENT, ref pReturn);
        }

        public modMOVIMENTO PostEntrada(modMOVIMENTO pMOV, ref PostReturn pReturn)
        {
            return Api.Post<modMOVIMENTO>("XGP/PostEntrada", pMOV, ref pReturn);
        }

        public modPRODUTO PostProduto(modPRODUTO pPRD, ref PostReturn pReturn)
        {
            return Api.Post<modPRODUTO>("XGP/PostProduto", pPRD, ref pReturn);
        }

        public modMOVIMENTO PostSaida(modMOVIMENTO pMOV, ref PostReturn pReturn)
        {
            return Api.Post<modMOVIMENTO>("XGP/PostSaida", pMOV, ref pReturn);
        }

        public void PostSync(MOD.CES.Public.modSync pSync, ref PostReturn pReturn)
        {
            Api.PostAsync("Sync", pSync, ref pReturn);
        }


    }
}
