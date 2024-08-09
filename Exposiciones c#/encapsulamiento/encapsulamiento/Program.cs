using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una cuenta bancaria con un balance inicial
            cuenta_bancaria miCuenta = new cuenta_bancaria(1000m);

            // Depositar dinero
            miCuenta.Depositar(200m); // Salida: Se depositaron $200.00 en la cuenta.

            // Intentar retirar más dinero del que hay en la cuenta
            miCuenta.Retirar(1500m);  // Salida: Monto inválido para retirar.

            // Retirar dinero correctamente
            miCuenta.Retirar(300m);  // Salida: Se retiraron $300.00 de la cuenta.

            // Intentar establecer un balance negativo (no se permite)
            // miCuenta.Balance = -500m; // Error de compilación porque la propiedad es privada para escritura.
        }
    }
    }

