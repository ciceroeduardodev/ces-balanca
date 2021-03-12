using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES.APP.XGP.Classes
{
    public static class Report
    {

        public static void Show(DataTable pData)
        {
            string sHTML = GetHtml(pData);
        }

        private static string GetHtml(DataTable pData)
        {
            string sHtmlHeader = "";

            foreach(DataColumn oItem in pData.Columns)
            {
                //sHtmlHeader += string.Format("";
            }

            return "";
        }

    }
}
