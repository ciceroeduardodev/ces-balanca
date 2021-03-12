using CES.MOD.CES.CES;

namespace CES.MOD.CES.XGP
{

    // =============================================
    // Author: Cicero Silva
    // Create date: 21.05.2018
    // Description: Classe modelo da tabela CLIENTE.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class modENTIDADE
    {        
        public int CLI_Id { get; set; }
        public CES.modENTIDADE ENT = new CES.modENTIDADE();
               
        public int Value
        {
            get { return ENT.ENT_Id; }            
        }        

        public string Text
        {
            get { return ENT.ENT_Nome; }            
        }


    }
}

