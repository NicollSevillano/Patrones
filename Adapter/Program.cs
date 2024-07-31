using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            PagoA pagoA;
            string op = "";

            if(op != "3")
            {
                Console.WriteLine("Qué tipo de moneda desea?");
                Console.WriteLine("1: USD");
                Console.WriteLine("2: Pesos");
                op = Console.ReadLine();
                if(op == "1")
                {
                    pagoA = new PagoAdapter();
                    pagoA.CambiarMonedaUSD();
                    Console.WriteLine("Proveedor: EEUU");
                    Console.ReadKey();
                }
                if (op == "2")
                {
                    pagoA = new PagoAdapter();
                    pagoA.CambiarMonedaPesos();
                    Console.WriteLine("Proveedor: Pesos");
                    Console.ReadKey();
                }
            }
        }
    }
}
