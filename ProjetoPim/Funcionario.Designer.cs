namespace ProjetoPim
{
    partial class Funcionario
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
            this.label4 = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Cargo = new System.Windows.Forms.Label();
            this.CargoFuncionario = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.PasswordFuncionario = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Telefone";
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(450, 103);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(338, 22);
            this.Telefone.TabIndex = 14;
            this.Telefone.TextChanged += new System.EventHandler(this.Telefone_TextChanged);
            this.Telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Telefone_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(12, 103);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(412, 22);
            this.Email.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "CPF";
            // 
            // CPF
            // 
            this.CPF.Location = new System.Drawing.Point(450, 42);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(338, 22);
            this.CPF.TabIndex = 10;
            this.CPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CPF_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(12, 42);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(412, 22);
            this.Nome.TabIndex = 8;
            this.Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nome_KeyPress);
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(12, 173);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(412, 22);
            this.Data.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Data de nascimento";
            // 
            // Cargo
            // 
            this.Cargo.AutoSize = true;
            this.Cargo.Location = new System.Drawing.Point(447, 155);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(46, 17);
            this.Cargo.TabIndex = 19;
            this.Cargo.Text = "Cargo";
            // 
            // CargoFuncionario
            // 
            this.CargoFuncionario.Location = new System.Drawing.Point(450, 175);
            this.CargoFuncionario.Name = "CargoFuncionario";
            this.CargoFuncionario.Size = new System.Drawing.Size(338, 22);
            this.CargoFuncionario.TabIndex = 18;
            this.CargoFuncionario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.CargoFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(9, 211);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 17);
            this.Password.TabIndex = 21;
            this.Password.Text = "Password";
            // 
            // PasswordFuncionario
            // 
            this.PasswordFuncionario.Location = new System.Drawing.Point(12, 231);
            this.PasswordFuncionario.Name = "PasswordFuncionario";
            this.PasswordFuncionario.PasswordChar = '*';
            this.PasswordFuncionario.Size = new System.Drawing.Size(412, 22);
            this.PasswordFuncionario.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 285);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PasswordFuncionario);
            this.Controls.Add(this.Cargo);
            this.Controls.Add(this.CargoFuncionario);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nome);
            this.Name = "Funcionario";
            this.Text = "Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Cargo;
        private System.Windows.Forms.TextBox CargoFuncionario;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox PasswordFuncionario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}