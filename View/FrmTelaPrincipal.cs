using Microsoft.Data.SqlClient; // Biblioteca para conectar com SQL Server
using SistemaAtendimento.Database; // Onde está a classe ConexaoDB

namespace SistemaAtendimento // Nome do projeto
{
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal() // Quando essa tela for aberta, o sistema monta todos os botões e elementos visuais
        {
            InitializeComponent(); //incializa os componentes do formulário
        }

        // Esse é o código que roda quando o botão "Conectar" é clicado
        private void btnConexao_Click(object sender, EventArgs e)
        {
            try // Aqui o sistema vai tentar se conectar ao banco de dados
            {
                // Tenta abrir a conexão com o banco de dados
                using (SqlConnection conexao = ConexaoDB.GetConexao()) 
                { 
                    conexao.Open();
                    MessageBox.Show("Conexão Realizada com sucesso!."); // Se não der erro, mostra mensagem de sucesso
                }
            }
            catch (Exception ex) // Se der algum erro ao tentar se conectar
            {
                MessageBox.Show("Erro ao conectar:" + ex.Message); // Se der erro, mostra mensagem de erro com detalhes
            }
        }
    }
}
