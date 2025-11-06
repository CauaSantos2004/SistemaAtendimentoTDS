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
using SistemaAtendimento.Model.SistemaAtendimento.Model;

namespace SistemaAtendimento.View
{
    public partial class FrmAtendimento : Form 
    {
        private AtendimentoController _atendimentoController; //adicionada esta linha
        private StatusAtendimentoController _statusAtendimentoController; //adicionada esta linha
        private FrmCadastroSituacaoAtendimento _cadastroSituacaoAtendimentoController; // adicionar referência à tela de situação
        private FrmCadastroEtapa _cadastroEtapaController; // adicionar referência à tela de etapa atendimento

        public FrmAtendimento() //construtor do formulário
        {
            //inicializa os componentes do formulário
            InitializeComponent();

            _atendimentoController = new AtendimentoController(this); //adicionada esta linha
            _cadastroSituacaoAtendimentoController = new FrmCadastroSituacaoAtendimento();
            _statusAtendimentoController = new StatusAtendimentoController(_cadastroSituacaoAtendimentoController);
            _cadastroEtapaController = new FrmCadastroEtapa();
        }

        private void btnPesquisarAtendimento_Click(object sender, EventArgs e)
        {
            FrmConsultaAtendimento frmConsultaAtendimento = new FrmConsultaAtendimento(); 
            frmConsultaAtendimento.ShowDialog();
        }

        //função para carregar os clientes, adicionada esta parte
        private void CarregarClientes()
        {
            //obter a lista de clientes do controller
            var clientes = _atendimentoController.ListarClientes(); //adicionada esta linha
            cbxNomeCliente.DataSource = clientes; //adicionada esta linha
            cbxNomeCliente.DisplayMember = "Nome"; //adicionada esta linha, para mostrar o nome no combobox
            cbxNomeCliente.SelectedIndex = -1; //adicionada esta linha, para não selecionar nenhum item inicialmente
            cbxNomeCliente.ValueMember = "Id"; //adicionada esta linha, para definir o valor do item como o Id do cliente

            //Filtros de auto complete no combobox de clientes( Tras automaticamente o nome do cliente ao digitar )
            cbxNomeCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend; //adicionada esta linha
            cbxNomeCliente.AutoCompleteSource = AutoCompleteSource.ListItems; //adicionada esta linha

        }

        //função para carregar os status atendimento, adicionada esta parte
        private void CarregarSituacaoAtendimento()
        {
            //obter a lista de status atendimento do controller
            var statusAtendimento = _atendimentoController.ListarSituacaoAtendimento(); //adicionada esta linha
            cbxSituacaoAtendimento.DataSource = statusAtendimento; 
            cbxSituacaoAtendimento.DisplayMember = "Nome"; //adicionada esta linha, para mostrar a descrição no combobox
            cbxSituacaoAtendimento.SelectedIndex = -1; //adicionada esta linha, para não selecionar nenhum item inicialmente
            cbxSituacaoAtendimento.ValueMember = "Id"; //adicionada esta linha, para definir o valor do item como o Id do status atendimento
            //Filtros de auto complete no combobox de status atendimento( Tras automaticamente o nome do status ao digitar )
            cbxSituacaoAtendimento.AutoCompleteMode = AutoCompleteMode.SuggestAppend; //adicionada esta linha
            cbxSituacaoAtendimento.AutoCompleteSource = AutoCompleteSource.ListItems; //adicionada esta linha

        }

