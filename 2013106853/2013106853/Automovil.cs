using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013106853
{
    class Automovil
    {
        int _numLlantas;
        int _numAsientos;

        public Automovil(int numLlantas, int numAsientos)
        {
            _numLlantas = numLlantas;
            _numAsientos = numAsientos;
            return _numLlantas; _numAsientos;
        }

        string Volante(string volante);
        string Parabrisas(string parabrisas);
        string Propietario(string propietario);
        string TipoCarro(string tipoCarro);
        public int Llantas { get { return _numLlantas; } }

        public int Asientos { get { return _numAsientos; } }
    }
}
