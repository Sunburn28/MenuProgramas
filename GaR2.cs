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
    public partial class GaR2 : Form
    {
        public GaR2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ApotemaA_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double grado, radian, conv;

            if (Gra.Checked)
            {
                grado = Convert.ToDouble(Grados.Text);
                conv = grado * Math.PI / 180;
                MessageBox.Show("El resultado es: " + conv + " Radianes");
            }
            else if (Rad.Checked)
            {
                radian = Convert.ToDouble(Radianes.Text);
                conv = radian * 180 / Math.PI;
                MessageBox.Show("El resultado es de: " + conv + " Grados");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona entre Área o Perímetro.", "Error de selección");
            }
        }
    }
 }

