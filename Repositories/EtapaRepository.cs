using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.Repositories
{
    public class EtapaRepository
    {
        //public List<Etapas> Listar()
        //{
        //    var etapas = new List<Etapas>();
            
        //    using (var conexao = ConexaoDB.GetConexao())
        //    {
        //        string sql = "SELECT * FROM etapas";

        //        using (var comando = new SqlCommand(sql, conexao))
        //        {
        //            conexao.Open();

        //            using (var linhas = comando.ExecuteReader())
        //            {
        //                while (linhas.Read())
        //                {
        //                    etapas.Add(new Etapas()
        //                    {
        //                        Id = Convert.ToInt32(linhas["id"]),
        //                        Nome = linhas["nome"]).ToString(),
        //                        Ordem = Convert.ToInt32(linhas["email"]).ToString(),
        //                        Ativo = Convert.ToBoolean(linhas["senha"])
        //                    });
        //                }
        //            }   
        //        }
        //    }
        //    return etapas;
        //}
                    
    }
}
