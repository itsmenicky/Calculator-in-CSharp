using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1, valor2, resultado;
        String operacao, sinal;
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtbox.Text, CultureInfo.InvariantCulture);
            txtbox.Text = null;
            operacao = "SOMA";
            sinal = "+";
            txtbox2.Text = valor1 + sinal;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtbox.Text += "1";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtbox.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtbox.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtbox.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtbox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtbox.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtbox.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtbox.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtbox.Text += "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtbox.Text += "0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtbox.Text = null;
            operacao = null;
            txtbox2.Text = null;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            txtbox.Text += "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtbox.Text, CultureInfo.InvariantCulture);
            txtbox.Text = null;
            operacao = "SUB";
            sinal = "-";
            txtbox2.Text = valor1 + sinal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtbox.Text, CultureInfo.InvariantCulture);
            txtbox.Text = null;
            operacao = "DIV";
            sinal = "/";
            txtbox2.Text = valor1 + sinal;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtbox.Text, CultureInfo.InvariantCulture);
            txtbox.Text = null;
            operacao = "MULTI";
            sinal = "x";
            txtbox2.Text = valor1 + sinal;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtbox.Text += ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtbox.Text, CultureInfo.InvariantCulture);
            txtbox.Text = null;
            operacao = "PORC";
            sinal = "%";
            txtbox2.Text = valor1 + sinal;
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            txtbox.Text += "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtbox2.Text = null;
            valor2 = decimal.Parse(txtbox.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                resultado = valor1 + valor2;
                txtbox.Text = Convert.ToString(resultado);
            }
            else if (operacao == "SUB")
            {
                resultado = valor1 - valor2;
                txtbox.Text = Convert.ToString(resultado);
            }
            else if (operacao == "MULTI")
            {
                resultado = valor1 * valor2;
                txtbox.Text = Convert.ToString(resultado);
            }
            else if (operacao == "PORC")
            {
                resultado = (valor1 * valor2)/100;
                txtbox.Text = Convert.ToString(resultado);
            }
            else
            {
                resultado = valor1 / valor2;
                txtbox.Text = Convert.ToString(resultado);
            }
            //txtbox.Text = String.Format("{0:0.00}", resultado);      
        }
    }
}