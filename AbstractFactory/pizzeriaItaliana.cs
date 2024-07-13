using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class pizzeriaItaliana : Pizzeria
    {
        public override Pizza crearPizza()
        {
            return new pizzaNapolitana();
        }
    }
}
