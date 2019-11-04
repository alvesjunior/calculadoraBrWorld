namespace Calculadora
{
    partial class CalculoRefim
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbEconomiaTotal = new System.Windows.Forms.Label();
            this.lbTotalEmprestimo = new System.Windows.Forms.Label();
            this.txtQtdParcelas = new System.Windows.Forms.TextBox();
            this.txtTaxadeJuros = new System.Windows.Forms.TextBox();
            this.txtValorParcela = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textSaldoDevedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(387, 416);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 47);
            this.button1.TabIndex = 44;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbEconomiaTotal
            // 
            this.lbEconomiaTotal.AutoSize = true;
            this.lbEconomiaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEconomiaTotal.Location = new System.Drawing.Point(401, 349);
            this.lbEconomiaTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEconomiaTotal.Name = "lbEconomiaTotal";
            this.lbEconomiaTotal.Size = new System.Drawing.Size(23, 25);
            this.lbEconomiaTotal.TabIndex = 43;
            this.lbEconomiaTotal.Text = "0";
            // 
            // lbTotalEmprestimo
            // 
            this.lbTotalEmprestimo.AutoSize = true;
            this.lbTotalEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalEmprestimo.Location = new System.Drawing.Point(401, 278);
            this.lbTotalEmprestimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalEmprestimo.Name = "lbTotalEmprestimo";
            this.lbTotalEmprestimo.Size = new System.Drawing.Size(23, 25);
            this.lbTotalEmprestimo.TabIndex = 40;
            this.lbTotalEmprestimo.Text = "0";
            // 
            // txtQtdParcelas
            // 
            this.txtQtdParcelas.Location = new System.Drawing.Point(406, 238);
            this.txtQtdParcelas.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdParcelas.Name = "txtQtdParcelas";
            this.txtQtdParcelas.Size = new System.Drawing.Size(148, 22);
            this.txtQtdParcelas.TabIndex = 38;
            // 
            // txtTaxadeJuros
            // 
            this.txtTaxadeJuros.Location = new System.Drawing.Point(406, 192);
            this.txtTaxadeJuros.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaxadeJuros.Name = "txtTaxadeJuros";
            this.txtTaxadeJuros.Size = new System.Drawing.Size(148, 22);
            this.txtTaxadeJuros.TabIndex = 37;
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.Location = new System.Drawing.Point(406, 146);
            this.txtValorParcela.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.Size = new System.Drawing.Size(148, 22);
            this.txtValorParcela.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(80, 350);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(272, 24);
            this.label9.TabIndex = 35;
            this.label9.Text = "Liquido Liberado para o Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Valor Total Emprestimo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Qtde Parcelas Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Taxa de Juros Refin Portabilidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Valor da Parcela:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cálculo Liberação Refin";
            // 
            // textSaldoDevedor
            // 
            this.textSaldoDevedor.Location = new System.Drawing.Point(406, 103);
            this.textSaldoDevedor.Margin = new System.Windows.Forms.Padding(4);
            this.textSaldoDevedor.Name = "textSaldoDevedor";
            this.textSaldoDevedor.Size = new System.Drawing.Size(148, 22);
            this.textSaldoDevedor.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(217, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "Saldo Devedor";
            // 
            // CalculoRefim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 512);
            this.Controls.Add(this.textSaldoDevedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbEconomiaTotal);
            this.Controls.Add(this.lbTotalEmprestimo);
            this.Controls.Add(this.txtQtdParcelas);
            this.Controls.Add(this.txtTaxadeJuros);
            this.Controls.Add(this.txtValorParcela);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalculoRefim";
            this.Text = "CalculoRefim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbEconomiaTotal;
        private System.Windows.Forms.Label lbTotalEmprestimo;
        private System.Windows.Forms.TextBox txtQtdParcelas;
        private System.Windows.Forms.TextBox txtTaxadeJuros;
        private System.Windows.Forms.TextBox txtValorParcela;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSaldoDevedor;
        private System.Windows.Forms.Label label7;
    }
}