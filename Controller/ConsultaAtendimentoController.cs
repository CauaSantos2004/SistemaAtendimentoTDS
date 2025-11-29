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
        private FrmConsultaAtendimento _frmConsultaAtendimento;
        private AtendimentoRepository _atendimentoRepository;
        public ConsultaAtendimentoController(FrmConsultaAtendimento view)
        {
            _frmConsultaAtendimento = view;
            _atendimentoRepository = new AtendimentoRepository();
        }

        public void ListarAtendimento(string termo = "", string condicao = "")
        {
            try
            {
                var listaAtendimento = _atendimentoRepository.Listar(termo, condicao);
                _frmConsultaAtendimento.ExibirAtendimentos(listaAtendimento);

            }
            catch (Exception ex)
            {
                _frmConsultaAtendimento.ExibirMensagem($"Erro ao listar os atendimentos: {ex.Message}");
            }
        }

    }
}
