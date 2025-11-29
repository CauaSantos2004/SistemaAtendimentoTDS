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
    internal class UsuarioController
    {
        private FrmCadastroUsuario _frmCadastroUsuario;
        private UsuarioRepository _usuarioRepository;
        public UsuarioController(FrmCadastroUsuario view) //Método Construtor
        {
            _frmCadastroUsuario = view;
            _usuarioRepository = new UsuarioRepository();
        }

        public void ListarUsuarios(string termo = "")
        {
            try
            {
                var listaUsuarios = _usuarioRepository.Listar(termo);
                _frmCadastroUsuario.ExibirUsuarios(listaUsuarios);
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao carregar os clientes: {ex.Message}");
            }
        }

        public void Salvar(Usuarios usuario)
        {
            try
            {
                _usuarioRepository.Inserir(usuario);
                _frmCadastroUsuario.ExibirMensagem($"Etapa cadastrada com sucesso!");

                ListarUsuarios();

                _frmCadastroUsuario.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao Cadastrar Etapa: {ex.Message}");
            }
        }

        public void Atualizar(Usuarios usuario)
        {
            try
            {
                _usuarioRepository.Atualizar(usuario);
                _frmCadastroUsuario.ExibirMensagem($"Etapa atualizada com sucesso!");
                ListarUsuarios();
                _frmCadastroUsuario.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao atualizar Etapa: {ex.Message}");
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _usuarioRepository.Excluir(id);
                _frmCadastroUsuario.ExibirMensagem($"Etapa excluída com sucesso!");
                ListarUsuarios();
                _frmCadastroUsuario.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao excluir Etapa: {ex.Message}");
            }
        }
    }
}
