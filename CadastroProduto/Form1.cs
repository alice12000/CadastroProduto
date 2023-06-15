using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroProduto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            valor_final.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            //botão cadastrar
            string descricao = descricao_tx.Text;
            double valor = Convert.ToDouble(valor_tx.Text);
            double pis = Convert.ToDouble(pis_tx.Text);
            double icms = Convert.ToDouble(icms_tx.Text);
            double lucro = Convert.ToDouble(lucro_tx.Text);
            double confins = Convert.ToDouble(confins_tx.Text);
           
            Lucro l = new Lucro(valor, icms, pis, confins, lucro);
            double valorfinal =  l.CalcularImposto(valor, icms, pis, confins, lucro);
            MessageBox.Show(valorfinal.ToString());
        }

        private void codigo_tx_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
