using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPraticoSemana1
{
    class Cliente: Empresa
    {
        private string nombre;
        private string tipoCliente; //(habilitado,  no  habillitado)
        private string tipoClienteFrenteAlIVA;//excento,  no  excento, etc etc
        private string pedidoCliente;


        public Cliente(string nombre, string tipoCliente): 
            base(nombre )
        {
            this.nombre = nombre;
            this.tipoCliente = tipoCliente;
            //this.tipoClienteFrenteAlIVA =  tipoClienteFrenteAlIVA;
        }
        public void setNombre(string nombre, string tipoCliente)
        {
            this.nombre = nombre;
            this.tipoCliente = tipoCliente;
        }

        //public void setTipoCliente(string tipoCliente)
        //{
        //    this.tipoCliente = tipoCliente;
        //}

      

        public string getNombre()
        {
            return this.nombre;
        }

        public string getTipoCliente()
        {
            return this.tipoCliente;
        }


        public bool verificarCliente(string tipoCliente)
        {
            bool retorno =  true;
            if ( tipoCliente == "habilitado")
            {
                this.tipoCliente = tipoCliente;
                return retorno;
            }
            retorno = false;
            return retorno; ;
        }






    }
}
