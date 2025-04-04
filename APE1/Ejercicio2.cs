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
    public partial class Ejercicio2: Form
    {
        private TextBox[,] matrizA;
        private TextBox[] matrizResultado;
        //Almacenar filas y columnas
        int fila1, columna1;

        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnRespuesta_Click(object sender, EventArgs e)
        {
            double[,] matriz = new double[fila1, columna1];

            // Tomamos los valores de los TextBox de la matriz A
            for (int i = 0; i < fila1; i++)
            {
                for (int j = 0; j < columna1; j++)
                {
                    if (double.TryParse(matrizA[i, j].Text, out double value))
                        matriz[i, j] = value;
                    else
                    {
                        MessageBox.Show($"Entrada inválida en la posición [{i + 1},{j + 1}]", "Error");
                        return;
                    }
                }
            }

            string resultadoMensaje;
            double[] resultado = ResolverSistemaGauss(matriz, out resultadoMensaje);

            if (resultado == null)
            {
                MessageBox.Show(resultadoMensaje, "Resultado");
                return;
            }

            groupBoxMatrizResultado.Controls.Clear();
            matrizResultado = new TextBox[fila1];

            for (int i = 0; i < resultado.Length; i++)
            {
                matrizResultado[i] = new TextBox();
                matrizResultado[i].Text = $"X{i + 1} = {resultado[i]:F2}";
                matrizResultado[i].Top = (i * 30) + 20;
                matrizResultado[i].Left = 10;
                matrizResultado[i].Width = groupBoxMatrizResultado.Width - 20;
                groupBoxMatrizResultado.Controls.Add(matrizResultado[i]);
            }
        }
        private void btLimpiarMatrizA_Click(object sender, EventArgs e)
        {
            groupBoxMatrizA.Controls.Clear();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            groupBoxMatrizResultado.Controls.Clear();

        }
        private void btMatrizACrear_Click(object sender, EventArgs e)
        {
            groupBoxMatrizA.Controls.Clear();
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
            int tamañoMatriz = groupBoxMatrizA.Width / columna1 - 10;
            for (int x = 0; x < matrizA.GetLength(0); x++)
            {
                for (int y = 0; y < matrizA.GetLength(1); y++)
                {
                    matrizA[x, y] = new TextBox();
                    matrizA[x, y].Text = "0";
                    matrizA[x, y].Top = (x * matrizA[x, y].Height) + 20;
                    matrizA[x, y].Left = y * tamañoMatriz + 6;
                    matrizA[x, y].Width = tamañoMatriz;
                    groupBoxMatrizA.Controls.Add(matrizA[x, y]);
                }
            }

        }

        private void btLimpiarMatrizA_Click_1(object sender, EventArgs e)
        {
            groupBoxMatrizA.Controls.Clear();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            groupBoxMatrizResultado.Controls.Clear();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

        }

        private double[] ResolverSistemaGauss(double[,] matriz, out string mensaje)
        {
            int n = matriz.GetLength(0);
            int m = matriz.GetLength(1);

            // Verificar que la matriz es de tamaño válido (n x n+1)
            if (m != n + 1)
            {
                mensaje = "La matriz aumentada debe tener exactamente n+1 columnas.";
                return null;
            }

            for (int i = 0; i < n; i++)
            {
                if (matriz[i, i] == 0)
                {
                    int swapRow = -1;
                    for (int k = i + 1; k < n; k++)
                    {
                        if (matriz[k, i] != 0)
                        {
                            swapRow = k;
                            break;
                        }
                    }
                    if (swapRow == -1)
                    {
                        mensaje = "El sistema es inconsistente o tiene infinitas soluciones.";
                        return null;
                    }

                    for (int j = 0; j < m; j++)
                    {
                        double temp = matriz[i, j];
                        matriz[i, j] = matriz[swapRow, j];
                        matriz[swapRow, j] = temp;
                    }
                }

                double divisor = matriz[i, i];
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] /= divisor;
                }

                for (int k = 0; k < n; k++)
                {
                    if (k != i)
                    {
                        double factor = matriz[k, i];
                        for (int j = 0; j < m; j++)
                        {
                            matriz[k, j] -= factor * matriz[i, j];
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                bool esCeroCompleto = true;
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] != 0)
                    {
                        esCeroCompleto = false;
                        break;
                    }
                }

                if (esCeroCompleto)
                {
                    if (matriz[i, m - 1] != 0)
                    {
                        mensaje = "El sistema no tiene solución.";
                        return null;
                    }
                    else
                    {
                        mensaje = "El sistema tiene infinitas soluciones.";
                        return null;
                    }
                }
            }

            double[] resultado = new double[n];
            for (int i = 0; i < n; i++)
            {
                resultado[i] = matriz[i, n];
            }

            mensaje = "El sistema tiene una única solución.";
            return resultado;
        }

    }
}
