using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaClase4
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("nombre generico" );
            

            Empleado emp1 = new Empleado("Eliana", 4500,12);
            Empleado emp2 = new Empleado("Romina", 4500, 12);
            Empleado emp3 = new Empleado("Gisel", 4500, 12);

            Cliente cli1 = new Cliente("Marcos");
            Cliente cli2 = new Cliente("Federico");
            Cliente cli3 = new Cliente("Ezequiel");


            //Console.WriteLine(emp1.getNombrePersona());
            //emp1.EmitirFactura();
            //emp1.CalcularMontoFactura();
            //emp2.EmitirFactura();
            //emp2.CalcularMontoFactura();
            //emp3.EmitirFactura();
            //emp3.CalcularMontoFactura();

            //List<Empleado> listaEmpleados = new List<Empleado>();
            //listaEmpleados.Add(emp1);
            //listaEmpleados.Add(emp2);
            //listaEmpleados.Add(emp3);
            //listaEmpleados.Add(new Empleado("Ross", 4522, 23));

            List<Persona> listaPersonas = new List<Persona>();
            listaPersonas.Add(persona);
            //listaPersonas.Add(cli1);
            //listaPersonas.Add(cli2);


           


            

            
            




            


            Console.ReadKey();
        }
    }
}
