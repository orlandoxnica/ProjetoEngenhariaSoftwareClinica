
namespace Clinica.HelpApplication
{
    partial class FormAddPessoa
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelNIF = new System.Windows.Forms.Label();
            this.textBoxDataNascimento = new System.Windows.Forms.TextBox();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.textBoxContacto = new System.Windows.Forms.TextBox();
            this.labelContacto = new System.Windows.Forms.Label();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.labelSobrenome = new System.Windows.Forms.Label();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.labelMorada = new System.Windows.Forms.Label();
            this.labelCriarPessoa = new System.Windows.Forms.Label();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.labelFormatoData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(114, 68);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(212, 23);
            this.textBoxNome.TabIndex = 0;
            this.textBoxNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNome_KeyPress);
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.Location = new System.Drawing.Point(114, 156);
            this.textBoxNIF.MaxLength = 9;
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.Size = new System.Drawing.Size(212, 23);
            this.textBoxNIF.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(65, 71);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome:";
            // 
            // labelNIF
            // 
            this.labelNIF.AutoSize = true;
            this.labelNIF.Location = new System.Drawing.Point(80, 159);
            this.labelNIF.Name = "labelNIF";
            this.labelNIF.Size = new System.Drawing.Size(28, 15);
            this.labelNIF.TabIndex = 3;
            this.labelNIF.Text = "NIF:";
            // 
            // textBoxDataNascimento
            // 
            this.textBoxDataNascimento.Location = new System.Drawing.Point(114, 198);
            this.textBoxDataNascimento.Name = "textBoxDataNascimento";
            this.textBoxDataNascimento.Size = new System.Drawing.Size(212, 23);
            this.textBoxDataNascimento.TabIndex = 4;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(7, 201);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(101, 15);
            this.labelDataNascimento.TabIndex = 5;
            this.labelDataNascimento.Text = "Data Nascimento:";
            // 
            // textBoxContacto
            // 
            this.textBoxContacto.Location = new System.Drawing.Point(114, 241);
            this.textBoxContacto.MaxLength = 9;
            this.textBoxContacto.Name = "textBoxContacto";
            this.textBoxContacto.Size = new System.Drawing.Size(212, 23);
            this.textBoxContacto.TabIndex = 6;
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.Location = new System.Drawing.Point(49, 244);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(59, 15);
            this.labelContacto.TabIndex = 7;
            this.labelContacto.Text = "Contacto:";
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(114, 112);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(212, 23);
            this.textBoxSobrenome.TabIndex = 8;
            this.textBoxSobrenome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSobrenome_KeyPress);
            // 
            // labelSobrenome
            // 
            this.labelSobrenome.AutoSize = true;
            this.labelSobrenome.Location = new System.Drawing.Point(37, 115);
            this.labelSobrenome.Name = "labelSobrenome";
            this.labelSobrenome.Size = new System.Drawing.Size(71, 15);
            this.labelSobrenome.TabIndex = 9;
            this.labelSobrenome.Text = "Sobrenome:";
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(114, 283);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(212, 23);
            this.textBoxMorada.TabIndex = 10;
            // 
            // labelMorada
            // 
            this.labelMorada.AutoSize = true;
            this.labelMorada.Location = new System.Drawing.Point(57, 286);
            this.labelMorada.Name = "labelMorada";
            this.labelMorada.Size = new System.Drawing.Size(51, 15);
            this.labelMorada.TabIndex = 11;
            this.labelMorada.Text = "Morada:";
            // 
            // labelCriarPessoa
            // 
            this.labelCriarPessoa.AutoSize = true;
            this.labelCriarPessoa.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCriarPessoa.Location = new System.Drawing.Point(12, 9);
            this.labelCriarPessoa.Name = "labelCriarPessoa";
            this.labelCriarPessoa.Size = new System.Drawing.Size(160, 37);
            this.labelCriarPessoa.TabIndex = 12;
            this.labelCriarPessoa.Text = "Criar Pessoa";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(114, 330);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 13;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(251, 330);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 14;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // labelFormatoData
            // 
            this.labelFormatoData.AutoSize = true;
            this.labelFormatoData.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFormatoData.Location = new System.Drawing.Point(23, 216);
            this.labelFormatoData.Name = "labelFormatoData";
            this.labelFormatoData.Size = new System.Drawing.Size(69, 12);
            this.labelFormatoData.TabIndex = 15;
            this.labelFormatoData.Text = "AAAA-MM-DD";
            // 
            // FormAddPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 368);
            this.Controls.Add(this.labelFormatoData);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.labelCriarPessoa);
            this.Controls.Add(this.labelMorada);
            this.Controls.Add(this.textBoxMorada);
            this.Controls.Add(this.labelSobrenome);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.labelContacto);
            this.Controls.Add(this.textBoxContacto);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.textBoxDataNascimento);
            this.Controls.Add(this.labelNIF);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNIF);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormAddPessoa";
            this.Text = "FormAddPessoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxNIF;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNIF;
        private System.Windows.Forms.TextBox textBoxDataNascimento;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.TextBox textBoxContacto;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Label labelSobrenome;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.Label labelMorada;
        private System.Windows.Forms.Label labelCriarPessoa;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label labelFormatoData;
    }
}