using System.Drawing;

namespace Practica_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, farh1;
            v1 = double.Parse(Valor.Text);
            farh1 = v1 * (9.0 / 5.0) + 32;
            Resultado.Text = farh1.ToString();
            label6.Text = " Fahrenheit ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double v1, cent1;
            v1 = double.Parse(Valor.Text);
            cent1 = (v1 - 32) * (5.0 / 9.0);
            Resultado.Text = cent1.ToString();
            label6.Text = " Centigrados ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Valor.Text = " ";
            Resultado.Text = " ";
        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}