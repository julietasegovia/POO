using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico
{
    public class CuentaCorriente : CuentaBancaria
    {
        private float limite { get; set; }

        public CuentaCorriente(float limiteIni)
        {
            limite = limiteIni;
        }

        public override void Extraer(float monto)
        {
            if (ObtenerSaldo() - monto >= limite)
                RestarSaldo(monto);
            else
                Console.WriteLine($"No se puede retirar más dinero del limitado. El limite de su cuenta es de {limite}. Por favor ingrese un valor válido.");
        }
    }
}
