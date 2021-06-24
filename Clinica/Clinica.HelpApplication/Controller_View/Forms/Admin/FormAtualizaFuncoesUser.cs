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
    public partial class FormAtualizaFuncoesUser : Form
    {
        Navegacao navegacao = new Navegacao();
        Admin_m admin = new Admin_m();
        public FormAtualizaFuncoesUser()
        {
            InitializeComponent();
        }
        public FormAtualizaFuncoesUser(string nif)
        {
            InitializeComponent();
            this.Nif = nif;
        }

        private string Nif { get; set; }

        private void FormAtualizaFuncoesUser_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = admin.acedeIDUtilizadorENomeCompletoDaPessoa();
            while (reader.Read())
            {
                comboBoxUtilizador.Items.Add(reader.GetString("id") + " - " + reader.GetString("nome") + " " + reader.GetString("sobrenome"));
            }
            reader.Close();
        }

        private void comboBoxUtilizador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUtilizador.SelectedIndex != -1)
            {
                checkBoxAdmin.Checked = false;
                checkBoxUtente.Checked = false;
                checkBoxTerapeuta.Checked = false;
                string bU, bT, bA;
                string[] parts = comboBoxUtilizador.Text.Split(' ');
                MySqlDataReader reader = admin.acedeUtilizadorEspecifico(parts[0]);
                reader.Read();
                bU = reader.GetString("bUtente");
                bT = reader.GetString("bTerapeuta");
                bA = reader.GetString("bAdmin");
                if (bA == "1")
                {
                    checkBoxAdmin.Checked = true;
                }
                if (bU == "1")
                {
                    checkBoxUtente.Checked = true;
                }
                if (bT == "1")
                {
                    checkBoxTerapeuta.Checked = true;
                }
            }
            else
            {
                checkBoxAdmin.Checked = false;
                checkBoxUtente.Checked = false;
                checkBoxTerapeuta.Checked = false;
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formAdmin", Nif);
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if ((comboBoxUtilizador.SelectedItem != null) && (checkBoxAdmin.Checked == true) || (checkBoxUtente.Checked == true) || (checkBoxTerapeuta.Checked == true))
            {
                List<string> idExistentes = new List<string>();
                string[] parts = comboBoxUtilizador.Text.Split(' ');
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
                admin.atualizaFuncoesUtilizador(c1, c2, c3, parts[0]);
                comboBoxUtilizador.SelectedIndex = -1;
                checkBoxAdmin.Checked = false;
                checkBoxUtente.Checked = false;
                checkBoxTerapeuta.Checked = false;
                MessageBox.Show("Utilizador atualizado!");
            }
            else 
            {
                comboBoxUtilizador.SelectedIndex = -1;
                checkBoxAdmin.Checked = false;
                checkBoxUtente.Checked = false;
                checkBoxTerapeuta.Checked = false;
                MessageBox.Show("Preencha o(s) campo(s) corretamente e tente novamente!", "Campo(s) em falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
