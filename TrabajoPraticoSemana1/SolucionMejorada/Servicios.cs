using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionMejorada
{
    class Servicios: Productos
    {
        private string nombre;
        private float costo;
        private string tipo;

        public Servicios(string nombre, float costo, string tipo)
            :base(nombre, costo, tipo)
        {
            this.costo = costo;
            this.nombre = nombre;
            this.tipo = tipo;
        }


        

    }
}
