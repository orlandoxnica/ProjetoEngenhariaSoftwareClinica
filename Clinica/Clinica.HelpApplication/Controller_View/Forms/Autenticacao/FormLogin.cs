using Clinica.HelpApplication.Controller_View.Navegacao;
using Clinica.HelpApplication.Model.Autenticacao;
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
    public partial class FormLogin : Form
    {
        Autenticacao_m autenticacao = new Autenticacao_m();
        Navegacao navegacao = new Navegacao();

        public FormLogin()
        {
            InitializeComponent();

        }

        public FormLogin(int verifica, string nifVolta)
        {
            InitializeComponent();
            this.Verifica = verifica;
            this.NifVolta = nifVolta;
        }

        private int Verifica { get; set; }

        private string NifVolta { get; set; }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if(Verifica == 1)
            {
                MySqlDataReader reader = autenticacao.getUtilizadorLogin(NifVolta);
                reader.Read();
                escolherTipo(reader, NifVolta);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNIF.Text) && !String.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Introduza um NIF válido e tente novamente!", "Erro ao iniciar login!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNIF.Clear();
                textBoxPassword.Clear();
            }
            else if (String.IsNullOrEmpty(textBoxNIF.Text) && String.IsNullOrEmpty(textBoxPassword.Text)) 
            {
                MessageBox.Show("Introduza um NIF e Password!", "Erro ao iniciar login!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MySqlDataReader reader = autenticacao.getUtilizadorLogin(textBoxNIF.Text, textBoxPassword.Text);
                reader.Read();
                escolherTipo(reader, textBoxNIF.Text);
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            if(Verifica == 1)
            {
                navegacao.getFormulario(this, "formAdmin", NifVolta);
            }
            else 
            {
                navegacao.getFormulario(this, "formAdmin", textBoxNIF.Text);
            }
            
        }

        private void buttonUtente_Click(object sender, EventArgs e)
        {
            if (Verifica == 1)
            {
                navegacao.getFormulario(this, "formUtente", NifVolta);
            }
            else
            {
                navegacao.getFormulario(this, "formUtente", textBoxNIF.Text);
            }
        }

        private void buttonTerapeuta_Click(object sender, EventArgs e)
        {
            if (Verifica == 1)
            {
                navegacao.getFormulario(this, "formTerapeuta", NifVolta);
            }
            else
            {
                navegacao.getFormulario(this, "formTerapeuta", textBoxNIF.Text);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            labelSelecioneTipo.Visible = false;
            buttonAdmin.Visible = false;
            buttonUtente.Visible = false;
            buttonTerapeuta.Visible = false;
            buttonLogout.Visible = false;
            textBoxNIF.Clear();
            textBoxPassword.Clear();
            textBoxNIF.Visible = true;
            textBoxPassword.Visible = true;
            buttonLogin.Visible = true;
            labelNIF.Visible = true;
            labelPassword.Visible = true;
            labelEfetuaLogin.Visible = true;
        }

        private void escolherTipo(MySqlDataReader reader, string nif)
        {
            int bTerapeuta = 1;
            int bUtente = 2;
            int bAdmin = 3;
            if (reader.HasRows)
            {
                if ((reader.GetFieldValue<int>(bUtente) == 1) || (reader.GetFieldValue<int>(bTerapeuta) == 1) || (reader.GetFieldValue<int>(bAdmin) == 1))
                {
                    if (((reader.GetFieldValue<int>(bUtente) == 1) && (reader.GetFieldValue<int>(bTerapeuta) == 0) && (reader.GetFieldValue<int>(bAdmin) == 0)))
                    {
                        navegacao.getFormulario(this, "formUtente", nif);
                    }
                    if (((reader.GetFieldValue<int>(bUtente) == 0) && (reader.GetFieldValue<int>(bTerapeuta) == 1) && (reader.GetFieldValue<int>(bAdmin) == 0)))
                    {
                        navegacao.getFormulario(this, "formTerapeuta", nif);
                    }
                    if (((reader.GetFieldValue<int>(bUtente) == 0) && (reader.GetFieldValue<int>(bTerapeuta) == 0) && (reader.GetFieldValue<int>(bAdmin) == 1)))
                    {
                        navegacao.getFormulario(this, "formAdmin", nif);
                    }

                    else if (((reader.GetFieldValue<int>(bUtente) == 1) && (reader.GetFieldValue<int>(bTerapeuta) == 1) && (reader.GetFieldValue<int>(bAdmin) == 1)))
                    {
                        labelSelecioneTipo.Visible = true;
                        buttonAdmin.Visible = true;
                        buttonUtente.Visible = true;
                        buttonTerapeuta.Visible = true;
                        buttonLogout.Visible = true;
                        textBoxNIF.Visible = false;
                        textBoxPassword.Visible = false;
                        buttonLogin.Visible = false;
                        labelNIF.Visible = false;
                        labelPassword.Visible = false;
                        labelEfetuaLogin.Visible = false;
                    }
                    else if (((reader.GetFieldValue<int>(bUtente) == 1) && (reader.GetFieldValue<int>(bTerapeuta) == 1) && (reader.GetFieldValue<int>(bAdmin) == 0)))
                    {
                        labelSelecioneTipo.Visible = true;
                        buttonAdmin.Visible = false;
                        buttonUtente.Visible = true;
                        buttonTerapeuta.Visible = true;
                        buttonLogout.Visible = true;
                        textBoxNIF.Visible = false;
                        textBoxPassword.Visible = false;
                        buttonLogin.Visible = false;
                        labelNIF.Visible = false;
                        labelPassword.Visible = false;
                        labelEfetuaLogin.Visible = false;
                    }
                    else if (((reader.GetFieldValue<int>(bUtente) == 1) && (reader.GetFieldValue<int>(bTerapeuta) == 0) && (reader.GetFieldValue<int>(bAdmin) == 1)))
                    {
                        labelSelecioneTipo.Visible = true;
                        buttonAdmin.Visible = true;
                        buttonUtente.Visible = true;
                        buttonTerapeuta.Visible = false;
                        buttonLogout.Visible = true;
                        textBoxNIF.Visible = false;
                        textBoxPassword.Visible = false;
                        buttonLogin.Visible = false;
                        labelNIF.Visible = false;
                        labelPassword.Visible = false;
                        labelEfetuaLogin.Visible = false;
                    }
                    else if (((reader.GetFieldValue<int>(bUtente) == 0) && (reader.GetFieldValue<int>(bTerapeuta) == 1) && (reader.GetFieldValue<int>(bAdmin) == 1)))
                    {
                        labelSelecioneTipo.Visible = true;
                        buttonAdmin.Visible = true;
                        buttonUtente.Visible = false;
                        buttonTerapeuta.Visible = true;
                        buttonLogout.Visible = true;
                        textBoxNIF.Visible = false;
                        textBoxPassword.Visible = false;
                        buttonLogin.Visible = false;
                        labelNIF.Visible = false;
                        labelPassword.Visible = false;
                        labelEfetuaLogin.Visible = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Informações erradas, tente novamente!", "Erro ao iniciar login!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNIF.Clear();
                textBoxPassword.Clear();
            }
        }
    }
}
