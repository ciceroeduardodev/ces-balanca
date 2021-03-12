using CES.MOD.CES.CES;
using System;

namespace CES.MOD.CES.XGP
{
    // =============================================
    // Author: Cicero Silva
    // Create date: 26.05.2018
    // Description: Classe modelo da tabela MOVIMENTO.
    // Changes:
    // dd.MM.yyyy - Author - Describe the change:
    // ...
    // =============================================

    public class modMOVIMENTO
    {
        public modCLIENTE CLI = new modCLIENTE();
        public int MOV_Id { get; set; }
        public modBALANCA BAL = new modBALANCA();
        public string MOV_Ticket { get; set; }
        public string MOV_Tipo { get; set; }
        public string MOV_Placa { get; set; }
        public string MOV_NotaFiscal { get; set; }
        public double MOV_NotaFiscalPeso { get; set; }
        public CES.modENTIDADE Motorista = new CES.modENTIDADE();
        public CES.modENTIDADE Cliente = new CES.modENTIDADE();
        public CES.modENTIDADE Fornecedor = new CES.modENTIDADE();
        public CES.modENTIDADE Transportadora = new CES.modENTIDADE();
        public modPRODUTO PRD = new modPRODUTO();
        public string MOV_Observacao { get; set; }
        public DateTime MOV_EntradaData { get; set; }
        public double MOV_EntradaPeso { get; set; }
        public int MOV_EntradaUsuario { get; set; }
        public DateTime MOV_SaidaData { get; set; }
        public double MOV_SaidaPeso { get; set; }
        public int MOV_SaidaUsuario { get; set; }
        public double MOV_CargaPeso { get; set; }
        public int MOV_Impressao { get; set; }
        public int MOV_Ativo { get; set; }
        public string MOV_CancelJust { get; set; }
        public DateTime MOV_CancelData { get; set; }
        public DateTime MOV_Integrado { get; set; }

        public string MOV_Tipo_Descr
        {
            get
            {
                if (MOV_Tipo.Trim().ToUpper() == "I")
                    return "Interna";
                else if (MOV_Tipo.Trim().ToUpper() == "N")
                    return "Normal";
                else
                    return "";
            }
        }
    }
}
