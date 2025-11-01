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
        private AtendimentoController _atendimentoController; //adicionada esta linha
        private StatusAtendimentoController _statusAtendimentoController; //adicionada esta linha
        private FrmCadastroSituacaoAtendimento _cadastroSituacaoAtendimentoController ; // adicionar referência à tela de situação
        private FrmCadastroEtapa _cadastroEtapaController; // adicionar referência à tela de etapa atendimento

        public FrmAtendimento()
        {
            InitializeComponent();
            _atendimentoController = new AtendimentoController(this); //adicionada esta linha
            _cadastroSituacaoAtendimentoController = new FrmCadastroSituacaoAtendimento();
            _statusAtendimentoController = new StatusAtendimentoController(_cadastroSituacaoAtendimentoController);
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

        private void FrmAtendimento_Load(object sender, EventArgs e)
        {
            CarregarClientes(); //adicionada esta linha
            CarregarSituacaoAtendimento(); //adicionada esta linha
            CarregarEtapas(); //adicionada esta linha
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
    }
}
