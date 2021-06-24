
namespace Clinica.HelpApplication
{
    partial class FormAtualizaFuncoesUser
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
            this.labelAtualizaFuncoesUtilizador = new System.Windows.Forms.Label();
            this.comboBoxUtilizador = new System.Windows.Forms.ComboBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.labelUtilizador = new System.Windows.Forms.Label();
            this.labelFuncoes = new System.Windows.Forms.Label();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.checkBoxUtente = new System.Windows.Forms.CheckBox();
            this.checkBoxTerapeuta = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelAtualizaFuncoesUtilizador
            // 
            this.labelAtualizaFuncoesUtilizador.AutoSize = true;
            this.labelAtualizaFuncoesUtilizador.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAtualizaFuncoesUtilizador.Location = new System.Drawing.Point(12, 9);
            this.labelAtualizaFuncoesUtilizador.Name = "labelAtualizaFuncoesUtilizador";
            this.labelAtualizaFuncoesUtilizador.Size = new System.Drawing.Size(386, 37);
            this.labelAtualizaFuncoesUtilizador.TabIndex = 0;
            this.labelAtualizaFuncoesUtilizador.Text = "Atualizar Funções do Utilizador";
            // 
            // comboBoxUtilizador
            // 
            this.comboBoxUtilizador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUtilizador.FormattingEnabled = true;
            this.comboBoxUtilizador.Location = new System.Drawing.Point(81, 68);
            this.comboBoxUtilizador.Name = "comboBoxUtilizador";
            this.comboBoxUtilizador.Size = new System.Drawing.Size(181, 23);
            this.comboBoxUtilizador.TabIndex = 1;
            this.comboBoxUtilizador.SelectedIndexChanged += new System.EventHandler(this.comboBoxUtilizador_SelectedIndexChanged);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(81, 161);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 2;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // labelUtilizador
            // 
            this.labelUtilizador.AutoSize = true;
            this.labelUtilizador.Location = new System.Drawing.Point(15, 71);
            this.labelUtilizador.Name = "labelUtilizador";
            this.labelUtilizador.Size = new System.Drawing.Size(60, 15);
            this.labelUtilizador.TabIndex = 3;
            this.labelUtilizador.Text = "Utilizador:";
            // 
            // labelFuncoes
            // 
            this.labelFuncoes.AutoSize = true;
            this.labelFuncoes.Location = new System.Drawing.Point(21, 113);
            this.labelFuncoes.Name = "labelFuncoes";
            this.labelFuncoes.Size = new System.Drawing.Size(54, 15);
            this.labelFuncoes.TabIndex = 4;
            this.labelFuncoes.Text = "Funções:";
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(187, 161);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 6;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Location = new System.Drawing.Point(81, 113);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(62, 19);
            this.checkBoxAdmin.TabIndex = 7;
            this.checkBoxAdmin.Text = "Admin";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // checkBoxUtente
            // 
            this.checkBoxUtente.AutoSize = true;
            this.checkBoxUtente.Location = new System.Drawing.Point(149, 113);
            this.checkBoxUtente.Name = "checkBoxUtente";
            this.checkBoxUtente.Size = new System.Drawing.Size(61, 19);
            this.checkBoxUtente.TabIndex = 8;
            this.checkBoxUtente.Text = "Utente";
            this.checkBoxUtente.UseVisualStyleBackColor = true;
            // 
            // checkBoxTerapeuta
            // 
            this.checkBoxTerapeuta.AutoSize = true;
            this.checkBoxTerapeuta.Location = new System.Drawing.Point(216, 113);
            this.checkBoxTerapeuta.Name = "checkBoxTerapeuta";
            this.checkBoxTerapeuta.Size = new System.Drawing.Size(77, 19);
            this.checkBoxTerapeuta.TabIndex = 9;
            this.checkBoxTerapeuta.Text = "Terapeuta";
            this.checkBoxTerapeuta.UseVisualStyleBackColor = true;
            // 
            // FormAtualizaFuncoesUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 205);
            this.Controls.Add(this.checkBoxTerapeuta);
            this.Controls.Add(this.checkBoxUtente);
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.labelFuncoes);
            this.Controls.Add(this.labelUtilizador);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.comboBoxUtilizador);
            this.Controls.Add(this.labelAtualizaFuncoesUtilizador);
            this.Name = "FormAtualizaFuncoesUser";
            this.Text = "FormAdicionarUser";
            this.Load += new System.EventHandler(this.FormAtualizaFuncoesUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAtualizaFuncoesUtilizador;
        private System.Windows.Forms.ComboBox comboBoxUtilizador;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label labelUtilizador;
        private System.Windows.Forms.Label labelFuncoes;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.CheckBox checkBoxUtente;
        private System.Windows.Forms.CheckBox checkBoxTerapeuta;
    }
}