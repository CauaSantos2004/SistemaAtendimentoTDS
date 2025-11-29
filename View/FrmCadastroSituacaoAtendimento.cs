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
        private SituacaoAtendimentoController _situacaoAtendimentoController;

        public FrmCadastroSituacaoAtendimento()
        {
            _situacaoAtendimentoController = new SituacaoAtendimentoController(this);
            InitializeComponent();
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        internal void ExibirSituacaoAtendimento(List<SituacaoAtendimentos> situacaoAtendimentos)
        {
            dgvSituacoesAtendimento.DataSource = situacaoAtendimentos;
        }

        private void FrmCadastroSituacaoAtendimento_Load(object sender, EventArgs e)
        {
            _situacaoAtendimentoController.ListarSituacaoAtendimento();

            dgvSituacoesAtendimento.Columns["Id"].HeaderText = "Código";
            dgvSituacoesAtendimento.Columns["Nome"].HeaderText = "Nome da Situação";
            dgvSituacoesAtendimento.Columns["Cor"].HeaderText = "Cor";
            dgvSituacoesAtendimento.Columns["Ativo"].HeaderText = "Ativo";

            // Preenche o grid com ajuste automático
            dgvSituacoesAtendimento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Ajuste individual:
            dgvSituacoesAtendimento.Columns["Id"].Width = 60;
            dgvSituacoesAtendimento.Columns["Nome"].Width = 200;
            dgvSituacoesAtendimento.Columns["Cor"].Width = 100;
            dgvSituacoesAtendimento.Columns["Ativo"].Width = 60;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SituacaoAtendimentos situacaoAtendimentos = new SituacaoAtendimentos()
            {
                Nome = txtNome.Text,
                Cor = txtCor.Text,
                Ativo = rdbAtivo.Checked,
            };

            if (!ValidaDados(situacaoAtendimentos))
                return;

            if (string.IsNullOrEmpty(txtCodigo.Text))
                _situacaoAtendimentoController.Salvar(situacaoAtendimentos);
            else
            {
                situacaoAtendimentos.Id = Convert.ToInt32(txtCodigo.Text);
                _situacaoAtendimentoController.Atualizar(situacaoAtendimentos);
            }
        }

        private bool ValidaDados(SituacaoAtendimentos situacaoAtendimentos)
        {
            if (string.IsNullOrWhiteSpace(situacaoAtendimentos.Nome))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(situacaoAtendimentos.Cor))
            {
                ExibirMensagem("O campo Cor é obrigatório.");
                txtCor.Focus();
                return false;
            }
            return true;
        }

        public void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtCor.ReadOnly = false;
            pnlSituacao.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            txtCor.Clear();
            rdbAtivo.Checked = true;
            txtNome.Focus();
        }

        public void DesabilitarCampos()
        {
            LimparCampos();

            txtNome.ReadOnly = true;
            txtCor.ReadOnly = true;
            pnlSituacao.Enabled = false;
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

        private void dgvSituacoesAtendimento_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var situacaoAtendimento = (SituacaoAtendimentos)dgvSituacoesAtendimento.Rows[e.RowIndex].DataBoundItem;
                txtCodigo.Text = situacaoAtendimento.Id.ToString();
                txtNome.Text = situacaoAtendimento.Nome;
                txtCor.Text = situacaoAtendimento.Cor;
                rdbAtivo.Checked = situacaoAtendimento.Ativo;
                rdbInativo.Checked = !situacaoAtendimento.Ativo;

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
                ExibirMensagem("Nenhum situação de atendimento selecionado para exclusão.");
                return;
            }
            else
            {
                DialogResult resultado = MessageBox.Show($"Deseja Excluir esta Situação de Atendimento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtCodigo.Text);
                    _situacaoAtendimentoController.Excluir(id);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.Trim();
            _situacaoAtendimentoController.ListarSituacaoAtendimento(termo);
        }
    }
}
