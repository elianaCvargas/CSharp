using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoDiaUno
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre,  name;
            int age, contador = 0;
            const int CANTIDAD_DE_ALUMNOS = 3;
            string[] arrayNombres = new string[CANTIDAD_DE_ALUMNOS];
            int[] arrayEdades = new int[CANTIDAD_DE_ALUMNOS];

            //Escribimos mensajes
            Console.WriteLine("Hola mundo");
            //Pedir ingreso de datos
            Console.WriteLine("Ingresar nombre: ");
            //Leer dato  ingresado
            nombre = Console.ReadLine();//O  directamente string nombre = console.readLine();
            //Imprimir dato
            Console.WriteLine("Nombre: " + nombre);
            if (CANTIDAD_DE_ALUMNOS < 5)
            {
                Console.WriteLine("La cantidad es menor que 5");
            }
            else
            {
                Console.WriteLine("La cantidad es mayo que 5");
            }

            for (int i = 0; i < CANTIDAD_DE_ALUMNOS; i++ )
            {
                Console.WriteLine("Ingrese el nombre del  alumno: ");
                name = Console.ReadLine();
                arrayNombres[i] = name; //Otra forma es arrayNombre[i] = console.readline; (Mas directo - sin necesidad de crear la variable name-)
                Console.WriteLine("Ingrese la edad:");
                //age = Console.ReadLine();
                //age = int.Parse(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    arrayEdades[i] = age;
                }
                else {
                    arrayEdades[i] = 0; 
                }
            }

           
            //Autoincrementar siempre la variable que usamos como contador
            while(contador < CANTIDAD_DE_ALUMNOS)
            {

                Console.WriteLine("Nombre: " + arrayNombres[contador] + "Edad: " + arrayEdades[contador]);
                Console.WriteLine("Nombre: {0}\nEdad: {1}", arrayNombres[contador], arrayEdades[contador]);
                contador++;
            }

            Console.WriteLine("Ingrese una vocal: ");
            /*switch()
            {
            
            }*/

            
            Console.Clear();
            //Leemos o  pausamos
            Console.ReadLine();
        }
    }
}
