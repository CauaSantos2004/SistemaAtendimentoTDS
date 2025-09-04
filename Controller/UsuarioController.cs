using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class UsuarioController
    {
        private FrmCadastroUsuario _frmCadastroUsuario;
        private UsuarioRepository _usuarioRepository;

        public UsuarioController(FrmCadastroUsuario view)
        {
            _frmCadastroUsuario = view; //gurda a tela 
            _usuarioRepository = new UsuarioRepository();
        }

        public void ListarUsuarios()
        {
            try
            {
                var listarUsuarios = _usuarioRepository.Listar();
                _frmCadastroUsuario.ExibirUsuarios(listarUsuarios);
            }
            catch (Exception ex) // se der erro
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao carregar Usuarios: {ex.Message}");

            }
        }
    }
}
