using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JANN.Models.Base;

namespace JANN
{
    class Dendrite
    {
        private static long __id;
        private long _id;
        private double _weight;
        private Neuron _inputNeuron;
        private Neuron _outputNeuron;

        public double Weight { get { return _weight; } }
        public double Input { get { return _outputNeuron.Output; } }
        public double Output { get { return Input * _weight; } }

        public Neuron InputNeuron { get { return _inputNeuron ; } }   
        public Neuron OutputNeuron { get { return _outputNeuron  ; }  }

        static private Random r = new Random();

        // Ctor
        public Dendrite(Neuron iN, Neuron oN)
        {
            _id = __id += 1;
            _inputNeuron  = new Neuron();
            _outputNeuron   = new Neuron();
            _inputNeuron  = iN;
            _outputNeuron  = oN;
            RandomizeWeight();
        }
        public Dendrite()
        {
            _id = __id += 1;
            _inputNeuron  = new Neuron();
            _outputNeuron  = new Neuron();
            RandomizeWeight();
        }


        public double OutputRecursivly()
        {
            return _outputNeuron.Output * _weight;
        } // TODO WorkingNeuron kann damit noch nicht umgehen

        public void RandomizeWeight()
        {
            _weight = (r.NextDouble() * 2) - 1;
        }

    }
}
