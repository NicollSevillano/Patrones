using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Directorio : Componente
    {
        public List<Componente> hijos;
        public Directorio(string pNombre) : base(pNombre)
        {
            hijos = new List<Componente>();
        }

        public override int obtenerTamaño
        {
            get 
            { 
                int i = 0; 
                foreach(var item in hijos)
                {
                    i += item.obtenerTamaño;
                }
                return i; 
            }
        }

        public override void agregarHijo(Componente c)
        {
            hijos.Add(c);
        }

        public override IList<Componente> obtenerHijos()
        {
            return hijos.ToArray();
        }
    }
}
