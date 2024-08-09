using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos_y_funciones_con_parametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase Calculadora
            calculadora miCalculadora = new calculadora();

            // Llamar al método Sumar con parámetros
            int suma = miCalculadora.Sumar(10, 5);
            Console.WriteLine($"La suma de 10 y 5 es: {suma}"); // Salida: La suma de 10 y 5 es: 15

            // Llamar al método Multiplicar con parámetros
            int producto = miCalculadora.Multiplicar(4, 3);
            Console.WriteLine($"La multiplicacion de 4 y 3 es: {producto}"); // Salida: El producto de 4 y 3 es: 12
        }
    }
}
