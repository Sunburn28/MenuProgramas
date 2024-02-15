using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuProgramas
{
    public partial class GradosCaF : Form
    {
        public GradosCaF()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gradoss_TextChanged(object sender, EventArgs e)
        {

        }

        private void Convertir_Click(object sender, EventArgs e)
        {
            double grados;
            double res;

            grados = double.Parse(Celsius.Text);
            res = (grados * 9 / 5) + 32;

            MessageBox.Show("La conversion dio como resultado: " + res + " Grados Fahrenheit");



        }
    }
}
