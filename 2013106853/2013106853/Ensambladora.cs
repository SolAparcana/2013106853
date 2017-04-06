using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013106853
{
    class Ensambladora
    {
        List<Carro> _Carro;

        List<Automovil> _Automovil;
		List<Bus> _Bus;
        public Ensambladora()
        {
            _Carro = new List<Carro>();
            _Automovil = new List<Automovil>();
			_Bus = new List<Bus>();
        }

        public void Agregar(Carro carro)
        {
          
        }

        public void Eliminar(Carro carro)
        {
            
        }

        public bool IniciarPersonalizacion()
        {
            return false;
        }

        public bool FinalizarPersonalizacion()
        {
           
            return false;
        }



    }
}
