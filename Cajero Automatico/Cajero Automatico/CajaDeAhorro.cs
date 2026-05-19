using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico
{
    public class CajaDeAhorro : CuentaBancaria
    {
        public override void Extraer(float monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("El monto a extraer debe ser positivo.");
                return;
            }

            if (ObtenerSaldo() - monto >= 0)
                RestarSaldo(monto);
            else
                Console.WriteLine("No se puede retirar más dinero del almacenado. Por favor ingrese un valor válido.");
        }
    }
}
