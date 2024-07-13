using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class pizzaNapolitana : Pizza
    {
        public pizzaNapolitana(string pOrigen)
        {
            _descripcion = "Pizza napolitana";
            _origen = pOrigen;
        }
    }
}
