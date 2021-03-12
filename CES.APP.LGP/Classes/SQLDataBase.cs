using CES.DAO.CES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES.APP.XGP.Classes
{
    public static class SQLDataBase
    {
        public static DataTable Selecionar(string pScript)
        {
            Conexao oCnn = new Conexao();
            oCnn.CommandType = CommandType.Text;
            return oCnn.Select(pScript).GetDataTable;
        }

        public static bool Executar(string pScript)
        {
            Conexao oCnn = new Conexao();
            oCnn.CommandType = CommandType.Text;
            return oCnn.Execute(pScript);
        }

    }
}
