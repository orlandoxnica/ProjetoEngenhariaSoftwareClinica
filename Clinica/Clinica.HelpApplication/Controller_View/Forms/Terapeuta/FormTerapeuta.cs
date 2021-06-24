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
    public partial class FormTerapeuta : Form
    {
        Navegacao navegacao = new Navegacao();
        Autenticacao_m autenticacao = new Autenticacao_m();
        MySqlConnection con = new MySqlConnection(@"server=Localhost;user id=root;database=clinica;password=");
        MySqlCommand cmd;
        public FormTerapeuta()
        {
            InitializeComponent();
        }

        public FormTerapeuta(string nif)
        {
            InitializeComponent();
            this.Nif = nif;
        }

        private string Nif { get; set; }

        private void FormTerapeuta_Load(object sender, EventArgs e)
        {
            if (autenticacao.verificaFuncoesUtilizador("terapeuta", Nif) == 1)
            {
                buttonVoltarAtras.Visible = false;
            }
        }

        private void buttonCriaPrescricao_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formCriarPrescricao", Nif);
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHistoricoPrescricoes_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formHistoricoPrescricoes", Nif);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formLogin", Nif);
        }

        private void buttonIntroduzir_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formCriarMedTraExer", Nif);
        }

        private void buttonCriarPlanoTratamento_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formPlanoTratamento", Nif);
        }

        private void buttonIniciarSessaoTratamento_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formSessaoTratamento", Nif);
        }

        private void buttonVoltarAtras_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formLoginVoltarAtras", Nif);
        }
        
        private void buttonSessoesRealizadas_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formTratamentosRealizados", Nif);
        }
    }
}
