
namespace Clinica.HelpApplication
{
    partial class FormHistoricoUtentes
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
            this.labelConsultarHistoricoPrescricoes = new System.Windows.Forms.Label();
            this.dataGridViewPrescricoes = new System.Windows.Forms.DataGridView();
            this.buttonVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescricoes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConsultarHistoricoPrescricoes
            // 
            this.labelConsultarHistoricoPrescricoes.AutoSize = true;
            this.labelConsultarHistoricoPrescricoes.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelConsultarHistoricoPrescricoes.Location = new System.Drawing.Point(12, 9);
            this.labelConsultarHistoricoPrescricoes.Name = "labelConsultarHistoricoPrescricoes";
            this.labelConsultarHistoricoPrescricoes.Size = new System.Drawing.Size(417, 37);
            this.labelConsultarHistoricoPrescricoes.TabIndex = 0;
            this.labelConsultarHistoricoPrescricoes.Text = "Consultar Histórico de Prescrições";
            // 
            // dataGridViewPrescricoes
            // 
            this.dataGridViewPrescricoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPrescricoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrescricoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPrescricoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrescricoes.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewPrescricoes.Name = "dataGridViewPrescricoes";
            this.dataGridViewPrescricoes.RowTemplate.Height = 25;
            this.dataGridViewPrescricoes.Size = new System.Drawing.Size(1166, 352);
            this.dataGridViewPrescricoes.TabIndex = 4;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(527, 415);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(88, 23);
            this.buttonVoltar.TabIndex = 5;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // FormHistoricoUtentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 450);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.dataGridViewPrescricoes);
            this.Controls.Add(this.labelConsultarHistoricoPrescricoes);
            this.Name = "FormHistoricoUtentes";
            this.Text = "FormHistoricoUtentes";
            this.Load += new System.EventHandler(this.FormHistoricoUtentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescricoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConsultarHistoricoPrescricoes;
        private System.Windows.Forms.DataGridView dataGridViewPrescricoes;
        private System.Windows.Forms.Button buttonVoltar;
    }
}