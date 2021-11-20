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
    public partial class FormServico : Form
    {

        private FormEditarServico JanelaEditarServico;

        public FormServico()
        {
            InitializeComponent();

            JanelaEditarServico = new FormEditarServico();
        }

        public void Registro_Preencher(int id)
        {

            try
            {
                txtIdReserva.Text = id.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ValorServico_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarServico_Click(object sender, EventArgs e)
        {
            ConsultarServicos();
        }

        private void ConsultarServicos()
        {
            try
            {
                HotelariaContext context = new HotelariaContext();

                var tbservico = context.ConsultarServicos();
                List<Servico> servicos = new List<Servico>();

                if (tbservico.Count == 0 || tbservico == null)
                {
                    dgvServicos.Update();
                    MessageBox.Show("Nenhum registro encontrado. ", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var servico in tbservico)
                {
                    Servico serv = new Servico();

                    serv.IdServico = servico.IdServico;
                    serv.IdReserva = servico.IdReserva;
                    serv.Tipo = servico.Tipo;
                    serv.Valor = servico.Valor;
                    serv.NomeHospede = servico.tbReserva.tbHospede.Nome;

                    servicos.Add(serv);

                };

                dgvServicos.DataSource = servicos;

                dgvServicos.Select();
                dgvServicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvServicos.Rows[0].Selected = true;

                return;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void CadastrarServico()
        {
            try
            {
                if (String.IsNullOrEmpty(txtTipoServico.Text))
                {
                    MessageBox.Show("Insira o tipo de serviço!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (String.IsNullOrEmpty(txtValorServico.Text))
                {
                    MessageBox.Show("Insira o valor do serviço!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                HotelariaContext context = new HotelariaContext();

                var idReserva = Convert.ToInt32(txtIdReserva.Text);


                Servico servico = new Servico()
                {
                    Tipo = txtTipoServico.Text,
                    Valor = Convert.ToDecimal(txtValorServico.Text),
                    IdReserva = idReserva

                };

                var insert = context.CadastrarServico(servico);

                if (insert)
                {
                    MessageBox.Show("Serviço inserido com sucesso. ", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possivel inserir serviço. Motivo: " + ex, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarServico()
        {
            var row = dgvServicos.CurrentRow.DataBoundItem as Servico;

            Servico reserva = new Servico()
            {
                IdServico = row.IdServico,
                Tipo = row.Tipo,
                Valor = row.Valor
            };

            try
            {
                JanelaEditarServico.Registro_Preencher(reserva);

                JanelaEditarServico.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorrreu um erro. " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ExcluirServico()
        {
            HotelariaContext context = new HotelariaContext();

            var row = dgvServicos.CurrentRow.DataBoundItem as Servico;
            var idReserva = row.IdServico;

            var cancel = context.ExcluirServico(idReserva);

            if (cancel)
            {
                MessageBox.Show("Serviço excluído com sucesso. ", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void Registro_RenomearColunas()
        {

            dgvServicos.Columns["NomeHospede"].HeaderText = "Hospede";


        }

        private void OcultarColunas()
        {
            dgvServicos.Columns["IdReserva"].Visible = false;
            dgvServicos.Columns["IdServico"].Visible = false;

        }

        private void Registro_InserirColuna()
        {
            DataGridViewImageColumn columnEditar = new DataGridViewImageColumn();
            columnEditar.Image = Properties.Resources.editing;
            columnEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            columnEditar.Width = 25;
            columnEditar.Name = "columnEditar";
            columnEditar.HeaderText = "";
            dgvServicos.Columns.Insert(0, columnEditar);

            DataGridViewImageColumn columnExcluir = new DataGridViewImageColumn();
            columnExcluir.Image = Properties.Resources.cancel__1_;
            columnExcluir.ImageLayout = DataGridViewImageCellLayout.Zoom;
            columnExcluir.Width = 25;
            columnExcluir.Name = "columnExcluir";
            columnExcluir.HeaderText = "";
            dgvServicos.Columns.Insert(1, columnExcluir);


        }

        private void LimparCampos()
        {
            txtTipoServico.Text = string.Empty;
            txtValorServico.Text = string.Empty;
        }

        private void dgvServicos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (!dgvServicos.Columns.Contains("columnEditar"))
            {
                Registro_InserirColuna();
            }

            OcultarColunas();
            Registro_RenomearColunas();
        }

        private void dgvServicos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServicos.Columns[e.ColumnIndex] == dgvServicos.Columns["columnExcluir"])
            {
                if (MessageBox.Show("Deseja excluir o serviço?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        ExcluirServico();
                        LimparCampos();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Ocorreu um erro. " + ex.Message, "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else if (dgvServicos.Columns[e.ColumnIndex] == dgvServicos.Columns["columnEditar"])
            {
                try
                {
                    EditarServico();
                    LimparCampos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro. " + ex.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarServico();
            LimparCampos();
        }

        private void FormServico_Load(object sender, EventArgs e)
        {

        }

        private void dgvServicos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvServicos.Rows[e.RowIndex].Cells[0].ToolTipText = "Clique para editar";
            dgvServicos.Rows[e.RowIndex].Cells[1].ToolTipText = "Clique para cancelar";
        }
    }
}
