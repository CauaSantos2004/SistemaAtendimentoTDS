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

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        internal void ExibirUsuarios(List<Usuarios> usuarios)
        {
            dgvUsuarios.DataSource = usuarios;
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            _usuarioController.ListarUsuarios();

            dgvUsuarios.Columns["Id"].HeaderText = "Código";
            dgvUsuarios.Columns["Nome"].HeaderText = "Nome Completo";
            dgvUsuarios.Columns["Email"].HeaderText = "Email";
            // dgvUsuarios.Columns["Senha"].Visible = false; // Oculta a coluna Senha
            dgvUsuarios.Columns["Senha"].HeaderText = "Senha";
            dgvUsuarios.Columns["Perfil"].HeaderText = "Perfil";

            // Preenche o grid com ajuste automático
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Ajuste individual:
            dgvUsuarios.Columns["Id"].Width = 60;
            dgvUsuarios.Columns["Nome"].Width = 200;
            dgvUsuarios.Columns["Email"].Width = 200;
            dgvUsuarios.Columns["Senha"].Width = 100;
            dgvUsuarios.Columns["Perfil"].Width = 100;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios()
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                Perfil = cbxPerfil.Text,
            };

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                _usuarioController.Salvar(usuario);
            }
            else
            {
                usuario.Id = Convert.ToInt32(txtCodigo.Text);
                _usuarioController.Atualizar(usuario);
            }


        }

        private bool ValidaDados(Usuarios usuario)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ExibirMensagem("O campo Email é obrigatório.");
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                ExibirMensagem("O campo Senha é obrigatório.");
                txtSenha.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbxPerfil.Text))
            {
                ExibirMensagem("O campo Senha é obrigatório.");
                cbxPerfil.Focus();
                return false;
            }

            return true;
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
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cbxPerfil.Text = "";
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
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void dgvUsuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];

                txtCodigo.Text = row.Cells["Id"].Value.ToString();
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSenha.Text = row.Cells["Senha"].Value.ToString();
                cbxPerfil.Text = row.Cells["Perfil"].Value.ToString();

                btnNovo.Enabled = false;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnEditar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                ExibirMensagem("Selecione um usuário para excluir.");
                return;
            }
            else
            {
                DialogResult resultado = MessageBox.Show($"Deseja Excluir este Usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtCodigo.Text);
                    _usuarioController.Excluir(id);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.Trim();
            _usuarioController.ListarUsuarios(termo);
        }
    }
}
