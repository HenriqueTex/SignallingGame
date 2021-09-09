using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignallingGame
{
    class Enviroment
    {
        public List<int> enviromentListStates { get; set; }
        public List<int> enviromentListSignals { get; set; }
        public int enviromentState { get; set; }
        public int quantityStates { get; set; }
        public int quantitySignals { get; set; }

        public Enviroment(int states, int signals)
        {
            this.quantitySignals = signals;
            this.quantityStates = states;
            this.enviromentListStates = new List<int>();
            this.enviromentListSignals = new List<int>();

            for (int i = 0; i < states; i++)
            {
                this.enviromentListStates.Add(i);
            }
            
            for (int i = 0; i < signals; i++)
            {
                this.enviromentListSignals.Add(i);
            }
        }

        public int GetEnviromentState()
        {
            Random randNum = new Random();
            return enviromentListStates[randNum.Next(0, enviromentListStates.Count - 1)];
        }
    }
}
