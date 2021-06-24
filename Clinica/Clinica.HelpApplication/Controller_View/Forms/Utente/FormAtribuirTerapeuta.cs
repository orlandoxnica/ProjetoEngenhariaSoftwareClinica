using Clinica.HelpApplication.Controller_View.Navegacao;
using Clinica.HelpApplication.Model.Utente;
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
    public partial class FormAtribuirTerapeuta : Form
    {
        Navegacao navegacao = new Navegacao();
        Utente_m utente = new Utente_m();
        MySqlConnection con = new MySqlConnection(@"server=Localhost;user id=root;database=clinica;password=");
        MySqlCommand cmd, cmd2;
        public FormAtribuirTerapeuta()
        {
            InitializeComponent();
        }

        public FormAtribuirTerapeuta(string nif)
        {
            InitializeComponent();
            this.Nif = nif;
        }

        private string Nif { get; set; }

        private void FormAtribuirTerapeuta_Load(object sender, EventArgs e)
        {
            textBoxUtente.Enabled = false;
            textBoxTerapeutaAutor.Enabled = false;
            textBoxMedicamento.Enabled = false;
            textBoxTratamento.Enabled = false;
            textBoxExercicios.Enabled = false;
            textBoxDescricao.Enabled = false;
            MySqlDataReader reader = utente.acedeIDEDataPrescricao(Nif);
            while (reader.Read())
            {
                string[] parts = reader.GetString("data").Split(' ');
                comboBoxPrescricao.Items.Add(reader.GetString("id") + " - " + parts[0]);
            }
            reader.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(comboBoxPrescricao.Text == "")
            {
                MessageBox.Show("Não foi selecionada nenhuma prescrição");
                comboBoxTerapeuta.Items.Clear();
            }
            else if (comboBoxTerapeuta.Text == "")
            {
                MessageBox.Show("Não foi selecionado nenhum terapeuta");
            }
            else 
            { 
                con.Open();
                string[] parts = comboBoxPrescricao.Text.Split(' ');
                string[] parts2 = comboBoxTerapeuta.Text.Split(' ');
                int count = utente.verificarTerapeutaAcessoPrescricao(parts2[0], parts[0]);
                if (count != 0)
                {
                    MessageBox.Show("O terapeuta selecionado já tem acesso a prescrição");
                    comboBoxTerapeuta.SelectedIndex = -1;
                }
                else
                {
                    utente.atribuirAcessoTerapeutaPrescricao(parts2[0], parts[0]);
                    MessageBox.Show("Prescrição atribuida!");
                    comboBoxPrescricao.SelectedIndex = -1;
                    comboBoxTerapeuta.SelectedIndex = -1;
                    comboBoxTerapeuta.Items.Clear();
                }
            }
        }

        private void comboBoxPrescricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTerapeuta.SelectedIndex = -1;
            comboBoxTerapeuta.Items.Clear();
            if (comboBoxPrescricao.SelectedIndex != -1)
            {
                con.Open();
                string[] parts = comboBoxPrescricao.Text.Split(' ');
                MySqlDataReader reader = utente.acedeConteudoPrescricao(parts[0]);
                reader.Read();
                textBoxUtente.Text = reader.GetString("idUtente") + " - " + reader.GetString("nome") + " " + reader.GetString("sobrenome");
                textBoxMedicamento.Text = reader.GetString("medicamento");
                textBoxTratamento.Text = reader.GetString("tratamento");
                textBoxExercicios.Text = reader.GetString("exercicios");
                textBoxDescricao.Text = reader.GetString("descricao");
                reader.Close();
                reader = utente.acedeAutorResponsavelPrescricao(parts[0]);
                reader.Read();
                textBoxTerapeutaAutor.Text = reader.GetString("idAutorTerapeuta") + " - " + reader.GetString("nome") + " " + reader.GetString("sobrenome");
                reader.Close();
                reader = utente.acedeTerapeutasDisponiveis(textBoxTerapeutaAutor.Text);
                while (reader.Read())
                {
                    comboBoxTerapeuta.Items.Add(reader.GetString("id") + " - " + reader.GetString("nome") + " " + reader.GetString("sobrenome"));
                }
                con.Close();
            }
            else
            {
                textBoxUtente.Text = "";
                textBoxTerapeutaAutor.Text = "";
                textBoxMedicamento.Text = "";
                textBoxTratamento.Text = "";
                textBoxExercicios.Text = "";
                textBoxDescricao.Text = "";
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formUtente", Nif);
        }
    }
}
