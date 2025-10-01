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
        public List<StatusAtendimento> Listar()
        {
            var lista = new List<StatusAtendimento>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM status_atendimento";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            lista.Add(new StatusAtendimento()
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

        public void Inserir(StatusAtendimento status)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "INSERT INTO status_atendimento (nome, cor, ativo) VALUES (@nome, @cor, @ativo)";

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

        public void Atualizar(StatusAtendimento status)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "UPDATE status_atendimento SET nome=@nome, cor=@cor, ativo=@ativo WHERE id=@id";

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
                string sql = "DELETE FROM status_atendimento WHERE id=@id";

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
