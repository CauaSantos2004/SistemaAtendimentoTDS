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
    internal class EtapaRepository
    {
        public List<Etapas> Listar(string termo = "")
        {
            var etapas = new List<Etapas>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM etapas";
                if (!string.IsNullOrEmpty(termo))
                {
                    sql = "SELECT * FROM etapas WHERE nome LIKE @termo";
                }

                using (var comando = new SqlCommand(sql, conexao))
                {
                    if (!string.IsNullOrEmpty(termo))
                    {
                        comando.Parameters.AddWithValue("@termo", $"%{termo}%");
                    }

                    conexao.Open();
                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            etapas.Add(new Etapas()
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                Nome = linhas["nome"].ToString(),
                                Ordem = linhas["ordem"].ToString(),
                                Ativo = Convert.ToBoolean(linhas["ativo"])
                            });
                        }
                    }
                }
            }

            return etapas;
        }

        public void Inserir(Etapas etapas)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "INSERT INTO etapas (nome, ordem, ativo) VALUES (@nome, @ordem, @ativo)";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", etapas.Nome);
                    comando.Parameters.AddWithValue("@ordem", etapas.Ordem);
                    comando.Parameters.AddWithValue("@ativo", etapas.Ativo);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Etapas etapa)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "UPDATE etapas SET nome = @nome, ordem = @ordem, ativo = @ativo WHERE id = @id";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", etapa.Id);
                    comando.Parameters.AddWithValue("@nome", etapa.Nome);
                    comando.Parameters.AddWithValue("@ordem", etapa.Ordem);
                    comando.Parameters.AddWithValue("@ativo", etapa.Ativo);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "DELETE FROM etapas WHERE id=@id";
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
