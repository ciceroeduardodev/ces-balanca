namespace CES.APP.XGP
{
    partial class frmCadastroBalanca
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.cmdSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdFechar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBAL_Ticket_Bco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBAL_Ticket_Bcc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBAL_Ticket_To = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBAL_Nome = new System.Windows.Forms.TextBox();
            this.txtCLI_Nome = new System.Windows.Forms.TextBox();
            this.lblCLI_Nome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 61);
            this.panel1.TabIndex = 15;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(5, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(354, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro Balança";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdSalvar,
            this.toolStripSeparator2,
            this.cmdFechar});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(1121, 96);
            this.toolStrip.TabIndex = 14;
            this.toolStrip.Text = "ToolStrip";
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalvar.Image = global::CES.APP.XGP.Properties.Resources.upload;
            this.cmdSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(159, 93);
            this.cmdSalvar.Text = "       SALVAR       ";
            this.cmdSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 96);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 555);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1121, 22);
            this.statusStrip.TabIndex = 17;
            this.statusStrip.Text = "StatusStrip";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBAL_Nome);
            this.groupBox1.Controls.Add(this.txtCLI_Nome);
            this.groupBox1.Controls.Add(this.lblCLI_Nome);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1121, 420);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBAL_Ticket_Bco);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBAL_Ticket_Bcc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBAL_Ticket_To);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1096, 226);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket Online";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "E-mails cópias ocultas:";
            // 
            // txtBAL_Ticket_Bco
            // 
            this.txtBAL_Ticket_Bco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBAL_Ticket_Bco.Location = new System.Drawing.Point(328, 155);
            this.txtBAL_Ticket_Bco.MaxLength = 100;
            this.txtBAL_Ticket_Bco.Name = "txtBAL_Ticket_Bco";
            this.txtBAL_Ticket_Bco.Size = new System.Drawing.Size(648, 35);
            this.txtBAL_Ticket_Bco.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "E-mails cópias:";
            // 
            // txtBAL_Ticket_Bcc
            // 
            this.txtBAL_Ticket_Bcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBAL_Ticket_Bcc.Location = new System.Drawing.Point(328, 101);
            this.txtBAL_Ticket_Bcc.MaxLength = 100;
            this.txtBAL_Ticket_Bcc.Name = "txtBAL_Ticket_Bcc";
            this.txtBAL_Ticket_Bcc.Size = new System.Drawing.Size(648, 35);
            this.txtBAL_Ticket_Bcc.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "E-mails destinatários:";
            // 
            // txtBAL_Ticket_To
            // 
            this.txtBAL_Ticket_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBAL_Ticket_To.Location = new System.Drawing.Point(328, 47);
            this.txtBAL_Ticket_To.MaxLength = 100;
            this.txtBAL_Ticket_To.Name = "txtBAL_Ticket_To";
            this.txtBAL_Ticket_To.Size = new System.Drawing.Size(648, 35);
            this.txtBAL_Ticket_To.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Balança:";
            // 
            // txtBAL_Nome
            // 
            this.txtBAL_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBAL_Nome.Location = new System.Drawing.Point(341, 101);
            this.txtBAL_Nome.MaxLength = 100;
            this.txtBAL_Nome.Name = "txtBAL_Nome";
            this.txtBAL_Nome.Size = new System.Drawing.Size(648, 35);
            this.txtBAL_Nome.TabIndex = 22;
            // 
            // txtCLI_Nome
            // 
            this.txtCLI_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCLI_Nome.Location = new System.Drawing.Point(341, 46);
            this.txtCLI_Nome.MaxLength = 100;
            this.txtCLI_Nome.Name = "txtCLI_Nome";
            this.txtCLI_Nome.Size = new System.Drawing.Size(648, 35);
            this.txtCLI_Nome.TabIndex = 21;
            // 
            // lblCLI_Nome
            // 
            this.lblCLI_Nome.AutoSize = true;
            this.lblCLI_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCLI_Nome.Location = new System.Drawing.Point(221, 47);
            this.lblCLI_Nome.Name = "lblCLI_Nome";
            this.lblCLI_Nome.Size = new System.Drawing.Size(103, 29);
            this.lblCLI_Nome.TabIndex = 0;
            this.lblCLI_Nome.Text = "Cliente:";
            // 
            // frmCadastroBalanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1121, 577);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip);
            this.Name = "frmCadastroBalanca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XGP - Configuração da Balança";
            this.Load += new System.EventHandler(this.frmCadastroBalanca_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton cmdSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cmdFechar;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCLI_Nome;
        private System.Windows.Forms.Label lblCLI_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBAL_Nome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBAL_Ticket_To;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBAL_Ticket_Bco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBAL_Ticket_Bcc;
    }
}