using Clinica.HelpApplication.Controller_View.Navegacao;
using Clinica.HelpApplication.Model.Admin;
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
    public partial class FormAddUser : Form
    {
        Navegacao navegacao = new Navegacao();
        Admin_m admin = new Admin_m();
        public FormAddUser()
        {
            InitializeComponent();
        }

        public FormAddUser(string nif)
        {
            InitializeComponent();
            this.Nif = nif;
        }

        private string Nif { get; set; }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = admin.acederPessoas();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxIDPessoa.Items.Add(reader.GetString("id") + " - " + reader.GetString("nome") + " " + reader.GetString("sobrenome"));
            }
            reader.Close();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("É necessario inserir uma password!");
                comboBoxIDPessoa.SelectedIndex = -1;
                textBoxPassword.Clear();
                checkBoxAdmin.Checked = false;
                checkBoxUtente.Checked = false;
                checkBoxTerapeuta.Checked = false;
            }
            else if (checkBoxAdmin.Checked == false && checkBoxUtente.Checked == false && checkBoxTerapeuta.Checked == false)
            {
                MessageBox.Show("É necessario ter uma das opções selecionada!");
                comboBoxIDPessoa.SelectedIndex = -1;
                checkBoxAdmin.Checked = false;
                checkBoxUtente.Checked = false;
                checkBoxTerapeuta.Checked = false;
            }
            else if (comboBoxIDPessoa.Text == "")
            {
                MessageBox.Show("É necessario inserir um ID utilizador!");
                comboBoxIDPessoa.SelectedIndex = -1;
            }
            else
            {
                List<string> idExistentes = new List<string>();
                MySqlDataReader reader = admin.acederUtilizadores().ExecuteReader();
                while (reader.Read())
                {
                    idExistentes.Add(reader.GetString("idPessoa"));
                }
                reader.Close();
                string[] parts = comboBoxIDPessoa.Text.Split(' ');
                if (!idExistentes.Contains(parts[0]))
                {
                    int c1, c2, c3;
                    if (checkBoxAdmin.Checked)
                    {
                        c1 = 1;
                    }
                    else
                    {
                        c1 = 0;
                    }
                    if (checkBoxUtente.Checked)
                    {
                        c2 = 1;
                    }
                    else
                    {
                        c2 = 0;
                    }
                    if (checkBoxTerapeuta.Checked)
                    {
                        c3 = 1;
                    }
                    else
                    {
                        c3 = 0;
                    }

                    admin.criaUtilizador(textBoxPassword.Text, c3, c2, c1, int.Parse(parts[0]));
                    if (c2 == 1)
                    {
                        admin.procuraIDPessoaEInsereUtente(parts[0]);
                    }
                    if (c3 == 1)
                    {
                        admin.procuraIDPessoaEInsereTerapeuta(parts[0]);
                    }
                    MessageBox.Show("Utilizador criado com sucesso!");
                    comboBoxIDPessoa.SelectedIndex = -1;
                    textBoxPassword.Clear();
                    checkBoxAdmin.Checked = false;
                    checkBoxUtente.Checked = false;
                    checkBoxTerapeuta.Checked = false;
                }
                else
                {
                    MessageBox.Show("Erro, esse idPessoa já está a ser utilizado");
                    comboBoxIDPessoa.SelectedIndex = -1;
                }
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formAdmin", Nif);
        }
    }
}
