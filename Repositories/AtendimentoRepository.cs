using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Repositories
{
    public class AtendimentoRepository
    {
        public AtendimentoRepository() { }

        // MÉTODO PARA LISTAR OS ATENDIMENTOS
        // Retorna uma lista contendo todos os atendimentos cadastrados no banco.
        // Pode também filtrar por termo e condição (ex: código, nome do cliente ou CPF/CNPJ).
        public List<Atendimentos> Listar(string termo = "", string condicao = "")
        {
            // Cria uma lista vazia que depois vai receber os objetos "Atendimentos" vindos do banco.
            var lista = new List<Atendimentos>();

            // "using" garante que a conexão será fechada automaticamente após o uso.
            using (var conexao = ConexaoDB.GetConexao())
            {
                // Comando SQL base que busca informações dos atendimentos e também junta dados
                // relacionados (cliente, usuário e situação).
                string sql = @"SELECT a.*, 
                                      c.nome AS cliente_nome, 
                                      s.nome AS situacao_nome, 
                                      u.nome AS usuario_nome, 
                                      c.cpf_cnpj
                               FROM atendimentos a
                               INNER JOIN clientes c ON c.id = a.cliente_id
                               INNER JOIN usuarios u ON u.id = a.usuario_id
                               INNER JOIN situacao_atendimentos s ON s.id = a.situacao_atendimento_id";

                // Se o usuário digitou algo para pesquisar, adiciona um filtro ao SQL.
                if (!string.IsNullOrEmpty(termo) && !string.IsNullOrEmpty(condicao))
                {
                    if (condicao == "Código do Atendimento")
                    {
                        sql += " WHERE a.id = @termo";
                    }
                    else if (condicao == "Nome do Cliente")
                    {
                        sql += " WHERE c.nome LIKE '%' + @termo + '%'";
                    }
                    else
                    {
                        sql += " WHERE c.cpf_cnpj = @termo";
                    }
                }

                using (var comando = new SqlCommand(sql, conexao))
                {
                    if (!string.IsNullOrEmpty(termo))
                    {
                        comando.Parameters.AddWithValue("@termo", termo);
                    }

                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            lista.Add(new Atendimentos
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                ClienteId = Convert.ToInt32(linhas["cliente_id"]),
                                UsuarioId = Convert.ToInt32(linhas["usuario_id"]),
                                DataAbertura = Convert.ToDateTime(linhas["data_abertura"]),
                                DataFechamento = Convert.ToDateTime(linhas["data_fechamento"]),
                                Observacao = linhas["observacao"].ToString(),
                                SituacaoAtendimentoId = Convert.ToInt32(linhas["situacao_atendimento_id"]),
                                ClienteNome = linhas["cliente_nome"].ToString(),
                                SituacaoAtendimentoNome = linhas["situacao_nome"].ToString(),
                                UsuarioNome = linhas["usuario_nome"].ToString()
                            });
                        }
                    }
                }
                return lista;
            }
        }

        // void porque o método inserir não retorna nada, só adiciona
        public void Inserir(Atendimentos atendimento)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"INSERT INTO atendimentos 
                               (cliente_id, usuario_id, data_abertura, data_fechamento, observacao, situacao_atendimento_id) 
                               VALUES (@cliente_id, @usuario_id, @data_abertura, @data_fechamento, @observacao, @situacao_atendimento_id)";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@cliente_id", atendimento.ClienteId);
                    comando.Parameters.AddWithValue("@usuario_id", atendimento.UsuarioId);
                    comando.Parameters.AddWithValue("@data_abertura", atendimento.DataAbertura);
                    comando.Parameters.AddWithValue("@data_fechamento", atendimento.DataFechamento);
                    comando.Parameters.AddWithValue("@observacao", atendimento.Observacao);
                    comando.Parameters.AddWithValue("@situacao_atendimento_id", atendimento.SituacaoAtendimentoId);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Atendimentos atendimento)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"UPDATE atendimento 
                               SET cliente_id = @cliente_id, 
                                   usuario_id = @usuario_id, 
                                   data_abertura = @data_abertura, 
                                   data_fechamento = @data_fechamento, 
                                   observacao = @observacao, 
                                   situacao_atendimento_id = @situacao_atendimento_id
                               WHERE id = @id";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", atendimento.Id);
                    comando.Parameters.AddWithValue("@cliente_id", atendimento.ClienteId);
                    comando.Parameters.AddWithValue("@usuario_id", atendimento.UsuarioId);
                    comando.Parameters.AddWithValue("@data_abertura", atendimento.DataAbertura);
                    comando.Parameters.AddWithValue("@data_fechamento", atendimento.DataFechamento);
                    comando.Parameters.AddWithValue("@observacao", atendimento.Observacao);
                    comando.Parameters.AddWithValue("@situacao_atendimento_id", atendimento.SituacaoAtendimentoId);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "DELETE FROM atendimentos WHERE id = @id";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }

}
