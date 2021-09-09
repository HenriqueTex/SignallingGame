using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignallingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void verifyConfig(int state, int signals, int interations)
        {
            if (state == 0 || signals == 0 || interations == 0)
            {
                MessageBox.Show("Atenção, os campos devem apresentar valor maior que 0",
                           "Aviso",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning,
                           MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Configurações corretas");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                verifyConfig(Convert.ToInt32(txtState.Text), Convert.ToInt32(txtSignals.Text), Convert.ToInt32(txtInterations.Text));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Atenção, Valores de configuração devem ser numeros inteiros",
                           "Aviso",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning,
                           MessageBoxDefaultButton.Button1);
            }

            var states = 3;
            var signals = 3;
            Enviroment ambiente = new Enviroment(states, signals);
            Receiver rec = new Receiver(states, signals);
            Sender send = new Sender(states, signals);

            var state = ambiente.GetEnviromentState();
            var signal = send.SignalSelect(state);
            var escolha = rec.StateSelect(signal);

            if (state == escolha)
            {
                MessageBox.Show("Correto");
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
