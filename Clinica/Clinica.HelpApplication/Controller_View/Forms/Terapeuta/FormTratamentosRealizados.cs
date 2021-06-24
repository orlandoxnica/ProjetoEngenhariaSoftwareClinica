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
    public partial class FormTratamentosRealizados : Form
    {
        Navegacao navegacao = new Navegacao();
        Terapeuta_m terapeuta = new Terapeuta_m();
        DataSet ds = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();
        public FormTratamentosRealizados()
        {
            InitializeComponent();
        }
        public FormTratamentosRealizados(string nif)
        {
            InitializeComponent();
            this.Nif = nif;
        }
        private string Nif { get; set; }

        private void FormTratamentosRealizados_Load(object sender, EventArgs e)
        {
            da.SelectCommand = terapeuta.tratamentosRealizados(Nif);
            ds.Clear();
            da.Fill(ds);
            dataGridViewTratamentos.DataSource = ds.Tables[0];
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formTerapeuta", Nif);
        }
    }
}
