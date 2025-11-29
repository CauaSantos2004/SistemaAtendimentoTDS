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
    public class SituacaoAtendimentoController
    {
        private FrmCadastroSituacaoAtendimento _frmCadastroSituacaoAtendimento;
        private SituacaoAtendimentoRepository _situacaoAtendimentoRepository;
        public SituacaoAtendimentoController(FrmCadastroSituacaoAtendimento view) //Método Construtor
        {
            _frmCadastroSituacaoAtendimento = view;
            _situacaoAtendimentoRepository = new SituacaoAtendimentoRepository();
        }

        public void ListarSituacaoAtendimento(string termo = "")
        {
            try
            {
                var listaSituacaoAtendimentos = _situacaoAtendimentoRepository.Listar(termo);
                _frmCadastroSituacaoAtendimento.ExibirSituacaoAtendimento(listaSituacaoAtendimentos);
            }
            catch (Exception ex)
            {
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Erro ao carregar os clientes: {ex.Message}");
            }
        }

        public void Salvar(SituacaoAtendimentos situacaoAtendimento)
        {
            try
            {
                _situacaoAtendimentoRepository.Inserir(situacaoAtendimento);
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Situação Atendimento cadastrado com sucesso!");

                ListarSituacaoAtendimento();

                _frmCadastroSituacaoAtendimento.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Erro ao Cadastrar Situação Atendimento: {ex.Message}");
            }
        }

        public void Atualizar(SituacaoAtendimentos situacaoAtendimento)
        {
            try
            {
                _situacaoAtendimentoRepository.Atualizar(situacaoAtendimento);
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Situação Atendimento atualizado com sucesso!");
                ListarSituacaoAtendimento();
                _frmCadastroSituacaoAtendimento.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Erro ao Atualizar Situação Atendimento: {ex.Message}");
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _situacaoAtendimentoRepository.Excluir(id);
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Situação Atendimento excluído com sucesso!");
                ListarSituacaoAtendimento();
                _frmCadastroSituacaoAtendimento.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Erro ao Excluir Situação Atendimento: {ex.Message}");
            }
        }
    }
}
