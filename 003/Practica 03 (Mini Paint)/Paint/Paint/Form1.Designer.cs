namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.muestra_Color = new System.Windows.Forms.PictureBox();
            this.area_Dibujo = new System.Windows.Forms.PictureBox();
            this.seleccion_Colores = new System.Windows.Forms.Button();
            this.Imagen_Prediseñada_2_comp = new System.Windows.Forms.Button();
            this.Imagen_Prediseñada_1_comp = new System.Windows.Forms.Button();
            this.Rombo = new System.Windows.Forms.Button();
            this.Rectangulo = new System.Windows.Forms.Button();
            this.Elipse = new System.Windows.Forms.Button();
            this.Triangulo = new System.Windows.Forms.Button();
            this.Curva = new System.Windows.Forms.Button();
            this.figuraL = new System.Windows.Forms.Button();
            this.Borrador = new System.Windows.Forms.Button();
            this.Lapiz = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Abrir = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.Mensaje = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.muestra_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.area_Dibujo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // muestra_Color
            // 
            this.muestra_Color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.muestra_Color.BackColor = System.Drawing.Color.Black;
            this.muestra_Color.Location = new System.Drawing.Point(3, 602);
            this.muestra_Color.Name = "muestra_Color";
            this.muestra_Color.Size = new System.Drawing.Size(63, 11);
            this.muestra_Color.TabIndex = 16;
            this.muestra_Color.TabStop = false;
            // 
            // area_Dibujo
            // 
            this.area_Dibujo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.area_Dibujo.BackColor = System.Drawing.Color.White;
            this.area_Dibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.area_Dibujo.Location = new System.Drawing.Point(72, 3);
            this.area_Dibujo.Name = "area_Dibujo";
            this.area_Dibujo.Size = new System.Drawing.Size(1125, 652);
            this.area_Dibujo.TabIndex = 15;
            this.area_Dibujo.TabStop = false;
            this.area_Dibujo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.area_Dibujo_MouseClick);
            this.area_Dibujo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.area_Dibujo_MouseDown);
            this.area_Dibujo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.area_Dibujo_MouseMove);
            // 
            // seleccion_Colores
            // 
            this.seleccion_Colores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.seleccion_Colores.BackgroundImage = global::Paint.Properties.Resources.Colors;
            this.seleccion_Colores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seleccion_Colores.Location = new System.Drawing.Point(3, 615);
            this.seleccion_Colores.Name = "seleccion_Colores";
            this.seleccion_Colores.Size = new System.Drawing.Size(63, 63);
            this.seleccion_Colores.TabIndex = 14;
            this.Mensaje.SetToolTip(this.seleccion_Colores, "Cambiar color");
            this.seleccion_Colores.UseVisualStyleBackColor = true;
            this.seleccion_Colores.Click += new System.EventHandler(this.seleccion_Colores_Click);
            // 
            // Imagen_Prediseñada_2_comp
            // 
            this.Imagen_Prediseñada_2_comp.BackgroundImage = global::Paint.Properties.Resources.Emojis;
            this.Imagen_Prediseñada_2_comp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_Prediseñada_2_comp.Location = new System.Drawing.Point(36, 195);
            this.Imagen_Prediseñada_2_comp.Name = "Imagen_Prediseñada_2_comp";
            this.Imagen_Prediseñada_2_comp.Size = new System.Drawing.Size(30, 30);
            this.Imagen_Prediseñada_2_comp.TabIndex = 13;
            this.Mensaje.SetToolTip(this.Imagen_Prediseñada_2_comp, "( ͡° ͜ʖ ͡°)");
            this.Imagen_Prediseñada_2_comp.UseVisualStyleBackColor = true;
            this.Imagen_Prediseñada_2_comp.Click += new System.EventHandler(this.Imagen_Prediseñada_2_comp_Click);
            // 
            // Imagen_Prediseñada_1_comp
            // 
            this.Imagen_Prediseñada_1_comp.BackgroundImage = global::Paint.Properties.Resources.Imagenes_Pre_Diseñadas;
            this.Imagen_Prediseñada_1_comp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_Prediseñada_1_comp.Location = new System.Drawing.Point(3, 195);
            this.Imagen_Prediseñada_1_comp.Name = "Imagen_Prediseñada_1_comp";
            this.Imagen_Prediseñada_1_comp.Size = new System.Drawing.Size(30, 30);
            this.Imagen_Prediseñada_1_comp.TabIndex = 12;
            this.Mensaje.SetToolTip(this.Imagen_Prediseñada_1_comp, "Figura prediseñada");
            this.Imagen_Prediseñada_1_comp.UseVisualStyleBackColor = true;
            this.Imagen_Prediseñada_1_comp.Click += new System.EventHandler(this.Imagenes_Prediseñadas_Click);
            // 
            // Rombo
            // 
            this.Rombo.BackgroundImage = global::Paint.Properties.Resources.Rombo;
            this.Rombo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rombo.Location = new System.Drawing.Point(36, 163);
            this.Rombo.Name = "Rombo";
            this.Rombo.Size = new System.Drawing.Size(30, 30);
            this.Rombo.TabIndex = 11;
            this.Mensaje.SetToolTip(this.Rombo, "Rombo");
            this.Rombo.UseVisualStyleBackColor = true;
            this.Rombo.Click += new System.EventHandler(this.Rombo_Click);
            // 
            // Rectangulo
            // 
            this.Rectangulo.BackgroundImage = global::Paint.Properties.Resources.Rectangulo;
            this.Rectangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rectangulo.Location = new System.Drawing.Point(3, 163);
            this.Rectangulo.Name = "Rectangulo";
            this.Rectangulo.Size = new System.Drawing.Size(30, 30);
            this.Rectangulo.TabIndex = 10;
            this.Mensaje.SetToolTip(this.Rectangulo, "Cuadrado");
            this.Rectangulo.UseVisualStyleBackColor = true;
            this.Rectangulo.Click += new System.EventHandler(this.Rectangulo_Click);
            // 
            // Elipse
            // 
            this.Elipse.BackgroundImage = global::Paint.Properties.Resources.Elipse;
            this.Elipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Elipse.Location = new System.Drawing.Point(36, 131);
            this.Elipse.Name = "Elipse";
            this.Elipse.Size = new System.Drawing.Size(30, 30);
            this.Elipse.TabIndex = 9;
            this.Mensaje.SetToolTip(this.Elipse, "Circulo");
            this.Elipse.UseVisualStyleBackColor = true;
            this.Elipse.Click += new System.EventHandler(this.Elipse_Click);
            // 
            // Triangulo
            // 
            this.Triangulo.BackgroundImage = global::Paint.Properties.Resources.Triangulo;
            this.Triangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Triangulo.Location = new System.Drawing.Point(3, 131);
            this.Triangulo.Name = "Triangulo";
            this.Triangulo.Size = new System.Drawing.Size(30, 30);
            this.Triangulo.TabIndex = 8;
            this.Mensaje.SetToolTip(this.Triangulo, "Triangulo (Seleccione 3 puntos)");
            this.Triangulo.UseVisualStyleBackColor = true;
            this.Triangulo.Click += new System.EventHandler(this.Triangulo_Click);
            // 
            // Curva
            // 
            this.Curva.BackgroundImage = global::Paint.Properties.Resources.Linea_Curva;
            this.Curva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Curva.Location = new System.Drawing.Point(36, 99);
            this.Curva.Name = "Curva";
            this.Curva.Size = new System.Drawing.Size(30, 30);
            this.Curva.TabIndex = 7;
            this.Mensaje.SetToolTip(this.Curva, "Linea curva");
            this.Curva.UseVisualStyleBackColor = true;
            this.Curva.Click += new System.EventHandler(this.Linea_Curva_Click);
            // 
            // figuraL
            // 
            this.figuraL.BackgroundImage = global::Paint.Properties.Resources.Lineas;
            this.figuraL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.figuraL.Location = new System.Drawing.Point(3, 99);
            this.figuraL.Name = "figuraL";
            this.figuraL.Size = new System.Drawing.Size(30, 30);
            this.figuraL.TabIndex = 6;
            this.Mensaje.SetToolTip(this.figuraL, "Poligono libre (click derecho para cerrar figura)");
            this.figuraL.UseVisualStyleBackColor = true;
            this.figuraL.Click += new System.EventHandler(this.Linea_Click);
            // 
            // Borrador
            // 
            this.Borrador.BackgroundImage = global::Paint.Properties.Resources.Borrar;
            this.Borrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Borrador.Location = new System.Drawing.Point(36, 67);
            this.Borrador.Name = "Borrador";
            this.Borrador.Size = new System.Drawing.Size(30, 30);
            this.Borrador.TabIndex = 5;
            this.Mensaje.SetToolTip(this.Borrador, "Borrador");
            this.Borrador.UseVisualStyleBackColor = true;
            this.Borrador.Click += new System.EventHandler(this.Borrador_Click);
            // 
            // Lapiz
            // 
            this.Lapiz.BackgroundImage = global::Paint.Properties.Resources.Lapiz;
            this.Lapiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lapiz.Location = new System.Drawing.Point(3, 67);
            this.Lapiz.Name = "Lapiz";
            this.Lapiz.Size = new System.Drawing.Size(30, 30);
            this.Lapiz.TabIndex = 4;
            this.Mensaje.SetToolTip(this.Lapiz, "Lapiz");
            this.Lapiz.UseVisualStyleBackColor = true;
            this.Lapiz.Click += new System.EventHandler(this.Lapiz_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackgroundImage = global::Paint.Properties.Resources.Guardar;
            this.Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Guardar.Location = new System.Drawing.Point(36, 35);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(30, 30);
            this.Guardar.TabIndex = 3;
            this.Mensaje.SetToolTip(this.Guardar, "Guardar progreso actual");
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Abrir
            // 
            this.Abrir.BackgroundImage = global::Paint.Properties.Resources.Abrir;
            this.Abrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Abrir.Location = new System.Drawing.Point(3, 35);
            this.Abrir.Name = "Abrir";
            this.Abrir.Size = new System.Drawing.Size(30, 30);
            this.Abrir.TabIndex = 2;
            this.Mensaje.SetToolTip(this.Abrir, "Abrir imagen existente");
            this.Abrir.UseVisualStyleBackColor = true;
            this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackgroundImage = global::Paint.Properties.Resources.Eliminar;
            this.Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eliminar.Location = new System.Drawing.Point(36, 3);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(30, 30);
            this.Eliminar.TabIndex = 1;
            this.Mensaje.SetToolTip(this.Eliminar, "Borrar progreso actual");
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.AccessibleDescription = "";
            this.Nuevo.BackgroundImage = global::Paint.Properties.Resources.Nuevo;
            this.Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Nuevo.Location = new System.Drawing.Point(3, 3);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(30, 30);
            this.Nuevo.TabIndex = 0;
            this.Mensaje.SetToolTip(this.Nuevo, "Crear nuevo dibujo");
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "1 px";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.tamano_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-1, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "5px";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.tamano_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-1, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "10 px";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.tamano_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(-1, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "15 px";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.tamano_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(3, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 226);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Paint.Properties.Resources.Lapiz;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 67);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(-1, 129);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "20 px";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.tamano_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.muestra_Color);
            this.Controls.Add(this.area_Dibujo);
            this.Controls.Add(this.seleccion_Colores);
            this.Controls.Add(this.Imagen_Prediseñada_2_comp);
            this.Controls.Add(this.Imagen_Prediseñada_1_comp);
            this.Controls.Add(this.Rombo);
            this.Controls.Add(this.Rectangulo);
            this.Controls.Add(this.Elipse);
            this.Controls.Add(this.Triangulo);
            this.Controls.Add(this.Curva);
            this.Controls.Add(this.figuraL);
            this.Controls.Add(this.Borrador);
            this.Controls.Add(this.Lapiz);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Abrir);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Nuevo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MiniPaint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.muestra_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.area_Dibujo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Abrir;
        private System.Windows.Forms.Button Borrador;
        private System.Windows.Forms.Button Lapiz;
        private System.Windows.Forms.Button Curva;
        private System.Windows.Forms.Button figuraL;
        private System.Windows.Forms.Button Elipse;
        private System.Windows.Forms.Button Triangulo;
        private System.Windows.Forms.Button Rombo;
        private System.Windows.Forms.Button Rectangulo;
        private System.Windows.Forms.Button Imagen_Prediseñada_2_comp;
        private System.Windows.Forms.Button Imagen_Prediseñada_1_comp;
        private System.Windows.Forms.Button seleccion_Colores;
        private System.Windows.Forms.PictureBox area_Dibujo;
        private System.Windows.Forms.PictureBox muestra_Color;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolTip Mensaje;
    }
}

