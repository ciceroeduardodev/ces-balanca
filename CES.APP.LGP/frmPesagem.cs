using CES.APP.XGP.Classes;
using CES.MOD.CES.Public;
using CES.MOD.CES.XGP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Linq;
using System.Configuration;
using CES.APP.XGP.Interfaces;

namespace CES.APP.XGP
{
    public partial class frmPesagem : Form
    {
        #region "Declaração de Variáveis"

        public enum Tipo { Entrada, Saida };
        const int _iZero = 0;
        private long _iCount = 0;
        private SerialPort _oSerialPort;
        private Tipo _Tipo;
        private modMOVIMENTO _MOV;
        private bool _InternetConnection;

        #endregion

        #region "Eventos"

        public frmPesagem(Tipo pTipo, bool pInternetConnection)
        {
            InitializeComponent();

            _Tipo = pTipo;
            _InternetConnection = pInternetConnection;
        }


        private void tmSerial_Tick(object sender, EventArgs e)
        {
            string sData = "";
            string sValue;
            double dValue;

            try
            {
                switch (ConfigurationManager.AppSettings["BAL_Type"].ToString().Trim().ToUpper())
                {
                    case "TOLEDO":
                        dValue = Convert_SerialData_Toledo(_oSerialPort.ReadExisting());
                        break;
                    case "JUNDIAI":
                        dValue = Convert_SerialData_Jundia(_oSerialPort.ReadExisting());
                        break;
                    default:
                        dValue = 0;
                        break;
                }

                sValue = dValue.ToString("N2");

                if (sValue == txtLeitora.Text && dValue > 100)
                {
                    _iCount += 1;
                }
                else
                {
                    txtLeitora.Text = sValue;
                }

                if (_iCount >= 5)
                {
                    tmSerial.Enabled = false;
                    txtLeitora.ForeColor = Color.Lime;
                    if (_Tipo == Tipo.Entrada)
                        txtMOV_EntradaPeso.Text = txtLeitora.Text;
                    else
                    {
                        txtMOV_SaidaPeso.Text = txtLeitora.Text;
                        txtMOV_CargaPeso.Text = Math.Abs((Convert.ToDouble(txtMOV_EntradaPeso.Text) - Convert.ToDouble(txtMOV_SaidaPeso.Text))).ToString("N2");
                    }
                }
            }
            catch (Exception pEx)
            {
                tmSerial.Enabled = false;
                General.SetError(new Exception(string.Format("Mensagem em processamento {0}.", sData), pEx), true);
            }
        }

        private void frmPesagem_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmSerial.Enabled = false;

            if (_oSerialPort.IsOpen)
                _oSerialPort.Close();
        }

        private void optAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            Selecionar_Tipo();
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            tmSerial.Enabled = false;
            this.Close();
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            PostReturn oRetorno;

            if (txtNrTicket.Text.Trim() == "")
            {
                General.MessageInformation("O número do ticket deve ser gerado para excução da pesagem.");
                return;
            }

            if (txtMOV_NotaFiscal.Text.Trim() != "" && txtMOV_NotaFiscalPeso.Text.Trim() == "")
            {
                General.MessageInformation("Deve ser informado o pesa da nota fiscal informada.");
                return;
            }

            if (cboMOV_Motorista.SelectedIndex == -1)
            {
                General.MessageInformation("Informe o motorista.");
                return;
            }

            if (mskMOV_Placa_01.Text.Replace("-", "").Trim() == "")
            {
                General.MessageInformation("Informe a placa(as) do veículo.");
                return;
            }

            if (cboMOV_Cliente.SelectedIndex == -1)
            {
                General.MessageInformation("Informe o cliente.");
                return;
            }

            if (cboMOV_Fornecedor.SelectedIndex == -1)
            {
                General.MessageInformation("Informe o fornecedor.");
                return;
            }

            if (cboMOV_Transportadora.SelectedIndex == -1)
            {
                General.MessageInformation("Informe a transportadora.");
                return;
            }

