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
    public partial class FrmCadastroEtapa : Form
    {
        private EtapaController _etapaController;
        public FrmCadastroEtapa()
        {
            _etapaController = new EtapaController(this);
            InitializeComponent();
        }
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        internal void ExibirEtapas(List<Etapas> etapas)
        {
            dgvEtapas.DataSource = etapas;
        }

        private void FrmCadastroEtapa_Load(object sender, EventArgs e)
        {
            _etapaController.ListarEtapas();

            dgvEtapas.Columns["Id"].HeaderText = "Código";
            dgvEtapas.Columns["Nome"].HeaderText = "Nome da Etapa";
            dgvEtapas.Columns["Ordem"].HeaderText = "Ordem";
            dgvEtapas.Columns["Ativo"].HeaderText = "Ativo";

            // Preenche o grid com ajuste automático
            dgvEtapas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Ajuste individual:
            dgvEtapas.Columns["Id"].Width = 60;
            dgvEtapas.Columns["Nome"].Width = 200;
            dgvEtapas.Columns["Ordem"].Width = 100;
            dgvEtapas.Columns["Ativo"].Width = 60;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Etapas etapa = new Etapas()
            {
                Nome = txtNome.Text,
                Ordem = txtOrdem.Text,
                Ativo = rdbAtivo.Checked,
            };

            if (!ValidaDados(etapa))
                return;

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                _etapaController.Salvar(etapa);
            }
            else
            {
                etapa.Id = Convert.ToInt32(txtCodigo.Text);
                _etapaController.Atualizar(etapa);
            }

        }

        private bool ValidaDados(Etapas Etapa)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtOrdem.Text))
            {
                ExibirMensagem("O campo Ordem é obrigatório.");
                txtOrdem.Focus();
                return false;
            }
            if (!int.TryParse(txtOrdem.Text, out _))
            {
                ExibirMensagem("O campo Ordem deve ser número inteiro.");
                txtOrdem.Focus();
                return false;
            }

            return true;
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtOrdem.ReadOnly = false;
            pnlSituacao.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtOrdem.Clear();
            rdbAtivo.Checked = true;
        }

        public void DesabilitarCampos()
        {
            LimparCampos();

            txtNome.ReadOnly = true;
            txtOrdem.ReadOnly = true;
            pnlSituacao.Enabled = false;

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

        private void dgvEtapas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEtapas.Rows[e.RowIndex];

                txtCodigo.Text = row.Cells["Id"].Value.ToString();
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtOrdem.Text = row.Cells["Ordem"].Value.ToString();
                rdbAtivo.Checked = Convert.ToBoolean(row.Cells["Ativo"].Value);
                rdbInativo.Checked = !Convert.ToBoolean(row.Cells["Ativo"].Value);

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
                ExibirMensagem("Nenhum etapa selecionada para exclusão.");
                return;
            }
            else
            {
                DialogResult resultado = MessageBox.Show($"Deseja Excluir esta Etapa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtCodigo.Text);
                    _etapaController.Excluir(id);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.Trim();
            _etapaController.ListarEtapas(termo);
        }
    }
}
