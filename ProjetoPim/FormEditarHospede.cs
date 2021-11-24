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
    public partial class FormEditarHospede : Form
    {
        public FormEditarHospede()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditarReserva();
        }

        private void EditarReserva()
        {
            try
            {
                HotelariaContext context = new HotelariaContext();

                Hospede hospede = new Hospede()
                {
                    IdHospede = Convert.ToInt32(txtIdHospede.Text),
                    Nome = Nome.Text,
                    DtNasc = Convert.ToDateTime(Data.Text),
                    Cpf = CPF.Text,
                    Email = Email.Text,
                    Telefone = Telefone.Text,

                };

                var insert = context.EditarHospede(hospede);

                if (insert)
                {
                    MessageBox.Show("Hospede editado com sucesso. ", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possivel atualizar reserva. Motivo: " + ex, "Reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Registro_Preencher(Hospede hospede)
        {

            try
            {
                txtIdHospede.Text = hospede.IdHospede.ToString();
                Nome.Text = hospede.Nome.ToString();
                Email.Text = hospede.Email.ToString();
                Telefone.Text = hospede.Telefone.ToString();
                CPF.Text = hospede.Cpf.ToString();
                Telefone.Text = hospede.Telefone.ToString();
                Data.Text = hospede.DtNasc.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
