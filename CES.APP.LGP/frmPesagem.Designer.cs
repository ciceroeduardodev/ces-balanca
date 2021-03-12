namespace CES.APP.XGP
{
    partial class frmPesagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesagem));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.cmdSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdFechar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMOV_NotaFiscalPeso = new System.Windows.Forms.TextBox();
            this.txtMOV_NotaFiscal = new System.Windows.Forms.TextBox();
            this.mskMOV_Placa_03 = new System.Windows.Forms.MaskedTextBox();
            this.mskMOV_Placa_02 = new System.Windows.Forms.MaskedTextBox();
            this.mskMOV_Placa_01 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNrTicket = new System.Windows.Forms.TextBox();
            this.chkPesagemInterna = new System.Windows.Forms.CheckBox();
            this.cboMOV_Motorista = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMOV_CargaPeso = new System.Windows.Forms.TextBox();
            this.txtMOV_SaidaPeso = new System.Windows.Forms.TextBox();
            this.txtMOV_EntradaPeso = new System.Windows.Forms.TextBox();
            this.txtLeitora = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.optManual = new System.Windows.Forms.RadioButton();
            this.optAutomatico = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMOV_Observacao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPRD_Nome = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMOV_Transportadora = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMOV_Fornecedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMOV_Cliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tmSerial = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip.Size = new System.Drawing.Size(1086, 98);
            this.toolStrip.TabIndex = 3;
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
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 98);
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
            this.groupBox1.Controls.Add(this.txtMOV_NotaFiscalPeso);
            this.groupBox1.Controls.Add(this.txtMOV_NotaFiscal);
            this.groupBox1.Controls.Add(this.mskMOV_Placa_03);
            this.groupBox1.Controls.Add(this.mskMOV_Placa_02);
            this.groupBox1.Controls.Add(this.mskMOV_Placa_01);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNrTicket);
            this.groupBox1.Controls.Add(this.chkPesagemInterna);
            this.groupBox1.Controls.Add(this.cboMOV_Motorista);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 273);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtMOV_NotaFiscalPeso
            // 
            this.txtMOV_NotaFiscalPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMOV_NotaFiscalPeso.Location = new System.Drawing.Point(680, 95);
            this.txtMOV_NotaFiscalPeso.Name = "txtMOV_NotaFiscalPeso";
            this.txtMOV_NotaFiscalPeso.Size = new System.Drawing.Size(236, 35);
            this.txtMOV_NotaFiscalPeso.TabIndex = 4;
            this.txtMOV_NotaFiscalPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMOV_NotaFiscalPeso_KeyPress);
            this.txtMOV_NotaFiscalPeso.Leave += new System.EventHandler(this.txtMOV_NotaFiscalPeso_Leave);
            // 
            // txtMOV_NotaFiscal
            // 
            this.txtMOV_NotaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMOV_NotaFiscal.Location = new System.Drawing.Point(212, 95);
            this.txtMOV_NotaFiscal.MaxLength = 15;
            this.txtMOV_NotaFiscal.Name = "txtMOV_NotaFiscal";
            this.txtMOV_NotaFiscal.Size = new System.Drawing.Size(302, 35);
            this.txtMOV_NotaFiscal.TabIndex = 3;
            this.txtMOV_NotaFiscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMOV_NotaFiscal_KeyPress);
            // 
            // mskMOV_Placa_03
            // 
            this.mskMOV_Placa_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskMOV_Placa_03.Location = new System.Drawing.Point(710, 217);
            this.mskMOV_Placa_03.Mask = "AAA-AAAA";
            this.mskMOV_Placa_03.Name = "mskMOV_Placa_03";
            this.mskMOV_Placa_03.Size = new System.Drawing.Size(205, 35);
            this.mskMOV_Placa_03.TabIndex = 8;
            // 
            // mskMOV_Placa_02
            // 
            this.mskMOV_Placa_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskMOV_Placa_02.Location = new System.Drawing.Point(461, 217);
            this.mskMOV_Placa_02.Mask = "AAA-AAAA";
            this.mskMOV_Placa_02.Name = "mskMOV_Placa_02";
            this.mskMOV_Placa_02.Size = new System.Drawing.Size(205, 35);
            this.mskMOV_Placa_02.TabIndex = 7;
            // 
            // mskMOV_Placa_01
            // 
            this.mskMOV_Placa_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskMOV_Placa_01.Location = new System.Drawing.Point(212, 217);
            this.mskMOV_Placa_01.Mask = "AAA-AAAA";
            this.mskMOV_Placa_01.Name = "mskMOV_Placa_01";
            this.mskMOV_Placa_01.Size = new System.Drawing.Size(205, 35);
            this.mskMOV_Placa_01.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 29);
            this.label10.TabIndex = 15;
            this.label10.Text = "Placa(s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nº Ticket:";
            // 
            // txtNrTicket
            // 
            this.txtNrTicket.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNrTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrTicket.Location = new System.Drawing.Point(212, 35);
            this.txtNrTicket.Name = "txtNrTicket";
            this.txtNrTicket.ReadOnly = true;
            this.txtNrTicket.Size = new System.Drawing.Size(302, 35);
            this.txtNrTicket.TabIndex = 1;
            this.txtNrTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkPesagemInterna
            // 
            this.chkPesagemInterna.AutoSize = true;
            this.chkPesagemInterna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPesagemInterna.Location = new System.Drawing.Point(680, 36);
            this.chkPesagemInterna.Name = "chkPesagemInterna";
            this.chkPesagemInterna.Size = new System.Drawing.Size(236, 33);
            this.chkPesagemInterna.TabIndex = 2;
            this.chkPesagemInterna.Text = "Pesagem Interna";
            this.chkPesagemInterna.UseVisualStyleBackColor = true;
            // 
            // cboMOV_Motorista
            // 
            this.cboMOV_Motorista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMOV_Motorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMOV_Motorista.FormattingEnabled = true;
            this.cboMOV_Motorista.Location = new System.Drawing.Point(212, 155);
            this.cboMOV_Motorista.Name = "cboMOV_Motorista";
            this.cboMOV_Motorista.Size = new System.Drawing.Size(704, 37);
            this.cboMOV_Motorista.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Motorista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peso NF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Nota Fiscal:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMOV_CargaPeso);
            this.groupBox2.Controls.Add(this.txtMOV_SaidaPeso);
            this.groupBox2.Controls.Add(this.txtMOV_EntradaPeso);
            this.groupBox2.Controls.Add(this.txtLeitora);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.optManual);
            this.groupBox2.Controls.Add(this.optAutomatico);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 828);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1086, 200);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // txtMOV_CargaPeso
            // 
            this.txtMOV_CargaPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMOV_CargaPeso.Location = new System.Drawing.Point(709, 44);
            this.txtMOV_CargaPeso.Name = "txtMOV_CargaPeso";
            this.txtMOV_CargaPeso.Size = new System.Drawing.Size(205, 35);
            this.txtMOV_CargaPeso.TabIndex = 6;
            this.txtMOV_CargaPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMOV_SaidaPeso
            // 
            this.txtMOV_SaidaPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMOV_SaidaPeso.Location = new System.Drawing.Point(460, 44);
            this.txtMOV_SaidaPeso.Name = "txtMOV_SaidaPeso";
            this.txtMOV_SaidaPeso.Size = new System.Drawing.Size(205, 35);
            this.txtMOV_SaidaPeso.TabIndex = 5;
            this.txtMOV_SaidaPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMOV_EntradaPeso
            // 
            this.txtMOV_EntradaPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMOV_EntradaPeso.Location = new System.Drawing.Point(211, 44);
            this.txtMOV_EntradaPeso.Name = "txtMOV_EntradaPeso";
            this.txtMOV_EntradaPeso.Size = new System.Drawing.Size(205, 35);
            this.txtMOV_EntradaPeso.TabIndex = 4;
            this.txtMOV_EntradaPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLeitora
            // 
            this.txtLeitora.BackColor = System.Drawing.Color.Black;
            this.txtLeitora.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeitora.Location = new System.Drawing.Point(211, 94);
            this.txtLeitora.Name = "txtLeitora";
            this.txtLeitora.Size = new System.Drawing.Size(455, 89);
            this.txtLeitora.TabIndex = 3;
            this.txtLeitora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLeitora.TextChanged += new System.EventHandler(this.txtLeitora_TextChanged);
            this.txtLeitora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLeitora_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(706, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 29);
            this.label15.TabIndex = 12;
            this.label15.Text = "Líquido:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(455, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 29);
            this.label14.TabIndex = 11;
            this.label14.Text = "Saída:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(207, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 29);
            this.label13.TabIndex = 10;
            this.label13.Text = "Entrada:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 29);
            this.label11.TabIndex = 5;
            this.label11.Text = "Pesos:";
            // 
            // optManual
            // 
            this.optManual.AutoSize = true;
            this.optManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optManual.Location = new System.Drawing.Point(711, 142);
            this.optManual.Name = "optManual";
            this.optManual.Size = new System.Drawing.Size(122, 33);
            this.optManual.TabIndex = 2;
            this.optManual.TabStop = true;
            this.optManual.Text = "Manual";
            this.optManual.UseVisualStyleBackColor = true;
            // 
            // optAutomatico
            // 
            this.optAutomatico.AutoSize = true;
            this.optAutomatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAutomatico.Location = new System.Drawing.Point(711, 103);
            this.optAutomatico.Name = "optAutomatico";
            this.optAutomatico.Size = new System.Drawing.Size(167, 33);
            this.optAutomatico.TabIndex = 1;
            this.optAutomatico.TabStop = true;
            this.optAutomatico.Text = "Automático";
            this.optAutomatico.UseVisualStyleBackColor = true;
            this.optAutomatico.CheckedChanged += new System.EventHandler(this.optAutomatico_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 55);
            this.label12.TabIndex = 3;
            this.label12.Text = "Leitura";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMOV_Observacao);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cboPRD_Nome);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cboMOV_Transportadora);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cboMOV_Fornecedor);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cboMOV_Cliente);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1086, 396);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // txtMOV_Observacao
            // 
            this.txtMOV_Observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMOV_Observacao.Location = new System.Drawing.Point(212, 291);
            this.txtMOV_Observacao.Name = "txtMOV_Observacao";
            this.txtMOV_Observacao.Size = new System.Drawing.Size(704, 35);
            this.txtMOV_Observacao.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Observação:";
            // 
            // cboPRD_Nome
            // 
            this.cboPRD_Nome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPRD_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPRD_Nome.FormattingEnabled = true;
            this.cboPRD_Nome.Location = new System.Drawing.Point(212, 227);
            this.cboPRD_Nome.Name = "cboPRD_Nome";
            this.cboPRD_Nome.Size = new System.Drawing.Size(704, 37);
            this.cboPRD_Nome.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Produto:";
            // 
            // cboMOV_Transportadora
            // 
            this.cboMOV_Transportadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMOV_Transportadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMOV_Transportadora.FormattingEnabled = true;
            this.cboMOV_Transportadora.Location = new System.Drawing.Point(212, 163);
            this.cboMOV_Transportadora.Name = "cboMOV_Transportadora";
            this.cboMOV_Transportadora.Size = new System.Drawing.Size(704, 37);
            this.cboMOV_Transportadora.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Transportadora:";
            // 
            // cboMOV_Fornecedor
            // 
            this.cboMOV_Fornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMOV_Fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMOV_Fornecedor.FormattingEnabled = true;
            this.cboMOV_Fornecedor.Location = new System.Drawing.Point(212, 99);
            this.cboMOV_Fornecedor.Name = "cboMOV_Fornecedor";
            this.cboMOV_Fornecedor.Size = new System.Drawing.Size(704, 37);
            this.cboMOV_Fornecedor.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fornecedor:";
            // 
            // cboMOV_Cliente
            // 
            this.cboMOV_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMOV_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMOV_Cliente.FormattingEnabled = true;
            this.cboMOV_Cliente.Location = new System.Drawing.Point(212, 35);
            this.cboMOV_Cliente.Name = "cboMOV_Cliente";
            this.cboMOV_Cliente.Size = new System.Drawing.Size(704, 37);
            this.cboMOV_Cliente.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cliente:";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Location = new System.Drawing.Point(0, 1028);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1086, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "StatusStrip";
            // 
            // tmSerial
            // 
            this.tmSerial.Interval = 1000;
            this.tmSerial.Tick += new System.EventHandler(this.tmSerial_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 61);
            this.panel1.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(5, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "lblTitulo";
            // 
            // frmPesagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1086, 1050);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmPesagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XGP - Pesagem - Entrada";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPesagem_FormClosed);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton cmdFechar;
        private System.Windows.Forms.ToolStripButton cmdSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMOV_Observacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboPRD_Nome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMOV_Transportadora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMOV_Fornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMOV_Cliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ComboBox cboMOV_Motorista;
        private System.Windows.Forms.RadioButton optManual;
        private System.Windows.Forms.RadioButton optAutomatico;
        private System.Windows.Forms.Timer tmSerial;
        private System.Windows.Forms.CheckBox chkPesagemInterna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNrTicket;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MaskedTextBox mskMOV_Placa_03;
        private System.Windows.Forms.MaskedTextBox mskMOV_Placa_02;
        private System.Windows.Forms.MaskedTextBox mskMOV_Placa_01;
        private System.Windows.Forms.TextBox txtMOV_NotaFiscal;
        private System.Windows.Forms.TextBox txtMOV_NotaFiscalPeso;
        private System.Windows.Forms.TextBox txtLeitora;
        private System.Windows.Forms.TextBox txtMOV_CargaPeso;
        private System.Windows.Forms.TextBox txtMOV_SaidaPeso;
        private System.Windows.Forms.TextBox txtMOV_EntradaPeso;
    }
}