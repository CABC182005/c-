using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    public class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string direccion { get; set; }



        public Persona ()
        {
            nombre = "";
            edad = 0;
            direccion = " ";
        }

        public Persona(string nombre, int edad, string direccion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
        }

        public virtual void mostrarPersona()
        {
            Console.WriteLine($"Hola mi nombre es :{nombre}");
            Console.WriteLine($"tengo {edad} años de edad ");
            Console.WriteLine($"y vivo en : {direccion}");
          
        }

        public async Task ObtenerDatosEmpleadoAsync()
        {
            Console.WriteLine("Obteniendo datos del empleado...");
            await Task.Delay(5000); 
            Console.WriteLine("Datos obtenidos correctamente.");
        }

        public void SolicitarDatosPersona()
        {
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese la edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la dirección: ");
            direccion = Console.ReadLine();

            Console.Write("Ingrese su telefono: ");
            direccion = Console.ReadLine();


        }
    }



}


