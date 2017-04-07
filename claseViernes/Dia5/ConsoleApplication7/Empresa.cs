using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Empresa
    {
        public string nombre;

        public List<Cliente> listaClientes = new List<Cliente>();
        public List<Producto> listaProductos = new List<Producto>();


        public bool vender(Producto prod, Cliente cliente, int cantidad, int IVA)
        {

            if (listaClientes.Contains(cliente))
            {
                if (listaProductos.Contains(prod))
                {
                    if (prod is Manufactura)
                    {

                        int pos = listaProductos.IndexOf(prod);
                        Manufactura aux = listaProductos[pos] as Manufactura;
                        if (aux.stock > cantidad)
                        {
                            //Llamo a un metodo que se encargue de mostrar la factura
                            aux.stock -= cantidad;
                            return true; 
                        }
                        else
                            return false; 
                    }
                    else
                    {
                        //lamo a metodo de mostrar factura;
                        return true;
                    }

                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }




        }




    }
}
