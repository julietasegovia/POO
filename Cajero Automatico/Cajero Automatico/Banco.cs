using System;
using System.Collections.Generic;

namespace Cajero_Automatico
{
    public class Banco
    {
        private List<CuentaBancaria> cuentas = new List<CuentaBancaria>();

        public void agregarCuenta(CuentaBancaria cuenta)
        {
            cuentas.Add(cuenta);
        }

        public void transferir(CuentaBancaria origen, CuentaBancaria destino, float monto)
        {
            if (!cuentas.Contains(origen))
            {
                Console.WriteLine("La cuenta origen no está registrada en el banco. Por favor ingrese una cuenta válida");
                return;
            }

            if (!cuentas.Contains(destino))
            {
                Console.WriteLine("La cuenta destino no está registrada en el banco. Por favor ingrese una cuenta válida");
                return;
            }

            if (monto <= 0)
            {
                Console.WriteLine("El monto de la transferencia debe ser positivo. Por favor ingrese un valor válido");
                return;
            }

            origen.Extraer(monto);

            destino.Depositar(monto);
        }
    }
}