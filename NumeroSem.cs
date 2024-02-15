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
    public partial class NumeroSem : Form
    {
        public NumeroSem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int op;

            op = int.Parse(NumeroS.Text);

            switch (op)
            {
                case 1:
                    MessageBox.Show("Es Lunes");
                    break;
                case 2:
                    MessageBox.Show("Es Martes");
                    break;
                case 3:
                    MessageBox.Show("Es Miercoles");
                    break;
                case 4:
                    MessageBox.Show("Es Jueves");
                    break;
                case 5:
                    MessageBox.Show("Es Viernes");
                    break;
                case 6:
                    MessageBox.Show("Es Sabado");
                    break;
                case 7:
                    MessageBox.Show("Es Domingo");
                    break;

            }

        }
    }
}
