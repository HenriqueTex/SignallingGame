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

        public Sender(int states, int signals)
        {
            this.quantitySignals = signals;
            this.quantityStates = states;
            this.boxStates = new int[states, signals];

            for (var i = 0; i < signals; i++)
            {
                for (var j = 0; i < states; i++)
                {
                    this.boxStates[i, j] = j;
                }
            }
        }

        public int SignalSelect(int signal)
        {
            Random randNum = new Random();
            return boxStates[signal, randNum.Next(0, quantitySignals)];
        }

    }
}
