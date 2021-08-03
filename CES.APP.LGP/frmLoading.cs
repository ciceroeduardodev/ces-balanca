using CES.APP.XGP.Classes;
using CES.MOD.CES.CES;
using CES.MOD.CES.Public;
using CES.MOD.CES.XGP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES.APP.XGP
{
    public partial class frmLoading : Form
    {

        public bool _LoadingCompleted { get; set; }

        public frmLoading(string pLabel = "Sincronizando dados...")
        {
            InitializeComponent();

            lblTitulo.Text = pLabel;
        }

        public void Mostrar()
        {
            this.ShowDialog();
        }

        private void tmTimer_Tick(object sender, EventArgs e)
        {
            if (this._LoadingCompleted)
            {
                tmTimer.Enabled = false;
                this.Close();
            }
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            this.Size = new Size(500, 150);
            Thread oThread = new Thread(Sincronizar);
            oThread.Start();
        }

        public void Sincronizar2()
        {

            Offline oActionOff = new Offline();
            Online oActionOn = new Online();
            PostReturn oReturn = new PostReturn();
            modMOVIMENTO oMOV;
            MOD.CES.XGP.modENTIDADE oENT;
            modPRODUTO oPRD;

            modXGP oXGPOff = oActionOff.GetXGP("");

            if (oXGPOff != null)
            {

                if (oXGPOff.ToSync.PFs != null && oXGPOff.ToSync.PFs.Count > 0)
                {
                    foreach (MOD.CES.XGP.modENTIDADE oItem in oXGPOff.ToSync.PFs.ToArray())
                    {
                        oENT = new MOD.CES.XGP.modENTIDADE();
                        oENT = oItem;
                        oENT.ENT.ENT_Id = 0;
                        oActionOn.PostEntidade(oENT, ref oReturn);
                        if (oReturn.Status)
                            oXGPOff.ToSync.PFs.Remove(oItem);
                    }
                }

                if (oXGPOff.ToSync.PJs != null && oXGPOff.ToSync.PJs.Count > 0)
                {
                    foreach (MOD.CES.XGP.modENTIDADE oItem in oXGPOff.ToSync.PJs.ToArray())
                    {
                        oENT = new MOD.CES.XGP.modENTIDADE();
                        oENT = oItem;
                        oENT.ENT.ENT_Id = 0;
                        oActionOn.PostEntidade(oENT, ref oReturn);
                        if (oReturn.Status)
                            oXGPOff.ToSync.PJs.Remove(oItem);
                    }
                }

                if (oXGPOff.ToSync.PRDs != null && oXGPOff.ToSync.PRDs.Count > 0)
                {
                    foreach (modPRODUTO oItem in oXGPOff.ToSync.PRDs.ToArray())
                    {
                        oPRD = new modPRODUTO();
                        oPRD = oItem;
                        oPRD.PRD_Id = 0;
                        oActionOn.PostProduto(oPRD, ref oReturn);
                        if (oReturn.Status)
                            oXGPOff.ToSync.PRDs.Remove(oItem);
                    }
                }

                if (oXGPOff.ToSync.MOVs_SaidasTop100 != null && oXGPOff.ToSync.MOVs_SaidasTop100.Count > 0)
                {
                    foreach (modMOVIMENTO oItem in oXGPOff.ToSync.MOVs_SaidasTop100.ToArray())
                    {
                        oMOV = new modMOVIMENTO();
                        oMOV = oItem;
                        oMOV.MOV_Ticket = oActionOn.GetTicket(Program._BAL.CLI_Id, Program._BAL.BAL_Id);
                        oMOV = Sincronizar_Item(oMOV);

                        oActionOn.PostSaida(oMOV, ref oReturn);
                        if (oReturn.Status)
                            oXGPOff.ToSync.MOVs_SaidasTop100.Remove(oItem);
                    }
                }

                if (oXGPOff.ToSync.MOVs_EntradasPendentes != null && oXGPOff.ToSync.MOVs_EntradasPendentes.Count > 0)
                {
                    foreach (modMOVIMENTO oItem in oXGPOff.ToSync.MOVs_EntradasPendentes.ToArray())
                    {
                        oMOV = new modMOVIMENTO();
                        oMOV = oItem;
                        oMOV.MOV_Ticket = oActionOn.GetTicket(Program._BAL.CLI_Id, Program._BAL.BAL_Id);
                        oMOV = Sincronizar_Item(oMOV);

                        oActionOn.PostEntrada(oMOV, ref oReturn);
                        if (oReturn.Status)
                            oXGPOff.ToSync.MOVs_EntradasPendentes.Remove(oItem);
                    }
                }

            }

            modXGP oXGPOn = oActionOn.GetXGP(ConfigurationManager.AppSettings["BAL_Token"].ToString());
            Offline.Commit(oXGPOn);

            this._LoadingCompleted = true;

        }

        public void Sincronizar()
        {            
            new modSync();
            DAO.CES.daoSync oSync = new DAO.CES.daoSync();
            modSync _Sync = new modSync();
            _Sync = oSync.Selecionar();

            Online oActionOn = new Online();
            PostReturn oReturn = new PostReturn();
            oActionOn.PostSync(_Sync, ref oReturn);

            this._LoadingCompleted = true;

        }

        private modMOVIMENTO Sincronizar_Item(modMOVIMENTO pItem)
        {
            Online oActionOn = new Online();
            PostReturn oReturn = new PostReturn();

            MOD.CES.XGP.modENTIDADE oENTIDADE;
            modMOVIMENTO oItem = pItem;

            //Cadastrar Motorista
            if (oItem.Motorista.ENT_Id == 0)
            {
                oENTIDADE = new MOD.CES.XGP.modENTIDADE();
                oENTIDADE.CLI_Id = Program._BAL.CLI_Id;
                oENTIDADE.ENT = oItem.Motorista;
                oItem.Motorista = oActionOn.PostEntidade(oENTIDADE, ref oReturn).ENT;
            }

            //Cadastrar Cliente
            if (oItem.Cliente.ENT_Id == 0)
            {
                oENTIDADE = new MOD.CES.XGP.modENTIDADE();
                oENTIDADE.CLI_Id = Program._BAL.CLI_Id;
                oENTIDADE.ENT = oItem.Cliente;
                oItem.Cliente = oActionOn.PostEntidade(oENTIDADE, ref oReturn).ENT;
            }

            //Cadastrar Fornecedor
            if (oItem.Fornecedor.ENT_Id == 0)
            {
                oENTIDADE = new MOD.CES.XGP.modENTIDADE();
                oENTIDADE.CLI_Id = Program._BAL.CLI_Id;
                oENTIDADE.ENT = oItem.Fornecedor;
                oItem.Fornecedor = oActionOn.PostEntidade(oENTIDADE, ref oReturn).ENT;
            }

            //Cadastrar Transportador
            if (oItem.Transportadora.ENT_Id == 0)
            {
                oENTIDADE = new MOD.CES.XGP.modENTIDADE();
                oENTIDADE.CLI_Id = Program._BAL.CLI_Id;
                oENTIDADE.ENT = oItem.Transportadora;
                oItem.Transportadora = oActionOn.PostEntidade(oENTIDADE, ref oReturn).ENT;
            }

            //Cadastrar Produto
            if (oItem.PRD.PRD_Id == 0)
            {
                oItem.PRD = oActionOn.PostProduto(oItem.PRD, ref oReturn);
            }

            return oItem;
        }

    }
}
