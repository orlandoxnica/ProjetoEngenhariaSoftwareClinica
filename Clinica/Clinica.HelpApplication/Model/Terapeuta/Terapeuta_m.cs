using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Clinica.HelpApplication.Model.Terapeuta
{
    class Terapeuta_m
    {

        public void criaSessaoTratamento(string idTerapeuta, string paciente, string descricao, string data, string medicacao, string tratamento, string exercicio)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("INSERT INTO sessaotratamento VALUES('" + null + "', '" + idTerapeuta + "', '" + paciente + "', '" + descricao + "', '" + data + "', '" + medicacao + "', '" + tratamento + "', '" + exercicio + "')", con);
            cmd.ExecuteNonQuery();
            con.Close(); ;
        }

        public void criaPlanoTratamento(string idUtente, string idTerapeuta, string dataInicio, string dataFim, string tratamento, string horarioMedicacao, string medicamento, string exercicio, string horarioExercicio, string nomeUtente, string sobrenomeUtente, string nomeTerapeuta, string sobrenomeTerapeuta)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("INSERT INTO planotratamento VALUES('" + null + "', '" + idUtente + "', '" + idTerapeuta + "','" + dataInicio + "', '" + dataFim + "', '" + tratamento + "', '" + horarioMedicacao + "', '" + medicamento + "', '" + exercicio + "', '" + horarioExercicio + "', '" + nomeUtente + "', '" + sobrenomeUtente + "','" + nomeTerapeuta + "', '" + sobrenomeTerapeuta + "')", con);
            cmd.ExecuteNonQuery();
            con.Close(); ;
        }

        public void criaPrescricao(string data, string descricao, string idTerapeuta, string idUtente, string nomeUtente, string sobrenomeUtente, string horarioMedicacao, string medicacao, string tratamento, string exercicios, string horarioExercicios, string nomeTerapeuta, string sobrenomeTerapeuta)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("INSERT INTO prescricao VALUES('" + null + "', '" + data + "', '" + descricao + "', '" + idTerapeuta + "', '" + idUtente + "', '" + nomeUtente + "', '" + sobrenomeUtente + "', '" + horarioMedicacao + "', '" + medicacao + "', '" + tratamento + "', '" + exercicios + "', '" + horarioExercicios + "', '" + nomeTerapeuta + "', '" + sobrenomeTerapeuta + "')", con);
            cmd.ExecuteNonQuery();
            con.Close(); ;
        }

        public void criaLigacaoTerapeutaPrescricao(string idTerapeuta, string idPrescricao)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("INSERT INTO terapeuta_tem_prescricao VALUES('" + idTerapeuta + "', '" + idPrescricao + "')", con);
            cmd.ExecuteNonQuery();
            con.Close(); ;
        }

        public void criaMedicamento(string medicamento)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("insert into medicamento values('" + null + "','" + medicamento + "')", con);
            cmd.ExecuteNonQuery();
            con.Close(); ;
        }

        public void criaTratamento(string tratamento)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("insert into tratamento values('" + null + "','" + tratamento + "')", con);
            cmd.ExecuteNonQuery();
            con.Close(); ;
        }

        public void criaExercicio(string exercicio)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("insert into exercicio values('" + null + "','" + exercicio + "')", con);
            cmd.ExecuteNonQuery();
            con.Close(); ;
        }

        public MySqlCommand tratamentosRealizados(string nif)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT st.paciente, st.descricao, st.dataRealizacao, st.MedicacaoUtilizada, st.TipoTratamento, st.ExercicioARealizar FROM terapeuta te, utilizador u, pessoa p, sessaotratamento st WHERE st.Terapeuta_id = te.id AND te.idUtilizador = u.id AND u.idPessoa = p.id AND p.identificacao = '" + nif + "'", con);
            con.Close();
            return cmd;
        }

        public MySqlCommand acedePlanoTratamentoAtribuidos(string nif)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT DISTINCT pt.dataInicioTratamento, pt.dataFimTratamento, pt.Tratamento, pt.horarioMedicacao, pt.medicamentos, pt.exercicios, pt.horarioExercicios, pt.NomeUtenteTratar, pt.SobrenomeUtenteTratar FROM utilizador u, utente ut, pessoa p, planotratamento pt, terapeuta te WHERE pt.Terapeuta_id = te.id AND te.idUtilizador = u.id AND u.idPessoa = p.id AND p.identificacao = '" + nif + "'", con);
            con.Close();
            return cmd;
        }

        public MySqlCommand historicoPrescricoes(string nif)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT pr.id, pr.data, pr.descricao, pr.idUtente, pr.nomeUtente, pr.sobrenomeUtente, pr.horarioMedicacao, pr.medicamento, pr.tratamento, pr.exercicios, pr.horarioexercicios FROM terapeuta_tem_prescricao tpr, pessoa p, prescricao pr, terapeuta t, utilizador u WHERE pr.id = tpr.idPrescricao AND tpr.idTerapeuta = t.id AND t.idUtilizador = u.id AND u.idPessoa = p.id AND p.identificacao = '" + nif + "'", con);
            con.Close();
            return cmd;
        }

        public MySqlCommand pesquisarPrescricaoNIF(string nif)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT pr.id, pr.data, pr.descricao, pr.idUtente, pr.nomeUtente, pr.sobrenomeUtente, pr.horarioMedicacao, pr.medicamento, pr.tratamento, pr.exercicios, pr.horarioexercicios FROM terapeuta_tem_prescricao tpr, pessoa p, prescricao pr, terapeuta t, utilizador u WHERE pr.id = tpr.idPrescricao AND tpr.idTerapeuta = t.id AND t.idUtilizador = u.id AND u.idPessoa = p.id AND p.identificacao = '" + nif + "'", con);
            con.Close();
            return cmd;
        }

        public MySqlDataReader acedeIDTerapeutaENomeCompletoDaPessoaNIF(string nif)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT te.id, p.nome, p.sobrenome FROM utilizador u, pessoa p, terapeuta te WHERE p.identificacao = '" + nif + "' AND u.idPessoa = p.id AND te.idUtilizador=u.id", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeIDUtenteENomeCompletoDaPessoaNIFDiferente(string nif)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT  ut.id, p.nome, p.sobrenome FROM utilizador u, pessoa p, utente ut WHERE u.idPessoa = p.id AND ut.idUtilizador=u.id AND p.identificacao <> '" + nif + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeNomeCompletoUtenteTratar()
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT DISTINCT pt.NomeUtenteTratar, pt.SobrenomeUtenteTratar FROM planotratamento pt", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeMedicacaoUtenteTratar()
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT DISTINCT pt.medicamentos FROM planotratamento pt", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeTratamentoUtenteTratar()
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT DISTINCT pt.tratamento FROM planotratamento pt", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeExerciciosUtenteTratar()
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT DISTINCT pt.exercicios FROM planotratamento pt", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeNomeCompletoUtente()
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT DISTINCT ut.id, p.nome, p.sobrenome FROM pessoa p, utilizador u, utente ut WHERE ut.idUtilizador = u.id AND u.idPessoa = p.id", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeTratamentosPrescricao()
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT DISTINCT pr.tratamento FROM prescricao pr", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeHorarioMedicacaoPrescricao()
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT DISTINCT pr.horarioMedicacao FROM prescricao pr", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeMedicacaoPrescricao()
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT DISTINCT pr.medicamento FROM prescricao pr", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeExerciciosPrescricao()
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT DISTINCT pr.exercicios FROM prescricao pr", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeHorarioExerciciosPrescricao()
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT DISTINCT pr.horarioexercicios FROM prescricao pr", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedePessoas()
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT * FROM pessoa", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeMedicamento()
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT  m.nome FROM medicamento m ", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeTratamento()
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT  t.nome FROM tratamento t ", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeExercicio()
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT  e.nome FROM exercicio e ", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader acedeIDPrescricao(string data, string idUtente, string idAutorTerapeuta)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT id FROM prescricao WHERE data = '" + data + "' AND idUtente = '" + idUtente + "' AND idAutorTerapeuta = '" + idAutorTerapeuta + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public int verificarPrescricaoDataETerapeutaExistentes(string data, string idUtente, string idAutorTerapeuta)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            con.Open();
            cmd = new MySqlCommand("SELECT COUNT(*) FROM prescricao WHERE data = '" + data + "' AND idUtente = '" + idUtente + "' AND idAutorTerapeuta = '" + idAutorTerapeuta + "'", con);
            int count = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return count;
        }
    }
}
