using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2Avion
{
    class Pasajeros:Persona, IPremios
    {

        public Pasajeros(int id, string nombre, string apellido, int edad, string rango) :
            base(id, nombre, apellido, edad, rango)
        {

        }

        public int AcumularHoras(int horas)
        {
            this.horasPorVuelo += horas;
            return this.horasPorVuelo;
        }


        public void InformarPremio(int retorno, string rango)
        {
            int horasFaltantes;
            horasFaltantes = 100 - retorno;
            if (retorno >= 100 && rango == "Frecuente")
            {

                Console.WriteLine("Felicitaciones usted ha llegado/superado las 100 horas y al ser frecuente se le regala un pasaje a Miami");
            }
            else if (retorno >= 100 && rango == "No frecuente")
            {
                Console.WriteLine("Felicitaciones usted ha llegado/superado las 100 horas  se le regala un pasaje a Brasil");
            }
            else {
                Console.WriteLine("Aun te faltan {0}  horas para el premio", horasFaltantes);
            }

        }



    }
}
