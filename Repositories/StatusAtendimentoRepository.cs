using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.Repositories
{
    public class StatusAtendimentoRepository
    {
        public List<StausAtendimentos> Listar(string termo = "")
        {
            var lista = new List<StausAtendimentos>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM situacao_atendimentos";

                // Se tiver termo de busca, adiciona o filtro
                if (!string.IsNullOrWhiteSpace(termo))
                {
                    sql += " WHERE nome LIKE @termo OR cor LIKE @termo";
                }

                using (var comando = new SqlCommand(sql, conexao))
                {
                    if (!string.IsNullOrWhiteSpace(termo))
                        comando.Parameters.AddWithValue("@termo", $"%{termo}%");

                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            lista.Add(new StausAtendimentos()
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                Nome = linhas["nome"].ToString(),
                                Cor = linhas["cor"].ToString(),
                                Ativo = Convert.ToBoolean(linhas["ativo"])
                            });
                        }
                    }
                }
            }

            return lista;
        }


        public void Inserir(StausAtendimentos status)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "INSERT INTO situacao_atendimentos (nome, cor, ativo) VALUES (@nome, @cor, @ativo)";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", status.Nome);
                    comando.Parameters.AddWithValue("@cor", status.Cor);
                    comando.Parameters.AddWithValue("@ativo", status.Ativo);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(StausAtendimentos status)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "UPDATE situacao_atendimentos SET nome=@nome, cor=@cor, ativo=@ativo WHERE id=@id";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", status.Id);
                    comando.Parameters.AddWithValue("@nome", status.Nome);
                    comando.Parameters.AddWithValue("@cor", status.Cor);
                    comando.Parameters.AddWithValue("@ativo", status.Ativo);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "DELETE FROM situacao_atendimentos WHERE id=@id";

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
