using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JANN.ViewModels
{
    public class ShellViewModel : Screen 
    {
        NeuralNetwork nn = new NeuralNetwork();
        private double[] _inputValues = new double[] { 1, 1 };

        public double[] Inputvalues
        {
            get { return _inputValues; }
            set { _inputValues = value; }
        }

        private double[] _outputValues;

        public double[] OutputValues
        {
            get { return _outputValues; }
            set { _outputValues = value; }
        }

        public void InitializeNetwork()
        {
            nn.addLayer(2, 0);
            nn.addLayer(2, 1);
            nn.meshLayers(nn.Layers.First(),nn.Layers.Last());
            nn.setNewInputvalues(_inputValues);
            OutputValues = nn.calculate();
        }


    }
}
