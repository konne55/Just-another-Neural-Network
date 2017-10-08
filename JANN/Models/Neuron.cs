using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JANN
{
    class Neuron
    {
        public double Input
        {
            get
            {
                double sum = 0;
                foreach (Dendrit d in RecievingDendrites)
                {
                    sum = sum + d.Value;
                }
                return sum;
            }
            set { Input = value; }
        }

        public double Output
        {
            get
            {
                return ActivationFunction(Input);
            }
            set { Output = value; }
        }

        public List<Dendrit> RecievingDendrites { get; set; }
        public List<Dendrit> SendingDendrites { get; set; }

        public Neuron()
        {
            RecievingDendrites = new List<Dendrit>();
            SendingDendrites = new List<Dendrit>();
        }

        private double ActivationFunction(double value)
        {
            //TODO - Verschiedene ActivationFunctions anbieten - nicht nur Sigmoid
            return 1/(1+Math.Pow(Math.E,(-value)));
        }
    }
}
