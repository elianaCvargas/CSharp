using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionMejorada
{
    class Empresa
    {
        private Clientes cliente;
        private Productos manufactura;
        private Manufactura manu;
        

        List<Manufactura> listaManufactura =  new List<Manufactura>();
        List<Clientes> listaClientes = new List<Clientes>();

       //*****************CREO LISTA MANUFACTURA****************************************
        public void asignarALista(Manufactura manu)//Se agregan a una lista los productos fabricados
        {
            this.listaManufactura.Add(manu);
        }
        //GET LISTA MANUFACTURA
        public List<Manufactura> getListaM()//Obtengo la lista
        {
            return this.listaManufactura;
        }
        //MOSTRAR LISTA MANUFACTURA
        public void mostrarListaManufacturas()
        {
            foreach (Manufactura item in getListaM())
            {
                Console.WriteLine("nombre: {0}          Costo: {1}" ,item.getName(),item.getCosto() );
            }
        }

       

        //VENDER
        public void vender(Manufactura manufactura, Clientes cliente, int cantidad)
        {
            if (listaClientes.Contains(cliente))
            {
                if (listaManufactura.Contains(manufactura))
                {
                    //Console.WriteLine("El cliente existe");
                    if (manufactura is Manufactura)
                    {
                        //Console.WriteLine("Lo  que pide es  una manufactura");
                        int pos = listaManufactura.IndexOf(manufactura);
                        Manufactura auxManufactura = listaManufactura[pos];
                        if (auxManufactura.getStock() > cantidad)
                        {
                            float totalPrecio;
                            totalPrecio = cantidad * manufactura.getCosto();
                            Console.WriteLine("*****************Factura*********************");
                            Console.WriteLine("Cliente: {0}\n Pedido: {1}    Cantidad: {2}\n Precio total: {3}", cliente.getNombre(), manufactura.getName(), cantidad, totalPrecio);
                        }

                    }
                }













            }
                
            
            
        }

       

        public void vender(Servicios servicio, Clientes cliente)
        { 
        
        }


        //COMPARAR TIPO DE PEDIDO  para MANUFACTURA 
        public bool compararDataM(string  tipo)
        {
            bool retorno = true;
            foreach (Manufactura item in listaManufactura)
            {
                if (item.getTipo() == "M")
                {
                    return retorno;
                }
            }
            return false; 
        }



        //public bool compararData(string tipo)
        //{
        //    bool retorno = true;
        //    foreach (Manufactura item in listaManufactura)
        //    {
        //        if (item.getTipo().Equals(tipo))
        //        {
        //            return retorno;
        //        }
        //    }
        //    return false;

        //}

        
        public void buscarManufactura(string manufactura)
        {
            foreach (Manufactura item in listaManufactura)
            {
                if (item.getName().Equals(manufactura))
                {
                    //Console.WriteLine("bucador {0}", item.getName());



                }
                
            }
        
        }
      
        

        //********************************DATOS CLIENTES*****************************
        public void asignarALista(Clientes cliente)//Se agregan a una lista los productos fabricados
        {
            this.listaClientes.Add(cliente);
        }
        //GET LISTA MANUFACTURA
        public List<Clientes> getListaC()//Obtengo la lista
        {
            return this.listaClientes;
        }
        //COMPARAR CLIENTE HABILITADO O NO HABILITADO
        public bool compararDataC(string tipo)
        {
            bool retorno = true;
            foreach (Clientes item in listaClientes)
            {
                if (item.getRestrciccion()== "Habilitado")
                {
                    return retorno;
                }
            }
           
            return false;
        }


        public int compararDataIva(string tipo)
        {
            //int retorno = 0;
            foreach (Clientes item in listaClientes)
            {
                if (item.getSituacionIva() == "Excento")
                {
                    return 0;
                }
                else
                    if (item.getSituacionIva() == "No excento")
                    {
                        return 1;
                    }
                    else
                        return 2;
            }

            return -1;
        }




       
    }
}
