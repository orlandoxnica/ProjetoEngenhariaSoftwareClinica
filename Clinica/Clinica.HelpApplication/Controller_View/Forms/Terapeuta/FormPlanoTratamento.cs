using Clinica.HelpApplication.Controller_View.Navegacao;
using Clinica.HelpApplication.Model.Terapeuta;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.HelpApplication
{
    public partial class FormPlanoTratamento : Form
    {
        Navegacao navegacao = new Navegacao();
        Terapeuta_m terapeuta = new Terapeuta_m();

        public FormPlanoTratamento()
        {
            InitializeComponent();
        }
        public FormPlanoTratamento(string nif)
        {
            InitializeComponent();
            this.Nif = nif;
        }

        private string Nif { get; set; }

        private void FormPlanoTratamento_Load(object sender, EventArgs e)
        {
            textBoxTerapeuta.Enabled = false;
            string[] parts = textBoxTerapeuta.Text.Split(' ');
            MySqlDataReader reader = terapeuta.acedeIDTerapeutaENomeCompletoDaPessoaNIF(Nif);
            reader.Read();
            textBoxTerapeuta.Text = reader.GetString("id") + " - " + reader.GetString("nome") + " " + reader.GetString("sobrenome");
            reader.Close();
            reader = terapeuta.acedeNomeCompletoUtente();
            while (reader.Read())
            {
                comboBoxUtente.Items.Add(reader.GetString("id") + " - " + reader.GetString("nome") + " " + reader.GetString("sobrenome"));
            }
            reader.Close();
            reader = terapeuta.acedeTratamentosPrescricao();
            while (reader.Read())
            {
                comboBoxTratamento.Items.Add(reader.GetString("tratamento"));
            }
            reader.Close();
            reader = terapeuta.acedeHorarioMedicacaoPrescricao();
            while (reader.Read())
            {
                comboBoxHorarioMedicacao.Items.Add(reader.GetString("horarioMedicacao"));
            }
            reader.Close();
            reader = terapeuta.acedeMedicacaoPrescricao();
            while (reader.Read())
            {
                comboBoxMedicamento.Items.Add(reader.GetString("medicamento"));
            }
            reader.Close();
            reader = terapeuta.acedeExerciciosPrescricao();
            while (reader.Read())
            {
                comboBoxExercicios.Items.Add(reader.GetString("exercicios"));
            }
            reader.Close();
            reader = terapeuta.acedeHorarioExerciciosPrescricao();
            while (reader.Read())
            {
                comboBoxHorarioExercicio.Items.Add(reader.GetString("horarioexercicios"));
            }
            reader.Close();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formTerapeuta", Nif);
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            if ((comboBoxUtente.SelectedItem == null) || String.IsNullOrEmpty(textBoxDataInicio.Text) || String.IsNullOrEmpty(textBoxDataFim.Text))
            {
                MessageBox.Show("Preencha corretamente todos os campos e tente novamente!", "Erro ao efetuar a inserção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IsDate(textBoxDataInicio.Text) == false && IsDate(textBoxDataFim.Text) == false)
            {
                MessageBox.Show("O formato da data está incorreto!", "Campo data formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxDataInicio.Clear();
                textBoxDataFim.Clear();
            }
            else if ((comboBoxTratamento.SelectedItem == null) && (comboBoxHorarioMedicacao.SelectedItem == null) && (comboBoxMedicamento.SelectedItem == null) && (comboBoxExercicios.SelectedItem == null) && (comboBoxHorarioExercicio.SelectedItem == null))
            {
                MessageBox.Show("Preencha pelo menos um medicamento ou tratamento ou exercício!", "Campo(s) em falta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((comboBoxHorarioMedicacao.SelectedItem != null) && (comboBoxMedicamento.SelectedItem == null))
            {
                MessageBox.Show("Preencha o campo medicamentos!", "Campo em falta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((comboBoxHorarioMedicacao.SelectedItem == null) && (comboBoxMedicamento.SelectedItem != null))
            {
                MessageBox.Show("Preencha o campo horário medicação!", "Campo em falta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((comboBoxExercicios.SelectedItem != null) && (comboBoxHorarioExercicio.SelectedItem == null))
            {
                MessageBox.Show("Preencha o campo horário exercícios!", "Campo em falta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((comboBoxExercicios.SelectedItem == null) && (comboBoxHorarioExercicio.SelectedItem != null))
            {
                MessageBox.Show("Preencha o campo exercícios!", "Campo em falta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string[] parts = comboBoxUtente.Text.Split(' ');
                string[] parts2 = textBoxTerapeuta.Text.Split(' ');
                terapeuta.criaPlanoTratamento(parts[0], parts2[0], textBoxDataInicio.Text, textBoxDataFim.Text, comboBoxTratamento.Text, comboBoxHorarioMedicacao.Text, comboBoxMedicamento.Text, comboBoxExercicios.Text, comboBoxHorarioExercicio.Text, parts2[2], parts2[3], parts[2], parts[3]);
                MessageBox.Show("Plano de Tratamento criado com sucesso!");
                textBoxDataInicio.Clear();
                textBoxDataFim.Clear();
                comboBoxTratamento.SelectedIndex = -1;
                comboBoxUtente.SelectedIndex = -1;
                comboBoxHorarioMedicacao.SelectedIndex = -1;
                comboBoxMedicamento.SelectedIndex = -1;
                comboBoxExercicios.SelectedIndex = -1;
                comboBoxHorarioExercicio.SelectedIndex = -1;
            }
        }

        public static bool IsDate(string tempDate)
        {
            DateTime fromDateValue;
            var formats = new[] { "yyyy/MM/dd", "yyyy-MM-dd" };
            if (DateTime.TryParseExact(tempDate, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fromDateValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
