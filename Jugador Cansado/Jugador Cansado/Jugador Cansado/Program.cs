using System;

namespace Jugador_Cansado
{
    public class Program
    {
        public static void Main()
        {
            IJugador amateur = new Amateur();
            amateur.Correr(15);
            amateur.Descansar(5);
            amateur.Cansado();
            amateur.Correr(10);
            amateur.Cansado();

            IJugador pro = new Amateur();
            pro.Correr(35);
            pro.Descansar(5);
            pro.Cansado();
            pro.Correr(10);
            pro.Cansado();
        }
    }
}
