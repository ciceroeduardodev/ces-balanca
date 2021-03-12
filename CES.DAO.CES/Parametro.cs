using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES.DAO.CES
{
    public class Parametro
    {
        private List<SqlParameter> _Parametros = new List<SqlParameter>();

        public List<SqlParameter> Parametros
        {
            get { return _Parametros; }
            set { _Parametros = value; }
        }

        public object GetValue(string pNome)
        {
            foreach (SqlParameter oItem in _Parametros)
            {
                if (oItem.ParameterName == pNome)
                {
                    return oItem.Value;
                }
            }
            return null;
        }

        public void Add(string pNome)
        {
            _Parametros.Add(new SqlParameter(pNome, System.DBNull.Value));
        }

        public void Add(string pNome, double pValue)
        {
            _Parametros.Add(new SqlParameter(pNome, pValue));
        }

        public void Add(string pNome, Int32 pValue)
        {
            _Parametros.Add(new SqlParameter(pNome, pValue));

        }

        public void Add(string pNome, bool pValue)
        {
            _Parametros.Add(new SqlParameter(pNome, pValue));
        }

        public void Add(string pNome, Int32 pValue, ParameterDirection pDirection)
        {
            SqlParameter oParametro = new SqlParameter(pNome, pValue);
            oParametro.Direction = pDirection;
            _Parametros.Add(oParametro);
        }

        public void Add(string pNome, string pValue)
        {
            if (pValue == null)
                this.Add(pNome);
            else
                _Parametros.Add(new SqlParameter(pNome, pValue));
        }

        public void Add(string pNome, DateTime pValue)
        {
            if (pValue == null)
                this.Add(pNome);
            else
                _Parametros.Add(new SqlParameter(pNome, pValue));
        }

    }
}
