using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
   
    public class AtendimentoController
    {
        private FrmAtendimento _frmAtendimento;
        private AtendimentoRepository _atendimentoRepository;
        private ClienteRepository _clienteRepository; 
        private EtapaRepository _etapaRepository;
        private SituacaoAtendimentoRepository _situacaoAtendimentoRepository;

        public AtendimentoController(FrmAtendimento view)
        {
            _frmAtendimento = view;
            _atendimentoRepository = new AtendimentoRepository();
            _clienteRepository = new ClienteRepository();
            _etapaRepository = new EtapaRepository();
            _situacaoAtendimentoRepository = new SituacaoAtendimentoRepository();
        }

        public List<Clientes> ListarClientes()
        {
            return _clienteRepository.Listar();
        }

        public List<Etapas> ListarEtapas()
        {
            return _etapaRepository.Listar();
        }

        public List<SituacaoAtendimentos> ListarSituacaoAtendimento()
        {
            return _situacaoAtendimentoRepository.Listar();
        }


        public int? Salvar(Atendimentos atendimento)
        {
            int? atendimentoId = null;
            try
            {
                atendimentoId = _atendimentoRepository.Inserir(atendimento);
                _frmAtendimento.ExibirMensagem("Atendimento Salvo com Sucesso!");
              
            }
            catch (Exception ex)
            {
                _frmAtendimento.ExibirMensagem($"Erro ao Cadastrar o Atendimento: {ex.Message}");
            }  

            return atendimentoId;
        }

        public void Atualizar(Atendimentos atendimento)
        {
            try
            {
                _atendimentoRepository.Atualizar(atendimento);
                _frmAtendimento.ExibirMensagem("Atendimento Atualizado com Sucesso!");
            }
            catch (Exception ex)
            {
                _frmAtendimento.ExibirMensagem($"Erro ao Atualizar o Atendimento: {ex.Message}");
            }
        }



        public Atendimentos? BuscarAtendimentoPorId(int id)
        {
            return _atendimentoRepository.BuscarPorId(id);
        }

        public void Excluir(int id)
        {
            try
            {
                _atendimentoRepository.Excluir(id);

                _frmAtendimento.ExibirMensagem("Atendimento excluído com Sucesso!");

            }
            catch (Exception ex)
            {
                _frmAtendimento.ExibirMensagem($"Erro ao Excluir o cliente: {ex.Message}");
            }

        }


    }
}
