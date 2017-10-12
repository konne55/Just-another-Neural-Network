using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JANN.Models.Base;
using JANN.Models;

namespace JANN
{
    class NeuralNetwork
    {
        private List<Layer> _layers;

        public List<Layer> Layers
        {
            get { return _layers; }
            set { _layers = value; }
        }

        private List<Neuron> _neurons;
        private List<Dendrite> _dendrites;

        public List<Neuron> Neurons
        {
            get { return _neurons; }
            set { _neurons = value; }
        }
        private Bias _bias;


        public NeuralNetwork()
        {
            _layers = new List<Layer>();
            _neurons = new List<Neuron>();
            _dendrites = new List<Dendrite>();
        }

        public void BuildNet(int[] netconfig)
        {
            for (int i = 0; i < netconfig.Length; i++)
            {
                Layer l = new Layer();
                for (int j = 0; j < netconfig[i]; j++)
                {
                    Neuron n;
                    if (i == 0)
                    {
                         n = new InputNeuron();
                    }
                    else
                    {
                         n = new WorkingNeuron();
                    }
                    l.addNeuron(n);
                    _neurons.Add(n);
                }
                _layers.Add(l);
            }
        }

        private void addLayer(int amountNeurons, int position)
        {
            Layer l = new Layer();
            for (int i = 0; i < amountNeurons ; i++)
            {
                Neuron n = new Neuron();
                l.addNeuron(n);
            }
            if (position <= _layers .Count )
            {
                _layers .Insert(position, l);
            }
        } //wird zurzeit nicht gebraucht

        private void meshLayers(Layer firstLayer, Layer secondLayer) //wird zurzeit nicht gebraucht
        {

            foreach (Neuron sn in firstLayer.Neurons)
            {
                foreach (Neuron rn in secondLayer.Neurons )
                {
                    Dendrite d = new Dendrite(sn, rn);
                }
            }
        } //TODO Dendriten den Neureonen zuweisen

        public void MeshFullNet()
        {
            for (int i = 0; i < _layers.Count()-1; i++)
            {
                if (i == 0)
                {
                    foreach (InputNeuron iN in _layers.First().Neurons)
                    {
                        foreach (WorkingNeuron wN in _layers[1].Neurons)
                        {
                            Dendrite d = new Dendrite(wN, iN);
                            wN.InputDendrites.Add(d);
                            _dendrites.Add(d);
                        }
                    }
                }
                else
                {
                    foreach (WorkingNeuron wNout in _layers[i].Neurons)
                    {
                        foreach (WorkingNeuron wNin in _layers[i+1].Neurons)
                        {
                            Dendrite d = new Dendrite(wNin, wNout);
                            wNin.AddInputDendrite(d);
                            _dendrites.Add(d);
                        }
                    }
                }
            }
        }

        public bool SetNewInputvalues(double[] inputData)
        {
            if (inputData.Count() == _layers.First().Neurons.Count())
            {
                // Inputwerte den Inputneuronen zuweisen
                for (int i = 0; i < _layers.First().Neurons.Count(); i++)
                {
                    InputNeuron iN = (InputNeuron)Layers.First().Neurons.ElementAt(i);
                    iN.Input  = inputData[i];
                }
                return true;
            }
            return false;
        }

        public void Calculate()
        {
            for (int i = 0; i < _layers.Count(); i++)
            {
                foreach (Neuron n in _layers[i].Neurons )
                {
                    n.ReCalculate();
                }
            }
        }

        public double[] GetNetOutput()
        {
            double[] output = new double[_layers.Last().Neurons.Count];
            for (int i = 0; i < output.Count(); i++)
            {
                output[i] = _layers.Last().Neurons[i].Output;
            }
            return output;
        }

        public double[] CalculateRecursively() //TODO funktioniert noch nicht
        {
            double[] outputData = new double[Layers.Last().Neurons.Count()];
            for (int i = 0; i < Layers.Last().Neurons.Count(); i++)
            {
                WorkingNeuron wN = (WorkingNeuron)Layers.Last().Neurons[i];
                
            }
            return outputData;
        }

    }
}
