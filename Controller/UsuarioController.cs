using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;
using System;
using System.Collections.Generic;

namespace SistemaAtendimento.Controller
{
    public class UsuarioController
    {
        private FrmCadastroUsuario _view;
        private UsuarioRepository _usuarioRepository;

        public UsuarioController(FrmCadastroUsuario view)
        {
            _view = view;
            _usuarioRepository = new UsuarioRepository();
        }

        public void ListarUsuarios()
        {
            try
            {
                var listarUsuarios = _usuarioRepository.Listar();
                _view.ExibirUsuarios(listarUsuarios); // chama o método da tela
            }
            catch (Exception ex)
            {
                _view.ExibirMensagem($"Erro ao listar usuários: {ex.Message}");
            }
        }

        public void Salvar(Usuarios usuario)
        {
            try
            {
                if (usuario.Id == 0)
                    _usuarioRepository.Inserir(usuario); // novo usuário
                else
                    _usuarioRepository.Atualizar(usuario);

                _view.ExibirMensagem("Usuário salvo com sucesso!");
                ListarUsuarios();
                _view.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _view.ExibirMensagem($"Erro ao salvar usuário: {ex.Message}");
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _usuarioRepository.Excluir(id);
                _view.ExibirMensagem("Usuário excluído com sucesso!");
                ListarUsuarios();
            }
            catch (Exception ex)
            {
                _view.ExibirMensagem($"Erro ao excluir usuário: {ex.Message}");
            }
        }
    }
}
