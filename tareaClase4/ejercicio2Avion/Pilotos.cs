using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2Avion
{
    class Pilotos:Persona, IPremios
    {


   
        public Pilotos(int id, string nombre, string apellido, int edad, string rango) :
            base(id, nombre, apellido, edad, rango)
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
            horasFaltantes = 30 - retorno;
            if (retorno >= 30)
            {
                
                Console.WriteLine("Felicitaciones usted ha llegado/superado las 25 horas, tiene una semana de descanso");
            }
            else {
                Console.WriteLine("Aun te faltan {0} horas para el premio", horasFaltantes);
            }

        }
    }
}
