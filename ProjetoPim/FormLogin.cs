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
    public partial class FormLogin : Form
    {
        private FormTelas JanelaTelas;
        public FormLogin()
        {
            InitializeComponent();
            JanelaTelas = new FormTelas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text == "admin@teste.com" &&  textSenha.Text == "admin123")
            {
                MessageBox.Show(
               $"Logado com sucesso",
               "Form",
               MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                    
                JanelaTelas.ShowDialog();
            }
            else
            {
                MessageBox.Show(
              $"Email ou senha invalido",
              "Form",
              MessageBoxButtons.OK, MessageBoxIcon.Error
               );
            }
        }
    }
}
