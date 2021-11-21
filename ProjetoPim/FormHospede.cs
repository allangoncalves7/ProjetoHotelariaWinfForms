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
    public partial class FormHospede : Form
    {
        private FormEditarHospede JanelaEditar;
        public FormHospede()
        {
            InitializeComponent();
            JanelaEditar = new FormEditarHospede();
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
                var registro = RegistrarHospede(Nome.Text, CPF.Text, Telefone.Text, Convert.ToDateTime(Data.Text), Email.Text, "password");

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

            HotelariaContext context = new HotelariaContext();

            Console.WriteLine(hosp);
            var insert = context.InserirHospede(hosp);

            return insert;

        }

        private void Registro_RenomearColunas()
        {
            dgvHospedes.Columns["IdHospede"].HeaderText = "ID";
            dgvHospedes.Columns["Nome"].HeaderText = "Nome";
            dgvHospedes.Columns["Cpf"].HeaderText = "Cpf";
            dgvHospedes.Columns["Email"].HeaderText = "Email";
            dgvHospedes.Columns["Telefone"].HeaderText = "Telefone";
            dgvHospedes.Columns["DtNasc"].HeaderText = "Data de Nascimento";
        }

        private void OcultarColunas()
        {
            dgvHospedes.Columns["IdHospede"].Visible = false;
            dgvHospedes.Columns["Senha"].Visible = false;
        }

        private void Registro_InserirColuna()
        {
            DataGridViewImageColumn columnEditar = new DataGridViewImageColumn();
            columnEditar.Image = Properties.Resources.editing;
            columnEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            columnEditar.Width = 25;
            columnEditar.Name = "columnEditar";
            columnEditar.HeaderText = "";
            dgvHospedes.Columns.Insert(0, columnEditar);

            DataGridViewImageColumn columnCancelar = new DataGridViewImageColumn();
            columnCancelar.Image = Properties.Resources.cancel__1_;
            columnEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            columnCancelar.Width = 25;
            columnCancelar.Name = "columnExcluir";
            columnCancelar.HeaderText = "";
            dgvHospedes.Columns.Insert(1, columnCancelar);
        }

        private void btnConsultarTodas_Click(object sender, EventArgs e)
        {
            if (dgvHospedes.Columns.Count > 0)
            {
                dgvHospedes.Columns.Remove("columnEditar");
                dgvHospedes.Columns.Remove("columnExcluir");
            }
            ConsultarTodas();
        }

        private void ConsultarTodas()
        {
            try
            {
                HotelariaContext context = new HotelariaContext();

                var tbhospede = context.ConsultarHospedes();
                List<Hospede> hospedes = new List<Hospede>();

                if (tbhospede.Count == 0 || tbhospede == null)
                {
                    MessageBox.Show("Nenhum registro encontrado. ", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var hospede in tbhospede)
                {
                    Hospede res = new Hospede();

                    res.IdHospede = hospede.IdHospede;
                    res.Nome = hospede.Nome;
                    res.Telefone = hospede.Telefone;
                    res.Email = hospede.Email;
                    res.Cpf = hospede.Cpf;
                    res.DtNasc = hospede.DtNasc;

                    hospedes.Add(res);
                };

    
                dgvHospedes.DataSource = hospedes;

                dgvHospedes.Select();
                dgvHospedes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvHospedes.Rows[0].Selected = true;
                return;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dgvHospedes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (!dgvHospedes.Columns.Contains("columnEditar"))
            {
                Registro_InserirColuna();
            }

            OcultarColunas();
            Registro_RenomearColunas();
        }

        private void dgvHospedes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvHospedes.Rows[e.RowIndex].Cells[0].ToolTipText = "Clique para editar";
            dgvHospedes.Rows[e.RowIndex].Cells[1].ToolTipText = "Clique para cancelar";
        }

        private void dgvHospedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHospedes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHospedes.Columns[e.ColumnIndex] == dgvHospedes.Columns["columnExcluir"])
            {
                if (MessageBox.Show("Deseja excluir a reserva?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        ExcluirHospede();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Ocorreu um erro. " + ex.Message, "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else if (dgvHospedes.Columns[e.ColumnIndex] == dgvHospedes.Columns["columnEditar"])
            {
                try
                {
                    EditarHospede();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro. " + ex.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void ExcluirHospede()
        {
            HotelariaContext context = new HotelariaContext();

            var row = dgvHospedes.CurrentRow.DataBoundItem as Hospede;
            var idHospede = row.IdHospede;
            Console.WriteLine(idHospede);

            var cancel = context.ExcluirHospede(idHospede);

            if (cancel)
            {
                MessageBox.Show("Hospede excluído com sucesso. ", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void EditarHospede()
        {
            var row = dgvHospedes.CurrentRow.DataBoundItem as Hospede;

            Hospede reserva = new Hospede()
            {
                IdHospede = row.IdHospede,
                Cpf = row.Cpf,
                DtNasc = row.DtNasc,
                Email = row.Email,
                Nome = row.Nome,
                Senha = row.Senha,
                Telefone = row.Telefone,
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
    }
}
