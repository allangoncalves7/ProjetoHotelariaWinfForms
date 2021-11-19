using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPim
{
    public partial class Quarto : Form
    {
        public Quarto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String descricao = Descricao.ToString();
            String valorDiario = ValorDiaria.ToString();

            MessageBox.Show(
                $"{descricao}, {valorDiario}",
                "Form",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        private void CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void ValorDiaria_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValorDiariaLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
