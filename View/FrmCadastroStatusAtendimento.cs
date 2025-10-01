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
    public partial class FrmCadastroStatusAtendimento : Form
    {
        private StatusAtendimentoController _statusAtendimentoController;
        public FrmCadastroStatusAtendimento()
        {
            InitializeComponent();
            _statusAtendimentoController = new StatusAtendimentoController(this);
        }

        public void ExibirStatus(List<StatusAtendimento> statusAtendimentos)
        {
            dgvListaSituacoesAtendimento.DataSource = statusAtendimentos;
        }
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }


        private void pnlSituacao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCadastroSituacaoAtendimento_Load(object sender, EventArgs e)
        {
            _statusAtendimentoController.ListarStatus();
        }
        private void HabilitarCampos() // metodo hanilitar campos
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
                _statusAtendimentoController.Atualizar(status);
            }
            else
            {
                status.Id = Convert.ToInt32(txtCodigo.Text);
                _statusAtendimentoController.Atualizar(status);
            }

            DesabilitarCampos();
        }

        public bool ValidarDados(StatusAtendimento status)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O campo Nome é obrigatório. Por favor, preencha-o.");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCor.Text))
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
        }

        public void DesabilitarCampos()
        {
            LimparCampos();

            txtNome.ReadOnly = true;
            txtCor.ReadOnly = true;
            rdbAtivo.Enabled = false;
            rdbInativo.Enabled = false;

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
                DataGridViewRow linhaSelecionada = dgvListaSituacoesAtendimento.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelecionada.Cells["Id"].Value.ToString();
                txtNome.Text = linhaSelecionada.Cells["Nome"].Value.ToString();
                txtCor.Text = linhaSelecionada.Cells["Cor"].Value.ToString();

                rdbAtivo.Checked = Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value);
                rdbInativo.Checked = !Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value);

                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;




            }
        }
    }
}
