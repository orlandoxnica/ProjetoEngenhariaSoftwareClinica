using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Clinica.HelpApplication.Model.Admin
{
    class Admin_m
    {
        public void criaPessoa(string nome, string nif, string nascimento, string contacto, string sobrenome, string morada)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("insert into pessoa values('" + null + "','" + nome + "','" + nif + "','" + nascimento + "','" + contacto + "','" + sobrenome + "', '" + morada + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public MySqlCommand acederPessoas()
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT * FROM pessoa", con);
            return cmd;
        }

        public MySqlCommand acederUtilizadores()
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT * FROM utilizador", con);
            return cmd;
        }

        public void criaUtilizador(string password, int bT, int bU, int bA, int idPessoa)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("insert into utilizador values('" + null + "','" + password + "','" + bT + "', '" + bU + "', '" + bA + "','" + idPessoa + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void procuraIDPessoaEInsereUtente(string idPessoa)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT * FROM utilizador WHERE idPessoa = '" + idPessoa + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string idU = reader.GetString("id");
            reader.Close();
            cmd = new MySqlCommand("insert into utente values('" + null + "','" + idU + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void procuraIDPessoaEInsereTerapeuta(string idPessoa)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT * FROM utilizador WHERE idPessoa = '" + idPessoa + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string idU = reader.GetString("id");
            reader.Close();
            cmd = new MySqlCommand("insert into terapeuta values('" + null + "','" + idU + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public MySqlDataReader acedeIDUtilizadorENomeCompletoDaPessoa()
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT u.id, p.nome, p.sobrenome FROM utilizador u, pessoa p WHERE u.idPessoa = p.id", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeUtilizadorEspecifico(string idUtilizador)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT * FROM utilizador WHERE id = '" + idUtilizador + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public void atualizaFuncoesUtilizador(int bA, int bU, int bT, string idUtilizador)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlCommand cmd2 = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            if (bA == 1)
            {

                con.Open();
                cmd = new MySqlCommand("SELECT COUNT(*) FROM utilizador WHERE id = '" + idUtilizador + "' AND bAdmin = '1'", con);
                int count = int.Parse(cmd.ExecuteScalar().ToString());
                if (count == 0)
                {
                    cmd = new MySqlCommand("UPDATE utilizador SET bAdmin = 1 WHERE id = '" + idUtilizador + "'", con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            else
            {
                con.Open();
                cmd = new MySqlCommand("SELECT COUNT(*) FROM utilizador WHERE id = '" + idUtilizador + "'  AND bAdmin = '1'", con);
                int count = int.Parse(cmd.ExecuteScalar().ToString());
                if (count != 0)
                {
                    cmd = new MySqlCommand("UPDATE utilizador SET bAdmin = 0 WHERE id = '" + idUtilizador + "'", con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            if (bU == 1)
            {
                con.Open();
                cmd = new MySqlCommand("SELECT COUNT(*) FROM utilizador WHERE id = '" + idUtilizador + "' AND bUtente = '1'", con);
                int count = int.Parse(cmd.ExecuteScalar().ToString());
                if (count == 0)
                {
                    cmd = new MySqlCommand("insert into utente values('" + null + "','" + int.Parse(idUtilizador) + "')", con);
                    cmd.ExecuteNonQuery();
                    cmd = new MySqlCommand("UPDATE utilizador SET bUtente = 1 WHERE id = '" + idUtilizador + "'", con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            else
            {
                con.Open();
                cmd = new MySqlCommand("SELECT COUNT(*) FROM utente", con);
                int count = int.Parse(cmd.ExecuteScalar().ToString());
                if (count != 0)
                {
                    cmd = new MySqlCommand("DELETE FROM utente WHERE idUtilizador = '" + idUtilizador + "'", con);
                    cmd.ExecuteNonQuery();
                    cmd2 = new MySqlCommand("UPDATE utilizador SET bUtente = 0 WHERE id = '" + idUtilizador + "'", con);
                    cmd2.ExecuteNonQuery();
                }
                con.Close();
            }
            if (bT == 1)
            {
                con.Open();
                cmd = new MySqlCommand("SELECT COUNT(*) FROM utilizador WHERE id = '" + idUtilizador + "' AND bTerapeuta = '1'", con);
                int count = int.Parse(cmd.ExecuteScalar().ToString());
                if (count == 0)
                {
                    cmd = new MySqlCommand("insert into terapeuta values('" + null + "','" + int.Parse(idUtilizador) + "')", con);
                    cmd.ExecuteNonQuery();
                    cmd = new MySqlCommand("UPDATE utilizador SET bTerapeuta = 1 WHERE id = '" + idUtilizador + "'", con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            else
            {
                con.Open();
                cmd = new MySqlCommand("SELECT COUNT(*) FROM terapeuta", con);
                int count = int.Parse(cmd.ExecuteScalar().ToString());
                if (count != 0)
                {
                    cmd = new MySqlCommand("DELETE FROM terapeuta WHERE idUtilizador = '" + idUtilizador + "'", con);
                    cmd.ExecuteNonQuery();
                    cmd2 = new MySqlCommand("UPDATE utilizador SET bTerapeuta = 0 WHERE id = '" + idUtilizador + "'", con);
                    cmd2.ExecuteNonQuery();
                }
                con.Close();
            }
        }


    }
}
