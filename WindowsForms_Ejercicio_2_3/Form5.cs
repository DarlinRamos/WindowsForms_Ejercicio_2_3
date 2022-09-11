using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Ejercicio_2_3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double numero3 = Convert.ToDouble(textBox3.Text);
            double numero4 = Convert.ToDouble(textBox4.Text);
            double suma = numero1 + numero2 + numero3 + numero4;
            label7.Text = "La suma es: " + suma.ToString();
        }
    }
}
