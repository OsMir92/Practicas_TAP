using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_05__Sockets_
{
    public partial class Form1 : Form
    {
        string nombreArchivo;

        public Form1()
        {
            InitializeComponent();
        }

        private void seleccionArchivo_Click(object sender, EventArgs e)
        {
            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                nombreArchivo = abrirArchivo.FileName;
                msg(" Archivo listo para enviar: "+nombreArchivo);
            }
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ipNueva = new IPAddress(ipAddressControl1.GetAddressBytes());
                int puerto = (int)numeroPuerto.Value;

                if (ipAddressControl1.AnyBlank)
                {
                    MessageBox.Show("El IP es erroneo o vacio");
                }
              
                IPEndPoint ipEndPoint = new IPEndPoint(ipNueva, puerto);

                //Delimitar el numero de puertos dependiendo del IPEndPoint
                numeroPuerto.Minimum = IPEndPoint.MinPort;
                numeroPuerto.Maximum = IPEndPoint.MaxPort;
               
                // Crea el nuevo socket
                Socket cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                //Conectamos el socket con el ip del host
                cliente.Connect(ipEndPoint);
                msg(" Conexion aceptada!");

                //Enviamos el archivo al dispositivo que esta escuchando
                cliente.SendFile(nombreArchivo);

                msg(" Archivo Enviado!");

                // Liberamos el socket
                cliente.Shutdown(SocketShutdown.Both);
                cliente.Close();
            }

            catch (SocketException ex)
            {
                msg(" " + ex.Message);
            }
            catch(Exception ex2)
            {
                msg(" " + ex2.Message);
            }
            
        }

        private void conectarServidor_Click(object sender, EventArgs e)
        {
            TcpListener servidor = null;
            try
            {
                IPAddress ipNueva = new IPAddress(ipAddressControl1.GetAddressBytes());
                int puerto = (int)numeroPuerto.Value;

                servidor = new TcpListener(ipNueva, puerto);
                servidor.Start();

                msg(" Escuchando...");
                var recibidor = servidor.AcceptTcpClient();
                var stream = recibidor.GetStream();
                var output = File.Create("resultado.txt");
                {
                    // Leer archivo de 1kb por tick
                    var buffer = new byte[1024];
                    int bytesLeidos;
                    while ((bytesLeidos = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        output.Write(buffer, 0, bytesLeidos);
                    }
                }
                msg(" Archivo recibido!");

                servidor.Stop();
            }
            catch (SocketException ex)
            {
                msg(" " + ex.Message);
            }

        }

        public void msg(string mesg)
        {
            string fecha = DateTime.Now.ToShortTimeString();
            log.Text = log.Text + Environment.NewLine + " >> " + fecha + mesg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            msg(" Servidor iniciado...");
        }
    }
}
