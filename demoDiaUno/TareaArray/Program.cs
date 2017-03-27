using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaArray
{
    class Program
    {
        static void Main(string[] args)
        {
/*A partir de un array de elementos, buscar si un valor se encuentra dentro del mismo. 
 En caso que se encuentre, mostrar la posición en la cual fue encontrado. De lo contrario, mostrar -1
*/
            int[] arrayElementos = { 20, 15, 21, 12, 9, 1 };
            /*bool bandera = true;
            Console.WriteLine("Ingrese el  numero que desea buscar: ");
            numero = int.Parse(Console.ReadLine());
            if (bandera == true)
            {
                for (int i = 0; i < arrayElementos.Length; i++)
                {
                    if (numero == arrayElementos[i])
                    {
                        Console.WriteLine(i);
                        bandera = true;
                    }
                    else
                        bandera = false;
                    break;

                }
            }
            else
                Console.WriteLine("-1");*/
/*Partiendo de un array de números declarado, ordenar el mismo y mostrar el resultado del array ordenado*/
            /*int auxiliar;

            for (int i = 0; i < arrayElementos.Length - 1; i++)
            {
                for (int j = 1 + i; j < arrayElementos.Length; j++)
                {
                    if (arrayElementos[i] > arrayElementos[j])
                    {
                        auxiliar = arrayElementos[i];
                        arrayElementos[i] = arrayElementos[j];
                        arrayElementos[j] = auxiliar;

                    }

                }
            }
            for (int i = 0; i < arrayElementos.Length; i++)
            {
                Console.WriteLine(arrayElementos[i]);
            }*/
/*Partiendo de un array de números declarado dentro del código, calcular el promedio y mostrarlo por consola. 
Recodemos, la formula del promedio : (A1+...An) / n*/
            /*int suma = 0;
            for (int i = 0; i < arrayElementos.Length; i++)
            {
                suma = suma + arrayElementos[i];
            }
            Console.WriteLine("la suma es: "+  suma);
            Console.WriteLine("El promedio es: " + suma/arrayElementos.Length);
            //verificar que el  resultado  tambien  puede ser con decimales,  en  tal  caso mejor cambiar la variable a float 
             */

/*Declarar un array tamaño 10 y completarlo con valores contiguos empezando por un numero ingresado por 
consola. Imprimir en pantalla el contenido del array por cada una de sus posiciones*/
            /*int[] arrayContiguos = new int [10];
            int numero; 
            Console.WriteLine("Ingrese un  numero: ");
            numero = int.Parse(Console.ReadLine());
            for (int i = numero ; i < arrayContiguos.Length; i++)
            {
                arrayContiguos[i] = i;
                Console.WriteLine("El  arreglo es: "+ arrayContiguos[i]);
            }*/

/*
Pidiendo una palabra o frase por consola comprobar si la misma es un palíndromo o no. Informar el resultado.
Ejemplo de palíndromo: Anita lava la tina - Se lee igual de izquiera a derecha y de derecha a izquierda*/
            string word, palabraSinEspacios, palabraNueva ="";
            Console.WriteLine("Ingrese una palabra: ");
            word = Console.ReadLine();

            /*for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    word[i] = '';
                }
            }*/
          
            palabraSinEspacios = word.Replace(" ", "");
            //Console.WriteLine(palabraSinEspacios);
            for (int i = palabraSinEspacios.Length-1; i >=  0 ; i--)
            {
                palabraNueva = palabraNueva + palabraSinEspacios[i];
            }

            if (palabraSinEspacios == palabraNueva)
            {
                Console.WriteLine("Es un palindromo");
            }
            else
                Console.WriteLine("No  es palindromo");

            Console.ReadLine();



        }
    }
}
