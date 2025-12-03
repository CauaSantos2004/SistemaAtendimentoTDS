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
        private EtapasAtendimentoController _etapasAtendimentoController;

        private int? _atendimentoId;
        public FrmAtendimento(int? atendimentoId = null)
        {
            InitializeComponent();
            _atendimentoController = new AtendimentoController(this);

            _etapasAtendimentoController = new EtapasAtendimentoController(this);

            _atendimentoId = atendimentoId;
        }


        private void btnPesquisarAtendimento_Click(object sender, EventArgs e)
        {
            FrmConsultaAtendimento frmConsultaAtendimento = new FrmConsultaAtendimento();
            frmConsultaAtendimento.ShowDialog();
        }

        // método para carregar os clientes no combobox
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

        // método para carregar as etapas de atendimento no combobox
        private void CarregarEtapas()
        {
            var etapas = _atendimentoController.ListarEtapas();

            cbxEtapaAtendimento.DataSource = etapas;
            cbxEtapaAtendimento.DisplayMember = "Nome";
            cbxEtapaAtendimento.SelectedIndex = -1;
            cbxEtapaAtendimento.ValueMember = "Id";


        }

        // método para carregar a situação do atendimento no combobox
        private void CarregarSituacaoAtendimento()
        {
            var situacaoAtendimentos = _atendimentoController.ListarSituacaoAtendimento();

            cbxSituacaoAtendimento.DataSource = situacaoAtendimentos;
            cbxSituacaoAtendimento.DisplayMember = "Nome";
            cbxSituacaoAtendimento.SelectedIndex = -1;
            cbxSituacaoAtendimento.ValueMember = "Id";


        }

        // Evento Load do Formulário
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
                    // preencher os campos do formulário com os dados do atendimento
                    PreencherCampos(atendimento);

                    grbEtaspasAtendimento.Enabled = true;

                    CarregarEtaspasAtendimento();


                }
            }
        }

        // método para preencher os campos do formulário com os dados do atendimento
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

        // método para habilitar os campos do formulário
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

        // método para desativar os campos do formulário
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

        // método para limpar os campos do formulário
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

                grbEtaspasAtendimento.Enabled = true; // habilitar o grupo de etapas de atendimento
                CarregarEtaspasAtendimento(); // carregar as etapas de atendimento no DataGridView


            }

        }

        // método para validar os dados do atendimento
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

        // método para exibir mensagens ao usuário
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem); //Exibir a mensagem em uma caixa de diálogo
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

        // método para carregar as etapas de atendimento no DataGridView
        private void CarregarEtaspasAtendimento()
        {
            if (!_atendimentoId.HasValue)
            {
                return;
            }

            dgvEtapasAtendimento.DataSource = _etapasAtendimentoController.Listar(_atendimentoId.Value);

        }

        private void btnAdicionarEtapa_Click(object sender, EventArgs e)
        {
            // validar se o atendimento foi salvo antes de adicionar etapas
            if (!_atendimentoId.HasValue)
            {
                MessageBox.Show("Salve o atendimento antes de adicionar etapas.");
                return;
            }
            // validar se uma etapa foi selecionada
            if (cbxEtapaAtendimento.SelectedValue == null)
            {
                MessageBox.Show("Selecione uma etapa.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtObservacaoAtendimento.Text))
            {
                ExibirMensagem("Digite uma observação do Atendimento");
                txtEtapaObservacao.Focus();
                return;

            }
            var etapaAtendimento = new EtapasAtendimentos
            {
                AtendimentoId = _atendimentoId.Value,
                EtapaId = Convert.ToInt32(cbxEtapaAtendimento.SelectedValue),
                UsuarioId = 1,
                DataCadastro = DateTime.Now,
                Observacao = txtEtapaObservacao.Text
            };

            _etapasAtendimentoController.Salvar(etapaAtendimento);

            cbxEtapaAtendimento.SelectedIndex = -1;
            txtEtapaObservacao.Clear();
            CarregarEtaspasAtendimento();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        // método para excluir uma etapa de atendimento
        private void btnExcluirEtapa_Click(object sender, EventArgs e)
        {
            if(dgvEtapasAtendimento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma etapa para excluir.");
                return;
            }

            int id = Convert.ToInt32(dgvEtapasAtendimento.SelectedRows[0].Cells["Id"].Value); //pega o ID da etapa selecionada

            var confirmar = MessageBox.Show("Tem certeza que deseja excluir esta etapa?", "Confirmação", MessageBoxButtons.YesNo); //pergunta se o usuário tem certeza que deseja excluir a etapa
            
            if (confirmar == DialogResult.Yes) //se o usuário clicar em sim
            {
                _etapasAtendimentoController.Excluir(id); //chama o método excluir do controller
                CarregarEtaspasAtendimento(); //recarrega as etapas de atendimento no DataGridView
            }
        }
    }
}
