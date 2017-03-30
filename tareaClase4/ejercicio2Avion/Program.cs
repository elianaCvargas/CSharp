using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2Avion
{
    class Program
    {
        static void Main(string[] args)
        {
            Azafatas aza1 = new Azafatas(1, "Eliana", "Vargas", 28 , "Comisario");
            Azafatas aza2 = new Azafatas(1, "Rose", "Mercado", 20 , "Subordinado");

            Pilotos pil1 = new Pilotos(1, "Alejandro", "Mercado", 40 , "Comandante");
            Pilotos pil2 = new Pilotos(1, "Miguel", "Rosales", 54 , "Copiloto");

            Pasajeros pasa1 = new Pasajeros(1, "Lucas", "Mercado", 40, "Frecuente");
            Pasajeros pasa2 = new Pasajeros(1, "Ivan", "Rosales", 54, "No frecuente");

            //pil1.AcumularHoras(50);
            //pil1.AcumularHoras(50);
            //Console.WriteLine(pil1.AcumularHoras(50));
            //Console.WriteLine(pil1.AcumularHoras(10));
            /*int valor;
            valor = int.Parse(Console.ReadLine());
            pil1.AcumularHoras(valor);*/

            pil1.InformarPremio(pil1.AcumularHoras(10));
            pasa1.InformarPremio(pasa1.AcumularHoras(50), "No frecuente");
            aza1.InformarPremio(aza1.AcumularHoras(25));


            

            Console.ReadKey();





        }
        
    }
}
