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
            Start.Enabled = false;


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
            Start.Enabled = true;
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
        private void ResetColor()
        {
            State1.ForeColor = Color.Black;
            State2.ForeColor = Color.Black;
            state3.ForeColor = Color.Black;
            signal1.ForeColor = Color.Black;
            signal2.ForeColor = Color.Black;
            signal3.ForeColor = Color.Black;
        }

        private void Start_Click(object sender, EventArgs e)
        {

            ResetColor();

            var state = ambiente.GetEnviromentState();
            var signal = send.SignalSelect(state);
            var escolha = rec.StateSelect(signal);

            switch (state)
            {

                case 0:
                    State1.ForeColor = Color.Blue;
                    break;
                case 1:
                    State2.ForeColor = Color.Blue;
                    break;
                case 2:
                    state3.ForeColor = Color.Blue;
                    break;
            }

            switch (signal)
            {

                case 0:
                    signal1.ForeColor = Color.Red;
                    break;
                case 1:
                    signal2.ForeColor = Color.Red;
                    break;
                case 2:
                    signal3.ForeColor = Color.Red;
                    break;
            }

            switch (escolha)
            {

                case 0:
                    State1.ForeColor = Color.Green;
                    break;
                case 1:
                    State2.ForeColor = Color.Green;
                    break;
                case 2:
                    state3.ForeColor = Color.Green;
                    break;
            }

            if (state == escolha)
            {
                MessageBox.Show(state.ToString()+" "+ signal + " "+ escolha);
                send.AddValue(state,signal);
                rec.AddValue(signal, escolha);
            }
        }
    }
}
