using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaLabII
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Rueda ruedaUno = new Rueda();
            Rueda ruedaDos = new Rueda();
            ruedaUno.marca = "firestone";
            ruedaUno.tamaño = 165;
            ruedaDos.marca = "peugeot";
            ruedaDos.tamaño = 185;

            Console.WriteLine("Rueda Uno: " + ruedaUno.mostrar());
            Console.ReadKey();

        }
    }
}
