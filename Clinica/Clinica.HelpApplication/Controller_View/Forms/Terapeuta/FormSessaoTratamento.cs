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
    public partial class FormSessaoTratamento : Form
    {
        Navegacao navegacao = new Navegacao();
        Terapeuta_m terapeuta = new Terapeuta_m();
        DataSet ds = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();
        public FormSessaoTratamento()
        {
            InitializeComponent();
        }
        public FormSessaoTratamento(string nif)
        {
            InitializeComponent();
            this.Nif = nif;
        }

        private string Nif { get; set; }

        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            comboBoxPaciente.SelectedIndex = -1;
            comboBoxMedicacao.SelectedIndex = -1;
            comboBoxTratamento.SelectedIndex = -1;
            comboBoxExercicio.SelectedIndex = -1;
        }


        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            if ((comboBoxPaciente.SelectedItem == null) || String.IsNullOrEmpty(textBoxData.Text))
            {
                MessageBox.Show("Campo(s) em falta, preencha e tente novamente!", "Campo(s) em falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IsDate(textBoxData.Text) == false)
            {
                MessageBox.Show("O formato da data está incorreto!", "Campo data formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxData.Clear();
            }
            else if ((comboBoxMedicacao.SelectedItem == null) && (comboBoxTratamento.SelectedItem == null) && (comboBoxExercicio.SelectedItem == null)) 
            {
                MessageBox.Show("Campo(s) em falta, preencha pelo menos um tipo de prescrito e tente novamente!", "Campo(s) em falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string[] parts = textBoxTerapeuta.Text.Split(' ');
                terapeuta.criaSessaoTratamento(parts[0], comboBoxPaciente.Text, textBoxDescricao.Text, textBoxData.Text, comboBoxMedicacao.Text, comboBoxTratamento.Text, comboBoxExercicio.Text);
                MessageBox.Show("Sessão de Tratamento criada com sucesso!");
                textBoxData.Clear();
                textBoxDescricao.Clear();
                comboBoxPaciente.SelectedIndex = -1;
                comboBoxMedicacao.SelectedIndex = -1;
                comboBoxTratamento.SelectedIndex = -1;
                comboBoxExercicio.SelectedIndex = -1;
            }
        }

        private void FormSessaoTratamento_Load(object sender, EventArgs e)
        {
            textBoxTerapeuta.Enabled = false;
            string[] parts = textBoxTerapeuta.Text.Split(' ');
            MySqlDataReader reader = terapeuta.acedeIDTerapeutaENomeCompletoDaPessoaNIF(Nif);
            reader.Read();
            textBoxTerapeuta.Text = reader.GetString("id") + " - " + reader.GetString("nome") + " " + reader.GetString("sobrenome");
            reader.Close();
            da.SelectCommand = terapeuta.acedePlanoTratamentoAtribuidos(Nif);
            ds.Clear();
            da.Fill(ds);
            dataGridViewTratamentos.DataSource = ds.Tables[0];
            reader = reader = terapeuta.acedeNomeCompletoUtenteTratar();
            while (reader.Read())
            {
                comboBoxPaciente.Items.Add(reader.GetString("NomeUtenteTratar") + " " + reader.GetString("SobrenomeUtenteTratar"));
            }
            reader.Close();
            reader = terapeuta.acedeMedicacaoUtenteTratar();
            while (reader.Read())
            {
                comboBoxMedicacao.Items.Add(reader.GetString("medicamentos"));
            }
            reader.Close();
            reader = terapeuta.acedeTratamentoUtenteTratar();
            while (reader.Read())
            {
                comboBoxTratamento.Items.Add(reader.GetString("Tratamento"));
            }
            reader.Close();
            reader = terapeuta.acedeExerciciosUtenteTratar();
            while (reader.Read())
            {
                comboBoxExercicio.Items.Add(reader.GetString("exercicios"));
            }
            reader.Close();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formTerapeuta", Nif);
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
