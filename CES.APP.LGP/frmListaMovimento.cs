using CES.APP.XGP.Classes;
using CES.APP.XGP.Interfaces;
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
    public partial class frmListaMovimento : Form
    {
        public enum Tipo { Entrada_Pendentes, SaidasTop100 };

        public modMOVIMENTO _MOV { get; set; }

        private Tipo _Tipo;

        List<modMOVIMENTO> _lsMOV = new List<modMOVIMENTO>();

        private bool _InternetConnection;

        public frmListaMovimento(bool pInternetConnection, Tipo pTipo)
        {
            InitializeComponent();

            _Tipo = pTipo;
            _InternetConnection = pInternetConnection;

        }


        private void frmListaMovimento_Load(object sender, EventArgs e)
        {
            switch (_Tipo)
            {
                case Tipo.Entrada_Pendentes:
                    lblTitulo.Text = "Lista de entradas pendentes";
                    break;
                case Tipo.SaidasTop100:
                    lblTitulo.Text = "Lista de saídas";
                    break;
            }

            Carregar_Movimentos();
        }

        private void Carregar_Movimentos()
        {

            DataTable dtMOV = new DataTable();
            dtMOV.Columns.Add("MOV_Id");
            dtMOV.Columns.Add("MOV_Ticket");
            dtMOV.Columns.Add("MOV_Tipo_Descr");
            dtMOV.Columns.Add("MOV_Placa");
            dtMOV.Columns.Add("Motorista");
            dtMOV.Columns.Add("Cliente");
            dtMOV.Columns.Add("Fornecedor");
            dtMOV.Columns.Add("Transportadora");
            dtMOV.Columns.Add("PRD_Nome");
            dtMOV.Columns.Add("MOV_EntradaData");
            dtMOV.Columns.Add("MOV_EntradaPeso");
            dtMOV.Columns.Add("MOV_SaidaData");
            dtMOV.Columns.Add("MOV_SaidaPeso");
            dtMOV.Columns.Add("MOV_CargaPeso");

            IMetodos oAction = General.GetActionInstance(_InternetConnection);
                      
            if (_Tipo == Tipo.SaidasTop100)
            {                
                _lsMOV = oAction.GetSaidasTop100(Program._BAL.CLI_Id).ToList();
            }
            else
            {             
                _lsMOV = oAction.GetEntradasPendentes(Program._BAL.CLI_Id).ToList();
            }            

            DataRow rwMOV;

            foreach (modMOVIMENTO oItem in _lsMOV)
            {
                rwMOV = dtMOV.NewRow();
                rwMOV["MOV_Id"] = oItem.MOV_Id;
                rwMOV["MOV_Ticket"] = oItem.MOV_Ticket;
                rwMOV["MOV_Tipo_Descr"] = oItem.MOV_Tipo_Descr;
                rwMOV["MOV_Placa"] = oItem.MOV_Placa;
                rwMOV["Motorista"] = oItem.Motorista.ENT_Nome;
                rwMOV["Cliente"] = oItem.Cliente.ENT_Nome;
                rwMOV["Fornecedor"] = oItem.Fornecedor.ENT_Nome;
                rwMOV["Transportadora"] = oItem.Transportadora.ENT_Nome;
                rwMOV["PRD_Nome"] = oItem.PRD.PRD_Nome;
                rwMOV["MOV_EntradaData"] = oItem.MOV_EntradaData;
                rwMOV["MOV_EntradaPeso"] = oItem.MOV_EntradaPeso;
                rwMOV["MOV_SaidaData"] = oItem.MOV_SaidaData;
                rwMOV["MOV_SaidaPeso"] = oItem.MOV_SaidaPeso;
                rwMOV["MOV_CargaPeso"] = oItem.MOV_CargaPeso;

                dtMOV.Rows.Add(rwMOV);
                             
            }

            grdMovimento.DataSource = dtMOV;

        }

        private void grdMovimento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iMOV_Id = Convert.ToInt32(grdMovimento.Rows[e.RowIndex].Cells["MOV_Id"].Value);
            _MOV = _lsMOV.Where(x => x.MOV_Id == iMOV_Id).ToList()[0];
            this.Close();
        }

        private void grdMovimento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {            
            switch (this.grdMovimento.Columns[e.ColumnIndex].Name.Trim().ToUpper())
            {
                case "MOV_ENTRADADATA":
                    e.Value = General.FormatDate(Convert.ToDateTime(e.Value));
                    break;
                case "MOV_ENTRADAPESO":                    
                    e.Value = Convert.ToDouble(e.Value).ToString("N2");
                    break;
                case "MOV_SAIDADATA":
                    e.Value = General.FormatDate(Convert.ToDateTime(e.Value));
                    break;
                case "MOV_SAIDAPESO":
                    e.Value = Convert.ToDouble(e.Value).ToString("N2");
                    break;
                case "MOV_CARGAPESO":
                    e.Value = Convert.ToDouble(e.Value).ToString("N2");
                    break;
            }
        }
    }
}
