using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JANN.Models.Base;
using JANN.Models;

namespace JANN.Models
{
    class Layer
    {
        public enum enmLayerType {Inputlayer, Outputlayer, Hiddenlayer}
        static int id;
        ActivationFunction _activationFunction;

        public List<Neuron > Neurons { get; set; }

        public Layer()
        {
            Neurons = new List<Neuron>();
            id += 1;
            _activationFunction = new ActivationFunction(ActivationFunction.enmFunctionType.Sigmoid);
        }

        public void SetActivationFunction(ActivationFunction.enmFunctionType ft)
        {
            foreach (Neuron n in Neurons)
            {
                n.ActivationFunction.SetFunctionType(ft);
            }
        }

        public void addNeuron(Neuron n)
        {
            Neurons.Add(n);
        }


    }
}
