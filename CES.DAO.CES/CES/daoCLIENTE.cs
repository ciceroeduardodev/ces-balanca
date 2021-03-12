using CES.MOD.CES.CES;
using System;
using System.Collections.Generic;
using System.Data;

namespace CES.DAO.CES.CES
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 20.05.2018
    // Description: Classe gestão da tabela CLIENTE.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class daoCLIENTE
    {
        public modCLIENTE Inserir(modCLIENTE pCLIENTE)
        {
            string sProcedure = "ces.prI_CLI";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pCLIENTE.CLI_Id);
            oParametros.Add("@CLI_Nome", pCLIENTE.CLI_Nome);
            oParametros.Add("@CLI_Token", pCLIENTE.CLI_Token);
            oParametros.Add("@CLI_Data", pCLIENTE.CLI_Data);
            oParametros.Add("@CLI_Ativo", pCLIENTE.CLI_Ativo);

            Conexao oConexao = new Conexao();
            bool oRetorno = oConexao.Execute(sProcedure, ref oParametros);
                        
            pCLIENTE.CLI_Id = Convert.ToInt32(oParametros.Parametros[0].Value);
            return pCLIENTE;
        }
        public bool Alterar(modCLIENTE pCLIENTE)
        {
            string sProcedure = "ces.prU_CLI";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pCLIENTE.CLI_Id);
            oParametros.Add("@CLI_Nome", pCLIENTE.CLI_Nome);
            oParametros.Add("@CLI_Token", pCLIENTE.CLI_Token);
            oParametros.Add("@CLI_Data", pCLIENTE.CLI_Data);
            oParametros.Add("@CLI_Ativo", pCLIENTE.CLI_Ativo);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }
        public bool Excluir(modCLIENTE pCLIENTE)
        {
            string sProcedure = "ces.prD_CLI";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pCLIENTE.CLI_Id);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }
        public List<modCLIENTE> SelecionarTodos()
        {
            string sProcedure = "ces.prQ_CLIs";
            List<modCLIENTE> lstCLIENTE = new List<modCLIENTE>();
            Conexao oConexao = new Conexao();
            DataTable dtCLIENTE = oConexao.Select(sProcedure).GetDataTable;

            if (dtCLIENTE != null)
            {
                foreach (DataRow oItem in dtCLIENTE.Rows)
                {
                    lstCLIENTE.Add(GetItem(oItem));
                }
            }
            return lstCLIENTE;
        }
        public List<modCLIENTE> Selecionar(modCLIENTE pCLIENTE)
        {
            string sProcedure = "ces.prQ_CLI";
            List<modCLIENTE> lstCLIENTE = new List<modCLIENTE>();
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pCLIENTE.CLI_Id);

            Conexao oConexao = new Conexao();
            DataTable dtCLIENTE = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtCLIENTE != null)
            {
                foreach (DataRow oItem in dtCLIENTE.Rows)
                {
                    lstCLIENTE.Add(GetItem(oItem));
                }
            }

            return lstCLIENTE;
        }
        private modCLIENTE GetItem(DataRow pItem)
        {
            modCLIENTE modCLIENTE = new modCLIENTE();
            modCLIENTE.CLI_Id = int.Parse(pItem["CLI_Id"].ToString());
            modCLIENTE.CLI_Nome = pItem["CLI_Nome"].ToString();
            modCLIENTE.CLI_Token = pItem["CLI_Token"].ToString();
            modCLIENTE.CLI_Data = DateTime.Parse(pItem["CLI_Data"].ToString());
            modCLIENTE.CLI_Ativo = int.Parse(pItem["CLI_Ativo"].ToString());
            return modCLIENTE;
        }
    }
}
