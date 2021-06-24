
namespace Clinica.HelpApplication
{
    partial class FormPlanoTratamentoUtente
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
            this.labelPlanoTratamento = new System.Windows.Forms.Label();
            this.dataGridViewTratamento = new System.Windows.Forms.DataGridView();
            this.buttonVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTratamento)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlanoTratamento
            // 
            this.labelPlanoTratamento.AutoSize = true;
            this.labelPlanoTratamento.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlanoTratamento.Location = new System.Drawing.Point(12, 9);
            this.labelPlanoTratamento.Name = "labelPlanoTratamento";
            this.labelPlanoTratamento.Size = new System.Drawing.Size(269, 37);
            this.labelPlanoTratamento.TabIndex = 0;
            this.labelPlanoTratamento.Text = "Plano de Tratamento:";
            // 
            // dataGridViewTratamento
            // 
            this.dataGridViewTratamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTratamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTratamento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTratamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTratamento.Location = new System.Drawing.Point(12, 49);
            this.dataGridViewTratamento.Name = "dataGridViewTratamento";
            this.dataGridViewTratamento.RowTemplate.Height = 25;
            this.dataGridViewTratamento.Size = new System.Drawing.Size(1216, 370);
            this.dataGridViewTratamento.TabIndex = 1;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(552, 424);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 2;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // FormPlanoTratamentoUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 450);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.dataGridViewTratamento);
            this.Controls.Add(this.labelPlanoTratamento);
            this.Name = "FormPlanoTratamentoUtente";
            this.Text = "FormPlanoTratamentoUtente";
            this.Load += new System.EventHandler(this.FormPlanoTratamentoUtente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTratamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlanoTratamento;
        private System.Windows.Forms.DataGridView dataGridViewTratamento;
        private System.Windows.Forms.Button buttonVoltar;
    }
}