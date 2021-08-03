using CES.APP.XGP.Classes;
using CES.APP.XGP.Interfaces;
using CES.MOD.CES.XGP;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CES.APP.XGP
{
    public partial class mdiPrincipal : Form
    {
        public bool _InternetConnection;

        public mdiPrincipal()
        {
            InitializeComponent();
        }

        private void cmdEntrada_Click(object sender, EventArgs e)
        {

            tmConexao.Enabled = false;
            frmPesagem oPesagem = new frmPesagem(frmPesagem.Tipo.Entrada, _InternetConnection);
            oPesagem.Mostrar();
            oPesagem = null;
            tmConexao.Enabled = true;
        }

        private void tmConexao_Tick(object sender, EventArgs e)
        {
            try
            {
                tmConexao.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["SyncTime"].ToString());
                                
                if (Convert.ToBoolean(ConfigurationManager.AppSettings["SIS_Local"].ToString()))
                    return;

                if (_InternetConnection)
                {
                    lblConectado.Visible = true;
                    lblNaoConectado.Visible = false;
                }
                else
                {
                    lblConectado.Visible = false;
                    lblNaoConectado.Visible = true;
                }

                Thread oThread = new Thread(CheckConnection);
                oThread.Start();

            }
            catch (Exception ex)
            {
                lblConectado.Visible = false;
                lblNaoConectado.Visible = true;
                General.SetError(ex);
            }
        }

        private void mdiPrincipal_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            lblConectado.Visible = false;
            lblNaoConectado.Visible = false;
            Habilitar_Menu();
            tmConexao.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void cmdSaida_Click(object sender, EventArgs e)
        {
            tmConexao.Enabled = false;
            frmPesagem oPesagem = new frmPesagem(frmPesagem.Tipo.Saida, _InternetConnection);
            oPesagem.Mostrar();
            oPesagem = null;
            tmConexao.Enabled = true;
        }

        private void cmdAddPessoaJuridica_Click(object sender, EventArgs e)
        {
            tmConexao.Enabled = false;
            frmCadastroEntidade oCadastroEntidade = new frmCadastroEntidade(frmCadastroEntidade.Tipo.Juridica, _InternetConnection);
            oCadastroEntidade.ShowDialog();
            oCadastroEntidade = null;
            tmConexao.Enabled = true;
        }

        private void cmdAddPessoaFisica_Click(object sender, EventArgs e)
        {
            tmConexao.Enabled = false;
            frmCadastroEntidade oCadastroEntidade = new frmCadastroEntidade(frmCadastroEntidade.Tipo.Fisica, _InternetConnection);
            oCadastroEntidade.ShowDialog();
            oCadastroEntidade = null;
            tmConexao.Enabled = true;
        }

        private void cmdAddProduto_Click(object sender, EventArgs e)
        {
            tmConexao.Enabled = false;
            frmCadastroProduto oCadastroProduto = new frmCadastroProduto(_InternetConnection);
            oCadastroProduto.ShowDialog();
            oCadastroProduto = null;
            tmConexao.Enabled = true;
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            tmConexao.Enabled = false;
            frmListaMovimento oListaMovimento = new frmListaMovimento(_InternetConnection, frmListaMovimento.Tipo.SaidasTop100);
            oListaMovimento.ShowDialog();

            if (oListaMovimento._MOV == null)
            {
                General.MessageError("Para realizar uma impressão é obrigatório selecionar uma pesagem.");
            }

            if (General.Imprimir(oListaMovimento._MOV, 1, "Impressão de 2ª Via"))
            {
                General.MessageInformation("Impressão realizada com sucesso!");
            }

            oListaMovimento = null;

            tmConexao.Enabled = true;
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckConnection()
        {
            _InternetConnection = General.Ping();

            if (_InternetConnection)
                General.Sincronizar();
        }
      
        private void cmdConfig_Click(object sender, EventArgs e)
        {
            if (!General.Autenticar())
            {
                return;
            }

            tmConexao.Enabled = false;
            frmCadastroBalanca oCadastroBalanca = new frmCadastroBalanca(ConfigurationManager.AppSettings["BAL_Token"].ToString());
            oCadastroBalanca.ShowDialog();
            oCadastroBalanca = null;
            tmConexao.Enabled = true;
        }

        private void mdiPrincipal_Shown(object sender, EventArgs e)
        {
            IMetodos oAction = General.GetActionInstance(_InternetConnection);

            do
            {
                Program._BAL = oAction.GetBalanca(ConfigurationManager.AppSettings["BAL_Token"].ToString());

                if (Program._BAL.BAL_Id == 0)
                {
                    tmConexao.Enabled = false;
                    frmCadastroBalanca oCadastroBalanca = new frmCadastroBalanca(ConfigurationManager.AppSettings["BAL_Token"].ToString());
                    oCadastroBalanca.ShowDialog();
                    oCadastroBalanca = null;
                    tmConexao.Enabled = true;
                }

            } while (Program._BAL.BAL_Id == 0);

        }

        private void mnuSQL_Click(object sender, EventArgs e)
        {
            tmConexao.Enabled = false;
            frmSQLConsulta oSQLConsulta = new frmSQLConsulta();
            oSQLConsulta.ShowDialog();
            oSQLConsulta = null;
            tmConexao.Enabled = true;
        }

        private void Habilitar_Menu()
        {
            string sKey = string.Format("SQL_{0}", DateTime.Now.ToString("yyyyMMdd"));

            List<string> sKeys = new List<string>(ConfigurationManager.AppSettings.AllKeys);

            try
            {
                if (sKeys.Contains(sKey))
                    mnuSQL.Visible = true;
                else
                    mnuSQL.Visible = false;

            }
            catch (Exception pEx)
            {
                System.Diagnostics.Debug.WriteLine(pEx.Message);
                mnuSQL.Visible = false;
            }
        }

        private void cmdUpdPessoaJuridica_Click(object sender, EventArgs e)
        {
            tmConexao.Enabled = false;
            frmCadastroEntidade oCadastroEntidade = new frmCadastroEntidade(frmCadastroEntidade.Tipo.Juridica, _InternetConnection, frmCadastroEntidade.TIPO_ACAO.ALTERAR);
            oCadastroEntidade.ShowDialog();
            oCadastroEntidade = null;
            tmConexao.Enabled = true;
        }

        private void cmdUpdPessoaFisica_Click(object sender, EventArgs e)
        {
            tmConexao.Enabled = false;
            frmCadastroEntidade oCadastroEntidade = new frmCadastroEntidade(frmCadastroEntidade.Tipo.Fisica, _InternetConnection, frmCadastroEntidade.TIPO_ACAO.ALTERAR);
            oCadastroEntidade.ShowDialog();
            oCadastroEntidade = null;
            tmConexao.Enabled = true;
        }

        private void cmdUpdProduto_Click(object sender, EventArgs e)
        {
            tmConexao.Enabled = false;
            frmCadastroProduto oCadastroProduto = new frmCadastroProduto(_InternetConnection, frmCadastroProduto.TIPO_ACAO.ALTERAR);
            oCadastroProduto.ShowDialog();
            oCadastroProduto = null;
            tmConexao.Enabled = true;
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
