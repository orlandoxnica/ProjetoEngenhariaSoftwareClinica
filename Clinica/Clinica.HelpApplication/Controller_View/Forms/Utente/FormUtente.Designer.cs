
namespace Clinica.HelpApplication
{
    partial class FormUtente
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
            this.buttonHistoricoPrescricoes = new System.Windows.Forms.Button();
            this.buttonPlanoTratamento = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelMenuUtente = new System.Windows.Forms.Label();
            this.buttonAtribuirTerapeuta = new System.Windows.Forms.Button();
            this.buttonVoltarAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(140, 214);
            this.buttonFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(82, 22);
            this.buttonFechar.TabIndex = 0;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonHistoricoPrescricoes
            // 
            this.buttonHistoricoPrescricoes.Location = new System.Drawing.Point(106, 58);
            this.buttonHistoricoPrescricoes.Name = "buttonHistoricoPrescricoes";
            this.buttonHistoricoPrescricoes.Size = new System.Drawing.Size(154, 32);
            this.buttonHistoricoPrescricoes.TabIndex = 1;
            this.buttonHistoricoPrescricoes.Text = "Histórico Prescrições";
            this.buttonHistoricoPrescricoes.UseVisualStyleBackColor = true;
            this.buttonHistoricoPrescricoes.Click += new System.EventHandler(this.buttonHistoricoPrescricoes_Click);
            // 
            // buttonPlanoTratamento
            // 
            this.buttonPlanoTratamento.Location = new System.Drawing.Point(106, 134);
            this.buttonPlanoTratamento.Name = "buttonPlanoTratamento";
            this.buttonPlanoTratamento.Size = new System.Drawing.Size(156, 32);
            this.buttonPlanoTratamento.TabIndex = 2;
            this.buttonPlanoTratamento.Text = "Planos de Tratamento";
            this.buttonPlanoTratamento.UseVisualStyleBackColor = true;
            this.buttonPlanoTratamento.Click += new System.EventHandler(this.buttonPlanoTratamento_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(140, 180);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(82, 23);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelMenuUtente
            // 
            this.labelMenuUtente.AutoSize = true;
            this.labelMenuUtente.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMenuUtente.Location = new System.Drawing.Point(100, 9);
            this.labelMenuUtente.Name = "labelMenuUtente";
            this.labelMenuUtente.Size = new System.Drawing.Size(172, 37);
            this.labelMenuUtente.TabIndex = 4;
            this.labelMenuUtente.Text = "Menu Utente";
            // 
            // buttonAtribuirTerapeuta
            // 
            this.buttonAtribuirTerapeuta.Location = new System.Drawing.Point(106, 96);
            this.buttonAtribuirTerapeuta.Name = "buttonAtribuirTerapeuta";
            this.buttonAtribuirTerapeuta.Size = new System.Drawing.Size(154, 32);
            this.buttonAtribuirTerapeuta.TabIndex = 5;
            this.buttonAtribuirTerapeuta.Text = "Atribuir Terapeuta";
            this.buttonAtribuirTerapeuta.UseVisualStyleBackColor = true;
            this.buttonAtribuirTerapeuta.Click += new System.EventHandler(this.buttonAtribuirTerapeuta_Click);
            // 
            // buttonVoltarAtras
            // 
            this.buttonVoltarAtras.Location = new System.Drawing.Point(282, 12);
            this.buttonVoltarAtras.Name = "buttonVoltarAtras";
            this.buttonVoltarAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltarAtras.TabIndex = 6;
            this.buttonVoltarAtras.Text = "Voltar Atrás";
            this.buttonVoltarAtras.UseVisualStyleBackColor = true;
            this.buttonVoltarAtras.Click += new System.EventHandler(this.buttonVoltarAtras_Click);
            // 
            // FormUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 249);
            this.Controls.Add(this.buttonVoltarAtras);
            this.Controls.Add(this.buttonAtribuirTerapeuta);
            this.Controls.Add(this.labelMenuUtente);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonPlanoTratamento);
            this.Controls.Add(this.buttonHistoricoPrescricoes);
            this.Controls.Add(this.buttonFechar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUtente";
            this.Text = "FormUtente";
            this.Load += new System.EventHandler(this.FormUtente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonHistoricoPrescricoes;
        private System.Windows.Forms.Button buttonPlanoTratamento;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelMenuUtente;
        private System.Windows.Forms.Button buttonAtribuirTerapeuta;
        private System.Windows.Forms.Button buttonVoltarAtras;
    }
}