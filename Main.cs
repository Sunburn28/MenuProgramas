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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DolarAEuro frm = new DolarAEuro();
            frm.Show();
        }

        private void ParOImp_Click(object sender, EventArgs e)
        {
            NumeroPar frm = new NumeroPar();
            frm.Show();
        }

        private void Perimetro_Click(object sender, EventArgs e)
        {
            Peri frm = new Peri();
            frm.Show();
        }

        private void Error_Click(object sender, EventArgs e)
        {
            Error frm = new Error();
            frm.Show();
        }

        private void NumeroS_Click(object sender, EventArgs e)
        {
            NumeroSem frm = new NumeroSem();
            frm.Show();
        }

        private void GradoRad_Click(object sender, EventArgs e)
        {
            GradosaR frm = new GradosaR();
            frm.Show();
        }

        private void CentiAFahr_Click(object sender, EventArgs e)
        {
            GradosCaF frm = new GradosCaF();
            frm.Show();
        }

        private void Impuesto_Click(object sender, EventArgs e)
        {
            Imp frm = new Imp();
            frm.Show();
        }

        private void PyA_Click(object sender, EventArgs e)
        {
            AyP frm = new AyP();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GaR2 frm = new GaR2();
            frm.Show();
        }
    }
}
