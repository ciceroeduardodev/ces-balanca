using CES.MOD.CES.CES;
using System;
using System.Collections.Generic;
using System.Data;

namespace CES.DAO.CES.CES
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 20.05.2018
    // Description: Classe gestão da tabela ENTIDADE.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class daoENTIDADE
    {
        public modENTIDADE Inserir(modENTIDADE pENTIDADE)
        {
            string sProcedure = "ces.prI_ENT";
            Parametro oParametros = new Parametro();            
            oParametros.Add("@ENT_Id", pENTIDADE.ENT_Id);
            oParametros.Add("@ENT_Nome", pENTIDADE.ENT_Nome);
            oParametros.Add("@ENT_Tipo", pENTIDADE.ENT_Tipo);
            oParametros.Add("@ENT_CPF_CNPJ", pENTIDADE.ENT_CPF_CNPJ);
            oParametros.Add("@ENT_Email", pENTIDADE.ENT_Email);
            oParametros.Add("@ENT_Ativo", pENTIDADE.ENT_Ativo);

            Conexao oConexao = new Conexao();
            bool bRetorno = oConexao.Execute(sProcedure, ref oParametros);

            pENTIDADE.ENT_Id = Convert.ToInt32(oParametros.Parametros[0].Value);

            return pENTIDADE;
        }
        public bool Alterar(modENTIDADE pENTIDADE)
        {
            string sProcedure = "ces.prU_ENT";
            Parametro oParametros = new Parametro();
            oParametros.Add("@ENT_Id", pENTIDADE.ENT_Id);
            oParametros.Add("@ENT_Nome", pENTIDADE.ENT_Nome);
            oParametros.Add("@ENT_Tipo", pENTIDADE.ENT_Tipo);
            oParametros.Add("@ENT_CPF_CNPJ", pENTIDADE.ENT_CPF_CNPJ);
            oParametros.Add("@ENT_Email", pENTIDADE.ENT_Email);
            oParametros.Add("@ENT_Ativo", pENTIDADE.ENT_Ativo);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }
        public bool Excluir(modENTIDADE pENTIDADE)
        {
            string sProcedure = "ces.prD_ENT";
            Parametro oParametros = new Parametro();
            oParametros.Add("@ENT_Id", pENTIDADE.ENT_Id);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }
        public List<modENTIDADE> SelecionarTodos(modENTIDADE pENT)
        {
            string sProcedure = "ces.prQ_ENTs";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pENT.ENT_Id);
            oParametros.Add("@ENT_Tipo", pENT.ENT_Tipo);
            List<modENTIDADE> lstENTIDADE = new List<modENTIDADE>();
            Conexao oConexao = new Conexao();
            DataTable dtENTIDADE = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtENTIDADE != null)
            {
                foreach (DataRow oItem in dtENTIDADE.Rows)
                {
                    lstENTIDADE.Add(GetItem(oItem));
                }
            }
            return lstENTIDADE;
        }
        public List<modENTIDADE> Selecionar(modENTIDADE pENTIDADE)
        {
            string sProcedure = "ces.prQ_ENT";
            List<modENTIDADE> lstENTIDADE = new List<modENTIDADE>();
            Parametro oParametros = new Parametro();
            oParametros.Add("@ENT_Id", pENTIDADE.ENT_Id);

            Conexao oConexao = new Conexao();
            DataTable dtENTIDADE = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtENTIDADE != null)
            {
                foreach (DataRow oItem in dtENTIDADE.Rows)
                {
                    lstENTIDADE.Add(GetItem(oItem));
                }
            }
            return lstENTIDADE;
        }
        private modENTIDADE GetItem(DataRow pItem)
        {
            modENTIDADE modENTIDADE = new modENTIDADE();
            modENTIDADE.ENT_Id = int.Parse(pItem["ENT_Id"].ToString());
            modENTIDADE.ENT_Nome = pItem["ENT_Nome"].ToString();
            modENTIDADE.ENT_Tipo = pItem["ENT_Tipo"].ToString();
            modENTIDADE.ENT_CPF_CNPJ = pItem["ENT_CPF_CNPJ"].ToString();
            modENTIDADE.ENT_Email = pItem["ENT_Email"].ToString();
            modENTIDADE.ENT_Ativo = int.Parse(pItem["ENT_Ativo"].ToString());
            return modENTIDADE;
        }
    }
}
