
namespace ProjetoPim
{
    partial class FormEditarReserva
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
            this.lbLogoname = new System.Windows.Forms.Label();
            this.cbHospede = new System.Windows.Forms.ComboBox();
            this.cbQuartos = new System.Windows.Forms.ComboBox();
            this.txtDtSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtDtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbDtEntrda = new System.Windows.Forms.Label();
            this.lbQuarto = new System.Windows.Forms.Label();
            this.lbDtSaida = new System.Windows.Forms.Label();
            this.lbHospede = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogoname
            // 
            this.lbLogoname.AutoSize = true;
            this.lbLogoname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogoname.Location = new System.Drawing.Point(320, 70);
            this.lbLogoname.Name = "lbLogoname";
            this.lbLogoname.Size = new System.Drawing.Size(223, 32);
            this.lbLogoname.TabIndex = 21;
            this.lbLogoname.Text = "NossoHotel.com";
            // 
            // cbHospede
            // 
            this.cbHospede.FormattingEnabled = true;
            this.cbHospede.Location = new System.Drawing.Point(422, 266);
            this.cbHospede.Name = "cbHospede";
            this.cbHospede.Size = new System.Drawing.Size(121, 21);
            this.cbHospede.TabIndex = 25;
            // 
            // cbQuartos
            // 
            this.cbQuartos.FormattingEnabled = true;
            this.cbQuartos.Location = new System.Drawing.Point(422, 204);
            this.cbQuartos.Name = "cbQuartos";
            this.cbQuartos.Size = new System.Drawing.Size(121, 21);
            this.cbQuartos.TabIndex = 24;
            // 
            // txtDtSaida
            // 
            this.txtDtSaida.Location = new System.Drawing.Point(206, 259);
            this.txtDtSaida.Mask = "00/00/0000";
            this.txtDtSaida.Name = "txtDtSaida";
            this.txtDtSaida.Size = new System.Drawing.Size(100, 20);
            this.txtDtSaida.TabIndex = 23;
            this.txtDtSaida.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtEntrada
            // 
            this.txtDtEntrada.Location = new System.Drawing.Point(206, 205);
            this.txtDtEntrada.Mask = "00/00/0000";
            this.txtDtEntrada.Name = "txtDtEntrada";
            this.txtDtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtDtEntrada.TabIndex = 22;
            this.txtDtEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoPim.Properties.Resources.nossoHotelLogo;
            this.pictureBox1.Location = new System.Drawing.Point(206, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lbDtEntrda
            // 
            this.lbDtEntrda.AutoSize = true;
            this.lbDtEntrda.Location = new System.Drawing.Point(203, 189);
            this.lbDtEntrda.Name = "lbDtEntrda";
            this.lbDtEntrda.Size = new System.Drawing.Size(70, 13);
            this.lbDtEntrda.TabIndex = 26;
            this.lbDtEntrda.Text = "Data Entrada";
            // 
            // lbQuarto
            // 
            this.lbQuarto.AutoSize = true;
            this.lbQuarto.Location = new System.Drawing.Point(419, 188);
            this.lbQuarto.Name = "lbQuarto";
            this.lbQuarto.Size = new System.Drawing.Size(39, 13);
            this.lbQuarto.TabIndex = 27;
            this.lbQuarto.Text = "Quarto";
            // 
            // lbDtSaida
            // 
            this.lbDtSaida.AutoSize = true;
            this.lbDtSaida.Location = new System.Drawing.Point(203, 243);
            this.lbDtSaida.Name = "lbDtSaida";
            this.lbDtSaida.Size = new System.Drawing.Size(62, 13);
            this.lbDtSaida.TabIndex = 28;
            this.lbDtSaida.Text = "Data Saída";
            // 
            // lbHospede
            // 
            this.lbHospede.AutoSize = true;
            this.lbHospede.Location = new System.Drawing.Point(419, 250);
            this.lbHospede.Name = "lbHospede";
            this.lbHospede.Size = new System.Drawing.Size(50, 13);
            this.lbHospede.TabIndex = 29;
            this.lbHospede.Text = "Hospede";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(446, 349);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(326, 349);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 31;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(208, 349);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(206, 308);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 33;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(206, 291);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 34;
            this.lbStatus.Text = "Status";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(132, 204);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(28, 20);
            this.txtId.TabIndex = 35;
            this.txtId.Visible = false;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(110, 207);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 36;
            this.lbId.Text = "Id";
            this.lbId.Visible = false;
            // 
            // FormEditarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbHospede);
            this.Controls.Add(this.lbDtSaida);
            this.Controls.Add(this.lbQuarto);
            this.Controls.Add(this.lbDtEntrda);
            this.Controls.Add(this.cbHospede);
            this.Controls.Add(this.cbQuartos);
            this.Controls.Add(this.txtDtSaida);
            this.Controls.Add(this.txtDtEntrada);
            this.Controls.Add(this.lbLogoname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormEditarReserva";
            this.Text = "FormEditarReserva";
            this.Load += new System.EventHandler(this.FormEditarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogoname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbHospede;
        private System.Windows.Forms.ComboBox cbQuartos;
        private System.Windows.Forms.MaskedTextBox txtDtSaida;
        private System.Windows.Forms.MaskedTextBox txtDtEntrada;
        private System.Windows.Forms.Label lbDtEntrda;
        private System.Windows.Forms.Label lbQuarto;
        private System.Windows.Forms.Label lbDtSaida;
        private System.Windows.Forms.Label lbHospede;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbId;
    }
}