﻿namespace Calculadora
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
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.copiarTexto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo do Saldo Devedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "TAXA ATUAL:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "PARCELAS RESTANTES:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "VALOR DA PARCELA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "SALDO ESTIMADO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "NOVA TAXA DE JUROS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 298);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "NOVA PARCELA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 336);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "ECONOMIA POR PARCELA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 374);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "ECONOMIA TOTAL:";
            // 
            // txbTaxaAtual
            // 
            this.txbTaxaAtual.Location = new System.Drawing.Point(233, 101);
            this.txbTaxaAtual.Margin = new System.Windows.Forms.Padding(4);
            this.txbTaxaAtual.Name = "txbTaxaAtual";
            this.txbTaxaAtual.Size = new System.Drawing.Size(50, 24);
            this.txbTaxaAtual.TabIndex = 9;
            // 
            // txbParcelasRestantes
            // 
            this.txbParcelasRestantes.Location = new System.Drawing.Point(233, 143);
            this.txbParcelasRestantes.Margin = new System.Windows.Forms.Padding(4);
            this.txbParcelasRestantes.Name = "txbParcelasRestantes";
            this.txbParcelasRestantes.Size = new System.Drawing.Size(148, 24);
            this.txbParcelasRestantes.TabIndex = 10;
            // 
            // txbValorParcela
            // 
            this.txbValorParcela.Location = new System.Drawing.Point(233, 184);
            this.txbValorParcela.Margin = new System.Windows.Forms.Padding(4);
            this.txbValorParcela.Name = "txbValorParcela";
            this.txbValorParcela.Size = new System.Drawing.Size(148, 24);
            this.txbValorParcela.TabIndex = 11;
            this.txbValorParcela.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // tbNovaTaxa
            // 
            this.tbNovaTaxa.Location = new System.Drawing.Point(233, 260);
            this.tbNovaTaxa.Margin = new System.Windows.Forms.Padding(4);
            this.tbNovaTaxa.Name = "tbNovaTaxa";
            this.tbNovaTaxa.Size = new System.Drawing.Size(50, 24);
            this.tbNovaTaxa.TabIndex = 13;
            // 
            // saldoEstimado
            // 
            this.saldoEstimado.AutoSize = true;
            this.saldoEstimado.Location = new System.Drawing.Point(233, 225);
            this.saldoEstimado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saldoEstimado.Name = "saldoEstimado";
            this.saldoEstimado.Size = new System.Drawing.Size(16, 18);
            this.saldoEstimado.TabIndex = 14;
            this.saldoEstimado.Text = "0";
            // 
            // lbnovaParcela
            // 
            this.lbnovaParcela.AutoSize = true;
            this.lbnovaParcela.Location = new System.Drawing.Point(233, 301);
            this.lbnovaParcela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnovaParcela.Name = "lbnovaParcela";
            this.lbnovaParcela.Size = new System.Drawing.Size(16, 18);
            this.lbnovaParcela.TabIndex = 15;
            this.lbnovaParcela.Text = "0";
            // 
            // lbecoParcela
            // 
            this.lbecoParcela.AutoSize = true;
            this.lbecoParcela.Location = new System.Drawing.Point(233, 336);
            this.lbecoParcela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbecoParcela.Name = "lbecoParcela";
            this.lbecoParcela.Size = new System.Drawing.Size(16, 18);
            this.lbecoParcela.TabIndex = 16;
            this.lbecoParcela.Text = "0";
            // 
            // lbecoTotal
            // 
            this.lbecoTotal.AutoSize = true;
            this.lbecoTotal.Location = new System.Drawing.Point(233, 371);
            this.lbecoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbecoTotal.Name = "lbecoTotal";
            this.lbecoTotal.Size = new System.Drawing.Size(16, 18);
            this.lbecoTotal.TabIndex = 17;
            this.lbecoTotal.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(427, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 47);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(427, 99);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 47);
            this.button2.TabIndex = 19;
            this.button2.Text = "Zerar Valores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(290, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 4);
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
            this.label11.Location = new System.Drawing.Point(290, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "%";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(427, 318);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 47);
            this.button3.TabIndex = 24;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(427, 245);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 47);
            this.button4.TabIndex = 25;
            this.button4.Text = "Copiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // copiarTexto
            // 
            this.copiarTexto.Location = new System.Drawing.Point(456, 328);
            this.copiarTexto.Multiline = true;
            this.copiarTexto.Name = "copiarTexto";
            this.copiarTexto.Size = new System.Drawing.Size(103, 37);
            this.copiarTexto.TabIndex = 26;
            // 
            // SaldoDevedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 426);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
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
            this.Controls.Add(this.copiarTexto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaldoDevedor";
            this.Text = "Calculo do saldo devedor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox copiarTexto;
    }
}

