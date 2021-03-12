using CES.MOD.CES.CES;
using System;
using System.Collections.Generic;
using System.Data;

namespace CES.DAO.CES.CES
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 20.05.2018
    // Description: Classe gestão da tabela LOG.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class daoLOG
    {
        public bool Inserir(modLOG pLOG)
        {
            string sProcedure = "ces.prI_LOG";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pLOG.CLI_Id);
            oParametros.Add("@LOG_Id", pLOG.LOG_Id);
            oParametros.Add("@LOG_Tipo", pLOG.LOG_Tipo);
            oParametros.Add("@LOG_TextoBreve", pLOG.LOG_TextoBreve);
            oParametros.Add("@LOG_Texto", pLOG.LOG_Texto);
            oParametros.Add("@LOG_Data", pLOG.LOG_Data);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }
        public bool Alterar(modLOG pLOG)
        {
            string sProcedure = "ces.prU_LOG";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pLOG.CLI_Id);
            oParametros.Add("@LOG_Id", pLOG.LOG_Id);
            oParametros.Add("@LOG_Tipo", pLOG.LOG_Tipo);
            oParametros.Add("@LOG_TextoBreve", pLOG.LOG_TextoBreve);
            oParametros.Add("@LOG_Texto", pLOG.LOG_Texto);
            oParametros.Add("@LOG_Data", pLOG.LOG_Data);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }
        public bool Excluir(modLOG pLOG)
        {
            string sProcedure = "ces.prD_LOG";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pLOG.CLI_Id);
            oParametros.Add("@LOG_Id", pLOG.LOG_Id);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }
        public List<modLOG> SelecionarTodos()
        {
            string sProcedure = "ces.prQ_LOGs";
            List<modLOG> lstLOG = new List<modLOG>();
            Conexao oConexao = new Conexao();
            DataTable dtLOG = oConexao.Select(sProcedure).GetDataTable;

            if (dtLOG != null)
            {
                foreach (DataRow oItem in dtLOG.Rows)
                {
                    lstLOG.Add(GetItem(oItem));
                }
            }
            return lstLOG;
        }
        public List<modLOG> Selecionar(modLOG pLOG)
        {
            string sProcedure = "ces.prQ_LOG";
            List<modLOG> lstLOG = new List<modLOG>();
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pLOG.CLI_Id);
            oParametros.Add("@LOG_Id", pLOG.LOG_Id);

            Conexao oConexao = new Conexao();
            DataTable dtLOG = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtLOG != null)
            {
                foreach (DataRow oItem in dtLOG.Rows)
                {
                    lstLOG.Add(GetItem(oItem));
                }
            }
            return lstLOG;
        }
        private modLOG GetItem(DataRow pItem)
        {
            modLOG modLOG = new modLOG();
            modLOG.CLI_Id = int.Parse(pItem["CLI_Id"].ToString());
            modLOG.LOG_Id = int.Parse(pItem["LOG_Id"].ToString());
            modLOG.LOG_Tipo = pItem["LOG_Tipo"].ToString();
            modLOG.LOG_TextoBreve = pItem["LOG_TextoBreve"].ToString();
            modLOG.LOG_Texto = pItem["LOG_Texto"].ToString();
            modLOG.LOG_Data = DateTime.Parse(pItem["LOG_Data"].ToString());
            return modLOG;
        }
    }
}
