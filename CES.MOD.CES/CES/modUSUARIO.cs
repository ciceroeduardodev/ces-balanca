using System;

namespace CES.MOD.CES.CES
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 20.05.2018
    // Description: Classe modelo da tabela USUARIO.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class modUSUARIO
    {
        private int _CLI_Id;
        private int _USR_Id;
        private string _USR_Alias;
        private string _USR_Nome;
        private string _USR_Email;
        private string _USR_Senha;
        private int _USR_Ativo;

        public int CLI_Id
        {
            get { return _CLI_Id; }
            set { _CLI_Id = value; }
        }

        public int USR_Id
        {
            get { return _USR_Id; }
            set { _USR_Id = value; }
        }

        public string USR_Alias
        {
            get { return _USR_Alias; }
            set { _USR_Alias = value; }
        }

        public string USR_Nome
        {
            get { return _USR_Nome; }
            set { _USR_Nome = value; }
        }

        public string USR_Email
        {
            get { return _USR_Email; }
            set { _USR_Email = value; }
        }

        public string USR_Senha
        {
            get { return _USR_Senha; }
            set { _USR_Senha = value; }
        }

        public int USR_Ativo
        {
            get { return _USR_Ativo; }
            set { _USR_Ativo = value; }
        }

    }
}
