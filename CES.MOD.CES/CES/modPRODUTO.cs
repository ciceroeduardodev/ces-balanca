using System;

namespace CES.MOD.CES.CES
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 20.05.2018
    // Description: Classe modelo da tabela PRODUTO.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class modPRODUTO
    {
        private int _CLI_Id;
        private int _PRD_Id;
        private string _PRD_Nome;
        private int _PRD_Ativo;

        public int CLI_Id
        {
            get { return _CLI_Id; }
            set { _CLI_Id = value; }
        }

        public int PRD_Id
        {
            get { return _PRD_Id; }
            set { _PRD_Id = value; }
        }

        public string PRD_Nome
        {
            get { return _PRD_Nome; }
            set { _PRD_Nome = value; }
        }

        public int PRD_Ativo
        {
            get { return _PRD_Ativo; }
            set { _PRD_Ativo = value; }
        }

    }
}