            if (cboPRD_Nome.SelectedIndex == -1)
            {
                General.MessageInformation("Informe o Produto.");
                return;
            }

            modMOVIMENTO modMOV = new modMOVIMENTO();

            if (_Tipo == Tipo.Saida)
                modMOV = this._MOV;

            modMOV.CLI.CLI_Id = Program._BAL.CLI_Id;
            modMOV.BAL.BAL_Id = Program._BAL.BAL_Id;
            modMOV.MOV_Ticket = txtNrTicket.Text.Trim();

            if (chkPesagemInterna.Checked)
                modMOV.MOV_Tipo = "I";
            else
                modMOV.MOV_Tipo = "N";

            modMOV.MOV_NotaFiscal = txtMOV_NotaFiscal.Text.Trim();

            if (txtMOV_NotaFiscalPeso.Text.Trim() != "")
                modMOV.MOV_NotaFiscalPeso = Convert.ToDouble(txtMOV_NotaFiscalPeso.Text.Trim());

            modMOV.Motorista.ENT_Id = Convert.ToInt32(cboMOV_Motorista.SelectedValue);

            modMOV.MOV_Placa = mskMOV_Placa_01.Text.Trim().ToUpper();

            if (mskMOV_Placa_02.Text.Replace("-", "").Trim() != "")
                modMOV.MOV_Placa += string.Format("/{0}", mskMOV_Placa_02.Text.Trim().ToUpper());

            if (mskMOV_Placa_03.Text.Replace("-", "").Trim() != "")
                modMOV.MOV_Placa += string.Format("/{0}", mskMOV_Placa_03.Text.Trim().ToUpper());

            modMOV.Cliente.ENT_Id = Convert.ToInt32(cboMOV_Cliente.SelectedValue);
            modMOV.Fornecedor.ENT_Id = Convert.ToInt32(cboMOV_Fornecedor.SelectedValue);
            modMOV.Transportadora.ENT_Id = Convert.ToInt32(cboMOV_Transportadora.SelectedValue);

            modMOV.PRD.PRD_Id = Convert.ToInt32(cboPRD_Nome.SelectedValue);
            modMOV.MOV_Observacao = txtMOV_Observacao.Text.Trim().ToUpper();

            if (_Tipo == Tipo.Entrada)
            {
                modMOV.MOV_EntradaPeso = Convert.ToDouble(txtMOV_EntradaPeso.Text.Trim());
                modMOV.MOV_EntradaData = DateTime.Now;

                oRetorno = new PostReturn();
                IMetodos oAction = General.GetActionInstance(_InternetConnection);
                oAction.PostEntrada(modMOV, ref oRetorno);

            }
            else if (_Tipo == Tipo.Saida)
            {
                modMOV.MOV_SaidaPeso = Convert.ToDouble(txtMOV_SaidaPeso.Text.Trim());
                modMOV.MOV_SaidaData = DateTime.Now;
                modMOV.MOV_CargaPeso = Convert.ToDouble(txtMOV_CargaPeso.Text.Trim());

                oRetorno = new PostReturn();
                IMetodos oAction = General.GetActionInstance(_InternetConnection);
                oAction.PostSaida(modMOV, ref oRetorno);
                General.Imprimir(modMOV, 2, lblTitulo.Text);
            }
            else
            {
                oRetorno = new PostReturn();
            }

