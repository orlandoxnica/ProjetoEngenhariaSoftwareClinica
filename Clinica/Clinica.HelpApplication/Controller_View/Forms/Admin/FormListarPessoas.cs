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
    public partial class FormListarPessoas : Form
    {
        Navegacao navegacao = new Navegacao();
        Admin_m admin = new Admin_m();
        DataSet ds = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();
        public FormListarPessoas()
        {
            InitializeComponent();
        }

        public FormListarPessoas(string nif)
        {
            InitializeComponent();
            this.Nif = nif;
        }

        private string Nif { get; set; }

        private void FormListarPessoas_Load(object sender, EventArgs e)
        {
            da.SelectCommand = admin.acederPessoas();
            ds.Clear();
            da.Fill(ds);
            dataGridViewPessoas.DataSource = ds.Tables[0];
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formAdmin", Nif);
        }
    }
}
