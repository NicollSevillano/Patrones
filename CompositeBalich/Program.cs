using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CompositeBalich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IComponente<string> raiz = new Compuesto<string>("root");
            IComponente<string> trabajo = raiz;

            string op = "";
            string dato = "";

            while(op != "6")
            {
                Console.WriteLine($"Estoy en {trabajo.nombre}");
                Console.WriteLine("1: Agregar compuesto");
                Console.WriteLine("2: Añadir componente");
                Console.WriteLine("3: Eliminar");
                Console.WriteLine("4: Buscar");
                Console.WriteLine("5: Mostrar");
                Console.WriteLine("6: Salir");

                op = Console.ReadLine();
                Console.WriteLine("--------------------------");

                if(op == "1")
                {
                    Console.WriteLine("Ingrese un dato:");
                    dato = Console.ReadLine();

                    IComponente<string> componente = new Compuesto<string>(dato);
                    trabajo.Adicionar(componente);
                }
                if(op == "2")
                {
                    Console.WriteLine("Ingrese un dato:");
                    dato = Console.ReadLine();

                    trabajo.Adicionar(new Componente<string>(dato));
                }
                if(op == "3")
                {
                    Console.WriteLine("Ingrese un dato");
                    dato = Console.ReadLine();

                    trabajo.Eliminar(dato);
                }
                if(op == "4")
                {
                    Console.WriteLine("Ingrese un dato");
                    dato = Console.ReadLine();

                    trabajo = raiz.Buscar(dato);
                }
                if(op == "5")
                {
                    Console.WriteLine(raiz.Mostrar(0));
                }
            }
        }
    }
}
