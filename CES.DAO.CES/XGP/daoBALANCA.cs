using System;
using System.Collections.Generic;
using System.Data;
using CES.MOD.CES.XGP;

namespace CES.DAO.CES.XGP
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 20.05.2018
    // Description: Classe gestão da tabela BALANCA.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class daoBALANCA
    {
        public modBALANCA Inserir(modBALANCA pBALANCA)
        {
            string sProcedure = "xgp.prI_BAL";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pBALANCA.CLI_Id);
            oParametros.Add("@BAL_Id", pBALANCA.BAL_Id);
            oParametros.Add("@BAL_Nome", pBALANCA.BAL_Nome);
            oParametros.Add("@BAL_Token", pBALANCA.BAL_Token);
            oParametros.Add("@BAL_Ticket_To", pBALANCA.BAL_Ticket_To);
            oParametros.Add("@BAL_Ticket_Bcc", pBALANCA.BAL_Ticket_Bcc);
            oParametros.Add("@BAL_Ticket_Bco", pBALANCA.BAL_Ticket_Bco);
            oParametros.Add("@BAL_Ativo", pBALANCA.BAL_Ativo);

            Conexao oConexao = new Conexao();
            bool oRetorno = oConexao.Execute(sProcedure, ref oParametros);

            pBALANCA.BAL_Id = Convert.ToInt32(oParametros.Parametros[0].Value);
            return pBALANCA;
        }
        public bool Alterar(modBALANCA pBALANCA)
        {
            string sProcedure = "xgp.prU_BAL";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pBALANCA.CLI_Id);
            oParametros.Add("@BAL_Id", pBALANCA.BAL_Id);
            oParametros.Add("@BAL_Nome", pBALANCA.BAL_Nome);
            oParametros.Add("@BAL_Token", pBALANCA.BAL_Token);
            oParametros.Add("@BAL_Ticket_To", pBALANCA.BAL_Ticket_To);
            oParametros.Add("@BAL_Ticket_Bcc", pBALANCA.BAL_Ticket_Bcc);
            oParametros.Add("@BAL_Ticket_Bco", pBALANCA.BAL_Ticket_Bco);
            oParametros.Add("@BAL_Ativo", pBALANCA.BAL_Ativo);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }
        public bool Excluir(modBALANCA pBALANCA)
        {
            string sProcedure = "xgp.prD_BAL";
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pBALANCA.CLI_Id);
            oParametros.Add("@BAL_Id", pBALANCA.BAL_Id);

            Conexao oConexao = new Conexao();
            return oConexao.Execute(sProcedure, ref oParametros);
        }
        public List<modBALANCA> SelecionarTodos()
        {
            string sProcedure = "xgp.prQ_BALs";
            List<modBALANCA> lstBALANCA = new List<modBALANCA>();
            Conexao oConexao = new Conexao();
            DataTable dtBALANCA = oConexao.Select(sProcedure).GetDataTable;

            if (dtBALANCA != null)
            {
                foreach (DataRow oItem in dtBALANCA.Rows)
                {
                    lstBALANCA.Add(GetItem(oItem));
                }
            }
            return lstBALANCA;
        }
        public List<modBALANCA> Selecionar(modBALANCA pBALANCA)
        {
            string sProcedure = "xgp.prQ_BAL";
            List<modBALANCA> lstBALANCA = new List<modBALANCA>();
            Parametro oParametros = new Parametro();
            oParametros.Add("@CLI_Id", pBALANCA.CLI_Id);
            oParametros.Add("@BAL_Id", pBALANCA.BAL_Id);

            Conexao oConexao = new Conexao();
            DataTable dtBALANCA = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtBALANCA != null)
            {
                foreach (DataRow oItem in dtBALANCA.Rows)
                {
                    lstBALANCA.Add(GetItem(oItem));
                }
            }
            return lstBALANCA;
        }

        public modBALANCA Selecionar(String pBAL_Token)
        {
            string sProcedure = "xgp.prQ_BAL_Token";
            List<modBALANCA> lstBALANCA = new List<modBALANCA>();
            Parametro oParametros = new Parametro();            
            oParametros.Add("@BAL_Token", pBAL_Token);

            Conexao oConexao = new Conexao();
            DataTable dtBALANCA = oConexao.Select(sProcedure, ref oParametros).GetDataTable;

            if (dtBALANCA != null)
            {
                foreach (DataRow oItem in dtBALANCA.Rows)
                {
                    return GetItem(oItem);
                }
            }
            return new modBALANCA();
        }

        private modBALANCA GetItem(DataRow pItem)
        {
            modBALANCA modBALANCA = new modBALANCA();
            modBALANCA.CLI_Id = int.Parse(pItem["CLI_Id"].ToString());
            modBALANCA.BAL_Id = int.Parse(pItem["BAL_Id"].ToString());
            modBALANCA.BAL_Nome = pItem["BAL_Nome"].ToString();
            modBALANCA.BAL_Token = pItem["BAL_Token"].ToString();
            modBALANCA.BAL_Ticket_To = pItem["BAL_Ticket_To"].ToString();
            modBALANCA.BAL_Ticket_Bcc = pItem["BAL_Ticket_Bcc"].ToString();
            modBALANCA.BAL_Ticket_Bco = pItem["BAL_Ticket_Bco"].ToString();
            modBALANCA.BAL_Ativo = int.Parse(pItem["BAL_Ativo"].ToString());
            return modBALANCA;
        }
    }
}
