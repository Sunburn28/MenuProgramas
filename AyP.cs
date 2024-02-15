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
    public partial class AyP : Form
    {
        public AyP()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double lado, apo, peri, a;

            if (Area.Checked)
            {
                peri = Convert.ToDouble(PerimetroA.Text);
                apo = Convert.ToDouble(ApotemaA.Text);
                a = (peri * apo) / 2;
                MessageBox.Show("El área es de: " + a);
            }
            else if (Perimetro.Checked)
            {
                lado = Convert.ToDouble(LadoP.Text);
                peri = 5 * lado;
                MessageBox.Show("El perímetro es de: " + peri);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona entre Área o Perímetro.", "Error de selección");
            }
        }


        private void Lado_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApotemaA_TextChanged(object sender, EventArgs e)
        {

        }

        private void PerimetroA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Area_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Perimetro_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
