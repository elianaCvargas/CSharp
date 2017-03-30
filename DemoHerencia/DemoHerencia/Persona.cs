using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHerencia
{
    abstract class Persona
    {
        protected string nombre;
        protected string dni;
        //protected string direccion;

        public Persona(string nombre,  string dni)
        {
            this.nombre = nombre;
            this.dni = dni; 
        }

        public string getNombre()
        {
            return this.nombre ; 
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        /*public void comer()
        {
            Console.WriteLine("comiendo");
        }*/
        public abstract void comer();

        public virtual string caminar()
        {
            return "caminando ";
        }

        public override string ToString()
        {
            return String.Format("nombre: {0}",  nombre);
        }


    }
}
