using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Calculos
{
    public partial class CalcRadio : Form
    {
        public CalcRadio()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CalcRadio_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double a, b;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);

            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b;
            double c;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a + b;


            // validação
            if (!double.TryParse(textBox1.Text, out a) ||
                !double.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("Digite números válidos!");
                return;
            }

            string resultadoFinal = "";

            // operações matemáticas
            if (soma.Checked)
                resultadoFinal = (a + b).ToString();

            else if (sub.Checked)
                resultadoFinal = (a - b).ToString();

            else if (div.Checked)
                resultadoFinal = (a / b).ToString();

            else if (mult.Checked)
                resultadoFinal = (a * b).ToString();

            // comparar
            else if (comp.Checked)
            {
                if (a > b)
                    resultadoFinal = a + " > " + b;
                else if (a < b)
                    resultadoFinal = a + " < " + b;
                else
                    resultadoFinal = a + " = " + b;
            }

            // par ou ímpar (usa só o primeiro número)
            else if (parimpar.Checked)
                c = a + b;
            {
                if (c % 2 == 0)
                    resultadoFinal = "A soma dos dois é Par";
                else
                    resultadoFinal = "A soma dos dois é Ímpar";
            }

            resultado.Text = resultadoFinal.ToString();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
