namespace Practica_2__Tic_Tac_Toe_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cuadricula = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.resetGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreJ1 = new System.Windows.Forms.TextBox();
            this.nombreJ2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.turnoLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contadorJ2 = new System.Windows.Forms.Label();
            this.contadorJ1 = new System.Windows.Forms.Label();
            this.resetScore = new System.Windows.Forms.Button();
            this.cuadricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cuadricula
            // 
            this.cuadricula.Controls.Add(this.button9);
            this.cuadricula.Controls.Add(this.button8);
            this.cuadricula.Controls.Add(this.button7);
            this.cuadricula.Controls.Add(this.button6);
            this.cuadricula.Controls.Add(this.button5);
            this.cuadricula.Controls.Add(this.button4);
            this.cuadricula.Controls.Add(this.button3);
            this.cuadricula.Controls.Add(this.button2);
            this.cuadricula.Controls.Add(this.button1);
            this.cuadricula.Location = new System.Drawing.Point(12, 143);
            this.cuadricula.Name = "cuadricula";
            this.cuadricula.Size = new System.Drawing.Size(355, 352);
            this.cuadricula.TabIndex = 0;
            this.cuadricula.TabStop = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(234, 237);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 100);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.checaTurno);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(128, 238);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 100);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.checaTurno);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(22, 237);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 100);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.checaTurno);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(234, 132);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 100);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.checaTurno);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(128, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.checaTurno);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.checaTurno);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(234, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.checaTurno);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checaTurno);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checaTurno);
            // 
            // resetGame
            // 
            this.resetGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetGame.Location = new System.Drawing.Point(493, 480);
            this.resetGame.Name = "resetGame";
            this.resetGame.Size = new System.Drawing.Size(110, 47);
            this.resetGame.TabIndex = 10;
            this.resetGame.Text = "Reiniciar Juego";
            this.resetGame.UseVisualStyleBackColor = true;
            this.resetGame.Click += new System.EventHandler(this.resetGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "JUGADOR 1 (X)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "JUGADOR 2 (O)";
            // 
            // nombreJ1
            // 
            this.nombreJ1.Location = new System.Drawing.Point(443, 210);
            this.nombreJ1.MaxLength = 12;
            this.nombreJ1.Name = "nombreJ1";
            this.nombreJ1.Size = new System.Drawing.Size(101, 20);
            this.nombreJ1.TabIndex = 13;
            // 
            // nombreJ2
            // 
            this.nombreJ2.Location = new System.Drawing.Point(443, 290);
            this.nombreJ2.MaxLength = 12;
            this.nombreJ2.Name = "nombreJ2";
            this.nombreJ2.Size = new System.Drawing.Size(101, 20);
            this.nombreJ2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Turno actual: ";
            // 
            // turnoLabel
            // 
            this.turnoLabel.AutoSize = true;
            this.turnoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnoLabel.Location = new System.Drawing.Point(460, 371);
            this.turnoLabel.Name = "turnoLabel";
            this.turnoLabel.Size = new System.Drawing.Size(80, 20);
            this.turnoLabel.TabIndex = 17;
            this.turnoLabel.Text = "Jugador 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "J1       Victorias      J2";
            // 
            // contadorJ2
            // 
            this.contadorJ2.AutoSize = true;
            this.contadorJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorJ2.Location = new System.Drawing.Point(331, 511);
            this.contadorJ2.Name = "contadorJ2";
            this.contadorJ2.Size = new System.Drawing.Size(15, 16);
            this.contadorJ2.TabIndex = 19;
            this.contadorJ2.Text = "0";
            this.contadorJ2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contadorJ1
            // 
            this.contadorJ1.AutoSize = true;
            this.contadorJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorJ1.Location = new System.Drawing.Point(31, 511);
            this.contadorJ1.Name = "contadorJ1";
            this.contadorJ1.Size = new System.Drawing.Size(15, 16);
            this.contadorJ1.TabIndex = 20;
            this.contadorJ1.Text = "0";
            this.contadorJ1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resetScore
            // 
            this.resetScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetScore.Location = new System.Drawing.Point(377, 480);
            this.resetScore.Name = "resetScore";
            this.resetScore.Size = new System.Drawing.Size(110, 47);
            this.resetScore.TabIndex = 21;
            this.resetScore.Text = "Reiniciar Marcador";
            this.resetScore.UseVisualStyleBackColor = true;
            this.resetScore.Click += new System.EventHandler(this.resetScore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(612, 572);
            this.Controls.Add(this.resetScore);
            this.Controls.Add(this.contadorJ1);
            this.Controls.Add(this.contadorJ2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.turnoLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nombreJ2);
            this.Controls.Add(this.nombreJ1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetGame);
            this.Controls.Add(this.cuadricula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TIC TAC TOE";
            this.cuadricula.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cuadricula;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button resetGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreJ1;
        private System.Windows.Forms.TextBox nombreJ2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label turnoLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label contadorJ2;
        private System.Windows.Forms.Label contadorJ1;
        private System.Windows.Forms.Button resetScore;
    }
}

