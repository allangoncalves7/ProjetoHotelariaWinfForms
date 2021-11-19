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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void Telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nome = Nome.ToString();
            String cpf = CPF.ToString();
            String email = Email.ToString();
            String telefone = Telefone.ToString();
            String date = Data.ToString();
            String cargo = CargoFuncionario.ToString();
            String password = PasswordFuncionario.ToString();

            MessageBox.Show(
                $"{nome}, {cpf}, {email}, {telefone}, {date}, {cargo}, {password}",
                "Form",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
