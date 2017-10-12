using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace JANN.ViewModels
{
    public class ShellViewModel : Screen 
    {
        NeuralNetwork nn;
        private double[] _inputValues = new double[] { 1, 1 };
        private int[] _netconfig = new int[] { 2, 1, 2 };
        public ObservableCollection<double> Output { get; private set; }

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
            double[] output;
            nn = new NeuralNetwork();
            Output = new ObservableCollection<double>();
            nn.BuildNet(_netconfig);
            nn.MeshFullNet();
            nn.SetNewInputvalues(_inputValues);
            nn.Calculate();
            output = nn.GetNetOutput();

            for (int i = 0; i < output.Length ; i++)
            {
                Output.Add(output[i]);
            }

        }


    }
}
