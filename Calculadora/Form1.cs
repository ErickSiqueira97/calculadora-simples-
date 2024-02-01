using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btSomar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNro1.Text) + float.Parse(txtNro2.Text)).ToString();
        }

        private void txtNro2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSubtrair_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNro1.Text) - float.Parse(txtNro2.Text)).ToString();
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNro1.Text) * float.Parse(txtNro2.Text)).ToString();
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNro1.Text) / float.Parse(txtNro2.Text)).ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void BtnSomar(object sender, EventArgs e)
        {
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {

        }

        private void btnNove_Click(object sender, EventArgs e)
        {

        }

        private void btnOito_Click(object sender, EventArgs e)
        {

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {

        }

        private void btnDois_Click(object sender, EventArgs e)
        {

        }

        private void btnUm_Click(object sender, EventArgs e)
        {

        }

        private void bntQuatro_Click(object sender, EventArgs e)
        {

        }
    }
}
