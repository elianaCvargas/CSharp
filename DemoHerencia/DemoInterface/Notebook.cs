using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    class Notebook: IEscribible
    {


        public void escribir(string texto)
        {
            Console.WriteLine("Estoy tipeando: {0}",  texto);
        }
    }
}
