using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;
using SistemaAtendimento.Model.SistemaAtendimento.Model;

namespace SistemaAtendimento.Repositories
{
    public class AtendimentoRepository
    {
        // Método que busca atendimentos no banco.
        // Pode retornar todos os atendimentos ou aplicar um filtro (termo + condição).
        public List<Atendimentos> Listar(string termo = "", string condicao = "")
        {
            // Criamos a lista que vai armazenar os atendimentos encontrados.
            var lista = new List<Atendimentos>();

            // Abre a conexão com o banco. "using" garante que a conexão será fechada no final.
            using (var conexao = ConexaoDB.GetConexao())
            {
                // Montamos a consulta SQL principal.
                // Ela busca dados da tabela 'atendimentos' e traz também informações
                // do cliente, do usuário e da situação para mostrar no grid.
                string sql = @"SELECT 
                                a.*, 
                                c.nome AS cliente_nome, 
                                s.nome AS situacao_nome, 
                                u.nome AS usuario_nome, 
                                c.cpf_cnpj 
                           FROM atendimentos a
                           INNER JOIN clientes c ON c.id = a.cliente_id
                           INNER JOIN usuarios u ON u.id = a.usuario_id
                           INNER JOIN situacao_atendimentos s ON s.id = a.situacao_atendimento_id";

                // Observação:
                // Aqui usamos a.* para trazer todas as colunas da tabela "atendimentos".
                // Também pegamos algumas colunas específicas das tabelas relacionadas usando alias.
                // Se tiver conflito de nomes de coluna (por exemplo "id" em outras tabelas),
                // o importante é garantir que o leitor acesse a coluna correta ao ler os dados.

                // Se o usuário digitou algo no campo de busca e escolheu uma condição no combo,
                // vamos acrescentar um WHERE apropriado à consulta.
                if (!string.IsNullOrEmpty(termo) && !string.IsNullOrEmpty(condicao))

                // Esse if foi colocado para só aplicar filtro quando houver realmente termo + condição.
                // Assim evitamos adicionar WHERE vazio e problemas na execução.
                {
                    // Se o filtro for por código do atendimento, buscamos igual ao ID.
                    if (condicao == "Código do Atendimento")
                    {
                        // filtro exato por id (numérico)
                        sql += " WHERE a.id = @termo"; //foi adicionado isso
                    }
                    // Se o filtro for pelo nome do cliente, usamos LIKE para buscar por partes do nome.
                    else if (condicao == "Nome do Cliente")
                    {
                        // LIKE permite que o usuário digite apenas parte do nome (ex: "jo" encontra "João")
                        sql += " WHERE c.nome LIKE @termo"; //foi adicionado isso (LIKE corrigido)
                    }
                    // Senão, assumimos que o filtro é por CPF ou CNPJ (campo único na tabela de clientes).
                    else
                    {
                        // Também usamos LIKE para procurar por partes do CPF/CNPJ.
                        sql += " WHERE c.cpf_cnpj LIKE @termo"; //foi adicionado isso (LIKE aplicado também ao CPF/CNPJ)
                    }
                }

                // Criamos o comando SQL com a query montada.
                using (var comando = new SqlCommand(sql, conexao))
                {
                    // Se houver termo e condição, adicionamos o parâmetro @termo de forma adequada.
                    if (!string.IsNullOrEmpty(termo) && !string.IsNullOrEmpty(condicao))
                    // Verificação para só adicionar parâmetro quando realmente necessário.
                    {
                        // Se for busca por código (ID), precisamos garantir que o termo é um número.
                        if (condicao == "Código do Atendimento")
                        {
                            // Tenta converter o termo para inteiro. Se for válido, passa como parâmetro numérico.
                            if (int.TryParse(termo, out int codigo))
                            // Isso evita erro se o usuário digitar texto quando a condição é numérica.
                            {
                                comando.Parameters.AddWithValue("@termo", codigo); //foi adicionado isso
                            }
                        }
                        else
                        {
                            // Para nome ou CPF/CNPJ usamos %termo% para pesquisar por parte do texto.
                            // Colocamos os '%' no parâmetro, não na string SQL, para manter segurança.
                            comando.Parameters.AddWithValue("@termo", "%" + termo + "%");
                            //foi adicionado isso (uso correto do LIKE com % no parâmetro)
                        }
                    }

                    // Abre a conexão para executar a consulta.
                    conexao.Open();

                    // Executa a consulta e obtém um leitor para percorrer os resultados.
                    using (var linhas = comando.ExecuteReader())
                    {
                        // Enquanto houver linhas no resultado, lemos uma por uma.
                        while (linhas.Read())
                        {
                            // Cada linha vira um objeto Atendimentos que será adicionado na lista.
                            lista.Add(new Atendimentos
                            {
                                // Preenche os campos do objeto com os valores vindos do banco.
                                // Convert.ToInt32 e as conversões garantem o tipo correto.
                                Id = Convert.ToInt32(linhas["id"]),
                                ClienteId = Convert.ToInt32(linhas["cliente_id"]),
                                UsuarioId = Convert.ToInt32(linhas["usuario_id"]),
                                // Datas podem ser nulas no banco, por isso usamos 'as DateTime?'.
                                DataAbertura = linhas["data_abertura"] as DateTime?, //foi adicionado isso (simplificação no cast)
                                DataFechamento = linhas["data_fechamento"] as DateTime?, //foi adicionado isso (simplificação no cast)
                                Observacao = linhas["observacao"].ToString(),
                                SituacaoAtendimentoId = Convert.ToInt32(linhas["situacao_atendimento_id"]),
                                // Esses campos vieram dos JOINs e foram renomeados com 'AS' no SELECT.
                                ClienteNome = linhas["cliente_nome"].ToString(), //foi adicionado isso (nome da propriedade ajustado)
                                SituacaoAtendimentoNome = linhas["situacao_nome"].ToString(), //foi adicionado isso
                                UsuarioNome = linhas["usuario_nome"].ToString(), //foi adicionado isso
                                Cpf_Cnpj = linhas["cpf_cnpj"].ToString(), //foi adicionado isso
                            });
                        }
                    }
                }
            }
            // Retorna a lista com todos os atendimentos encontrados (ou vazia, se nada for encontrado).
            return lista;
        }


