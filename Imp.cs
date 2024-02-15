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
    public partial class Imp : Form
    {
        public Imp()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double pro;
            double cost;
            bool esMedicamento = chkesMedicamento.Checked;
            double res;
            double sub;
            double iva;

            pro = double.Parse(Precio.Text);
            cost = double.Parse(Numero.Text);

            sub = pro * cost;

            if (esMedicamento)
            {
                iva = 0;
                res = sub + iva;
            }
            else
            {
                // Si es producto normal, se aplica IVA del 16%
                iva = sub * 0.16;
                res = sub + iva;
            }
            MessageBox.Show("El total de tus productos es: " + res);


        }
    }
}
