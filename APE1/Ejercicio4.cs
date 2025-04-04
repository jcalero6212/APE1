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
    public partial class Ejercicio4 : Form
    {
        private TextBox[,] matrizA;
        private int fila1, columna1;
        private const double TOLERANCIA = 1e-6;
        private const int maxIter = 100;



        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void btLimpiarMatrizA_Click(object sender, EventArgs e)
        {
            groupBoxMatrizA.Controls.Clear();
        }

        private void btMatrizACrear_Click(object sender, EventArgs e)
        {
            groupBoxMatrizA.Controls.Clear();
            fila1 = (int)numericUpDown1.Value;
            columna1 = (int)numericUpDown2.Value;

            if (fila1 != columna1)
            {
                MessageBox.Show("La matriz debe ser cuadrada", "Error");
                return;
            }

            matrizA = new TextBox[fila1, columna1];
            int tamañoMatriz = groupBoxMatrizA.Width / columna1 - 10;

            for (int x = 0; x < fila1; x++)
            {
                for (int y = 0; y < columna1; y++)
                {
                    matrizA[x, y] = new TextBox()
                    {
                        Text = "0",
                        Top = (x * 25) + 20,
                        Left = y * tamañoMatriz + 6,
                        Width = tamañoMatriz
                    };
                    groupBoxMatrizA.Controls.Add(matrizA[x, y]);
                }
            }
        }


        private double[,] LeerMatriz()
        {
            double[,] matriz = new double[fila1, columna1];

            for (int i = 0; i < fila1; i++)
            {
                for (int j = 0; j < columna1; j++)
                {
                    if (!double.TryParse(matrizA[i, j].Text, out matriz[i, j]))
                    {
                        MessageBox.Show("Error: Ingresa solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }
            return matriz;
        }

        private void btnRespuesta_Click(object sender, EventArgs e)
        {
            double[,] matriz = LeerMatriz();
            if (matriz == null) return;

            if (!EsMatrizSimetrica(matriz))
            {
                MessageBox.Show("La matriz no es simétrica.", "Error");
                return;
            }

            int iteraciones = 0;
            double[] autovalores = JacobiEigenvalues(matriz, fila1, ref iteraciones);
            MostrarResultado(autovalores, iteraciones);
        }

        private bool EsMatrizSimetrica(double[,] matriz)
        {
            for (int i = 0; i < fila1; i++)
                for (int j = 0; j < columna1; j++)
                    if (matriz[i, j] != matriz[j, i])
                        return false;
            return true;
        }

       
        private void button9_Click(object sender, EventArgs e)
        {
            groupBoxMatrizResultado.Controls.Clear();
        }

        private double[] JacobiEigenvalues(double[,] A, int n, ref int iteraciones)
        {
            double[,] D = (double[,])A.Clone();
            double maxOffDiagonal;
            iteraciones = 0;

            do
            {
                maxOffDiagonal = 0.0;
                int p = 0, q = 1;

                for (int i = 0; i < n; i++)
                    for (int j = i + 1; j < n; j++)
                        if (Math.Abs(D[i, j]) > maxOffDiagonal)
                        {
                            maxOffDiagonal = Math.Abs(D[i, j]);
                            p = i;
                            q = j;
                        }

                if (maxOffDiagonal < TOLERANCIA) break;

                double tau = (D[q, q] - D[p, p]) / (2.0 * D[p, q]);
                double t = Math.Sign(tau) / (Math.Abs(tau) + Math.Sqrt(1 + tau * tau));
                double cos = 1.0 / Math.Sqrt(1 + t * t);
                double sin = t * cos;

                for (int k = 0; k < n; k++)
                {
                    if (k != p && k != q)
                    {
                        double tempP = D[k, p];
                        double tempQ = D[k, q];
                        D[k, p] = cos * tempP - sin * tempQ;
                        D[k, q] = sin * tempP + cos * tempQ;
                        D[p, k] = D[k, p];
                        D[q, k] = D[k, q];
                    }
                }

                double dpp = D[p, p];
                double dqq = D[q, q];
                double dpq = D[p, q];

                D[p, p] = cos * cos * dpp - 2 * cos * sin * dpq + sin * sin * dqq;
                D[q, q] = sin * sin * dpp + 2 * cos * sin * dpq + cos * cos * dqq;
                D[p, q] = D[q, p] = 0.0;

                iteraciones++;
            } while (maxOffDiagonal > TOLERANCIA && iteraciones < maxIter);

            double[] eigenvalues = new double[n];
            for (int i = 0; i < n; i++)
                eigenvalues[i] = D[i, i];

            return eigenvalues;
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void groupBoxMatrizResultado_Enter(object sender, EventArgs e)
        {

        }

        private void MostrarResultado(double[] autovalores, int iteraciones)
        {
            groupBoxMatrizResultado.Controls.Clear();

            // Ordenar autovalores en orden descendente
            Array.Sort(autovalores);
            Array.Reverse(autovalores);

            Label resultadoLabel = new Label()
            {
                Text = $"Iteraciones: {iteraciones}",
                AutoSize = true,
                Top = 10,
                Left = 10
            };
            groupBoxMatrizResultado.Controls.Add(resultadoLabel);

            for (int i = 0; i < autovalores.Length; i++)
            {
                Label valorLabel = new Label()
                {
                    Text = $"Autovalor {i + 1}: {autovalores[i]:F6}",
                    AutoSize = true,
                    Top = (i + 1) * 30 + 10, // Espaciado mejorado
                    Left = 10
                };
                groupBoxMatrizResultado.Controls.Add(valorLabel);
            }
        }

    }
}
