using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracción_y_herencia
{
    public class cuenta_ahorro:cunta_bancaria
    {
        private decimal tasaInteres;

        public cuenta_ahorro(decimal balanceInicial, decimal tasaInteres)
            : base(balanceInicial)
        {
            this.tasaInteres = tasaInteres;
        }

        // Implementación del método abstracto para depositar dinero
        public override void Depositar(decimal monto)
        {
            Balance += monto;
            Console.WriteLine($"Se depositaron {monto:C} en la cuenta de ahorros.");
        }

        // Implementación del método abstracto para retirar dinero
        public override void Retirar(decimal monto)
        {
            if (Balance >= monto)
            {
                Balance -= monto;
                Console.WriteLine($"Se retiraron {monto:C} de la cuenta de ahorros.");
            }
            else
            {
                Console.WriteLine("Fondos insuficientes.");
            }
        }

        // Método específico de la cuenta de ahorros
        public void AplicarInteres()
        {
            Balance += Balance * tasaInteres;
            Console.WriteLine($"Se aplicó interés, nuevo balance: {Balance:C}");
        }
    }

    public class CuentaCorriente : cunta_bancaria
    {
        private decimal limiteSobregiro;

        public CuentaCorriente(decimal balanceInicial, decimal limiteSobregiro)
            : base(balanceInicial)
        {
            this.limiteSobregiro = limiteSobregiro;
        }

        // Implementación del método abstracto para depositar dinero
        public override void Depositar(decimal monto)
        {
            Balance += monto;
            Console.WriteLine($"Se depositaron {monto:C} en la cuenta corriente.");
        }

        // Implementación del método abstracto para retirar dinero
        public override void Retirar(decimal monto)
        {
            if (Balance + limiteSobregiro >= monto)
            {
                Balance -= monto;
                Console.WriteLine($"Se retiraron {monto:C} de la cuenta corriente.");
            }
            else
            {
                Console.WriteLine("Fondos insuficientes, incluso con el sobregiro.");
            }
        }
    }
}
