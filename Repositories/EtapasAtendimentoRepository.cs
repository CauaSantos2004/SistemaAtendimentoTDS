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
    public class EtapasAtendimentoRepository
    {
        // Cria a Lista de etapas de atendimento
        public List<EtapasAtendimentos> Listar(int atendimentoId)
        {

            var etapasAtendimento = new List<EtapasAtendimentos>(); //variavel para armazenar a lista

            using (var conexao = ConexaoDB.GetConexao())  // Craia a variavel de conexao com o banco de dados
            {
                //comando SQL para selecionar as etapas de atendimento pelo ID do atendimento
                string sql = @"SELECT * FROM etapa_atendimentos WHERWE 
                                atendimento_id = @atendimentoId";

                using (var comando = new SqlCommand(sql, conexao)) //cria o comando SQL
                {
                    comando.Parameters.AddWithValue("@atendimentoId", atendimentoId); // adciona o parametro que é o ID do atendimento ao comando SQL

                    conexao.Open(); //abre a conexao com o banco de dados   

                    
                    using (var linhas = comando.ExecuteReader()) //executa o comando SQL e retorna as linhas encontradas
                    {
                        //Percorre as linhas retornadas e adiciona na lista
                        while (linhas.Read())
                        {
                            etapasAtendimento.Add(new EtapasAtendimentos()
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                AtendimentoId = Convert.ToInt32(linhas["atendimento_id"]),
                                EtapaId = Convert.ToInt32(linhas["etapa_id"]),
                                UsuarioId = Convert.ToInt32(linhas["usuario_id"]),
                                DataCadastro = (linhas["data_cadastro"] as DateTime?),
                                Observacao = linhas["observacao"].ToString()
                            });                        
                        }
                    }
                }

                    return etapasAtendimento; //retornar a lista

            }
        }

        // Método para inserir uma nova etapa de atendimento
        public void Inserir(EtapasAtendimentos etapasAtendimentos)
        {
            
            using (var conexao = ConexaoDB.GetConexao()) // Cria a variavel de conexao com o banco de dados 
            {
                //comando SQL para inserir uma nova etapa de atendimento
                string sql = @"INSERT INTO atendimento_id, etapa_id, usuario_id, etapa_atendimentos (data_cadastro, observacao) 
                               VALUES (@data_cadastro, @observacao)";

                using(var comando = new SqlCommand(sql, conexao)) // cria o comando SQL
                {
                    //adiciona os parametros ao comando SQL
                    comando.Parameters.AddWithValue("@data_cadastro", etapasAtendimentos.DataCadastro);
                    comando.Parameters.AddWithValue("@observacao", etapasAtendimentos.Observacao);

                    conexao.Open(); //abre a conexao com o banco de dados
                    comando.ExecuteNonQuery(); //executa o comando SQL
                }
            }
        }


        // Método para excluir uma etapa de atendimento
        public void Excluir(int id)
        {
            using(var conexao = ConexaoDB.GetConexao()) // Cria a variavel de conexao com o banco de dados 
            {
                // comando SQL para excluir uma etapa de atendimento pelo ID
                string sql = "DELETE FROM etapa_atendimentos WHERE id=@id";

                using (var comando = new SqlCommand(sql, conexao)) // cria o comando SQL
                {
                    comando.Parameters.AddWithValue("@id", id); // adiciona o parametro ID ao comando SQL

                    conexao.Open(); //abre a conexao com o banco de dados
                    comando.ExecuteNonQuery(); //executa o comando SQL
                }
            }
        }






    }
}
