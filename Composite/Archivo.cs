using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Archivo : Componente
    {
        int tamaño;

        public Archivo(string pNombre, int pTamaño) : base(pNombre)
        {
            tamaño = pTamaño;
        }
        public int Tamaño { get { return tamaño; } }

        public override int obtenerTamaño
        {
            get { return tamaño; }
        }

        public override void agregarHijo(Componente c)
        {
            
        }

        public override IList<Componente> obtenerHijos()
        {
            return null;
        }
    }
}
