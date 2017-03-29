using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoPartes
//namespace tareaLabII
{
    class Rueda
    {
        public string marca;
        public int tamaño;

        public Rueda(string marca,  int tamaño)
        {
            this.marca = marca;
            this.tamaño = tamaño;
            
        }
        public Rueda()
        {
            this.marca = "Sin marca";
            this.tamaño = 165;
        }


        public string mostrar()
        {

            return this.marca +" " + this.tamaño.ToString();

            
        }


    }
}
