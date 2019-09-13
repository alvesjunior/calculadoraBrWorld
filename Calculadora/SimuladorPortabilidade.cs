using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{
    public partial class SimuladorPortabilidade : Form
    {
        public SimuladorPortabilidade()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // primeira conta
                double totalPrestacao = double.Parse(cbox011.Text) + double.Parse(cbox022.Text);
                lbPrestacao.Text = Convert.ToString(totalPrestacao.ToString("F2"));

                //segunda conta
                double resultadoLabel;
                if (cbox03.Text == "70%")
                {
                    resultadoLabel = 0.70 * double.Parse(lbPrestacao.Text);
                }
                else if (cbox03.Text == "80%")
                {
                    resultadoLabel = 0.80 * double.Parse(lbPrestacao.Text);

                }
                else
                {
                    resultadoLabel = 1 * double.Parse(lbPrestacao.Text);
                }



                lbResultado.Text =   Convert.ToString(resultadoLabel.ToString("F2"));

                // subtrair o resultado do total das parcelas
                double subtrairValor = double.Parse(lbResultado.Text) - double.Parse(cbox011.Text);
                lbSubtrair.Text = Convert.ToString(subtrairValor.ToString("F2"));

                double resultadoFvari = double.Parse(lbSubtrair.Text) + double.Parse(cbox044.Text);
                lbResultadoFinal.Text = Convert.ToString(resultadoFvari.ToString("F2"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

   

        private void Button2_Click(object sender, EventArgs e)
        {
            cbox011.Text = "0";
            cbox022.Text = "0";
            lbPrestacao.Text = "0";
            lbResultado.Text = "0";
            lbSubtrair.Text = "0";
            cbox044.Text = "0";
            lbResultadoFinal.Text = "0";

        }

      
    }
}
