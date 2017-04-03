using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonCalculardora
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonCalculadora num1 = SingletonCalculadora.getSCalculadora();
            SingletonCalculadora num2 = SingletonCalculadora.getSCalculadora();
            SingletonCalculadora num3 = SingletonCalculadora.getSCalculadora();
            SingletonCalculadora num4 = SingletonCalculadora.getSCalculadora();

            num1.sumar(5);
            num2.sumar(2);

            Console.WriteLine(num2.ultimoValor);

            num3.restar(10);

            Console.WriteLine(num4.ultimoValor);

            num4.muliticar(-1);

            Console.WriteLine(num3.ultimoValor);


            Console.ReadKey();

        }
    }
}
