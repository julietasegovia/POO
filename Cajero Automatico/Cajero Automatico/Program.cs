using System;

namespace Cajero_Automatico
{
    public class Program
    {
        static void Main()
        {
            CajaDeAhorro ahorro = new CajaDeAhorro();
            ahorro.Depositar(1000);
            ahorro.Extraer(400);
            ahorro.Extraer(800); // debe rechazarse
            ahorro.MostrarSaldo(); // debe mostrar 600

            CuentaCorriente corriente = new CuentaCorriente(500); // descubierto:500
            corriente.Depositar(200);
            corriente.Extraer(600); // queda en -400, es valido
            corriente.Extraer(200); // supera el descubierto, debe rechazarse
            corriente.MostrarSaldo(); // debe mostrar -400

            Banco banco = new Banco();
            CajaDeAhorro ahorroB = new CajaDeAhorro();
            CuentaCorriente corrienteB = new CuentaCorriente(500);
            banco.agregarCuenta(ahorroB);
            banco.agregarCuenta(corrienteB);
            ahorroB.Depositar(1000);
            banco.transferir(ahorroB, corrienteB, 300); // debe funcionar
            banco.transferir(ahorroB, corrienteB, 900); // debe rechazarse, saldo
        }
    }
}
