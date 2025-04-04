using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APE1
{
    public partial class Ejercicio1: Form
    {
        private TextBox[,] matrizA;
        private TextBox[,] matrizB;
        private TextBox[,] matrizResultado;

        //Almacenar filas y columnas
        int fila1, columna1;
        int fila2, columna2;

        private void btMultiMatrices_Click(object sender, EventArgs e)
        {
            Multiplicacion();
        }

        public void Multiplicacion()
        {
            if (matrizA == null || matrizB == null)
            {
                MessageBox.Show("Debe Cargarse las dos matrices", "Error");
                return;
            }
            double[,] temporalMatrizA = new double[matrizA.GetLength(0), matrizA.GetLength(1)];
            double[,] temporalMatrizB = new double[matrizB.GetLength(0), matrizB.GetLength(1)];
            if (temporalMatrizA.GetLength(1) != temporalMatrizB.GetLength(0))
            {
                MessageBox.Show("Solo es posible multiplicar matrices donde el numero de columnas sean iguales a las filas de otras", "Error Multiplicacion de matrices");
                return;
            }
            for (int x = 0; x < matrizA.GetLength(0); x++)
            {
                for (int y = 0; y < matrizA.GetLength(1); y++)
                {
                    temporalMatrizA[x, y] = Convert.ToDouble(matrizA[x, y].Text);
                }
            }
            for (int x = 0; x < matrizB.GetLength(0); x++)
            {
                for (int y = 0; y < matrizB.GetLength(1); y++)
                {
                    temporalMatrizB[x, y] = Convert.ToDouble(matrizB[x, y].Text);
                }
            }
            double[,] temporalMatrizResultante = new double[temporalMatrizA.GetLength(0), temporalMatrizB.GetLength(1)];
            for (int x = 0; x < temporalMatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < temporalMatrizResultante.GetLength(1); y++)
                {
                    for (int n = 0; n < temporalMatrizB.GetLength(0); n++)
                    {
                        temporalMatrizResultante[x, y] += temporalMatrizA[x, n] * temporalMatrizB[n, y];
                    }
                }
            }
            matrizResultado = new TextBox[temporalMatrizResultante.GetLength(0), temporalMatrizResultante.GetLength(1)];
   
            int tamañoMatriz = groupBoxMatrizResultado.Width / matrizResultado.GetLength(1) - 10;
            groupBoxMatrizResultado.Controls.Clear();
            for (int x = 0; x < matrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < matrizResultado.GetLength(1); y++)
                {
                    matrizResultado[x, y] = new TextBox();
                    matrizResultado[x, y].Text = temporalMatrizResultante[x, y].ToString();
                    matrizResultado[x, y].Top = (x * matrizResultado[x, y].Height) + 20;
                    matrizResultado[x, y].Left = y * tamañoMatriz + 6;
                    matrizResultado[x, y].Width = tamañoMatriz;
                    groupBoxMatrizResultado.Controls.Add(matrizResultado[x, y]);
                }
            }
        }

        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBoxMatrizResultado.Controls.Clear();
        }

        private void btLimpiarMatrizA_Click(object sender, EventArgs e)
        {
            groupBoxMatrizA.Controls.Clear();
            groupBoxMatrizB.Controls.Clear();
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

        }

        private void groupBoxMatrizA_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btMatrizACrear_Click(object sender, EventArgs e)
        {
            GenerarMatriz();
        }

        private void GenerarMatriz()
        {

            groupBoxMatrizA.Controls.Clear();
            fila1 = (int)numericUpDown1.Value;
            columna1 = (int)numericUpDown2.Value;

            if (fila1 != columna1)
            {
                MessageBox.Show("La matriz debe ser cuadrada", "Error");
                return;
            }
            Random numero = new Random();
            groupBoxMatrizA.Controls.Clear();
            groupBoxMatrizB.Controls.Clear();
            if ((int)numericUpDown1.Value != 0)
            {
                fila1 = (int)numericUpDown1.Value;
            }
            else
            {
                MessageBox.Show("El valor de las filas no es valido", "Error en matriz A");
            }

            if ((int)numericUpDown2.Value != 0)
            {
                columna1 = (int)numericUpDown2.Value;
            }
            else
            {
                MessageBox.Show("El valor de las Columnas no es valido", "Error en matriz A");
            }

            matrizA = new TextBox[fila1, columna1];
            matrizB = new TextBox[fila1, columna1];
            int tamañoMatriz = groupBoxMatrizA.Width / columna1 - 10;
            int tamañoMatrizb = groupBoxMatrizB.Width / columna1 - 10;
            for (int x = 0; x < matrizA.GetLength(0); x++)
            {
                for (int y = 0; y < matrizA.GetLength(1); y++)
                {
                    matrizA[x, y] = new TextBox();
                    matrizA[x, y].Text = numero.Next(1, 20).ToString();
                    matrizA[x, y].Top = (x * matrizA[x, y].Height) + 20;
                    matrizA[x, y].Left = y * tamañoMatriz + 6;
                    matrizA[x, y].Width = tamañoMatriz;
                    groupBoxMatrizA.Controls.Add(matrizA[x, y]);
                }
            }
            for (int x = 0; x < matrizB.GetLength(0); x++)
            {
                for (int y = 0; y < matrizB.GetLength(1); y++)
                {
                    matrizB[x, y] = new TextBox();
                    matrizB[x, y].Text = numero.Next(1, 20).ToString();
                    matrizB[x, y].Top = (x * matrizB[x, y].Height) + 20;
                    matrizB[x, y].Left = y * tamañoMatrizb + 6;
                    matrizB[x, y].Width = tamañoMatrizb;
                    groupBoxMatrizB.Controls.Add(matrizB[x, y]);
                }
            }
        }
    }
}
