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
        private string _name = "test";

        public string Name
        {
            get { return _name ; }
            set {
                _name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

    }
}
