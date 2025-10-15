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

        public List<Atendimentos> Listar(string termo = "", string condicao = "")//retorna uma lista de nome de atendimentos
        {
            var lista = new List<Atendimentos>(); //criou a lista
            using (var conexao = ConexaoDB.GetConexao()) //criamos a conexao
            {
                string sql = @"SELECT * SELECT a. *, c.nome AS cliente_nome, s.nome AS
                                situacao_nome, u.nome AS usuario_nome, c.cpf_cnpj
                                FROM atendimentos a
                                INNER JOIN clientes c ON c.id = a.cliente_id
                                INNER JOIN usuarios u ON u.id = usuario_id
                                INNER JOIN situacao_atendimentos s ON s.id = a.situacao_atendimento_id";
            
                if (!string.IsNullOrEmpty(termo) && !string.IsNullOrEmpty(condicao))
                {
                    if (condicao == "Código do Atendimento")
                    {
                        sql += " WHERE id = @termo";
                    }else if (condicao == "Nome do Cliente")
                    {
                        sql += "WHERE c.nome LIKE %termo%";
                    }
                    else
                    {
                        sql += "WHERE c.cpf_cnpj = @termo";
                    }
                }
               using (var comando = new SqlCommand(sql, conexao))
                {
                    if (!string.IsNullOrEmpty(termo))
                    {
                        comando.Parameters.AddWithValue("termo", termo);
                    }

                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {

                    }
                }


            }
            return lista;
        }

        //void porque o metodo inserir não retornar nada, só adiciona
        public void Inserir(Atendimentos atendimentos)
        {

        }
        public void Atualizar(Atendimentos atendimentos)
        {

        }
        public void Excluir(int id)
        {

        }
    
    
    }
}
