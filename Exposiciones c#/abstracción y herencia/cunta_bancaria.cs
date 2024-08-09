using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracción_y_herencia
{
    public abstract class cunta_bancaria
    {
        public decimal Balance { get; protected set; }

        public cunta_bancaria(decimal balanceInicial)
        {
            Balance = balanceInicial;
        }

        // Método abstracto para depositar dinero
        public abstract void Depositar(decimal monto);

        // Método abstracto para retirar dinero
        public abstract void Retirar(decimal monto);
    }
}
