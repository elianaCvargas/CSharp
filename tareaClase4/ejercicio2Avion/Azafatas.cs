using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2Avion
{
    class Azafatas:Persona, IPremios
    {

        public Azafatas(int id, string nombre,  string apellido, int edad,  string rango):
            base(id, nombre, apellido, edad,  rango)
        { 
            
        }



        public int AcumularHoras(int horas)
        {
            this.horasPorVuelo += horas;
            return this.horasPorVuelo;
        }


        public void InformarPremio(int retorno)
        {

            int horasFaltantes;
            horasFaltantes = 50 - retorno;
            if (retorno >= 50)
            {

                Console.WriteLine("Felicitaciones usted ha llegado/superado las 50 horas, tiene un bonus del 20% de su sueldo");
            }
            else
            {
                Console.WriteLine("Aun te faltan {0} horas para el premio", horasFaltantes);
            }

        }
    }
}
