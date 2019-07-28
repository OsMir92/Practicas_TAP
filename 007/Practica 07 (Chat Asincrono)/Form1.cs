using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_07__Chat_Asincrono_
{
    public partial class Form1 : Form
    {
        static TcpListener escuchador;
        static TcpClient ConectarSocket = default(TcpClient);
        static System.Net.Sockets.TcpClient hablador;
        int puerto;
        string ip;

        public Form1()
        {
            InitializeComponent();
            NumeroPuerto.Minimum = 1;
            NumeroPuerto.Maximum = 9999;
        }

        private void Escuchar_Click(object sender, EventArgs e)
        {
            MensajeEnviado("Conectado...");
            Thread Escuchando = new Thread(EscucharChat2);
            Escuchando.Start();
        }
        private void Enviar_Click(object sender, EventArgs e)
        {
            HablarChat();
        }

        public void EscucharChat2()
        {
            try
            {
                Int32 port = (Int32)NumeroPuerto.Value;
                escuchador = new TcpListener(IPAddress.Any, port);
                escuchador.Start();
                Byte[] bytes = new Byte[256];
                String data = null;

                while (true)
                {
                    TcpClient Cliente = escuchador.AcceptTcpClient();

                    data = null;
                    bool infoDisponible = false;
                    NetworkStream stream = Cliente.GetStream();

                    int i;
                    while (true)
                    {
                        if (!infoDisponible)
                        {
                            infoDisponible = stream.DataAvailable;
                            //Console.WriteLine("Data Available: "+dataAvailable);
                            if (escuchador.Pending())
                            {
                                break;
                            }
                        }

                        if (infoDisponible)
                        {
                            // Loop to receive all the data sent by the client.
                            i = stream.Read(bytes, 0, bytes.Length);
                            data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);

                            MensajeEnviado("    Persona: " + data);
                            infoDisponible = false;
                        }

                        if (escuchador.Pending())
                        {
                            break;
                        }
                    }
                    Cliente.Close();
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                escuchador.Stop();
            }
        }

        private void HablarChat()
        {
            try
            {
                ip = string.Join(".", IP1.Text + IP2.Text + IP3.Text + IP4.Text);
                puerto = (int)EnviarA.Value;

                hablador = new System.Net.Sockets.TcpClient();
                hablador.Connect(ip, puerto);
                NetworkStream serverStream = hablador.GetStream();
                MensajeEnviado("    Yo: " + Mensaje.Text);
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(Mensaje.Text);
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MensajeEnviado(string texto)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            string fecha = DateTime.Now.ToShortTimeString();
            log.Text = log.Text + Environment.NewLine + " >> " + fecha + texto;
        }

        private void SinLetras(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }
    }
}
