
namespace Clinica.HelpApplication
{
    partial class FormHistoricoPrescricoes
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
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.labelConsultarHistoricoPrescricoes = new System.Windows.Forms.Label();
            this.labelNIF = new System.Windows.Forms.Label();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.dataGridViewPrescricoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescricoes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(378, 56);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(113, 25);
            this.buttonVoltar.TabIndex = 0;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.Location = new System.Drawing.Point(130, 57);
            this.textBoxNIF.MaxLength = 9;
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.Size = new System.Drawing.Size(160, 23);
            this.textBoxNIF.TabIndex = 1;
            this.textBoxNIF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNIF_KeyPress);
            // 
            // labelConsultarHistoricoPrescricoes
            // 
            this.labelConsultarHistoricoPrescricoes.AutoSize = true;
            this.labelConsultarHistoricoPrescricoes.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelConsultarHistoricoPrescricoes.Location = new System.Drawing.Point(12, 9);
            this.labelConsultarHistoricoPrescricoes.Name = "labelConsultarHistoricoPrescricoes";
            this.labelConsultarHistoricoPrescricoes.Size = new System.Drawing.Size(542, 37);
            this.labelConsultarHistoricoPrescricoes.TabIndex = 2;
            this.labelConsultarHistoricoPrescricoes.Text = "Consultar Histórico de Prescrições realizadas";
            // 
            // labelNIF
            // 
            this.labelNIF.AutoSize = true;
            this.labelNIF.Location = new System.Drawing.Point(12, 60);
            this.labelNIF.Name = "labelNIF";
            this.labelNIF.Size = new System.Drawing.Size(112, 15);
            this.labelNIF.TabIndex = 3;
            this.labelNIF.Text = "Introduza o seu NIF:";
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(296, 56);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(76, 24);
            this.buttonPesquisar.TabIndex = 4;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // dataGridViewPrescricoes
            // 
            this.dataGridViewPrescricoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPrescricoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrescricoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPrescricoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrescricoes.Location = new System.Drawing.Point(12, 86);
            this.dataGridViewPrescricoes.Name = "dataGridViewPrescricoes";
            this.dataGridViewPrescricoes.RowTemplate.Height = 25;
            this.dataGridViewPrescricoes.Size = new System.Drawing.Size(1259, 352);
            this.dataGridViewPrescricoes.TabIndex = 5;
            // 
            // FormHistoricoPrescricoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 450);
            this.Controls.Add(this.dataGridViewPrescricoes);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.labelNIF);
            this.Controls.Add(this.labelConsultarHistoricoPrescricoes);
            this.Controls.Add(this.textBoxNIF);
            this.Controls.Add(this.buttonVoltar);
            this.Name = "FormHistoricoPrescricoes";
            this.Text = "FormHistoricoPrescricoes";
            this.Load += new System.EventHandler(this.FormHistoricoPrescricoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescricoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.TextBox textBoxNIF;
        private System.Windows.Forms.Label labelConsultarHistoricoPrescricoes;
        private System.Windows.Forms.Label labelNIF;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewPrescricoes;
    }
}