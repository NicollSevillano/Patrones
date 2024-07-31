using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PagoAdapter : PagoA
    {
        PagoB pA = new PagoB();

        public override void CambiarMonedaPesos()
        {
            pA.Pesos();
        }

        public override void CambiarMonedaUSD()
        {
            pA.USD();
        }
    }
}
