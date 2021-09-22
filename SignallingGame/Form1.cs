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
        Enviroment ambiente;
        Receiver rec;
        Sender send;


        public Form1()
        {
            InitializeComponent();
            txtState.Text= "3";
            txtSignals.Text = "3";
            txtInterations.Text = "100";


        }


        private void verifyConfig(int states, int signals, int interations)
        {
            if (states <= 0 || signals <= 0 || interations <= 0)
            {
                MessageBox.Show("Atenção, os campos devem apresentar valor maior que 0",
                           "Aviso",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning,
                           MessageBoxDefaultButton.Button1);
            }
            else
            {
                initializeWorld(states,signals,interations);
            }
        }



        private void initializeWorld(int states, int signals, int interations)
        {
            ambiente = new Enviroment(states, signals);
            rec = new Receiver(states, signals,interations);
            send = new Sender(states, signals,interations);
        }


        private void saveConfig_Click(object sender, EventArgs e)
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

            
            
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var state = ambiente.GetEnviromentState();
            var signal = send.SignalSelect(state);
            var escolha = rec.StateSelect(signal);

            if (state == escolha)
            {
                MessageBox.Show("Correto");
                send.AddValue(state,signal);
                rec.AddValue(signal, escolha);
            }
        }
    }
}
