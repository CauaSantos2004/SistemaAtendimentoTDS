using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;
using System;
using System.Collections.Generic;

namespace SistemaAtendimento.Controller
{
    public class UsuarioController
    {
        private FrmCadastroUsuario _frmCadastroUsuario;
        private UsuarioRepository _usuarioRepository;

        public UsuarioController(FrmCadastroUsuario view)
        {
            _frmCadastroUsuario = view;
            _usuarioRepository = new UsuarioRepository();
        }

        public void ListarUsuarios()
        {
            try
            {
                var listarUsuarios = _usuarioRepository.Listar();
                _frmCadastroUsuario.ExibirUsuarios(listarUsuarios); // chama o método da tela
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao listar usuários: {ex.Message}");
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

                _frmCadastroUsuario.ExibirMensagem("Usuário salvo com sucesso!");
                ListarUsuarios();
                _frmCadastroUsuario.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao salvar usuário: {ex.Message}");
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _usuarioRepository.Excluir(id);
                _frmCadastroUsuario.ExibirMensagem("Usuário excluído com sucesso!");

                ListarUsuarios(); // Atualiza o DataGrid
                _frmCadastroUsuario.DesabilitarCampos(); // Reseta a tela
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao excluir o usuário: {ex.Message}");
            }
        }
    }
}
