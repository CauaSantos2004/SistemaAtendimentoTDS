using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class ConsultaAtendimentoController
    {
        // Passo 1: Campos da classe
        private FrmConsultaAtendimento _frmConsultaAtendimento; // referência à tela
        private AtendimentoRepository _atendimentoRepository;   // referência ao repositório

        // Passo 2: Construtor da classe recebe a tela como parâmetro
        public ConsultaAtendimentoController(FrmConsultaAtendimento view)
        {
            _frmConsultaAtendimento = view;                  // atribui a tela recebida
            _atendimentoRepository = new AtendimentoRepository(); // cria uma instância do repositório
        }
    
        public void ListarAtendimento(string termo = "", string condicao = "")
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }



    }
}
