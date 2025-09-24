using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.View
{
    public partial class FrmCadastroUsuario : Form
    {
        private UsuarioController _usuarioController;
        public FrmCadastroUsuario()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController(this);
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }



        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void ExibirUsuarios(List<Usuarios> usuarios)
        {
            dgvUsuario.DataSource = usuarios;
        }

        public void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtCodigo.Enabled = false;
            // continue com os outros campos do formulário
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            _usuarioController.ListarUsuarios();
        }
    }



}
