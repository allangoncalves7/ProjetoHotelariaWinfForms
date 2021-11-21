
namespace ProjetoPim
{
    partial class FormReserva
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
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.txtDtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txtDtSaida = new System.Windows.Forms.MaskedTextBox();
            this.lbDtEntrda = new System.Windows.Forms.Label();
            this.lbDtSaida = new System.Windows.Forms.Label();
            this.cbQuartos = new System.Windows.Forms.ComboBox();
            this.lbQuartos = new System.Windows.Forms.Label();
            this.lbQuarto = new System.Windows.Forms.Label();
            this.cbHospede = new System.Windows.Forms.ComboBox();
            this.lbHospede = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConsultarTodas = new System.Windows.Forms.Button();
            this.lbLogoname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(16, 175);
            this.dgvReservas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.Size = new System.Drawing.Size(1035, 364);
            this.dgvReservas.TabIndex = 0;
            this.dgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentClick);
            this.dgvReservas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentDoubleClick);
            this.dgvReservas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReservas_CellFormatting);
            this.dgvReservas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvReservas_DataBindingComplete);
            // 
            // txtDtEntrada
            // 
            this.txtDtEntrada.Location = new System.Drawing.Point(16, 65);
            this.txtDtEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDtEntrada.Mask = "00/00/0000";
            this.txtDtEntrada.Name = "txtDtEntrada";
            this.txtDtEntrada.Size = new System.Drawing.Size(132, 22);
            this.txtDtEntrada.TabIndex = 1;
            this.txtDtEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtSaida
            // 
            this.txtDtSaida.Location = new System.Drawing.Point(16, 142);
            this.txtDtSaida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDtSaida.Mask = "00/00/0000";
            this.txtDtSaida.Name = "txtDtSaida";
            this.txtDtSaida.Size = new System.Drawing.Size(132, 22);
            this.txtDtSaida.TabIndex = 2;
            this.txtDtSaida.ValidatingType = typeof(System.DateTime);
            // 
            // lbDtEntrda
            // 
            this.lbDtEntrda.AutoSize = true;
            this.lbDtEntrda.Location = new System.Drawing.Point(17, 42);
            this.lbDtEntrda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDtEntrda.Name = "lbDtEntrda";
            this.lbDtEntrda.Size = new System.Drawing.Size(92, 17);
            this.lbDtEntrda.TabIndex = 3;
            this.lbDtEntrda.Text = "Data Entrada";
            // 
            // lbDtSaida
            // 
            this.lbDtSaida.AutoSize = true;
            this.lbDtSaida.Location = new System.Drawing.Point(16, 117);
            this.lbDtSaida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDtSaida.Name = "lbDtSaida";
            this.lbDtSaida.Size = new System.Drawing.Size(78, 17);
            this.lbDtSaida.TabIndex = 4;
            this.lbDtSaida.Text = "Data Saída";
            // 
            // cbQuartos
            // 
            this.cbQuartos.FormattingEnabled = true;
            this.cbQuartos.Location = new System.Drawing.Point(183, 64);
            this.cbQuartos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbQuartos.Name = "cbQuartos";
            this.cbQuartos.Size = new System.Drawing.Size(160, 24);
            this.cbQuartos.TabIndex = 5;
            // 
            // lbQuartos
            // 
            this.lbQuartos.AutoSize = true;
            this.lbQuartos.Location = new System.Drawing.Point(368, 118);
            this.lbQuartos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuartos.Name = "lbQuartos";
            this.lbQuartos.Size = new System.Drawing.Size(0, 17);
            this.lbQuartos.TabIndex = 6;
            // 
            // lbQuarto
            // 
            this.lbQuarto.AutoSize = true;
            this.lbQuarto.Location = new System.Drawing.Point(185, 42);
            this.lbQuarto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuarto.Name = "lbQuarto";
            this.lbQuarto.Size = new System.Drawing.Size(52, 17);
            this.lbQuarto.TabIndex = 7;
            this.lbQuarto.Text = "Quarto";
            // 
            // cbHospede
            // 
            this.cbHospede.FormattingEnabled = true;
            this.cbHospede.Location = new System.Drawing.Point(183, 140);
            this.cbHospede.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbHospede.Name = "cbHospede";
            this.cbHospede.Size = new System.Drawing.Size(160, 24);
            this.cbHospede.TabIndex = 8;
            // 
            // lbHospede
            // 
            this.lbHospede.AutoSize = true;
            this.lbHospede.Location = new System.Drawing.Point(183, 117);
            this.lbHospede.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHospede.Name = "lbHospede";
            this.lbHospede.Size = new System.Drawing.Size(65, 17);
            this.lbHospede.TabIndex = 9;
            this.lbHospede.Text = "Hospede";
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(425, 138);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(100, 28);
            this.btnReservar.TabIndex = 10;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(583, 138);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 28);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(743, 138);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConsultarTodas
            // 
            this.btnConsultarTodas.Location = new System.Drawing.Point(905, 138);
            this.btnConsultarTodas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultarTodas.Name = "btnConsultarTodas";
            this.btnConsultarTodas.Size = new System.Drawing.Size(145, 28);
            this.btnConsultarTodas.TabIndex = 13;
            this.btnConsultarTodas.Text = "Consultar Todas";
            this.btnConsultarTodas.UseVisualStyleBackColor = true;
            this.btnConsultarTodas.Click += new System.EventHandler(this.btnConsultarTodas_Click);
            // 
            // lbLogoname
            // 
            this.lbLogoname.AutoSize = true;
            this.lbLogoname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogoname.Location = new System.Drawing.Point(667, 49);
            this.lbLogoname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogoname.Name = "lbLogoname";
            this.lbLogoname.Size = new System.Drawing.Size(267, 39);
            this.lbLogoname.TabIndex = 15;
            this.lbLogoname.Text = "NossoHotel.com";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoPim.Properties.Resources.nossoHotelLogo;
            this.pictureBox1.Location = new System.Drawing.Point(515, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbLogoname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConsultarTodas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.lbHospede);
            this.Controls.Add(this.cbHospede);
            this.Controls.Add(this.lbQuarto);
            this.Controls.Add(this.lbQuartos);
            this.Controls.Add(this.cbQuartos);
            this.Controls.Add(this.lbDtSaida);
            this.Controls.Add(this.lbDtEntrda);
            this.Controls.Add(this.txtDtSaida);
            this.Controls.Add(this.txtDtEntrada);
            this.Controls.Add(this.dgvReservas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormReserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.FormReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.MaskedTextBox txtDtEntrada;
        private System.Windows.Forms.MaskedTextBox txtDtSaida;
        private System.Windows.Forms.Label lbDtEntrda;
        private System.Windows.Forms.Label lbDtSaida;
        private System.Windows.Forms.ComboBox cbQuartos;
        private System.Windows.Forms.Label lbQuartos;
        private System.Windows.Forms.Label lbQuarto;
        private System.Windows.Forms.ComboBox cbHospede;
        private System.Windows.Forms.Label lbHospede;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConsultarTodas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbLogoname;
    }
}