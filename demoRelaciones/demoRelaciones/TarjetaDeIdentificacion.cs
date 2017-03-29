using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoRelaciones
{
    class TarjetaDeIdentificacion
    {
        private int _codigo;//Todos los atributos privados convienen dejarlos con un  guion delante

        public int getCodigo()
        {
            return this._codigo;
        }
        public int setCodigo( int codigo)
        {
            return this._codigo = codigo;
        }
        public void utilizar()
        {
            Console.WriteLine("Estoy usando la tarjeta {0}", _codigo);
        }

    }
}
