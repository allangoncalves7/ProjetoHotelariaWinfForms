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
    public partial class FormReserva : Form
    {
        private FormEditarReserva JanelaEditar;
        private FormServico JanelaServico;
        private FormPagamento JanelaPagamento;

        public FormReserva()
        {
            InitializeComponent();
            FillDrop();

            JanelaEditar = new FormEditarReserva();
            JanelaServico = new FormServico();
            JanelaPagamento = new FormPagamento();
            JanelaEditar.OnFechar += FormEdit_OnFechar;
        }

        public void FillDrop()
        {
            try
            {
                var xNomes = new Dictionary<string, int>();
                var xQuartos = new Dictionary<string, int>();

                HotelariaContext context = new HotelariaContext();

                var tbhospedes = context.ConsultarHospedes();
                var tbquartos = context.ConsultarQuartos();


                foreach (var hospede in tbhospedes)
                {
                    //xNomes.Add(hospede.Nome);
                    xNomes.Add(hospede.Nome, hospede.IdHospede);
                }

                foreach (var quarto in tbquartos)
                {
                    if(!xQuartos.ContainsKey(quarto.Descricao))
                        xQuartos.Add(quarto.Descricao, quarto.IdQuarto);
                }

                cbHospede.DataSource = new BindingSource(xNomes, null);
                cbHospede.DisplayMember = "Key";
                cbHospede.ValueMember = "Value";

                cbQuartos.DataSource = new BindingSource(xQuartos, null);
                cbQuartos.DisplayMember = "Key";
                cbQuartos.ValueMember = "Value";


            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro. " + ex.Message);
            }

        }

        public void FormEdit_OnFechar()
        {
            if (dgvReservas.Rows.Count == 0)
            {
                return;
            }
            btnConsultarTodas_Click(null, null);
        }

        private void btnConsultarTodas_Click(object sender, EventArgs e)
        {
            if (dgvReservas.Columns.Count > 0)
            {
                dgvReservas.Columns.Remove("columnEditar");
                dgvReservas.Columns.Remove("columnCancelar");
                dgvReservas.Columns.Remove("columnServico");
                dgvReservas.Columns.Remove("columnPagamento");

            }
            ConsultarTodas();
        }

        private void ConsultarTodas()
        {
            try
            {
                HotelariaContext context = new HotelariaContext();

                var tbreserva = context.ConsultarReservas();
                List<Reserva> reservas = new List<Reserva>();

                if (tbreserva.Count == 0 || tbreserva == null)
                {
                    MessageBox.Show("Nenhum registro encontrado. ", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var reserva in tbreserva)
                {
                    Reserva res = new Reserva();

                    res.IdReserva = reserva.IdReserva;
                    res.DtEntrada = reserva.DtEntrada;
                    res.DtSaida = reserva.DtSaida;
                    res.StatusReserva = reserva.StatusReserva;
                    res.IdHospede = reserva.IdHospede;
                    res.NomeHospede = reserva.tbHospede.Nome;
                    res.IdQuarto = reserva.IdQuarto;
                    res.DescQuarto = reserva.tbQuarto.Descricao;
                    res.ValorDiaria = reserva.tbQuarto.ValorDiaria;

                    reservas.Add(res);

                };

                dgvReservas.DataSource = reservas;

                dgvReservas.Select();
                dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvReservas.Rows[0].Selected = true;
                return;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Registro_RenomearColunas()
        {
            dgvReservas.Columns["IdReserva"].HeaderText = "ID";
            dgvReservas.Columns["DtEntrada"].HeaderText = "Data Entrada";
            dgvReservas.Columns["DtSaida"].HeaderText = "Data Saída";
            dgvReservas.Columns["StatusReserva"].HeaderText = "Status";
            dgvReservas.Columns["DescQuarto"].HeaderText = "Quarto";
            dgvReservas.Columns["ValorDiaria"].HeaderText = "Valor Diaria";
            dgvReservas.Columns["NomeHospede"].HeaderText = "Hospede";


        }

        private void OcultarColunas()
        {
            dgvReservas.Columns["IdReserva"].Visible = false;
            dgvReservas.Columns["IdHospede"].Visible = false;
            dgvReservas.Columns["IdQuarto"].Visible = false;


        }

        private void Registro_InserirColuna()
        {
            DataGridViewImageColumn columnEditar = new DataGridViewImageColumn();
            columnEditar.Image = Properties.Resources.editing;
            columnEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            columnEditar.Width = 25;
            columnEditar.Name = "columnEditar";
            columnEditar.HeaderText = "";
            dgvReservas.Columns.Insert(0, columnEditar);

            DataGridViewImageColumn columnCancelar = new DataGridViewImageColumn();
            columnCancelar.Image = Properties.Resources.cancel__1_;
            columnCancelar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            columnCancelar.Width = 25;
            columnCancelar.Name = "columnCancelar";
            columnCancelar.HeaderText = "";
            dgvReservas.Columns.Insert(1, columnCancelar);

            DataGridViewImageColumn columnServico = new DataGridViewImageColumn();
            columnServico.Image = Properties.Resources.add;
            columnServico.ImageLayout = DataGridViewImageCellLayout.Zoom;
            columnServico.Width = 25;
            columnServico.Name = "columnServico";
            columnServico.HeaderText = "";
            dgvReservas.Columns.Insert(2, columnServico);

            DataGridViewImageColumn columnPagamento = new DataGridViewImageColumn();
            columnPagamento.Image = Properties.Resources.coin__1_;
            columnPagamento.ImageLayout = DataGridViewImageCellLayout.Zoom;
            columnPagamento.Width = 25;
            columnPagamento.Name = "columnPagamento";
            columnPagamento.HeaderText = "";
            dgvReservas.Columns.Insert(3, columnPagamento);

        }

        private void dgvReservas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (!dgvReservas.Columns.Contains("columnEditar"))
            {
                Registro_InserirColuna();
            }

            OcultarColunas();
            Registro_RenomearColunas();
        }

        private void dgvReservas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvReservas.Rows[e.RowIndex].Cells[0].ToolTipText = "Clique para editar";
            dgvReservas.Rows[e.RowIndex].Cells[1].ToolTipText = "Clique para cancelar";
            dgvReservas.Rows[e.RowIndex].Cells[2].ToolTipText = "Clique para adicionar serviço";
            dgvReservas.Rows[e.RowIndex].Cells[3].ToolTipText = "Clique para adicionar pagamento";
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            Reservar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDtEntrada.Text = "";
            txtDtSaida.Text = "";

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarReserva();
        }

        private void Reservar()
        {
            try
            {
                if (txtDtEntrada.Text == "  /  /" || txtDtEntrada.Text == "  /  /")
                {
                    MessageBox.Show("Data Inválida! ", "Reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Convert.ToDateTime(txtDtEntrada.Text) < DateTime.Now || Convert.ToDateTime(txtDtSaida.Text) < DateTime.Now)
                {
                    MessageBox.Show("Data Inválida! ", "Reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Convert.ToDateTime(txtDtEntrada.Text) > Convert.ToDateTime(txtDtSaida.Text) || Convert.ToDateTime(txtDtSaida.Text) < Convert.ToDateTime(txtDtEntrada.Text))
                {
                    MessageBox.Show("Data Inválida! ", "Reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                HotelariaContext context = new HotelariaContext();

                var idHospede = ((KeyValuePair<string, int>)cbHospede.SelectedItem).Value;
                var idQuarto = ((KeyValuePair<string, int>)cbQuartos.SelectedItem).Value;


                Reserva reserva = new Reserva()
                {
                    DtEntrada = Convert.ToDateTime(txtDtEntrada.Text),
                    DtSaida = Convert.ToDateTime(txtDtSaida.Text),
                    IdQuarto = idQuarto,
                    IdHospede = idHospede
                };

                var insert = context.CadastrarReserva(reserva);

                if (insert)
                {
                    MessageBox.Show("Reserva inserida com sucesso. ", "Reservar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possivel inserir reserva. Motivo: " + ex, "Reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void ConsultarReserva()
        {
            try
            {
                if (txtDtEntrada.Text == "  /  /" || txtDtEntrada.Text == "  /  /")
                {
                    MessageBox.Show("Data Inválida! ", "Reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Convert.ToDateTime(txtDtEntrada.Text) > Convert.ToDateTime(txtDtSaida.Text) || Convert.ToDateTime(txtDtSaida.Text) < Convert.ToDateTime(txtDtEntrada.Text))
                {
                    MessageBox.Show("Data Inválida! ", "Reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                HotelariaContext context = new HotelariaContext();

                var dtEntrada = Convert.ToDateTime(txtDtEntrada.Text);
                var dtSaida = Convert.ToDateTime(txtDtSaida.Text);

                var tbreserva = context.ConsultarReservasByDate(dtEntrada, dtSaida);

                if (tbreserva.Count == 0 || tbreserva == null)
                {
                    MessageBox.Show("Nenhum registro encontrado. ", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<Reserva> reservas = new List<Reserva>();

                foreach (var reserva in tbreserva)
                {
                    Reserva res = new Reserva();

                    res.IdReserva = reserva.IdReserva;
                    res.DtEntrada = reserva.DtEntrada;
                    res.DtSaida = reserva.DtSaida;
                    res.StatusReserva = reserva.StatusReserva;
                    res.IdHospede = reserva.IdHospede;
                    res.NomeHospede = reserva.tbHospede.Nome;
                    res.IdQuarto = reserva.IdQuarto;
                    res.DescQuarto = reserva.tbQuarto.Descricao;
                    res.ValorDiaria = reserva.tbQuarto.ValorDiaria;

                    reservas.Add(res);

                };

                dgvReservas.DataSource = reservas;

                dgvReservas.Select();
                dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvReservas.Rows[0].Selected = true;
                return;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel consultar reserva. Motivo: " + ex, "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EditarReserva()
        {
            var row = dgvReservas.CurrentRow.DataBoundItem as Reserva;

            Reserva reserva = new Reserva()
            {
                IdReserva = row.IdReserva,
                DtEntrada = row.DtEntrada,
                DtSaida = row.DtSaida,
                StatusReserva = row.StatusReserva,
                IdHospede = row.IdHospede,
                NomeHospede = row.NomeHospede,
                IdQuarto = row.IdQuarto,
                DescQuarto = row.DescQuarto,
                ValorDiaria = row.ValorDiaria
            };

            try
            {
                JanelaEditar.Registro_Preencher(reserva);

                JanelaEditar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorrreu um erro. " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InserirPagamento()
        {
            var row = dgvReservas.CurrentRow.DataBoundItem as Reserva;

            

            try
            {
                Pagamento pagamento = new Pagamento();

                var serv = ConsultarServicoByReserva(row.IdReserva);

                if(serv == null)
                {
                    MessageBox.Show("Está reserva não possui serviço vinculado. Para proseguir com o pagamento infome o serviço como \" Não solicitado\" e valor igual a zero!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int dias = (row.DtEntrada.Day - row.DtEntrada.Day);
                decimal valorReserva = dias > 1 ? dias * row.ValorDiaria : row.ValorDiaria;
                decimal valorServico = serv == null ? 0 : serv.Valor;

                pagamento.IdReserva = row.IdReserva;
                pagamento.NomeHospede = row.NomeHospede;
                pagamento.ValorReserva = row.ValorDiaria;


                pagamento.IdServico = serv == null ? 0 : serv.IdServico;
                pagamento.ValorServico = serv == null ? 0 : serv.Valor;
                pagamento.TotalPagamento = valorServico + valorReserva;


                JanelaPagamento.Registro_Preencher(pagamento);

                JanelaPagamento.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorrreu um erro. " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InserirServico()
        {
            var row = dgvReservas.CurrentRow.DataBoundItem as Reserva;

            try
            {
                JanelaServico.Registro_Preencher(row.IdReserva);

                JanelaServico.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorrreu um erro. " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarReserva()
        {
            try
            {

                HotelariaContext context = new HotelariaContext();

                var row = dgvReservas.CurrentRow.DataBoundItem as Reserva;
                var idReserva = row.IdReserva;

                var cancel = context.CancelarReserva(idReserva);

                if (cancel)
                {
                    MessageBox.Show("Reserva cancelada com sucesso. ", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possivel cancelar reserva. Motivo: " + ex, "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReservas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReservas.Columns[e.ColumnIndex] == dgvReservas.Columns["columnCancelar"])
            {
                if (MessageBox.Show("Deseja cancelar a reserva?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        CancelarReserva();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Ocorreu um erro. " + ex.Message, "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else if (dgvReservas.Columns[e.ColumnIndex] == dgvReservas.Columns["columnEditar"])
            {
                try
                {
                    EditarReserva();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro. " + ex.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (dgvReservas.Columns[e.ColumnIndex] == dgvReservas.Columns["columnPagamento"])
            {
                try
                {
                    InserirPagamento();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro. " + ex.Message, "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (dgvReservas.Columns[e.ColumnIndex] == dgvReservas.Columns["columnServico"])
            {
                try
                {
                    InserirServico();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro. " + ex.Message, "Serviço", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        public Servico ConsultarServicoByReserva(int idReserva)
        {
            try
            {
                HotelariaContext context = new HotelariaContext();

                
                var tbservico = context.ConsultarServicoByReserva(idReserva);

                if (tbservico == null)
                {
                    return null;
                }

                Servico serv = new Servico
                {
                    IdServico = tbservico.IdServico,
                    Tipo = tbservico.Tipo,
                    Valor = tbservico.Valor
                };

                return serv;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel consultar serviço. Motivo: " + ex, "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void FormReserva_Load(object sender, EventArgs e)
        {

        }
    }
}
