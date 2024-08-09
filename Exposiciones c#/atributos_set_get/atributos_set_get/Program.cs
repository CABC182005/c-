using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atributos_set_get
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de Persona
            persona persona1 = new persona("Camilo", 25);

            // Usar el método get para obtener los valores de los atributos
            Console.WriteLine($"Nombre: {persona1.Nombre}, Edad: {persona1.Edad}");

            // Usar el método set para modificar los valores de los atributos
            persona1.Nombre = "Isabella";
            persona1.Edad = 30;

            // Mostrar los nuevos valores
            Console.WriteLine($"Nombre: {persona1.Nombre}, Edad: {persona1.Edad}");

            // Intentar establecer una edad negativa (no se permitirá)
            persona1.Edad = -5; // Salida: La edad no puede ser negativa.
        }
    }
}
