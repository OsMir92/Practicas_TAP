using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricas
{
    public partial class Form1 : Form
    {
        public Form1()
            {InitializeComponent();
        }
        
        //Dependiendo de la opcion seleccionada en el combobox aparecen y desaparecen opciones.
        #region Casos ComboBox

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {   
                case "Cuadrado":

                    pictureBox1.Image = Properties.Resources.cuadrado;
                    dato1.Text = "Lado";
                    dato1.Visible = true;
                    dato1T.Visible = true;
                    dato2.Visible = false;
                    dato2T.Visible = false;
                    resultado2.Text = "Perimetro";
                    resultado1.Text = "Area";

                    resultado1.Visible = true;
                    resultado1T.Visible = true;
                    resultado2.Visible = true;
                    resultado2T.Visible = true;

                    break;

                case "Circulo":

                    pictureBox1.Image = Properties.Resources.circulo;
                    dato1.Text = "Radio";
                    dato1.Visible = true;
                    dato1T.Visible = true;
                    dato2.Visible = false;
                    dato2T.Visible = false;
                    dato3.Visible = false;
                    dato3T.Visible = false;

                    resultado1.Visible = true;
                    resultado1.Text = "Area ";
                    resultado1T.Visible = true;
                    resultado2.Visible = true;
                    resultado2.Text = "Perimetro ";
                    resultado2T.Visible = true;

                    break;

                case "Triangulo":

                    pictureBox1.Image = Properties.Resources.triangulo;
                    dato1.Text = "Base (Lado 1)";
                    dato1T.Visible = true;
                    dato2.Visible = true;
                    dato2.Text = "Altura (Lado 2)";
                    dato3T.Visible = true;
                    dato3.Visible = true;
                    dato3.Text = "Lado 3";

                    resultado1.Visible = true;
                    resultado1T.Visible = true;
                    resultado2.Visible = true;
                    resultado2T.Visible = true;

                    break;

                case "Rectangulo":

                    pictureBox1.Image = Properties.Resources.rectangulo;
                    dato1.Text = "Base";
                    dato1T.Visible = Visible;
                    dato2.Text = "Altura";
                    dato2.Visible = true;
                    dato2T.Visible = true;
                    dato3.Visible = false;
                    dato3T.Visible = false;

                    resultado1.Visible = true;
                    resultado1T.Visible = true;
                    resultado2.Visible = true;
                    resultado2T.Visible = true;

                    break;
            }
 
        }
        #endregion

        //Dependiendo de la opcion seleccionada se realizan los calculos necesarios.
        #region Calculos
        private void calcular_Click(object sender, EventArgs e)
        {
            double ar, per, ra , pi = Math.PI;
            double b, a, l, r;

            switch (comboBox1.Text)
            {
                case "Cuadrado":

                    try
                    {
                        l = double.Parse(dato1T.Text);
                        ar = l * l;
                        per = l * 4;
                        resultado1T.Text = ar.ToString("0.00");
                        resultado2T.Text = per.ToString("0.00");
                    }
                    catch
                    {}

                    break;

                case "Circulo":

                    try
                    {
                        r = double.Parse(dato1T.Text);
                        ra = pi * (r * r);
                        per = (2 * pi * r);
                        resultado1T.Text = ra.ToString("0.00");
                        resultado2T.Text = per.ToString("0.00");
                    }
                    catch
                    {}
                    
                    break;

                case "Rectangulo":
                    try
                    {
                        b = double.Parse(dato1T.Text);
                        a = double.Parse(dato2T.Text);
                        ar = (b * a);
                        per = (2 * (b + a));
                        resultado1T.Text = ar.ToString("0.00");
                        resultado2T.Text = per.ToString("00");
                    }
                    catch (Exception)
                    {}
                    
                    break;

                case "Triangulo":
                    /*El calculo del triangulo es el mismo aun cuando sea equilatero, existe la 
                    posibilidad de hacerlo de tal forma que un combobox deternmine si solo se usa
                    una variable para los calculos*/
                    try
                    {
                        b = double.Parse(dato1T.Text);
                        a = double.Parse(dato2T.Text);
                        l = double.Parse(dato3T.Text);
                        ar = ((b * a) / 2);
                        per = (b + a + l);
                        resultado1T.Text = ar.ToString("0.00");
                        resultado2T.Text = per.ToString("0.00");
                    }
                    catch
                    {}

                    break;
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
    

        }

        private void validate(object sender, KeyPressEventArgs e)
        {   //Verifica que la entrada solo sean numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Solo un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
