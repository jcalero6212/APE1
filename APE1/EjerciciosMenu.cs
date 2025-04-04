using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APE1
{
    public partial class EjerciciosMenu: Form
    {
        public EjerciciosMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio1 m = new Ejercicio1();
            this.Hide();  // Oculta la ventana actual (Caratula)
            m.ShowDialog();  // Abre la nueva ventana de forma modal (espera a que se cierre para continuar)
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ejercicio3 m = new Ejercicio3();
            this.Hide();  // Oculta la ventana actual (Caratula)
            m.ShowDialog();  // Abre la nueva ventana de forma modal (espera a que se cierre para continuar)
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ejercicio2 m = new Ejercicio2();
            this.Hide();  // Oculta la ventana actual (Caratula)
            m.ShowDialog();  // Abre la nueva ventana de forma modal (espera a que se cierre para continuar)
            this.Show();
        }

        private void EjerciciosMenu_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ejercicio4 m = new Ejercicio4();
            this.Hide();  // Oculta la ventana actual (Caratula)
            m.ShowDialog();  // Abre la nueva ventana de forma modal (espera a que se cierre para continuar)
            this.Show();
        }
    }
}
