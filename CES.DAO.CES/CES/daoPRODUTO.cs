using CES.MOD.CES.CES;
using System;
using System.Collections.Generic;
using System.Data;

namespace CES.DAO.CES.CES
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 20.05.2018
    // Description: Classe gestão da tabela PRODUTO.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class daoPRODUTO
    {
        public modPRODUTO Inserir(modPRODUTO pPRODUTO)
        {
            string sProcedure = "ces.prI_PRD";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pPRODUTO.CLI_Id);
            oParametros.Add("@PRD_Id", pPRODUTO.PRD_Id);
            oParametros.Add("@PRD_Nome", pPRODUTO.PRD_Nome);
            oParametros.Add("@PRD_Ativo", pPRODUTO.PRD_Ativo);

            Conexao oConexao = new Conexao();

            bool bRetorno = oConexao.Execute(sProcedure, ref oParametros);

            pPRODUTO.PRD_Id = Convert.ToInt32(oParametros.Parametros[0].Value);

            return pPRODUTO;
        }

        public modPRODUTO Alterar(modPRODUTO pPRODUTO)
        {
            string sProcedure = "ces.prU_PRD";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pPRODUTO.CLI_Id);
            oParametros.Add("@PRD_Id", pPRODUTO.PRD_Id);
            oParametros.Add("@PRD_Nome", pPRODUTO.PRD_Nome);
            oParametros.Add("@PRD_Ativo", pPRODUTO.PRD_Ativo);

            Conexao oConexao = new Conexao();

            bool bRetorno = oConexao.Execute(sProcedure, ref oParametros);

            pPRODUTO.PRD_Id = Convert.ToInt32(oParametros.Parametros[0].Value);

            return pPRODUTO;
        }

        public bool Excluir(modPRODUTO pPRODUTO)
        {
            string sProcedure = "ces.prD_PRD";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pPRODUTO.CLI_Id);
            oParametros.Add("@PRD_Id", pPRODUTO.PRD_Id);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }
        public List<modPRODUTO> SelecionarTodos(modPRODUTO pPRODUTO)
        {
            string sProcedure = "ces.prQ_PRDs";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pPRODUTO.CLI_Id);

            List<modPRODUTO> lstPRODUTO = new List<modPRODUTO>();
            Conexao oConexao = new Conexao();
            DataTable dtPRODUTO = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtPRODUTO != null)
            {
                foreach (DataRow oItem in dtPRODUTO.Rows)
                {
                    lstPRODUTO.Add(GetItem(oItem));
                }
            }
            return lstPRODUTO;
        }
        public List<modPRODUTO> Selecionar(modPRODUTO pPRODUTO)
        {
            string sProcedure = "ces.prQ_PRD";
            List<modPRODUTO> lstPRODUTO = new List<modPRODUTO>();
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pPRODUTO.CLI_Id);
            oParametros.Add("@PRD_Id", pPRODUTO.PRD_Id);

            Conexao oConexao = new Conexao();
            DataTable dtPRODUTO = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtPRODUTO != null)
            {
                foreach (DataRow oItem in dtPRODUTO.Rows)
                {
                    lstPRODUTO.Add(GetItem(oItem));
                }
            }
            return lstPRODUTO;
        }
        private modPRODUTO GetItem(DataRow pItem)
        {
            modPRODUTO modPRODUTO = new modPRODUTO();
            modPRODUTO.CLI_Id = int.Parse(pItem["CLI_Id"].ToString());
            modPRODUTO.PRD_Id = int.Parse(pItem["PRD_Id"].ToString());
            modPRODUTO.PRD_Nome = pItem["PRD_Nome"].ToString();
            modPRODUTO.PRD_Ativo = int.Parse(pItem["PRD_Ativo"].ToString());
            return modPRODUTO;
        }
    }
}
