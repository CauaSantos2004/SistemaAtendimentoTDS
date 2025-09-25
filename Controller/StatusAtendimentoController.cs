using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class StatusAtendimentoController
    {
        private FrmCadastroStatusAtendimento _frmCadastroStatusAtendimento;
        private StatusAtendimentoRepository _StatusAtendimentoRepository;

        public StatusAtendimentoController (FrmCadastroStatusAtendimento view)
        {
            _frmCadastroStatusAtendimento = view;
            _StatusAtendimentoRepository = new StatusAtendimentoRepository();
        }
    
        public void ListarStatusAtendimentos()
        {
            try
            {
                var listarStatusAtendimento = _StatusAtendimentoRepository.Listar();
                _frmCadastroStatusAtendimento.ExibirStatusAtendimento(listarStatusAtendimento);
            }
            catch (Exception ex)
            {
                _frmCadastroStatusAtendimento.ExibirMensagem($"Erro ao cadastrar Status do atendimento {ex.Message}");
            }

        }
        public void Salvar(SatusAtendimento satusAtendimento)
        {
            try
            {

            }
        }   

    }

    }
