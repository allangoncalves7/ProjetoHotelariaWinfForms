using ProjetoPim.Data;
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
    public partial class Hospede : Form
    {
        public Hospede()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var registro = RegistrarHospede(Nome.Text, CPF.Text, Telefone.Text, Convert.ToDateTime(Data.Text), Email.Text);

                if (registro)
                {
                    MessageBox.Show(
                   $"Cadastro realizado com sucesso",
                   "Form",
                   MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(
               $"Ocorreu um erro",
               "Form",
               MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
           
            

            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefone_KeyPress(object sender, KeyPressEventArgs e)

        {

            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }

        }

        private void CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void Data_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private bool RegistrarHospede(string nome, string cpf, string telefone, DateTime dataNasc, string email, string senha)
        {
            models.Hospede hosp = new models.Hospede() 
            { 
                Nome = nome,
                Email = email,
                DtNasc = dataNasc,
                Telefone = telefone,
                Cpf = cpf,
                Senha = senha
            };

            PimHotelariaDataContext context = new PimHotelariaDataContext();

            var insert = context.InserirHospede(hosp);

            return insert;

        }
    }
}
