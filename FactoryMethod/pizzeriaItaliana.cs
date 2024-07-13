using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class pizzeriaItaliana : Pizzeria
    {
        public override Pizza crearPizza(string pTipo)
        {
            if (pTipo == "Cancha")
            {
                return new pizzaCancha("Argentina");
            }
            else if (pTipo == "Napo")
            {
                return new pizzaNapolitana("Argentina");
            }
            else { return null; }
        }
    }
}
