
namespace Clinica.HelpApplication
{
    partial class FormCriarPrescricao
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
            this.labelCriarPrescricao = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.comboBoxUtente = new System.Windows.Forms.ComboBox();
            this.labelUtente = new System.Windows.Forms.Label();
            this.labelTerapeuta = new System.Windows.Forms.Label();
            this.buttonCriar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.labelHorarioMedicacao = new System.Windows.Forms.Label();
            this.textBoxHorarioMedicacao = new System.Windows.Forms.TextBox();
            this.labelMedicacao = new System.Windows.Forms.Label();
            this.listBoxMedicacao = new System.Windows.Forms.ListBox();
            this.labelTratamento = new System.Windows.Forms.Label();
            this.listBoxTratamento = new System.Windows.Forms.ListBox();
            this.listBoxExercicios = new System.Windows.Forms.ListBox();
            this.labelExercicios = new System.Windows.Forms.Label();
            this.labelHorarioExercicios = new System.Windows.Forms.Label();
            this.textBoxHorarioExercicios = new System.Windows.Forms.TextBox();
            this.textBoxTerapeuta = new System.Windows.Forms.TextBox();
            this.labelFormatoData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCriarPrescricao
            // 
            this.labelCriarPrescricao.AutoSize = true;
            this.labelCriarPrescricao.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCriarPrescricao.Location = new System.Drawing.Point(12, 9);
            this.labelCriarPrescricao.Name = "labelCriarPrescricao";
            this.labelCriarPrescricao.Size = new System.Drawing.Size(199, 37);
            this.labelCriarPrescricao.TabIndex = 0;
            this.labelCriarPrescricao.Text = "Criar Prescrição";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(39, 72);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(34, 15);
            this.labelData.TabIndex = 1;
            this.labelData.Text = "Data:";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(12, 117);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(61, 15);
            this.labelDescricao.TabIndex = 2;
            this.labelDescricao.Text = "Descrição:";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(79, 69);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(185, 23);
            this.textBoxData.TabIndex = 3;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(79, 114);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(185, 23);
            this.textBoxDescricao.TabIndex = 4;
            // 
            // comboBoxUtente
            // 
            this.comboBoxUtente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUtente.FormattingEnabled = true;
            this.comboBoxUtente.Location = new System.Drawing.Point(79, 158);
            this.comboBoxUtente.Name = "comboBoxUtente";
            this.comboBoxUtente.Size = new System.Drawing.Size(185, 23);
            this.comboBoxUtente.Sorted = true;
            this.comboBoxUtente.TabIndex = 5;
            // 
            // labelUtente
            // 
            this.labelUtente.AutoSize = true;
            this.labelUtente.Location = new System.Drawing.Point(28, 161);
            this.labelUtente.Name = "labelUtente";
            this.labelUtente.Size = new System.Drawing.Size(45, 15);
            this.labelUtente.TabIndex = 7;
            this.labelUtente.Text = "Utente:";
            // 
            // labelTerapeuta
            // 
            this.labelTerapeuta.AutoSize = true;
            this.labelTerapeuta.Location = new System.Drawing.Point(12, 206);
            this.labelTerapeuta.Name = "labelTerapeuta";
            this.labelTerapeuta.Size = new System.Drawing.Size(61, 15);
            this.labelTerapeuta.TabIndex = 8;
            this.labelTerapeuta.Text = "Terapeuta:";
            // 
            // buttonCriar
            // 
            this.buttonCriar.Location = new System.Drawing.Point(200, 253);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(75, 23);
            this.buttonCriar.TabIndex = 9;
            this.buttonCriar.Text = "Criar";
            this.buttonCriar.UseVisualStyleBackColor = true;
            this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(302, 253);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 10;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // labelHorarioMedicacao
            // 
            this.labelHorarioMedicacao.AutoSize = true;
            this.labelHorarioMedicacao.Location = new System.Drawing.Point(264, 15);
            this.labelHorarioMedicacao.Name = "labelHorarioMedicacao";
            this.labelHorarioMedicacao.Size = new System.Drawing.Size(111, 15);
            this.labelHorarioMedicacao.TabIndex = 11;
            this.labelHorarioMedicacao.Text = "Horário Medicação:";
            // 
            // textBoxHorarioMedicacao
            // 
            this.textBoxHorarioMedicacao.Location = new System.Drawing.Point(381, 12);
            this.textBoxHorarioMedicacao.Name = "textBoxHorarioMedicacao";
            this.textBoxHorarioMedicacao.Size = new System.Drawing.Size(185, 23);
            this.textBoxHorarioMedicacao.TabIndex = 12;
            // 
            // labelMedicacao
            // 
            this.labelMedicacao.AutoSize = true;
            this.labelMedicacao.Location = new System.Drawing.Point(307, 57);
            this.labelMedicacao.Name = "labelMedicacao";
            this.labelMedicacao.Size = new System.Drawing.Size(68, 15);
            this.labelMedicacao.TabIndex = 13;
            this.labelMedicacao.Text = "Medicação:";
            // 
            // listBoxMedicacao
            // 
            this.listBoxMedicacao.AllowDrop = true;
            this.listBoxMedicacao.FormattingEnabled = true;
            this.listBoxMedicacao.ItemHeight = 15;
            this.listBoxMedicacao.Location = new System.Drawing.Point(381, 57);
            this.listBoxMedicacao.Name = "listBoxMedicacao";
            this.listBoxMedicacao.ScrollAlwaysVisible = true;
            this.listBoxMedicacao.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMedicacao.Size = new System.Drawing.Size(185, 34);
            this.listBoxMedicacao.Sorted = true;
            this.listBoxMedicacao.TabIndex = 14;
            // 
            // labelTratamento
            // 
            this.labelTratamento.AutoSize = true;
            this.labelTratamento.Location = new System.Drawing.Point(307, 109);
            this.labelTratamento.Name = "labelTratamento";
            this.labelTratamento.Size = new System.Drawing.Size(70, 15);
            this.labelTratamento.TabIndex = 15;
            this.labelTratamento.Text = "Tratamento:";
            // 
            // listBoxTratamento
            // 
            this.listBoxTratamento.FormattingEnabled = true;
            this.listBoxTratamento.ItemHeight = 15;
            this.listBoxTratamento.Location = new System.Drawing.Point(381, 109);
            this.listBoxTratamento.Name = "listBoxTratamento";
            this.listBoxTratamento.ScrollAlwaysVisible = true;
            this.listBoxTratamento.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxTratamento.Size = new System.Drawing.Size(185, 34);
            this.listBoxTratamento.Sorted = true;
            this.listBoxTratamento.TabIndex = 16;
            // 
            // listBoxExercicios
            // 
            this.listBoxExercicios.FormattingEnabled = true;
            this.listBoxExercicios.ItemHeight = 15;
            this.listBoxExercicios.Location = new System.Drawing.Point(381, 162);
            this.listBoxExercicios.Name = "listBoxExercicios";
            this.listBoxExercicios.ScrollAlwaysVisible = true;
            this.listBoxExercicios.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxExercicios.Size = new System.Drawing.Size(185, 34);
            this.listBoxExercicios.Sorted = true;
            this.listBoxExercicios.TabIndex = 17;
            // 
            // labelExercicios
            // 
            this.labelExercicios.AutoSize = true;
            this.labelExercicios.Location = new System.Drawing.Point(313, 162);
            this.labelExercicios.Name = "labelExercicios";
            this.labelExercicios.Size = new System.Drawing.Size(62, 15);
            this.labelExercicios.TabIndex = 18;
            this.labelExercicios.Text = "Exercícios:";
            // 
            // labelHorarioExercicios
            // 
            this.labelHorarioExercicios.AutoSize = true;
            this.labelHorarioExercicios.Location = new System.Drawing.Point(272, 213);
            this.labelHorarioExercicios.Name = "labelHorarioExercicios";
            this.labelHorarioExercicios.Size = new System.Drawing.Size(105, 15);
            this.labelHorarioExercicios.TabIndex = 19;
            this.labelHorarioExercicios.Text = "Horário Exercícios:";
            // 
            // textBoxHorarioExercicios
            // 
            this.textBoxHorarioExercicios.Location = new System.Drawing.Point(383, 210);
            this.textBoxHorarioExercicios.Name = "textBoxHorarioExercicios";
            this.textBoxHorarioExercicios.Size = new System.Drawing.Size(185, 23);
            this.textBoxHorarioExercicios.TabIndex = 20;
            // 
            // textBoxTerapeuta
            // 
            this.textBoxTerapeuta.Location = new System.Drawing.Point(79, 203);
            this.textBoxTerapeuta.Name = "textBoxTerapeuta";
            this.textBoxTerapeuta.Size = new System.Drawing.Size(185, 23);
            this.textBoxTerapeuta.TabIndex = 21;
            // 
            // labelFormatoData
            // 
            this.labelFormatoData.AutoSize = true;
            this.labelFormatoData.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFormatoData.Location = new System.Drawing.Point(129, 54);
            this.labelFormatoData.Name = "labelFormatoData";
            this.labelFormatoData.Size = new System.Drawing.Size(69, 12);
            this.labelFormatoData.TabIndex = 22;
            this.labelFormatoData.Text = "AAAA-MM-DD";
            // 
            // FormCriarPrescricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 281);
            this.Controls.Add(this.labelFormatoData);
            this.Controls.Add(this.textBoxTerapeuta);
            this.Controls.Add(this.textBoxHorarioExercicios);
            this.Controls.Add(this.labelHorarioExercicios);
            this.Controls.Add(this.labelExercicios);
            this.Controls.Add(this.listBoxExercicios);
            this.Controls.Add(this.listBoxTratamento);
            this.Controls.Add(this.labelTratamento);
            this.Controls.Add(this.listBoxMedicacao);
            this.Controls.Add(this.labelMedicacao);
            this.Controls.Add(this.textBoxHorarioMedicacao);
            this.Controls.Add(this.labelHorarioMedicacao);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonCriar);
            this.Controls.Add(this.labelTerapeuta);
            this.Controls.Add(this.labelUtente);
            this.Controls.Add(this.comboBoxUtente);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelCriarPrescricao);
            this.Name = "FormCriarPrescricao";
            this.Text = "FormCriarPrescricao";
            this.Load += new System.EventHandler(this.FormCriarPrescricao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCriarPrescricao;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.ComboBox comboBoxUtente;
        private System.Windows.Forms.Label labelUtente;
        private System.Windows.Forms.Label labelTerapeuta;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label labelHorarioMedicacao;
        private System.Windows.Forms.TextBox textBoxHorarioMedicacao;
        private System.Windows.Forms.Label labelMedicacao;
        private System.Windows.Forms.ListBox listBoxMedicacao;
        private System.Windows.Forms.Label labelTratamento;
        private System.Windows.Forms.ListBox listBoxTratamento;
        private System.Windows.Forms.ListBox listBoxExercicios;
        private System.Windows.Forms.Label labelExercicios;
        private System.Windows.Forms.Label labelHorarioExercicios;
        private System.Windows.Forms.TextBox textBoxHorarioExercicios;
        private System.Windows.Forms.TextBox textBoxTerapeuta;
        private System.Windows.Forms.Label labelFormatoData;
    }
}