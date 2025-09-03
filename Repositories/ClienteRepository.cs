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
    public class ClienteRepository
    {
        public List<Clientes> Listar()
        {
            var clientes = new List<Clientes>();

            using (var conexao = ConexaoDB.GetConexao()) //Criar variavel de conexão com o banco de dados (o using é para controle automatico de memória)
            {
                string sql = "SELECT * FROM clientes"; //comando para trazer os dados da tabela cliente

                using (var comando = new SqlCommand(sql, conexao)) //comandos a ser executados
                { 
                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())  //percorrer a lista
                        {
                            clientes.Add(new Clientes() 
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                Nome = linhas["nome"].ToString(),
                                Email = linhas["email"].ToString(),
                                Cpf_Cnpj = linhas["cpf_cnpj"].ToString(),
                                TipoPessoa = linhas["tipo_pessoa"].ToString(),
                                Telefone = linhas["telefone"].ToString(),
                                Celular = linhas["celular"].ToString(),
                                Cep = linhas["cep"].ToString(),
                                Endereco = linhas["endereco"].ToString(),
                                Numero = linhas["numero"].ToString(),
                                Complemento = linhas["complemento"].ToString(),
                                Bairro = linhas["bairro"].ToString(),
                                Cidade = linhas["cidade"].ToString(),
                                Estado = linhas["estado"].ToString(),
                                Ativo = Convert.ToBoolean(linhas["ativo"])
                            });
                        }
                    }
                }

            }

                return clientes;
        }

    }
}
