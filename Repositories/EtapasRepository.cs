using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.Repositories
{
    public class EtapasRepository
    {
        public List<Etapas> Listar()
        {
            var etapas = new List<Etapas>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM etapas";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            etapas.Add(new Etapas()
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                Nome = linhas["nome"].ToString(),
                                Ordem = Convert.ToInt32(linhas["ordem"]),
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
                string sql = "INSERT INTO etapas (id, nome, ordem, ativo) VALUES (@id, @nome,ordem,@ativo)";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", etapas.Id);
                    comando.Parameters.AddWithValue("@nome", etapas.Nome);
                    comando.Parameters.AddWithValue("@ordem", etapas.Ordem);
                    comando.Parameters.AddWithValue("@ativo", etapas.Ativo);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

    }
}
