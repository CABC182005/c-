using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracción_y_herencia
{
     class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de las clases derivadas
            cunta_bancaria miAhorro = new cuenta_ahorro(1000m, 0.05m);
            cunta_bancaria miCorriente = new CuentaCorriente(500m, 100m);

            // Usar los métodos implementados
            miAhorro.Depositar(200m);
            miAhorro.Retirar(150m);
            ((cuenta_ahorro)miAhorro).AplicarInteres(); // Aplicar interés específico a la cuenta de ahorros

            miCorriente.Depositar(300m);
            miCorriente.Retirar(1000m); // Esto debería utilizar el sobregiro
        }
    }
}
