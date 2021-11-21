
namespace ProjetoPim
{
    partial class FormPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.ValorDiariaLabel = new System.Windows.Forms.Label();
            this.txtTotalPag = new System.Windows.Forms.TextBox();
            this.DescricaoLabel = new System.Windows.Forms.Label();
            this.cbTipoPag = new System.Windows.Forms.ComboBox();
            this.dgvPagamentos = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.txtIdServico = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(488, 67);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(338, 67);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(104, 23);
            this.btnEnviar.TabIndex = 18;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // ValorDiariaLabel
            // 
            this.ValorDiariaLabel.AutoSize = true;
            this.ValorDiariaLabel.Location = new System.Drawing.Point(335, 6);
            this.ValorDiariaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValorDiariaLabel.Name = "ValorDiariaLabel";
            this.ValorDiariaLabel.Size = new System.Drawing.Size(88, 13);
            this.ValorDiariaLabel.TabIndex = 17;
            this.ValorDiariaLabel.Text = "Total Pagamento";
            // 
            // txtTotalPag
            // 
            this.txtTotalPag.Location = new System.Drawing.Point(338, 23);
            this.txtTotalPag.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPag.Name = "txtTotalPag";
            this.txtTotalPag.ReadOnly = true;
            this.txtTotalPag.Size = new System.Drawing.Size(254, 20);
            this.txtTotalPag.TabIndex = 16;
            this.txtTotalPag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorDiaria_KeyPress);
            // 
            // DescricaoLabel
            // 
            this.DescricaoLabel.AutoSize = true;
            this.DescricaoLabel.Location = new System.Drawing.Point(7, 6);
            this.DescricaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescricaoLabel.Name = "DescricaoLabel";
            this.DescricaoLabel.Size = new System.Drawing.Size(99, 13);
            this.DescricaoLabel.TabIndex = 15;
            this.DescricaoLabel.Text = "Tipo de pagamento";
            // 
            // cbTipoPag
            // 
            this.cbTipoPag.FormattingEnabled = true;
            this.cbTipoPag.Location = new System.Drawing.Point(10, 23);
            this.cbTipoPag.Name = "cbTipoPag";
            this.cbTipoPag.Size = new System.Drawing.Size(280, 21);
            this.cbTipoPag.TabIndex = 20;
            // 
            // dgvPagamentos
            // 
            this.dgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamentos.Location = new System.Drawing.Point(10, 100);
            this.dgvPagamentos.Name = "dgvPagamentos";
            this.dgvPagamentos.Size = new System.Drawing.Size(578, 218);
            this.dgvPagamentos.TabIndex = 21;
            this.dgvPagamentos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagamentos_CellContentDoubleClick);
            this.dgvPagamentos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPagamentos_CellFormatting);
            this.dgvPagamentos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPagamentos_DataBindingComplete);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(13, 66);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(108, 23);
            this.btnConsultar.TabIndex = 22;
            this.btnConsultar.Text = "Consultar Todos";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Location = new System.Drawing.Point(128, 68);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(28, 20);
            this.txtIdReserva.TabIndex = 23;
            this.txtIdReserva.Visible = false;
            // 
            // txtIdServico
            // 
            this.txtIdServico.Location = new System.Drawing.Point(163, 67);
            this.txtIdServico.Name = "txtIdServico";
            this.txtIdServico.Size = new System.Drawing.Size(25, 20);
            this.txtIdServico.TabIndex = 24;
            this.txtIdServico.Visible = false;
            // 
            // FormPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 330);
            this.Controls.Add(this.txtIdServico);
            this.Controls.Add(this.txtIdReserva);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvPagamentos);
            this.Controls.Add(this.cbTipoPag);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.ValorDiariaLabel);
            this.Controls.Add(this.txtTotalPag);
            this.Controls.Add(this.DescricaoLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPagamento";
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.FormPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label ValorDiariaLabel;
        private System.Windows.Forms.TextBox txtTotalPag;
        private System.Windows.Forms.Label DescricaoLabel;
        private System.Windows.Forms.ComboBox cbTipoPag;
        private System.Windows.Forms.DataGridView dgvPagamentos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.TextBox txtIdServico;
    }
}