using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionMejorada
{
    class Clientes
    {
        private string nombre;
        private string restriccion;//No habilitado,  habilitado
        private string situacionFrenteAlIVA;

        public Clientes(string nombre, string restriccion, string situacionFrenteAlIVA)
        {
            this.nombre = nombre;
            this.restriccion = restriccion;
            this.situacionFrenteAlIVA = situacionFrenteAlIVA;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }

        public void setRestriccion(string restric)
        {
            this.restriccion = restric;
        }
        public string getRestrciccion()
        {
            return this.restriccion;
        }

        public void setSituacion(string situ)
        {
            this.situacionFrenteAlIVA = situ;
        }

        public string getSituacionIva()
        {
            return this.situacionFrenteAlIVA;
        }

        


        

    }
}
