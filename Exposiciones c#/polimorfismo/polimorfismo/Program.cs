using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista de empleados
            List<empleado> empleados = new List<empleado>();

            // Agregar diferentes tipos de empleados a la lista
            empleados.Add(new Desarrollador());
            empleados.Add(new Diseñador());

            // Usar el polimorfismo para invocar el método Trabajar
            foreach (empleado empleado in empleados)
            {
                empleado.Trabajar(); // Llamará a la versión correcta del método Trabajar
            }
        }
    }
    }

