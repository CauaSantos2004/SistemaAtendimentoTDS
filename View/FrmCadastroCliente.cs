using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
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



        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
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

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                // Se o código está vazio, é um novo cliente — então salva (INSERT)
                _clienteController.Salvar(cliente);
            }
            else
            {
                // Se tem código, então é um cliente existente — atualiza (UPDATE)
                cliente.Id = Convert.ToInt32(txtCodigo.Text);
                _clienteController.Atualizar(cliente);
            }
        }

        //funçao que vai fazer validação dos campos antes de cadastrar no banco de dados
        //se os campos forem preenchidos da meneira correta ele retornará verdadeiro e exibirá uma mensagem dizendo que o campo deve ser preenchido
        public bool ValidarDados(Clientes clientes)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
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
                if (rdbFisica.Checked) //se o rdbFisica estiver marcado:
                {
                    ExibirMensagem("O campo CPF é obrigatório. Por favor, preencha-o.");
                }
                else // caso contrário:
                {
                    ExibirMensagem("O campo CNPJ é obrigatório. Por favor, preencha-o.");
                }

                txtCpfCnpj.Focus();
                return false;
            }
            else
            {
                if (rdbFisica.Checked)
                {
                    //verificar se o cpf é valido  
                }
                else if (rdbJuridico.Checked)
                {
                    //verificar se o cnpj é valido 
                }
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

        private void rdbJuridico_CheckedChanged(object sender, EventArgs e)
        {
            lblCpfCnpj.Text = "CNPJ"; // Quando o usuário marcar o RadioButton "Jurídico",
                                      // o texto do Label lblCpfCnpj será alterado para "CNPJ".
        }

        private void rdbFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCpfCnpj.Text = "CPF"; // Quando o usuário marcar o RadioButton "Fisico",
                                     // o texto do Label lblCpfCnpj será alterado para "CPF".
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;
            txtCpfCnpj.ReadOnly = false;
            txtCep.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtBairro.ReadOnly = false;
            txtComplemento.ReadOnly = false;
            txtCidade.ReadOnly = false;
            cbxEstado.Enabled = true;
            pnlTipoPessoa.Enabled = true;
            pnlSituacao.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtCpfCnpj.Clear();
            txtCep.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            rdbFisica.Checked = true;
            rdbAtivo.Checked = true;
            cbxEstado.Text = "";
        }

        public void DesabilitarCampos()
        {
            LimparCampos();
            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtCelular.ReadOnly = true;
            txtCpfCnpj.ReadOnly = true;
            txtCep.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtBairro.ReadOnly = true;
            txtComplemento.ReadOnly = true;
            txtCidade.ReadOnly = true;
            cbxEstado.Enabled = false;
            pnlSituacao.Enabled = true;
            pnlTipoPessoa.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

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

        private void dgvClientes_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelecionada = dgvClientes.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelecionada.Cells["Id"].Value.ToString();
                txtNome.Text = linhaSelecionada.Cells["Nome"].Value.ToString();
                txtEmail.Text = linhaSelecionada.Cells["Email"].Value.ToString();
                txtCpfCnpj.Text = linhaSelecionada.Cells["Cpf_Cnpj"].Value.ToString();
                txtTelefone.Text = linhaSelecionada.Cells["Telefone"].Value.ToString();
                txtCelular.Text = linhaSelecionada.Cells["Celular"].Value.ToString();
                txtCep.Text = linhaSelecionada.Cells["Cep"].Value.ToString();
                txtEndereco.Text = linhaSelecionada.Cells["Endereco"].Value.ToString();
                txtNumero.Text = linhaSelecionada.Cells["Numero"].Value.ToString();
                txtComplemento.Text = linhaSelecionada.Cells["Complemento"].Value.ToString();
                txtBairro.Text = linhaSelecionada.Cells["Bairro"].Value.ToString();
                txtCidade.Text = linhaSelecionada.Cells["Cidade"].Value.ToString();
                cbxEstado.Text = linhaSelecionada.Cells["Estado"].Value.ToString();

                rdbFisica.Checked = linhaSelecionada.Cells["TipoPessoa"].Value.ToString() == "F";
                rdbJuridico.Checked = linhaSelecionada.Cells["TipoPessoa"].Value.ToString() == "J";

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
                ExibirMensagem("Selecione um Cliente");
                return;
            }

            //craindo um alerta
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este cliente?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                _clienteController.Excluir(id);
            }
        }

        private async Task BuscarEnderecoPorCep(string cep)
        {
            try
            {
                //"Replace" substitui por espaços o cep digitado com traços
                cep = cep.Replace("-", "-").Trim();

                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";

                    var response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await
                            response.Content.ReadAsStringAsync();

                        dynamic? dadosEndereco =
                            JsonConvert.DeserializeObject(json);

                        txtEndereco.Text = dadosEndereco?.logradouro;
                        txtBairro.Text = dadosEndereco?.bairro;
                        txtCidade.Text = dadosEndereco?.localidade;
                        cbxEstado.Text = dadosEndereco?.uf;

                    }

                }
            }


            catch (Exception ex)
            {
                ExibirMensagem($"Erro ao buscar o Endereço: {ex.Message}");
            }
        }

        private async void txtCep_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCep.Text)) // "!string.IsNullOrEmpty" Pergunta "não esta nulo e vazio?" então executa
            {
                await BuscarEnderecoPorCep(txtCep.Text);
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.Trim();
            _clienteController.ListarClientes(termo);
        }
    }

}       
