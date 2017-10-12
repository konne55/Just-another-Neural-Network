using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JANN.Models.Base;

namespace JANN.Models
{
    class WorkingNeuron : Neuron
    {
        private List<Dendrite> _inputDendrites;
        public List<Dendrite> InputDendrites

        {
            get { return _inputDendrites; }
        }

        public WorkingNeuron()
        {
            _inputDendrites = new List<Dendrite>();
        }
        public override  double InputCollector()
        {
            double sum = 0;
            foreach (Dendrite d in _inputDendrites)
            {
                sum += d.Output;
            }
            return ActivationFunction.CalculateFunction(sum);
        }

        public void AddInputDendrite(Dendrite d)
        {
            _inputDendrites.Add(d);
        }



    }
}
