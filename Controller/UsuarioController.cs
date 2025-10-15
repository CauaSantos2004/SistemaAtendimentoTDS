using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;
using System;
using System.Collections.Generic;
using System.Data;

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
                _frmCadastroUsuario.ExibirUsuarios(listarUsuarios);
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao listar usuários: {ex.Message}");
            }
        }

        public void Inserir(Usuarios usuario)
        {
            try
            {
                _usuarioRepository.Inserir(usuario);

                _frmCadastroUsuario.ExibirMensagem("Usuário salvo com sucesso!");

                ListarUsuarios();
                _frmCadastroUsuario.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao salvar usuário: {ex.Message}");
            }
        }

        public void Atualizar(Usuarios usuario)
        {
            try
            {
                _usuarioRepository.Atualizar(usuario);

                _frmCadastroUsuario.ExibirMensagem("Usuário atualizado com sucesso!");

                ListarUsuarios();
                _frmCadastroUsuario.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao atualizar usuário: {ex.Message}");
            }
        }


        public void Excluir(int id)
        {
            try
            {
                _usuarioRepository.Excluir(id);
                _frmCadastroUsuario.ExibirMensagem("Usuário excluído com sucesso!");
                ListarUsuarios();
                _frmCadastroUsuario.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao excluir o usuário: {ex.Message}");
            }
        }

        public DataTable PesquisarUsuarios(string termo)
        {
            UsuarioRepository repository = new UsuarioRepository();
            return repository.PesquisarUsuarios(termo);
        }
    }
}