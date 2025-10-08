using Microsoft.Data.SqlClient; // Biblioteca para conectar com SQL Server
using SistemaAtendimento.Database;
using SistemaAtendimento.View; // Onde está a classe ConexaoDB

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

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Para chamar um formulario (abrir a tela de clientes no sistema)
            FrmCadastroClientes frmCadastroClientes = new FrmCadastroClientes();
            frmCadastroClientes.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //programação do botão sair, para sair da tela atual(fecha a tela)
            Application.Exit();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //para chamar o formulario (abrir a tela de usuarios no sistema)
            FrmCadastroUsuario frmCadastroUsuario = new FrmCadastroUsuario();
            frmCadastroUsuario.ShowDialog();
        }

        private void etapasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //para chamar o formulario (abrir a tela de etapas no sistema)
            FrmCadastroEtapa frmCadastroEtapa = new FrmCadastroEtapa();
            frmCadastroEtapa.ShowDialog();
        }

        private void statusAtendimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //para chamar o formulario (abrir a tela de sistema atendimento no sistema)
            FrmCadastroSituacaoAtendimento frmCadastroSituacaoAtendimento = new FrmCadastroSituacaoAtendimento();
            frmCadastroSituacaoAtendimento.ShowDialog();
        }

        private void novoAtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtendimento frmAtendimento = new FrmAtendimento();
            frmAtendimento.ShowDialog();
        }
    }
}
