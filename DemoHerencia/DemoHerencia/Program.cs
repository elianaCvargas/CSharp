using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Supervisor super = new Supervisor("Carlos",  "dni", 321.2f);
            super.setNombre("Hello");
            //No se puede instanciar porque Persona es clase abrstracta
            //Persona pe = new Persona();
            super.caminar();
            Console.WriteLine(super.caminar());
            List<Supervisor> listaSuper = new List<Supervisor>();
            listaSuper.Add(new Supervisor("jose", "13", 13));
            listaSuper.Add(new Supervisor("carlos", "13", 13));
            listaSuper.Add(new Supervisor("pablo", "13", 13));
            listaSuper.Add(super);
            listaSuper.Sort();

            foreach (Supervisor item in listaSuper)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
