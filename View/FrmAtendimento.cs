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
    public partial class FrmAtendimento : Form
    {

        private AtendimentoController _atendimentoController;

        private int? _atendimentoId;
        public FrmAtendimento(int? atendimentoId = null)
        {
            InitializeComponent();
            _atendimentoController = new AtendimentoController(this);

            _atendimentoId = atendimentoId;
        }


        private void btnPesquisarAtendimento_Click(object sender, EventArgs e)
        {
            FrmConsultaAtendimento frmConsultaAtendimento = new FrmConsultaAtendimento();
            frmConsultaAtendimento.ShowDialog();
        }


        private void CarregarClientes()
        {
            var clientes = _atendimentoController.ListarClientes();

            cbxNomeCliente.DataSource = clientes;
            cbxNomeCliente.DisplayMember = "Nome";
            cbxNomeCliente.SelectedIndex = -1;
            cbxNomeCliente.ValueMember = "Id";
            //Filtros no Combobox
            cbxNomeCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxNomeCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void CarregarEtapas()
        {
            var etapas = _atendimentoController.ListarEtapas();

            cbxEtapaAtendimento.DataSource = etapas;
            cbxEtapaAtendimento.DisplayMember = "Nome";
            cbxEtapaAtendimento.SelectedIndex = -1;
            cbxEtapaAtendimento.ValueMember = "Id";


        }

        private void CarregarSituacaoAtendimento()
        {
            var situacaoAtendimentos = _atendimentoController.ListarSituacaoAtendimento();

            cbxSituacaoAtendimento.DataSource = situacaoAtendimentos;
            cbxSituacaoAtendimento.DisplayMember = "Nome";
            cbxSituacaoAtendimento.SelectedIndex = -1;
            cbxSituacaoAtendimento.ValueMember = "Id";


        }

        private void FrmAtendimento_Load(object sender, EventArgs e)
        {
            CarregarClientes();
            CarregarEtapas();
            CarregarSituacaoAtendimento();

            if (_atendimentoId.HasValue)
            {
                var atendimento = _atendimentoController.BuscarAtendimentoPorId(_atendimentoId.Value);

                if (atendimento != null)
                {
                    //Preencher campos
                    PreencherCampos(atendimento);
                }
            }
        }

        private void PreencherCampos(Atendimentos atendimento)
        {
            txtCodigoAtendimento.Text = atendimento.Id.ToString();
            txtCodigoCliente.Text = atendimento.ClienteId.ToString();
            cbxNomeCliente.SelectedValue = atendimento.ClienteId;
            cbxSituacaoAtendimento.SelectedValue = atendimento.SituacaoAtendimentoId;
            dtpAberturaAtendimento.Value = atendimento.DataAbertura ?? DateTime.Now;
            txtObservacaoAtendimento.Text = atendimento.Observacao;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            btnFinalizar.Enabled = true;
            cbxSituacaoAtendimento.Enabled = true;
            txtObservacaoAtendimento.ReadOnly = false;



        }

        private void cbxNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoCliente.Clear();

            if (cbxNomeCliente.SelectedValue != null)
            {
                txtCodigoCliente.Text = cbxNomeCliente.SelectedValue.ToString();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            cbxNomeCliente.Enabled = true;
            dtpAberturaAtendimento.Enabled = true;
            cbxSituacaoAtendimento.Enabled = true;
            txtObservacaoAtendimento.ReadOnly = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesativarCampos();
        }

        private void DesativarCampos()
        {
            LimparCampos();
            cbxNomeCliente.Enabled = false;
            dtpAberturaAtendimento.Enabled = false;
            cbxSituacaoAtendimento.Enabled = false;
            txtObservacaoAtendimento.ReadOnly = true;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void LimparCampos()
        {
            txtCodigoCliente.Clear();
            txtCodigoAtendimento.Clear();
            cbxNomeCliente.SelectedIndex = -1;
            cbxSituacaoAtendimento.SelectedIndex = -1;
            txtObservacaoAtendimento.Clear();
            dtpAberturaAtendimento.Value = DateTime.Now;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Atendimentos atendimento = new Atendimentos
            {
                Id = _atendimentoId ?? null,
                ClienteId = string.IsNullOrWhiteSpace(txtCodigoCliente.Text) ? null : Convert.ToInt32(txtCodigoCliente.Text),
                UsuarioId = 1,
                SituacaoAtendimentoId = cbxSituacaoAtendimento.SelectedValue == null ? null : Convert.ToInt32(cbxSituacaoAtendimento.SelectedValue),
                DataAbertura = dtpAberturaAtendimento.Value,
                Observacao = txtObservacaoAtendimento.Text
            };

            if (!ValidarDados(atendimento))
                return;

            if (_atendimentoId.HasValue && _atendimentoId > 0)
            {
                _atendimentoController.Atualizar(atendimento);
            }
            else
            {
                int? atendimentoId = _atendimentoController.Salvar(atendimento);

                txtCodigoAtendimento.Text = atendimentoId.ToString();

                _atendimentoId = atendimentoId;

                btnExcluir.Enabled = true;

            }

        }

        private bool ValidarDados(Atendimentos atendimento)
        {
            //Criar Regras de Validação de Campos
            if (string.IsNullOrWhiteSpace(txtCodigoCliente.Text))
            {
                ExibirMensagem("Selecione um Cliente");
                cbxNomeCliente.Focus();
                return false;
            }

            if (cbxSituacaoAtendimento.SelectedValue == null)
            {
                ExibirMensagem("Selecione uma Situação do Atendimento");
                cbxSituacaoAtendimento.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtObservacaoAtendimento.Text))
            {
                ExibirMensagem("Digite uma observação do Atendimento");
                txtObservacaoAtendimento.Focus();
                return false;

            }


            return true;
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja Excluir este Cliente?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCodigoAtendimento.Text);
                _atendimentoController.Excluir(id);
                DesativarCampos();

            }
        }
    }
}
