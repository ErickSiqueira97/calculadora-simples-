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
        

        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; }


        private enum Operacao

        {
            Adicao,
            subtracao,
            Multiplicacao,
            Divisao,     
        }
    
        public Calculadora ()
        {
            InitializeComponent();
        }

        private void btC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "*";
        }

        private void btSubtrair_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "-";
        }

        private void btSomar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "+";
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;
            }
            txtResultado.Text = Convert.ToString(Resultado);
            lblOperacao.Text = "=";

        }

        private void btNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "/";
        }

        private void btOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btPonto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","));
            txtResultado.Text += ",";
        }

        private void btUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
