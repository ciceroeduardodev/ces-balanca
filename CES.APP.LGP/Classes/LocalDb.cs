using CES.APP.XGP.Interfaces;
using CES.DAO.CES.CES;
using CES.DAO.CES.XGP;
using CES.MOD.CES.CES;
using CES.MOD.CES.Public;
using CES.MOD.CES.XGP;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES.APP.XGP.Classes
{
    public class LocalDb : IMetodos
    {
        public bool DeleteEntidade(MOD.CES.XGP.modENTIDADE pENT, ref PostReturn pReturn)
        {

            daoMOVIMENTO daoMOV = new daoMOVIMENTO();
            if (daoMOV.Existe(pENT))
            {
                pReturn.Status = false;
                pReturn.Message = "Existem pesagens relacionadas a esse código, não possível excluir.";
                return false;
            }

            DAO.CES.XGP.daoENTIDADE daoENT = new DAO.CES.XGP.daoENTIDADE();
            return daoENT.Excluir(pENT);
        }

        public bool DeleteProduto(modPRODUTO pPRD, ref PostReturn pReturn)
        {
            daoMOVIMENTO daoMOV = new daoMOVIMENTO();
            if (daoMOV.Existe(pPRD))
            {
                pReturn.Status = false;
                pReturn.Message = "Existem pesagens relacionadas a esse código, não possível excluir.";
                return false;
            }

            daoPRODUTO daoPRD = new daoPRODUTO();
            return daoPRD.Excluir(pPRD);
        }

        public modBALANCA GetBalanca(string pBAL_Token)
        {
            daoBALANCA daoBAL = new daoBALANCA();
            modBALANCA modBAL = daoBAL.Selecionar(pBAL_Token);
            return modBAL;
        }

        public modCLIENTE GetCliente(modCLIENTE pCLI)
        {
            daoCLIENTE daoCLI = new daoCLIENTE();
            List<modCLIENTE> lslCLI = daoCLI.Selecionar(pCLI);

            if (lslCLI.Count > 0)
                return daoCLI.Selecionar(pCLI)[0];

            return new modCLIENTE();
        }

        public List<modMOVIMENTO> GetEntradasPendentes(int pCLI_Id)
        {

            MOD.CES.XGP.modMOVIMENTO modMOV = new MOD.CES.XGP.modMOVIMENTO();
            modMOV.CLI.CLI_Id = pCLI_Id;
            DAO.CES.XGP.daoMOVIMENTO daoMOV = new DAO.CES.XGP.daoMOVIMENTO();
            List<MOD.CES.XGP.modMOVIMENTO> lsMOV = daoMOV.SelecionarEntradasPendentes(pCLI_Id);
            return lsMOV;
        }

        public List<MOD.CES.XGP.modENTIDADE> GetPessoaFisica(int pCLI_Id)
        {
            MOD.CES.XGP.modENTIDADE modENT = new MOD.CES.XGP.modENTIDADE();
            modENT.CLI_Id = pCLI_Id;
            modENT.ENT.ENT_Tipo = "F";

            DAO.CES.XGP.daoENTIDADE daoENT = new DAO.CES.XGP.daoENTIDADE();
            List<MOD.CES.XGP.modENTIDADE> lsENT = daoENT.SelecionarTodos(modENT);
            return lsENT.OrderBy(x => x.ENT.ENT_Nome).ToList();
        }

        public List<MOD.CES.XGP.modENTIDADE> GetPessoaJuridica(int pCLI_Id)
        {
            MOD.CES.XGP.modENTIDADE modENT = new MOD.CES.XGP.modENTIDADE();
            modENT.CLI_Id = pCLI_Id;
            modENT.ENT.ENT_Tipo = "J";

            DAO.CES.XGP.daoENTIDADE daoENT = new DAO.CES.XGP.daoENTIDADE();
            List<MOD.CES.XGP.modENTIDADE> lsENT = daoENT.SelecionarTodos(modENT);
            return lsENT.OrderBy(x => x.ENT.ENT_Nome).ToList();
        }

        public List<modPRODUTO> GetProduto(int pCLI_Id)
        {
            daoPRODUTO daoPRO = new daoPRODUTO();
            List<modPRODUTO> lsPRO = daoPRO.SelecionarTodos(new modPRODUTO { CLI_Id = pCLI_Id });
            return lsPRO.OrderBy(x => x.PRD_Nome).ToList();
        }

        public List<modMOVIMENTO> GetSaidasTop100(int pCLI_Id)
        {
            MOD.CES.XGP.modMOVIMENTO modMOV = new MOD.CES.XGP.modMOVIMENTO();
            modMOV.CLI.CLI_Id = pCLI_Id;

            DAO.CES.XGP.daoMOVIMENTO daoMOV = new DAO.CES.XGP.daoMOVIMENTO();
            List<MOD.CES.XGP.modMOVIMENTO> lsMOV = daoMOV.SelecionarSaidasTop100(pCLI_Id);
            return lsMOV;
        }

        public string GetTicket(int pCLI_Id, int pBAL_Id)
        {
            DAO.CES.XGP.daoMOVIMENTO daoMOV = new DAO.CES.XGP.daoMOVIMENTO();
            return daoMOV.CriarTicket(pCLI_Id, pBAL_Id);
        }

        public modXGP GetXGP(string pBAL_Token)
        {
            daoBALANCA daoBAL = new daoBALANCA();
            modBALANCA modBAL = daoBAL.Selecionar(pBAL_Token);
            daoBAL = null;

            if (modBAL.BAL_Id == 0)
                throw new Exception("Token não encontrado.");

            modXGP modXGP = new modXGP();
            modXGP.BAL = modBAL;

            DAO.CES.XGP.daoENTIDADE daoENT;
            daoENT = new DAO.CES.XGP.daoENTIDADE();
            modXGP.Current.PFs = daoENT.SelecionarTodos(new MOD.CES.XGP.modENTIDADE { CLI_Id = modBAL.CLI_Id, ENT = new MOD.CES.CES.modENTIDADE { ENT_Tipo = "F" } });
            daoENT = null;

            daoENT = new DAO.CES.XGP.daoENTIDADE();
            modXGP.Current.PJs = daoENT.SelecionarTodos(new MOD.CES.XGP.modENTIDADE { CLI_Id = modBAL.CLI_Id, ENT = new MOD.CES.CES.modENTIDADE { ENT_Tipo = "J" } });
            daoENT = null;

            DAO.CES.CES.daoPRODUTO daoPRD = new DAO.CES.CES.daoPRODUTO();
            modXGP.Current.PRDs = daoPRD.SelecionarTodos(new MOD.CES.CES.modPRODUTO { CLI_Id = modBAL.CLI_Id });
            daoPRD = null;

            DAO.CES.XGP.daoMOVIMENTO daoMOV;
            daoMOV = new DAO.CES.XGP.daoMOVIMENTO();
            modXGP.Current.MOVs_EntradasPendentes = daoMOV.SelecionarEntradasPendentes(modBAL.CLI_Id);
            daoMOV = null;

            daoMOV = new DAO.CES.XGP.daoMOVIMENTO();
            modXGP.Current.MOVs_SaidasTop100 = daoMOV.SelecionarSaidasTop100(modBAL.CLI_Id);
            daoMOV = null;

            return modXGP;
        }

        public modBALANCA PostConfigInicial(modCLIENTE pCLI, modBALANCA pBAL, ref PostReturn pReturn)
        {

            daoCLIENTE daoCLI = new daoCLIENTE();

            List<modCLIENTE> lsCLI = daoCLI.Selecionar(pCLI);

            if (lsCLI.Count == 0 || lsCLI[0].CLI_Id == 0)
            {
                pCLI.CLI_Data = DateTime.Now;
                pCLI.CLI_Ativo = 1;
                pCLI = daoCLI.Inserir(pCLI);
            }
            else
            {
                pCLI.CLI_Data = lsCLI[0].CLI_Data;
                pCLI.CLI_Ativo = lsCLI[0].CLI_Ativo;
                daoCLI.Alterar(pCLI);
            }

            daoBALANCA daoBAL = new daoBALANCA();
            pBAL.CLI_Id = pCLI.CLI_Id;
            pBAL.BAL_Id = 1;
            List<modBALANCA> lsBAL = daoBAL.Selecionar(pBAL);

            if (lsBAL.Count == 0)
            {
                pBAL.CLI_Id = pCLI.CLI_Id;
                pBAL.BAL_Id = 1;
                pBAL = daoBAL.Inserir(pBAL);

                pReturn.Status = true;

                return pBAL;
            }
            else
            {
                pBAL.CLI_Id = lsBAL[0].CLI_Id;
                pBAL.BAL_Id = lsBAL[0].BAL_Id;
                daoBAL.Alterar(pBAL);

                pReturn.Status = true;

                return pBAL;
            }
        }

        public MOD.CES.XGP.modENTIDADE PostEntidade(MOD.CES.XGP.modENTIDADE pENT, ref PostReturn pReturn)
        {
            DAO.CES.XGP.daoENTIDADE daoENT = new DAO.CES.XGP.daoENTIDADE();

            MOD.CES.XGP.modENTIDADE modENT;

            if (!daoENT.Existe(pENT))
                modENT = daoENT.Inserir(pENT);
            else
            {
                modENT = daoENT.Selecionar(pENT);
                pENT.CLI_Id = modENT.CLI_Id;
                pENT.ENT.ENT_Id = modENT.ENT.ENT_Id;
                modENT = daoENT.Alterar(pENT);
            }

            pReturn.Status = true;

            return modENT;
        }

        public modMOVIMENTO PostEntrada(modMOVIMENTO pMOV, ref PostReturn pReturn)
        {
            daoMOVIMENTO daoMOV = new daoMOVIMENTO();
            pMOV.MOV_EntradaData = DateTime.Now;
            pMOV.MOV_Ativo = 1;
            modMOVIMENTO modMOV = daoMOV.Inserir(pMOV);

            pReturn.Status = true;

            return modMOV;
        }

        public modPRODUTO PostProduto(modPRODUTO pPRD, ref PostReturn pReturn)
        {
            daoPRODUTO daoPRD = new daoPRODUTO();

            modPRODUTO modPRD;
            if (pPRD.PRD_Id == 0)
                modPRD = daoPRD.Inserir(pPRD);
            else
                modPRD = daoPRD.Alterar(pPRD);

            pReturn.Status = true;

            return modPRD;
        }

        public modMOVIMENTO PostSaida(modMOVIMENTO pMOV, ref PostReturn pReturn)
        {
            daoMOVIMENTO daoMOV = new daoMOVIMENTO();
            pMOV.MOV_SaidaData = DateTime.Now;
            pMOV.MOV_Ativo = 1;
            if (daoMOV.Alterar(pMOV))
            {
                if (pMOV.MOV_Tipo.ToUpper() == "N")
                {
                    Mail.SendTicket(pMOV);
                }

                pReturn.Status = true;
                return pMOV;
            }
            else
            {
                pReturn.Status = false;
                throw new Exception("Ocorreu um erro no procedimento de saída.");
            }
        }

    }
}
