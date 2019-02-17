namespace FigurasGeometricas
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dato1 = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dato2 = new System.Windows.Forms.Label();
            this.resultado1 = new System.Windows.Forms.Label();
            this.resultado2 = new System.Windows.Forms.Label();
            this.resultado1T = new System.Windows.Forms.TextBox();
            this.resultado2T = new System.Windows.Forms.TextBox();
            this.dato3 = new System.Windows.Forms.Label();
            this.dato3T = new System.Windows.Forms.TextBox();
            this.dato2T = new System.Windows.Forms.TextBox();
            this.dato1T = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(66, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cuadrado",
            "Circulo",
            "Rectangulo",
            "Triangulo"});
            this.comboBox1.Location = new System.Drawing.Point(152, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dato1
            // 
            this.dato1.AutoSize = true;
            this.dato1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato1.Location = new System.Drawing.Point(463, 142);
            this.dato1.Name = "dato1";
            this.dato1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dato1.Size = new System.Drawing.Size(57, 20);
            this.dato1.TabIndex = 2;
            this.dato1.Text = "Dato 1";
            this.dato1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dato1.Visible = false;
            // 
            // calcular
            // 
            this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.Location = new System.Drawing.Point(565, 403);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(100, 34);
            this.calcular.TabIndex = 3;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Figuras Geometricas";
            // 
            // dato2
            // 
            this.dato2.AutoSize = true;
            this.dato2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato2.Location = new System.Drawing.Point(463, 185);
            this.dato2.Name = "dato2";
            this.dato2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dato2.Size = new System.Drawing.Size(57, 20);
            this.dato2.TabIndex = 6;
            this.dato2.Text = "Dato 2";
            this.dato2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dato2.Visible = false;
            // 
            // resultado1
            // 
            this.resultado1.AutoSize = true;
            this.resultado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado1.Location = new System.Drawing.Point(463, 305);
            this.resultado1.Name = "resultado1";
            this.resultado1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultado1.Size = new System.Drawing.Size(95, 20);
            this.resultado1.TabIndex = 8;
            this.resultado1.Text = "Resultado 1";
            this.resultado1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultado1.Visible = false;
            // 
            // resultado2
            // 
            this.resultado2.AutoSize = true;
            this.resultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado2.Location = new System.Drawing.Point(463, 347);
            this.resultado2.Name = "resultado2";
            this.resultado2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultado2.Size = new System.Drawing.Size(95, 20);
            this.resultado2.TabIndex = 9;
            this.resultado2.Text = "Resultado 2";
            this.resultado2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultado2.Visible = false;
            // 
            // resultado1T
            // 
            this.resultado1T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado1T.Location = new System.Drawing.Point(598, 305);
            this.resultado1T.Name = "resultado1T";
            this.resultado1T.ReadOnly = true;
            this.resultado1T.Size = new System.Drawing.Size(100, 26);
            this.resultado1T.TabIndex = 10;
            this.resultado1T.Visible = false;
            // 
            // resultado2T
            // 
            this.resultado2T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado2T.Location = new System.Drawing.Point(598, 347);
            this.resultado2T.Name = "resultado2T";
            this.resultado2T.ReadOnly = true;
            this.resultado2T.Size = new System.Drawing.Size(100, 26);
            this.resultado2T.TabIndex = 11;
            this.resultado2T.Visible = false;
            // 
            // dato3
            // 
            this.dato3.AutoSize = true;
            this.dato3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato3.Location = new System.Drawing.Point(463, 230);
            this.dato3.Name = "dato3";
            this.dato3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dato3.Size = new System.Drawing.Size(57, 20);
            this.dato3.TabIndex = 14;
            this.dato3.Text = "Dato 3";
            this.dato3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dato3.Visible = false;
            // 
            // dato3T
            // 
            this.dato3T.Location = new System.Drawing.Point(598, 230);
            this.dato3T.Name = "dato3T";
            this.dato3T.Size = new System.Drawing.Size(100, 20);
            this.dato3T.TabIndex = 18;
            this.dato3T.Visible = false;
            this.dato3T.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validate);
            // 
            // dato2T
            // 
            this.dato2T.Location = new System.Drawing.Point(598, 185);
            this.dato2T.Name = "dato2T";
            this.dato2T.Size = new System.Drawing.Size(100, 20);
            this.dato2T.TabIndex = 17;
            this.dato2T.Visible = false;
            this.dato2T.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validate);
            // 
            // dato1T
            // 
            this.dato1T.Location = new System.Drawing.Point(598, 142);
            this.dato1T.Name = "dato1T";
            this.dato1T.Size = new System.Drawing.Size(100, 20);
            this.dato1T.TabIndex = 16;
            this.dato1T.Visible = false;
            this.dato1T.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.dato3T);
            this.Controls.Add(this.dato2T);
            this.Controls.Add(this.dato3);
            this.Controls.Add(this.dato1T);
            this.Controls.Add(this.resultado2T);
            this.Controls.Add(this.resultado1T);
            this.Controls.Add(this.resultado2);
            this.Controls.Add(this.resultado1);
            this.Controls.Add(this.dato2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.dato1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Figuras Geometricas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label dato1;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dato2;
        private System.Windows.Forms.Label resultado1;
        private System.Windows.Forms.Label resultado2;
        private System.Windows.Forms.TextBox resultado1T;
        private System.Windows.Forms.TextBox resultado2T;
        private System.Windows.Forms.Label dato3;
        private System.Windows.Forms.TextBox dato3T;
        private System.Windows.Forms.TextBox dato2T;
        private System.Windows.Forms.TextBox dato1T;
    }
}

