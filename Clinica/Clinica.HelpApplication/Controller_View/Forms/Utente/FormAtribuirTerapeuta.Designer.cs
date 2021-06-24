
namespace Clinica.HelpApplication
{
    partial class FormAtribuirTerapeuta
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
            this.labelPrescricao = new System.Windows.Forms.Label();
            this.comboBoxPrescricao = new System.Windows.Forms.ComboBox();
            this.labelDetalhes = new System.Windows.Forms.Label();
            this.textBoxUtente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTerapeutaAutor = new System.Windows.Forms.Label();
            this.textBoxTerapeutaAutor = new System.Windows.Forms.TextBox();
            this.labelMedicamento = new System.Windows.Forms.Label();
            this.textBoxMedicamento = new System.Windows.Forms.TextBox();
            this.textBoxTratamento = new System.Windows.Forms.TextBox();
            this.labelTratamento = new System.Windows.Forms.Label();
            this.labelExercicios = new System.Windows.Forms.Label();
            this.textBoxExercicios = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTerapeuta = new System.Windows.Forms.Label();
            this.comboBoxTerapeuta = new System.Windows.Forms.ComboBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPrescricao
            // 
            this.labelPrescricao.AutoSize = true;
            this.labelPrescricao.Location = new System.Drawing.Point(30, 29);
            this.labelPrescricao.Name = "labelPrescricao";
            this.labelPrescricao.Size = new System.Drawing.Size(64, 15);
            this.labelPrescricao.TabIndex = 0;
            this.labelPrescricao.Text = "Prescrição:";
            // 
            // comboBoxPrescricao
            // 
            this.comboBoxPrescricao.FormattingEnabled = true;
            this.comboBoxPrescricao.Location = new System.Drawing.Point(97, 26);
            this.comboBoxPrescricao.Name = "comboBoxPrescricao";
            this.comboBoxPrescricao.Size = new System.Drawing.Size(166, 23);
            this.comboBoxPrescricao.TabIndex = 1;
            this.comboBoxPrescricao.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrescricao_SelectedIndexChanged);
            // 
            // labelDetalhes
            // 
            this.labelDetalhes.AutoSize = true;
            this.labelDetalhes.Location = new System.Drawing.Point(30, 78);
            this.labelDetalhes.Name = "labelDetalhes";
            this.labelDetalhes.Size = new System.Drawing.Size(55, 15);
            this.labelDetalhes.TabIndex = 3;
            this.labelDetalhes.Text = "Detalhes:";
            // 
            // textBoxUtente
            // 
            this.textBoxUtente.Location = new System.Drawing.Point(130, 115);
            this.textBoxUtente.Name = "textBoxUtente";
            this.textBoxUtente.Size = new System.Drawing.Size(166, 23);
            this.textBoxUtente.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Utente:";
            // 
            // labelTerapeutaAutor
            // 
            this.labelTerapeutaAutor.AutoSize = true;
            this.labelTerapeutaAutor.Location = new System.Drawing.Point(30, 150);
            this.labelTerapeutaAutor.Name = "labelTerapeutaAutor";
            this.labelTerapeutaAutor.Size = new System.Drawing.Size(94, 15);
            this.labelTerapeutaAutor.TabIndex = 6;
            this.labelTerapeutaAutor.Text = "Terapeuta Autor:";
            // 
            // textBoxTerapeutaAutor
            // 
            this.textBoxTerapeutaAutor.Location = new System.Drawing.Point(130, 147);
            this.textBoxTerapeutaAutor.Name = "textBoxTerapeutaAutor";
            this.textBoxTerapeutaAutor.Size = new System.Drawing.Size(166, 23);
            this.textBoxTerapeutaAutor.TabIndex = 7;
            // 
            // labelMedicamento
            // 
            this.labelMedicamento.AutoSize = true;
            this.labelMedicamento.Location = new System.Drawing.Point(30, 185);
            this.labelMedicamento.Name = "labelMedicamento";
            this.labelMedicamento.Size = new System.Drawing.Size(84, 15);
            this.labelMedicamento.TabIndex = 8;
            this.labelMedicamento.Text = "Medicamento:";
            // 
            // textBoxMedicamento
            // 
            this.textBoxMedicamento.Location = new System.Drawing.Point(130, 182);
            this.textBoxMedicamento.Name = "textBoxMedicamento";
            this.textBoxMedicamento.Size = new System.Drawing.Size(166, 23);
            this.textBoxMedicamento.TabIndex = 9;
            // 
            // textBoxTratamento
            // 
            this.textBoxTratamento.Location = new System.Drawing.Point(130, 216);
            this.textBoxTratamento.Name = "textBoxTratamento";
            this.textBoxTratamento.Size = new System.Drawing.Size(166, 23);
            this.textBoxTratamento.TabIndex = 11;
            // 
            // labelTratamento
            // 
            this.labelTratamento.AutoSize = true;
            this.labelTratamento.Location = new System.Drawing.Point(30, 219);
            this.labelTratamento.Name = "labelTratamento";
            this.labelTratamento.Size = new System.Drawing.Size(70, 15);
            this.labelTratamento.TabIndex = 10;
            this.labelTratamento.Text = "Tratamento:";
            // 
            // labelExercicios
            // 
            this.labelExercicios.AutoSize = true;
            this.labelExercicios.Location = new System.Drawing.Point(30, 253);
            this.labelExercicios.Name = "labelExercicios";
            this.labelExercicios.Size = new System.Drawing.Size(62, 15);
            this.labelExercicios.TabIndex = 10;
            this.labelExercicios.Text = "Exercicios:";
            // 
            // textBoxExercicios
            // 
            this.textBoxExercicios.Location = new System.Drawing.Point(130, 250);
            this.textBoxExercicios.Name = "textBoxExercicios";
            this.textBoxExercicios.Size = new System.Drawing.Size(166, 23);
            this.textBoxExercicios.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Atribuir esta prescrição para o terapeuta: ";
            // 
            // labelTerapeuta
            // 
            this.labelTerapeuta.AutoSize = true;
            this.labelTerapeuta.Location = new System.Drawing.Point(30, 439);
            this.labelTerapeuta.Name = "labelTerapeuta";
            this.labelTerapeuta.Size = new System.Drawing.Size(61, 15);
            this.labelTerapeuta.TabIndex = 13;
            this.labelTerapeuta.Text = "Terapeuta:";
            // 
            // comboBoxTerapeuta
            // 
            this.comboBoxTerapeuta.FormattingEnabled = true;
            this.comboBoxTerapeuta.Location = new System.Drawing.Point(97, 436);
            this.comboBoxTerapeuta.Name = "comboBoxTerapeuta";
            this.comboBoxTerapeuta.Size = new System.Drawing.Size(166, 23);
            this.comboBoxTerapeuta.TabIndex = 14;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(30, 487);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(427, 23);
            this.buttonGuardar.TabIndex = 15;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(30, 516);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(427, 23);
            this.buttonVoltar.TabIndex = 16;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(130, 283);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(327, 93);
            this.textBoxDescricao.TabIndex = 18;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(30, 286);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(61, 15);
            this.labelDescricao.TabIndex = 17;
            this.labelDescricao.Text = "Descricao:";
            // 
            // FormAtribuirTerapeuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 566);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.comboBoxTerapeuta);
            this.Controls.Add(this.labelTerapeuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxExercicios);
            this.Controls.Add(this.textBoxTratamento);
            this.Controls.Add(this.labelExercicios);
            this.Controls.Add(this.labelTratamento);
            this.Controls.Add(this.textBoxMedicamento);
            this.Controls.Add(this.labelMedicamento);
            this.Controls.Add(this.textBoxTerapeutaAutor);
            this.Controls.Add(this.labelTerapeutaAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUtente);
            this.Controls.Add(this.labelDetalhes);
            this.Controls.Add(this.comboBoxPrescricao);
            this.Controls.Add(this.labelPrescricao);
            this.Name = "FormAtribuirTerapeuta";
            this.Text = "FormAtribuirTerapeuta";
            this.Load += new System.EventHandler(this.FormAtribuirTerapeuta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrescricao;
        private System.Windows.Forms.ComboBox comboBoxPrescricao;
        private System.Windows.Forms.Label labelDetalhes;
        private System.Windows.Forms.TextBox textBoxUtente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTerapeutaAutor;
        private System.Windows.Forms.TextBox textBoxTerapeutaAutor;
        private System.Windows.Forms.Label labelMedicamento;
        private System.Windows.Forms.TextBox textBoxMedicamento;
        private System.Windows.Forms.TextBox textBoxTratamento;
        private System.Windows.Forms.Label labelTratamento;
        private System.Windows.Forms.Label labelExercicios;
        private System.Windows.Forms.TextBox textBoxExercicios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTerapeuta;
        private System.Windows.Forms.ComboBox comboBoxTerapeuta;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDescricao;
    }
}