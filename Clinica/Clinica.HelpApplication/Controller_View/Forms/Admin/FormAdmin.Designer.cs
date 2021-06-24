
namespace Clinica.HelpApplication
{
    partial class FormAdmin
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
            this.buttonCriarPessoa = new System.Windows.Forms.Button();
            this.buttonCriarUser = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.buttonListaPessoas = new System.Windows.Forms.Button();
            this.buttonListaUsers = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonAtualizaFuncoes = new System.Windows.Forms.Button();
            this.buttonVoltarAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCriarPessoa
            // 
            this.buttonCriarPessoa.Location = new System.Drawing.Point(12, 67);
            this.buttonCriarPessoa.Name = "buttonCriarPessoa";
            this.buttonCriarPessoa.Size = new System.Drawing.Size(169, 37);
            this.buttonCriarPessoa.TabIndex = 0;
            this.buttonCriarPessoa.Text = "Criar Pessoa";
            this.buttonCriarPessoa.UseVisualStyleBackColor = true;
            this.buttonCriarPessoa.Click += new System.EventHandler(this.buttonCriarPessoa_Click);
            // 
            // buttonCriarUser
            // 
            this.buttonCriarUser.Location = new System.Drawing.Point(12, 128);
            this.buttonCriarUser.Name = "buttonCriarUser";
            this.buttonCriarUser.Size = new System.Drawing.Size(169, 37);
            this.buttonCriarUser.TabIndex = 1;
            this.buttonCriarUser.Text = "Criar utilizador";
            this.buttonCriarUser.UseVisualStyleBackColor = true;
            this.buttonCriarUser.Click += new System.EventHandler(this.buttonCriarUser_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(300, 195);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(88, 31);
            this.buttonFechar.TabIndex = 2;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdmin.Location = new System.Drawing.Point(12, 9);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(186, 37);
            this.labelAdmin.TabIndex = 3;
            this.labelAdmin.Text = "Administrador";
            // 
            // buttonListaPessoas
            // 
            this.buttonListaPessoas.Location = new System.Drawing.Point(216, 67);
            this.buttonListaPessoas.Name = "buttonListaPessoas";
            this.buttonListaPessoas.Size = new System.Drawing.Size(169, 37);
            this.buttonListaPessoas.TabIndex = 4;
            this.buttonListaPessoas.Text = "Listar Pessoas";
            this.buttonListaPessoas.UseVisualStyleBackColor = true;
            this.buttonListaPessoas.Click += new System.EventHandler(this.buttonListaPessoas_Click);
            // 
            // buttonListaUsers
            // 
            this.buttonListaUsers.Location = new System.Drawing.Point(216, 128);
            this.buttonListaUsers.Name = "buttonListaUsers";
            this.buttonListaUsers.Size = new System.Drawing.Size(169, 37);
            this.buttonListaUsers.TabIndex = 5;
            this.buttonListaUsers.Text = "Listar Utilizadores";
            this.buttonListaUsers.UseVisualStyleBackColor = true;
            this.buttonListaUsers.Click += new System.EventHandler(this.buttonListaUsers_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(204, 195);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(90, 31);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonAtualizaFuncoes
            // 
            this.buttonAtualizaFuncoes.Location = new System.Drawing.Point(12, 187);
            this.buttonAtualizaFuncoes.Name = "buttonAtualizaFuncoes";
            this.buttonAtualizaFuncoes.Size = new System.Drawing.Size(169, 39);
            this.buttonAtualizaFuncoes.TabIndex = 7;
            this.buttonAtualizaFuncoes.Text = "Atualizar Funções do Utilizador";
            this.buttonAtualizaFuncoes.UseVisualStyleBackColor = true;
            this.buttonAtualizaFuncoes.Click += new System.EventHandler(this.buttonAtualizaFuncoes_Click);
            // 
            // buttonVoltarAtras
            // 
            this.buttonVoltarAtras.Location = new System.Drawing.Point(313, 12);
            this.buttonVoltarAtras.Name = "buttonVoltarAtras";
            this.buttonVoltarAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltarAtras.TabIndex = 8;
            this.buttonVoltarAtras.Text = "Voltar atrás";
            this.buttonVoltarAtras.UseVisualStyleBackColor = true;
            this.buttonVoltarAtras.Click += new System.EventHandler(this.buttonVoltarAtras_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 243);
            this.Controls.Add(this.buttonVoltarAtras);
            this.Controls.Add(this.buttonAtualizaFuncoes);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonListaUsers);
            this.Controls.Add(this.buttonListaPessoas);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonCriarUser);
            this.Controls.Add(this.buttonCriarPessoa);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCriarPessoa;
        private System.Windows.Forms.Button buttonCriarUser;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Button buttonListaPessoas;
        private System.Windows.Forms.Button buttonListaUsers;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonAtualizaFuncoes;
        private System.Windows.Forms.Button buttonVoltarAtras;
    }
}