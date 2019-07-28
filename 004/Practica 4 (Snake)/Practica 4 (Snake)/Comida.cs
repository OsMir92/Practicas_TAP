using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4__Snake_
{
    class Comida : Instanciador
    {
        public Comida()
        {
            this.x = numRandom(65);
            this.y = numRandom(35);
        }

        public void posicionComida()
        {
            this.x = numRandom(65);
            this.y = numRandom(35);
        }

        public void dibujarComida(Graphics g)
        {
            g.DrawImage(Properties.Resources.manzana, new Rectangle(this.x, this.y, this.ancho, this.ancho));
        }

        public int numRandom(int num)
        {
            Random random = new Random();
            int numeroR = random.Next(0,num)*10;

            return numeroR;
        }
    }
}
