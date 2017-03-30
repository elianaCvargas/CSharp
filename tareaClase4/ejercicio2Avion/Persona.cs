using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2Avion
{
    abstract class Persona
    {
        protected int id;
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected string rango;
        protected int horasPorVuelo;

        
        public Persona(int id, string nombre, string apellido, int edad, string rango) 
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.rango = rango;
           // this.horasPorVuelo=  horasPorVuelo;
        }



        //public string AsignarRango();

        

    }
}
