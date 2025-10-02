using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
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

        public void ListarClientes(string termo = "")
        {
            try //try e catch pega erros do sistema guarda numa variavel e podemos mostrar o erro de uma forma personalizada (com uma mensagem personalizada)
            {
                var listaClientes = _clienteRepository.Listar(termo);
                _frmCadastroClientes.ExibirClientes(listaClientes);
            }
            catch (Exception ex) //guardamos a mensagem de erro aqui em "ex"
            {
                _frmCadastroClientes.ExibirMensagem($"Erro ao carregar os clientes: {ex.Message}"); //mostra a mensagem junto com o erro
            }
        }
        public void Salvar(Clientes cliente) //método de salvar
        {
            //criar o try catch
            try
            {
                _clienteRepository.Inserir(cliente);
                _frmCadastroClientes.ExibirMensagem($"Cliente cadastrado com sucesso!");
                
                ListarClientes();
                //Atualizar DataGrid

                _frmCadastroClientes.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroClientes.ExibirMensagem($"Erro ao cadastrar o cliente: {ex.Message}");
            }
        }

        public void Atualizar(Clientes cliente) //método de atualizar
        {
            //criar o try catch
            try
            {
                _clienteRepository.Atualizar(cliente);
                _frmCadastroClientes.ExibirMensagem($"Cliente atualizado com sucesso!");

                ListarClientes();
                //Atualizar DataGrid

                _frmCadastroClientes.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroClientes.ExibirMensagem($"Erro ao atualizar cliente: {ex.Message}");
            }
        }

        public void Excluir(int id) //método de excluir
        {
            try
            {
                _clienteRepository.Excluir(id);
                _frmCadastroClientes.ExibirMensagem("Cliente excluido com sucesso!");
                
                ListarClientes();

                _frmCadastroClientes.DesabilitarCampos();
            
            }
            catch (Exception ex)
            {
                _frmCadastroClientes.ExibirMensagem($"Erro ao excluir o cliente: {ex.Message}");
            }

        }

    }   
}
