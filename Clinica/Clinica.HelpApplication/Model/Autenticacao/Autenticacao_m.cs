using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Clinica.HelpApplication.Model.Autenticacao
{
    public class Autenticacao_m
    {

        public MySqlDataReader getUtilizadorLogin(string nif, string password)
        {
            int nif1 = int.Parse(nif) ; //solução temporaria
            //bool hasrows = false; 
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlConnection cn = new MySqlConnection(strConnection);
            cn.Open(); //abre conexao
            MySqlCommand command = new MySqlCommand();
            command.Connection = cn;
            command.CommandText = "SELECT d.password, d.bTerapeuta, d.bUtente, d.bAdmin, d.idPessoa, p.identificacao FROM utilizador d " +
                                  "JOIN pessoa p WHERE p.id = d.idPessoa AND p.identificacao = '"+nif1+"' AND d.password = '"+password+"'";
            MySqlDataReader reader = command.ExecuteReader();
            //command.Connection.Close();  //Fecha conexao
            return reader;
        }

        public MySqlDataReader getUtilizadorLogin(string nif)
        {
            int nif1 = int.Parse(nif); //solução temporaria
            //bool hasrows = false; 
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlConnection cn = new MySqlConnection(strConnection);
            cn.Open(); //abre conexao
            MySqlCommand command = new MySqlCommand();
            command.Connection = cn;
            command.CommandText = "SELECT d.password, d.bTerapeuta, d.bUtente, d.bAdmin, d.idPessoa, p.identificacao FROM utilizador d " +
                                  "JOIN pessoa p WHERE p.id = d.idPessoa AND p.identificacao = '" + nif1 + "'";
            MySqlDataReader reader = command.ExecuteReader();
            //command.Connection.Close();  //Fecha conexao
            return reader;
        }

        public int verificaFuncoesUtilizador(string funcao, string nif)
        {
            string strConnection = @"server=Localhost;user id=root;database=clinica;password=";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(strConnection);
            string bU, bT, bA;
            con.Open();
            cmd = new MySqlCommand("SELECT * FROM utilizador u, pessoa p WHERE p.identificacao = '" + nif + "' AND p.id = u.idPessoa", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            bU = reader.GetString("bUtente");
            bT = reader.GetString("bTerapeuta");
            bA = reader.GetString("bAdmin");
            con.Close();
            if(funcao == "admin")
            {
                if (!(bU == "1" || bT == "1"))
                {
                    return 1;
                }
                return 0;
            }
            else if(funcao == "utente")
            {
                if (!(bA == "1" || bT == "1"))
                {
                    return 1;
                }
                return 0;
            }
            else if (funcao == "terapeuta")
            {
                if (!(bA == "1" || bU == "1"))
                {
                    return 1;
                }
                return 0;
            }
            else
            {
                return 0;
            }
        }

    }
}
