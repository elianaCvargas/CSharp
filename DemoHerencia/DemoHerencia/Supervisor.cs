using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHerencia
{
    class Supervisor: Persona, IComparable
    {
        float sueldo;
        public Supervisor(string nombre,  string dni,  float sueldo)
            :base(nombre,  dni)//esto es para aclararle eu hay  dos atributos que heredan  del  padre y  una que es propia de la misma clase
        {
            
            this.sueldo = sueldo;

        }
        public override void comer()//override es para sobreescribir el metodo  del  padre
        {
            Console.WriteLine("comiendo  sushi");
        }

        public override string caminar()
        {
            return base.caminar() + "por puerto  madero";
        }


        public int CompareTo(object obj)
        {
            Supervisor aux = obj as Supervisor;
            return this.nombre.CompareTo(aux.nombre);
        }
    }
}
