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
    public partial class NumeroPar : Form
    {
        public NumeroPar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int numero;
            numero = int.Parse(Numero.Text);

            if (numero % 2 == 0)
            {
               MessageBox.Show("El numero es par");
            }
            else
            {
                MessageBox.Show("El numero es impar");
            }
        }

        private void Numero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
