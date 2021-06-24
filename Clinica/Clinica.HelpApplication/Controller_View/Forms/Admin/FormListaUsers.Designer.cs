
namespace Clinica.HelpApplication
{
    partial class FormListaUsers
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
            this.dataGridViewUtilizadores = new System.Windows.Forms.DataGridView();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.labelListaUtilizadores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilizadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUtilizadores
            // 
            this.dataGridViewUtilizadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUtilizadores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUtilizadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUtilizadores.Location = new System.Drawing.Point(12, 49);
            this.dataGridViewUtilizadores.Name = "dataGridViewUtilizadores";
            this.dataGridViewUtilizadores.RowTemplate.Height = 25;
            this.dataGridViewUtilizadores.Size = new System.Drawing.Size(850, 320);
            this.dataGridViewUtilizadores.TabIndex = 0;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(377, 380);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(93, 25);
            this.buttonVoltar.TabIndex = 1;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // labelListaUtilizadores
            // 
            this.labelListaUtilizadores.AutoSize = true;
            this.labelListaUtilizadores.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelListaUtilizadores.Location = new System.Drawing.Point(12, 9);
            this.labelListaUtilizadores.Name = "labelListaUtilizadores";
            this.labelListaUtilizadores.Size = new System.Drawing.Size(262, 37);
            this.labelListaUtilizadores.TabIndex = 2;
            this.labelListaUtilizadores.Text = "Lista de Utilizadores:";
            // 
            // FormListaUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 413);
            this.Controls.Add(this.labelListaUtilizadores);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.dataGridViewUtilizadores);
            this.Name = "FormListaUsers";
            this.Text = "FormListaUsers";
            this.Load += new System.EventHandler(this.FormListaUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilizadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUtilizadores;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label labelListaUtilizadores;
    }
}