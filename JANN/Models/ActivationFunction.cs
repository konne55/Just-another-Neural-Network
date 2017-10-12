using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JANN.Models
{
    class ActivationFunction
    {
        public enum enmFunctionType { Sigmoid, IdentityWithThreshold, Boolean}
        private enmFunctionType _functionType;
        private double _activationThreshold =0 ;

        public double ActivationThreshold
        {
            get { return _activationThreshold; }
            set { _activationThreshold = value; }
        }


        //CTOR
        public ActivationFunction(enmFunctionType ft)
        {
            _functionType = ft;
        }

        //Set
        public void SetFunctionType(enmFunctionType ft)
        {
            _functionType = ft;
        }


        //Calculation
        public double CalculateFunction(double value)
        {
            if(_functionType == enmFunctionType.Sigmoid)
            {
                return 1 / (1 + Math.Pow(Math.E, (-value)));
            }
            else if(_functionType == enmFunctionType.IdentityWithThreshold )
            {
                if (value > _activationThreshold)
                {
                    return value;
                }
                else
                {
                    return 0;
                }
            }
            else if ( _functionType == enmFunctionType.Boolean )
            {
                if (value > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        public double CalculateDerivation(double value)
        {
            if (_functionType == enmFunctionType.Sigmoid)
            {
                return (1 / (1 + Math.Pow(Math.E, (-value))))*(1- (1 / (1 + Math.Pow(Math.E, (-value)))));
            }
            else if (_functionType == enmFunctionType.IdentityWithThreshold)
            {
                if (value > _activationThreshold)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (_functionType == enmFunctionType.Boolean)
            {
                if (value > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
