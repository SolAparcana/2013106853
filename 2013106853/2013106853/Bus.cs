using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013106853
{
    class Bus
    {
        int _numAsientos;
        private TipoBus _TipoBus;
        public Automovil(int numAsientos)
        {
            _numAsientos= numAsientos;
        }
        
        public TipoBus TipoBus { get { return _TipoBus; } }
    }
}
    

