using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonCalculardora
{
    class SingletonCalculadora
    {
        private static SingletonCalculadora sCalculadora;
        public float ultimoValor;
       

        private SingletonCalculadora()
        {
            ultimoValor = 0;
        }

        public static SingletonCalculadora getSCalculadora()
        {
            if (sCalculadora == null)
            {
                sCalculadora = new SingletonCalculadora();
            }
            return sCalculadora;
        }

        public float sumar(float numero)
        {
            return  ultimoValor += numero;
        }

        public float restar(float numero)
        {
            
            return ultimoValor -= numero;
        }

        public float muliticar(float numero)
        {
            
            return ultimoValor *= numero;
        
        }

    }
}
