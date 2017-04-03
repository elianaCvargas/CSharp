using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSingleton3
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton single = Singleton.GetInstancia();
            Singleton single2 = Singleton.GetInstancia();
            Singleton single3 = Singleton.GetInstancia();
            Singleton single4 = Singleton.GetInstancia();

            single.Contar();
            single2.Contar();
            single3.Contar();

            single3.Contar();
            single4.Contar();
            single4.Contar();

            Console.WriteLine(single4.contador);
            Console.WriteLine(single4.contador);

            Console.Read();
        }
    }
}
