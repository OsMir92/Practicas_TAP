using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaMatrices;
using Microsoft.VisualBasic;

namespace Practica_06__Libreria_
{
    public partial class Form1 : Form
    {

        int matrizSize;
        int[,] matrizFinal;

        public Form1()
        {
            InitializeComponent();
        }

        private void TamanoMatrizOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TamanoMatrizOpcion.SelectedIndex)
            {
                case 0:
                    Matriz2x2();
                    matrizSize = 2;
                    break;

                case 1:
                    Matriz3x3();
                    matrizSize = 3;
                    break;

                case 2:
                    Matriz4x4();
                    matrizSize = 4;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int[,] m = new int[matrizSize, matrizSize];
                int[,] n = new int[matrizSize, matrizSize];

                for (int i = 0; i < matrizSize; i++)
                {
                    for (int j = 0; j < matrizSize; j++)
                    {
                        if (Matriz1.Rows[i].Cells[j].Value != null)
                        { m[i, j] = int.Parse(Matriz1.Rows[i].Cells[j].Value.ToString()); }

                        else { m[i, j] = 0; }
                    }
                }

                for (int k = 0; k < matrizSize; k++)
                {
                    for (int l = 0; l < matrizSize; l++)
                    {
                        if (Matriz2.Rows[k].Cells[l].Value != null)
                        { n[k, l] = int.Parse(Matriz2.Rows[k].Cells[l].Value.ToString()); }

                        else { n[k, l] = 0; }
                    }
                }


                switch (OperacionMatriz.SelectedIndex)
                {
                    case 0:
                        //Suma
                        matrizFinal = LibreriaMatrices.Matrices.SumarMatrices(m, n, matrizSize);
                        printMatriz(matrizFinal);

                        break;

                    case 1:
                        //Resta
                        matrizFinal = LibreriaMatrices.Matrices.RestarMatrices(m, n, matrizSize);
                        printMatriz(matrizFinal);
                        break;

                    case 2:
                        //Multiplicacion
                        matrizFinal = LibreriaMatrices.Matrices.MultiplicarMatrices(m, n, matrizSize);
                        printMatriz(matrizFinal);

                        break;
                }


                SumaDeFilasBox.Text = string.Join(", ", LibreriaMatrices.Matrices.SumaFilas(matrizFinal, matrizSize));
                SumaDeColumnasBox.Text = string.Join(", ", LibreriaMatrices.Matrices.SumaColumnas(matrizFinal, matrizSize));
                SumaDeDiagonalBox.Text = LibreriaMatrices.Matrices.SumaDiagonal(matrizFinal, matrizSize).ToString();
                SumaDeContraDiagonalBox.Text = LibreriaMatrices.Matrices.SumaContraDiagonal(matrizFinal, matrizSize).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Solo se aceptan numeros enteros en la matriz... "+ex.Message, "Error de lectura");
            }


        }

        private void printMatriz(int[,] matrizFinal)
        {
            string matrixString = "";
            for (int i = 0; i < matrizFinal.GetLength(0); i++)
            {
                for (int j = 0; j < matrizFinal.GetLength(1); j++)
                {
                    matrixString += matrizFinal[i, j].ToString();
                    matrixString += " ";
                }

                matrixString += Environment.NewLine;
            }
            this.matrizTextbox.Text = matrixString;
        }

        private void Matriz2x2()
        {
            Matriz1.RowCount = 2;
            Matriz1.ColumnCount = 2;
            Matriz2.RowCount = 2;
            Matriz2.ColumnCount = 2;
        }

        private void Matriz3x3()
        {
            Matriz1.RowCount = 3;
            Matriz1.ColumnCount = 3;
            Matriz2.RowCount = 3;
            Matriz2.ColumnCount = 3;
        }

        private void Matriz4x4()
        {
            Matriz1.RowCount = 4;
            Matriz1.ColumnCount = 4;
            Matriz2.RowCount = 4;
            Matriz2.ColumnCount = 4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OperacionMatriz.SelectedIndex = 0;
            TamanoMatrizOpcion.SelectedIndex = 0;
        }

        private void Matriz1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
