using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Model.SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    //alterações feitas a partir daqui
    //vincular o formulario
    //ligação com o repositorio
    public class AtendimentoController //adcionada a palavra public
    {
        //criação das variaveis, adicionada esta duas linhas
        private FrmAtendimento _frmAtendimento;
        private AtendimentoRepository _atendimentoRepository;

        private ClienteRepository _clienteRepository; //adicionada esta linha do repositorio de cliente

        private StatusAtendimentoRepository _statusAtendimentoRepository; //adicionada esta linha do repositorio de status atendimento

        private EtapasRepository _etapasRepository; //adicionada esta linha do repositorio de etapas atendimento


        //construtor do controller, adicionada esta parte
        public AtendimentoController(FrmAtendimento view) //
        {
            _frmAtendimento = view;
            _atendimentoRepository = new AtendimentoRepository();

            _clienteRepository = new ClienteRepository(); //adicionada esta linha do repositorio de cliente
            _statusAtendimentoRepository = new StatusAtendimentoRepository(); //adicionada esta linha do repositorio de status atendimento
            _etapasRepository = new EtapasRepository(); //adicionada esta linha do repositorio de etapas atendimento
        }

        //função para listar todos os clientes, adicionada esta parte
        public List<Clientes> ListarClientes()
        {
            return _clienteRepository.Listar();
        }

        //função para listar todas as situações do atendimento
        public List<StausAtendimento> ListarSituacaoAtendimento() //adicionada esta parte
        {
            return _statusAtendimentoRepository.Listar();
        }

        //função para listar todas as etapas do atendimento
        public List<Etapas> ListarEtapasAtendimento() //adicionada esta parte
        {
            return _etapasRepository.Listar();
        }

        //função para salvar o atendimento
        public void Salvar(Atendimentos atendimento)
        {
            // bloco try catch para tratar erros
            try
            {
                _atendimentoRepository.Inserir(atendimento); // chama o metodo inserir do repositorio
                _frmAtendimento.ExibirMensagem("Atendimento salvo com sucesso!"); // mensagem de sucesso
            }

            catch (Exception ex)
            {
                _frmAtendimento.ExibirMensagem($"Erro ao salvar atendimento: {ex.Message}"); //mensagem de erro
            }
        }



    }
}
