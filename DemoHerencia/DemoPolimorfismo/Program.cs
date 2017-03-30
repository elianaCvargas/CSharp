using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>();
            Persona per = new Persona();
            lista.Add(per);
            Alumno alu = new Alumno();
            lista.Add(alu);
            Supervisor sup = new Supervisor();
            lista.Add(sup);

            foreach (Persona item in lista)
            {
                if (item is Supervisor)//aca le pedimos que nos saque solamente los supervisores
                {
                    Supervisor aux;
                    aux = item as Supervisor;
                    Console.WriteLine(aux.Supervisar());
                    //Console.WriteLine((item as Supervisor).Supervisar());//convertimos el  tipo  item  a tipo supervsor

                }
                
                
            }

            Console.ReadKey();
        }
    }
}
