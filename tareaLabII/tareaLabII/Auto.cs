using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using autoPartes;

namespace autos
{
    class Auto
    {
        public Rueda dD;
        public Rueda Di;
        public Rueda Id;
        public Rueda Ii;

       // Rueda ru = new Rueda();
        //Rueda r2 = new Rueda();
        public Auto()
        { 
            this.dD = new Rueda();
            /*this.Di = r2;
            this.Id = ru;
            this.Ii = ru;*/
        }
        
        public string mostrarRueda()
        {
           return this.dD.ToString() + " " + this.Di.ToString() + " " + this.Id.ToString() + " " + this.Ii.ToString()  ;

        }


    }
}
