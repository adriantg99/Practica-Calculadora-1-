using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Calculadora : Form
    {
        Aritmetica miObjAritmetica;
        double aux;
        int c = 0;
        bool primerPunto;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            miObjAritmetica.Temporal1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = string.Empty;
            primerPunto = false;
            miObjAritmetica.UltimaOperacion = Operacion.Suma;
            if (c > 0)
            {
                switch (miObjAritmetica.UltimaOperacion)
                {
                    case Operacion.Suma:
                        var resultadosuma = miObjAritmetica.Sumar(aux, miObjAritmetica.Temporal1);
                        txtResultado.Text = resultadosuma.ToString();
                        miObjAritmetica.Temporal3 = resultadosuma;
                        aux = miObjAritmetica.Temporal3;
                        txtResultado.Text = string.Empty;
                        break;
                }
            }
            c = 1;
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if(primerPunto == false)
            {
                txtResultado.Text += ".";
                primerPunto = true;
            }

        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            miObjAritmetica.Temporal1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = string.Empty;
            primerPunto = false;
            miObjAritmetica.UltimaOperacion = Operacion.Resta;
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            miObjAritmetica.Temporal1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = string.Empty;
            primerPunto = false;
            miObjAritmetica.UltimaOperacion = Operacion.Multiplicacion;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            miObjAritmetica.Temporal1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = string.Empty;
            primerPunto = false;
            miObjAritmetica.UltimaOperacion = Operacion.Division;
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            switch (miObjAritmetica.UltimaOperacion)
            {
                case Operacion.Suma:
                    miObjAritmetica.Temporal2 = Convert.ToDouble(txtResultado.Text);
                    var resultadosuma = miObjAritmetica.Sumar(miObjAritmetica.Temporal1, miObjAritmetica.Temporal2);

                    txtResultado.Text = resultadosuma.ToString();
                    miObjAritmetica.Temporal3 = resultadosuma;
                    break;

                case Operacion.Resta:
                    miObjAritmetica.Temporal2 = Convert.ToDouble(txtResultado.Text);
                    var resultadoResta = miObjAritmetica.Resta(miObjAritmetica.Temporal1, miObjAritmetica.Temporal2);
                    txtResultado.Text = resultadoResta.ToString();

                    break;

                case Operacion.Multiplicacion:
                    miObjAritmetica.Temporal2 = Convert.ToDouble(txtResultado.Text);
                    var resultadoMulti = miObjAritmetica.Multiplicacion(miObjAritmetica.Temporal1, miObjAritmetica.Temporal2);

                    txtResultado.Text = resultadoMulti.ToString();

                    break;

                case Operacion.Division:
                    miObjAritmetica.Temporal2 = Convert.ToDouble(txtResultado.Text);
                    var resultadoDiv = miObjAritmetica.Division(miObjAritmetica.Temporal1, miObjAritmetica.Temporal2);
                    txtResultado.Text = resultadoDiv.ToString();

                    break;

                default: break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            primerPunto = false;
            miObjAritmetica = new Aritmetica();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResultado.Text = string.Empty;
            miObjAritmetica = new Aritmetica();
        }
    }
}
