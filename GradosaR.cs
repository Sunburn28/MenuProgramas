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
    public partial class GradosaR : Form
    {
        public GradosaR()
        {
            InitializeComponent();
        }

        private void Convertir_Click(object sender, EventArgs e)
        {
            double grados;
            double res;

            grados = double.Parse(Gradoss.Text);

            res = grados * (Math.PI / 180);

            MessageBox.Show("El resultado de la conversion es de: " + res + " Radianes");

        }

        private void Gradoss_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
