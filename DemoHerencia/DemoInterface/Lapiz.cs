using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    class Lapiz: IEscribible
    {
        public void escribir(string texto)
        {
            Console.WriteLine("Estoy a manuscrita {0}",  texto);
        }
    }
}
