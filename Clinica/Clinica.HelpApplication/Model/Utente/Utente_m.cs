using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Clinica.HelpApplication.Model.Utente
{
    class Utente_m
    {
        public MySqlCommand historicoUtente(string nif)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT DISTINCT pr.id, pr.data, pr.nomeTerapeuta, pr.sobrenomeTerapeuta, pr.descricao, pr.horarioMedicacao, pr.medicamento, pr.tratamento, pr.exercicios, pr.horarioexercicios FROM pessoa p, prescricao pr, terapeuta t, utilizador u, utente ut WHERE pr.idUtente = ut.id AND ut.idUtilizador = u.id AND u.idPessoa = p.id AND p.identificacao = '" + nif + "'", con);
            con.Close(); 
            return cmd;
        }

        public MySqlCommand planosDeTratamentoUtente(string nif)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT pt.dataInicioTratamento, pt.dataFimTratamento, pt.Tratamento, pt.horarioMedicacao, pt.medicamentos, pt.exercicios, pt.horarioExercicios, pt.terapeutaNome, pt.terapeutaSobrenome FROM utilizador u, utente ut, pessoa p, planotratamento pt WHERE pt.idUtente = ut.id AND ut.idUtilizador = u.id AND u.idPessoa = p.id AND p.identificacao = '" + nif + "'", con);
            con.Close();
            return cmd;
        }

        public MySqlDataReader acedeIDEDataPrescricao(string nif)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT pr.id, pr.data FROM prescricao pr, utente u, utilizador ut, pessoa p WHERE pr.idUtente = u.id AND u.idUtilizador = ut.id AND ut.idPessoa = p.id AND p.identificacao = '" + nif + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public int verificarTerapeutaAcessoPrescricao(string idTerapeuta, string idPrescricao)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT COUNT(*) FROM terapeuta t, utilizador u, pessoa p, terapeuta_tem_prescricao tpr WHERE tpr.idTerapeuta = '" + idTerapeuta + "' AND tpr.idPrescricao = '" + idPrescricao + "' AND tpr.idTerapeuta = t.id AND t.idUtilizador = u.id AND u.idPessoa = p.id", con);
            int count = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return count;
        }

        public void atribuirAcessoTerapeutaPrescricao(string idTerapeuta, string idPrescricao)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("INSERT INTO terapeuta_tem_prescricao VALUES('" + idTerapeuta + "','" + idPrescricao + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public MySqlDataReader acedeConteudoPrescricao(string idPrescricao)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT pr.idUtente, pr.medicamento, pr.tratamento, pr.exercicios, pr.descricao, p.nome, p.sobrenome FROM prescricao pr, utente ut, utilizador u, pessoa p WHERE pr.id = '" + idPrescricao + "' AND pr.idUtente = ut.id AND ut.idUtilizador = u.id AND u.idPessoa = p.id", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeAutorResponsavelPrescricao(string idPrescricao)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT pr.idAutorTerapeuta, p.nome, p.sobrenome FROM  prescricao pr, terapeuta t, utilizador u, pessoa p WHERE pr.id = '" + idPrescricao + "' AND pr.idAutorTerapeuta = t.id AND t.idUtilizador = u.id AND u.idPessoa = p.id", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeTerapeutasDisponiveis(string idTerapeuta)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT t.id, p.nome, p.sobrenome FROM terapeuta t, utilizador u, pessoa p  WHERE t.id <> '" + idTerapeuta + "' AND t.idUtilizador = u.id AND u.idPessoa = p.id ", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
