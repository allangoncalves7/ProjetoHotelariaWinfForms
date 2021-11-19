
namespace ProjetoPim
{
    partial class FormQuarto
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
            this.ValorDiariaLabel = new System.Windows.Forms.Label();
            this.ValorDiaria = new System.Windows.Forms.TextBox();
            this.DescricaoLabel = new System.Windows.Forms.Label();
            this.Descricao = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ValorDiariaLabel
            // 
            this.ValorDiariaLabel.AutoSize = true;
            this.ValorDiariaLabel.Location = new System.Drawing.Point(447, 18);
            this.ValorDiariaLabel.Name = "ValorDiariaLabel";
            this.ValorDiariaLabel.Size = new System.Drawing.Size(82, 17);
            this.ValorDiariaLabel.TabIndex = 11;
            this.ValorDiariaLabel.Text = "Valor Diaria";
            this.ValorDiariaLabel.Click += new System.EventHandler(this.ValorDiariaLabel_Click);
            // 
            // ValorDiaria
            // 
            this.ValorDiaria.Location = new System.Drawing.Point(450, 38);
            this.ValorDiaria.Name = "ValorDiaria";
            this.ValorDiaria.Size = new System.Drawing.Size(338, 22);
            this.ValorDiaria.TabIndex = 10;
            this.ValorDiaria.TextChanged += new System.EventHandler(this.ValorDiaria_TextChanged);
            this.ValorDiaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CPF_KeyPress);
            // 
            // DescricaoLabel
            // 
            this.DescricaoLabel.AutoSize = true;
            this.DescricaoLabel.Location = new System.Drawing.Point(9, 18);
            this.DescricaoLabel.Name = "DescricaoLabel";
            this.DescricaoLabel.Size = new System.Drawing.Size(71, 17);
            this.DescricaoLabel.TabIndex = 9;
            this.DescricaoLabel.Text = "Descricao";
            this.DescricaoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Descricao
            // 
            this.Descricao.Location = new System.Drawing.Point(12, 38);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(412, 22);
            this.Descricao.TabIndex = 8;
            this.Descricao.TextChanged += new System.EventHandler(this.Nome_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 146);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ValorDiariaLabel);
            this.Controls.Add(this.ValorDiaria);
            this.Controls.Add(this.DescricaoLabel);
            this.Controls.Add(this.Descricao);
            this.Name = "Quarto";
            this.Text = "Quarto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ValorDiariaLabel;
        private System.Windows.Forms.TextBox ValorDiaria;
        private System.Windows.Forms.Label DescricaoLabel;
        private System.Windows.Forms.TextBox Descricao;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}