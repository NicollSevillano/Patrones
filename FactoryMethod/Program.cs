using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
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
                Console.WriteLine("Selecciona la carta que desee");
                Console.WriteLine("1) Pizzeria Argentina");
                Console.WriteLine("2) Pizzeria Italiana");
                op = Console.ReadLine();
               
                if(op == "1")
                {
                    pizzeria = new pizzeriaArgentina();
                    pizza = pizzeria.crearPizza("Cancha");
                    pizza.Render();
                    pizza = pizzeria.crearPizza("Napo");
                    pizza.Render();
                    Console.ReadKey();
                }
                else if(op == "2")
                {
                    pizzeria = new pizzeriaItaliana();
                    pizza = pizzeria.crearPizza("Cancha");
                    pizza.Render();
                    pizza = pizzeria.crearPizza("Napo");
                    pizza.Render();
                    Console.ReadKey();
                }
            }
        }
    }
}
