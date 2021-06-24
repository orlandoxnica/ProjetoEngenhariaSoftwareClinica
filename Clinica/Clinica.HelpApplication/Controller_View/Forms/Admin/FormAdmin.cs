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
    public partial class FormAdmin : Form
    {
        Navegacao navegacao = new Navegacao();
        Autenticacao_m autenticacao = new Autenticacao_m();
        public FormAdmin()
        {
            InitializeComponent();
        }

        public FormAdmin(string nif)
        {
            InitializeComponent();
            this.Nif = nif;
        }

        private string Nif { get; set; }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            if (autenticacao.verificaFuncoesUtilizador("admin",Nif) == 1)
            {
                buttonVoltarAtras.Visible = false;
            }
        }

        private void buttonCriarPessoa_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formAddPessoa", Nif);
        }

        private void buttonCriarUser_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formAddUser", Nif);
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formLogin", Nif);
        }

        private void buttonListaPessoas_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formListarPessoas", Nif);
        }

        private void buttonListaUsers_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formListaUsers", Nif);
        }

        private void buttonAtualizaFuncoes_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formAtualizaFuncoesUser", Nif);
        }

        private void buttonVoltarAtras_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formLoginVoltarAtras", Nif);
        }
    }
}
