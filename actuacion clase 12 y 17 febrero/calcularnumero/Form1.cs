using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcularnumero
{
    public partial class Form1 : Form
    {
        Matematica mat;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(tbNum1.Text);
            double num2 = double.Parse(tbNum2.Text);
            mat = new Matematica();

            if (sumar.Checked)
            {
                MessageBox.Show("La suma es: " + mat.Sumar(num1, num2));
                Result.Text = mat.Sumar(num1, num2).ToString();
            }
            if (restar.Checked)
            {
                MessageBox.Show("La resta es: " + mat.Restar(num1, num2));
                Result.Text = mat.Restar(num1, num2).ToString();
            }
            if (multiplicar.Checked)
            {
                MessageBox.Show("La multiplicación es: " + mat.Multiplicar(num1, num2));
                Result.Text = mat.Multiplicar(num1, num2).ToString();
            }
            if (dividir.Checked)
            {
                double resultado = mat.Dividir(num1, num2);
                if (!double.IsNaN(resultado))
                {
                    MessageBox.Show("La división es: " + resultado);
                    Result.Text = resultado.ToString();
                }
            }
            if (modulo.Checked)
            {
                double resultado = mat.Modulo(num1, num2);
                if (!double.IsNaN(resultado))
                {
                    MessageBox.Show("El módulo es: " + resultado);
                    Result.Text = resultado.ToString();
                }
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

