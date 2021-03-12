using CES.APP.XGP.Classes;
using CES.APP.XGP.Interfaces;
using CES.MOD.CES.CES;
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
    public partial class frmCadastroBalanca : Form
    {
        string _Token;

        public frmCadastroBalanca(string pToken)
        {
            InitializeComponent();

            _Token = pToken;
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            if (txtCLI_Nome.Text.Trim() == "")
            {
                General.MessageInformation("Deve ser informado o nome do Cliente.");
                return;
            }

            if (txtBAL_Nome.Text.Trim() == "")
            {
                General.MessageInformation("Deve ser informado o nome da Balança.");
                return;
            }

            IMetodos oAction = General.GetActionInstance(false);
            PostReturn oReturn = new PostReturn();

            modCLIENTE oCLI = new modCLIENTE();
            oCLI.CLI_Id = 1;
            oCLI.CLI_Nome = txtCLI_Nome.Text.ToUpper();
            oCLI.CLI_Token = _Token;

            modBALANCA oBAL = new modBALANCA();
            oBAL.BAL_Id = 1;
            oBAL.BAL_Nome = txtBAL_Nome.Text.ToUpper();
            oBAL.BAL_Token = _Token;
            oBAL.BAL_Ticket_To = txtBAL_Ticket_To.Text;
            oBAL.BAL_Ticket_Bcc = txtBAL_Ticket_Bcc.Text;
            oBAL.BAL_Ticket_Bco = txtBAL_Ticket_Bco.Text;

            oBAL = oAction.PostConfigInicial(oCLI, oBAL, ref oReturn);

            General.MessageInformation("Operação realizada com sucesso!");
            this.Close();


        }

        private void frmCadastroBalanca_Load(object sender, EventArgs e)
        {

            this.Size = new Size(760, 450);
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            lblTitulo.Text = "Configuração da balança";
            this.Text = lblTitulo.Text;

            IMetodos oAction = General.GetActionInstance(false);

            modBALANCA oBAL = oAction.GetBalanca(_Token);
            txtBAL_Nome.Text = oBAL.BAL_Nome;
            txtBAL_Ticket_To.Text = oBAL.BAL_Ticket_To;
            txtBAL_Ticket_Bcc.Text = oBAL.BAL_Ticket_Bcc;
            txtBAL_Ticket_Bco.Text = oBAL.BAL_Ticket_Bco;

            modCLIENTE oCLI = new modCLIENTE();
            oCLI.CLI_Id = 1;
            oCLI = oAction.GetCliente(oCLI);
            txtCLI_Nome.Text = oCLI.CLI_Nome;

        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
