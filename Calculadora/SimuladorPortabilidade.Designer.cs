namespace Calculadora
{
    partial class SimuladorPortabilidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimuladorPortabilidade));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbox03 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbPrestacao = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lbSubtrair = new System.Windows.Forms.Label();
            this.lbResultadoFinal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbox011 = new System.Windows.Forms.TextBox();
            this.cbox022 = new System.Windows.Forms.TextBox();
            this.cbox044 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total de prestações consignadas em outras instituições";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIMULADOR PORTABILIDADE SIAPE - 1 PRESTAÇÃO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Margem do site:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(152, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total de prestação(s) + margem do site:";
            // 
            // cbox03
            // 
            this.cbox03.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbox03.FormattingEnabled = true;
            this.cbox03.Items.AddRange(new object[] {
            "70%",
            "80%",
            "100%"});
            this.cbox03.Location = new System.Drawing.Point(410, 195);
            this.cbox03.Name = "cbox03";
            this.cbox03.Size = new System.Drawing.Size(121, 21);
            this.cbox03.TabIndex = 8;
            this.cbox03.Text = "80%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Regra do Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(325, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Resultado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(23, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Subtrair o \"resultado\" do total das parcelas a serem portadas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(245, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Prestação a ser portada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(325, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Resultado:";
            // 
            // lbPrestacao
            // 
            this.lbPrestacao.AutoSize = true;
            this.lbPrestacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrestacao.Location = new System.Drawing.Point(410, 155);
            this.lbPrestacao.Name = "lbPrestacao";
            this.lbPrestacao.Size = new System.Drawing.Size(18, 20);
            this.lbPrestacao.TabIndex = 16;
            this.lbPrestacao.Text = "0";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(410, 233);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(18, 20);
            this.lbResultado.TabIndex = 17;
            this.lbResultado.Text = "0";
            // 
            // lbSubtrair
            // 
            this.lbSubtrair.AutoSize = true;
            this.lbSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtrair.Location = new System.Drawing.Point(410, 272);
            this.lbSubtrair.Name = "lbSubtrair";
            this.lbSubtrair.Size = new System.Drawing.Size(18, 20);
            this.lbSubtrair.TabIndex = 18;
            this.lbSubtrair.Text = "0";
            // 
            // lbResultadoFinal
            // 
            this.lbResultadoFinal.AutoSize = true;
            this.lbResultadoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoFinal.Location = new System.Drawing.Point(410, 351);
            this.lbResultadoFinal.Name = "lbResultadoFinal";
            this.lbResultadoFinal.Size = new System.Drawing.Size(18, 20);
            this.lbResultadoFinal.TabIndex = 19;
            this.lbResultadoFinal.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(613, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Não correntista: 80%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(643, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Correntista: 80%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(587, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(183, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Correntista FOPA: 100%";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(669, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(669, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 40);
            this.button2.TabIndex = 24;
            this.button2.Text = "Zerar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(619, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Gov São Paulo 70%";
            // 
            // cbox011
            // 
            this.cbox011.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox011.Location = new System.Drawing.Point(410, 76);
            this.cbox011.Name = "cbox011";
            this.cbox011.Size = new System.Drawing.Size(121, 26);
            this.cbox011.TabIndex = 26;
            // 
            // cbox022
            // 
            this.cbox022.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox022.Location = new System.Drawing.Point(410, 116);
            this.cbox022.Name = "cbox022";
            this.cbox022.Size = new System.Drawing.Size(121, 26);
            this.cbox022.TabIndex = 27;
            // 
            // cbox044
            // 
            this.cbox044.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox044.Location = new System.Drawing.Point(410, 305);
            this.cbox044.Name = "cbox044";
            this.cbox044.Size = new System.Drawing.Size(121, 26);
            this.cbox044.TabIndex = 28;
            // 
            // SimuladorPortabilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 401);
            this.Controls.Add(this.cbox044);
            this.Controls.Add(this.cbox022);
            this.Controls.Add(this.cbox011);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbResultadoFinal);
            this.Controls.Add(this.lbSubtrair);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbPrestacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbox03);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimuladorPortabilidade";
            this.Text = "SIMULADOR PORTABILIDADE ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbox03;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbPrestacao;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label lbSubtrair;
        private System.Windows.Forms.Label lbResultadoFinal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cbox011;
        private System.Windows.Forms.TextBox cbox022;
        private System.Windows.Forms.TextBox cbox044;
    }
}