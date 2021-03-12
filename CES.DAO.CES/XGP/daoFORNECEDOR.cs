using CES.MOD.CES.XGP;
using System;
using System.Collections.Generic;
using System.Data;

namespace CES.DAO.CES.XGP
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 21.05.2018
    // Description: Classe gestão da tabela FORNECEDOR.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class daoFORNECEDOR
    {
        public bool Inserir(modFORNECEDOR pFORNECEDOR)
        {
            string sProcedure = "dbo.prI_FOR";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pFORNECEDOR.CLI_Id);
            oParametros.Add("@ENT_Id", pFORNECEDOR.ENTIDADE.ENT_Id);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }

        public bool Excluir(modFORNECEDOR pFORNECEDOR)
        {
            string sProcedure = "xgp.prD_FOR";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pFORNECEDOR.CLI_Id);
            oParametros.Add("@ENT_Id", pFORNECEDOR.ENTIDADE.ENT_Id);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }

        public List<modFORNECEDOR> SelecionarTodos(int pCLI_Id)
        {
            string sProcedure = "xgp.prQ_FORs";
            List<modFORNECEDOR> lstFORNECEDOR = new List<modFORNECEDOR>();
            Conexao oConexao = new Conexao();
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pCLI_Id);
            DataTable dtFORNECEDOR = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtFORNECEDOR != null)
            {
                foreach (DataRow oItem in dtFORNECEDOR.Rows)
                {
                    lstFORNECEDOR.Add(GetItem(oItem));
                }
            }
            return lstFORNECEDOR;
        }
        public List<modFORNECEDOR> Selecionar(modFORNECEDOR pFORNECEDOR)
        {
            string sProcedure = "xgp.prQ_FOR";
            List<modFORNECEDOR> lstFORNECEDOR = new List<modFORNECEDOR>();
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pFORNECEDOR.CLI_Id);
            oParametros.Add("@ENT_Id", pFORNECEDOR.ENTIDADE.ENT_Id);

            Conexao oConexao = new Conexao();
            DataTable dtFORNECEDOR = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtFORNECEDOR != null)
            {
                foreach (DataRow oItem in dtFORNECEDOR.Rows)
                {
                    lstFORNECEDOR.Add(GetItem(oItem));
                }
            }
            return lstFORNECEDOR;
        }
        private modFORNECEDOR GetItem(DataRow pItem)
        {
            modFORNECEDOR modFORNECEDOR = new modFORNECEDOR();
            modFORNECEDOR.CLI_Id = int.Parse(pItem["CLI_Id"].ToString());

            CES.daoENTIDADE daoENT = new CES.daoENTIDADE();
            MOD.CES.CES.modENTIDADE modENT = new MOD.CES.CES.modENTIDADE();
            modENT.ENT_Id = Convert.ToInt32(pItem["ENT_Id"]);
            modFORNECEDOR.ENTIDADE = daoENT.Selecionar(modENT)[0];
            modFORNECEDOR.ENT_Id = modFORNECEDOR.ENTIDADE.ENT_Id;
            modFORNECEDOR.ENT_Nome = modFORNECEDOR.ENTIDADE.ENT_Nome;

            return modFORNECEDOR;
        }
    }
}
