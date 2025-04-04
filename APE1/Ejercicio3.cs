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
    public partial class Ejercicio3: Form
    {
        private TextBox[,] matrizA;
        private TextBox[] matrizResultado;
        //Almacenar filas y columnas
        int fila1, columna1;
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btLimpiarMatrizA_Click(object sender, EventArgs e)
        {

        }
        private bool EsMatrizCero(double[,] matriz)
        {
            foreach (double valor in matriz)
            {
                if (Math.Abs(valor) > 1e-10)
                    return false;
            }
            return true;
        }


        private void btnRespuesta_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxMatrizResultadoQ.Controls.Clear();
                groupBoxMatrizResultadoR.Controls.Clear();

                double[,] matriz = ObtenerMatrizDesdeTextBox();
                if (matriz == null) return;

                if (EsMatrizCero(matriz))
                {
                    MessageBox.Show("La matriz ingresada es completamente cero. No se puede realizar la descomposición QR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                (double[,] Q, double[,] R) = DescomposicionQR(matriz);

                if (Q == null || R == null)
                {
                    MessageBox.Show("No se pudo realizar la descomposición QR debido a problemas con la matriz.", "Error QR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MostrarMatriz(Q, groupBoxMatrizResultadoQ);
                MostrarMatriz(R, groupBoxMatrizResultadoR);

                bool esOrtogonal = EsOrtogonal(Q);
                lblOrtogonalidad.Text = esOrtogonal ? "✅ Q es Ortogonal" : "❌ Q NO es Ortogonal";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void MostrarMatriz(double[,] matriz, GroupBox groupBox)
        {
            groupBox.Controls.Clear();
            int filas = matriz.GetLength(0), columnas = matriz.GetLength(1);
            int tamañoMatriz = groupBox.Width / columnas - 10;

            for (int x = 0; x < filas; x++)
            {
                for (int y = 0; y < columnas; y++)
                {
                    TextBox tb = new TextBox { Text = matriz[x, y].ToString("F2"), Width = tamañoMatriz, ReadOnly = true };
                    tb.Top = (x * tb.Height) + 20;
                    tb.Left = y * tamañoMatriz + 6;
                    groupBox.Controls.Add(tb);
                }
            }
        }

        private bool EsOrtogonal(double[,] Q)
        {
            int filas = Q.GetLength(0);
            int columnas = Q.GetLength(1);

            if (filas != columnas) // Si no es cuadrada, no se puede verificar ortogonalidad
            {
                MessageBox.Show("No se puede verificar ortogonalidad porque Q no es cuadrada.", "Advertencia");
                return false;
            }

            double[,] QT = TransponerMatriz(Q);
            double[,] QTQ = MultiplicarMatrices(QT, Q);

            //ImprimirMatriz(Q, "Matriz Q");
            //ImprimirMatriz(QTQ, "Q^T * Q");

            double tolerancia = 1e-6;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    double esperado = (i == j) ? 1.0 : 0.0;
                    if (Math.Abs(QTQ[i, j] - esperado) > tolerancia)
                        return false;
                }
            }
            return true;
        }

        private double[,] TransponerMatriz(double[,] matriz)
        {
            int filas = matriz.GetLength(0), columnas = matriz.GetLength(1);
            double[,] transpuesta = new double[columnas, filas];
            for (int i = 0; i < filas; i++)
                for (int j = 0; j < columnas; j++)
                    transpuesta[j, i] = matriz[i, j];
            return transpuesta;
        }

        private double[,] MultiplicarMatrices(double[,] A, double[,] B)
        {
            int filasA = A.GetLength(0), columnasA = A.GetLength(1), columnasB = B.GetLength(1);
            double[,] resultado = new double[filasA, columnasB];
            for (int i = 0; i < filasA; i++)
                for (int j = 0; j < columnasB; j++)
                    for (int k = 0; k < columnasA; k++)
                        resultado[i, j] += A[i, k] * B[k, j];
            return resultado;
        }

        private (double[,], double[,]) DescomposicionQR(double[,] A)
        {
            int m = A.GetLength(0), n = A.GetLength(1);
            double[,] Q = new double[m, n];
            double[,] R = new double[n, n];

            for (int k = 0; k < n; k++)
            {
                double norma = 0;
                for (int i = 0; i < m; i++)
                    norma += A[i, k] * A[i, k];

                if (norma < 1e-10)
                {
                    MessageBox.Show($"Error: La columna {k + 1} es nula o linealmente dependiente.", "Error QR");
                    return (null, null);
                }

                R[k, k] = Math.Sqrt(norma);
                for (int i = 0; i < m; i++)
                    Q[i, k] = A[i, k] / R[k, k];

                for (int j = k + 1; j < n; j++)
                {
                    R[k, j] = 0;
                    for (int i = 0; i < m; i++)
                        R[k, j] += Q[i, k] * A[i, j];
                    for (int i = 0; i < m; i++)
                        A[i, j] -= Q[i, k] * R[k, j];
                }
            }
            return (Q, R);

        }

        private double[,] ObtenerMatrizDesdeTextBox()
        {
            double[,] matriz = new double[fila1, columna1];
            for (int i = 0; i < fila1; i++)
            {
                for (int j = 0; j < columna1; j++)
                {
                    if (!double.TryParse(matrizA[i, j].Text, out matriz[i, j]))
                    {
                        MessageBox.Show("Valores no válidos en la matriz", "Error");
                        return null;
                    }
                }
            }
            return matriz;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblOrtogonalidad_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBoxMatrizResultadoQ.Controls.Clear();
            groupBoxMatrizResultadoR.Controls.Clear();
        }

        private void groupBoxMatrizResultadoR_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxMatrizResultadoQ_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

        }

        private void btLimpiarMatrizA_Click_1(object sender, EventArgs e)
        {
            groupBoxMatrizA.Controls.Clear();
        }

        private void btMatrizACrear_Click_1(object sender, EventArgs e)
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
    }
}
