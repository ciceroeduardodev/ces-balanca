using CES.DAO.CES;
using CES.MOD.CES.XGP;
using System;
using System.Collections.Generic;
using System.Data;

namespace CES.DAO.CES.XGP
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 21.05.2018
    // Description: Classe gestão da tabela MOTORISTA.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class daoMOTORISTA
    {
        public bool Inserir(modMOTORISTA pMOTORISTA)
        {
            string sProcedure = "dbo.prI_MOT";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pMOTORISTA.CLI_Id);
            oParametros.Add("@ENT_Id", pMOTORISTA.ENTIDADE.ENT_Id);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }

        public bool Excluir(modMOTORISTA pMOTORISTA)
        {
            string sProcedure = "xgp.prD_MOT";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pMOTORISTA.CLI_Id);
            oParametros.Add("@ENT_Id", pMOTORISTA.ENTIDADE.ENT_Id);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }

        public List<modMOTORISTA> SelecionarTodos(int pCLI_Id)
        {
            string sProcedure = "xgp.prQ_MOTs";
            List<modMOTORISTA> lstMOTORISTA = new List<modMOTORISTA>();
            Conexao oConexao = new Conexao();
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pCLI_Id);
            DataTable dtMOTORISTA = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtMOTORISTA != null)
            {
                foreach (DataRow oItem in dtMOTORISTA.Rows)
                {
                    lstMOTORISTA.Add(GetItem(oItem));
                }
            }
            return lstMOTORISTA;
        }
        public List<modMOTORISTA> Selecionar(modMOTORISTA pMOTORISTA)
        {
            string sProcedure = "xgp.prQ_MOT";
            List<modMOTORISTA> lstMOTORISTA = new List<modMOTORISTA>();
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pMOTORISTA.CLI_Id);
            oParametros.Add("@ENT_Id", pMOTORISTA.ENTIDADE.ENT_Id);

            Conexao oConexao = new Conexao();
            DataTable dtMOTORISTA = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtMOTORISTA != null)
            {
                foreach (DataRow oItem in dtMOTORISTA.Rows)
                {
                    lstMOTORISTA.Add(GetItem(oItem));
                }
            }
            return lstMOTORISTA;
        }
        private modMOTORISTA GetItem(DataRow pItem)
        {
            modMOTORISTA modMOTORISTA = new modMOTORISTA();
            modMOTORISTA.CLI_Id = int.Parse(pItem["CLI_Id"].ToString());

            CES.daoENTIDADE daoENT = new CES.daoENTIDADE();
            MOD.CES.CES.modENTIDADE modENT = new MOD.CES.CES.modENTIDADE();
            modENT.ENT_Id = Convert.ToInt32(pItem["ENT_Id"]);
            modMOTORISTA.ENTIDADE = daoENT.Selecionar(modENT)[0];
            
            return modMOTORISTA;
        }
    }
}
