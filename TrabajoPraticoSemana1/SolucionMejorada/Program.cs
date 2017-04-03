using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionMejorada
{
    class Program
    {
        static void Main(string[] args)
        {

            Empresa empresa = new Empresa();
            Manufactura manu = new Manufactura("Heladera", 3000,20, "M");
            //Manufactura manu2 = new Manufactura("Lavarropas", 4500);
           

            Clientes cliente = new Clientes("Eliana", "Habilitado", "excento");
            //Console.WriteLine(manu2.getName());
            empresa.asignarALista(manu);
            //empresa.asignarALista(manu2);
            //empresa.vender(manu);
            empresa.mostrarListaManufacturas();

            //Console.WriteLine(empresa.getStock());//stock de heladeras

            empresa.buscarManufactura(manu.getName());
            empresa.vender(manu, cliente);


/* Se nos ha pedido implementar el sistema de ventas de una empresa--> 
  * Empresa fabrica y vende PRODUCTOS ELECTRICOS y SERVICIOS relacionados. 
  * Al fabricar alguno de los productos, el stock del producto fabricado listo para la venta aumenta. Dichos productos
se almacenan en las instalaciones hasta que son vendidos a algunos de sus clientes.
Las ventas se realizan siempre y cuando el cliente esté habilitado para comprar.
Cuando se vende, se genera una factura con el importe que corresponda*/

            

            


            

            Console.ReadKey();
        }
    }
}
