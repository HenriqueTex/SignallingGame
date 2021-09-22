using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignallingGame
{
    class Receiver
    {
        private int[,] boxSignal { get; set; }
        public int quantityStates;
        public int quantitySignals;

        public Receiver(int states, int signals, int interations)
        {
            this.quantitySignals = signals;
            this.quantityStates = states;
            this.boxSignal = new int[states+interations,signals+interations];

            for (var i = 0; i<states ; i++)
            {
                for (int j = 1; j < signals; j++)
                {
                    this.boxSignal[i, j] = Convert.ToInt32(j);
                }
            }
        }

        public int StateSelect(int signal)
        {
            Random randNum = new Random();
            return boxSignal[randNum.Next(0,quantitySignals), signal];
        }
        
        public void AddValue(int signal, int escolha)
        {
            quantityStates++;
            boxSignal[quantityStates, signal] = escolha;
        } 
    }
}
