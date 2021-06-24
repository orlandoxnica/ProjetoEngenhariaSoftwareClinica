
namespace Clinica.HelpApplication
{
    partial class FormTratamentosRealizados
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
            this.labelListaTratamentos = new System.Windows.Forms.Label();
            this.dataGridViewTratamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTratamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(343, 347);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(115, 34);
            this.buttonVoltar.TabIndex = 0;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // labelListaTratamentos
            // 
            this.labelListaTratamentos.AutoSize = true;
            this.labelListaTratamentos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelListaTratamentos.Location = new System.Drawing.Point(12, 9);
            this.labelListaTratamentos.Name = "labelListaTratamentos";
            this.labelListaTratamentos.Size = new System.Drawing.Size(394, 37);
            this.labelListaTratamentos.TabIndex = 1;
            this.labelListaTratamentos.Text = "Lista de Tratamentos realizados:";
            // 
            // dataGridViewTratamentos
            // 
            this.dataGridViewTratamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTratamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTratamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTratamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTratamentos.Location = new System.Drawing.Point(12, 49);
            this.dataGridViewTratamentos.Name = "dataGridViewTratamentos";
            this.dataGridViewTratamentos.RowTemplate.Height = 25;
            this.dataGridViewTratamentos.Size = new System.Drawing.Size(776, 292);
            this.dataGridViewTratamentos.TabIndex = 2;
            // 
            // FormTratamentosRealizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.dataGridViewTratamentos);
            this.Controls.Add(this.labelListaTratamentos);
            this.Controls.Add(this.buttonVoltar);
            this.Name = "FormTratamentosRealizados";
            this.Text = "FormTratamentosRealizados";
            this.Load += new System.EventHandler(this.FormTratamentosRealizados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTratamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListaTratamentos;
        private System.Windows.Forms.DataGridView dataGridViewTratamentos;
        private System.Windows.Forms.Button buttonVoltar;
    }
}