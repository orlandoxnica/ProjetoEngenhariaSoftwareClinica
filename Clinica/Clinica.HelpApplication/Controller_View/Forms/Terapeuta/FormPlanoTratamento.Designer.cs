
namespace Clinica.HelpApplication
{
    partial class FormPlanoTratamento
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
            this.labelCriarPlanoTratamento = new System.Windows.Forms.Label();
            this.labelDataInicio = new System.Windows.Forms.Label();
            this.textBoxDataInicio = new System.Windows.Forms.TextBox();
            this.textBoxDataFim = new System.Windows.Forms.TextBox();
            this.labelDataFim = new System.Windows.Forms.Label();
            this.comboBoxTratamento = new System.Windows.Forms.ComboBox();
            this.labelTratamento = new System.Windows.Forms.Label();
            this.labelUtente = new System.Windows.Forms.Label();
            this.comboBoxUtente = new System.Windows.Forms.ComboBox();
            this.labelHorarioMedicacao = new System.Windows.Forms.Label();
            this.comboBoxHorarioMedicacao = new System.Windows.Forms.ComboBox();
            this.labelMedicamento = new System.Windows.Forms.Label();
            this.comboBoxMedicamento = new System.Windows.Forms.ComboBox();
            this.labelExercicios = new System.Windows.Forms.Label();
            this.labelHorarioExercicio = new System.Windows.Forms.Label();
            this.comboBoxExercicios = new System.Windows.Forms.ComboBox();
            this.comboBoxHorarioExercicio = new System.Windows.Forms.ComboBox();
            this.labelTerapeuta = new System.Windows.Forms.Label();
            this.buttonCriar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.labelFormatoDataInicio = new System.Windows.Forms.Label();
            this.labelFormatoDataFim = new System.Windows.Forms.Label();
            this.textBoxTerapeuta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCriarPlanoTratamento
            // 
            this.labelCriarPlanoTratamento.AutoSize = true;
            this.labelCriarPlanoTratamento.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCriarPlanoTratamento.Location = new System.Drawing.Point(12, 9);
            this.labelCriarPlanoTratamento.Name = "labelCriarPlanoTratamento";
            this.labelCriarPlanoTratamento.Size = new System.Drawing.Size(332, 37);
            this.labelCriarPlanoTratamento.TabIndex = 0;
            this.labelCriarPlanoTratamento.Text = "Criar Plano de Tratamento:";
            // 
            // labelDataInicio
            // 
            this.labelDataInicio.AutoSize = true;
            this.labelDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataInicio.Location = new System.Drawing.Point(10, 109);
            this.labelDataInicio.Name = "labelDataInicio";
            this.labelDataInicio.Size = new System.Drawing.Size(118, 13);
            this.labelDataInicio.TabIndex = 1;
            this.labelDataInicio.Text = "Data Inicio Tratamento:";
            // 
            // textBoxDataInicio
            // 
            this.textBoxDataInicio.Location = new System.Drawing.Point(134, 105);
            this.textBoxDataInicio.MaxLength = 10;
            this.textBoxDataInicio.Name = "textBoxDataInicio";
            this.textBoxDataInicio.Size = new System.Drawing.Size(178, 23);
            this.textBoxDataInicio.TabIndex = 2;
            // 
            // textBoxDataFim
            // 
            this.textBoxDataFim.Location = new System.Drawing.Point(134, 149);
            this.textBoxDataFim.MaxLength = 10;
            this.textBoxDataFim.Name = "textBoxDataFim";
            this.textBoxDataFim.Size = new System.Drawing.Size(178, 23);
            this.textBoxDataFim.TabIndex = 4;
            // 
            // labelDataFim
            // 
            this.labelDataFim.AutoSize = true;
            this.labelDataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataFim.Location = new System.Drawing.Point(19, 153);
            this.labelDataFim.Name = "labelDataFim";
            this.labelDataFim.Size = new System.Drawing.Size(109, 13);
            this.labelDataFim.TabIndex = 3;
            this.labelDataFim.Text = "Data Fim Tratamento:";
            // 
            // comboBoxTratamento
            // 
            this.comboBoxTratamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTratamento.FormattingEnabled = true;
            this.comboBoxTratamento.Location = new System.Drawing.Point(134, 192);
            this.comboBoxTratamento.Name = "comboBoxTratamento";
            this.comboBoxTratamento.Size = new System.Drawing.Size(178, 23);
            this.comboBoxTratamento.Sorted = true;
            this.comboBoxTratamento.TabIndex = 5;
            // 
            // labelTratamento
            // 
            this.labelTratamento.AutoSize = true;
            this.labelTratamento.Location = new System.Drawing.Point(58, 195);
            this.labelTratamento.Name = "labelTratamento";
            this.labelTratamento.Size = new System.Drawing.Size(70, 15);
            this.labelTratamento.TabIndex = 6;
            this.labelTratamento.Text = "Tratamento:";
            // 
            // labelUtente
            // 
            this.labelUtente.AutoSize = true;
            this.labelUtente.Location = new System.Drawing.Point(83, 67);
            this.labelUtente.Name = "labelUtente";
            this.labelUtente.Size = new System.Drawing.Size(45, 15);
            this.labelUtente.TabIndex = 7;
            this.labelUtente.Text = "Utente:";
            // 
            // comboBoxUtente
            // 
            this.comboBoxUtente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUtente.FormattingEnabled = true;
            this.comboBoxUtente.Location = new System.Drawing.Point(134, 64);
            this.comboBoxUtente.Name = "comboBoxUtente";
            this.comboBoxUtente.Size = new System.Drawing.Size(178, 23);
            this.comboBoxUtente.Sorted = true;
            this.comboBoxUtente.TabIndex = 8;
            // 
            // labelHorarioMedicacao
            // 
            this.labelHorarioMedicacao.AutoSize = true;
            this.labelHorarioMedicacao.Location = new System.Drawing.Point(343, 70);
            this.labelHorarioMedicacao.Name = "labelHorarioMedicacao";
            this.labelHorarioMedicacao.Size = new System.Drawing.Size(111, 15);
            this.labelHorarioMedicacao.TabIndex = 9;
            this.labelHorarioMedicacao.Text = "Horário Medicação:";
            // 
            // comboBoxHorarioMedicacao
            // 
            this.comboBoxHorarioMedicacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHorarioMedicacao.FormattingEnabled = true;
            this.comboBoxHorarioMedicacao.Location = new System.Drawing.Point(460, 67);
            this.comboBoxHorarioMedicacao.Name = "comboBoxHorarioMedicacao";
            this.comboBoxHorarioMedicacao.Size = new System.Drawing.Size(178, 23);
            this.comboBoxHorarioMedicacao.Sorted = true;
            this.comboBoxHorarioMedicacao.TabIndex = 10;
            // 
            // labelMedicamento
            // 
            this.labelMedicamento.AutoSize = true;
            this.labelMedicamento.Location = new System.Drawing.Point(365, 112);
            this.labelMedicamento.Name = "labelMedicamento";
            this.labelMedicamento.Size = new System.Drawing.Size(89, 15);
            this.labelMedicamento.TabIndex = 11;
            this.labelMedicamento.Text = "Medicamentos:";
            // 
            // comboBoxMedicamento
            // 
            this.comboBoxMedicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMedicamento.FormattingEnabled = true;
            this.comboBoxMedicamento.Location = new System.Drawing.Point(460, 109);
            this.comboBoxMedicamento.Name = "comboBoxMedicamento";
            this.comboBoxMedicamento.Size = new System.Drawing.Size(178, 23);
            this.comboBoxMedicamento.Sorted = true;
            this.comboBoxMedicamento.TabIndex = 12;
            // 
            // labelExercicios
            // 
            this.labelExercicios.AutoSize = true;
            this.labelExercicios.Location = new System.Drawing.Point(392, 152);
            this.labelExercicios.Name = "labelExercicios";
            this.labelExercicios.Size = new System.Drawing.Size(62, 15);
            this.labelExercicios.TabIndex = 13;
            this.labelExercicios.Text = "Exercícios:";
            // 
            // labelHorarioExercicio
            // 
            this.labelHorarioExercicio.AutoSize = true;
            this.labelHorarioExercicio.Location = new System.Drawing.Point(349, 194);
            this.labelHorarioExercicio.Name = "labelHorarioExercicio";
            this.labelHorarioExercicio.Size = new System.Drawing.Size(105, 15);
            this.labelHorarioExercicio.TabIndex = 14;
            this.labelHorarioExercicio.Text = "Horário Exercícios:";
            // 
            // comboBoxExercicios
            // 
            this.comboBoxExercicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExercicios.FormattingEnabled = true;
            this.comboBoxExercicios.Location = new System.Drawing.Point(460, 148);
            this.comboBoxExercicios.Name = "comboBoxExercicios";
            this.comboBoxExercicios.Size = new System.Drawing.Size(178, 23);
            this.comboBoxExercicios.Sorted = true;
            this.comboBoxExercicios.TabIndex = 15;
            // 
            // comboBoxHorarioExercicio
            // 
            this.comboBoxHorarioExercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHorarioExercicio.FormattingEnabled = true;
            this.comboBoxHorarioExercicio.Location = new System.Drawing.Point(460, 191);
            this.comboBoxHorarioExercicio.Name = "comboBoxHorarioExercicio";
            this.comboBoxHorarioExercicio.Size = new System.Drawing.Size(178, 23);
            this.comboBoxHorarioExercicio.Sorted = true;
            this.comboBoxHorarioExercicio.TabIndex = 16;
            // 
            // labelTerapeuta
            // 
            this.labelTerapeuta.AutoSize = true;
            this.labelTerapeuta.Location = new System.Drawing.Point(67, 238);
            this.labelTerapeuta.Name = "labelTerapeuta";
            this.labelTerapeuta.Size = new System.Drawing.Size(61, 15);
            this.labelTerapeuta.TabIndex = 17;
            this.labelTerapeuta.Text = "Terapeuta:";
            // 
            // buttonCriar
            // 
            this.buttonCriar.Location = new System.Drawing.Point(423, 239);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(94, 27);
            this.buttonCriar.TabIndex = 19;
            this.buttonCriar.Text = "Criar";
            this.buttonCriar.UseVisualStyleBackColor = true;
            this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(544, 239);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(94, 27);
            this.buttonVoltar.TabIndex = 20;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // labelFormatoDataInicio
            // 
            this.labelFormatoDataInicio.AutoSize = true;
            this.labelFormatoDataInicio.Location = new System.Drawing.Point(21, 122);
            this.labelFormatoDataInicio.Name = "labelFormatoDataInicio";
            this.labelFormatoDataInicio.Size = new System.Drawing.Size(87, 15);
            this.labelFormatoDataInicio.TabIndex = 21;
            this.labelFormatoDataInicio.Text = "AAAA-MM-DD";
            // 
            // labelFormatoDataFim
            // 
            this.labelFormatoDataFim.AutoSize = true;
            this.labelFormatoDataFim.Location = new System.Drawing.Point(21, 166);
            this.labelFormatoDataFim.Name = "labelFormatoDataFim";
            this.labelFormatoDataFim.Size = new System.Drawing.Size(87, 15);
            this.labelFormatoDataFim.TabIndex = 22;
            this.labelFormatoDataFim.Text = "AAAA-MM-DD";
            // 
            // textBoxTerapeuta
            // 
            this.textBoxTerapeuta.Location = new System.Drawing.Point(134, 235);
            this.textBoxTerapeuta.Name = "textBoxTerapeuta";
            this.textBoxTerapeuta.Size = new System.Drawing.Size(178, 23);
            this.textBoxTerapeuta.TabIndex = 23;
            // 
            // FormPlanoTratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 278);
            this.Controls.Add(this.textBoxTerapeuta);
            this.Controls.Add(this.labelFormatoDataFim);
            this.Controls.Add(this.labelFormatoDataInicio);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonCriar);
            this.Controls.Add(this.labelTerapeuta);
            this.Controls.Add(this.comboBoxHorarioExercicio);
            this.Controls.Add(this.comboBoxExercicios);
            this.Controls.Add(this.labelHorarioExercicio);
            this.Controls.Add(this.labelExercicios);
            this.Controls.Add(this.comboBoxMedicamento);
            this.Controls.Add(this.labelMedicamento);
            this.Controls.Add(this.comboBoxHorarioMedicacao);
            this.Controls.Add(this.labelHorarioMedicacao);
            this.Controls.Add(this.comboBoxUtente);
            this.Controls.Add(this.labelUtente);
            this.Controls.Add(this.labelTratamento);
            this.Controls.Add(this.comboBoxTratamento);
            this.Controls.Add(this.textBoxDataFim);
            this.Controls.Add(this.labelDataFim);
            this.Controls.Add(this.textBoxDataInicio);
            this.Controls.Add(this.labelDataInicio);
            this.Controls.Add(this.labelCriarPlanoTratamento);
            this.Name = "FormPlanoTratamento";
            this.Text = "FormPlanoTratamento";
            this.Load += new System.EventHandler(this.FormPlanoTratamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCriarPlanoTratamento;
        private System.Windows.Forms.Label labelDataInicio;
        private System.Windows.Forms.TextBox textBoxDataInicio;
        private System.Windows.Forms.TextBox textBoxDataFim;
        private System.Windows.Forms.Label labelDataFim;
        private System.Windows.Forms.ComboBox comboBoxTratamento;
        private System.Windows.Forms.Label labelTratamento;
        private System.Windows.Forms.Label labelUtente;
        private System.Windows.Forms.ComboBox comboBoxUtente;
        private System.Windows.Forms.Label labelHorarioMedicacao;
        private System.Windows.Forms.ComboBox comboBoxHorarioMedicacao;
        private System.Windows.Forms.Label labelMedicamento;
        private System.Windows.Forms.ComboBox comboBoxMedicamento;
        private System.Windows.Forms.Label labelExercicios;
        private System.Windows.Forms.Label labelHorarioExercicio;
        private System.Windows.Forms.ComboBox comboBoxExercicios;
        private System.Windows.Forms.ComboBox comboBoxHorarioExercicio;
        private System.Windows.Forms.Label labelTerapeuta;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label labelFormatoDataInicio;
        private System.Windows.Forms.Label labelFormatoDataFim;
        private System.Windows.Forms.TextBox textBoxTerapeuta;
    }
}