namespace CES.APP.XGP
{
    partial class mdiPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiPrincipal));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.cmdEntrada = new System.Windows.Forms.ToolStripButton();
            this.cmdSaida = new System.Windows.Forms.ToolStripButton();
            this.cmdImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdAddPessoaJuridica = new System.Windows.Forms.ToolStripButton();
            this.cmdAddPessoaFisica = new System.Windows.Forms.ToolStripButton();
            this.cmdAddProduto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdUpdPessoaJuridica = new System.Windows.Forms.ToolStripButton();
            this.cmdUpdPessoaFisica = new System.Windows.Forms.ToolStripButton();
            this.cmdUpdProduto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdConfig = new System.Windows.Forms.ToolStripButton();
            this.mnuSQL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdFechar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblNaoConectado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConectado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tmConexao = new System.Windows.Forms.Timer(this.components);
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdEntrada,
            this.cmdSaida,
            this.cmdImprimir,
            this.toolStripSeparator1,
            this.cmdAddPessoaJuridica,
            this.cmdAddPessoaFisica,
            this.cmdAddProduto,
            this.toolStripSeparator4,
            this.cmdUpdPessoaJuridica,
            this.cmdUpdPessoaFisica,
            this.cmdUpdProduto,
            this.toolStripSeparator2,
            this.cmdConfig,
            this.mnuSQL,
            this.toolStripSeparator3,
            this.cmdFechar});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(1678, 96);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // cmdEntrada
            // 
            this.cmdEntrada.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEntrada.Image = global::CES.APP.XGP.Properties.Resources.input;
            this.cmdEntrada.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdEntrada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEntrada.Name = "cmdEntrada";
            this.cmdEntrada.Size = new System.Drawing.Size(146, 93);
            this.cmdEntrada.Text = "    ENTRADA    ";
            this.cmdEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdEntrada.Click += new System.EventHandler(this.cmdEntrada_Click);
            // 
            // cmdSaida
            // 
            this.cmdSaida.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSaida.Image = global::CES.APP.XGP.Properties.Resources.output;
            this.cmdSaida.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdSaida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSaida.Name = "cmdSaida";
            this.cmdSaida.Size = new System.Drawing.Size(124, 93);
            this.cmdSaida.Text = "     SAÍDA     ";
            this.cmdSaida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdSaida.ToolTipText = "SAÍDA";
            this.cmdSaida.Click += new System.EventHandler(this.cmdSaida_Click);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimir.Image = global::CES.APP.XGP.Properties.Resources.printer;
            this.cmdImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(141, 93);
            this.cmdImprimir.Text = "   IMPRIMIR    ";
            this.cmdImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 96);
            // 
            // cmdAddPessoaJuridica
            // 
            this.cmdAddPessoaJuridica.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddPessoaJuridica.Image = global::CES.APP.XGP.Properties.Resources.browser;
            this.cmdAddPessoaJuridica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdAddPessoaJuridica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAddPessoaJuridica.Name = "cmdAddPessoaJuridica";
            this.cmdAddPessoaJuridica.Size = new System.Drawing.Size(176, 93);
            this.cmdAddPessoaJuridica.Text = "PESSOA JURÍDICA";
            this.cmdAddPessoaJuridica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAddPessoaJuridica.Click += new System.EventHandler(this.cmdAddPessoaJuridica_Click);
            // 
            // cmdAddPessoaFisica
            // 
            this.cmdAddPessoaFisica.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddPessoaFisica.Image = global::CES.APP.XGP.Properties.Resources.browser;
            this.cmdAddPessoaFisica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdAddPessoaFisica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAddPessoaFisica.Name = "cmdAddPessoaFisica";
            this.cmdAddPessoaFisica.Size = new System.Drawing.Size(163, 93);
            this.cmdAddPessoaFisica.Text = " PESSOA FÍSICA  ";
            this.cmdAddPessoaFisica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAddPessoaFisica.Click += new System.EventHandler(this.cmdAddPessoaFisica_Click);
            // 
            // cmdAddProduto
            // 
            this.cmdAddProduto.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddProduto.Image = global::CES.APP.XGP.Properties.Resources.browser;
            this.cmdAddProduto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdAddProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAddProduto.Name = "cmdAddProduto";
            this.cmdAddProduto.Size = new System.Drawing.Size(146, 93);
            this.cmdAddProduto.Text = "    PRODUTO    ";
            this.cmdAddProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAddProduto.Click += new System.EventHandler(this.cmdAddProduto_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 96);
            // 
            // cmdUpdPessoaJuridica
            // 
            this.cmdUpdPessoaJuridica.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdPessoaJuridica.Image = global::CES.APP.XGP.Properties.Resources.change;
            this.cmdUpdPessoaJuridica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdUpdPessoaJuridica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdUpdPessoaJuridica.Name = "cmdUpdPessoaJuridica";
            this.cmdUpdPessoaJuridica.Size = new System.Drawing.Size(176, 93);
            this.cmdUpdPessoaJuridica.Text = "PESSOA JURÍDICA";
            this.cmdUpdPessoaJuridica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdUpdPessoaJuridica.Visible = false;
            this.cmdUpdPessoaJuridica.Click += new System.EventHandler(this.cmdUpdPessoaJuridica_Click);
            // 
            // cmdUpdPessoaFisica
            // 
            this.cmdUpdPessoaFisica.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdPessoaFisica.Image = global::CES.APP.XGP.Properties.Resources.change;
            this.cmdUpdPessoaFisica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdUpdPessoaFisica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdUpdPessoaFisica.Name = "cmdUpdPessoaFisica";
            this.cmdUpdPessoaFisica.Size = new System.Drawing.Size(163, 93);
            this.cmdUpdPessoaFisica.Text = " PESSOA FÍSICA  ";
            this.cmdUpdPessoaFisica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdUpdPessoaFisica.Visible = false;
            this.cmdUpdPessoaFisica.Click += new System.EventHandler(this.cmdUpdPessoaFisica_Click);
            // 
            // cmdUpdProduto
            // 
            this.cmdUpdProduto.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdProduto.Image = global::CES.APP.XGP.Properties.Resources.change;
            this.cmdUpdProduto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdUpdProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdUpdProduto.Name = "cmdUpdProduto";
            this.cmdUpdProduto.Size = new System.Drawing.Size(146, 93);
            this.cmdUpdProduto.Text = "    PRODUTO    ";
            this.cmdUpdProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdUpdProduto.Visible = false;
            this.cmdUpdProduto.Click += new System.EventHandler(this.cmdUpdProduto_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 96);
            this.toolStripSeparator2.Visible = false;
            // 
            // cmdConfig
            // 
            this.cmdConfig.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfig.Image = global::CES.APP.XGP.Properties.Resources.menu;
            this.cmdConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdConfig.Name = "cmdConfig";
            this.cmdConfig.Size = new System.Drawing.Size(163, 93);
            this.cmdConfig.Text = "CONFIGURAÇÃO";
            this.cmdConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdConfig.Click += new System.EventHandler(this.cmdConfig_Click);
            // 
            // mnuSQL
            // 
            this.mnuSQL.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuSQL.Image = global::CES.APP.XGP.Properties.Resources.menu;
            this.mnuSQL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSQL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuSQL.Name = "mnuSQL";
            this.mnuSQL.Size = new System.Drawing.Size(135, 93);
            this.mnuSQL.Text = "        SQL         ";
            this.mnuSQL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnuSQL.ToolTipText = "SQL";
            this.mnuSQL.Click += new System.EventHandler(this.mnuSQL_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 96);
            // 
            // cmdFechar
            // 
            this.cmdFechar.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFechar.Image = global::CES.APP.XGP.Properties.Resources.error;
            this.cmdFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdFechar.Name = "cmdFechar";
            this.cmdFechar.Size = new System.Drawing.Size(157, 93);
            this.cmdFechar.Text = "       FECHAR       ";
            this.cmdFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdFechar.Click += new System.EventHandler(this.cmdFechar_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNaoConectado,
            this.lblConectado});
            this.statusStrip.Location = new System.Drawing.Point(0, 667);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1678, 30);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // lblNaoConectado
            // 
            this.lblNaoConectado.Image = global::CES.APP.XGP.Properties.Resources.error;
            this.lblNaoConectado.Name = "lblNaoConectado";
            this.lblNaoConectado.Size = new System.Drawing.Size(169, 25);
            this.lblNaoConectado.Text = "Não conectado...";
            // 
            // lblConectado
            // 
            this.lblConectado.Image = global::CES.APP.XGP.Properties.Resources.success;
            this.lblConectado.Name = "lblConectado";
            this.lblConectado.Size = new System.Drawing.Size(134, 25);
            this.lblConectado.Text = "Conectado...";
            // 
            // tmConexao
            // 
            this.tmConexao.Tick += new System.EventHandler(this.tmConexao_Tick);
            // 
            // mdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 697);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mdiPrincipal";
            this.Text = "XGP - Sistema de Pesagem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;            
            this.Load += new System.EventHandler(this.mdiPrincipal_Load);
            this.Shown += new System.EventHandler(this.mdiPrincipal_Shown);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblConectado;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton cmdImprimir;
        private System.Windows.Forms.ToolStripButton cmdEntrada;
        private System.Windows.Forms.ToolStripButton cmdSaida;
        private System.Windows.Forms.ToolStripStatusLabel lblNaoConectado;
        private System.Windows.Forms.ToolStripButton cmdFechar;
        private System.Windows.Forms.Timer tmConexao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cmdAddPessoaJuridica;
        private System.Windows.Forms.ToolStripButton cmdAddPessoaFisica;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton cmdAddProduto;
        private System.Windows.Forms.ToolStripButton cmdConfig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton mnuSQL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton cmdUpdPessoaJuridica;
        private System.Windows.Forms.ToolStripButton cmdUpdPessoaFisica;
        private System.Windows.Forms.ToolStripButton cmdUpdProduto;
    }
}



