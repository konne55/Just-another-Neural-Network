using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JANN
{
    class NeuralNetwork
    {
        public List<Layer> Layers { get; set; }
        public Layer InputLayer { get { return Layers.ElementAt(0); } }
        public Layer OutputLayer { get { return Layers.Last(); } }

        public NeuralNetwork()
        {
            Layers = new List<Layer>();
        }


        public void addLayer(int amountNeurons, int position)
        {
            Layer l = new Layer();
            for (int i = 0; i < amountNeurons ; i++)
            {
                Neuron n = new Neuron();
                l.addNeuron(n);
            }
            if (position < Layers.Count )
            {
                Layers.Insert(position, l);
            }
        }

        public void meshLayers(Layer firstLayer, Layer secondLayer)
        {

            foreach (Neuron sn in firstLayer.Neurons)
            {
                foreach (Neuron rn in secondLayer.Neurons )
                {
                    Dendrit d = new Dendrit(sn, rn);
                    rn.SendingDendrites.Add(d);
                    sn.RecievingDendrites.Add (d);
                }
            }
        }

        public void calculate(double[] inputData)
        {
            if (inputData.Count() ==  InputLayer.Neurons.Count()) 
            {
                for (int i = 0; i < InputLayer.Neurons.Count(); i++)
                {
                    InputLayer.Neurons.ElementAt(i).Input = inputData[i];
                }
            }
        }

    }
}
