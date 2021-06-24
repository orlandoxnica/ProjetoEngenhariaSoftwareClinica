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
    public partial class FormCriarMedTraExer : Form
    {
        Navegacao navegacao = new Navegacao();
        Terapeuta_m terapeuta = new Terapeuta_m();
        MySqlConnection con = new MySqlConnection(@"server=Localhost;user id=root;database=clinica;password=");
        MySqlCommand cmd;
        public FormCriarMedTraExer()
        {
            InitializeComponent();
        }
        public FormCriarMedTraExer(string nif)
        {
            InitializeComponent();
            this.Nif = nif;
        }

        private string Nif { get; set; }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formTerapeuta", Nif);
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxNomeMedicamento.Text) || !String.IsNullOrEmpty(textBoxNomeTratamento.Text) || !String.IsNullOrEmpty(textBoxNomeExercicio.Text))
            {
                if (!String.IsNullOrEmpty(textBoxNomeMedicamento.Text))
                {
                    terapeuta.criaMedicamento(textBoxNomeMedicamento.Text);
                    MessageBox.Show("Medicamento adicionado com sucesso!");
                    textBoxNomeMedicamento.Clear();
                }
                if (!String.IsNullOrEmpty(textBoxNomeTratamento.Text))
                {
                    terapeuta.criaTratamento(textBoxNomeTratamento.Text);
                    MessageBox.Show("Tratamento adicionado com sucesso!");
                    textBoxNomeTratamento.Clear();
                }
                if (!String.IsNullOrEmpty(textBoxNomeExercicio.Text))
                {
                    terapeuta.criaExercicio(textBoxNomeExercicio.Text);
                    MessageBox.Show("Exercício adicionado com sucesso!");
                    textBoxNomeExercicio.Clear();
                }
            }
            else 
            {
                MessageBox.Show("Preencha o(s) campo(s) corretamente e tente novamente!", "Campo(s) em falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
