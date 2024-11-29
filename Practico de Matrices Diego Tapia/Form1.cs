using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico_de_Matrices_Diego_Tapia
{
    public partial class Form1 : Form
    {
        Matriz x1, x2, x3;
        Vector v1;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = new Matriz();
            x2 = new Matriz();
            x3 = new Matriz();
            v1 = new Vector();

        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));

        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = x1.Descargar();
        }
        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            x2.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }
        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox6.Text = x2.Descargar();
        }

        private void ejercicio1FrecuenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = string.Concat(x1.Ejercicio1());

        }

        private void ejercicio2FibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Ejercicio2(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox7.Text = x1.Descargar();
        }

        private void ejercicio3VerifAscendenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = x1.Ejercicio3().ToString();
        }

        private void ejercicio4MayorFrecuenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Ejercicio4();
            textBox7.Text = x1.Descargar();

        }
        private void ejercicio5VerifRigor1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = x1.Ejercicio5().ToString();

        }
        private void ejercicio6VerifSiUnaMatrizEstaIncluidaEnOtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = x1.Ejericio6(x2).ToString();
        }

        private void ejercicio7SegmentarEnParImparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Ejercicio7();
            textBox7.Text = x1.Descargar();
        }

        private void ejercicio8OrdenarPorPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Ejercicio8();
            textBox7.Text = x1.Descargar();
        }


        private void ejercicio9LlevarAVectorYOrdenarMatrizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = "";
            x1.Ejercicio9(ref s);
            textBox6.Text = x1.Descargar();
            textBox7.Text = s;
        }

        private void ejercicio10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Ejercicio10();
            textBox7.Text = x1.Descargar();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.EJERCICIO1(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            textBox7.Text = x1.Descargar();

        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.EJERCICIO2();
            textBox7.Text = x1.Descargar();
        }

        private void ejerecicio3OrdenarFibbonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.EJERCICIO3();
            textBox7.Text = x1.Descargar();
        }
        private void ejercicio4OrdenarTriangularSuperioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.EJERCICIO4();
            textBox7.Text = x1.Descargar();
        }


        private void ejercicio5SegmentarTriangularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.EJERCICIO5();
            textBox7.Text = x1.Descargar();
        }

        private void ejrcicio6OrdenarDiagonalSecundariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.EJERCICIO6();
            textBox7.Text = x1.Descargar();
        }

        private void ordenamiento1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Ordenamiento1();
            textBox7.Text = x1.Descargar();
        }

        private void ordenamiento2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Ordenamiento2();
            textBox7.Text = x1.Descargar();
        }

        private void ordenamiento3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Ordenamiento3();
            textBox7.Text = x1.Descargar();
        }

        private void ordenamiento4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Ordenamiento4();
            textBox7.Text = x1.Descargar();
        }

        private void triangular1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Triangular1();
            textBox7.Text = x1.Descargar();
        }

        private void triangular2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Triangular2();
            textBox7.Text = x1.Descargar();
        }
        private void triangular3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Triangular3();
            textBox7.Text = x1.Descargar();
        }

        private void triangular4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Triangular4();
            textBox7.Text = x1.Descargar();
        }

        private void triangular5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Triangular5();
            textBox7.Text = x1.Descargar();
        }

        private void triangular6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Triangular6();
            textBox7.Text = x1.Descargar();
        }
        private void triangular7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Triangular7();
            textBox7.Text = x1.Descargar();
        }
        private void ordenarDiagonal2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.OrdDiago2();
            textBox7.Text = x1.Descargar();
        }

    }
}
