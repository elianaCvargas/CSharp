using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPraticoSemana1
{
    class Program
    {
        static void Main(string[] args)
        {

            Fabrica fabrica = new Fabrica("fabrica");
            Empresa empresa = new Empresa("lalala");
          
           
            fabrica.fabricar("Caja");
           
            Console.WriteLine(fabrica.getProducto().getNombreProducto());
            
            Console.WriteLine("Cantidad de fabricados: {0}", fabrica.getStock());

            
            fabrica.addListaP();
            Console.WriteLine(fabrica.getListaP());
            



/////////////////////////////////////////////////////////////////////////////////
            Cliente cli = new Cliente("Eliana", "habilitado");
            //if (cli.getNombre() == "Eliana")
            //{
               //Console.WriteLine();
            //}
            //Console.WriteLine(cli.getNombre());


            //bool verificacion;
            //verificacion= cli.verificarCliente(cli.getTipoCliente());
            //if (verificacion)
            //{
            //    Console.WriteLine("Habilitado");
            //}
            
 

            

            Console.ReadKey();

        }
    }
}
