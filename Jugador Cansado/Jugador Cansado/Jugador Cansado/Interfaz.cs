using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jugador_Cansado
{
    public interface IJugador
    {
        public int tiempo { get; set; } //metodos que te permiten acceder a la variable, sirve para despues

        public bool Cansado();
        public bool Correr(int minutos);
        public void Descansar(int minutos);
    }
}
