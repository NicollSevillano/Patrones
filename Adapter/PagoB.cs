using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PagoB
    {
        bool monedaUSD;
        bool monedaPesos;

        public void Pesos()
        {
            if (!monedaUSD)
            {
                Console.WriteLine("Está pagando en pesos");
            }
        }
        public void USD()
        {
            if (!monedaPesos)
            {
                Console.WriteLine("Está pagando en USD, el dólar actual está $1000 pesos");
            }
        }
    }
}
