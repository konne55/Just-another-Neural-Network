using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JANN.Models.Base;

namespace JANN.Models
{
    class InputNeuron : Neuron 
    {
        private string _descName;
        public string DescriptionName
        {
            get { return _descName; }
            set { _descName = value; }
        }

        private double _input;
        public double Input
        {
            get { return _input; }
            set { _input = value; }
        }

        public InputNeuron()
        {
            ActivationFunction = new ActivationFunction(ActivationFunction.enmFunctionType.IdentityWithThreshold);
            ActivationFunction.ActivationThreshold = 0;
        }

        public override double InputCollector()
        {
            return _input;
        }

    }
}
