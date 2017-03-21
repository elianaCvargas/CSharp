using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola mundo");
            //Console.ReadLine();
            //int numero;
            //numero = int.Parse("22");
            //Console.WriteLine("El  numero es: " + numero);

            int numero;
            string dato;
            int maximo = 0;
            int minimo = 0;
            bool convertNumero;

            for (int contador = 0; contador < 6; contador++)
            {
                Console.WriteLine("Ingrese numero: ");
                dato = Console.ReadLine();
                //numero = int.Parse(dato);
                convertNumero = int.TryParse(dato, out numero);
                while(convertNumero == false)
                {
                    Console.WriteLine("Error, Ingrese nuevamente: ");
                    dato = Console.ReadLine();
                    
                }

                if (contador == 0)
                {
                    
                    maximo = numero;
                    minimo = numero;
                }
                else
                { 
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    if (numero < minimo)
                    {
                        minimo = numero; 
                    }
                }
            }



            Console.WriteLine("Maximo: " + maximo);
            Console.WriteLine("Minimo: " + minimo);
            Console.ReadLine();
        }
    }
}
