using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosolid.Principio_de_Segregación_de_Interfaces__ISP_
{
    public interface ITrabajador
    {
        void Trabajar();
    }

    public interface IComedor
    {
        void Comer();
    }

    public class Robot : ITrabajador
    {
        public void Trabajar()
        {
            Console.WriteLine("Robot trabajando");
        }
    }

    public class Humano : ITrabajador, IComedor
    {
        public void Trabajar()
        {
            Console.WriteLine("Humano trabajando");
        }

        public void Comer()
        {
            Console.WriteLine("Humano comiendo");
        }
    }
}
