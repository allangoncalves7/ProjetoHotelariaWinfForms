﻿using ProjetoPim.Data;
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
    public partial class FormQuarto : Form
    {
        public FormQuarto()
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
            string descricao = Descricao.Text;
            string valorDiarioconverte = ValorDiaria.Text;
            valorDiarioconverte = valorDiarioconverte.Replace('.', ',');
            decimal valorDiario = Convert.ToDecimal(valorDiarioconverte);

            RegistrarQuarto(descricao, valorDiario);
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

        private bool RegistrarQuarto(string descricao, decimal valorDiaria)
        {
            models.Quarto quart = new models.Quarto()
            {
                Descricao = descricao,
                ValorDiaria = valorDiaria
            };

            HotelariaContext context = new HotelariaContext();

            Console.WriteLine(quart);
            var insert = context.InserirQuarto(quart);

            return insert;

        }
    }
}
