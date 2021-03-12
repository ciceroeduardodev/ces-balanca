using System;

namespace CES.MOD.CES.CES
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 20.05.2018
    // Description: Classe modelo da tabela CLIENTE.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class modCLIENTE
    {
        private int _CLI_Id;
        private string _CLI_Nome;
        private string _CLI_Token;
        private DateTime _CLI_Data;
        private int _CLI_Ativo;

        public int CLI_Id
        {
            get { return _CLI_Id; }
            set { _CLI_Id = value; }
        }

        public string CLI_Nome
        {
            get { return _CLI_Nome; }
            set { _CLI_Nome = value; }
        }

        public string CLI_Token
        {
            get { return _CLI_Token; }
            set { _CLI_Token = value; }
        }

        public DateTime CLI_Data
        {
            get { return _CLI_Data; }
            set { _CLI_Data = value; }
        }

        public int CLI_Ativo
        {
            get { return _CLI_Ativo; }
            set { _CLI_Ativo = value; }
        }

    }
}