        // Método para buscar um atendimento específico pelo ID.
        public Atendimentos BuscarPorId(int id)
        {
            var resultado = Listar(id.ToString(), "Código do Atendimento"); //reutiliza o método Listar para buscar por ID
            return resultado.FirstOrDefault(); //retorna o primeiro resultado ou null se não encontrar
        }


        // Método para inserir um novo atendimento no banco.
        // Recebe um objeto 'Atendimentos' preenchido e salva os dados na tabela.
        public void Inserir(Atendimentos atendimentos)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"INSERT INTO atendimentos 
                               (cliente_id, usuario_id, data_abertura, observacao, situacao_atendimento_id)
                               VALUES (@cliente_id, @usuario_id, @data_abertura, @observacao, @situacao_atendimento_id)";

                // Observação:
                // O SQL acima não altera nada do objeto, apenas define quais colunas serão inseridas.
                // Os parâmetros são preenchidos logo abaixo.

                using (var comando = new SqlCommand(sql, conexao))
                {
                    // Associamos cada parâmetro ao valor vindo do objeto 'atendimentos'.
                    comando.Parameters.AddWithValue("@cliente_id", atendimentos.ClienteId);
                    comando.Parameters.AddWithValue("@usuario_id", atendimentos.UsuarioId);
                    comando.Parameters.AddWithValue("@data_abertura", atendimentos.DataAbertura);
                    comando.Parameters.AddWithValue("@observacao", atendimentos.Observacao);
                    comando.Parameters.AddWithValue("@situacao_atendimento_id", atendimentos.SituacaoAtendimentoId);

                    // Abre a conexão e executa o INSERT.
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Método para atualizar um atendimento já existente.
        // Recebe o objeto 'Atendimentos' com ID preenchido e atualiza os campos no banco.
        public void Atualizar(Atendimentos atendimentos)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"UPDATE atendimentos SET
                               cliente_id = @cliente_id,
                               usuario_id = @usuario_id, //foi adicionado isso (corrigido de @usuarios_id)
                               data_abertura = @data_abertura,
                               data_fechamento = @data_fechamento,
                               observacao = @observacao,
                               situacao_atendimento_id = @situacao_atendimento_id
                               WHERE id = @id"; //foi adicionado isso (WHERE confirmado)

                // Observação:
                // O WHERE id = @id é essencial aqui para garantir que apenas o registro certo seja atualizado.

                using (var comando = new SqlCommand(sql, conexao))
                {
                    // Preenche os parâmetros com os valores do objeto.
                    comando.Parameters.AddWithValue("@cliente_id", atendimentos.ClienteId);
                    comando.Parameters.AddWithValue("@usuario_id", atendimentos.UsuarioId);
                    comando.Parameters.AddWithValue("@data_abertura", atendimentos.DataAbertura);
                    comando.Parameters.AddWithValue("@data_fechamento", atendimentos.DataFechamento);
                    comando.Parameters.AddWithValue("@observacao", atendimentos.Observacao);
                    comando.Parameters.AddWithValue("@situacao_atendimento_id", atendimentos.SituacaoAtendimentoId);
                    comando.Parameters.AddWithValue("@id", atendimentos.Id); //foi adicionado isso (parâmetro posicionado corretamente)

                    // Abre a conexão e executa o UPDATE.
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Método para excluir um atendimento pelo ID.
        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                // Comando para remover o registro com o id especificado.
                string sql = "DELETE FROM atendimentos WHERE id=@id";

                // Observação:
                // Tenha cuidado ao usar DELETE — certifique-se de que o id passado é o correto.
                // Em sistemas reais, às vezes preferimos marcar como "inativo" ao invés de apagar.

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
