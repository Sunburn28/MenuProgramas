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
    public partial class DolarAEuro : Form
    {
        public DolarAEuro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double dolar, euro, cam, conv;

            dolar = Convert.ToDouble(Dolar.Text);
            cam = Convert.ToDouble(Euro.Text);

            conv = dolar * cam;

            MessageBox.Show("Tus" + dolar + " Equivalen a " + conv + " Euros");
        }
    }
}
