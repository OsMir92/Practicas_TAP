namespace Practica_07__Chat_Asincrono_
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
            this.Escuchar = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Mensaje = new System.Windows.Forms.TextBox();
            this.IP1 = new System.Windows.Forms.TextBox();
            this.IP2 = new System.Windows.Forms.TextBox();
            this.IP3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumeroPuerto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Enviar = new System.Windows.Forms.Button();
            this.IP4 = new System.Windows.Forms.TextBox();
            this.EnviarA = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroPuerto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnviarA)).BeginInit();
            this.SuspendLayout();
            // 
            // Escuchar
            // 
            this.Escuchar.Location = new System.Drawing.Point(672, 166);
            this.Escuchar.Name = "Escuchar";
            this.Escuchar.Size = new System.Drawing.Size(94, 23);
            this.Escuchar.TabIndex = 0;
            this.Escuchar.Text = "Conectar";
            this.Escuchar.UseVisualStyleBackColor = true;
            this.Escuchar.Click += new System.EventHandler(this.Escuchar_Click);
            // 
            // log
            // 
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log.Location = new System.Drawing.Point(12, 51);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(596, 292);
            this.log.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chat";
            // 
            // Mensaje
            // 
            this.Mensaje.Location = new System.Drawing.Point(18, 396);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(590, 20);
            this.Mensaje.TabIndex = 3;
            // 
            // IP1
            // 
            this.IP1.Location = new System.Drawing.Point(647, 98);
            this.IP1.MaxLength = 3;
            this.IP1.Name = "IP1";
            this.IP1.Size = new System.Drawing.Size(44, 20);
            this.IP1.TabIndex = 4;
            this.IP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SinLetras);
            // 
            // IP2
            // 
            this.IP2.Location = new System.Drawing.Point(697, 98);
            this.IP2.MaxLength = 3;
            this.IP2.Name = "IP2";
            this.IP2.Size = new System.Drawing.Size(44, 20);
            this.IP2.TabIndex = 5;
            this.IP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SinLetras);
            // 
            // IP3
            // 
            this.IP3.Location = new System.Drawing.Point(747, 98);
            this.IP3.MaxLength = 3;
            this.IP3.Name = "IP3";
            this.IP3.Size = new System.Drawing.Size(44, 20);
            this.IP3.TabIndex = 6;
            this.IP3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SinLetras);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(622, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP";
            // 
            // NumeroPuerto
            // 
            this.NumeroPuerto.Location = new System.Drawing.Point(672, 126);
            this.NumeroPuerto.Name = "NumeroPuerto";
            this.NumeroPuerto.Size = new System.Drawing.Size(94, 20);
            this.NumeroPuerto.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Puerto";
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(615, 392);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(75, 23);
            this.Enviar.TabIndex = 10;
            this.Enviar.Text = "Enviar a -->";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // IP4
            // 
            this.IP4.Location = new System.Drawing.Point(797, 98);
            this.IP4.MaxLength = 3;
            this.IP4.Name = "IP4";
            this.IP4.Size = new System.Drawing.Size(44, 20);
            this.IP4.TabIndex = 11;
            // 
            // EnviarA
            // 
            this.EnviarA.Location = new System.Drawing.Point(697, 396);
            this.EnviarA.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.EnviarA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EnviarA.Name = "EnviarA";
            this.EnviarA.Size = new System.Drawing.Size(69, 20);
            this.EnviarA.TabIndex = 12;
            this.EnviarA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 478);
            this.Controls.Add(this.EnviarA);
            this.Controls.Add(this.IP4);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumeroPuerto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IP3);
            this.Controls.Add(this.IP2);
            this.Controls.Add(this.IP1);
            this.Controls.Add(this.Mensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.log);
            this.Controls.Add(this.Escuchar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Chat";
            ((System.ComponentModel.ISupportInitialize)(this.NumeroPuerto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnviarA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Escuchar;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Mensaje;
        private System.Windows.Forms.TextBox IP1;
        private System.Windows.Forms.TextBox IP2;
        private System.Windows.Forms.TextBox IP3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumeroPuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.TextBox IP4;
        private System.Windows.Forms.NumericUpDown EnviarA;
    }
}

