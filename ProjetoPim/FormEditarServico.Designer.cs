
namespace ProjetoPim
{
    partial class FormEditarServico
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
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.lbTipoServico = new System.Windows.Forms.Label();
            this.txtValorServico = new System.Windows.Forms.TextBox();
            this.lbValorDiaria = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTipoServico = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Location = new System.Drawing.Point(11, 73);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(32, 20);
            this.txtIdReserva.TabIndex = 32;
            this.txtIdReserva.Visible = false;
            // 
            // lbTipoServico
            // 
            this.lbTipoServico.AutoSize = true;
            this.lbTipoServico.Location = new System.Drawing.Point(9, 12);
            this.lbTipoServico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTipoServico.Name = "lbTipoServico";
            this.lbTipoServico.Size = new System.Drawing.Size(82, 13);
            this.lbTipoServico.TabIndex = 25;
            this.lbTipoServico.Text = "Tipo do Serviço";
            // 
            // txtValorServico
            // 
            this.txtValorServico.Location = new System.Drawing.Point(340, 28);
            this.txtValorServico.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorServico.Name = "txtValorServico";
            this.txtValorServico.Size = new System.Drawing.Size(146, 20);
            this.txtValorServico.TabIndex = 26;
            // 
            // lbValorDiaria
            // 
            this.lbValorDiaria.AutoSize = true;
            this.lbValorDiaria.Location = new System.Drawing.Point(337, 12);
            this.lbValorDiaria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbValorDiaria.Name = "lbValorDiaria";
            this.lbValorDiaria.Size = new System.Drawing.Size(85, 13);
            this.lbValorDiaria.TabIndex = 27;
            this.lbValorDiaria.Text = "Valor do Serviço";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(247, 73);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 23);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 73);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtTipoServico
            // 
            this.txtTipoServico.Location = new System.Drawing.Point(11, 28);
            this.txtTipoServico.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipoServico.Name = "txtTipoServico";
            this.txtTipoServico.Size = new System.Drawing.Size(310, 20);
            this.txtTipoServico.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoPim.Properties.Resources.nossoHotelLogo;
            this.pictureBox1.Location = new System.Drawing.Point(505, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // FormEditarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 129);
            this.Controls.Add(this.txtIdReserva);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbValorDiaria);
            this.Controls.Add(this.txtValorServico);
            this.Controls.Add(this.lbTipoServico);
            this.Controls.Add(this.txtTipoServico);
            this.Name = "FormEditarServico";
            this.Text = "FormEditarServico";
            this.Load += new System.EventHandler(this.FormEditarServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.Label lbTipoServico;
        private System.Windows.Forms.TextBox txtValorServico;
        private System.Windows.Forms.Label lbValorDiaria;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTipoServico;
    }
}