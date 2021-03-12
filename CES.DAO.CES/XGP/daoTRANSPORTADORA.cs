using CES.MOD.CES.XGP;
using System;
using System.Collections.Generic;
using System.Data;

namespace CES.DAO.CES.XGP
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 21.05.2018
    // Description: Classe gestão da tabela TRANSPORTADORA.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class daoTRANSPORTADORA
    {
        public bool Inserir(modTRANSPORTADORA pTRANSPORTADORA)
        {
            string sProcedure = "dbo.prI_TRA";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pTRANSPORTADORA.CLI_Id);
            oParametros.Add("@ENT_Id", pTRANSPORTADORA.ENTIDADE.ENT_Id);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }

        public bool Excluir(modTRANSPORTADORA pTRANSPORTADORA)
        {
            string sProcedure = "xgp.prD_TRA";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pTRANSPORTADORA.CLI_Id);
            oParametros.Add("@ENT_Id", pTRANSPORTADORA.ENTIDADE.ENT_Id);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }

        public List<modTRANSPORTADORA> SelecionarTodos(int pCLI_Id)
        {
            string sProcedure = "xgp.prQ_TRAs";
            List<modTRANSPORTADORA> lstTRANSPORTADORA = new List<modTRANSPORTADORA>();
            Conexao oConexao = new Conexao();
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pCLI_Id);
            DataTable dtTRANSPORTADORA = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtTRANSPORTADORA != null)
            {
                foreach (DataRow oItem in dtTRANSPORTADORA.Rows)
                {
                    lstTRANSPORTADORA.Add(GetItem(oItem));
                }
            }
            return lstTRANSPORTADORA;
        }
        public List<modTRANSPORTADORA> Selecionar(modTRANSPORTADORA pTRANSPORTADORA)
        {
            string sProcedure = "xgp.prQ_TRA";
            List<modTRANSPORTADORA> lstTRANSPORTADORA = new List<modTRANSPORTADORA>();
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pTRANSPORTADORA.CLI_Id);
            oParametros.Add("@ENT_Id", pTRANSPORTADORA.ENTIDADE.ENT_Id);

            Conexao oConexao = new Conexao();
            DataTable dtTRANSPORTADORA = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtTRANSPORTADORA != null)
            {
                foreach (DataRow oItem in dtTRANSPORTADORA.Rows)
                {
                    lstTRANSPORTADORA.Add(GetItem(oItem));
                }
            }
            return lstTRANSPORTADORA;
        }
        private modTRANSPORTADORA GetItem(DataRow pItem)
        {
            modTRANSPORTADORA modTRANSPORTADORA = new modTRANSPORTADORA();
            modTRANSPORTADORA.CLI_Id = int.Parse(pItem["CLI_Id"].ToString());

            CES.daoENTIDADE daoENT = new CES.daoENTIDADE();
            MOD.CES.CES.modENTIDADE modENT = new MOD.CES.CES.modENTIDADE();
            modENT.ENT_Id = Convert.ToInt32(pItem["ENT_Id"]);
            modTRANSPORTADORA.ENTIDADE = daoENT.Selecionar(modENT)[0];
            modTRANSPORTADORA.ENT_Id = modTRANSPORTADORA.ENTIDADE.ENT_Id;
            modTRANSPORTADORA.ENT_Nome = modTRANSPORTADORA.ENTIDADE.ENT_Nome;

            return modTRANSPORTADORA;
        }
    }
}
