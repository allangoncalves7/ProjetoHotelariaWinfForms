
namespace ProjetoPim
{
    partial class FormServico
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbValorDiaria = new System.Windows.Forms.Label();
            this.txtValorServico = new System.Windows.Forms.TextBox();
            this.lbTipoServico = new System.Windows.Forms.Label();
            this.txtTipoServico = new System.Windows.Forms.TextBox();
            this.dgvServicos = new System.Windows.Forms.DataGridView();
            this.btnConsultarServico = new System.Windows.Forms.Button();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 74);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(245, 74);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbValorDiaria
            // 
            this.lbValorDiaria.AutoSize = true;
            this.lbValorDiaria.Location = new System.Drawing.Point(335, 13);
            this.lbValorDiaria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbValorDiaria.Name = "lbValorDiaria";
            this.lbValorDiaria.Size = new System.Drawing.Size(85, 13);
            this.lbValorDiaria.TabIndex = 17;
            this.lbValorDiaria.Text = "Valor do Serviço";
            // 
            // txtValorServico
            // 
            this.txtValorServico.Location = new System.Drawing.Point(338, 29);
            this.txtValorServico.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorServico.Name = "txtValorServico";
            this.txtValorServico.Size = new System.Drawing.Size(146, 20);
            this.txtValorServico.TabIndex = 16;
            this.txtValorServico.TextChanged += new System.EventHandler(this.ValorServico_TextChanged);
            // 
            // lbTipoServico
            // 
            this.lbTipoServico.AutoSize = true;
            this.lbTipoServico.Location = new System.Drawing.Point(7, 13);
            this.lbTipoServico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTipoServico.Name = "lbTipoServico";
            this.lbTipoServico.Size = new System.Drawing.Size(82, 13);
            this.lbTipoServico.TabIndex = 15;
            this.lbTipoServico.Text = "Tipo do Serviço";
            // 
            // txtTipoServico
            // 
            this.txtTipoServico.Location = new System.Drawing.Point(9, 29);
            this.txtTipoServico.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipoServico.Name = "txtTipoServico";
            this.txtTipoServico.Size = new System.Drawing.Size(310, 20);
            this.txtTipoServico.TabIndex = 14;
            // 
            // dgvServicos
            // 
            this.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicos.Location = new System.Drawing.Point(9, 120);
            this.dgvServicos.Name = "dgvServicos";
            this.dgvServicos.Size = new System.Drawing.Size(583, 215);
            this.dgvServicos.TabIndex = 21;
            this.dgvServicos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicos_CellContentDoubleClick);
            this.dgvServicos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvServicos_CellFormatting);
            this.dgvServicos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvServicos_DataBindingComplete);
            // 
            // btnConsultarServico
            // 
            this.btnConsultarServico.Location = new System.Drawing.Point(10, 91);
            this.btnConsultarServico.Name = "btnConsultarServico";
            this.btnConsultarServico.Size = new System.Drawing.Size(106, 23);
            this.btnConsultarServico.TabIndex = 22;
            this.btnConsultarServico.Text = "Consultar Serviços";
            this.btnConsultarServico.UseVisualStyleBackColor = true;
            this.btnConsultarServico.Click += new System.EventHandler(this.btnConsultarServico_Click);
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Location = new System.Drawing.Point(122, 93);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(32, 20);
            this.txtIdReserva.TabIndex = 23;
            this.txtIdReserva.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoPim.Properties.Resources.nossoHotelLogo;
            this.pictureBox1.Location = new System.Drawing.Point(503, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FormServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 381);
            this.Controls.Add(this.txtIdReserva);
            this.Controls.Add(this.btnConsultarServico);
            this.Controls.Add(this.dgvServicos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbValorDiaria);
            this.Controls.Add(this.txtValorServico);
            this.Controls.Add(this.lbTipoServico);
            this.Controls.Add(this.txtTipoServico);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormServico";
            this.Text = "Servico";
            this.Load += new System.EventHandler(this.FormServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbValorDiaria;
        private System.Windows.Forms.TextBox txtValorServico;
        private System.Windows.Forms.Label lbTipoServico;
        private System.Windows.Forms.TextBox txtTipoServico;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvServicos;
        private System.Windows.Forms.Button btnConsultarServico;
        private System.Windows.Forms.TextBox txtIdReserva;
    }
}