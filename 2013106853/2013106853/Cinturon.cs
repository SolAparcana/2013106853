using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013106853
{
    class Cinturon
    {
        private string _numSerie;
        private int _metraje;
        public Cinturon(String numSerie, int metraje)
        {
            _numSerie = numSerie;
            _metraje = metraje;
        }
        public String NumSerie
        {
            get { return _numSerie; }
        }
        public int Metraje
        {
            get { return _metraje; }
        }
    }
}
