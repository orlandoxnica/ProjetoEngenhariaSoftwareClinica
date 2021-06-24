using MySql.Data.MySqlClient;
namespace Clinica.HelpApplication
{
    partial class FormAddUser
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelCriarUtilizador = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelFuncao = new System.Windows.Forms.Label();
            this.labelIDPessoa = new System.Windows.Forms.Label();
            this.buttonCriar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.comboBoxIDPessoa = new System.Windows.Forms.ComboBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.checkBoxUtente = new System.Windows.Forms.CheckBox();
            this.checkBoxTerapeuta = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(78, 65);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(211, 23);
            this.textBoxPassword.TabIndex = 0;
            // 
            // labelCriarUtilizador
            // 
            this.labelCriarUtilizador.AutoSize = true;
            this.labelCriarUtilizador.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCriarUtilizador.Location = new System.Drawing.Point(12, 9);
            this.labelCriarUtilizador.Name = "labelCriarUtilizador";
            this.labelCriarUtilizador.Size = new System.Drawing.Size(196, 37);
            this.labelCriarUtilizador.TabIndex = 1;
            this.labelCriarUtilizador.Text = "Criar Utilizador";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 68);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(60, 15);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password:";
            // 
            // labelFuncao
            // 
            this.labelFuncao.AutoSize = true;
            this.labelFuncao.Location = new System.Drawing.Point(23, 112);
            this.labelFuncao.Name = "labelFuncao";
            this.labelFuncao.Size = new System.Drawing.Size(49, 15);
            this.labelFuncao.TabIndex = 8;
            this.labelFuncao.Text = "Função:";
            // 
            // labelIDPessoa
            // 
            this.labelIDPessoa.AutoSize = true;
            this.labelIDPessoa.Location = new System.Drawing.Point(12, 155);
            this.labelIDPessoa.Name = "labelIDPessoa";
            this.labelIDPessoa.Size = new System.Drawing.Size(60, 15);
            this.labelIDPessoa.TabIndex = 9;
            this.labelIDPessoa.Text = "ID Pessoa:";
            // 
            // buttonCriar
            // 
            this.buttonCriar.Location = new System.Drawing.Point(78, 200);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(75, 23);
            this.buttonCriar.TabIndex = 11;
            this.buttonCriar.Text = "Criar";
            this.buttonCriar.UseVisualStyleBackColor = true;
            this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(214, 200);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 12;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // comboBoxIDPessoa
            // 
            this.comboBoxIDPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIDPessoa.FormattingEnabled = true;
            this.comboBoxIDPessoa.Location = new System.Drawing.Point(78, 152);
            this.comboBoxIDPessoa.Name = "comboBoxIDPessoa";
            this.comboBoxIDPessoa.Size = new System.Drawing.Size(211, 23);
            this.comboBoxIDPessoa.TabIndex = 13;
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Location = new System.Drawing.Point(78, 112);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(62, 19);
            this.checkBoxAdmin.TabIndex = 14;
            this.checkBoxAdmin.Text = "Admin";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // checkBoxUtente
            // 
            this.checkBoxUtente.AutoSize = true;
            this.checkBoxUtente.Location = new System.Drawing.Point(146, 112);
            this.checkBoxUtente.Name = "checkBoxUtente";
            this.checkBoxUtente.Size = new System.Drawing.Size(61, 19);
            this.checkBoxUtente.TabIndex = 15;
            this.checkBoxUtente.Text = "Utente";
            this.checkBoxUtente.UseVisualStyleBackColor = true;
            // 
            // checkBoxTerapeuta
            // 
            this.checkBoxTerapeuta.AutoSize = true;
            this.checkBoxTerapeuta.Location = new System.Drawing.Point(213, 112);
            this.checkBoxTerapeuta.Name = "checkBoxTerapeuta";
            this.checkBoxTerapeuta.Size = new System.Drawing.Size(77, 19);
            this.checkBoxTerapeuta.TabIndex = 16;
            this.checkBoxTerapeuta.Text = "Terapeuta";
            this.checkBoxTerapeuta.UseVisualStyleBackColor = true;
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 241);
            this.Controls.Add(this.checkBoxTerapeuta);
            this.Controls.Add(this.checkBoxUtente);
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.comboBoxIDPessoa);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonCriar);
            this.Controls.Add(this.labelIDPessoa);
            this.Controls.Add(this.labelFuncao);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelCriarUtilizador);
            this.Controls.Add(this.textBoxPassword);
            this.Name = "FormAddUser";
            this.Text = "FormAddUser";
            this.Load += new System.EventHandler(this.FormAddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelCriarUtilizador;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelFuncao;
        private System.Windows.Forms.Label labelIDPessoa;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.ComboBox comboBoxIDPessoa;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.CheckBox checkBoxUtente;
        private System.Windows.Forms.CheckBox checkBoxTerapeuta;
    }
}