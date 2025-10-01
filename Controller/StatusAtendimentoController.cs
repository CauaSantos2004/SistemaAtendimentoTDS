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
        private FrmCadastroSituacaoAtendimento _frmStatus;
        private StatusAtendimentoRepository _repository;

        public StatusAtendimentoController(FrmCadastroSituacaoAtendimento view)
        {
            _frmStatus = view;
            _repository = new StatusAtendimentoRepository();
        }

        public void ListarStatus()
        {
            try
            {
                var lista = _repository.Listar();
                _frmStatus.ExibirStatus(lista);
            }
            catch (Exception ex)
            {
                _frmStatus.ExibirMensagem($"Erro ao carregar os status de atendimento: {ex.Message}");
            }
        }

        public void Salvar(StatusAtendimento status)
        {
            try
            {
                _repository.Inserir(status);
                _frmStatus.ExibirMensagem("Status de atendimento cadastrado com sucesso!");

                ListarStatus();
                _frmStatus.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmStatus.ExibirMensagem($"Erro ao cadastrar status: {ex.Message}");
            }
        }

        public void Atualizar(StatusAtendimento status)
        {
            try
            {
                _repository.Atualizar(status);
                _frmStatus.ExibirMensagem("Status de atendimento atualizado com sucesso!");

                ListarStatus();
                _frmStatus.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmStatus.ExibirMensagem($"Erro ao atualizar status: {ex.Message}");
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _repository.Excluir(id);
                _frmStatus.ExibirMensagem("Status de atendimento excluído com sucesso!");

                ListarStatus();
                _frmStatus.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmStatus.ExibirMensagem($"Erro ao excluir status: {ex.Message}");
            }
        }
    }
}
