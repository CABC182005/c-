using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    public  class empleado
    {
        public virtual void Trabajar()
        {
            Console.WriteLine("El empleado está trabajando.");
        }
    }

    // Clase derivada que hereda de Empleado
    public class Desarrollador : empleado
    {
        public override void Trabajar()
        {
            Console.WriteLine("El desarrollador está escribiendo código.");
        }
    }

    // Otra clase derivada que hereda de Empleado
    public class Diseñador : empleado
    {
        public override void Trabajar()
        {
            Console.WriteLine("El diseñador está creando gráficos.");
        }
    }
}
