using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoRelaciones
{
    class Supervisor
    {
        //Los nombres de las propiedades comienzan  con  mayuscula

        /*public string Nombre { get; set; }
        private int nombe;*/

        private string nombre;
        private TarjetaDeIdentificacion tarjeta;
        private List<Empleado> empleadosACargo;
        private Proyecto proyectoACargo = new Proyecto();
        public double sueldo = 50000;

        public Supervisor(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void AsignarTarjeta(TarjetaDeIdentificacion tarjeta)
        {
            this.tarjeta = tarjeta; 
        }

        public TarjetaDeIdentificacion obtenerTarjeta() 
        {
            return tarjeta;
        }

        public void setEmpleadosACargo(List<Empleado> lista)
        {
            this.empleadosACargo = lista;   
        }

        public List<Empleado> getEmpleadosACargo()
        {
            return this.empleadosACargo;
        }

        
        public bool agregarEmpleadoACargo(Empleado empleado)
        {
            if (empleadosACargo != null)
            {
                empleadosACargo.Add(empleado);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AsignarProyecto(Proyecto proyecto)
        {
            this.proyectoACargo = proyecto;
        }
        
        public void evaluarDespempeño()
        {
            if (proyectoACargo.esExitoso)
            {
                sueldo = sueldo * 10 / 100;
            }
        }

        
    }
}
