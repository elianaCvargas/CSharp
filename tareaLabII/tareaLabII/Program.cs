using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using autos;
using autoPartes;

namespace tareaLabII
{
    class Program
    {
        static void Main(string[] args)
        {
            
           /* Rueda ruedaUno = new Rueda();
            Rueda ruedaDos = new Rueda();
            ruedaUno.marca = "firestone";
            ruedaUno.tamaño = 165;
            ruedaDos.marca = "peugeot";
            ruedaDos.tamaño = 185;*/
            Auto auto = new Auto();
            Console.WriteLine(auto.mostrarRueda());
            

            Rueda rueda = new Rueda( "sin marca", 165);
            Console.WriteLine("Rueda Uno: " + rueda.mostrar());
             

            Console.ReadKey();

        }
    }
}
