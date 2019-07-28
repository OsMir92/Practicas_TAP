using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4__Snake_
{
    class Snake : Instanciador
    {
        Snake cola;

        public Snake(int x, int y)
        {
            this.x = x;
            this.y = y;
            cola = null;
        }

        public void dibujo(Graphics g)
        {
            if (cola != null)
            {
                cola.dibujo(g);
            }
            g.FillRectangle(new SolidBrush(Color.Green), this.x, this.y, this.ancho, this.ancho);
        }

        public void setxy(int x, int y)
        {
            if (cola != null)
            {
                cola.setxy(this.x, this.y);
            }
            this.x = x;
            this.y = y;

        }

        public void poner()
        {
            if (cola == null)
            {
                cola = new Snake(this.x, this.y);
            }else
            {
                cola.poner();
            }
        }

        public int obtenerX()
        {
            return this.x;
        }

        public int obtenerY()
        {
            return this.y;
        }

        public Snake mostrarSiguiente()
        {
            return cola;
        }

    }
}
