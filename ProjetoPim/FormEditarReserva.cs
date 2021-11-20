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
    public partial class FormEditarReserva : Form
    {

        public delegate void Fechar();
        public event Fechar OnFechar;
        public FormEditarReserva()
        {
            InitializeComponent();
            FillDrop();
        }

        public void FillDrop()
        {
            try
            {
                var xQuartos = new Dictionary<string, int>();

                HotelariaContext context = new HotelariaContext();

                var tbquartos = context.ConsultarQuartos();


                foreach (var quarto in tbquartos)
                {
                    if (!xQuartos.ContainsKey(quarto.Descricao))
                        xQuartos.Add(quarto.Descricao, quarto.IdQuarto);
                }


                cbQuartos.DataSource = new BindingSource(xQuartos, null);
                cbQuartos.DisplayMember = "Key";
                cbQuartos.ValueMember = "Value";

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro. " + ex.Message);
            }

        }

        public void Registro_Preencher(Reserva reserva)
        {

            try
            {
                txtId.Text = reserva.IdReserva.ToString();
                txtDtEntrada.Text = reserva.DtEntrada.ToString();
                txtDtSaida.Text = reserva.DtSaida.ToString();

                var xNomes = new Dictionary<string, int>();
                xNomes.Add(reserva.NomeHospede, reserva.IdHospede);

                cbHospede.DataSource = new BindingSource(xNomes, null);
                cbHospede.DisplayMember = "Key";
                cbHospede.ValueMember = "Value";

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            EditarReserva();
        }

        private void EditarReserva()
        {
            try
            {
                if (txtDtEntrada.Text == "  /  /" || txtDtEntrada.Text == "  /  /")
                {
                    MessageBox.Show("Data Inválida! ", "Reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                HotelariaContext context = new HotelariaContext();

                var idHospede = ((KeyValuePair<string, int>)cbHospede.SelectedItem).Value;
                var idQuarto = ((KeyValuePair<string, int>)cbQuartos.SelectedItem).Value;


                Reserva reserva = new Reserva()
                {
                    IdReserva = Convert.ToInt32(txtId.Text),
                    DtEntrada = Convert.ToDateTime(txtDtEntrada.Text),
                    DtSaida = Convert.ToDateTime(txtDtSaida.Text),
                    IdQuarto = idQuarto,
                    IdHospede = idHospede,
                    StatusReserva = txtStatus.Text
                };

                var insert = context.EditarReserva(reserva);

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

        private void ExcluirReserva()
        {
            try
            {
                if (MessageBox.Show("Deseja excluir a reserva?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    HotelariaContext context = new HotelariaContext();
                    var delete = context.ExcluirReserva(Convert.ToInt32(txtId.Text));

                    if (delete)
                    {
                        MessageBox.Show("Reserva excluida com sucesso. ", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                    
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possivel excluir reserva. Motivo: " + ex, "Reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirReserva();
            Registro_LimparCampos();
        }

        private void Registro_LimparCampos()
        {
            txtId.Text = String.Empty;
            txtDtEntrada.Text = String.Empty;
            txtDtSaida.Text = String.Empty;
            txtStatus.Text = String.Empty;

        }

        private void FormEditarReserva_Load(object sender, EventArgs e)
        {

        }
    }
}
