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

        public Receiver(int states, int signals)
        {
            this.quantitySignals = signals;
            this.quantityStates = states;
            this.boxSignal = new int[states,signals];

            for (var i = 0; i<states ; i++)
            {
                for (int j = 1; i < signals; i++)
                {
                    this.boxSignal[i, j] = Convert.ToInt32(j);
                }
            }
        }

        public int StateSelect(int state)
        {
            Random randNum = new Random();
            return boxSignal[state,randNum.Next(0,quantitySignals)];
        } 
    }
}
