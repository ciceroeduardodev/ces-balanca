using CES.APP.XGP.Classes;
using CES.APP.XGP.Interfaces;
using CES.MOD.CES.CES;
using CES.MOD.CES.Public;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES.APP.XGP
{
    public partial class frmCadastroProduto : Form
    {

        public enum TIPO_ACAO { CRIAR, ALTERAR };

        private bool _InternetConnection;
        private TIPO_ACAO _TipoOperacao;
        private int _PRD_Id;

        public frmCadastroProduto(bool pInternetConnection, TIPO_ACAO pTipoOperacao = TIPO_ACAO.CRIAR)
        {
            InitializeComponent();

            lblTitulo.Text = "Cadastro de Produtos";
            this.Text = lblTitulo.Text;
            _InternetConnection = pInternetConnection;
            _TipoOperacao = pTipoOperacao;
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            modPRODUTO modPRD = new modPRODUTO();
            modPRD.CLI_Id = Program._BAL.CLI_Id;
            modPRD.PRD_Id = 0;
            modPRD.PRD_Nome = txtPRD_Nome.Text.Trim().ToUpper();
            modPRD.PRD_Ativo = 1;
            PostReturn oRetorno = new PostReturn();

            IMetodos oAction = General.GetActionInstance(_InternetConnection);
            oAction.PostProduto(modPRD, ref oRetorno);

            if (oRetorno.Status)
            {
                General.MessageInformation("Cadastro realizado com sucesso!");
                this.Close();
            }
            else
            {
                General.MessageError(oRetorno.Message);
            }
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {

            if (_TipoOperacao == TIPO_ACAO.CRIAR)
            {
                this.Size = new Size(660, 260);
                this.MaximumSize = this.Size;
                this.MinimumSize = this.Size;

                grpAlterar.Visible = false;

                cmdSalvar.Visible = true;
                cmdAlterar.Visible = false;
                cmdExcluir.Visible = false;
                tssSeparador01.Visible = false;
            }
            else if (_TipoOperacao == TIPO_ACAO.ALTERAR)
            {
                this.Size = new Size(660, 320);
                this.MaximumSize = this.Size;
                this.MinimumSize = this.Size;

                grpAlterar.Visible = true;

                cmdSalvar.Visible = false;
                cmdAlterar.Visible = true;
                cmdExcluir.Visible = true;
                tssSeparador01.Visible = false;

                Preencher_Produtos();

            }
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Preencher_Produtos()
        {
            IMetodos oAction = General.GetActionInstance(_InternetConnection);
            List<MOD.CES.CES.modPRODUTO> lsProduto = oAction.GetProduto(Program._BAL.CLI_Id);

            cboPRD_Nome.ValueMember = "PRD_Id";
            cboPRD_Nome.DisplayMember = "PRD_Nome";
            cboPRD_Nome.DataSource = lsProduto;

            cboPRD_Nome.SelectedIndex = -1;
        }

        private void cboPRD_Nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPRD_Nome.SelectedIndex > -1)
            {
                modPRODUTO modPRD = (modPRODUTO)cboPRD_Nome.SelectedItem;
                _PRD_Id = modPRD.PRD_Id;
                txtPRD_Nome.Text = modPRD.PRD_Nome;
            }
            else
            {
                _PRD_Id = 0;
                txtPRD_Nome.Text = "";
            }
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            this.Alterar(1);
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Deseja realmente Excluir o produto selecionado?", Contantes.C_NomeSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            this.Alterar(0);
        }

        private void Alterar(Int32 pPRD_Ativo)
        {

            modPRODUTO modPRD = new modPRODUTO();
            modPRD.CLI_Id = Program._BAL.CLI_Id;
            modPRD.PRD_Id = _PRD_Id;
            modPRD.PRD_Nome = txtPRD_Nome.Text.Trim().ToUpper();
            modPRD.PRD_Ativo = pPRD_Ativo;
            PostReturn oRetorno = new PostReturn();

            IMetodos oAction = General.GetActionInstance(_InternetConnection);
            oAction.PostProduto(modPRD, ref oRetorno);

            if (oRetorno.Status)
            {
                General.MessageInformation("Alteração realizada com sucesso!");
                this.Close();
            }
            else
            {
                General.MessageError(oRetorno.Message);
            }

        }
    }
}
