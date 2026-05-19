using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico
{
    public class CuentaBancaria
    {
        private float saldo { get; set; }

        public void Depositar(float monto)
        {
            if (monto == 0 || monto < 0)
                return;
            else
                saldo += monto;
        }

        public virtual void Extraer(float monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("El monto a extraer debe ser positivo.");
                return;
            }
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Dinero en cuenta: ${saldo}");
        }

        //funciones protegidas para poder acceder a una variable privada desde una clase hija
        protected float ObtenerSaldo()
        {
            return saldo;
        }

        protected void RestarSaldo(float monto)
        {
            saldo -= monto;
        }
    }
}