        //função para carregar as etapas atendimento, adicionada esta parte
        private void CarregarEtapas()
        {
            //obter a lista de etapas atendimento do controller
            var etapasAtendimento = _atendimentoController.ListarEtapasAtendimento(); //adicionada esta linha
            cbxEtapaAtendimento.DataSource = etapasAtendimento;
            cbxEtapaAtendimento.DisplayMember = "Nome"; //adicionada esta linha, para mostrar a descrição no combobox
            cbxEtapaAtendimento.SelectedIndex = -1; //adicionada esta linha, para não selecionar nenhum item inicialmente
            cbxEtapaAtendimento.ValueMember = "Id"; //adicionada esta linha, para definir o valor do item como o Id da etapa atendimento
            //Filtros de auto complete no combobox de etapas atendimento( Tras automaticamente o nome da etapa ao digitar )
            cbxEtapaAtendimento.AutoCompleteMode = AutoCompleteMode.SuggestAppend; //adicionada esta linha
            cbxEtapaAtendimento.AutoCompleteSource = AutoCompleteSource.ListItems; //adicionada esta linha
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAtendimento_Load(object sender, EventArgs e) //
        {
            CarregarClientes(); //adicionada esta linha, para carregar os clientes no combobox ao carregar o formulário
            CarregarSituacaoAtendimento(); //adicionada esta linha, para carregar os status atendimento no combobox ao carregar o formulário
            CarregarEtapas(); //adicionada esta linha, para carregar as etapas atendimento no combobox ao carregar o formulário
        }

        private void cbxNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sincronizar o combobox com o textbox do código do cliente
            txtCodigoCliente.Clear(); //adicionada esta linha, para limpar o textbox antes de atribuir um novo valor
            if (cbxNomeCliente.SelectedValue != null) //adicionada esta linha, para evitar erro ao selecionar um item
            {
                txtCodigoCliente.Text = cbxNomeCliente.SelectedValue.ToString(); //adicionada esta linha, para atribuir o valor do Id do cliente ao textbox
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos(); //chama a função para habilitar os campos ao clicar no botão novo
        }

        //função para habilitar os campos
        private void HabilitarCampos()
        {
            grbEtapaAtendimento.Enabled = true;
            cbxNomeCliente.Enabled = true;
            dtpAberturaAtendimento.Enabled = true;
            cbxSituacaoAtendimento.Enabled = true;
            txtObservacaoAtendimento.ReadOnly = false;

            //Habilita os botões
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesativarCampos(); //chama a função para desabilitar os campos ao clicar no botão cancelar
        }


        private void DesativarCampos() //função para desabilitar os campos
        {
            LimparCampos(); //chama a função para limpar os campos

            //Desabilita os campos
            grbEtapaAtendimento.Enabled = false;
            cbxNomeCliente.Enabled = false;
            dtpAberturaAtendimento.Enabled = false;
            cbxSituacaoAtendimento.Enabled = false;
            txtObservacaoAtendimento.ReadOnly = true;

            //Desabilita os botões
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void LimparCampos() //função para limpar os campos
        {
            txtCodigoCliente.Clear();
            cbxNomeCliente.SelectedIndex = -1;
            cbxSituacaoAtendimento.SelectedIndex = -1;
            txtObservacaoAtendimento.Clear(); 
            dtpAberturaAtendimento.Value = DateTime.Now; //define a data atual como padrão
        }

        private void lblObservacoes2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Atendimentos atendimento = new Atendimentos //criando um objeto atendimento para salvar os dados
            {
                //todas as colunas da tabela Atendimentos do banco de dados
                ClienteId = string.IsNullOrWhiteSpace(txtCodigoCliente.Text) ? null : Convert.ToInt32(txtCodigoCliente.Text), //verifica se o campo código do cliente está vazio, se estiver atribui null, se não converte para int
                UsuarioId = 1,
                SituacaoAtendimentoId = cbxSituacaoAtendimento.SelectedValue == null ? null : Convert.ToInt32 (cbxSituacaoAtendimento.SelectedValue), //convertendo o código da situação do atendimento para int e pegando do combobox
                DataAbertura = dtpAberturaAtendimento.Value,
                Observacao = txtObservacaoAtendimento.Text //
            };

            if(!ValidarDados(atendimento)) //chama a função para validar os dados antes de salvar o atendimento
                return;
            _atendimentoController.Salvar(atendimento); //chama a função para salvar o atendimento no banco de dados
        }

        //função para exibir mensagens na tela
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem); //exibe a mensagem em uma caixa de diálogo
        }

        //função para validar os dados antes de salvar o atendimento
        private bool ValidarDados(Atendimentos atendimento)
        {
            //validação do campo cliente
            if (string.IsNullOrWhiteSpace(cbxNomeCliente.Text)) //se o campo cliente estiver vazio
            {
                ExibirMensagem("O campo Cliente é obrigatório. Por favor, selecione um cliente.");
                cbxNomeCliente.Focus(); //coloca o cursor no combobox do Nome

                return false;
            }

            //validação do campo situação do atendimento
            if (cbxSituacaoAtendimento.SelectedValue == null) //se o campo situação do atendimento estiver vazio
            {
                ExibirMensagem("O campo Situação do Atendimento é obrigatório. Por favor, selecione uma situação.");
                cbxSituacaoAtendimento.Focus(); //coloca o cursor no combobox da Situação do Atendimento

                return false;

            }

            //validação do campo observação do atendimento
            if (string.IsNullOrWhiteSpace(txtObservacaoAtendimento.Text)) //se o campo observação estiver vazio
            {
                ExibirMensagem("O campo Observação é obrigatório. Por favor, preencha a observação do atendimento.");
                txtObservacaoAtendimento.Focus(); //coloca o cursor no textbox da Observação

                return false; 
            }
            return true;
        
        
        }
        




    }
}
