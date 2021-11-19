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


    }
}
