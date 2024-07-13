using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeBalich
{
    public class Compuesto<T> : IComponente<T>
    {
        private List<IComponente<T>> _elementos;
        public Compuesto(T pNombre)
        {
            this.nombre = pNombre;
            _elementos = new List<IComponente<T>>();
        }
        public T nombre { get ; set ; }

        public void Adicionar(IComponente<T> elemento)
        {
            _elementos.Add(elemento);
        }

        public IComponente<T> Buscar(T elemento)
        {
            if (nombre.Equals(elemento))
            {
                return this;
            }
            IComponente<T> encontrado = null;
            foreach (IComponente<T> item in _elementos)
            {
                encontrado = item.Buscar(elemento);
                if(encontrado != null) { break; }
            }
            return encontrado;
        }

        public IComponente<T> Eliminar(T elemento)
        {
            IComponente<T> elementoBuscado = this.Buscar(elemento);
            if(elementoBuscado != null)
            {
                (this as Compuesto<T>)._elementos.Remove(elementoBuscado);
            }
            return this;
        }

        public string Mostrar(int profundidad)
        {
            StringBuilder infoElemento = new StringBuilder(new string('-', profundidad));
            infoElemento.Append($"Compuesto: {nombre} elementos: {_elementos.Count}" + "\r\n");
            foreach (var elemento in _elementos)
            {
                infoElemento.Append(elemento.Mostrar(profundidad + 1));
            }
            return infoElemento.ToString();
        }
    }
}
