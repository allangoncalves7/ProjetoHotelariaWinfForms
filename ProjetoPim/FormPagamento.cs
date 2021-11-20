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
    public partial class FormPagamento : Form
    {
        public FormPagamento()
        {
            InitializeComponent();
            FillDrop();
        }

        private void FillDrop()
        {
            cbTipoPag.DataSource = null;

            List<string> tpPagamentos = new List<string>();

            tpPagamentos.Add("CRÉDITO");
            tpPagamentos.Add("DÉBITO");
            tpPagamentos.Add("DINHEIRO");

            cbTipoPag.DataSource = tpPagamentos;
        }

        public void Registro_Preencher(Pagamento pagamento)
        {

            try
            {
                txtTotalPag.Text = pagamento.TotalPagamento.ToString();
                txtIdReserva.Text = pagamento.IdReserva.ToString();
                txtIdServico.Text = pagamento.IdServico.ToString();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void ConsultarPagamento()
        {
            try
            {
                HotelariaContext context = new HotelariaContext();

                var tbpagamento = context.ConsultarPagamentos();
                List<Pagamento> pagamentos = new List<Pagamento>();

                if (tbpagamento.Count == 0 || tbpagamento == null)
                {
                    dgvPagamentos.Update();
                    MessageBox.Show("Nenhum registro encontrado. ", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var pagamento in tbpagamento)
                {
                    Pagamento pag = new Pagamento();

                    var dias = pagamento.tbReserva.DtEntrada.Day - pagamento.tbReserva.DtEntrada.Day;
                    var diaria = pagamento.tbReserva.tbQuarto.ValorDiaria;
                    var valorReserva = dias > 1 ? dias * diaria : diaria;

                    pag.IdPagamento = pagamento.IdPagamento;
                    pag.IdServico = pagamento.IdServico;
                    pag.IdReserva = pagamento.IdReserva;
                    pag.Tipo = pagamento.Tipo;
                    pag.TotalPagamento = pagamento.TotalPagamento;
                    pag.ValorReserva = valorReserva;
                    pag.ValorServico = pagamento.tbServico.Valor;
                    pag.NomeHospede = pagamento.tbReserva.tbHospede.Nome;

                    pagamentos.Add(pag);

                };

                dgvPagamentos.DataSource = pagamentos;

                dgvPagamentos.Select();
                dgvPagamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvPagamentos.Rows[0].Selected = true;

                return;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void ExcluirPagamento()
        {

            HotelariaContext context = new HotelariaContext();

            var row = dgvPagamentos.CurrentRow.DataBoundItem as Pagamento;
            var idPag = row.IdPagamento;

            var cancel = context.ExcluirPagamento(idPag);

            if (cancel)
            {
                MessageBox.Show("Pagamento excluído com sucesso. ", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
        }

        private void SalvarPagamento()
        {
            try
            {

                HotelariaContext context = new HotelariaContext();

                var idReserva = Convert.ToInt32(txtIdReserva.Text);

                var pag = context.ConsultarPagamentoByReserva(idReserva);

                if (pag != null)
                {
                    MessageBox.Show(" Esse Pagamento já foi realizado. ", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idServ = Convert.ToInt32(txtIdServico.Text);

                Pagamento pagamento = new Pagamento();

                pagamento.IdReserva = Convert.ToInt32(txtIdReserva.Text);
                pagamento.TotalPagamento = Convert.ToDecimal(txtTotalPag.Text);
                pagamento.IdServico = idServ;

                pagamento.Tipo = cbTipoPag.Text;



                var insert = context.CadastrarPagamento(pagamento);

                if (insert)
                {
                    MessageBox.Show("Pagamento realizado com sucesso. ", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possivel inserir serviço. Motivo: " + ex, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void FormPagamento_Load(object sender, EventArgs e)
        {

        }

        private void dgvPagamentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPagamentos.Columns[e.ColumnIndex] == dgvPagamentos.Columns["columnExcluir"])
            {
                if (MessageBox.Show("Deseja excluir o pagamento?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        ExcluirPagamento();
                        LimparCampos();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Ocorreu um erro. " + ex.Message, "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            
        }

        private void LimparCampos()
        {
            txtIdReserva.Text = string.Empty;
            txtIdServico.Text = string.Empty;
            txtTotalPag.Text = string.Empty;
        }

        private void dgvPagamentos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (!dgvPagamentos.Columns.Contains("columnEditar"))
            {
                Registro_InserirColuna();
            }

            OcultarColunas();
            Registro_RenomearColunas();
        }

        private void Registro_RenomearColunas()
        {

            dgvPagamentos.Columns["ValorServico"].HeaderText = "Valor Serviço";
            dgvPagamentos.Columns["ValorReserva"].HeaderText = "Valor Reserva";
            dgvPagamentos.Columns["NomeHospede"].HeaderText = "Hospede";
            dgvPagamentos.Columns["TotalPagamento"].HeaderText = "Total Pagamento";


        }

        private void OcultarColunas()
        {
            dgvPagamentos.Columns["IdReserva"].Visible = false;
            dgvPagamentos.Columns["IdServico"].Visible = false;
            dgvPagamentos.Columns["IdPagamento"].Visible = false;



        }

        private void Registro_InserirColuna()
        {

            DataGridViewImageColumn columnExcluir = new DataGridViewImageColumn();
            columnExcluir.Image = Properties.Resources.cancel__1_;
            columnExcluir.ImageLayout = DataGridViewImageCellLayout.Zoom;
            columnExcluir.Width = 25;
            columnExcluir.Name = "columnExcluir";
            columnExcluir.HeaderText = "";
            dgvPagamentos.Columns.Insert(1, columnExcluir);



        }

        private void dgvPagamentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvPagamentos.Rows[e.RowIndex].Cells[0].ToolTipText = "Clique para editar";
            dgvPagamentos.Rows[e.RowIndex].Cells[1].ToolTipText = "Clique para cancelar";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            SalvarPagamento();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarPagamento();
        }
    }
}
