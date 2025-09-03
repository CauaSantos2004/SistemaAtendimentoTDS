using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Repositories;

namespace SistemaAtendimento.Controller
{
    public class ClienteController
    {
        private FrmCadastroClientes _frmCadastroClientes; //private significa que só vai funcionar nessa classe, não compartilha infirmações com outra
        private ClienteRepository _clienteRepository;
        public ClienteController(FrmCadastroClientes view)
        {
            _frmCadastroClientes = view;
            _clienteRepository = new ClienteRepository();
        }

        public void ListarClientes()
        {
            try //try e catch pega erros do sistema guarda numa variavel e podemos mostrar o erro de uma forma personalizada (com uma mensagem personalizada)
            {
                var listaClientes = _clienteRepository.Listar();
                _frmCadastroClientes.ExibirClientes(listaClientes);
            }
            catch (Exception ex) //guardamos a mensagem de erro aqui em "ex"
            {
                _frmCadastroClientes.ExibirMensagem($"Erro ao carregar os clientes: {ex.Message}"); //mostra a mensagem junto com o erro
            }
        }
    }
}
