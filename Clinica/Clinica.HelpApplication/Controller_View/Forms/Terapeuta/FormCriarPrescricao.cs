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
    public partial class FormCriarPrescricao : Form
    {
        Navegacao navegacao = new Navegacao();
        Terapeuta_m terapeuta = new Terapeuta_m();
        public FormCriarPrescricao()
        {
            InitializeComponent();
        }

        public FormCriarPrescricao(string nif)
        {
            InitializeComponent();
            this.Nif = nif;
        }

        private string Nif { get; set; }

        private void FormCriarPrescricao_Load(object sender, EventArgs e)
        {
            textBoxTerapeuta.Enabled = false;
            string[] parts = textBoxTerapeuta.Text.Split(' ');
            MySqlDataReader reader = terapeuta.acedeIDUtenteENomeCompletoDaPessoaNIFDiferente(Nif);
            while (reader.Read())
            {
                comboBoxUtente.Items.Add(reader.GetString("id") + " - " + reader.GetString("nome") + " " + reader.GetString("sobrenome"));
            }
            reader.Close();
            reader = terapeuta.acedeIDTerapeutaENomeCompletoDaPessoaNIF(Nif);
            reader.Read();
            textBoxTerapeuta.Text = reader.GetString("id") + " - " + reader.GetString("nome") + " " + reader.GetString("sobrenome");
            reader.Close();
            reader = terapeuta.acedeMedicamento();
            while (reader.Read())
            {
                listBoxMedicacao.Items.Add(reader.GetString("nome"));
            }
            reader.Close();
            reader = terapeuta.acedeTratamento();
            while (reader.Read())
            {
                listBoxTratamento.Items.Add(reader.GetString("nome"));
            }
            reader.Close();
            reader = terapeuta.acedeExercicio();
            while (reader.Read())
            {
                listBoxExercicios.Items.Add(reader.GetString("nome"));
            }
            reader.Close();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formTerapeuta", Nif);
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxData.Text) || String.IsNullOrEmpty(textBoxDescricao.Text) || String.IsNullOrEmpty(comboBoxUtente.Text) || String.IsNullOrEmpty(textBoxTerapeuta.Text))
            {
                MessageBox.Show("Preencha o(s) campo(s) corretamente e tente novamente!", "Campo(s) em falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxData.Clear();
                textBoxDescricao.Clear();
            }
            else if(IsDate(textBoxData.Text)==false)
            {
                MessageBox.Show("O formato da data está incorreto!", "Campo data formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxData.Clear();
            }
            else if (!String.IsNullOrEmpty(textBoxData.Text) && !String.IsNullOrEmpty(textBoxDescricao.Text) && !String.IsNullOrEmpty(comboBoxUtente.Text) && this.listBoxMedicacao.SelectedIndex == -1 && this.listBoxTratamento.SelectedIndex == -1 && this.listBoxExercicios.SelectedIndex == -1)
            {
                MessageBox.Show("Campo(s) em falta, preencha e tente novamente!", "Campo(s) em falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!String.IsNullOrEmpty(textBoxHorarioMedicacao.Text) && this.listBoxMedicacao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um medicamento e tente novamente!", "Campo em falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(textBoxHorarioMedicacao.Text) && this.listBoxMedicacao.SelectedIndex != -1)
            {
                MessageBox.Show("Introduza um horário de medicação e tente novamente!", "Campo em falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!String.IsNullOrEmpty(textBoxHorarioExercicios.Text) && this.listBoxExercicios.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um exercício e tente novamente!", "Campo em falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(textBoxHorarioExercicios.Text) && this.listBoxExercicios.SelectedIndex != -1)
            {
                MessageBox.Show("Introduza um horário de exercício e tente novamente!!", "Campo em falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string[] parts = comboBoxUtente.Text.Split(' ');
                string[] parts2 = textBoxTerapeuta.Text.Split(' ');
                int count = terapeuta.verificarPrescricaoDataETerapeutaExistentes(textBoxData.Text, parts[0], parts2[0]);
                if (count == 0)
                {
                    terapeuta.criaPrescricao(textBoxData.Text, textBoxDescricao.Text, parts2[0], parts[0], parts[2], parts[3], textBoxHorarioMedicacao.Text, listBoxMedicacao.Text, listBoxTratamento.Text, listBoxExercicios.Text, textBoxHorarioExercicios.Text, parts2[2], parts2[3]);
                    MySqlDataReader reader = terapeuta.acedeIDPrescricao(textBoxData.Text, parts[0], parts2[0]);
                    reader.Read();
                    string idP = reader.GetString("id");
                    reader.Close();
                    terapeuta.criaLigacaoTerapeutaPrescricao(parts2[0], idP);
                    MessageBox.Show("Prescrição criada com sucesso!");
                    textBoxData.Clear();
                    textBoxDescricao.Clear();
                    textBoxHorarioMedicacao.Clear();
                    textBoxHorarioExercicios.Clear();
                    comboBoxUtente.SelectedIndex = -1;
                    listBoxMedicacao.ClearSelected();
                    listBoxTratamento.ClearSelected();
                    listBoxExercicios.ClearSelected();
                }
                else
                {
                    MessageBox.Show("Só é possivel passar 1 prescrição por dia por cada utente");
                }
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
