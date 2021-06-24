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
    public partial class FormAddPessoa : Form
    {
        Navegacao navegacao = new Navegacao();
        Admin_m admin = new Admin_m();
        public FormAddPessoa()
        {
            InitializeComponent();
        }

        public FormAddPessoa(string nif)
        {
            InitializeComponent();
            this.Nif = nif;
        }

        private string Nif { get; set; }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            navegacao.getFormulario(this, "formAdmin", Nif);
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (String.IsNullOrEmpty(textBoxNome.Text) || String.IsNullOrEmpty(textBoxNIF.Text) || String.IsNullOrEmpty(textBoxDataNascimento.Text) || String.IsNullOrEmpty(textBoxContacto.Text) || String.IsNullOrEmpty(textBoxSobrenome.Text) || String.IsNullOrEmpty(textBoxMorada.Text))
            {
                MessageBox.Show("Preencha o(s) campo(s) corretamente e tente novamente!", "Campo(s) em falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNome.Clear();
                textBoxNIF.Clear();
                textBoxDataNascimento.Clear();
                textBoxContacto.Clear();
                textBoxSobrenome.Clear();
                textBoxMorada.Clear();
            }
            else if(!int.TryParse(textBoxNIF.Text, out parsedValue)|| !int.TryParse(textBoxContacto.Text, out parsedValue))
            {
                MessageBox.Show("Só é permitido números no campo NIF e no campo Contacto!", "Campo(s) com formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNIF.Clear();
                textBoxContacto.Clear();
            }
            else if(IsDate(textBoxDataNascimento.Text)==false)
            {
                MessageBox.Show("O formato da data está incorreto!", "Campo data formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxDataNascimento.Clear();
            }
            else
            {
                admin.criaPessoa(textBoxNome.Text, textBoxNIF.Text, textBoxDataNascimento.Text, textBoxContacto.Text, textBoxSobrenome.Text, textBoxMorada.Text);
                MessageBox.Show("Pessoa criada com sucesso!");
                textBoxNome.Clear();
                textBoxNIF.Clear();
                textBoxDataNascimento.Clear();
                textBoxContacto.Clear();
                textBoxSobrenome.Clear();
                textBoxMorada.Clear();
            }
        }

        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxSobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        public static bool IsDate(string tempDate)
        {
            DateTime fromDateValue;
            var formats = new[] { "yyyy/MM/dd", "yyyy-MM-dd" };
            if (DateTime.TryParseExact(tempDate, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fromDateValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
