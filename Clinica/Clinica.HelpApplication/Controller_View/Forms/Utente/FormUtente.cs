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
    public partial class FormUtente : Form
    {
        Navegacao navegacao = new Navegacao();
        Autenticacao_m autenticacao = new Autenticacao_m();
        MySqlConnection con = new MySqlConnection(@"server=Localhost;user id=root;database=clinica;password=");
        MySqlCommand cmd;
        public FormUtente()
        {
            InitializeComponent();
        }

        public FormUtente(string nif)
        {
            InitializeComponent();
            this.Nif = nif;
        }

        private string Nif { get; set; }

        private void FormUtente_Load(object sender, EventArgs e)
        {
            if (autenticacao.verificaFuncoesUtilizador("utente", Nif) == 1)
            {
                buttonVoltarAtras.Visible = false;
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonHistoricoPrescricoes_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formHistoricoUtentes", Nif);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formLogin", Nif);
        }

        private void buttonPlanoTratamento_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formPlanoTratamentoUtente", Nif);
        }

        private void buttonAtribuirTerapeuta_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formAtribuirTerapeuta", Nif);
        }

        private void buttonVoltarAtras_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formLoginVoltarAtras", Nif);
        }
    }
}
