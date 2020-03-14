using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVolume
{
    public partial class ProjetoVolume : Form
    {
        public ProjetoVolume()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double verify1, verify2;

            if (double.TryParse(txtRaio.Text, out verify1)&&
                double.TryParse(txtAltura.Text, out verify2 ))

            {  

                if (verify1 <0) 
                    MessageBox.Show("Não pode número negativo");
                if (verify2 < 0)
                    MessageBox.Show("Não pode número negativo");
                else
                {

                    double Volume = Math.PI * Math.Pow(verify1, 2) * verify2;
                    txtVolume.Text = Volume.ToString();
                }
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRaio.Text = "";
            txtAltura.Text = "";
            txtVolume.Text = "";

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtRaio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
