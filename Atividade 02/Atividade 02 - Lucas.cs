using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;

            if (Double.TryParse(txtNum2.Text, out numero2) &&
                Double.TryParse(txtNum1.Text, out numero1))
            {
                if (numero2 == 0)
                {
                    MessageBox.Show("Impossível dividir por zero");
                    txtNum1.Focus();
                }
                else
                {
                    resultado = numero1 / numero2;
                    txtResultado.Text = resultado.ToString("N2");
                }
            }
            else
            {
                MessageBox.Show("Valores Inválidos");
                txtNum1.Focus();
            }
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;

            if (Double.TryParse(txtNum2.Text, out numero2) &&
                Double.TryParse(txtNum1.Text, out numero1))
            {
                
                    resultado = numero1 * numero2;
                    txtResultado.Text = resultado.ToString("N2");
        
            }
            else
            {
                MessageBox.Show("Valores Inválidos");
                txtNum1.Focus();
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;

            if (Double.TryParse(txtNum2.Text, out numero2) &&
                Double.TryParse(txtNum1.Text, out numero1))
            {

                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString("N2");

            }
            else
            {
                MessageBox.Show("Valores Inválidos");
                txtNum1.Focus();
            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;

            if (Double.TryParse(txtNum2.Text, out numero2) &&
                Double.TryParse(txtNum1.Text, out numero1))
            {

                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString("N2");

            }
            else
            {
                MessageBox.Show("Valores Inválidos");
                txtNum1.Focus();
            }
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLmp_Click(object sender, EventArgs e)
        {
            //limpar os dados
            txtNum2.Clear();
            txtNum1.Clear();
            txtResultado.Text = String.Empty;

            txtNum1.Focus();
        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
