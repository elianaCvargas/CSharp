using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    abstract class  Producto:IEquatable<Producto>
    {
        public string nombre;
        public int codigo;


        public bool Equals(Producto other)
        {
            return this.nombre == other.nombre;
        }
    }
}
