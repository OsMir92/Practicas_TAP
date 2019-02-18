using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2__Tic_Tac_Toe_
{
    public partial class Form1 : Form
    {
        bool turno = true;
        bool Ganador = false;
        Bitmap J1 = Properties.Resources.Jugador1;
        Bitmap J2 = Properties.Resources.Jugador2;
        int victoriasJ1, victoriasJ2, cuentaTurno = 0;
        String gj1 = " Jugador 1 A GANADO!";
        String gj2 = " Jugador 2 A GANADO!";

        public Form1()
        {
            InitializeComponent();
        }

        private void checaTurno(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                turnoActual();
                if (turno)
                {
                    btn.Image = J1;
                    turno = false;
                }
                else
                {
                    btn.Image = J2;
                    turno = true;
                }
                btn.Enabled = false;
                cuentaTurno++;
                checa_Ganador();
            }
            catch { }
        }

        private void bloquerBtn()
        {
            try
            {
                foreach (Control c in cuadricula.Controls)
                {
                    ((Button)c).Enabled = false;
                }
            }
            catch { }
        }

        private void checa_Ganador()
        {
            try
            {
                // Checa horizontalmente
                if (button1.Image == button2.Image && button2.Image == button3.Image && button1.Enabled == false && button2.Enabled == false && button3.Enabled == false)
                { Ganador = true; }

                else if (button4.Image == button5.Image && button5.Image == button6.Image && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false)
                { Ganador = true; }

                else if (button7.Image == button8.Image && button8.Image == button9.Image && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                { Ganador = true; }

                //Checa vertical
                else if (button1.Image == button4.Image && button4.Image == button7.Image && button1.Enabled == false && button4.Enabled == false && button7.Enabled == false)
                { Ganador = true; }

                else if (button2.Image == button5.Image && button5.Image == button8.Image && button2.Enabled == false && button5.Enabled == false && button8.Enabled == false)
                { Ganador = true; }

                else if (button3.Image == button6.Image && button6.Image == button9.Image && button3.Enabled == false && button6.Enabled == false && button9.Enabled == false)
                { Ganador = true; }

                //Checa diagonal
                else if (button1.Image == button5.Image && button5.Image == button9.Image && button1.Enabled == false && button5.Enabled == false && button9.Enabled == false)
                { Ganador = true; }

                else if (button3.Image == button5.Image && button5.Image == button7.Image && button3.Enabled == false && button5.Enabled == false && button7.Enabled == false)
                { Ganador = true; }


                if (Ganador)
                {
                    bloquerBtn();

                    if (!turno)//El if esta al revez porque al presionar el boton y cambiar turno se modifica el bool antes de checar ganador
                    {
                        if (string.IsNullOrWhiteSpace(nombreJ1.Text)) { MessageBox.Show(gj1); }
                        else { MessageBox.Show(nombreJ1.Text + " A GANADO"); }
                        victoriasJ1++;
                        contadorJ1.Text = Convert.ToString(victoriasJ1);
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(nombreJ2.Text)) { MessageBox.Show(gj2); }
                        else { MessageBox.Show(nombreJ2.Text + " A GANADO"); }

                        victoriasJ2++;
                        contadorJ2.Text = Convert.ToString(victoriasJ2);
                    }
                }

                else
                {
                    if (cuentaTurno == 9)
                    {
                        bloquerBtn();
                        MessageBox.Show("Es un empate");
                    }
                }

            }

            catch { }

        }

        private void turnoActual()
        {
            if (turno) {turnoLabel.Text = nombreJ2.Text;}
            else       {turnoLabel.Text = nombreJ1.Text;}
        }

        
        private void resetGame_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in cuadricula.Controls)
                {
                    ((Button)c).Enabled = true;
                    ((Button)c).Image = null;
                }

                nombreJ1.Text = null;
                nombreJ2.Text = null;
                turnoLabel.Text = null;
                cuentaTurno = 0;
                Ganador = false;
                turno = true;
            }

            catch { }
            }

        private void resetScore_Click(object sender, EventArgs e)
        {
            try
            {
                victoriasJ1 = 0;
                victoriasJ2 = 0;
                contadorJ1.Text = victoriasJ1.ToString();
                contadorJ2.Text = victoriasJ2.ToString();
            }

            catch { }
            }


    }//Fin de clase
}//Fin namespace
