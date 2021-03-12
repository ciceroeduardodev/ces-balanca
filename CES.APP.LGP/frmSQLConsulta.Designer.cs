namespace CES.APP.XGP
{
    partial class frmSQLConsulta
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
            this.txtScript = new System.Windows.Forms.TextBox();
            this.cmdExecutarConsulta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdResultado = new System.Windows.Forms.DataGridView();
            this.cmdExecutarScript = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScript
            // 
            this.txtScript.Location = new System.Drawing.Point(21, 25);
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(776, 26);
            this.txtScript.TabIndex = 0;
            // 
            // cmdExecutarConsulta
            // 
            this.cmdExecutarConsulta.Location = new System.Drawing.Point(21, 67);
            this.cmdExecutarConsulta.Name = "cmdExecutarConsulta";
            this.cmdExecutarConsulta.Size = new System.Drawing.Size(212, 40);
            this.cmdExecutarConsulta.TabIndex = 1;
            this.cmdExecutarConsulta.Text = "Executar Consulta";
            this.cmdExecutarConsulta.UseVisualStyleBackColor = true;
            this.cmdExecutarConsulta.Click += new System.EventHandler(this.cmdExecutarConsulta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdExecutarScript);
            this.groupBox1.Controls.Add(this.txtScript);
            this.groupBox1.Controls.Add(this.cmdExecutarConsulta);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdResultado);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 328);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados";
            // 
            // grdResultado
            // 
            this.grdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdResultado.Location = new System.Drawing.Point(3, 22);
            this.grdResultado.Name = "grdResultado";
            this.grdResultado.RowTemplate.Height = 28;
            this.grdResultado.Size = new System.Drawing.Size(794, 303);
            this.grdResultado.TabIndex = 0;
            // 
            // cmdExecutarScript
            // 
            this.cmdExecutarScript.Location = new System.Drawing.Point(276, 67);
            this.cmdExecutarScript.Name = "cmdExecutarScript";
            this.cmdExecutarScript.Size = new System.Drawing.Size(212, 40);
            this.cmdExecutarScript.TabIndex = 2;
            this.cmdExecutarScript.Text = "Executar Script";
            this.cmdExecutarScript.UseVisualStyleBackColor = true;
            this.cmdExecutarScript.Click += new System.EventHandler(this.cmdExecutarScript_Click);
            // 
            // frmSQLConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSQLConsulta";
            this.Text = "frmSQLConsulta";
            this.Load += new System.EventHandler(this.frmSQLConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.Button cmdExecutarConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdResultado;
        private System.Windows.Forms.Button cmdExecutarScript;
    }
}