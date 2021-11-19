namespace ProjetoPim
{
    partial class FormHospede
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(12, 39);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(412, 22);
            this.Nome.TabIndex = 0;
            this.Nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nome_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CPF
            // 
            this.CPF.Location = new System.Drawing.Point(450, 39);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(338, 22);
            this.CPF.TabIndex = 2;
            this.CPF.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.CPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CPF_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(12, 100);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(412, 22);
            this.Email.TabIndex = 4;
            this.Email.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone";
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(450, 100);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(338, 22);
            this.Telefone.TabIndex = 6;
            this.Telefone.TextChanged += new System.EventHandler(this.Telefone_TextChanged);
            this.Telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Telefone_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data de nascimento";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(12, 171);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(412, 22);
            this.Data.TabIndex = 13;
            this.Data.ValueChanged += new System.EventHandler(this.Data_ValueChanged);
            // 
            // Hospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 226);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nome);
            this.Name = "Hospede";
            this.Text = "Hospede";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Telefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker Data;
    }
}

