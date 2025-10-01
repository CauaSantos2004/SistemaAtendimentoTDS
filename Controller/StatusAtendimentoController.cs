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
        private FrmCadastroStatusAtendimento _frmCadastroStatusAtendimento;
        private StatusAtendimentoRepository _statusAtendimentoRepository;

        public StatusAtendimentoController(FrmCadastroStatusAtendimento view)
        {
            _frmCadastroStatusAtendimento = view;
            _statusAtendimentoRepository = new StatusAtendimentoRepository();
        }

        public void ListarStatus()
        {
            try
            {
                var listaStatus = _statusAtendimentoRepository.Listar();
                _frmCadastroStatusAtendimento.ExibirStatus(listaStatus);
            }
            catch (Exception ex)
            {
                _frmCadastroStatusAtendimento.ExibirMensagem($"Erro ao carregar os status de atendimento: {ex.Message}");
            }
        }

        public void Salvar(StatusAtendimento statusAtendimento) //método de salvar
        {
            try
            {
                _statusAtendimentoRepository.Inserir(statusAtendimento);
                _frmCadastroStatusAtendimento.ExibirMensagem("Status do atendimento cadastrado com sucesso!");

                ListarStatus();
                // Atualizar DataGrid

                _frmCadastroStatusAtendimento.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroStatusAtendimento.ExibirMensagem($"Erro ao cadastrar o status do atendimento: {ex.Message}");
            }
        }

        public void Atualizar(StatusAtendimento statusAtendimento) //método de atualizar
        {
            try
            {
                _statusAtendimentoRepository.Atualizar(statusAtendimento);
                _frmCadastroStatusAtendimento.ExibirMensagem("Status do atendimento atualizado com sucesso!");

                ListarStatus();
                // Atualizar DataGrid

                _frmCadastroStatusAtendimento.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroStatusAtendimento.ExibirMensagem($"Erro ao atualizar o status do atendimento: {ex.Message}");
            }
        }

        public void Excluir(int id) //método de excluir
        {
            try
            {
                _statusAtendimentoRepository.Excluir(id);
                _frmCadastroStatusAtendimento.ExibirMensagem("Status do atendimento excluído com sucesso!");

                ListarStatus();
                _frmCadastroStatusAtendimento.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroStatusAtendimento.ExibirMensagem($"Erro ao excluir o status do atendimento: {ex.Message}");
            }
        }
    }
}
