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
        private EtapasController _etapaController;
        public FrmCadastroEtapa()
        {
            InitializeComponent();
            _etapaController = new EtapasController(this);
        }

        public void ExibirEtapas(List<Etapas> etapas)
        {
            dgvEtapas.DataSource = etapas;
        }

        private void FrmCadastroEtapa_Load(object sender, EventArgs e)
        {
            _etapaController.ListarEtapas();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Etapas etapa = new Etapas()
            {
                Nome = txtNome.Text,
                Ordem = Convert.ToInt32(txtOrdem.Text),
                Ativo = rdbAtivo.Checked,
            };

            if (!ValidarDados(etapa))
                return;

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                _etapaController.Atualizar(etapa);
            }
            else
            {
                etapa.Id = Convert.ToInt32(txtCodigo.Text);
                _etapaController.Atualizar(etapa);
            }
        }

        public bool ValidarDados(Etapas etapa)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O campo Nome da Etapa é obrigatório. Por favor, preencha-o.");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtOrdem.Text))
            {
                ExibirMensagem("O campo Ordem é obrigatório. Por favor, preencha-o.");
                txtOrdem.Focus();
                return false;
            }

            // retorno garantido em todos os casos
            return true;
        }


        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            pnlSituacao.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtOrdem.Clear();
            pnlSituacao.Enabled = true;

            rdbAtivo.Checked = true;
            rdbInativo.Checked = true;
        }
        public void DesabilitarCampos()
        {
            LimparCampos();
            txtNome.ReadOnly = true;
            txtOrdem.ReadOnly = true;
            pnlSituacao.Enabled = true;

            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void dgvEtapas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelecionada = dgvEtapas.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelecionada.Cells["Id"].Value.ToString();
                txtNome.Text = linhaSelecionada.Cells["Nome"].Value.ToString();

                rdbAtivo.Checked = Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value);
                rdbInativo.Checked = !Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value);

                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;




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
                ExibirMensagem("Selecione um Etapa");
                return;
            }

            //craindo um alerta
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esta etapa?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                _etapaController.Excluir(id);
            }

        }
    }
}
