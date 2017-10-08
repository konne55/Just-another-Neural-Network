using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JANN
{
    class Dendrit
    {
        public double Weight { get { return Weight; } set { Weight = value; } }
        public double Value { get { return SendingNeuron.Output * Weight; } set { Value = value; } }
        public Neuron SendingNeuron { get { return SendingNeuron; } set { SendingNeuron = value; } }
        public Neuron RecievingNeuron { get { return RecievingNeuron ; } set { RecievingNeuron = value; } }

        private Random r = new Random();
        public Dendrit(Neuron sn, Neuron rn)
        {
            Weight = r.Next(-10,10);
            SendingNeuron = new Neuron();
            SendingNeuron = new Neuron();
            SendingNeuron = sn;
            RecievingNeuron = rn;
        }

        public Dendrit()
        {
            SendingNeuron = new Neuron();
            RecievingNeuron = new Neuron();
            Weight = r.Next(-10,10);
        }

        public void randomizeWeight(int min, int max)
        {
            Weight = r.Next(min, max);
        }

        public void setSendingNeuron(Neuron sn)
        {
            SendingNeuron = sn;
        }

        public void setRecievingNeuron(Neuron rn)
        {
            RecievingNeuron = rn;
        }
    }
}
