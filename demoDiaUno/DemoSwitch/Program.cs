using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("opcion UNO");
                    break;
                case 2:
                    Console.WriteLine("opcion DOS");
                    break;
                case 3:
                    Console.WriteLine("opcion TRES");
                    break;

                default:
                    Console.WriteLine("DEFAULT");
                    break;
            }
            Console.ReadLine();
        }
    }
}
