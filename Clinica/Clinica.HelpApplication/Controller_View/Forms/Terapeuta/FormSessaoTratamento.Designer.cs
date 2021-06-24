
namespace Clinica.HelpApplication
{
    partial class FormSessaoTratamento
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
            this.labelListaTratamentos = new System.Windows.Forms.Label();
            this.dataGridViewTratamentos = new System.Windows.Forms.DataGridView();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.labelIniciarTratamento = new System.Windows.Forms.Label();
            this.labelPaciente = new System.Windows.Forms.Label();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.comboBoxMedicacao = new System.Windows.Forms.ComboBox();
            this.labelMedicacao = new System.Windows.Forms.Label();
            this.labelTratamento = new System.Windows.Forms.Label();
            this.comboBoxTratamento = new System.Windows.Forms.ComboBox();
            this.labelExercicio = new System.Windows.Forms.Label();
            this.comboBoxExercicio = new System.Windows.Forms.ComboBox();
            this.labelTerapeuta = new System.Windows.Forms.Label();
            this.buttonLimparCampos = new System.Windows.Forms.Button();
            this.labelFormatoData = new System.Windows.Forms.Label();
            this.textBoxTerapeuta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTratamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListaTratamentos
            // 
            this.labelListaTratamentos.AutoSize = true;
            this.labelListaTratamentos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelListaTratamentos.Location = new System.Drawing.Point(12, 9);
            this.labelListaTratamentos.Name = "labelListaTratamentos";
            this.labelListaTratamentos.Size = new System.Drawing.Size(408, 37);
            this.labelListaTratamentos.TabIndex = 0;
            this.labelListaTratamentos.Text = "Lista de Tratamentos por realizar:";
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
            this.dataGridViewTratamentos.Size = new System.Drawing.Size(1303, 314);
            this.dataGridViewTratamentos.TabIndex = 1;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(998, 453);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(102, 29);
            this.buttonVoltar.TabIndex = 2;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // labelIniciarTratamento
            // 
            this.labelIniciarTratamento.AutoSize = true;
            this.labelIniciarTratamento.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIniciarTratamento.Location = new System.Drawing.Point(12, 364);
            this.labelIniciarTratamento.Name = "labelIniciarTratamento";
            this.labelIniciarTratamento.Size = new System.Drawing.Size(236, 37);
            this.labelIniciarTratamento.TabIndex = 3;
            this.labelIniciarTratamento.Text = "Iniciar Tratamento:";
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Location = new System.Drawing.Point(12, 417);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(55, 15);
            this.labelPaciente.TabIndex = 4;
            this.labelPaciente.Text = "Paciente:";
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(73, 414);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(166, 23);
            this.comboBoxPaciente.TabIndex = 5;
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(890, 453);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(102, 29);
            this.buttonIniciar.TabIndex = 6;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(73, 457);
            this.textBoxData.MaxLength = 10;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(166, 23);
            this.textBoxData.TabIndex = 7;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(33, 460);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(34, 15);
            this.labelData.TabIndex = 8;
            this.labelData.Text = "Data:";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(300, 417);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(61, 15);
            this.labelDescricao.TabIndex = 9;
            this.labelDescricao.Text = "Descrição:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(367, 414);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(166, 23);
            this.textBoxDescricao.TabIndex = 10;
            // 
            // comboBoxMedicacao
            // 
            this.comboBoxMedicacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMedicacao.FormattingEnabled = true;
            this.comboBoxMedicacao.Location = new System.Drawing.Point(367, 457);
            this.comboBoxMedicacao.Name = "comboBoxMedicacao";
            this.comboBoxMedicacao.Size = new System.Drawing.Size(166, 23);
            this.comboBoxMedicacao.TabIndex = 11;
            // 
            // labelMedicacao
            // 
            this.labelMedicacao.AutoSize = true;
            this.labelMedicacao.Location = new System.Drawing.Point(246, 460);
            this.labelMedicacao.Name = "labelMedicacao";
            this.labelMedicacao.Size = new System.Drawing.Size(115, 15);
            this.labelMedicacao.TabIndex = 12;
            this.labelMedicacao.Text = "Medicação a utilizar:";
            // 
            // labelTratamento
            // 
            this.labelTratamento.AutoSize = true;
            this.labelTratamento.Location = new System.Drawing.Point(549, 417);
            this.labelTratamento.Name = "labelTratamento";
            this.labelTratamento.Size = new System.Drawing.Size(112, 15);
            this.labelTratamento.TabIndex = 13;
            this.labelTratamento.Text = "Tipo de Tratamento:";
            // 
            // comboBoxTratamento
            // 
            this.comboBoxTratamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTratamento.FormattingEnabled = true;
            this.comboBoxTratamento.Location = new System.Drawing.Point(667, 414);
            this.comboBoxTratamento.Name = "comboBoxTratamento";
            this.comboBoxTratamento.Size = new System.Drawing.Size(166, 23);
            this.comboBoxTratamento.TabIndex = 14;
            // 
            // labelExercicio
            // 
            this.labelExercicio.AutoSize = true;
            this.labelExercicio.Location = new System.Drawing.Point(549, 460);
            this.labelExercicio.Name = "labelExercicio";
            this.labelExercicio.Size = new System.Drawing.Size(109, 15);
            this.labelExercicio.TabIndex = 15;
            this.labelExercicio.Text = "Exercício a Realizar:";
            // 
            // comboBoxExercicio
            // 
            this.comboBoxExercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExercicio.FormattingEnabled = true;
            this.comboBoxExercicio.Location = new System.Drawing.Point(667, 457);
            this.comboBoxExercicio.Name = "comboBoxExercicio";
            this.comboBoxExercicio.Size = new System.Drawing.Size(166, 23);
            this.comboBoxExercicio.TabIndex = 16;
            // 
            // labelTerapeuta
            // 
            this.labelTerapeuta.AutoSize = true;
            this.labelTerapeuta.Location = new System.Drawing.Point(844, 417);
            this.labelTerapeuta.Name = "labelTerapeuta";
            this.labelTerapeuta.Size = new System.Drawing.Size(61, 15);
            this.labelTerapeuta.TabIndex = 17;
            this.labelTerapeuta.Text = "Terapeuta:";
            // 
            // buttonLimparCampos
            // 
            this.buttonLimparCampos.Location = new System.Drawing.Point(1106, 453);
            this.buttonLimparCampos.Name = "buttonLimparCampos";
            this.buttonLimparCampos.Size = new System.Drawing.Size(102, 29);
            this.buttonLimparCampos.TabIndex = 19;
            this.buttonLimparCampos.Text = "Limpar Campos";
            this.buttonLimparCampos.UseVisualStyleBackColor = true;
            this.buttonLimparCampos.Click += new System.EventHandler(this.buttonLimparCampos_Click);
            // 
            // labelFormatoData
            // 
            this.labelFormatoData.AutoSize = true;
            this.labelFormatoData.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFormatoData.Location = new System.Drawing.Point(111, 444);
            this.labelFormatoData.Name = "labelFormatoData";
            this.labelFormatoData.Size = new System.Drawing.Size(69, 12);
            this.labelFormatoData.TabIndex = 20;
            this.labelFormatoData.Text = "AAAA-MM-DD";
            // 
            // textBoxTerapeuta
            // 
            this.textBoxTerapeuta.Location = new System.Drawing.Point(911, 414);
            this.textBoxTerapeuta.Name = "textBoxTerapeuta";
            this.textBoxTerapeuta.Size = new System.Drawing.Size(166, 23);
            this.textBoxTerapeuta.TabIndex = 21;
            // 
            // FormSessaoTratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 494);
            this.Controls.Add(this.textBoxTerapeuta);
            this.Controls.Add(this.labelFormatoData);
            this.Controls.Add(this.buttonLimparCampos);
            this.Controls.Add(this.labelTerapeuta);
            this.Controls.Add(this.comboBoxExercicio);
            this.Controls.Add(this.labelExercicio);
            this.Controls.Add(this.comboBoxTratamento);
            this.Controls.Add(this.labelTratamento);
            this.Controls.Add(this.labelMedicacao);
            this.Controls.Add(this.comboBoxMedicacao);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.comboBoxPaciente);
            this.Controls.Add(this.labelPaciente);
            this.Controls.Add(this.labelIniciarTratamento);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.dataGridViewTratamentos);
            this.Controls.Add(this.labelListaTratamentos);
            this.Name = "FormSessaoTratamento";
            this.Text = "FormSessaoTratamento";
            this.Load += new System.EventHandler(this.FormSessaoTratamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTratamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListaTratamentos;
        private System.Windows.Forms.DataGridView dataGridViewTratamentos;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label labelIniciarTratamento;
        private System.Windows.Forms.Label labelPaciente;
        private System.Windows.Forms.ComboBox comboBoxPaciente;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.ComboBox comboBoxMedicacao;
        private System.Windows.Forms.Label labelMedicacao;
        private System.Windows.Forms.Label labelTratamento;
        private System.Windows.Forms.ComboBox comboBoxTratamento;
        private System.Windows.Forms.Label labelExercicio;
        private System.Windows.Forms.ComboBox comboBoxExercicio;
        private System.Windows.Forms.Label labelTerapeuta;
        private System.Windows.Forms.Button buttonLimparCampos;
        private System.Windows.Forms.Label labelFormatoData;
        private System.Windows.Forms.TextBox textBoxTerapeuta;
    }
}