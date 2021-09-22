using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignallingGame
{
    class Sender
    {
        private int[,] boxStates { get; set; }
        public int quantityStates;
        public int quantitySignals;

        public Sender(int states, int signals,int interations)
        {
            this.quantitySignals = signals;
            this.quantityStates = states;
            this.boxStates = new int[states+interations, signals+interations];

            for (var i = 0; i < states; i++)
            {
                for (var j = 0; j < signals; j++)
                {
                    this.boxStates[i, j] = j;
                }
            }
        }

        public int SignalSelect(int estate)
        {
            Random randNum = new Random();
            return boxStates[estate, randNum.Next(0, quantitySignals)];
        }

        public void AddValue(int state,int signal)
        {
            quantitySignals++;
            boxStates[state, quantitySignals] = signal;
        }

    }
}
