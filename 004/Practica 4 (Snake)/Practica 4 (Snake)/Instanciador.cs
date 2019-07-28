using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4__Snake_
{
    class Instanciador
    {//La clase se utiliza para instanciar las variables protegidas a las clases de comida y snake
        protected int x, y, ancho;

        public Instanciador()
        {
            ancho = 10;
        }

        public Boolean choques(Instanciador i)
        {
            int difx = Math.Abs(this.x - i.x);
            int dify = Math.Abs(this.y - i.y);
            //Checa el posicionamiento para que no esten uno sobre el otro objeto de la serpiente
            if (difx >= 0 && difx < ancho && dify >= 0 && dify < ancho)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
