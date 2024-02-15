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
    public partial class Peri : Form
    {
        public Peri()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int numero;
            int peri;
            numero = int.Parse(NumeroL.Text);

            peri = numero * 5;

            MessageBox.Show("El perimetro de tu figura es de: " + peri);

        }
    }
}
