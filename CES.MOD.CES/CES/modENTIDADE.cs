using System;

namespace CES.MOD.CES.CES
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 20.05.2018
    // Description: Classe modelo da tabela ENTIDADE.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class modENTIDADE
    {
        private int _ENT_Id;
        private string _ENT_Nome;
        private string _ENT_Tipo;
        private string _ENT_CPF_CNPJ;
        private string _ENT_Email;
        private int _ENT_Ativo;

        public int ENT_Id
        {
            get { return _ENT_Id; }
            set { _ENT_Id = value; }
        }

        public string ENT_Nome
        {
            get { return _ENT_Nome; }
            set { _ENT_Nome = value; }
        }

        public string ENT_Tipo
        {
            get { return _ENT_Tipo; }
            set { _ENT_Tipo = value; }
        }

        public string ENT_CPF_CNPJ
        {
            get { return _ENT_CPF_CNPJ; }
            set { _ENT_CPF_CNPJ = value; }
        }

        public string ENT_Email
        {
            get { return _ENT_Email; }
            set { _ENT_Email = value; }
        }

        public int ENT_Ativo
        {
            get { return _ENT_Ativo; }
            set { _ENT_Ativo = value; }
        }

        public string ENT_CPF_CNPJ_Text
        {
            get
            {
                if(_ENT_CPF_CNPJ != null && _ENT_CPF_CNPJ.Length == 11)
                {
                    return string.Format("{0}.{1}.{2}-{3}", 
                        _ENT_CPF_CNPJ.Substring(0,3),
                        _ENT_CPF_CNPJ.Substring(3,3),
                        _ENT_CPF_CNPJ.Substring(6,3),
                        _ENT_CPF_CNPJ.Substring(9,2));
                }

                if (_ENT_CPF_CNPJ != null && _ENT_CPF_CNPJ.Length == 14)
                {
                    return string.Format("{0}.{1}/{2}-{3}",
                        _ENT_CPF_CNPJ.Substring(0, 2),
                        _ENT_CPF_CNPJ.Substring(2, 3),
                        _ENT_CPF_CNPJ.Substring(5, 4),
                        _ENT_CPF_CNPJ.Substring(9, 2));
                }

                return _ENT_CPF_CNPJ;

            }

        }


    }
}
