using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPraticoSemana1
{
    class Producto//:Interfaz,  base
    {
        

       
        private Cliente cliente;
        private string nombreProducto;
        private int precio;
        private int stock;

        List<Producto> producto;


        public Producto(string nombreProducto, int stock, int precio)
        {
            this.precio =  precio;
            this.stock = stock;
            this.nombreProducto = nombreProducto;
        }

        public void setNombreProducto(string nombreProducto)
        {
            this.nombreProducto = nombreProducto;
        }
        public string getNombreProducto()
        {
            return this.nombreProducto;
        }

        public void setStockPrecio(int stock)
        {
            this.stock = stock;
        }
        public int getStockProducto()
        {
            return this.stock;
        }

        public void setPrecio(int precio)
        {
            this.precio = precio;
        }
        public int getPrecio()
        {
            return this.precio;
        }
        

        
  

        //public int aumentarStock()
        //{
        //    this.stock += stock;
        //    return stock;
        //}

        //public void vender(string tipo )
        //{
            
        //    if (cliente.verificarCliente ( tipo))
        //     {
        //         this.stock -= 1;
        //     }
        //}

        



        
        



    }
}
