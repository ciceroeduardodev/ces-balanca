using CES.APP.XGP.Classes;
using CES.APP.XGP.Interfaces;
using CES.MOD.CES.Public;
using CES.MOD.CES.XGP;
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
    public partial class frmCadastroEntidade : Form
    {

        public enum TIPO_ACAO { CRIAR, ALTERAR };

        private int _ENT_Id;

        public enum Tipo { Fisica, Juridica };
        private Tipo _Tipo;
        private bool _InternetConnection;
        private TIPO_ACAO _TipoOperacao;

        public frmCadastroEntidade(Tipo pTipo, bool pInternetConnection, TIPO_ACAO pTipoOperacao = TIPO_ACAO.CRIAR)
        {
            InitializeComponent();

            _Tipo = pTipo;
            _InternetConnection = pInternetConnection;
            _TipoOperacao = pTipoOperacao;

            if (_Tipo == Tipo.Fisica)
            {
                lblENT_CPF_CNPJ.Text = "CPF:";
                txtENT_CPF_CNPJ.Mask = "000,000,000-00";
                lblENT_Nome.Text = "Nome:";
                lblTitulo.Text = "Cadastro de Pessoa Física";
                lblEntidade.Text = "Pes. Física:";
            }
            else if (_Tipo == Tipo.Juridica)
            {
                lblENT_CPF_CNPJ.Text = "CNPJ:";
                txtENT_CPF_CNPJ.Mask = "00,000,000/0000-00";
                lblENT_Nome.Text = "Nome:";
                lblTitulo.Text = "Cadastro de Pessoa Jurídica";
                lblEntidade.Text = "Pes. Jurídica:";
            }

            this.Text = lblTitulo.Text;

        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            PostReturn oRetorno;

            modENTIDADE modENT = new modENTIDADE();

            modENT.CLI_Id = Program._BAL.CLI_Id;
            modENT.ENT.ENT_CPF_CNPJ = txtENT_CPF_CNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", "");
            modENT.ENT.ENT_Nome = txtENT_Nome.Text.Trim().ToUpper();

            if (_Tipo == Tipo.Fisica)
                modENT.ENT.ENT_Tipo = "F";
            else if (_Tipo == Tipo.Juridica)
                modENT.ENT.ENT_Tipo = "J";

            modENT.ENT.ENT_Ativo = 1;

            oRetorno = new PostReturn();
            IMetodos oAction = General.GetActionInstance(_InternetConnection);
            oAction.PostEntidade(modENT, ref oRetorno);

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

        private void frmCadastroEntidade_Load(object sender, EventArgs e)
        {
            if (_TipoOperacao == TIPO_ACAO.CRIAR)
            {
                this.Size = new Size(850, 300);
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
                this.Size = new Size(850, 350);
                this.MaximumSize = this.Size;
                this.MinimumSize = this.Size;

                grpAlterar.Visible = true;

                cmdSalvar.Visible = false;
                cmdAlterar.Visible = true;
                cmdExcluir.Visible = true;
                tssSeparador01.Visible = true;

                Preencher_Pessoas();

            }
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            this.Alterar(1);
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Deseja realmente Excluir a {0} selecionada?", lblEntidade.Text), Contantes.C_NomeSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            this.Alterar(0);
        }


        private void Preencher_Pessoas()
        {

            IMetodos oAction = General.GetActionInstance(_InternetConnection);

            List<modENTIDADE> lsFisica = oAction.GetPessoaFisica(Program._BAL.CLI_Id);
            List<modENTIDADE> lsJuridica = oAction.GetPessoaJuridica(Program._BAL.CLI_Id);

            cboENT_Nome.ValueMember = "Value";
            cboENT_Nome.DisplayMember = "Text";

            if (_Tipo == Tipo.Fisica)
            {
                cboENT_Nome.DataSource = lsFisica;
            }
            else
            {
                cboENT_Nome.DataSource = lsJuridica;
            }

            cboENT_Nome.SelectedIndex = -1;

        }

        private void Alterar(int pENT_Ativo)
        {
            PostReturn oRetorno;

            modENTIDADE modENT = new modENTIDADE();

            modENT.CLI_Id = Program._BAL.CLI_Id;
            modENT.ENT.ENT_Id = _ENT_Id;
            modENT.ENT.ENT_CPF_CNPJ = txtENT_CPF_CNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", "");
            modENT.ENT.ENT_Nome = txtENT_Nome.Text.Trim().ToUpper();

            if (_Tipo == Tipo.Fisica)
                modENT.ENT.ENT_Tipo = "F";
            else if (_Tipo == Tipo.Juridica)
                modENT.ENT.ENT_Tipo = "J";

            modENT.ENT.ENT_Ativo = pENT_Ativo;

            oRetorno = new PostReturn();
            IMetodos oAction = General.GetActionInstance(_InternetConnection);
            oAction.PostEntidade(modENT, ref oRetorno);

            if (oRetorno.Status)
            {
                Preencher_Pessoas();
                General.MessageInformation("Alteração realizada com sucesso!");
                this.Close();
            }
            else
            {
                General.MessageError(oRetorno.Message);
            }
        }

        private void cboENT_Nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboENT_Nome.SelectedIndex > -1)
            {
                modENTIDADE modENT = (modENTIDADE)cboENT_Nome.SelectedItem;
                _ENT_Id = modENT.ENT.ENT_Id;
                txtENT_CPF_CNPJ.Text = modENT.ENT.ENT_CPF_CNPJ;
                txtENT_Nome.Text = modENT.ENT.ENT_Nome;
            }
            else
            {
                _ENT_Id = 0;
                txtENT_CPF_CNPJ.Text = "";
                txtENT_Nome.Text = "";
            }
        }
    }
}
