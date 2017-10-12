using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JANN.Models.Base
{
     class Neuron
    {
        static private long id;

        private double _output;
        public double Output{get { return _output; }}


        private ActivationFunction _activationFunction;
        public ActivationFunction ActivationFunction { get { return _activationFunction; } set { _activationFunction = value; } }

        //CTOR
        public Neuron()
        {
            _activationFunction = new ActivationFunction(Models.ActivationFunction.enmFunctionType.Sigmoid);
            id += 1;
        }

        public virtual  double InputCollector()
        {
            return 0;
        }

        public void ReCalculate()
        {
           _output = ActivationFunction.CalculateFunction(InputCollector());
        }

    }
}
