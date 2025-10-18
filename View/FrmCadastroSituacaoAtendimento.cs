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
    public partial class FrmCadastroSituacaoAtendimento : Form
    {
        private StatusAtendimentoController _situacaoAtendimentoController;

        public FrmCadastroSituacaoAtendimento()
        {
            InitializeComponent();
            _situacaoAtendimentoController = new StatusAtendimentoController(this);
        }

        public void ExibirStatus(List<StatusAtendimento> statusAtendimentos)
        {
            dgvListaSituacaoAtendimento.DataSource = statusAtendimentos;
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        private void FrmCadastroSituacaoAtendimento_Load(object sender, EventArgs e)
        {
            _situacaoAtendimentoController.ListarSituacao();
            DesabilitarCampos(); // ✅ bloqueia tudo e deixa só o “Novo” ativo
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtCor.ReadOnly = false;
            pnlSituacao.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            StatusAtendimento status = new StatusAtendimento
            {
                Nome = txtNome.Text,
                Cor = txtCor.Text,
                Ativo = rdbAtivo.Checked
            };

            if (!ValidarDados(status))
                return;

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                _situacaoAtendimentoController.Salvar(status);
            }
            else
            {
                status.Id = Convert.ToInt32(txtCodigo.Text);
                _situacaoAtendimentoController.Atualizar(status);
            }

            _situacaoAtendimentoController.ListarSituacao();
            DesabilitarCampos();
        }

        public bool ValidarDados(StatusAtendimento status)
        {
            if (string.IsNullOrWhiteSpace(status.Nome))
            {
                ExibirMensagem("O campo Nome é obrigatório. Por favor, preencha-o.");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(status.Cor))
            {
                ExibirMensagem("O campo Cor é obrigatório. Por favor, preencha-o.");
                txtCor.Focus();
                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtCor.Clear();
            rdbAtivo.Checked = true;
            rdbInativo.Checked = false;
        }

        public void DesabilitarCampos()
        {
            LimparCampos();

            txtNome.ReadOnly = true;
            txtCor.ReadOnly = true;
            pnlSituacao.Enabled = false;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();

        }

        private void dgvListaSituacoesAtendimento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelecionada = dgvListaSituacaoAtendimento.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelecionada.Cells["Id"].Value.ToString();
                txtNome.Text = linhaSelecionada.Cells["Nome"].Value.ToString();
                txtCor.Text = linhaSelecionada.Cells["Cor"].Value.ToString();

                bool ativo = Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value);
                rdbAtivo.Checked = Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value);
                rdbInativo.Checked = !Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value);


                txtNome.ReadOnly = true;
                txtCor.ReadOnly = true;
                pnlSituacao.Enabled = false;

                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                ExibirMensagem("Nenhuma situação de atendimento selecionada.");
                return;
            }

            DialogResult resultado = MessageBox.Show($"Deseja Excluir esta Situação de Atendimento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                _situacaoAtendimentoController.Excluir(id);
                _situacaoAtendimentoController.ListarSituacao();
                DesabilitarCampos();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.Trim();
            _situacaoAtendimentoController.ListarSituacao(termo);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.Trim();

            if (string.IsNullOrEmpty(termo))
            {
                _situacaoAtendimentoController.ListarSituacao(); // ✅ Atualiza a lista com todos os registros
            }
        }
    }
}
