using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizzeria pizzeria;
            Pizza pizza;
            string op = "";
            
            if(op != "2")
            {
                Console.WriteLine("Qué pizza desea elegir?");
                Console.WriteLine("1) Pizza Argentina");
                Console.WriteLine("2) Pizza Italiana");
                op = Console.ReadLine();    
                if(op == "1")
                {
                    pizzeria = new pizzeriaArgentina();
                    pizza = pizzeria.crearPizza();

                    Console.WriteLine(pizza.Descripcion);
                    Console.ReadKey();
                }
                else if(op == "2")
                {
                    pizzeria = new pizzeriaItaliana();
                    pizza = pizzeria.crearPizza();

                    Console.WriteLine(pizza.Descripcion);
                    Console.ReadKey();
                }
            }
        }
    }
}