            if (oRetorno.Status)
            {
                General.MessageInformation("Operação realizada com sucesso!");
                this.Close();
            }
            else
            {
                General.MessageError(oRetorno.Message);
            }

        }

        private void txtMOV_NotaFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMOV_NotaFiscalPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtLeitora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtLeitora_TextChanged(object sender, EventArgs e)
        {
            double dLeitura;


            try
            {
                if (_Tipo == Tipo.Entrada)
                {
                    if (txtLeitora.Text.Trim() == "")
                        txtMOV_EntradaPeso.Text = _iZero.ToString("N2");
                    else
                    {
                        if (double.TryParse(txtLeitora.Text.Trim(), out dLeitura))
                            txtMOV_EntradaPeso.Text = dLeitura.ToString("N2");
                        else
                            txtMOV_EntradaPeso.Text = txtLeitora.Text;
                    }
                }
                else
                {
                    if (txtLeitora.Text.Trim() == "")
                    {
                        txtMOV_SaidaPeso.Text = _iZero.ToString("N2");
                        txtMOV_CargaPeso.Text = _iZero.ToString("N2");
                    }
                    else
                    {
                        if (double.TryParse(txtLeitora.Text.Trim(), out dLeitura))
                            txtMOV_SaidaPeso.Text = dLeitura.ToString("N2");
                        else
                            txtMOV_SaidaPeso.Text = txtLeitora.Text;

                        txtMOV_CargaPeso.Text = Math.Abs((Convert.ToDouble(txtMOV_EntradaPeso.Text) - Convert.ToDouble(txtMOV_SaidaPeso.Text))).ToString("N2");
                    }

                }
            }
            catch (Exception pEx)
            {
                General.SetError(pEx);
            }
        }

        private void txtMOV_NotaFiscalPeso_Leave(object sender, EventArgs e)
        {
            if (txtMOV_NotaFiscalPeso.Text.Trim() != "")
                txtMOV_NotaFiscalPeso.Text = Convert.ToDouble(txtMOV_NotaFiscalPeso.Text.Trim()).ToString("N2");

        }

        #endregion

        #region "Métodos"

        public void Mostrar()
        {

            Cursor.Current = Cursors.WaitCursor;

            this.Size = new Size(660, 730);
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            Carregar_Controles();

            if (!Carregar_Movimento_Saida())
            {
                return;
            }

            Configurar_Leitora();
            Inicializar_Controles();
            Configurar_Controles();

            Cursor.Current = Cursors.Default;

            this.ShowDialog();

        }

        private void Configurar_Controles()
        {
            if (_Tipo == Tipo.Saida)
            {
                txtNrTicket.Enabled = false;
                chkPesagemInterna.Enabled = false;
                //txtMOV_NotaFiscal.Enabled = false;
                //txtMOV_NotaFiscalPeso.Enabled = false;
                //cboMOV_Motorista.Enabled = false;
                //mskMOV_Placa_01.Enabled = false;
                //mskMOV_Placa_02.Enabled = false;
                //mskMOV_Placa_03.Enabled = false;

                //cboMOV_Cliente.Enabled = false;
                //cboMOV_Fornecedor.Enabled = false;
                //cboMOV_Transportadora.Enabled = false;
                //cboPRD_Nome.Enabled = false;
                //txtMOV_Observacao.Enabled = false;

                //txtMOV_EntradaPeso.Enabled = false;
                //txtMOV_SaidaPeso.Enabled = false;
                //txtMOV_CargaPeso.Enabled = false;

            }

        }

        private bool Carregar_Movimento_Saida()
        {
            if (_Tipo == Tipo.Entrada)
                return true;

            frmListaMovimento oListaMovimento = new frmListaMovimento(_InternetConnection, frmListaMovimento.Tipo.Entrada_Pendentes);
            oListaMovimento.ShowDialog();

            if (oListaMovimento._MOV == null)
            {
                General.MessageError("Para realizar uma saída é obrigatório selecionar uma entrada.");
                return false;
            }

            this._MOV = oListaMovimento._MOV;

            txtNrTicket.Text = this._MOV.MOV_Ticket;

            if (this._MOV.MOV_Tipo == "I")
                chkPesagemInterna.Checked = true;
            else
                chkPesagemInterna.Checked = false;

            txtMOV_NotaFiscal.Text = this._MOV.MOV_NotaFiscal;
            txtMOV_NotaFiscalPeso.Text = this._MOV.MOV_NotaFiscalPeso.ToString("N2");
            cboMOV_Motorista.SelectedValue = this._MOV.Motorista.ENT_Id;

            if (this._MOV.MOV_Placa.Length >= 8)
                mskMOV_Placa_01.Text = this._MOV.MOV_Placa.Substring(0, 8);

            if (this._MOV.MOV_Placa.Length >= 17)
                mskMOV_Placa_02.Text = this._MOV.MOV_Placa.Substring(9, 8);

            if (this._MOV.MOV_Placa.Length >= 25)
                mskMOV_Placa_03.Text = this._MOV.MOV_Placa.Substring(17, 8);

            cboMOV_Cliente.SelectedValue = this._MOV.Cliente.ENT_Id;
            cboMOV_Fornecedor.SelectedValue = this._MOV.Fornecedor.ENT_Id;
            cboMOV_Transportadora.SelectedValue = this._MOV.Transportadora.ENT_Id;
            cboPRD_Nome.SelectedValue = this._MOV.PRD.PRD_Id;
            txtMOV_Observacao.Text = this._MOV.MOV_Observacao;
            txtMOV_EntradaPeso.Text = this._MOV.MOV_EntradaPeso.ToString("N2");

            return true;

        }

        private void Preencher_Pessoas_Juridicas()
        {

            IMetodos oAction = General.GetActionInstance(_InternetConnection);

            List<modENTIDADE> lsCliente = oAction.GetPessoaJuridica(Program._BAL.CLI_Id);
            List<modENTIDADE> lsFornecedor = oAction.GetPessoaJuridica(Program._BAL.CLI_Id);
            List<modENTIDADE> lsTransportadora = oAction.GetPessoaJuridica(Program._BAL.CLI_Id);

            cboMOV_Cliente.ValueMember = "Value";
            cboMOV_Cliente.DisplayMember = "Text";
            cboMOV_Cliente.DataSource = lsCliente;

            cboMOV_Fornecedor.ValueMember = "Value";
            cboMOV_Fornecedor.DisplayMember = "Text";
            cboMOV_Fornecedor.DataSource = lsFornecedor;

            cboMOV_Transportadora.ValueMember = "Value";
            cboMOV_Transportadora.DisplayMember = "Text";
            cboMOV_Transportadora.DataSource = lsTransportadora;
        }

        private void Preencher_Pessoas_Fisicas()
        {
            IMetodos oAction = General.GetActionInstance(_InternetConnection);
            List<modENTIDADE> lsMotorista = oAction.GetPessoaFisica(Program._BAL.CLI_Id);

            cboMOV_Motorista.ValueMember = "Value";
            cboMOV_Motorista.DisplayMember = "Text";
            cboMOV_Motorista.DataSource = lsMotorista;
        }

        private void Preencher_Produtos()
        {
            IMetodos oAction = General.GetActionInstance(_InternetConnection);
            List<MOD.CES.CES.modPRODUTO> lsProduto = oAction.GetProduto(Program._BAL.CLI_Id);

            cboPRD_Nome.ValueMember = "PRD_Id";
            cboPRD_Nome.DisplayMember = "PRD_Nome";
            cboPRD_Nome.DataSource = lsProduto;
        }

        private void Configurar_Leitora()
        {
            _oSerialPort = new SerialPort(ConfigurationManager.AppSettings["BAL_SerialPort"].ToString());
            _oSerialPort.BaudRate = Convert.ToInt32(ConfigurationManager.AppSettings["BAL_BaudRate"]);
            _oSerialPort.Parity = (Parity)Convert.ToInt32(ConfigurationManager.AppSettings["BAL_Parity"]);
            _oSerialPort.StopBits = (StopBits)Convert.ToInt32(ConfigurationManager.AppSettings["BAL_StopBits"]);
            _oSerialPort.DataBits = Convert.ToInt32(ConfigurationManager.AppSettings["BAL_DataBits"]);
            _oSerialPort.Handshake = (Handshake)Convert.ToInt32(ConfigurationManager.AppSettings["BAL_Handshake"]);
        }

        private void Ativar_Leitora()
        {
            try
            {
                //oSerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                _iCount = 0;
                txtLeitora.ForeColor = Color.Red;
                txtLeitora.Text = _iZero.ToString("N2");
                txtLeitora.ReadOnly = true;
                _oSerialPort.Open();
                tmSerial.Enabled = true;
            }
            catch (Exception ex)
            {
                tmSerial.Enabled = false;
                General.SetError(ex);
                General.MessageError("Não foi possível conectar a balança. Verifique se o equipamento está conectado.");
            }
        }

        private void Desativar_Leitora()
        {
            tmSerial.Enabled = false;
            _oSerialPort.Close();
            txtLeitora.ForeColor = Color.Lime;
            txtLeitora.ReadOnly = false;
            txtLeitora.Text = _iZero.ToString("N2");
        }

        private void Selecionar_Tipo()
        {

            if (optAutomatico.Checked)
            {
                Ativar_Leitora();
            }

            if (optManual.Checked)
            {
                Desativar_Leitora();
            }
        }

        private void Carregar_Controles()
        {
            Preencher_Pessoas_Juridicas();
            Preencher_Pessoas_Fisicas();
            Preencher_Produtos();
        }

        private void Inicializar_Controles()
        {
            if (_Tipo == Tipo.Entrada)
            {
                this.Text = "Entrada de Pesagem";
                lblTitulo.Text = "Entrada de Pesagem";
                lblTitulo.ForeColor = Color.Black;
                IMetodos oAction = General.GetActionInstance(_InternetConnection);
                txtNrTicket.Text = oAction.GetTicket(Program._BAL.CLI_Id, Program._BAL.BAL_Id);

                chkPesagemInterna.Checked = false;
                txtMOV_NotaFiscal.Text = "";
                txtMOV_NotaFiscalPeso.Text = "";
                cboMOV_Motorista.SelectedIndex = -1;
                mskMOV_Placa_01.Text = "";
                mskMOV_Placa_02.Text = "";
                mskMOV_Placa_03.Text = "";
                txtMOV_Observacao.Text = "";
                cboMOV_Cliente.SelectedIndex = -1;
                cboMOV_Fornecedor.SelectedIndex = -1;
                cboMOV_Transportadora.SelectedIndex = -1;
                cboPRD_Nome.SelectedIndex = -1;

                txtMOV_EntradaPeso.Enabled = false;
                txtMOV_SaidaPeso.Enabled = false;
                txtMOV_CargaPeso.Enabled = false;
            }
            else if (_Tipo == Tipo.Saida)
            {
                this.Text = "Saída de Pesagem";
                lblTitulo.Text = "Saída de Pesagem";

                txtMOV_EntradaPeso.Enabled = false;
                txtMOV_SaidaPeso.Enabled = false;
                txtMOV_CargaPeso.Enabled = false;
            }

            txtLeitora.Text = _iZero.ToString("N2");
            optAutomatico.Checked = true;

        }

        private double Convert_SerialData_Toledo(string pValue)
        {
            long lNumber;
            double dNumber;
            int iPostion = pValue.IndexOf("<");
            string sNumber = "";
            string[] lines = pValue.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            if (lines.Count() > 1)
            {
                try
                {
                    sNumber = lines[1].Substring(5, 12);
                }
                catch (Exception pEx)
                {
                    General.SetError(pEx);
                    sNumber = "";
                }
            }

            if (Int64.TryParse(sNumber.Trim(), out lNumber))
            {
                dNumber = lNumber / 1000000;
                return dNumber;
            }

            return 0;

        }

        private double Convert_SerialData_Jundia(string pValue)
        {
            long lNumber;
            double dNumber;
            string sLine;

            string sNumber = "";
            string[] lines = pValue.Split(new[] { ":" }, StringSplitOptions.None);
                        
            if (lines.Count() > 1)
            {
                try
                {
                    if (lines[1].Length < 17)
                        sLine = lines[1];
                    else
                        sLine = lines[2];

                        sNumber = sLine.Substring(8, 9);                    
                }
                catch (Exception pEx)
                {
                    General.SetError(new Exception(string.Format("Value: #{0}#", pValue), pEx));
                    sNumber = "";
                }
            }

            if (Int64.TryParse(sNumber.Trim(), out lNumber))
            {
                dNumber = lNumber / 100;
                return dNumber;
            }

            return 0;

        }


        #endregion
    }
}
