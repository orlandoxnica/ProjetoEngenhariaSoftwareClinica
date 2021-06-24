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
    public partial class FormPlanoTratamentoUtente : Form
    {
        Navegacao navegacao = new Navegacao();
        Utente_m utente = new Utente_m();
        DataSet ds = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();
        public FormPlanoTratamentoUtente()
        {
            InitializeComponent();
        }
        public FormPlanoTratamentoUtente(string nif )
        {
            InitializeComponent();
            this.Nif = nif;
        }

        private string Nif { get; set; }

        private void FormPlanoTratamentoUtente_Load(object sender, EventArgs e)
        {
            da.SelectCommand = utente.planosDeTratamentoUtente(Nif);
            ds.Clear();
            da.Fill(ds);
            dataGridViewTratamento.DataSource = ds.Tables[0];
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formUtente", Nif);
        }
    }
}
