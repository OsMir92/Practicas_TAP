using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4__Snake_
{
    public partial class Juego1 : Form
    {
        Graphics g;
        Snake cabeza;
        Comida comida;
        int direccionX = 0, direccionY = 0, frame = 10, puntos = 0;
        //Estos booleanos empiezan en true porque al principio del juego se puede mover el objeto en cualquier direccion
        Boolean ejeX = true, ejeY = true;

        public Juego1()
        {
            InitializeComponent();
            g = PanelG.CreateGraphics();
            cabeza = new Snake(10, 10);
            comida = new Comida();
        }
        
        //Funciones que se ejecutan cada que el intervalo de tiempo pasa
        private void tiempo_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);//Borra todo el graphics para dibujar la serpiente en el siguiente frame
            cabeza.dibujo(g);//Dibuja la cabeza en cada tick del tiempo
            movimiento();//Crea la nueva cabeza en la posicion donde se movera
            comida.dibujarComida(g);
            choqueCuerpo();
            choqueOrila();

            if (cabeza.choques(comida))
            {
                comida.posicionComida();
                cabeza.poner();
                puntos++;
                PuntosNum.Text = puntos.ToString();
                cambiarVelocidad();
                sonido(1);
            }     
        }

        public void cambiarVelocidad()
        {
            if (tiempo.Interval <= 50)
            {
                tiempo.Interval = 50;
            }
            else if (tiempo.Interval > 50)
            {
                tiempo.Interval = tiempo.Interval - 5;
            }
        }

        public void movimiento()
        {
             cabeza.setxy(cabeza.obtenerX() + direccionX, cabeza.obtenerY() + direccionY);
        }

        public void choqueCuerpo()
        {
            Snake temp;
            try
            {
                temp = cabeza.mostrarSiguiente().mostrarSiguiente();
            }
            catch(Exception)
            {
                temp = null;
            }
            while (temp != null)
            {
                if (cabeza.choques(temp))
                {
                    gameOver();
                }
                else
                {
                    temp = temp.mostrarSiguiente();
                }
            }
        }

        public void choqueOrila()
        {
            if (cabeza.obtenerX() < 0 || cabeza.obtenerX() > PanelG.Width - 10 || cabeza.obtenerY() < 0 || cabeza.obtenerY() > PanelG.Height-10)
            {   //Si las dimenciones de ancho o alto del objeto Snake estan por fuera de el ancho o largo del panel de juego se genera el fin del juego
                gameOver();
            }
        }

        public void gameOver()
        {
            try
            {
                int puntajefinal = puntos;
                puntos = 0;
                PuntosNum.Text = "0";
                ejeX = true;
                ejeY = true;
                direccionX = 0;
                direccionY = 0;
                cabeza = new Snake(10, 10);
                comida = new Comida();
                tiempo.Stop();
                tiempo.Interval = 150;
                tiempo.Start();
                sonido(2);

                MessageBox.Show("Has perdido! \nPuntuacion: " + puntajefinal, "Fin del juego");
            }
            catch { }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Cuando el ejeX esta activo se desactiva el movimiento de ejeY y su boolean
            switch (e.KeyCode)
            {
                case Keys.Up:
                    direccionY = -frame;
                    direccionX = 0;
                    ejeX = false;
                    ejeY = true;
                    break;

                case Keys.Down:
                    direccionY = frame;
                    direccionX = 0;
                    ejeX = false;
                    ejeY = true;
                    break;

                case Keys.Right:
                    direccionY = 0;
                    direccionX = frame;
                    ejeX = true;
                    ejeY = false;
                    break;

                case Keys.Left:
                    direccionY = 0;
                    direccionX = -frame;
                    ejeX = true;
                    ejeY = false;
                    break;
            }
        }
     
        private void sonido(int sonido)
        {
            if (sonido == 1)
            {
                System.Media.SoundPlayer sonidoComida = new System.Media.SoundPlayer();
                sonidoComida.Stream = Properties.Resources.Picked_Coin_Echo;
                sonidoComida.Load();
                sonidoComida.Play();
            }

            if (sonido == 2)
            {
                System.Media.SoundPlayer golpe = new System.Media.SoundPlayer();
                golpe.Stream = Properties.Resources.GameOver;
                golpe.Load();
                golpe.Play();
            }
        }
    }
}
