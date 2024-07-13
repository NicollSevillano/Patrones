using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Componente
    {
        string _nombre;
        public Componente(string pNombre) { _nombre = pNombre; }
        public string Nombre { get { return _nombre; } }
        public abstract void agregarHijo(Componente c);
        public abstract IList<Componente> obtenerHijos();
        public abstract int obtenerTamaño {  get; }
    }
}
