using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {

            Empresa emp = new Empresa();

            Manufactura man1 = new Manufactura();
            Manufactura man2 = new Manufactura();
            man1.nombre = "Tele";
            man2.nombre = "Tele";
            man1.stock = 500;
            man2.stock = 23;
            Cliente cli = new Cliente();
            cli.nombre = "Carlos Ejemplo";

            emp.listaProductos.Add(man1);
            emp.listaClientes.Add(cli);

            emp.vender(man2, cli, 50, 2);





            





        }
    }
}
