using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaClase4
{
    class Persona
    {
        protected string nombre;
        //protected Empleado listaEmpleados;
        //protected Cliente listaClientes;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public void setNombrePersona(string  nombre)
        {
            this.nombre = nombre;
        }
        public string getNombrePersona()
        {
            return this.nombre;
        }


        //public void addAListEmployee( Empleado listEmployee)
        //{
        //    this.listaEmpleados = listEmployee;
        //}
        //public Empleado saveToListE()
        //{
        //    return this.listaEmpleados;
        //}

        //public void addAListClientes(Cliente listClientes)
        //{
        //    this.listaClientes = listClientes;
        //}
        //public Cliente saveToListC()
        //{
        //    return this.listaClientes;
        //}

        
    }
}
