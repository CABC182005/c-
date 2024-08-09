using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atributos_set_get
{
    internal class persona
    {
        // Atributo privado
        private string nombre;

        // Propiedad para acceder y modificar el atributo 'nombre'
        public string Nombre
        {
            get { return nombre; } // Obtener el valor de 'nombre'
            set { nombre = value; } // Establecer el valor de 'nombre'
        }

        // Atributo privado
        private int edad;

        // Propiedad para acceder y modificar el atributo 'edad'
        public int Edad
        {
            get { return edad; } // Obtener el valor de 'edad'
            set
            {
                if (value >= 0) // Validar que la edad no sea negativa
                {
                    edad = value;
                }
                else
                {
                    Console.WriteLine("La edad no puede ser negativa.");
                }
            }
        }

        // Constructor
        public persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
}
