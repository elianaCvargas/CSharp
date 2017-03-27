using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClaseUno
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad, numero, numeroUno, numeroDos, basse, exponente, contador = 0, resultadoPotencia = 1, puntaje;
            int acumulaPuntaje = 0;



 /*
 Pedir al usuario que ingrese su nombre y su edad, guardando ambos valores en variables.
Mostrar un mensaje de bienvenida que contenga ambos valores.
*/
            
            /*Console.WriteLine("Ingrese su  nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Buenos dias {0}, ud. Tiene {1} años.", nombre, edad);*/
         
/*
 * Pedir el ingreso de un número del 0 al 9 por consola e imprimir el nombre en letras del mismo.
EJ:Ingresamos 2 por consola y la misma nos responde con el mensaje Dos
*/
           /* Console.WriteLine("Ingrese un  numero entre el 0 y  el  9.");
            numero = int.Parse(Console.ReadLine());
            switch (numero)
            {   
                case 1:
                    Console.WriteLine("UNO");
                    break;
                case 2:
                    Console.WriteLine("DOS");
                    break;
                case 3:
                    Console.WriteLine("TRES");
                    break;
                case 4:
                    Console.WriteLine("CUATRO");
                    break;
                case 5:
                    Console.WriteLine("CINCO");
                    break;
                case 6:
                    Console.WriteLine("SEIS");
                    break;
                case 7:
                    Console.WriteLine("SIETE");
                    break;
                case 8:
                    Console.WriteLine("OCHO");
                    break;
                case 9:
                    Console.WriteLine("NUEVE");
                    break;
                default:
                    Console.WriteLine("Fuera de rango");
                    break;
            }*/
/*
Pedir el ingreso de dos números por consola e imprimir el de menor valor primero y
el de mayor valor despues, separados por una coma 
 */
            /*Console.WriteLine("Ingrese primer numero: ");
            numeroUno = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero: ");
            numeroDos = int.Parse(Console.ReadLine());
            if (numeroUno > numeroDos)
            {
                Console.WriteLine("{0} , {1}", numeroDos, numeroUno);
            }
            else
                Console.WriteLine("{0} , {1}", numeroUno, numeroDos);*/
/*
Declarar un array de 5 posiciones de texto y luego inicializarlo.
Recorrerlo imprimiendo por pantalla cada uno de los valores contenidos
Declarar un array de 5 posiciones numéricas e inicializarlo en la misma linea.
Recorrerlo e imprimir sólo los números contenidos que sean pares 
            
*/
            
           /* string[] arrayTexto = {"Uno","Dos","Tres","Cuatro","Cinco"};
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Lectura datos: " + arrayTexto[i]); 
            }

            int[] arrayInt = new int[4];
            for (int i = 0; i < 4; i++)
            {
                arrayInt[i] = i;
                if (arrayInt[i] % 2 == 0)
                {
                    Console.WriteLine("Numeros pares: " + arrayInt[i]);
                }
            }
            */
/*Calcula la potencia dado una base y un exponente utilizando el búcle WHILE
Calcula la potencia dado una base y un exponente utilizando el búcle FOR*/
            /*Console.WriteLine("Ingrese la base: ");
            basse = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el exponente: ");
            exponente = int.Parse(Console.ReadLine());
            while (contador < exponente)
            {
                resultadoPotencia = resultadoPotencia *basse;
                contador++;
                
            }
            Console.WriteLine(resultadoPotencia);

            for (int i = 0; i < exponente; i++)
            {
                resultadoPotencia = resultadoPotencia * basse;
                
            }
            Console.WriteLine(resultadoPotencia);*/

/*
Determinar que puntaje extra le corresponde a un jugador luego de pedirle que ingrese dicho valor.
Los puntajes ingresados iran de 0 a 9.
Si el puntaje ingresado esta entre 1 y 3 inclusive, le suma 10 veces el puntaje ingresado
Si el puntaje ingresado esta entre 7 y 9 inclusive, le suma 1000 veces el puntaje ingresado
Para puntajes mayores a 9 ó 0, se emitirá un mensaje de error
             */
           /* Console.WriteLine("Ingrese el  puntaje: ");
            puntaje = int.Parse(Console.ReadLine());
            if (puntaje >= 1 && puntaje <= 3)
            {
                acumulaPuntaje = (acumulaPuntaje + puntaje * 10) + puntaje;
                Console.WriteLine("Puntaje acumulado: " + acumulaPuntaje);
            }
            else if (puntaje >= 7 && puntaje <= 9)
            {
                acumulaPuntaje = (acumulaPuntaje + puntaje * 1000) + puntaje;
                Console.WriteLine("Puntaje acumulado: " + acumulaPuntaje);
            }
            else if (puntaje == 0 && puntaje > 9)
            {
                Console.WriteLine("error ");
            }
            else
                Console.WriteLine("No observado");*/


            

            Console.ReadLine();

        }
    }
}
