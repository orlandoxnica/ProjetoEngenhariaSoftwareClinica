
namespace Clinica.HelpApplication
{
    partial class FormTerapeuta
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
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonCriaPrescricao = new System.Windows.Forms.Button();
            this.buttonIniciarSessaoTratamento = new System.Windows.Forms.Button();
            this.buttonHistoricoPrescricoes = new System.Windows.Forms.Button();
            this.labelMenuTerapeuta = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonIntroduzir = new System.Windows.Forms.Button();
            this.buttonCriarPlanoTratamento = new System.Windows.Forms.Button();
            this.buttonVoltarAtras = new System.Windows.Forms.Button();
            this.buttonSessoesRealizadas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(102, 189);
            this.buttonFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 31);
            this.buttonFechar.TabIndex = 0;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonCriaPrescricao
            // 
            this.buttonCriaPrescricao.Location = new System.Drawing.Point(22, 67);
            this.buttonCriaPrescricao.Name = "buttonCriaPrescricao";
            this.buttonCriaPrescricao.Size = new System.Drawing.Size(170, 23);
            this.buttonCriaPrescricao.TabIndex = 1;
            this.buttonCriaPrescricao.Text = "Cria Prescrição";
            this.buttonCriaPrescricao.UseVisualStyleBackColor = true;
            this.buttonCriaPrescricao.Click += new System.EventHandler(this.buttonCriaPrescricao_Click);
            // 
            // buttonIniciarSessaoTratamento
            // 
            this.buttonIniciarSessaoTratamento.Location = new System.Drawing.Point(22, 150);
            this.buttonIniciarSessaoTratamento.Name = "buttonIniciarSessaoTratamento";
            this.buttonIniciarSessaoTratamento.Size = new System.Drawing.Size(170, 23);
            this.buttonIniciarSessaoTratamento.TabIndex = 2;
            this.buttonIniciarSessaoTratamento.Text = "Iniciar Sessão de Tratamento";
            this.buttonIniciarSessaoTratamento.UseVisualStyleBackColor = true;
            this.buttonIniciarSessaoTratamento.Click += new System.EventHandler(this.buttonIniciarSessaoTratamento_Click);
            // 
            // buttonHistoricoPrescricoes
            // 
            this.buttonHistoricoPrescricoes.Location = new System.Drawing.Point(198, 67);
            this.buttonHistoricoPrescricoes.Name = "buttonHistoricoPrescricoes";
            this.buttonHistoricoPrescricoes.Size = new System.Drawing.Size(170, 23);
            this.buttonHistoricoPrescricoes.TabIndex = 3;
            this.buttonHistoricoPrescricoes.Text = "Histórico de Prescrições";
            this.buttonHistoricoPrescricoes.UseVisualStyleBackColor = true;
            this.buttonHistoricoPrescricoes.Click += new System.EventHandler(this.buttonHistoricoPrescricoes_Click);
            // 
            // labelMenuTerapeuta
            // 
            this.labelMenuTerapeuta.AutoSize = true;
            this.labelMenuTerapeuta.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMenuTerapeuta.Location = new System.Drawing.Point(12, 9);
            this.labelMenuTerapeuta.Name = "labelMenuTerapeuta";
            this.labelMenuTerapeuta.Size = new System.Drawing.Size(208, 37);
            this.labelMenuTerapeuta.TabIndex = 4;
            this.labelMenuTerapeuta.Text = "Menu Terapeuta";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(207, 189);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 31);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonIntroduzir
            // 
            this.buttonIntroduzir.Location = new System.Drawing.Point(198, 109);
            this.buttonIntroduzir.Name = "buttonIntroduzir";
            this.buttonIntroduzir.Size = new System.Drawing.Size(170, 23);
            this.buttonIntroduzir.TabIndex = 6;
            this.buttonIntroduzir.Text = "Introduzir Novo";
            this.buttonIntroduzir.UseVisualStyleBackColor = true;
            this.buttonIntroduzir.Click += new System.EventHandler(this.buttonIntroduzir_Click);
            // 
            // buttonCriarPlanoTratamento
            // 
            this.buttonCriarPlanoTratamento.Location = new System.Drawing.Point(22, 109);
            this.buttonCriarPlanoTratamento.Name = "buttonCriarPlanoTratamento";
            this.buttonCriarPlanoTratamento.Size = new System.Drawing.Size(170, 23);
            this.buttonCriarPlanoTratamento.TabIndex = 7;
            this.buttonCriarPlanoTratamento.Text = "Criar Plano Tratamento";
            this.buttonCriarPlanoTratamento.UseVisualStyleBackColor = true;
            this.buttonCriarPlanoTratamento.Click += new System.EventHandler(this.buttonCriarPlanoTratamento_Click);
            // 
            // buttonVoltarAtras
            // 
            this.buttonVoltarAtras.Location = new System.Drawing.Point(302, 12);
            this.buttonVoltarAtras.Name = "buttonVoltarAtras";
            this.buttonVoltarAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltarAtras.TabIndex = 8;
            this.buttonVoltarAtras.Text = "Voltar atrás";
            this.buttonVoltarAtras.UseVisualStyleBackColor = true;
            this.buttonVoltarAtras.Click += new System.EventHandler(this.buttonVoltarAtras_Click);
            // 
            // buttonSessoesRealizadas
            // 
            this.buttonSessoesRealizadas.Location = new System.Drawing.Point(198, 150);
            this.buttonSessoesRealizadas.Name = "buttonSessoesRealizadas";
            this.buttonSessoesRealizadas.Size = new System.Drawing.Size(170, 23);
            this.buttonSessoesRealizadas.TabIndex = 8;
            this.buttonSessoesRealizadas.Text = "Sessões Realizadas";
            this.buttonSessoesRealizadas.UseVisualStyleBackColor = true;
            this.buttonSessoesRealizadas.Click += new System.EventHandler(this.buttonSessoesRealizadas_Click);
            // 
            // FormTerapeuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 228);
            this.Controls.Add(this.buttonSessoesRealizadas);
            this.Controls.Add(this.buttonVoltarAtras);
            this.Controls.Add(this.buttonCriarPlanoTratamento);
            this.Controls.Add(this.buttonIntroduzir);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelMenuTerapeuta);
            this.Controls.Add(this.buttonHistoricoPrescricoes);
            this.Controls.Add(this.buttonIniciarSessaoTratamento);
            this.Controls.Add(this.buttonCriaPrescricao);
            this.Controls.Add(this.buttonFechar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTerapeuta";
            this.Text = "FormTerapeuta";
            this.Load += new System.EventHandler(this.FormTerapeuta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonCriaPrescricao;
        private System.Windows.Forms.Button buttonIniciarSessaoTratamento;
        private System.Windows.Forms.Button buttonHistoricoPrescricoes;
        private System.Windows.Forms.Label labelMenuTerapeuta;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonIntroduzir;
        private System.Windows.Forms.Button buttonCriarPlanoTratamento;
        private System.Windows.Forms.Button buttonVoltarAtras;
        private System.Windows.Forms.Button buttonSessoesRealizadas;
    }
}