using SistemaAtendimento.Database;
using SistemaAtendimento.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace SistemaAtendimento.Repositories
{
    public class UsuarioRepository
    {
        public List<Usuarios> Listar()
        {
            var usuarios = new List<Usuarios>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM usuarios";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();
                    using (var leitor = comando.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            usuarios.Add(new Usuarios
                            {
                                Id = Convert.ToInt32(leitor["id"]),
                                Nome = leitor["nome"].ToString(),
                                Email = leitor["email"].ToString(),
                                Senha = leitor["senha"].ToString(),
                                Perfil = leitor["perfil"].ToString(),
                            });
                        }
                    }
                }
            }

            return usuarios;
        }

        public void Inserir(Usuarios usuario)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "INSERT INTO usuarios (Nome, Email, Senha, Perfil) VALUES (@Nome, @Email, @Senha, @Perfil)";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                    comando.Parameters.AddWithValue("@Email", usuario.Email);
                    comando.Parameters.AddWithValue("@Senha", usuario.Senha);
                    comando.Parameters.AddWithValue("@Perfil", usuario.Perfil);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }

            }
        }

        public void Atualizar(Usuarios usuario)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "UPDATE usuarios SET nome=@nome, email=@email, senha=@senha, perfil=@perfil, ativo=@ativo WHERE id=@id";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", usuario.Id);
                    comando.Parameters.AddWithValue("@nome", usuario.Nome);
                    comando.Parameters.AddWithValue("@email", usuario.Email);
                    comando.Parameters.AddWithValue("@senha", usuario.Senha);
                    comando.Parameters.AddWithValue("@perfil", usuario.Perfil);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "DELETE FROM usuarios WHERE id=@id";
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
