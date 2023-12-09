using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico_Matrices
{
    public partial class Form1 : Form
    {
        MATRICES x1, x2, x3;
        NEnt n1, n2;
        VECTORES v1, v2, v3;

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = x1.Descargar();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            textBox6.Text = string.Concat(x1.EleNoRep());          
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = string.Concat(x1.MIncluida(x2));
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            x2.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox6.Text = x2.Descargar();
        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (x1.Fila() == x1.Columna())
            {
                v1 = new VECTORES();
                x1.CargarOrdTri(v1);
                v1.VOrdTri();
                x1.DescargarOrdTri(v1);
                textBox6.Text = x1.Descargar();
            }
            else
            {
                textBox6.Text = "INGRESE UNA MATRIZ CUADRADA (mxm)";
            }
        }

        private void ejercicio8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1 = new VECTORES();
            x1.CargarPara8(v1);
            x1.DescargarPara8(v1);
            x1.SegParImpTri();                        
            v1 = new VECTORES();
            x1.Cargar2Para8(v1);
            x1.Descargar2Para8(v1);
            textBox6.Text = x1.Descargar();
            /*if (x1.Fila() == x1.Columna())
            {
                v1 = new Vector();                   
                x1.CargarPara8(v1);
                x1.DescargarPara8(v1);
                x1.SegParImpTri();
                x1.Cargar2Para8(v1);
                x1.Descargar2Para8(v1);
                textBox6.Text = x1.Descargar();
            }
            else
            {
                textBox6.Text = "INGRESE UNA MATRIZ CUADRADA (mxm)";
            }*/
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(x1.AcumPrim());
        }

        private void ejercicio9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (x1.Fila() == x1.Columna())
            {
                v1 = new VECTORES();
                x1.CargarOrdDiagSec(v1);
                v1.VOrdDiagSec();
                x1.DescargarOrdDiagSec(v1);
                textBox6.Text = x1.Descargar();
            }
            else
            {
                textBox6.Text = "INGRESE UNA MATRIZ CUADRADA (mxm)";
            }
        }

        private void ejercicio10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (x1.Fila() == x1.Columna())
            {
                x1.MayorDiag();
                textBox6.Text = x1.Descargar();
            }
            else
            {
                textBox6.Text = "INGRESE UNA MATRIZ CUADRADA (mxm)";
            }
        }

        private void ejercicio4ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            x1.OrdFPri();
            textBox6.Text = x1.Descargar();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1 = new VECTORES();
            v2 = new VECTORES();
            v3 = new VECTORES();
            x1.CargarOrdColFrec(v1);
            x1.DescargarOrdColFrec(v1, v2, v3);
            textBox6.Text = x1.Descargar();
            /*v1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.Descargar();
            v1.OrdEleMayFrec(v2, v3);
            textBox5.Text = v1.Descargar();
            textBox6.Text = v2.Descargar();
            textBox7.Text = v3.Descargar();*/
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.FiboNoFibo();
            textBox6.Text = x1.Descargar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = new MATRICES();
            x2 = new MATRICES();
            x3 = new MATRICES();
            n1 = new NEnt();
            n2 = new NEnt();
            v1 = new VECTORES();
            v2 = new VECTORES();
        }

        public Form1()
        {
            InitializeComponent();
        }        

    }
}
