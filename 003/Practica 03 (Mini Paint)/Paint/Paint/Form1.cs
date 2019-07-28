using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Color selecciona_Color = Color.Black;
        public Point actual = new Point();
        public Point viejo = new Point();
        public Pen p = new Pen(Color.Black, 8);
        public Pen b = new Pen(Color.White, 16);
        public SolidBrush sb = new SolidBrush(Color.Gold);
        string tiempo = DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");

        bool lapizBorra = true;
        Graphics g;

        //Este bool se activa para tomar las coordenadas al dibujar
        bool rectBool = false;
        bool elipBool = false;
        bool figlibrebool = false;
        bool imagenPredibool1 = false;
        bool imagenPredibool2 = false;
        bool trianguloBool = false;
        bool romboBool = false;
        private List<Point> figuraLibre = new List<Point>();
        private List<Point> triangulo = new List<Point>();

        int posY;
        int posX;

        public Form1()
        {
            InitializeComponent();
            g = area_Dibujo.CreateGraphics();
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            if (area_Dibujo == null)
            {
                Clear();
            }
            else
            {
                DialogResult d = MessageBox.Show("¿Desea guardar su dibujo actual?", "Nuevo", MessageBoxButtons.YesNoCancel);
                if (d == DialogResult.Yes)
                {
                    Guardado();
                }
                else if (d == DialogResult.No)
                {
                    Clear();
                }
            }
        }

        private Bitmap DrawControlToBitmap(Control control)
        {   //Pasat graphics a imagen para guardado

            Bitmap dibujazo = new Bitmap(area_Dibujo.Width, area_Dibujo.Height);
            Graphics gr = Graphics.FromImage(dibujazo);
            Rectangle rect = control.RectangleToScreen(control.ClientRectangle);
            gr.CopyFromScreen(rect.Location, Point.Empty, control.Size);

            return dibujazo;

        }//Fin de graphics a bitmap

        private void Eliminar_Click(object sender, EventArgs e)
        {
            //Pregunta antes de borrar todo
            DialogResult clr = MessageBox.Show("¿Desea borrar todo el progreso?", "Borrar dibujo", MessageBoxButtons.YesNo);
            if (clr == DialogResult.Yes)
            {
                Clear();
            }
        }
        
        public void Clear()
        {   //Metodo publico para limpiar PictureBox
            area_Dibujo.Refresh();
            this.area_Dibujo.Image = null;
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                area_Dibujo.Image = new Bitmap(open.FileName);
            }

            Graphics g = Graphics.FromImage(area_Dibujo.Image);
            area_Dibujo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Guardado()
        {
            Bitmap dibujazo = DrawControlToBitmap(area_Dibujo);

            //Guardado SaveFile
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Bitmap Image (.bmp)|*.bmp|JPEG Image (.jpeg)|*.jpeg";
            save.Title = "Guardar archivo";
            save.InitialDirectory = "C:/";
            save.RestoreDirectory = true;
            save.ValidateNames = true;
            save.FileName = tiempo;

            ImageFormat format = ImageFormat.Bmp;

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                switch (save.FilterIndex)
                {
                    case 1:
                        format = ImageFormat.Jpeg;
                        break;

                    case 2:
                        format = ImageFormat.Bmp;
                        break;
                }

                dibujazo.Save(save.FileName, format);

                MessageBox.Show("Guardado exitoso", "Guardar");
            }

        }//Fin de Guardado

        private void Guardar_Click(object sender, EventArgs e)
        {Guardado();}

        private void Lapiz_Click(object sender, EventArgs e)
        {
            lapizBorra = true;
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
        }

        private void Borrador_Click(object sender, EventArgs e)
        {
            b.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            lapizBorra = false;
        }

        private void Linea_Click(object sender, EventArgs e)
        {
            figlibrebool = true;
        }

        private void DrawLine(Point p1, Point p2)
        {
            g.DrawLine(p, p1, p2);
        }

        private void seleccion_Colores_Click(object sender, EventArgs e)
        {
            color_Dialog();
        }

        public void color_Dialog()
        {
            ColorDialog cD = new ColorDialog();
            cD.ShowDialog();
            selecciona_Color = cD.Color;

            muestra_Color.BackColor = selecciona_Color;
            p.Color = cD.Color;
        }

        private void area_Dibujo_MouseDown(object sender, MouseEventArgs e)
        {   //Al hacer click en el panel determinar si se dibujara una figura o solo se pintara con la pluma
            viejo = e.Location;
            posX = e.X;
            posY = e.Y;

            if (rectBool)
            { rectanguloDibuja(); }

            if (elipBool)
            { circuloDibuja(); }

            if (imagenPredibool1)
            { imagenPredi1(); }

            if (imagenPredibool2)
            { imagenPredi2(); }

            if (romboBool)
            { romboDibuja(); }

        }

        private void area_Dibujo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && lapizBorra == true)
            {   //Dibuja la linea con la pluma seleccionada
                actual = e.Location;
                g.DrawLine(p, viejo, actual);
                viejo = actual;
            }

            else if (e.Button == MouseButtons.Left && lapizBorra == false)
            {   //Esta pluma funciona como borrador
                actual = e.Location;
                g.DrawLine(b, viejo, actual);
                viejo = actual;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Esta a punto de cerrar la aplicacion. ¿Desea guardar el archivo actual?", "Cerrar aplicacion", MessageBoxButtons.YesNoCancel);
            if (dlg == DialogResult.Yes)
            {
                Guardado();
                e.Cancel = false;
            }
            else if (dlg == DialogResult.No)
            {
                e.Cancel = false;
                this.Activate();
            }

            else if (dlg == DialogResult.Cancel)
            {e.Cancel = true;}
        }

        private void Rectangulo_Click(object sender, EventArgs e)
        {
            rectBool = true;
        }

        private void Elipse_Click(object sender, EventArgs e)
        {
            elipBool = true;
        }

        private void Triangulo_Click(object sender, EventArgs e)
        {
            trianguloBool = true;
        }

        private void Rombo_Click(object sender, EventArgs e)
        {
            romboBool = true;
        }

        private void romboDibuja()
        {
            Point point1 = new Point(posX, posY);
            Point point2 = new Point(posX + 100, posY + 100);
            Point point3 = new Point(posX + 200, posY);
            Point point4 = new Point(posX + 100, posY - 100);

            Point[] curvePoints =
            {point1, point2, point3, point4};

            g.DrawPolygon(p, curvePoints);
            romboBool = false;

        }

        private void Imagenes_Prediseñadas_Click(object sender, EventArgs e)
        {
            imagenPredibool1 = true;
        }

        private void imagenPredi1()
        {
            Point point1 = new Point(500, 100);
            Point point5 = new Point(500, 600);
            Point point2 = new Point(200, 600);
            Point point6 = new Point(350, 350);
            Point point3 = new Point(800, 600);
            Point point4 = new Point(650, 350);
            Point point7 = new Point(650, 350);
            Point[] curvePoints =
            {point1,point2,point3, point4,point5,point6,point7};

            g.FillPolygon(sb, curvePoints);
            imagenPredibool1 = false;
        }

        private void Linea_Curva_Click(object sender, EventArgs e)
        {

        }

        private void rectanguloDibuja()
        {
            //Objeto rectangulo
            g.DrawRectangle(p, posX-50,posY-50,100,100);

            //Fuerza los procesos regresar el control al usuario
            g.Flush();

            //Cierra el booleano que dibuja el rectangulo
            rectBool = false;

        }

        private void circuloDibuja()
        {
            g.DrawEllipse(p, posX - 50, posY - 50, 100, 100);
            g.Flush();
            elipBool = false;
        }

        private void Imagen_Prediseñada_2_comp_Click(object sender, EventArgs e)
        {
            imagenPredibool2 = true;
        }

        private void imagenPredi2()
        {
            g.DrawImage(Properties.Resources.miraste, new Rectangle(posX, posY, 200, 200));
            imagenPredibool2 = false;
        }
        
        private void tamano_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.TabIndex)
            {
                case 17:
                    p.Width = 1;
                    break;

                case 18:
                    p.Width = 5;
                    break;

                case 19:
                    p.Width = 10;
                    break;

                case 20:
                    p.Width = 15;
                    break;

                case 21:
                    p.Width = 20;
                    break;
            }
        }
     
        private void area_Dibujo_MouseClick(object sender, MouseEventArgs e)
        {
            if (figlibrebool)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        //draw line
                        figuraLibre.Add(new Point(e.X, e.Y));
                        if (figuraLibre.Count > 1)
                        {
                            //draw line
                            this.DrawLine(figuraLibre[figuraLibre.Count - 2], figuraLibre[figuraLibre.Count - 1]);
                        }
                        break;

                    case MouseButtons.Right:
                        //finish polygon
                        if (figuraLibre.Count > 2)
                        {
                            //draw last line
                            this.DrawLine(figuraLibre[figuraLibre.Count - 1], figuraLibre[0]);
                            figuraLibre.Clear();
                            figlibrebool = false;
                        }
                        break;
                }
            }

            if (trianguloBool)
            {
                triangulo.Add(new Point(e.X, e.Y));
                if (triangulo.Count == 3)
                {
                    g.DrawLine(p, triangulo[0],triangulo[1]);
                    g.DrawLine(p, triangulo[1],triangulo[2]);
                    g.DrawLine(p, triangulo[2],triangulo[0]);
                    trianguloBool = false;
                }

            }
            
        }

    }
}
