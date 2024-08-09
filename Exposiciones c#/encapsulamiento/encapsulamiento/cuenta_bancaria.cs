using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulamiento
{
    internal class cuenta_bancaria
    {
        // Campos privados
        private decimal balance;

        // Propiedad pública para acceder y modificar el balance  
        public decimal Balance
        {
            get { return balance; }
            private set
            {
                if (value >= 0)
                    balance = value;
            }
        }

        // Constructor
        public cuenta_bancaria(decimal balanceInicial)
        {
            Balance = balanceInicial;
        }

        // Método público para depositar dinero
        public void Depositar(decimal monto)
        {
            if (monto > 0)
            {
                Balance += monto;
                Console.WriteLine($"Se depositaron {monto:C} en la cuenta.");
            }
            else
            {
                Console.WriteLine("El monto a depositar debe ser mayor que 0.");
            }
        }

        // Método público para retirar dinero
        public void Retirar(decimal monto)
        {
            if (monto > 0 && monto <= Balance)
            {
                Balance -= monto;
                Console.WriteLine($"Se retiraron {monto:C} de la cuenta.");
            }
            else
            {
                Console.WriteLine("Monto inválido para retirar.");
            }
        }
    }
}
