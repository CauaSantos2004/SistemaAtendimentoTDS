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
        public List<Atendimentos> Listar(string termo = "", string condicao = "")
        {
            var lista = new List<Atendimentos>();
            using (var conexao = ConexaoDB.GetConexao())
            {
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

                //foi adicionado isso (SELECT simplificado e campos duplicados removidos)

                if (!string.IsNullOrEmpty(termo) && !string.IsNullOrEmpty(condicao))

                //foi adicionado isso (condição corrigida — agora só entra se termo e condicao tiverem valor)
                {
                    if (condicao == "Código do Atendimento")
                    {
                        sql += " WHERE a.id = @termo"; //foi adicionado isso
                    }
                    else if (condicao == "Nome do Cliente")
                    {
                        sql += " WHERE c.nome LIKE @termo"; //foi adicionado isso (LIKE corrigido)
                    }
                    else
                    {
                        sql += " WHERE c.cpf_cnpj LIKE @termo"; //foi adicionado isso (LIKE aplicado também ao CPF/CNPJ)
                    }
                }

                using (var comando = new SqlCommand(sql, conexao))
                {
                    if (!string.IsNullOrEmpty(termo) && !string.IsNullOrEmpty(condicao))
                    //foi adicionado isso (verificação correta antes de adicionar parâmetro)
                    {
                        if (condicao == "Código do Atendimento")
                        {
                            if (int.TryParse(termo, out int codigo))
                            //foi adicionado isso (validação do termo numérico para evitar erro)
                            {
                                comando.Parameters.AddWithValue("@termo", codigo); //foi adicionado isso
                            }
                        }
                        else
                        {
                            comando.Parameters.AddWithValue("@termo", "%" + termo + "%");
                            //foi adicionado isso (uso correto do LIKE com % no parâmetro)
                        }
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
                                DataAbertura = linhas["data_abertura"] as DateTime?, //foi adicionado isso (simplificação no cast)
                                DataFechamento = linhas["data_fechamento"] as DateTime?, //foi adicionado isso (simplificação no cast)
                                Observacao = linhas["observacao"].ToString(),
                                SituacaoAtendimentoId = Convert.ToInt32(linhas["situacao_atendimento_id"]),
                                ClienteNome = linhas["cliente_nome"].ToString(), //foi adicionado isso (nome da propriedade ajustado)
                                SituacaoAtendimentoNome = linhas["situacao_nome"].ToString(), //foi adicionado isso
                                UsuarioNome = linhas["usuario_nome"].ToString(), //foi adicionado isso
                                Cpf_Cnpj = linhas["cpf_cnpj"].ToString(), //foi adicionado isso
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public void Inserir(Atendimentos atendimentos)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"INSERT INTO atendimentos 
                               (cliente_id, usuario_id, data_abertura, data_fechamento, observacao, situacao_atendimento_id)
                               VALUES (@cliente_id, @usuario_id, @data_abertura, @data_fechamento, @observacao, @situacao_atendimento_id)";

                //foi adicionado isso (ajuste na formatação e padronização do SQL)

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@cliente_id", atendimentos.ClienteId);
                    comando.Parameters.AddWithValue("@usuario_id", atendimentos.UsuarioId);
                    comando.Parameters.AddWithValue("@data_abertura", atendimentos.DataAbertura);
                    comando.Parameters.AddWithValue("@data_fechamento", atendimentos.DataFechamento);
                    comando.Parameters.AddWithValue("@observacao", atendimentos.Observacao);
                    comando.Parameters.AddWithValue("@situacao_atendimento_id", atendimentos.SituacaoAtendimentoId);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

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

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@cliente_id", atendimentos.ClienteId);
                    comando.Parameters.AddWithValue("@usuario_id", atendimentos.UsuarioId);
                    comando.Parameters.AddWithValue("@data_abertura", atendimentos.DataAbertura);
                    comando.Parameters.AddWithValue("@data_fechamento", atendimentos.DataFechamento);
                    comando.Parameters.AddWithValue("@observacao", atendimentos.Observacao);
                    comando.Parameters.AddWithValue("@situacao_atendimento_id", atendimentos.SituacaoAtendimentoId);
                    comando.Parameters.AddWithValue("@id", atendimentos.Id); //foi adicionado isso (parâmetro posicionado corretamente)

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "DELETE FROM atendimentos WHERE id=@id";

                //foi adicionado isso (corrigido nome da tabela de atendimento → atendimentos)

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