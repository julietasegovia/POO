using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaforo
{
    public class Semaforo
    {
        public string color;
        public int segundos = 0;
        public bool intermitente = false;

        public string mostrarColor()
        {
            return color;
        }

        public void ponerEnIntermitente() 
        {
            intermitente = true;
        }

        public void sacarDeIntermitente()
        {
            intermitente = false;
        }

        public void pasoDelTiempo(int mas_segundos)
        {
            segundos += mas_segundos;

            bool cambio = true;

            while (cambio) {

                cambio = false;

                if (intermitente)
                {
                    if (segundos % 2 == 0)
                        color = "Amarillo";
                    else
                        color = "Apagado";

                    segundos++;
                }

                else { 
                    if (color == "Rojo" && segundos >= 30)
                    {
                        color = "Rojo + Amarillo";
                        segundos -= 30;
                        cambio = true;
                    }

                     else if (color == "Rojo + Amarillo" && segundos >= 2)
                    {
                        color = "Verde";
                        segundos -= 2;
                        cambio = true;
                    }

                    else if (color == "Verde" && segundos >= 20)
                    {
                        color = "Amarillo";
                        segundos -= 20;
                        cambio = true;
                    }

                    else if (color == "Amarillo" && segundos >= 2)
                    {
                        color = "Rojo";
                        segundos -= 2;
                        cambio = true;
                    }
                }
            }
        }
    }

}
