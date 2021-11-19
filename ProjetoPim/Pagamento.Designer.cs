
namespace ProjetoPim
{
    partial class Pagamento
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
            this.button1 = new System.Windows.Forms.Button();
            this.ValorDiariaLabel = new System.Windows.Forms.Label();
            this.ValorDiaria = new System.Windows.Forms.TextBox();
            this.DescricaoLabel = new System.Windows.Forms.Label();
            this.Descricao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ValorDiariaLabel
            // 
            this.ValorDiariaLabel.AutoSize = true;
            this.ValorDiariaLabel.Location = new System.Drawing.Point(447, 8);
            this.ValorDiariaLabel.Name = "ValorDiariaLabel";
            this.ValorDiariaLabel.Size = new System.Drawing.Size(116, 17);
            this.ValorDiariaLabel.TabIndex = 17;
            this.ValorDiariaLabel.Text = "Total Pagamento";
            // 
            // ValorDiaria
            // 
            this.ValorDiaria.Location = new System.Drawing.Point(450, 28);
            this.ValorDiaria.Name = "ValorDiaria";
            this.ValorDiaria.Size = new System.Drawing.Size(338, 22);
            this.ValorDiaria.TabIndex = 16;
            this.ValorDiaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorDiaria_KeyPress);
            // 
            // DescricaoLabel
            // 
            this.DescricaoLabel.AutoSize = true;
            this.DescricaoLabel.Location = new System.Drawing.Point(9, 8);
            this.DescricaoLabel.Name = "DescricaoLabel";
            this.DescricaoLabel.Size = new System.Drawing.Size(131, 17);
            this.DescricaoLabel.TabIndex = 15;
            this.DescricaoLabel.Text = "Tipo de pagamento";
            // 
            // Descricao
            // 
            this.Descricao.Location = new System.Drawing.Point(12, 28);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(412, 22);
            this.Descricao.TabIndex = 14;
            this.Descricao.TextChanged += new System.EventHandler(this.Descricao_TextChanged);
            this.Descricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Descricao_KeyPress);
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 133);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ValorDiariaLabel);
            this.Controls.Add(this.ValorDiaria);
            this.Controls.Add(this.DescricaoLabel);
            this.Controls.Add(this.Descricao);
            this.Name = "Pagamento";
            this.Text = "Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ValorDiariaLabel;
        private System.Windows.Forms.TextBox ValorDiaria;
        private System.Windows.Forms.Label DescricaoLabel;
        private System.Windows.Forms.TextBox Descricao;
    }
}