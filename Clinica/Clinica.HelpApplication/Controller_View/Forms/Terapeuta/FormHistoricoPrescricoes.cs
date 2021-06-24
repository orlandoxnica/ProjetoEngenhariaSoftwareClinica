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
    public partial class FormHistoricoPrescricoes : Form
    {
        Navegacao navegacao = new Navegacao();
        Terapeuta_m terapeuta = new Terapeuta_m();
        DataSet ds = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();
        public FormHistoricoPrescricoes()
        {
            InitializeComponent();
        }

        public FormHistoricoPrescricoes(string nif)
        {
            InitializeComponent();
            this.Nif = nif;
        }

        private string Nif { get; set; }

        private void FormHistoricoPrescricoes_Load(object sender, EventArgs e)
        {
            da.SelectCommand = terapeuta.historicoPrescricoes(Nif);
            ds.Clear();
            da.Fill(ds);
            dataGridViewPrescricoes.DataSource = ds.Tables[0];
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formTerapeuta", Nif);
        }

        private void textBoxNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            List<string> idExistentes = new List<string>();
            MySqlDataReader reader = terapeuta.acedePessoas();
            while (reader.Read())
            {
                idExistentes.Add(reader.GetString("identificacao"));
            }
            reader.Close();
            if (!idExistentes.Contains(textBoxNIF.Text))
            {
                MessageBox.Show("NIF inválido tente novamente!", "NIF não existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                da.SelectCommand = terapeuta.pesquisarPrescricaoNIF(textBoxNIF.Text);
                ds.Clear();
                da.Fill(ds);
                dataGridViewPrescricoes.DataSource = ds.Tables[0];
            }
        }
    }
}
