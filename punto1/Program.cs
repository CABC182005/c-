using punto1;
using System;
using System.Threading.Tasks;

namespace punto1
{
    public class Program
    {

        public static async Task Main()
        {
        
            Empleado empleado = new Empleado();

           
            empleado.SolicitarDatosPersona();

            
            empleado.SolicitarDatosEmpleado();

          
            await empleado.ObtenerDatosEmpleadoAsync();

           
            empleado.mostrarPersona();
        }
    }
}
