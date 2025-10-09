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
            dgvUsuario.DataSource = null;
            dgvUsuario.DataSource = usuarios;
        }

        public void DesabilitarCampos()
        {
            LimparCampos();

            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtSenha.ReadOnly = true;
            cbxPerfil.Enabled = false;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;

            LimparCampos();
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSenha.ReadOnly = false;
            cbxPerfil.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cbxPerfil.SelectedIndex = -1;
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            _usuarioController.ListarUsuarios();
            DesabilitarCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos(); // opcional, mas recomendado para limpar campos antes de criar novo usuário
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios
            {
                Id = string.IsNullOrEmpty(txtCodigo.Text) ? 0 : Convert.ToInt32(txtCodigo.Text),
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                Perfil = cbxPerfil.Text,
            };

            _usuarioController.Salvar(usuario);

        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelecionada = dgvUsuario.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelecionada.Cells["Id"].Value.ToString();
                txtNome.Text = linhaSelecionada.Cells["Nome"].Value.ToString();
                txtEmail.Text = linhaSelecionada.Cells["Email"].Value.ToString();
                txtSenha.Text = linhaSelecionada.Cells["Senha"].Value.ToString();
                cbxPerfil.Text = linhaSelecionada.Cells["Perfil"].Value.ToString();

                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = false;
                btnSalvar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                ExibirMensagem("Selecione um usuário para excluir.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja excluir este usuário?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                _usuarioController.Excluir(id);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos(); // habilita os campos para edição
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
        }
    }



}