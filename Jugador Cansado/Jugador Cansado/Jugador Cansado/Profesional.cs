using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jugador_Cansado
{
    public class Profesional : IJugador
    {
        public int tiempo { get; set; } = 40;

        public bool Correr(int mins)
        {
            if (mins < 40)
            {
                tiempo -= mins;
                if (tiempo < 0)
                    tiempo = 0;
                return true;
            }
            return false;
        }

        public bool Cansado()
        {
            if (tiempo == 0)
                return true;
            return false;
        }

        public void Descansar(int minutos)
        {
            tiempo += minutos;
            if (tiempo > 40)
                tiempo = 40;
        }
    }
}
