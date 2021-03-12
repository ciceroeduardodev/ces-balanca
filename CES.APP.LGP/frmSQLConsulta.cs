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
    public partial class frmSQLConsulta : Form
    {
        public frmSQLConsulta()
        {
            InitializeComponent();
        }

        private void cmdExecutarConsulta_Click(object sender, EventArgs e)
        {
            grdResultado.DataSource = SQLDataBase.Selecionar(txtScript.Text);
        }

        private void frmSQLConsulta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void cmdExecutarScript_Click(object sender, EventArgs e)
        {
            if(SQLDataBase.Executar(txtScript.Text))
            {
                General.MessageInformation("Operação realizada com sucesso!");
            }
            else
            {
                General.MessageError("Ocorreu um erro na operação!");
            }

        }
    }
}
