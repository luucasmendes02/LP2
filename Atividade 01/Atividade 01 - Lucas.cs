using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //limpar os dados
            txtAltura.Clear();
            txtRaio.Text = "";
            txtVolume.Text = String.Empty;

            txtRaio.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double raio, altura, volume;

            if (Double.TryParse(txtAltura.Text, out altura) &&
                Double.TryParse(txtRaio.Text, out raio))
            {
                if ((altura <= 0) || (raio <= 0))
                {
                    MessageBox.Show("Altura e raio devem ser maior que zero");
                    txtRaio.Focus();
                }
                else
                {
                    //volume = 3.14 * raio * altura;
                    volume = Math.PI * Math.Pow(raio, 2) * altura;
                    txtVolume.Text = volume.ToString("N2");
                }
            }
            else
            {
                MessageBox.Show("Valores inválidos");
                txtRaio.Focus();
            }
                
        }

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {
            Enabled = false;
        }
    }
}
