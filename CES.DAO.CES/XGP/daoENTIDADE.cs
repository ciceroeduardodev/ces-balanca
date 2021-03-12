using System;
using System.Collections.Generic;
using System.Data;
using CES.MOD.CES.XGP;


namespace CES.DAO.CES.XGP
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 27.05.2018
    // Description: Classe gestão da tabela ENTIDADE.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class daoENTIDADE
    {
        public modENTIDADE Inserir(modENTIDADE pENTIDADE)
        {            
            string sProcedure = "xgp.prI_ENT";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pENTIDADE.CLI_Id);
            oParametros.Add("@ENT_Id", pENTIDADE.ENT.ENT_Id);
            oParametros.Add("@ENT_Nome", pENTIDADE.ENT.ENT_Nome);
            oParametros.Add("@ENT_Tipo", pENTIDADE.ENT.ENT_Tipo);
            oParametros.Add("@ENT_CPF_CNPJ", pENTIDADE.ENT.ENT_CPF_CNPJ);
            oParametros.Add("@ENT_Email", pENTIDADE.ENT.ENT_Email);
            oParametros.Add("@ENT_Ativo", pENTIDADE.ENT.ENT_Ativo);

            Conexao oConexao = new Conexao();
            bool oRetorno = oConexao.Execute(sProcedure, ref oParametros);

            pENTIDADE.ENT.ENT_Id = Convert.ToInt32(oParametros.Parametros[0].Value);

            return pENTIDADE;
        }

        public modENTIDADE Alterar(modENTIDADE pENTIDADE)
        {
            string sProcedure = "ces.prU_ENT";
            Parametro oParametros = new Parametro();
            oParametros.Add("@ENT_Id", pENTIDADE.ENT.ENT_Id);
            oParametros.Add("@ENT_Nome", pENTIDADE.ENT.ENT_Nome);
            oParametros.Add("@ENT_Tipo", pENTIDADE.ENT.ENT_Tipo);
            oParametros.Add("@ENT_CPF_CNPJ", pENTIDADE.ENT.ENT_CPF_CNPJ);
            oParametros.Add("@ENT_Email", pENTIDADE.ENT.ENT_Email);
            oParametros.Add("@ENT_Ativo", pENTIDADE.ENT.ENT_Ativo);

            Conexao oConexao = new Conexao();
            bool oRetorno = oConexao.Execute(sProcedure, ref oParametros);

            pENTIDADE.ENT.ENT_Id = Convert.ToInt32(oParametros.Parametros[0].Value);

            return pENTIDADE;
        }

        public bool Excluir(modENTIDADE pENTIDADE)
        {
            string sProcedure = "xgp.prD_ENT";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pENTIDADE.CLI_Id);
            oParametros.Add("@ENT_Id", pENTIDADE.ENT.ENT_Id);
            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }

        public List<modENTIDADE> SelecionarTodos(modENTIDADE pENTIDADE)
        {

            string sProcedure = "xgp.prQ_ENTs";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pENTIDADE.CLI_Id);
            oParametros.Add("@ENT_Tipo", pENTIDADE.ENT.ENT_Tipo);

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
            string sProcedure = "xgp.prQ_ENT";
            List<modENTIDADE> lstENTIDADE = new List<modENTIDADE>();
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pENTIDADE.CLI_Id);
            oParametros.Add("@ENT_Id", pENTIDADE.ENT.ENT_Id);

            Conexao oConexao = new Conexao();
            DataTable dtENTIDADE = oConexao.Select(sProcedure,ref oParametros).GetDataTable;

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
            modENTIDADE.CLI_Id = int.Parse(pItem["CLI_Id"].ToString());
            modENTIDADE.ENT.ENT_Id = int.Parse(pItem["ENT_Id"].ToString());

            CES.daoENTIDADE daoENT = new CES.daoENTIDADE();
            modENTIDADE.ENT = daoENT.Selecionar(modENTIDADE.ENT)[0];                
            return modENTIDADE;
        }
    }
}
