using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class CalculoRefim : Form
    {
        public CalculoRefim()
        {
            InitializeComponent();
        }
        // rate = taxa, nper = quantidade , pmt = valor;
        static double valorPresente(double rate, double nper, double pmt)
        {
            return pmt / rate * (1 - Math.Pow(1 + rate, -nper));
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            double valorParcela, txRefin, qtdParcela, totalEstimado, saldoPortado, economiaTotal, vp, saldoDevedor;

            valorParcela = double.Parse(txtValorParcela.Text);
            txRefin = double.Parse(txtTaxadeJuros.Text) / 100;
           // txRefin =/ 100;
            qtdParcela = double.Parse(txtQtdParcelas.Text) ;

            vp = valorPresente(txRefin, qtdParcela, valorParcela);
            lbTotalEmprestimo.Text = "R$ " + Convert.ToString(vp.ToString("F2"));

         //   textSaldoDevedor.Text = saldoPo;
           // economiaTotal = vp - saldoDevedor;
         //   lbEconomiaTotal.Text = Convert.ToString(economiaTotal.ToString("F2"));

            // total
            // lbEconomiaTotal.Text = Convert.ToString( vp - double.Parse(textSaldoDevedor.Text));



        }
    }
}
