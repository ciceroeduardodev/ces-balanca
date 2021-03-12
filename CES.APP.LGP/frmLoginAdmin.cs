using CES.APP.XGP.Classes;
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
    public partial class frmLoginAdmin : Form
    {

        public bool Autenticado { get; set; }

        public frmLoginAdmin()
        {
            InitializeComponent();
        }

        private void cmdLogar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.ToUpper().Trim() == Contantes.C_SenhaAdmin.Trim().ToUpper())
            {
                Autenticado = true;
                this.Close();
            }
            else
            {
                txtPassword.Text = "";
                General.MessageError("Senha incorreta!");
                Autenticado = false;
            }            
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            Autenticado = false;
            this.Close();
        }

        private void frmLoginAdmin_Load(object sender, EventArgs e)
        {         
            this.Size = new Size(360, 250);
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }
    }
}
