using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionMejorada
{
    abstract class Productos
    {
        private string nombre;
        private float costo;
        private string tipo;
        


        //Constructor
        public Productos(string nombre, float costo, string tipo)
        {
            this.nombre = nombre;
            this.costo = costo;
            this.tipo = tipo;
        }
        //get y  set de nombre
        public void setName(string nombre)
        {
            this.nombre = nombre;
        }
        public string getName()
        {
            return this.nombre;
        }
        //get y  set de costo
        public void setCosto(float costo)
        {
            this.costo = costo;
        }
        public float getCosto()
        {
            return this.costo;
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public string getTipo()
        {
            return this.tipo;
        }




        
    }
}
