using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES.DAO.CES
{
  public class Dados
  {

    DataTable _Data;

    public DataSet GetDataSet
    {
      get
      {
        DataSet oDataSet = new DataSet();
        oDataSet.Tables.Add(_Data);
        return oDataSet;
      }
    }

    public string GetXML
    {
      get { return this.GetDataSet.GetXml(); }

    }

    public string GetXmlSchema
    {
      get { return this.GetDataSet.GetXmlSchema(); }

    }

    public DataTable GetDataTable
    {
      get { return _Data; }
    }

    public Dados(DataTable pData)
    {
      _Data = pData;
    }
  }
}
