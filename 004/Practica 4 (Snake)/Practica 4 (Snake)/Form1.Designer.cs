namespace Practica_4__Snake_
{
    partial class Juego1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego1));
            this.PanelG = new System.Windows.Forms.PictureBox();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.PuntosNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PanelG)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelG
            // 
            this.PanelG.Location = new System.Drawing.Point(74, 53);
            this.PanelG.Name = "PanelG";
            this.PanelG.Size = new System.Drawing.Size(650, 350);
            this.PanelG.TabIndex = 0;
            this.PanelG.TabStop = false;
            // 
            // tiempo
            // 
            this.tiempo.Enabled = true;
            this.tiempo.Interval = 150;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puntos:";
            // 
            // PuntosNum
            // 
            this.PuntosNum.AutoSize = true;
            this.PuntosNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuntosNum.Location = new System.Drawing.Point(448, 410);
            this.PuntosNum.Name = "PuntosNum";
            this.PuntosNum.Size = new System.Drawing.Size(29, 31);
            this.PuntosNum.TabIndex = 3;
            this.PuntosNum.Text = "0";
            // 
            // Juego1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PuntosNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PanelG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Juego1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PanelG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PanelG;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PuntosNum;
    }
}

