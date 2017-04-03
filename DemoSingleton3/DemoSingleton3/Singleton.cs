using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSingleton3
{
    class Singleton
    {
         static Singleton single;
        public  int contador;

        private Singleton()
        {
            contador = 0;
        }

        public static Singleton GetInstancia()
        {
            if (single == null)
            {
                single = new Singleton();
            }
            return single;
        }

        public void Contar() {
            contador++;
        }

    }
}
