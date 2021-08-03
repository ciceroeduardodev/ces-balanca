using CES.MOD.CES.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES.DAO.CES
{
    public class daoSync
    {

        public modSync Selecionar()
        {

            modSync oSync = new modSync();

            //Cliente
            CES.daoCLIENTE daoCLI = new CES.daoCLIENTE();
            oSync.Cliente = daoCLI.SelecionarTodos().First();

            //Entidade
            CES.daoENTIDADE daoENT = new CES.daoENTIDADE();
            oSync.Entidades = daoENT.SelecionarTodos();
            
            //Produto
            CES.daoPRODUTO daoPRD = new CES.daoPRODUTO();
            oSync.Produtos = daoPRD.SelecionarTodos(new MOD.CES.CES.modPRODUTO { CLI_Id = oSync.Cliente.CLI_Id });

            //Balança
            XGP.daoBALANCA daoBAL = new XGP.daoBALANCA();
            oSync.Balanca = daoBAL.SelecionarTodos().First();

            //Movimento
            XGP.daoMOVIMENTO daoMOV = new XGP.daoMOVIMENTO();
            oSync.Movimentos = daoMOV.SelecionarTodos(oSync.Cliente.CLI_Id);

            return oSync;

        }

        public bool Executar_Script(string pScript)
        {
            string sScript = pScript;            
            Conexao oConexao = new Conexao();
            oConexao.CommandType = System.Data.CommandType.Text;
            return oConexao.Execute(pScript);
        }

    }
}
