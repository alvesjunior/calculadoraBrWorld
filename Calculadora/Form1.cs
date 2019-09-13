using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Calculadora
{
    public partial class SaldoDevedor : Form
    {
        public SaldoDevedor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// objeto do tipo FolderBrowserDialog. Utilizado na interação do sistema
        /// com o usuário na hora da escolha do diretório da base de dados a ser
        /// pesquisada. 
        /// </summary>
        public FolderBrowserDialog folderDialog = new FolderBrowserDialog();

        //Irá armazenar o diretório recebido pelo folderDialog
        public string diretorio;

        //Arquivo de escrita 
        public TextWriter arquivo;





        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double taxa, parcelas, valorParcela,  raiz, vp, vpPositivo, novaTaxa, novaParcela, economiaParcela, economiaTotal;

                taxa = double.Parse(txbTaxaAtual.Text) / 100;
                parcelas = double.Parse(txbParcelasRestantes.Text);
                valorParcela = double.Parse(txbValorParcela.Text);
                raiz = Math.Pow(1 + taxa, parcelas);
                //valorFuturo = valorParcela * (raiz);

                vp = valorPresente(taxa, parcelas, -valorParcela);
                vpPositivo = vp * -1;

                saldoEstimado.Text = "R$ " + Convert.ToString(vpPositivo.ToString("F2"));




                /*   Calculo da nova parce      */
                novaTaxa = double.Parse(tbNovaTaxa.Text) / 100;
                //  tbNovaTaxa.Text = Convert.ToString(novaTaxa);
                novaParcela = CalcNovaParcela(vpPositivo, parcelas, novaTaxa);
                lbnovaParcela.Text = "R$ " + Convert.ToString(novaParcela.ToString("F2"));



                /*   economia por parcela     */
                economiaParcela = valorParcela - novaParcela;
                lbecoParcela.Text = "R$ " + Convert.ToString(economiaParcela.ToString("F2"));



                /*Economia total*/
                economiaTotal = parcelas * economiaParcela;
                lbecoTotal.Text = "R$ " + Convert.ToString(economiaTotal.ToString("F2"));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        static double valorPresente(double rate, double nper, double pmt)
        {
            return pmt / rate * (1 - Math.Pow(1 + rate, -nper));
        }
        static double CalcNovaParcela(double PV, double parcela, double i)
        {
            double PMT = 0;
            PMT = (PV * Math.Pow((1 + i), parcela) * i) / (Math.Pow((1 + i), parcela) - 1);
            return Math.Round(PMT, 2);
        }


        // zerar valores
        private void Button2_Click(object sender, EventArgs e)
        {
            txbTaxaAtual.Text = "0";
            txbParcelasRestantes.Text = "0";
            txbValorParcela.Text = "0";
            saldoEstimado.Text = "0";
            tbNovaTaxa.Text = "0";
            lbnovaParcela.Text = "0";
            lbecoParcela.Text = "0";
            lbecoTotal.Text = "0";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            txtConteudo.Text = "Taxa Atual: " + txbTaxaAtual.Text + "%" + "\r\n" + "Parcelas Restantes: " + txbParcelasRestantes.Text +
                "\r\n" + "Valor da Parcela: R$" + txbValorParcela.Text + "\r\n" + "Saldo Estimado: " + saldoEstimado.Text + "\r\n" +
                "Nova Taxa de Juros: " + tbNovaTaxa.Text + "% \r\n" + "Nova Parcela: " + lbnovaParcela.Text + "\r\n" + "Economia por Parcela: " +
                lbecoParcela.Text + "\r\nEconomia Total: " + lbecoTotal.Text;

            Clipboard.SetText(txtConteudo.Text);

        }

        private void ZerarValoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivo texto | '.txt";
            sfd.ShowDialog();

            if(string.IsNullOrEmpty(sfd.FileName) == false)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        writer.Write(txtConteudo.Text);
                        writer.Flush();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Não foi possivel salvar o arquivo.", "Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
