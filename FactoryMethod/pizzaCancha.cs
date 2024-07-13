using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class pizzaCancha : Pizza
    {
        public pizzaCancha(string pOrigen)
        {
            _descripcion = "Pizza de cancha";
            _origen = pOrigen;
        }
    }
}
