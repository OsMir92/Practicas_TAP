namespace Practica_06__Libreria_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TamanoMatrizOpcion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OperacionMatriz = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SumaDeFilasBox = new System.Windows.Forms.TextBox();
            this.SumaDeColumnasBox = new System.Windows.Forms.TextBox();
            this.SumaDeDiagonalBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SumaDeContraDiagonalBox = new System.Windows.Forms.TextBox();
            this.Matriz2 = new System.Windows.Forms.DataGridView();
            this.Matriz1 = new System.Windows.Forms.DataGridView();
            this.matrizTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Matriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matriz1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matriz 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matriz 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // TamanoMatrizOpcion
            // 
            this.TamanoMatrizOpcion.FormattingEnabled = true;
            this.TamanoMatrizOpcion.Items.AddRange(new object[] {
            "2 x 2",
            "3 x 3",
            "4 x 4"});
            this.TamanoMatrizOpcion.Location = new System.Drawing.Point(462, 49);
            this.TamanoMatrizOpcion.Name = "TamanoMatrizOpcion";
            this.TamanoMatrizOpcion.Size = new System.Drawing.Size(128, 21);
            this.TamanoMatrizOpcion.TabIndex = 6;
            this.TamanoMatrizOpcion.SelectedIndexChanged += new System.EventHandler(this.TamanoMatrizOpcion_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tamaño de la matriz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Operacion";
            // 
            // OperacionMatriz
            // 
            this.OperacionMatriz.FormattingEnabled = true;
            this.OperacionMatriz.Items.AddRange(new object[] {
            "A + B",
            "A - B",
            "A * B"});
            this.OperacionMatriz.Location = new System.Drawing.Point(462, 98);
            this.OperacionMatriz.Name = "OperacionMatriz";
            this.OperacionMatriz.Size = new System.Drawing.Size(128, 21);
            this.OperacionMatriz.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(609, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SumaDeFilasBox
            // 
            this.SumaDeFilasBox.Location = new System.Drawing.Point(481, 181);
            this.SumaDeFilasBox.Name = "SumaDeFilasBox";
            this.SumaDeFilasBox.ReadOnly = true;
            this.SumaDeFilasBox.Size = new System.Drawing.Size(100, 20);
            this.SumaDeFilasBox.TabIndex = 11;
            // 
            // SumaDeColumnasBox
            // 
            this.SumaDeColumnasBox.Location = new System.Drawing.Point(481, 207);
            this.SumaDeColumnasBox.Name = "SumaDeColumnasBox";
            this.SumaDeColumnasBox.ReadOnly = true;
            this.SumaDeColumnasBox.Size = new System.Drawing.Size(100, 20);
            this.SumaDeColumnasBox.TabIndex = 12;
            // 
            // SumaDeDiagonalBox
            // 
            this.SumaDeDiagonalBox.Location = new System.Drawing.Point(481, 233);
            this.SumaDeDiagonalBox.Name = "SumaDeDiagonalBox";
            this.SumaDeDiagonalBox.ReadOnly = true;
            this.SumaDeDiagonalBox.Size = new System.Drawing.Size(100, 20);
            this.SumaDeDiagonalBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Suma de filas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Suma de columnas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(587, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Suma de diagonal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(587, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Suma de contra diagonal";
            // 
            // SumaDeContraDiagonalBox
            // 
            this.SumaDeContraDiagonalBox.Location = new System.Drawing.Point(481, 259);
            this.SumaDeContraDiagonalBox.Name = "SumaDeContraDiagonalBox";
            this.SumaDeContraDiagonalBox.ReadOnly = true;
            this.SumaDeContraDiagonalBox.Size = new System.Drawing.Size(100, 20);
            this.SumaDeContraDiagonalBox.TabIndex = 17;
            // 
            // Matriz2
            // 
            this.Matriz2.AllowUserToAddRows = false;
            this.Matriz2.AllowUserToDeleteRows = false;
            this.Matriz2.AllowUserToResizeColumns = false;
            this.Matriz2.AllowUserToResizeRows = false;
            this.Matriz2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Matriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matriz2.ColumnHeadersVisible = false;
            this.Matriz2.Location = new System.Drawing.Point(46, 317);
            this.Matriz2.Name = "Matriz2";
            this.Matriz2.RowHeadersVisible = false;
            this.Matriz2.Size = new System.Drawing.Size(200, 92);
            this.Matriz2.TabIndex = 1;
            // 
            // Matriz1
            // 
            this.Matriz1.AllowUserToAddRows = false;
            this.Matriz1.AllowUserToDeleteRows = false;
            this.Matriz1.AllowUserToResizeColumns = false;
            this.Matriz1.AllowUserToResizeRows = false;
            this.Matriz1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Matriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matriz1.ColumnHeadersVisible = false;
            this.Matriz1.Location = new System.Drawing.Point(46, 58);
            this.Matriz1.Name = "Matriz1";
            this.Matriz1.RowHeadersVisible = false;
            this.Matriz1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Matriz1.Size = new System.Drawing.Size(200, 92);
            this.Matriz1.TabIndex = 0;
            this.Matriz1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Matriz1_KeyPress);
            // 
            // matrizTextbox
            // 
            this.matrizTextbox.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrizTextbox.Location = new System.Drawing.Point(271, 189);
            this.matrizTextbox.Multiline = true;
            this.matrizTextbox.Name = "matrizTextbox";
            this.matrizTextbox.Size = new System.Drawing.Size(172, 95);
            this.matrizTextbox.TabIndex = 19;
            this.matrizTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 438);
            this.Controls.Add(this.matrizTextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SumaDeContraDiagonalBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SumaDeDiagonalBox);
            this.Controls.Add(this.SumaDeColumnasBox);
            this.Controls.Add(this.SumaDeFilasBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OperacionMatriz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TamanoMatrizOpcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Matriz2);
            this.Controls.Add(this.Matriz1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Operaciones de Matrices";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Matriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matriz1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TamanoMatrizOpcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox OperacionMatriz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SumaDeFilasBox;
        private System.Windows.Forms.TextBox SumaDeColumnasBox;
        private System.Windows.Forms.TextBox SumaDeDiagonalBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SumaDeContraDiagonalBox;
        private System.Windows.Forms.DataGridView Matriz2;
        private System.Windows.Forms.DataGridView Matriz1;
        private System.Windows.Forms.TextBox matrizTextbox;
    }
}

