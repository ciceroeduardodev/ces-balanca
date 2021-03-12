namespace CES.APP.XGP
{
    partial class frmCadastroEntidade
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtENT_Nome = new System.Windows.Forms.TextBox();
            this.txtENT_CPF_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblENT_CPF_CNPJ = new System.Windows.Forms.Label();
            this.lblENT_Nome = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.grpAlterar = new System.Windows.Forms.GroupBox();
            this.lblEntidade = new System.Windows.Forms.Label();
            this.cboENT_Nome = new System.Windows.Forms.ComboBox();
            this.tssSeparador01 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdAlterar = new System.Windows.Forms.ToolStripButton();
            this.cmdExcluir = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 61);
            this.panel1.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(5, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "lblTitulo";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdSalvar,
            this.tssSeparador01,
            this.cmdAlterar,
            this.cmdExcluir,
            this.toolStripSeparator2,
            this.cmdFechar});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(1223, 96);
            this.toolStrip.TabIndex = 9;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtENT_Nome);
            this.groupBox1.Controls.Add(this.txtENT_CPF_CNPJ);
            this.groupBox1.Controls.Add(this.lblENT_CPF_CNPJ);
            this.groupBox1.Controls.Add(this.lblENT_Nome);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1223, 152);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txtENT_Nome
            // 
            this.txtENT_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtENT_Nome.Location = new System.Drawing.Point(212, 95);
            this.txtENT_Nome.MaxLength = 100;
            this.txtENT_Nome.Name = "txtENT_Nome";
            this.txtENT_Nome.Size = new System.Drawing.Size(988, 35);
            this.txtENT_Nome.TabIndex = 21;
            // 
            // txtENT_CPF_CNPJ
            // 
            this.txtENT_CPF_CNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtENT_CPF_CNPJ.Location = new System.Drawing.Point(212, 36);
            this.txtENT_CPF_CNPJ.Mask = "000,000,000-00";
            this.txtENT_CPF_CNPJ.Name = "txtENT_CPF_CNPJ";
            this.txtENT_CPF_CNPJ.Size = new System.Drawing.Size(295, 35);
            this.txtENT_CPF_CNPJ.TabIndex = 18;
            this.txtENT_CPF_CNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblENT_CPF_CNPJ
            // 
            this.lblENT_CPF_CNPJ.AutoSize = true;
            this.lblENT_CPF_CNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblENT_CPF_CNPJ.Location = new System.Drawing.Point(12, 42);
            this.lblENT_CPF_CNPJ.Name = "lblENT_CPF_CNPJ";
            this.lblENT_CPF_CNPJ.Size = new System.Drawing.Size(161, 29);
            this.lblENT_CPF_CNPJ.TabIndex = 15;
            this.lblENT_CPF_CNPJ.Text = "[CPF_CNPJ]";
            // 
            // lblENT_Nome
            // 
            this.lblENT_Nome.AutoSize = true;
            this.lblENT_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblENT_Nome.Location = new System.Drawing.Point(12, 98);
            this.lblENT_Nome.Name = "lblENT_Nome";
            this.lblENT_Nome.Size = new System.Drawing.Size(106, 29);
            this.lblENT_Nome.TabIndex = 0;
            this.lblENT_Nome.Text = "[NOME]";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Location = new System.Drawing.Point(0, 409);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1223, 22);
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "StatusStrip";
            // 
            // grpAlterar
            // 
            this.grpAlterar.Controls.Add(this.lblEntidade);
            this.grpAlterar.Controls.Add(this.cboENT_Nome);
            this.grpAlterar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpAlterar.Location = new System.Drawing.Point(0, 309);
            this.grpAlterar.Name = "grpAlterar";
            this.grpAlterar.Size = new System.Drawing.Size(1223, 100);
            this.grpAlterar.TabIndex = 17;
            this.grpAlterar.TabStop = false;
            this.grpAlterar.Text = "Selecione para alterar";
            // 
            // lblEntidade
            // 
            this.lblEntidade.AutoSize = true;
            this.lblEntidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidade.Location = new System.Drawing.Point(8, 37);
            this.lblEntidade.Name = "lblEntidade";
            this.lblEntidade.Size = new System.Drawing.Size(158, 29);
            this.lblEntidade.TabIndex = 22;
            this.lblEntidade.Text = "[ENTIDADE]";
            // 
            // cboENT_Nome
            // 
            this.cboENT_Nome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboENT_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboENT_Nome.FormattingEnabled = true;
            this.cboENT_Nome.Location = new System.Drawing.Point(212, 34);
            this.cboENT_Nome.Name = "cboENT_Nome";
            this.cboENT_Nome.Size = new System.Drawing.Size(988, 37);
            this.cboENT_Nome.TabIndex = 5;
            this.cboENT_Nome.SelectedIndexChanged += new System.EventHandler(this.cboENT_Nome_SelectedIndexChanged);
            // 
            // tssSeparador01
            // 
            this.tssSeparador01.Name = "tssSeparador01";
            this.tssSeparador01.Size = new System.Drawing.Size(6, 96);
            // 
            // cmdAlterar
            // 
            this.cmdAlterar.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAlterar.Image = global::CES.APP.XGP.Properties.Resources.change;
            this.cmdAlterar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAlterar.Name = "cmdAlterar";
            this.cmdAlterar.Size = new System.Drawing.Size(169, 93);
            this.cmdAlterar.Text = "       ALTERAR       ";
            this.cmdAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAlterar.Click += new System.EventHandler(this.cmdAlterar_Click);
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcluir.Image = global::CES.APP.XGP.Properties.Resources.delete;
            this.cmdExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(161, 93);
            this.cmdExcluir.Text = "       EXCLUIR       ";
            this.cmdExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // frmCadastroEntidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1223, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.grpAlterar);
            this.Controls.Add(this.statusStrip);
            this.Name = "frmCadastroEntidade";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCadastroEntidade_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpAlterar.ResumeLayout(false);
            this.grpAlterar.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtENT_Nome;
        private System.Windows.Forms.MaskedTextBox txtENT_CPF_CNPJ;
        private System.Windows.Forms.Label lblENT_CPF_CNPJ;
        private System.Windows.Forms.Label lblENT_Nome;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.GroupBox grpAlterar;
        private System.Windows.Forms.Label lblEntidade;
        private System.Windows.Forms.ComboBox cboENT_Nome;
        private System.Windows.Forms.ToolStripSeparator tssSeparador01;
        private System.Windows.Forms.ToolStripButton cmdAlterar;
        private System.Windows.Forms.ToolStripButton cmdExcluir;
    }
}