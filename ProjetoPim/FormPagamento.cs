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
    public partial class FormPagamento : Form
    {
        public FormPagamento()
        {
            InitializeComponent();
        }

        private void Descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValorDiaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void Descricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
