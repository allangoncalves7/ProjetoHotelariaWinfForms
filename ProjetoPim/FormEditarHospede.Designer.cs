
namespace ProjetoPim
{
    partial class FormEditarHospede
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
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.txtIdHospede = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(12, 170);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(412, 22);
            this.Data.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Data de nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Telefone";
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(450, 99);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(338, 22);
            this.Telefone.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(12, 99);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(412, 22);
            this.Email.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "CPF";
            // 
            // CPF
            // 
            this.CPF.Location = new System.Drawing.Point(450, 38);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(338, 22);
            this.CPF.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(12, 38);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(412, 22);
            this.Nome.TabIndex = 14;
            // 
            // txtIdHospede
            // 
            this.txtIdHospede.Location = new System.Drawing.Point(450, 172);
            this.txtIdHospede.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdHospede.Name = "txtIdHospede";
            this.txtIdHospede.Size = new System.Drawing.Size(41, 22);
            this.txtIdHospede.TabIndex = 25;
            this.txtIdHospede.Visible = false;
            // 
            // FormEditarHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 226);
            this.Controls.Add(this.txtIdHospede);
            this.Controls.Add(this.Data);
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
            this.Name = "FormEditarHospede";
            this.Text = "FormEditarHospede";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox txtIdHospede;
    }
}