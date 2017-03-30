using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaClase4
{
    class Empleado: Persona, ICobrador
    {
        private int salarioHoras;
        private int horasTrabajadas;

        public Empleado(string nombre, int salarioHoras, int horasTrabajadas)
            :base(nombre)
        {
            this.salarioHoras = salarioHoras;
            this.horasTrabajadas = horasTrabajadas;
        }

        public void EmitirFactura()
        {
            Console.WriteLine("Emitiendo factura...");
        }

        public void CalcularMontoFactura()
        {
            Console.WriteLine("Facturando");
        }





    }
}
