using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Calculadora
{
    public partial class InicioForm : Form
    {
        Thread novaThread;
        public InicioForm()
        {
            InitializeComponent();
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //this.Close();

            novaThread = new Thread(novoForm);
            novaThread.SetApartmentState(ApartmentState.MTA);
            novaThread.Start();
        }

        private void novoForm()
        {
            Application.Run(new SimuladorPortabilidade());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            novaThread = new Thread(segundoform);
            novaThread.SetApartmentState(ApartmentState.MTA);
            novaThread.Start();
        }

        private void segundoform()
        {
            Application.Run(new SaldoDevedor());
        }

  
    }
}
