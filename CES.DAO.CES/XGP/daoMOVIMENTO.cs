using System;
using System.Collections.Generic;
using System.Data;
using CES.DAO.CES.CES;
using CES.MOD.CES.XGP;

namespace CES.DAO.CES.XGP
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 26.05.2018
    // Description: Classe gestão da tabela MOVIMENTO.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class daoMOVIMENTO
    {
        public modMOVIMENTO Inserir(modMOVIMENTO pMOVIMENTO)
        {
            string sProcedure = "xgp.prI_MOV";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pMOVIMENTO.CLI.CLI_Id);
            oParametros.Add("@MOV_Id", pMOVIMENTO.MOV_Id, ParameterDirection.Output);
            oParametros.Add("@BAL_Id", pMOVIMENTO.BAL.BAL_Id);
            oParametros.Add("@MOV_Ticket", pMOVIMENTO.MOV_Ticket);
            oParametros.Add("@MOV_Tipo", pMOVIMENTO.MOV_Tipo);
            oParametros.Add("@MOV_Placa", pMOVIMENTO.MOV_Placa);
            oParametros.Add("@MOV_NotaFiscal", pMOVIMENTO.MOV_NotaFiscal);
            oParametros.Add("@MOV_NotaFiscalPeso", pMOVIMENTO.MOV_NotaFiscalPeso);
            oParametros.Add("@MOV_Motorista", pMOVIMENTO.Motorista.ENT_Id);
            oParametros.Add("@MOV_Cliente", pMOVIMENTO.Cliente.ENT_Id);
            oParametros.Add("@MOV_Fornecedor", pMOVIMENTO.Fornecedor.ENT_Id);
            oParametros.Add("@MOV_Transportadora", pMOVIMENTO.Transportadora.ENT_Id);
            oParametros.Add("@PRD_Id", pMOVIMENTO.PRD.PRD_Id);
            oParametros.Add("@MOV_Observacao", pMOVIMENTO.MOV_Observacao);

            if (pMOVIMENTO.MOV_EntradaData.Year == 1)
                oParametros.Add("@MOV_EntradaData");
            else
                oParametros.Add("@MOV_EntradaData", pMOVIMENTO.MOV_EntradaData);

            oParametros.Add("@MOV_EntradaPeso", pMOVIMENTO.MOV_EntradaPeso);
            oParametros.Add("@MOV_EntradaUsuario", pMOVIMENTO.MOV_EntradaUsuario);

            if (pMOVIMENTO.MOV_SaidaData.Year == 1)
                oParametros.Add("@MOV_SaidaData");
            else
                oParametros.Add("@MOV_SaidaData", pMOVIMENTO.MOV_SaidaData);

            oParametros.Add("@MOV_SaidaPeso", pMOVIMENTO.MOV_SaidaPeso);
            oParametros.Add("@MOV_SaidaUsuario", pMOVIMENTO.MOV_SaidaUsuario);
            oParametros.Add("@MOV_CargaPeso", pMOVIMENTO.MOV_CargaPeso);
            oParametros.Add("@MOV_Impressao", pMOVIMENTO.MOV_Impressao);
            oParametros.Add("@MOV_Ativo", pMOVIMENTO.MOV_Ativo);
            oParametros.Add("@MOV_CancelJust", pMOVIMENTO.MOV_CancelJust);

            if (pMOVIMENTO.MOV_CancelData.Year == 1)
                oParametros.Add("@MOV_CancelData");
            else
                oParametros.Add("@MOV_CancelData", pMOVIMENTO.MOV_CancelData);


            if (pMOVIMENTO.MOV_Integrado.Year == 1)
                oParametros.Add("@MOV_Integrado");
            else
                oParametros.Add("@MOV_Integrado", pMOVIMENTO.MOV_Integrado);

            Conexao oConexao = new Conexao();

            bool bRetorno = oConexao.Execute(sProcedure, ref oParametros);

            pMOVIMENTO.MOV_Id = Convert.ToInt32(oParametros.Parametros[1].Value);

            return this.Selecionar(pMOVIMENTO)[0];

        }
        public bool Alterar(modMOVIMENTO pMOVIMENTO)
        {
            string sProcedure = "xgp.prU_MOV";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pMOVIMENTO.CLI.CLI_Id);
            oParametros.Add("@MOV_Id", pMOVIMENTO.MOV_Id);
            oParametros.Add("@BAL_Id", pMOVIMENTO.BAL.BAL_Id);
            oParametros.Add("@MOV_Ticket", pMOVIMENTO.MOV_Ticket);
            oParametros.Add("@MOV_Tipo", pMOVIMENTO.MOV_Tipo);
            oParametros.Add("@MOV_Placa", pMOVIMENTO.MOV_Placa);
            oParametros.Add("@MOV_NotaFiscal", pMOVIMENTO.MOV_NotaFiscal);
            oParametros.Add("@MOV_NotaFiscalPeso", pMOVIMENTO.MOV_NotaFiscalPeso);
            oParametros.Add("@MOV_Motorista", pMOVIMENTO.Motorista.ENT_Id);
            oParametros.Add("@MOV_Cliente", pMOVIMENTO.Cliente.ENT_Id);
            oParametros.Add("@MOV_Fornecedor", pMOVIMENTO.Fornecedor.ENT_Id);
            oParametros.Add("@MOV_Transportadora", pMOVIMENTO.Transportadora.ENT_Id);
            oParametros.Add("@PRD_Id", pMOVIMENTO.PRD.PRD_Id);
            oParametros.Add("@MOV_Observacao", pMOVIMENTO.MOV_Observacao);

            if (pMOVIMENTO.MOV_EntradaData.Year == 1)
                oParametros.Add("@MOV_EntradaData");
            else
                oParametros.Add("@MOV_EntradaData", pMOVIMENTO.MOV_EntradaData);

            oParametros.Add("@MOV_EntradaPeso", pMOVIMENTO.MOV_EntradaPeso);
            oParametros.Add("@MOV_EntradaUsuario", pMOVIMENTO.MOV_EntradaUsuario);

            if (pMOVIMENTO.MOV_SaidaData.Year == 1)
                oParametros.Add("@MOV_SaidaData");
            else
                oParametros.Add("@MOV_SaidaData", pMOVIMENTO.MOV_SaidaData);

            oParametros.Add("@MOV_SaidaPeso", pMOVIMENTO.MOV_SaidaPeso);
            oParametros.Add("@MOV_SaidaUsuario", pMOVIMENTO.MOV_SaidaUsuario);
            oParametros.Add("@MOV_CargaPeso", pMOVIMENTO.MOV_CargaPeso);
            oParametros.Add("@MOV_Impressao", pMOVIMENTO.MOV_Impressao);
            oParametros.Add("@MOV_Ativo", pMOVIMENTO.MOV_Ativo);
            oParametros.Add("@MOV_CancelJust", pMOVIMENTO.MOV_CancelJust);

            if (pMOVIMENTO.MOV_CancelData.Year == 1)
                oParametros.Add("@MOV_CancelData");
            else
                oParametros.Add("@MOV_CancelData", pMOVIMENTO.MOV_CancelData);


            if (pMOVIMENTO.MOV_Integrado.Year == 1)
                oParametros.Add("@MOV_Integrado");
            else
                oParametros.Add("@MOV_Integrado", pMOVIMENTO.MOV_Integrado);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }

        public bool Excluir(modMOVIMENTO pMOVIMENTO)
        {
            string sProcedure = "xgp.prD_MOV";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pMOVIMENTO.CLI.CLI_Id);
            oParametros.Add("@MOV_Id", pMOVIMENTO.MOV_Id);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }

        public List<modMOVIMENTO> SelecionarSaidasTop100(int pCLI_Id)
        {
            string sProcedure = "xgp.prQ_MOVs_Saidas_Top100";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pCLI_Id);

            List<modMOVIMENTO> lstMOVIMENTO = new List<modMOVIMENTO>();
            Conexao oConexao = new Conexao();
            DataTable dtMOVIMENTO = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtMOVIMENTO != null)
            {
                foreach (DataRow oItem in dtMOVIMENTO.Rows)
                {
                    lstMOVIMENTO.Add(GetItem(oItem));
                }
            }
            return lstMOVIMENTO;
        }

        public List<modMOVIMENTO> SelecionarEntradasPendentes(int pCLI_Id)
        {
            string sProcedure = "xgp.prQ_MOVs_EntradasPendentes";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pCLI_Id);

            List<modMOVIMENTO> lstMOVIMENTO = new List<modMOVIMENTO>();
            Conexao oConexao = new Conexao();
            DataTable dtMOVIMENTO = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtMOVIMENTO != null)
            {

                foreach (DataRow oItem in dtMOVIMENTO.Rows)
                {
                    lstMOVIMENTO.Add(GetItem(oItem));
                }
            }

            return lstMOVIMENTO;

        }

        public List<modMOVIMENTO> SelecionarTodos(int pCLI_Id)
        {
            string sProcedure = "xgp.prQ_MOVs";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pCLI_Id);

            List<modMOVIMENTO> lstMOVIMENTO = new List<modMOVIMENTO>();
            Conexao oConexao = new Conexao();
            DataTable dtMOVIMENTO = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtMOVIMENTO != null)
            {
                foreach (DataRow oItem in dtMOVIMENTO.Rows)
                {
                    lstMOVIMENTO.Add(GetItem(oItem));
                }
            }
            return lstMOVIMENTO;
        }

        public List<modMOVIMENTO> Selecionar(modMOVIMENTO pMOVIMENTO)
        {
            string sProcedure = "xgp.prQ_MOV";
            List<modMOVIMENTO> lstMOVIMENTO = new List<modMOVIMENTO>();
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pMOVIMENTO.CLI.CLI_Id);
            oParametros.Add("@MOV_Id", pMOVIMENTO.MOV_Id);

            Conexao oConexao = new Conexao();
            DataTable dtMOVIMENTO = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtMOVIMENTO != null)
            {
                foreach (DataRow oItem in dtMOVIMENTO.Rows)
                {
                    lstMOVIMENTO.Add(GetItem(oItem));
                }
            }
            return lstMOVIMENTO;
        }

        public bool Existe(modENTIDADE pENT)
        {
            string sProcedure = "xgp.prQ_MOV_Existe_ENT";
            List<modMOVIMENTO> lstMOVIMENTO = new List<modMOVIMENTO>();
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pENT.CLI_Id);
            oParametros.Add("@ENT_Id", pENT.ENT.ENT_Id);

            Conexao oConexao = new Conexao();
            DataTable dtMOVIMENTO = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtMOVIMENTO != null)
            {
                foreach (DataRow oItem in dtMOVIMENTO.Rows)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Existe(MOD.CES.CES.modPRODUTO pPRD)
        {
            string sProcedure = "xgp.prQ_MOV_Existe_PRD";
            List<modMOVIMENTO> lstMOVIMENTO = new List<modMOVIMENTO>();
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pPRD.CLI_Id);
            oParametros.Add("@PRD_Id", pPRD.PRD_Id);

            Conexao oConexao = new Conexao();
            DataTable dtMOVIMENTO = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtMOVIMENTO != null)
            {
                foreach (DataRow oItem in dtMOVIMENTO.Rows)
                {
                    return true;
                }
            }
            return false;
        }

        public string CriarTicket(int pCLI_Id, int pBAL_Id)
        {
            string sProcedure = "xgp.prQ_MOV_Ticket";

            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pCLI_Id);
            oParametros.Add("@BAL_Id", pBAL_Id);

            Conexao oConexao = new Conexao();
            DataTable dtTicket = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtTicket != null)
            {
                foreach (DataRow oItem in dtTicket.Rows)
                {
                    return oItem["MOV_Ticket"].ToString();
                }
            }
            return "";
        }

        private modMOVIMENTO GetItem(DataRow pItem)
        {            
                modMOVIMENTO modMOVIMENTO = new modMOVIMENTO();

                //Carrega objeto CLIENTE.
                daoCLIENTE daoCLI = new daoCLIENTE();
                modMOVIMENTO.CLI.CLI_Id = int.Parse(pItem["CLI_Id"].ToString());
                modMOVIMENTO.CLI = daoCLI.Selecionar(modMOVIMENTO.CLI)[0];
                daoCLI = null;

                modMOVIMENTO.MOV_Id = int.Parse(pItem["MOV_Id"].ToString());
                     
                //Carrega objeto BALANCA
                daoBALANCA daoBAL = new daoBALANCA();
                modMOVIMENTO.BAL.CLI_Id = modMOVIMENTO.CLI.CLI_Id;
                modMOVIMENTO.BAL.BAL_Id = int.Parse(pItem["BAL_Id"].ToString());
                modMOVIMENTO.BAL = daoBAL.Selecionar(modMOVIMENTO.BAL)[0];
                daoBAL = null;
                        
                modMOVIMENTO.MOV_Ticket = pItem["MOV_Ticket"].ToString();
                modMOVIMENTO.MOV_Tipo = pItem["MOV_Tipo"].ToString();
                modMOVIMENTO.MOV_Placa = pItem["MOV_Placa"].ToString();
                modMOVIMENTO.MOV_NotaFiscal = pItem["MOV_NotaFiscal"].ToString();
                modMOVIMENTO.MOV_NotaFiscalPeso = double.Parse(pItem["MOV_NotaFiscalPeso"].ToString());

                //Carrega objeto ENTIDADE
                CES.daoENTIDADE daoENT = new CES.daoENTIDADE();
                modMOVIMENTO.Motorista.ENT_Id = int.Parse(pItem["MOV_Motorista"].ToString());
                modMOVIMENTO.Motorista = daoENT.Selecionar(modMOVIMENTO.Motorista)[0];

                modMOVIMENTO.Cliente.ENT_Id = int.Parse(pItem["MOV_Cliente"].ToString());
                modMOVIMENTO.Cliente = daoENT.Selecionar(modMOVIMENTO.Cliente)[0];
                        
                modMOVIMENTO.Fornecedor.ENT_Id = int.Parse(pItem["MOV_Fornecedor"].ToString());
                modMOVIMENTO.Fornecedor = daoENT.Selecionar(modMOVIMENTO.Fornecedor)[0];

                modMOVIMENTO.Transportadora.ENT_Id = int.Parse(pItem["MOV_Transportadora"].ToString());
                modMOVIMENTO.Transportadora = daoENT.Selecionar(modMOVIMENTO.Transportadora)[0];
                        
                daoENT = null;

                //Carrega objeto PRODUTO
                daoPRODUTO daoPRD = new daoPRODUTO();
                modMOVIMENTO.PRD.CLI_Id = modMOVIMENTO.CLI.CLI_Id;
                modMOVIMENTO.PRD.PRD_Id = int.Parse(pItem["PRD_Id"].ToString());
                modMOVIMENTO.PRD = daoPRD.Selecionar(modMOVIMENTO.PRD)[0];
                daoPRD = null;

                modMOVIMENTO.MOV_Observacao = pItem["MOV_Observacao"].ToString();

                if (pItem["MOV_EntradaData"].ToString() != "")
                    modMOVIMENTO.MOV_EntradaData = DateTime.Parse(pItem["MOV_EntradaData"].ToString());

                modMOVIMENTO.MOV_EntradaPeso = double.Parse(pItem["MOV_EntradaPeso"].ToString());
                modMOVIMENTO.MOV_EntradaUsuario = int.Parse(pItem["MOV_EntradaUsuario"].ToString());

                if (pItem["MOV_SaidaData"].ToString() != "")
                    modMOVIMENTO.MOV_SaidaData = DateTime.Parse(pItem["MOV_SaidaData"].ToString());

                modMOVIMENTO.MOV_SaidaPeso = double.Parse(pItem["MOV_SaidaPeso"].ToString());
                modMOVIMENTO.MOV_SaidaUsuario = int.Parse(pItem["MOV_SaidaUsuario"].ToString());
                modMOVIMENTO.MOV_CargaPeso = double.Parse(pItem["MOV_CargaPeso"].ToString());
                modMOVIMENTO.MOV_Impressao = int.Parse(pItem["MOV_Impressao"].ToString());
                modMOVIMENTO.MOV_Ativo = int.Parse(pItem["MOV_Ativo"].ToString());
                modMOVIMENTO.MOV_CancelJust = pItem["MOV_CancelJust"].ToString();

                if (pItem["MOV_CancelData"].ToString() != "")
                    modMOVIMENTO.MOV_CancelData = DateTime.Parse(pItem["MOV_CancelData"].ToString());

                if (pItem["MOV_Integrado"].ToString() != "")
                    modMOVIMENTO.MOV_Integrado = DateTime.Parse(pItem["MOV_Integrado"].ToString());

                return modMOVIMENTO;
            
        }
    }
}
