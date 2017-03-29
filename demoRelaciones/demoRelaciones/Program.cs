using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoRelaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asociacion
            TarjetaDeIdentificacion tarjeta = new TarjetaDeIdentificacion();
            tarjeta.setCodigo(789);
            Supervisor supervisor = new Supervisor("Carlos ejemplo");
            supervisor.AsignarTarjeta(tarjeta);
            supervisor.obtenerTarjeta().utilizar();
           

            //Agregacion
            Empleado empleado = new Empleado("Pochi Lavezzi");

            Empleado empleado2 = new Empleado("Carlos Ramos");
            Empleado empleado3 = new Empleado("Amy  ");

            List<Empleado> lista = new List<Empleado>();
            lista.Add(empleado);
            lista.Add(empleado2);
            lista.Add(empleado3);

            supervisor.setEmpleadosACargo(lista);//agrega la lista entera
            supervisor.agregarEmpleadoACargo(new Empleado("Marcela tinelli"));//agrga un empleado 

            

            foreach(Empleado item in supervisor.getEmpleadosACargo())//
            {
                Console.WriteLine(item.nombre);
                
            }

            Console.WriteLine(supervisor.sueldo);
            supervisor.evaluarDespempeño();

            Console.ReadKey();

        }
    }
}
