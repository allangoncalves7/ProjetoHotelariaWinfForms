using ProjetoPim.Data;
using ProjetoPim.models;
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
    public partial class FormEditarServico : Form
    {
        public FormEditarServico()
        {
            InitializeComponent();
        }

        private void FormEditarServico_Load(object sender, EventArgs e)
        {

        }

        public void Registro_Preencher(Servico servico)
        {

            try
            {
                txtIdServico.Text = servico.IdServico.ToString();
                txtTipoServico.Text = servico.Tipo.ToString();
                txtValorServico.Text = servico.Valor.ToString();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimparCampos()
        {
            txtIdServico.Text = string.Empty;
            txtTipoServico.Text = string.Empty;
            txtValorServico.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AtualizarReserva();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizarReserva()
        {
            try
            {
                if (String.IsNullOrEmpty(txtTipoServico.Text) || String.IsNullOrEmpty(txtValorServico.Text))
                {
                    MessageBox.Show("O Tipo e o Valor não pode ser vazio!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                HotelariaContext context = new HotelariaContext();


                Servico servico = new Servico()
                {
                    IdServico = Convert.ToInt32(txtIdServico.Text),
                    Tipo = txtTipoServico.Text,
                    Valor = Convert.ToDecimal(txtValorServico.Text)
                };

                var insert = context.EditarServico(servico);

                if (insert)
                {
                    MessageBox.Show("Reserva atualizada com sucesso. ", "Reservar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possivel atualizar reserva. Motivo: " + ex, "Reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
