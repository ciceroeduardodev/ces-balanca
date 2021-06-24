using System;
using System.Configuration;
using CES.MOD.CES.XGP;
using System.Windows.Forms;
using CES.APP.XGP.Interfaces;
using System.Management;
using System.IO;

namespace CES.APP.XGP.Classes
{
    class General
    {

        public static bool _LoadingCompleted { get; set; }

        #region"Métodos de mensagens"

        public static void MessageError(string pValue)
        {
            MessageBox.Show(pValue, Contantes.C_NomeSistema, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        public static void MessageInformation(string pValue)
        {
            MessageBox.Show(pValue, Contantes.C_NomeSistema, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        #endregion

        public static void SetError(Exception pEx, bool pShowMessage = false)
        {

            RecorderError(pEx);

            if (pShowMessage)
                MessageError(pEx.Message);
        }


        private static void RecorderError(Exception pEx, bool pShowMessage = false)
        {
            string sDir = "";

            sDir = @"LOG";
            CheckDirectory(sDir);

            sDir = string.Format(@"LOG\{0}", DateTime.Now.Year.ToString("yyyy"));
            CheckDirectory(sDir);

            sDir = string.Format(@"LOG\{0}\{1}", DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("MM"));
            CheckDirectory(sDir);

            sDir = string.Format(@"LOG\{0}\{1}\{2}", DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("MM"), DateTime.Now.ToString("dd"));
            CheckDirectory(sDir);

            string sFileName = string.Format(@"{0}\LOG-{1}.error", sDir, DateTime.Now.ToString("yyyyMMdd-hhmmss"));

            string sLogError = "";

            try
            {
                sLogError += string.Format("{0}Balança: {1}", System.Environment.NewLine, Program._BAL.BAL_Nome);
                sLogError += System.Environment.NewLine;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            sLogError += string.Format("{0}Data/Hora: {1}", System.Environment.NewLine, DateTime.Now.ToLongDateString());
            sLogError += System.Environment.NewLine;
            sLogError += string.Format("{0}Mensagem: {1}", System.Environment.NewLine, pEx.Message);
            sLogError += System.Environment.NewLine;
            sLogError += string.Format("{0}Trace: {1}", System.Environment.NewLine, pEx.StackTrace);
            sLogError += System.Environment.NewLine;
            sLogError += string.Format("{0}Error: {1}", System.Environment.NewLine, pEx.ToString());
            File.AppendAllText(sFileName, sLogError);

            Mail.SendError(sLogError);

        }

        private static void CheckDirectory(string pPath)
        {
            if (!Directory.Exists(pPath))
                Directory.CreateDirectory(pPath);
        }

        public static bool Ping()
        {
            string sRetorno;
            try
            {
                if (Convert.ToBoolean(ConfigurationManager.AppSettings["SIS_Local"]))
                    return false;

                sRetorno = Api.Get<string>("XGP/Ping");
                return true;
            }
            catch (Exception ex)
            {
                SetError(ex);
                return false;
            }

        }

        private static bool Print_Init()
        {
            if (MP2032.ConfiguraModeloImpressora(Convert.ToInt32(ConfigurationManager.AppSettings["PRINT_Model"])) == 0)
                return false;

            if (MP2032.IniciaPorta(ConfigurationManager.AppSettings["PRINT_Port"].ToString()) == 0)
                return false;

            MP2032.AjustaLarguraPapel(Convert.ToInt32(ConfigurationManager.AppSettings["PRINT_Width"]));

            return true;
        }

        private static void Print_Text(string pTextLeft, string pTextRight, bool pTitle = false)
        {
            int iDiff;
            string sText;
            iDiff = Convert.ToInt32(ConfigurationManager.AppSettings["PRINT_CharMax"]) - (pTextLeft.Length + pTextRight.Length);
            sText = string.Format("{0}{1}{2}", pTextLeft, new string(' ', iDiff), pTextRight);
            if (pTitle)
                MP2032.FormataTX(string.Format("{0}\r\n", sText), 2, 0, 0, 0, 1);
            else
                MP2032.FormataTX(string.Format("{0}\r\n", sText), 2, 0, 0, 0, 0);
        }

        private static void Print_Text(string pText, bool pTitle = false, bool pCenter = false)
        {

            int iDiff;
            int iCharLen;
            int iDefaultLen;
            string sText;

            if (pTitle)
                iDefaultLen = Convert.ToInt32(ConfigurationManager.AppSettings["PRINT_CharMax"]) / 2;
            else
                iDefaultLen = Convert.ToInt32(ConfigurationManager.AppSettings["PRINT_CharMax"]);

            if (pCenter)
            {
                iDiff = iDefaultLen - pText.Length;
                iCharLen = iDiff / 2;
                sText = string.Format("{0}{1}{2}", new string(' ', iCharLen), pText, new string(' ', iCharLen));
            }
            else
            {
                sText = pText;
            }

            if (pTitle)
                MP2032.FormataTX(string.Format("{0}\r\n", sText), 2, 0, 0, 1, 1);
            else
                MP2032.FormataTX(string.Format("{0}\r\n", sText), 2, 0, 0, 0, 0);

            
        }

        private static void Print_Line()
        {
            MP2032.FormataTX(string.Format("{0}\r\n", new string('_', Convert.ToInt32(ConfigurationManager.AppSettings["PRINT_CharMax"]))), 2, 0, 0, 0, 0);
        }

        private static void Print_NewLine()
        {
            string sNewLine = "\r\n";
            MP2032.ComandoTX(sNewLine, sNewLine.Length);
        }

        private static void Print_Cut()
        {
            MP2032.AcionaGuilhotina(0);
        }

        private static void Print_Close()
        {
            MP2032.AcionaGuilhotina(1);
            MP2032.FechaPorta();
        }

        public static bool Imprimir(modMOVIMENTO pMOV, int pQtdeVias, string pTitulo)
        {
            try
            {

                if (!Print_Init())
                {
                    General.MessageError("Impressora não está conectada para emissão do ticket.");
                    return false;
                }

                if (pMOV == null)
                {
                    return false;
                }
                pQtdeVias = 1;
                for (int i = 1; i <= pQtdeVias; i++)
                {
                    Print_Text(pTitulo.ToUpper().Trim(), true, true);
                    Print_NewLine();
                    Print_Text(pMOV.BAL.BAL_Nome, pCenter: true);
                    Print_Text(string.Format("Ticket Nr: {0}", pMOV.MOV_Ticket), DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                    Print_Text(string.Format("Produto: {0}", pMOV.PRD.PRD_Nome));
                    Print_Text(string.Format("Motorista: {0}", pMOV.Motorista.ENT_Nome));
                    Print_Text(string.Format("CPF: {0}", pMOV.Motorista.ENT_CPF_CNPJ_Text));
                    Print_Text(string.Format("Placa: {0}", pMOV.MOV_Placa));

                    Print_Text(string.Format("Cliente: {0}", pMOV.Cliente.ENT_Nome));
                    Print_Text(string.Format("Fornecedor: {0}", pMOV.Fornecedor.ENT_Nome));
                    Print_Text(string.Format("Transp.: {0}", pMOV.Transportadora.ENT_Nome));

                    if (pMOV.MOV_Observacao.Trim() != "")
                        Print_Text(string.Format("Obs.: {0}", pMOV.MOV_Observacao));

                    if (pMOV.MOV_Tipo.Trim() == "I")
                        Print_Text("Pesagem interna.");

                    Print_NewLine();

                    Print_Text("PESAGEM DE ENTRADA", "PESAGEM DE SAÍDA", true);
                    if (pMOV.MOV_SaidaPeso > 0)
                    {
                        //Print_Text("Modo: Automático", "Modo: Manual");
                        Print_Text(string.Format("Data: {0}", pMOV.MOV_EntradaData.ToString("dd/MM/yyyy")), string.Format("Data: {0}", pMOV.MOV_SaidaData.ToString("dd/MM/yyyy")));
                        Print_Text(string.Format("Hora: {0}", pMOV.MOV_EntradaData.ToString("HH:mm")), string.Format("Hora: {0}", pMOV.MOV_SaidaData.ToString("HH:mm")));
                        Print_Text(string.Format("Peso: {0} Kg", pMOV.MOV_EntradaPeso.ToString("N2")), string.Format("Peso: {0} Kg", pMOV.MOV_SaidaPeso.ToString("N2")));
                    }
                    else
                    {
                        //Print_Text("Modo: Automático");
                        Print_Text(string.Format("Data: {0}", pMOV.MOV_EntradaData.ToString("dd/MM/yyyy")));
                        Print_Text(string.Format("Hora: {0}", pMOV.MOV_EntradaData.ToString("HH:mm")));
                        Print_Text(string.Format("Peso: {0} Kg", pMOV.MOV_EntradaPeso.ToString("N2")), "");
                    }

                    Print_Text(string.Format("Líquido: {0} Kg", pMOV.MOV_CargaPeso.ToString("N2")), true, true);

                    Print_NewLine();
                    Print_Line();
                    Print_Text("Operador da Balança", pCenter: true);
                    Print_NewLine();
                    Print_Line();
                    Print_Text("Motorista", pCenter: true);
                    Print_NewLine();
                    Print_NewLine();
                    if (i == pQtdeVias)
                        Print_Close();
                    else
                        Print_Cut();
                }

                return true;

            }
            catch (Exception ex)
            {
                SetError(ex);
                General.MessageError("Impressora apresentou erro. Verifique falta de papel ou conexão.");
                return false;
            }

        }

        public static string FormatDate(DateTime pValue)
        {
            if (pValue.Year < 100)
                return "";
            else
                return pValue.ToString("dd/MM/yyyy");

        }

        public static void LoadingShow(string pText)
        {
            frmLoading oLoading = new frmLoading(pText);
            oLoading.Show();
        }

        public static void LoadingHide()
        {
            General._LoadingCompleted = true;
        }

        public static IMetodos GetActionInstance(bool pInternetConnection)
        {
            if (Convert.ToBoolean(ConfigurationManager.AppSettings["SIS_Local"]))
                return new LocalDb();

            if (pInternetConnection)
                return new Online();
            else
                return new Offline();

        }

        public static void Sincronizar(bool pInternetConnection)
        {

            if (!pInternetConnection)
                return;

            frmLoading oLoading = new frmLoading();
            oLoading.Mostrar();
            oLoading = null;


        }

        public static bool ValidarKey()
        {

            string sToken = ConfigurationManager.AppSettings["BAL_Token"].ToString();

            if (sToken == "60020936-F077-4C95-86FF-6C301F7A1325" ||
                sToken == "CAF26EE9-9385-440A-B746-1E657C1F7A43" ||
                sToken == "205D2790-3B7C-4051-B276-17E010D19B3C" ||
                sToken == "3CAA6BFA-7710-4776-A002-51A4C750C22F" ||
                sToken == "076D02CF-A741-45CB-9B72-2D969D384C4C")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetMotherBoardID()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Product, SerialNumber FROM Win32_BaseBoard");
            ManagementObjectCollection information = searcher.Get();

            foreach (ManagementObject obj in information)
            {
                foreach (PropertyData data in obj.Properties)
                {
                    if (data.Name.ToUpper().Trim() == "SERIALNUMBER")
                    {
                        return data.Value.ToString();
                    }
                }
            }

            searcher.Dispose();

            throw new Exception("Serial number da máquina não foi encontrado.");
        }

        public static string GetKey()
        {
            return Criptografia.Ecript(string.Format("{0}{1}{2}", Guid.NewGuid().ToString().Substring(0, 10), DateTime.Now.ToString("yyyyMMdd"), General.GetMotherBoardID()));
        }

        public static string Decript(byte[] pValue)
        {
            //byte[] data = Convert.FromBase64String(encodedString);
            //string decodedString = Encoding.UTF8.GetString(data);
            return "";
        }

        public static bool Autenticar()
        {
            frmLoginAdmin oLoginAdmin = new frmLoginAdmin();
            oLoginAdmin.ShowDialog();
            return oLoginAdmin.Autenticado;
        }

        public static void Trace(string pText)
        {
            StreamWriter oWr = new StreamWriter("LOG.TXT");
            oWr.WriteLine(pText);
            oWr.Close();
        }
    }
}
