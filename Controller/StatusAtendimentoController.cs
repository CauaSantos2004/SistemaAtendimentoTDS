using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class StatusAtendimentoController
    {
        private FrmCadastroSituacaoAtendimento _frmSituacaoAtendimento;
        private StatusAtendimentoRepository _situacaoAtendimentoRepository;

        public StatusAtendimentoController(FrmCadastroSituacaoAtendimento view)
        {
            _frmSituacaoAtendimento = view;
            _situacaoAtendimentoRepository = new StatusAtendimentoRepository();
        }

        public void ListarSituacao(string termo = "")
        {
            try
            {
                var lista = _situacaoAtendimentoRepository.Listar(termo);
                _frmSituacaoAtendimento.ExibirSituacaoAtendimentos(lista);
            }
            catch (Exception ex)
            {
                _frmSituacaoAtendimento.ExibirMensagem($"Erro ao carregar os status de atendimento: {ex.Message}");
            }
        }

        public void Salvar(StausAtendimentos status)
        {
            try
            {
                _situacaoAtendimentoRepository.Inserir(status);
                _frmSituacaoAtendimento.ExibirMensagem("Status de atendimento cadastrado com sucesso!");

                ListarSituacao();
                _frmSituacaoAtendimento.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmSituacaoAtendimento.ExibirMensagem($"Erro ao cadastrar status: {ex.Message}");
            }
        }

        public void Atualizar(StausAtendimentos status)
        {
            try
            {
                _situacaoAtendimentoRepository.Atualizar(status);
                _frmSituacaoAtendimento.ExibirMensagem("Status de atendimento atualizado com sucesso!");

                ListarSituacao();
                _frmSituacaoAtendimento.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmSituacaoAtendimento.ExibirMensagem($"Erro ao atualizar status: {ex.Message}");
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _situacaoAtendimentoRepository.Excluir(id);
                _frmSituacaoAtendimento.ExibirMensagem("Status de atendimento excluído com sucesso!");

                ListarSituacao();
                _frmSituacaoAtendimento.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmSituacaoAtendimento.ExibirMensagem($"Erro ao excluir status: {ex.Message}");
            }
        }
    }
}
