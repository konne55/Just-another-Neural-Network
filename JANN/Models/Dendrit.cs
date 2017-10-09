using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JANN
{
    class Dendrit
    {
        private double _weight;
        private Neuron _sendingNeuron;
        private Neuron _recievingNeuron;



        public double Weight { get { return _weight; } }
        public double Value { get { return SendingNeuron.Output * Weight; } set { Value = value; } }
        public Neuron SendingNeuron { get { return _sendingNeuron; } }
        public Neuron RecievingNeuron { get { return _recievingNeuron ; }  }

        private Random r = new Random();

        // Ctor
        public Dendrit(Neuron sn, Neuron rn)
        {
            _weight = r.NextDouble() * 2 - 1;
            _sendingNeuron  = new Neuron();
            _recievingNeuron  = new Neuron();
            _sendingNeuron = sn;
            _recievingNeuron = rn;
        }
        public Dendrit()
        {
            _sendingNeuron = new Neuron();
            _recievingNeuron = new Neuron();
            _weight = r.NextDouble() * 2 - 1;
        }


        public void randomizeWeight(int min, int max)
        {
            _weight = r.NextDouble() * 2 - 1;
        }
        public void setSendingNeuron(Neuron sn)
        {
            _sendingNeuron = sn;
        }
        public void setRecievingNeuron(Neuron rn)
        {
            _recievingNeuron = rn;
        }
    }
}
