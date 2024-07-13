using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Pizza
    {
        protected string descripcion;
        public object Descripcion { get { return descripcion; } }
    }
}
