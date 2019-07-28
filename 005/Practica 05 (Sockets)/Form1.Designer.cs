namespace Practica_05__Sockets_
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
            this.abrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.seleccionArchivo = new System.Windows.Forms.Button();
            this.enviar = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.RichTextBox();
            this.conectarServidor = new System.Windows.Forms.Button();
            this.mensajeEmergente = new System.Windows.Forms.ToolTip(this.components);
            this.ipAddressControl1 = new IPAddressControlLib.IPAddressControl();
            this.numeroPuerto = new System.Windows.Forms.NumericUpDown();
            this.direccionIP = new System.Windows.Forms.Label();
            this.puerto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeroPuerto)).BeginInit();
            this.SuspendLayout();
            // 
            // abrirArchivo
            // 
            this.abrirArchivo.Title = "Selecciona archivo a enviar";
            // 
            // seleccionArchivo
            // 
            this.seleccionArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionArchivo.Location = new System.Drawing.Point(751, 347);
            this.seleccionArchivo.Name = "seleccionArchivo";
            this.seleccionArchivo.Size = new System.Drawing.Size(140, 23);
            this.seleccionArchivo.TabIndex = 1;
            this.seleccionArchivo.Text = "Seleccionar Archivo";
            this.mensajeEmergente.SetToolTip(this.seleccionArchivo, "Busca un archivo para enviar al servidor remoto");
            this.seleccionArchivo.UseVisualStyleBackColor = true;
            this.seleccionArchivo.Click += new System.EventHandler(this.seleccionArchivo_Click);
            // 
            // enviar
            // 
            this.enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviar.Location = new System.Drawing.Point(897, 347);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(75, 23);
            this.enviar.TabIndex = 2;
            this.enviar.Text = "Enviar";
            this.mensajeEmergente.SetToolTip(this.enviar, "Crea una conexion temporal para mandar un archivo");
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // log
            // 
            this.log.Enabled = false;
            this.log.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(12, 34);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(996, 273);
            this.log.TabIndex = 3;
            this.log.Text = "";
            // 
            // conectarServidor
            // 
            this.conectarServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conectarServidor.Location = new System.Drawing.Point(136, 347);
            this.conectarServidor.Name = "conectarServidor";
            this.conectarServidor.Size = new System.Drawing.Size(75, 23);
            this.conectarServidor.TabIndex = 4;
            this.conectarServidor.Text = "Recibir archivo";
            this.mensajeEmergente.SetToolTip(this.conectarServidor, "Abre una conexion temporal para recibir un archivo de una conexion pendiente");
            this.conectarServidor.UseVisualStyleBackColor = true;
            this.conectarServidor.Click += new System.EventHandler(this.conectarServidor_Click);
            // 
            // ipAddressControl1
            // 
            this.ipAddressControl1.AllowInternalTab = false;
            this.ipAddressControl1.AutoHeight = true;
            this.ipAddressControl1.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControl1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddressControl1.Location = new System.Drawing.Point(377, 347);
            this.ipAddressControl1.MinimumSize = new System.Drawing.Size(99, 22);
            this.ipAddressControl1.Name = "ipAddressControl1";
            this.ipAddressControl1.ReadOnly = false;
            this.ipAddressControl1.Size = new System.Drawing.Size(99, 22);
            this.ipAddressControl1.TabIndex = 5;
            this.ipAddressControl1.Text = "...";
            this.mensajeEmergente.SetToolTip(this.ipAddressControl1, "Esta direccion IP debe ser la misma en ambas instancias del programa");
            // 
            // numeroPuerto
            // 
            this.numeroPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroPuerto.Location = new System.Drawing.Point(535, 348);
            this.numeroPuerto.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeroPuerto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeroPuerto.Name = "numeroPuerto";
            this.numeroPuerto.Size = new System.Drawing.Size(120, 22);
            this.numeroPuerto.TabIndex = 8;
            this.mensajeEmergente.SetToolTip(this.numeroPuerto, "Introduce un numero de puerto valido dentro del rango");
            this.numeroPuerto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // direccionIP
            // 
            this.direccionIP.AutoSize = true;
            this.direccionIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionIP.Location = new System.Drawing.Point(291, 350);
            this.direccionIP.Name = "direccionIP";
            this.direccionIP.Size = new System.Drawing.Size(80, 16);
            this.direccionIP.TabIndex = 6;
            this.direccionIP.Text = "Direccion IP";
            // 
            // puerto
            // 
            this.puerto.AutoSize = true;
            this.puerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puerto.Location = new System.Drawing.Point(482, 350);
            this.puerto.Name = "puerto";
            this.puerto.Size = new System.Drawing.Size(47, 16);
            this.puerto.TabIndex = 7;
            this.puerto.Text = "Puerto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 403);
            this.Controls.Add(this.numeroPuerto);
            this.Controls.Add(this.puerto);
            this.Controls.Add(this.direccionIP);
            this.Controls.Add(this.ipAddressControl1);
            this.Controls.Add(this.conectarServidor);
            this.Controls.Add(this.log);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.seleccionArchivo);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Transferir archivo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeroPuerto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog abrirArchivo;
        private System.Windows.Forms.Button seleccionArchivo;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.ToolTip mensajeEmergente;
        private System.Windows.Forms.Button conectarServidor;
        private IPAddressControlLib.IPAddressControl ipAddressControl1;
        private System.Windows.Forms.Label direccionIP;
        private System.Windows.Forms.Label puerto;
        private System.Windows.Forms.NumericUpDown numeroPuerto;
    }
}

