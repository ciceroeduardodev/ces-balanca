using System;
using System.Collections.Generic;

namespace CES.MOD.CES.XGP
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 20.05.2018
    // Description: Classe modelo da tabela BALANCA.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class modBALANCA
    {

        public int CLI_Id { get; set; }
        public int BAL_Id { get; set; }
        public string BAL_Nome { get; set; }
        public string BAL_Token { get; set; }
        public string BAL_Ticket_To { get; set; }
        public string BAL_Ticket_Bcc { get; set; }
        public string BAL_Ticket_Bco { get; set; }
        public int BAL_Ativo { get; set; }


        public string[] BAL_Mail_To
        {
            get
            {
                return ConvertToArray(BAL_Ticket_To);
            }

        }

        public string[] BAL_Mail_Bcc
        {
            get
            {
                return ConvertToArray(BAL_Ticket_Bcc);
            }

        }

        public string[] BAL_Mail_Bco
        {
            get
            {
                return ConvertToArray(BAL_Ticket_Bco);
            }

        }

        private string[] ConvertToArray(string pValue)
        {
            string[] sMails = { };
            string[] sChars = { ";" };
            if (!string.IsNullOrEmpty(pValue))
                sMails = pValue.Split(sChars, StringSplitOptions.RemoveEmptyEntries);
            return sMails;
        }


    }

}

