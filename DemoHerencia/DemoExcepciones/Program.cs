using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numero;
                int numero2;
                Console.WriteLine("Ingrese el  primer numero");
                numero = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el  segundo numero");
                numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine(numero / numero2);

            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("No  se puede dividir por cero");
            }

            //catch (OverflowException)
            //{
            //    Console.WriteLine("No se pueden  ingresar tantos numeros,  line    ");
            //}
           catch (FormatException)
            {
                Console.WriteLine("No  ingresar letras");
            }
            catch (Exception ex)
            {
               Console.WriteLine( ex.Message);
            }

            Console.ReadKey();
        }
    }
}
