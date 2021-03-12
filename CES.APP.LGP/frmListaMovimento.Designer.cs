namespace CES.APP.XGP
{
    partial class frmListaMovimento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdMovimento = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.MOV_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOV_Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRD_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOV_Tipo_Descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOV_Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transportadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOV_EntradaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOV_EntradaPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOV_SaidaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOV_SaidaPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOV_CargaPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovimento)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdMovimento);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1453, 631);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // grdMovimento
            // 
            this.grdMovimento.AllowUserToAddRows = false;
            this.grdMovimento.AllowUserToDeleteRows = false;
            this.grdMovimento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMovimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMovimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMovimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MOV_Id,
            this.MOV_Ticket,
            this.PRD_Nome,
            this.MOV_Tipo_Descr,
            this.MOV_Placa,
            this.Motorista,
            this.Cliente,
            this.Fornecedor,
            this.Transportadora,
            this.MOV_EntradaData,
            this.MOV_EntradaPeso,
            this.MOV_SaidaData,
            this.MOV_SaidaPeso,
            this.MOV_CargaPeso});
            this.grdMovimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMovimento.Location = new System.Drawing.Point(3, 22);
            this.grdMovimento.Name = "grdMovimento";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMovimento.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdMovimento.RowHeadersVisible = false;
            this.grdMovimento.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdMovimento.RowTemplate.Height = 40;
            this.grdMovimento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMovimento.Size = new System.Drawing.Size(1447, 606);
            this.grdMovimento.TabIndex = 0;
            this.grdMovimento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMovimento_CellDoubleClick);
            this.grdMovimento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdMovimento_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1453, 61);
            this.panel1.TabIndex = 16;
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
            // MOV_Id
            // 
            this.MOV_Id.DataPropertyName = "MOV_Id";
            this.MOV_Id.HeaderText = "Código";
            this.MOV_Id.Name = "MOV_Id";
            this.MOV_Id.ReadOnly = true;
            this.MOV_Id.Visible = false;
            // 
            // MOV_Ticket
            // 
            this.MOV_Ticket.DataPropertyName = "MOV_Ticket";
            this.MOV_Ticket.HeaderText = "Ticket";
            this.MOV_Ticket.Name = "MOV_Ticket";
            this.MOV_Ticket.ReadOnly = true;
            this.MOV_Ticket.Width = 150;
            // 
            // PRD_Nome
            // 
            this.PRD_Nome.DataPropertyName = "PRD_Nome";
            this.PRD_Nome.HeaderText = "Produto";
            this.PRD_Nome.Name = "PRD_Nome";
            this.PRD_Nome.ReadOnly = true;
            // 
            // MOV_Tipo_Descr
            // 
            this.MOV_Tipo_Descr.DataPropertyName = "MOV_Tipo_Descr";
            this.MOV_Tipo_Descr.HeaderText = "Tipo";
            this.MOV_Tipo_Descr.Name = "MOV_Tipo_Descr";
            this.MOV_Tipo_Descr.ReadOnly = true;
            // 
            // MOV_Placa
            // 
            this.MOV_Placa.DataPropertyName = "MOV_Placa";
            this.MOV_Placa.HeaderText = "Placa";
            this.MOV_Placa.Name = "MOV_Placa";
            this.MOV_Placa.ReadOnly = true;
            this.MOV_Placa.Width = 200;
            // 
            // Motorista
            // 
            this.Motorista.DataPropertyName = "Motorista";
            this.Motorista.HeaderText = "Motorista";
            this.Motorista.Name = "Motorista";
            this.Motorista.ReadOnly = true;
            this.Motorista.Width = 250;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 250;
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "Fornecedor";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            this.Fornecedor.Width = 250;
            // 
            // Transportadora
            // 
            this.Transportadora.DataPropertyName = "Transportadora";
            this.Transportadora.HeaderText = "Transportadora";
            this.Transportadora.Name = "Transportadora";
            this.Transportadora.ReadOnly = true;
            this.Transportadora.Width = 250;
            // 
            // MOV_EntradaData
            // 
            this.MOV_EntradaData.DataPropertyName = "MOV_EntradaData";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MOV_EntradaData.DefaultCellStyle = dataGridViewCellStyle2;
            this.MOV_EntradaData.HeaderText = "Data Entrada";
            this.MOV_EntradaData.Name = "MOV_EntradaData";
            this.MOV_EntradaData.ReadOnly = true;
            this.MOV_EntradaData.Width = 150;
            // 
            // MOV_EntradaPeso
            // 
            this.MOV_EntradaPeso.DataPropertyName = "MOV_EntradaPeso";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.MOV_EntradaPeso.DefaultCellStyle = dataGridViewCellStyle3;
            this.MOV_EntradaPeso.HeaderText = "Peso Entrada";
            this.MOV_EntradaPeso.Name = "MOV_EntradaPeso";
            this.MOV_EntradaPeso.ReadOnly = true;
            this.MOV_EntradaPeso.Width = 150;
            // 
            // MOV_SaidaData
            // 
            this.MOV_SaidaData.DataPropertyName = "MOV_SaidaData";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MOV_SaidaData.DefaultCellStyle = dataGridViewCellStyle4;
            this.MOV_SaidaData.HeaderText = "Data Saída";
            this.MOV_SaidaData.Name = "MOV_SaidaData";
            this.MOV_SaidaData.ReadOnly = true;
            this.MOV_SaidaData.Width = 150;
            // 
            // MOV_SaidaPeso
            // 
            this.MOV_SaidaPeso.DataPropertyName = "MOV_SaidaPeso";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.MOV_SaidaPeso.DefaultCellStyle = dataGridViewCellStyle5;
            this.MOV_SaidaPeso.HeaderText = "Peso Saída";
            this.MOV_SaidaPeso.Name = "MOV_SaidaPeso";
            this.MOV_SaidaPeso.ReadOnly = true;
            this.MOV_SaidaPeso.Width = 150;
            // 
            // MOV_CargaPeso
            // 
            this.MOV_CargaPeso.DataPropertyName = "MOV_CargaPeso";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.MOV_CargaPeso.DefaultCellStyle = dataGridViewCellStyle6;
            this.MOV_CargaPeso.HeaderText = "Peso Carga";
            this.MOV_CargaPeso.Name = "MOV_CargaPeso";
            this.MOV_CargaPeso.ReadOnly = true;
            this.MOV_CargaPeso.Width = 150;
            // 
            // frmListaMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1453, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmListaMovimento";
            this.Text = "frmListaMovimento";
            this.Load += new System.EventHandler(this.frmListaMovimento_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMovimento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdMovimento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOV_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOV_Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRD_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOV_Tipo_Descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOV_Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transportadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOV_EntradaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOV_EntradaPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOV_SaidaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOV_SaidaPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOV_CargaPeso;
    }
}