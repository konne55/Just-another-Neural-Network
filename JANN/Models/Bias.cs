using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JANN.Models.Base;

namespace JANN.Models
{
    class Bias :Neuron 
    {
        public override double InputCollector()
        {
            return 1;
        }
    }
}
