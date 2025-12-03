using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class EtapasAtendimentoController
    {
        //adicionar os métodos do repositório
        private EtapasAtendimentoRepository _etapasAtendimentoRepository;
        private FrmAtendimento _frmAtendimento;

        //construtor
        public EtapasAtendimentoController(FrmAtendimento view)
        {
            _frmAtendimento = view;
            _etapasAtendimentoRepository = new EtapasAtendimentoRepository(); //faz a instancia do repositório
        }

        //método para listar as etapas de atendimento pelo ID do atendimento
        public List<EtapasAtendimentos> Listar(int atendimentoId)
        {
            return _etapasAtendimentoRepository.Listar(atendimentoId); //chama o método listar do repositório e retorna a lista
        }
        
        public void Salvar(EtapasAtendimentos etapasAtendimentos)
        {
            try
            {
                _etapasAtendimentoRepository.Inserir(etapasAtendimentos);
                _frmAtendimento.ExibirMensagem("Atendimento Etapa salvo com sucesso!");
            }
            catch(Exception ex)
            {
                _frmAtendimento.ExibirMensagem("Erro ao cadastrar o Atendimento Etapa: " + ex.Message);
            }
            {

            }
        }
        public void Excluir(int id)
        {
            try
            {
                _etapasAtendimentoRepository.Excluir(id);
                _frmAtendimento.ExibirMensagem("Etapa do atendimento excluída com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir a etapa do atendimento: " + ex.Message);
            }

        }
    }
}
