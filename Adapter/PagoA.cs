using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public abstract class PagoA
    {
        public abstract void CambiarMonedaUSD();
        public abstract void CambiarMonedaPesos();
    }
}
