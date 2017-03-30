using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaClase4
{
    class Cliente
    {
        private string nombre;

        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }

        public void setNombreCliente(string nombre)
        {
            this.nombre = nombre;  
        }
        public string getNombreCliente()
        {
            return this.nombre;
        }

    }
}
