using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionMejorada
{
    class Manufactura: Productos
    {

        private string nombre;
        private float costo;
        private int stock;
        private string tipo;

        //Constructor
        public Manufactura(string nombre, float costo, int stock, string tipo)
            :base(nombre, costo, tipo)
        {
            this.nombre = nombre;
            this.costo = costo;
            this.stock = stock;
            this.tipo = tipo;
        }
        public void setStock(int stock)
        {
            this.stock = stock;
        }

        public int getStock()
        {
            return this.stock;
        }
        




    }
}
