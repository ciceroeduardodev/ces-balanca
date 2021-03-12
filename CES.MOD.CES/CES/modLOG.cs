using System;

namespace CES.MOD.CES.CES
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 20.05.2018
    // Description: Classe modelo da tabela LOG.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class modLOG
    {
        private int _CLI_Id;
        private int _LOG_Id;
        private string _LOG_Tipo;
        private string _LOG_TextoBreve;
        private string _LOG_Texto;
        private DateTime _LOG_Data;

        public int CLI_Id
        {
            get { return _CLI_Id; }
            set { _CLI_Id = value; }
        }

        public int LOG_Id
        {
            get { return _LOG_Id; }
            set { _LOG_Id = value; }
        }

        public string LOG_Tipo
        {
            get { return _LOG_Tipo; }
            set { _LOG_Tipo = value; }
        }

        public string LOG_TextoBreve
        {
            get { return _LOG_TextoBreve; }
            set { _LOG_TextoBreve = value; }
        }

        public string LOG_Texto
        {
            get { return _LOG_Texto; }
            set { _LOG_Texto = value; }
        }

        public DateTime LOG_Data
        {
            get { return _LOG_Data; }
            set { _LOG_Data = value; }
        }

    }
}
