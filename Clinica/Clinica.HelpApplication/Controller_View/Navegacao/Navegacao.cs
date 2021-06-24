using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.HelpApplication.Controller_View.Navegacao
{
    class Navegacao
    {
        public void getFormulario(Form formOrigem, string formDestino, string nif)
        {
            switch (formDestino)
            {
                //Admin
                case ("formAdmin"):
                    {
                        var formAdmin = new FormAdmin(nif);
                        formOrigem.Hide();
                        formAdmin.Show();
                        break;
                    }
                case ("formAddPessoa"):
                    {
                        var formAddPessoa = new FormAddPessoa(nif);
                        formOrigem.Hide();
                        formAddPessoa.Show();
                        break;
                    }
                case ("formAddUser"):
                    {
                        var formAddUser = new FormAddUser(nif);
                        formOrigem.Hide();
                        formAddUser.Show();
                        break;
                    }
                case ("formAtualizaFuncoesUser"):
                    {
                        var formAtualizaFuncoesUser = new FormAtualizaFuncoesUser(nif);
                        formOrigem.Hide();
                        formAtualizaFuncoesUser.Show();
                        break;
                    }
                case ("formListarPessoas"):
                    {
                        var formListarPessoas = new FormListarPessoas(nif);
                        formOrigem.Hide();
                        formListarPessoas.Show();
                        break;
                    }
                case ("formListaUsers"):
                    {
                        var formListaUsers = new FormListaUsers(nif);
                        formOrigem.Hide();
                        formListaUsers.Show();
                        break;
                    }
                //Terapeuta
                case ("formTerapeuta"):
                    {
                        var formTerapeuta = new FormTerapeuta(nif);
                        formOrigem.Hide();
                        formTerapeuta.Show();
                        break;
                    }
                case ("formCriarMedTraExer"):
                    {
                        var formCriarMedTraExer = new FormCriarMedTraExer(nif);
                        formOrigem.Hide();
                        formCriarMedTraExer.Show();
                        break;
                    }
                case ("formCriarPrescricao"):
                    {
                        var formCriarPrescricao = new FormCriarPrescricao(nif);
                        formOrigem.Hide();
                        formCriarPrescricao.Show();
                        break;
                    }
                case ("formHistoricoPrescricoes"):
                    {
                        var formHistoricoPrescricoes = new FormHistoricoPrescricoes(nif);
                        formOrigem.Hide();
                        formHistoricoPrescricoes.Show();
                        break;
                    }
                case ("formPlanoTratamento"):
                    {
                        var formPlanoTratamento = new FormPlanoTratamento(nif);
                        formOrigem.Hide();
                        formPlanoTratamento.Show();
                        break;
                    }
                case ("formSessaoTratamento"):
                    {
                        var formSessaoTratamento = new FormSessaoTratamento(nif);
                        formOrigem.Hide();
                        formSessaoTratamento.Show();
                        break;
                    }
                //Utente
                case ("formUtente"):
                    {
                        var formUtente = new FormUtente(nif);
                        formOrigem.Hide();
                        formUtente.Show();
                        break;
                    }
                case ("formAtribuirTerapeuta"):
                    {
                        var formAtribuirTerapeuta = new FormAtribuirTerapeuta(nif);
                        formOrigem.Hide();
                        formAtribuirTerapeuta.Show();
                        break;
                    }
                case ("formHistoricoUtentes"):
                    {
                        var formHistoricoUtentes = new FormHistoricoUtentes(nif);
                        formOrigem.Hide();
                        formHistoricoUtentes.Show();
                        break;
                    }
                case ("formPlanoTratamentoUtente"):
                    {
                        var formPlanoTratamentoUtente = new FormPlanoTratamentoUtente(nif);
                        formOrigem.Hide();
                        formPlanoTratamentoUtente.Show();
                        break;
                    }
                case ("formTratamentosRealizados"):
                    {
                        var formTratamentosRealizados = new FormTratamentosRealizados(nif);
                        formOrigem.Hide();
                        formTratamentosRealizados.Show();
                        break;
                    }
                //Autenticacao
                case ("formLogin"):
                    {
                        var formLogin = new FormLogin();
                        formOrigem.Hide();
                        formLogin.Show();
                        break;
                    }
                case ("formLoginVoltarAtras"):
                    {
                        var formLogin = new FormLogin(1, nif);
                        formOrigem.Hide();
                        formLogin.Show();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Esse formulário não existe");
                        break;
                    }
            }
        }
    }
}
