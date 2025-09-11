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

namespace SistemaAtendimento
{
    public partial class FrmCadastroClientes : Form
    {
        private ClienteController _clienteController;
        public FrmCadastroClientes()
        {
            InitializeComponent();
            _clienteController = new ClienteController(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCelular_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroClientes_Load(object sender, EventArgs e)
        {
            _clienteController.ListarClientes();
        }

        //criamos uma função na qual exibe um alerta na tela
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }


        //alteração...
        public void ExibirClientes(List<Clientes> clientes)
        {
            dgvClientes.DataSource = clientes;
        }


        //alteração feita a partir aqui para anotação da aula
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //forma de criar um objeto
            Clientes cliente = new Clientes
            { 
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Cpf_Cnpj = txtCpfCnpj.Text,
                TipoPessoa = rdbFisica.Checked ? "F" : "J",
                Telefone = txtTelefone.Text,
                Celular = txtCelular.Text,
                Cep = txtCep.Text,
                Endereco = txtEndereco.Text,
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Estado = cbxEstado.Text,
                Ativo = rdbAtivo.Checked,
            };
            
            if(!ValidarDados(cliente))
                return;

            _clienteController.Salvar(cliente);
        }

        //funçao que vai fazer validação dos campos antes de cadastrar no banco de dados
        //se os campos forem preenchidos da meneira correta ele retornará verdadeiro e exibirá uma mensagem dizendo que o campo deve ser preenchido
        public bool ValidarDados(Clientes clientes)
        {
            if(string .IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O campo Nome é obrigatório. Por favor, preencha-o.");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ExibirMensagem("O campo Email é obrigatório. Por favor, preencha-o.");
                txtEmail.Focus();
                return false;
            }

            //validação do cpf e cnpj, para pessoa fisica exibe uma mensagem e para pessoa juridica exibe outra mensagem
            if (string.IsNullOrWhiteSpace(txtCpfCnpj.Text))
            {
                if (rdbFisica.Checked)
                {
                    ExibirMensagem("O campo CPF é obrigatório. Por favor, preencha-o.");
                }
                else 
                {
                    ExibirMensagem("O campo CNPJ é obrigatório. Por favor, preencha-o.");
                }

                txtCpfCnpj.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                ExibirMensagem("O campo Endereço é obrigatório. Por favor, preencha-o.");
                txtEndereco.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                ExibirMensagem("O campo Número é obrigatório. Por favor, preencha-o.");
                txtNumero.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                ExibirMensagem("O campo Bairro é obrigatório. Por favor, preencha-o.");
                txtBairro.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                ExibirMensagem("O campo Cidade é obrigatório. Por favor, preencha-o.");
                txtCidade.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbxEstado.Text))
            {
                ExibirMensagem("O campo Estado é obrigatório. Por favor, preencha-o.");
                cbxEstado.Focus();
                return false;
            }

            return true;
        }
    }
}
