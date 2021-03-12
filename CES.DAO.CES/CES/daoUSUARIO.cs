using CES.MOD.CES.CES;
using System.Collections.Generic;
using System.Data;

namespace CES.DAO.CES.CES
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 20.05.2018
    // Description: Classe gestão da tabela USUARIO.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class daoUSUARIO
    {
        public bool Inserir(modUSUARIO pUSUARIO)
        {
            string sProcedure = "ces.prI_USR";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pUSUARIO.CLI_Id);
            oParametros.Add("@USR_Id", pUSUARIO.USR_Id);
            oParametros.Add("@USR_Alias", pUSUARIO.USR_Alias);
            oParametros.Add("@USR_Nome", pUSUARIO.USR_Nome);
            oParametros.Add("@USR_Email", pUSUARIO.USR_Email);
            oParametros.Add("@USR_Senha", pUSUARIO.USR_Senha);
            oParametros.Add("@USR_Ativo", pUSUARIO.USR_Ativo);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }
        public bool Alterar(modUSUARIO pUSUARIO)
        {
            string sProcedure = "ces.prU_USR";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pUSUARIO.CLI_Id);
            oParametros.Add("@USR_Id", pUSUARIO.USR_Id);
            oParametros.Add("@USR_Alias", pUSUARIO.USR_Alias);
            oParametros.Add("@USR_Nome", pUSUARIO.USR_Nome);
            oParametros.Add("@USR_Email", pUSUARIO.USR_Email);
            oParametros.Add("@USR_Senha", pUSUARIO.USR_Senha);
            oParametros.Add("@USR_Ativo", pUSUARIO.USR_Ativo);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }
        public bool Excluir(modUSUARIO pUSUARIO)
        {
            string sProcedure = "ces.prD_USR";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pUSUARIO.CLI_Id);
            oParametros.Add("@USR_Id", pUSUARIO.USR_Id);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }
        public List<modUSUARIO> SelecionarTodos()
        {
            string sProcedure = "ces.prQ_USRs";
            List<modUSUARIO> lstUSUARIO = new List<modUSUARIO>();
            Conexao oConexao = new Conexao();
            DataTable dtUSUARIO = oConexao.Select(sProcedure).GetDataTable;

            if (dtUSUARIO != null)
            {
                foreach (DataRow oItem in dtUSUARIO.Rows)
                {
                    lstUSUARIO.Add(GetItem(oItem));
                }
            }
            return lstUSUARIO;
        }
        public List<modUSUARIO> Selecionar(modUSUARIO pUSUARIO)
        {
            string sProcedure = "ces.prQ_USR";
            List<modUSUARIO> lstUSUARIO = new List<modUSUARIO>();
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pUSUARIO.CLI_Id);
            oParametros.Add("@USR_Id", pUSUARIO.USR_Id);

            Conexao oConexao = new Conexao();
            DataTable dtUSUARIO = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtUSUARIO != null)
            {
                foreach (DataRow oItem in dtUSUARIO.Rows)
                {
                    lstUSUARIO.Add(GetItem(oItem));
                }
            }
            return lstUSUARIO;
        }
        private modUSUARIO GetItem(DataRow pItem)
        {
            modUSUARIO modUSUARIO = new modUSUARIO();
            modUSUARIO.CLI_Id = int.Parse(pItem["CLI_Id"].ToString());
            modUSUARIO.USR_Id = int.Parse(pItem["USR_Id"].ToString());
            modUSUARIO.USR_Alias = pItem["USR_Alias"].ToString();
            modUSUARIO.USR_Nome = pItem["USR_Nome"].ToString();
            modUSUARIO.USR_Email = pItem["USR_Email"].ToString();
            modUSUARIO.USR_Senha = pItem["USR_Senha"].ToString();
            modUSUARIO.USR_Ativo = int.Parse(pItem["USR_Ativo"].ToString());
            return modUSUARIO;
        }
    }
}
