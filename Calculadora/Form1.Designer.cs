namespace Calculadora
{
    partial class SaldoDevedor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaldoDevedor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbTaxaAtual = new System.Windows.Forms.TextBox();
            this.txbParcelasRestantes = new System.Windows.Forms.TextBox();
            this.txbValorParcela = new System.Windows.Forms.TextBox();
            this.tbNovaTaxa = new System.Windows.Forms.TextBox();
            this.saldoEstimado = new System.Windows.Forms.Label();
            this.lbnovaParcela = new System.Windows.Forms.Label();
            this.lbecoParcela = new System.Windows.Forms.Label();
            this.lbecoTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zerarValoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnRefin = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtqqtdParcelas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbTotalEmprestimo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbEconomiaTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo do Saldo Devedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "TAXA ATUAL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "PARCELAS RESTANTES:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "VALOR DA PARCELA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 279);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "SALDO ESTIMADO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 317);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "NOVA TAXA DE JUROS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 355);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "NOVA PARCELA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 393);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "ECONOMIA POR PARCELA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(127, 431);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "ECONOMIA TOTAL:";
            // 
            // txbTaxaAtual
            // 
            this.txbTaxaAtual.Location = new System.Drawing.Point(315, 160);
            this.txbTaxaAtual.Margin = new System.Windows.Forms.Padding(4);
            this.txbTaxaAtual.Name = "txbTaxaAtual";
            this.txbTaxaAtual.Size = new System.Drawing.Size(50, 29);
            this.txbTaxaAtual.TabIndex = 9;
            // 
            // txbParcelasRestantes
            // 
            this.txbParcelasRestantes.Location = new System.Drawing.Point(315, 200);
            this.txbParcelasRestantes.Margin = new System.Windows.Forms.Padding(4);
            this.txbParcelasRestantes.Name = "txbParcelasRestantes";
            this.txbParcelasRestantes.Size = new System.Drawing.Size(148, 29);
            this.txbParcelasRestantes.TabIndex = 10;
            // 
            // txbValorParcela
            // 
            this.txbValorParcela.Location = new System.Drawing.Point(315, 236);
            this.txbValorParcela.Margin = new System.Windows.Forms.Padding(4);
            this.txbValorParcela.Name = "txbValorParcela";
            this.txbValorParcela.Size = new System.Drawing.Size(148, 29);
            this.txbValorParcela.TabIndex = 11;
            // 
            // tbNovaTaxa
            // 
            this.tbNovaTaxa.Location = new System.Drawing.Point(315, 312);
            this.tbNovaTaxa.Margin = new System.Windows.Forms.Padding(4);
            this.tbNovaTaxa.Name = "tbNovaTaxa";
            this.tbNovaTaxa.Size = new System.Drawing.Size(50, 29);
            this.tbNovaTaxa.TabIndex = 13;
            // 
            // saldoEstimado
            // 
            this.saldoEstimado.AutoSize = true;
            this.saldoEstimado.Location = new System.Drawing.Point(315, 279);
            this.saldoEstimado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saldoEstimado.Name = "saldoEstimado";
            this.saldoEstimado.Size = new System.Drawing.Size(20, 24);
            this.saldoEstimado.TabIndex = 14;
            this.saldoEstimado.Text = "0";
            // 
            // lbnovaParcela
            // 
            this.lbnovaParcela.AutoSize = true;
            this.lbnovaParcela.Location = new System.Drawing.Point(315, 355);
            this.lbnovaParcela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnovaParcela.Name = "lbnovaParcela";
            this.lbnovaParcela.Size = new System.Drawing.Size(20, 24);
            this.lbnovaParcela.TabIndex = 15;
            this.lbnovaParcela.Text = "0";
            // 
            // lbecoParcela
            // 
            this.lbecoParcela.AutoSize = true;
            this.lbecoParcela.Location = new System.Drawing.Point(315, 393);
            this.lbecoParcela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbecoParcela.Name = "lbecoParcela";
            this.lbecoParcela.Size = new System.Drawing.Size(20, 24);
            this.lbecoParcela.TabIndex = 16;
            this.lbecoParcela.Text = "0";
            // 
            // lbecoTotal
            // 
            this.lbecoTotal.AutoSize = true;
            this.lbecoTotal.Location = new System.Drawing.Point(315, 431);
            this.lbecoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbecoTotal.Name = "lbecoTotal";
            this.lbecoTotal.Size = new System.Drawing.Size(20, 24);
            this.lbecoTotal.TabIndex = 17;
            this.lbecoTotal.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(496, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 47);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(377, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 29);
            this.label10.TabIndex = 21;
            this.label10.Text = "%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(377, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 29);
            this.label11.TabIndex = 23;
            this.label11.Text = "%";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(496, 392);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 47);
            this.button3.TabIndex = 24;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(496, 319);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 47);
            this.button4.TabIndex = 25;
            this.button4.Text = "Copiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(527, 392);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(103, 37);
            this.txtConteudo.TabIndex = 26;
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.calcularToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.zerarValoresToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.salvarToolStripMenuItem.Text = "Salvar Como";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.SalvarToolStripMenuItem_Click);
            // 
            // calcularToolStripMenuItem
            // 
            this.calcularToolStripMenuItem.Name = "calcularToolStripMenuItem";
            this.calcularToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.calcularToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.calcularToolStripMenuItem.Text = "Calcular";
            this.calcularToolStripMenuItem.Click += new System.EventHandler(this.CalcularToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.CopiarToolStripMenuItem_Click);
            // 
            // zerarValoresToolStripMenuItem
            // 
            this.zerarValoresToolStripMenuItem.Name = "zerarValoresToolStripMenuItem";
            this.zerarValoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zerarValoresToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.zerarValoresToolStripMenuItem.Text = "Sair";
            this.zerarValoresToolStripMenuItem.Click += new System.EventHandler(this.ZerarValoresToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnRefin
            // 
            this.btnRefin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefin.Location = new System.Drawing.Point(496, 165);
            this.btnRefin.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefin.Name = "btnRefin";
            this.btnRefin.Size = new System.Drawing.Size(168, 47);
            this.btnRefin.TabIndex = 28;
            this.btnRefin.Text = "Refin";
            this.btnRefin.UseVisualStyleBackColor = true;
            this.btnRefin.Visible = false;
            this.btnRefin.Click += new System.EventHandler(this.btnRefin_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(85, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 24);
            this.label12.TabIndex = 29;
            this.label12.Text = "Quantidade de Parcelas:";
            // 
            // txtqqtdParcelas
            // 
            this.txtqqtdParcelas.Location = new System.Drawing.Point(305, 10);
            this.txtqqtdParcelas.Margin = new System.Windows.Forms.Padding(4);
            this.txtqqtdParcelas.Name = "txtqqtdParcelas";
            this.txtqqtdParcelas.Size = new System.Drawing.Size(50, 29);
            this.txtqqtdParcelas.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(91, 50);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 24);
            this.label13.TabIndex = 31;
            this.label13.Text = "Valor Total Emprestimo:";
            // 
            // lbTotalEmprestimo
            // 
            this.lbTotalEmprestimo.AutoSize = true;
            this.lbTotalEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalEmprestimo.Location = new System.Drawing.Point(305, 49);
            this.lbTotalEmprestimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalEmprestimo.Name = "lbTotalEmprestimo";
            this.lbTotalEmprestimo.Size = new System.Drawing.Size(23, 25);
            this.lbTotalEmprestimo.TabIndex = 41;
            this.lbTotalEmprestimo.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 92);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(277, 24);
            this.label15.TabIndex = 44;
            this.label15.Text = "Liquido Liberado para o Cliente:";
            // 
            // lbEconomiaTotal
            // 
            this.lbEconomiaTotal.AutoSize = true;
            this.lbEconomiaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEconomiaTotal.Location = new System.Drawing.Point(305, 91);
            this.lbEconomiaTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEconomiaTotal.Name = "lbEconomiaTotal";
            this.lbEconomiaTotal.Size = new System.Drawing.Size(23, 25);
            this.lbEconomiaTotal.TabIndex = 45;
            this.lbEconomiaTotal.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.lbEconomiaTotal);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lbTotalEmprestimo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtqqtdParcelas);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(10, 454);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // SaldoDevedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 621);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbecoTotal);
            this.Controls.Add(this.lbecoParcela);
            this.Controls.Add(this.lbnovaParcela);
            this.Controls.Add(this.saldoEstimado);
            this.Controls.Add(this.tbNovaTaxa);
            this.Controls.Add(this.txbValorParcela);
            this.Controls.Add(this.txbParcelasRestantes);
            this.Controls.Add(this.txbTaxaAtual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtConteudo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaldoDevedor";
            this.Text = "Calculo do saldo devedor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbTaxaAtual;
        private System.Windows.Forms.TextBox txbParcelasRestantes;
        private System.Windows.Forms.TextBox txbValorParcela;
        private System.Windows.Forms.TextBox tbNovaTaxa;
        private System.Windows.Forms.Label saldoEstimado;
        private System.Windows.Forms.Label lbnovaParcela;
        private System.Windows.Forms.Label lbecoParcela;
        private System.Windows.Forms.Label lbecoTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zerarValoresToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnRefin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtqqtdParcelas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbTotalEmprestimo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbEconomiaTotal;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

