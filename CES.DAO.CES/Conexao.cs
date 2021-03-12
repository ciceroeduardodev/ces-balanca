using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CES.DAO.CES
{
    public class Conexao
    {

        private SqlConnection _Connection;
        private SqlCommand _Command;
        private SqlTransaction _Transaction;
        private CommandType _CommandType = CommandType.StoredProcedure;

        public CommandType CommandType
        {
            set { _CommandType = value; }
        }

        private void Conecta(string pTexto)
        {
            Parametro oParametros = null;
            this.Conecta(pTexto, ref oParametros);
        }
        private void Conecta(string pTexto, ref Parametro pParametros)
        {
            _Connection = new SqlConnection();
            _Command = new SqlCommand();

            _Connection.ConnectionString = ConfigurationManager.ConnectionStrings["cnnCES"].ConnectionString;

            _Command.CommandType = _CommandType;
            _Command.CommandText = pTexto;
            _Command.Connection = _Connection;
            _Command.CommandTimeout = 400000;

            if (pParametros != null)
            {
                foreach (SqlParameter oItem in pParametros.Parametros)
                {
                    _Command.Parameters.Add(oItem);
                }
            }

            _Connection.Open();

        }

        private void Desconecta()
        {
            _Connection.Close();
            _Connection = new SqlConnection();
            _Command = new SqlCommand();
        }
        public bool Execute(string pProcedure)

        {

            this.Conecta(pProcedure);
            int iRows = _Command.ExecuteNonQuery();
            this.Desconecta();

            if (iRows == 0)
                return false;
            else
                return true;

        }

        public bool Execute(string pProcedure, ref Parametro pParametros)
        {
            this.Conecta(pProcedure, ref pParametros);
            int iRows = _Command.ExecuteNonQuery();
            this.Desconecta();
            return true;
        }

        public Dados Select(string pProcedure)
        {
            this.Conecta(pProcedure);
            SqlDataAdapter oDataAdapter = new SqlDataAdapter(_Command);
            DataTable oDataTable = new DataTable();
            oDataAdapter.Fill(oDataTable);
            this.Desconecta();
            return new Dados(oDataTable);
        }

        public Dados Select(string pProcedure, ref Parametro pParametros)
        {
            this.Conecta(pProcedure, ref pParametros);
            SqlDataAdapter oDataAdapter = new SqlDataAdapter(_Command);
            DataTable oDataTable = new DataTable();
            oDataAdapter.Fill(oDataTable);
            this.Desconecta();
            return new Dados(oDataTable);
        }

    }
}
