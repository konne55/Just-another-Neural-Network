using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JANN
{
     class Neuron
    {
        private double _input;
        private double _output;
        private List<Dendrit> _recievingDendrites;
        private List<Dendrit> _sendingDendrites;

        public List<Dendrit> RecievingDendrites { get { return _recievingDendrites; } }
        public List<Dendrit> SendingDendrites { get { return _sendingDendrites; } }

        public double Input
        {
            get
            {
                double sum = 0;
                if (RecievingDendrites.Count() > 0) { 
                    foreach (Dendrit d in RecievingDendrites)
                    {
                        sum = sum + d.Value;
                    }
                    return sum;
                }
                else
                {
                    return _input;
                }
            }
            set { _input = value; }
        }

        public double Output
        {
            get
            {
                return ActivationFunction(Input);
            }
            set { _output = value; }
        }


        public Neuron()
        {
            _recievingDendrites = new List<Dendrit>();
            _sendingDendrites = new List<Dendrit>();
        }

        public void AddSendingDendrite(Dendrit d)
        {
            _sendingDendrites.Add(d);
        }
        public void AddRecievingDendrite(Dendrit d)
        {
            _recievingDendrites.Add(d);
        }

        private double ActivationFunction(double value)
        {
            //TODO - Verschiedene ActivationFunctions anbieten - nicht nur Sigmoid
            return 1/(1+Math.Pow(Math.E,(-value)));
        }
    }
}
