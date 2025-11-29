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
    public class AtendimentoRepository
    {
        //Código do Atendimento
        //Nome do Cliente
        //CPF
        //CNPJ
      
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

                    if (!string.IsNullOrEmpty(termo) && !string.IsNullOrEmpty(condicao))
                    {
                        if (condicao == "Código do Atendimento")
                        {
                            sql += " WHERE a.id = @termo";
                        }
                        else if (condicao == "Nome do Cliente")
                        {
                            sql += " WHERE c.nome LIKE @termo";
                        }
                        else 
                        {
                            sql += " WHERE c.cpf_cnpj LIKE @termo";
                        }
                    }

                    using (var comando = new SqlCommand(sql, conexao))
                    {
                        if (!string.IsNullOrEmpty(termo) && !string.IsNullOrEmpty(condicao))
                        {
                            if (condicao == "Código do Atendimento")
                            {
                                if (int.TryParse(termo, out int codigo))
                                {
                                    comando.Parameters.AddWithValue("@termo", codigo);
                                }                                
                            }
                            else 
                            {
                               comando.Parameters.AddWithValue("@termo", "%" + termo + "%");
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
                                    DataAbertura = linhas["data_abertura"] as DateTime?,
                                    DataFechamento = linhas["data_fechamento"] as DateTime?,
                                    Observacao = linhas["observacao"].ToString(),
                                    SituacaoAtendimentoId = Convert.ToInt32(linhas["situacao_atendimento_id"]),
                                    ClienteNome = linhas["cliente_nome"].ToString(),
                                    SituacaoAtendimentoNome = linhas["situacao_nome"].ToString(),
                                    UsuarioNome = linhas["usuario_nome"].ToString(),
                                    CpfCnpj = linhas["cpf_cnpj"].ToString() 
                                });
                            }
                        }
                    }
                }

                return lista;
            }


        //public Atendimentos? BuscarPorId(int id)
        //{
        //    var resultado = Listar(id.ToString(), "Código do Atendimento");
        //    return resultado.FirstOrDefault();
        //}




        public Atendimentos? BuscarPorId(int id)
        {
            using(var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"SELECT 
                            a.*, 
                            c.nome AS cliente_nome,
                            u.nome AS usuario_nome,
                            s.nome AS situacao_nome 
                            FROM atendimentos a 
                            INNER JOIN clientes c ON c.id = a.cliente_id 
                            INNER JOIN usuarios u ON u.id = a.usuario_id 
                            INNER JOIN situacao_atendimentos s ON s.id = a.situacao_atendimento_id 
                            WHERE a.id = @id";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    conexao.Open();

                    using (var linha = comando.ExecuteReader()) {
                        if (linha.Read()) {
                            return new Atendimentos
                            {
                            Id = Convert.ToInt32(linha["id"]),
                            ClienteId = Convert.ToInt32(linha["cliente_id"]),
                            UsuarioId = Convert.ToInt32(linha["usuario_id"]),
                            DataAbertura = linha["data_abertura"] as DateTime?,
                            DataFechamento = linha["data_fechamento"] as DateTime?,
                            Observacao = linha["observacao"].ToString(),
                            SituacaoAtendimentoId = Convert.ToInt32(linha["situacao_atendimento_id"]),
                            ClienteNome = linha["cliente_nome"].ToString(),
                            UsuarioNome = linha["usuario_nome"].ToString(),
                            SituacaoAtendimentoNome = linha["situacao_nome"].ToString()

                            };
                        }
                    }
                }
            }
            return null;
        }


        public int Inserir(Atendimentos atendimento)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"INSERT INTO atendimentos (cliente_id, usuario_id, data_abertura,  observacao, situacao_atendimento_id) OUTPUT INSERTED.id VALUES (@cliente_id, @usuario_id, @data_abertura, @observacao, @situacao_atendimento_id)";

                using (var comando = new SqlCommand(sql, conexao)) 
                {
                    comando.Parameters.AddWithValue("@cliente_id", atendimento.ClienteId);
                    comando.Parameters.AddWithValue("@usuario_id", atendimento.UsuarioId);
                    comando.Parameters.AddWithValue("@data_abertura", atendimento.DataAbertura);
                    comando.Parameters.AddWithValue("@observacao", atendimento.Observacao);
                    comando.Parameters.AddWithValue("@situacao_atendimento_id", atendimento.SituacaoAtendimentoId);
                    conexao.Open();

                    return Convert.ToInt32(comando.ExecuteScalar());
                   
                }
            }
        }

        public void Atualizar(Atendimentos atendimento)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"UPDATE atendimentos SET 
                               cliente_id=@cliente_id, 
                               usuario_id=@usuario_id, 
                               data_abertura=@data_abertura,                            
                               observacao=@observacao,
                               situacao_atendimento_id=@situacao_atendimento_id WHERE id=@id";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", atendimento.Id);
                    comando.Parameters.AddWithValue("@cliente_id", atendimento.ClienteId);
                    comando.Parameters.AddWithValue("@usuario_id", atendimento.UsuarioId);
                    comando.Parameters.AddWithValue("@data_abertura", atendimento.DataAbertura);
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
                string sql = "DELETE FROM atendimentos WHERE id=@id";

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
