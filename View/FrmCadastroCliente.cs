using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;

namespace SistemaAtendimento
{
    public partial class FrmCadastroCliente : Form
    {
        private ClienteController _clienteController;

        public FrmCadastroCliente()
        {
            InitializeComponent();
            _clienteController = new ClienteController(this);
        }




        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);

        }

        public void ExibirClientes(List<Clientes> clientes)
        {
            dgvClientes.DataSource = clientes;
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            _clienteController.ListarClientes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
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

            if (!ValidarDados(cliente))
                return;

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                _clienteController.Salvar(cliente);
            }
            else
            {
                cliente.Id = Convert.ToInt32(txtCodigo.Text);
                _clienteController.Atualizar(cliente);
            }



        }

        public bool ValidarDados(Clientes cliente)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O Campo Nome é Obrigatório");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ExibirMensagem("O Campo E-mail é Obrigatório");
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCpfCnpj.Text))
            {

                if (rdbFisica.Checked)
                {
                    ExibirMensagem("O Campo CPF é Obrigatório");
                }
                else
                {
                    ExibirMensagem("O Campo CNPJ é Obrigatório");
                }


                txtCpfCnpj.Focus();
                return false;
            }
            else
            {
                if (rdbFisica.Checked)
                {
                    //verificar se o CPF é válido
                }
                else
                {
                    //Verificar se o CNPJ é válido
                }
            }


            if (string.IsNullOrWhiteSpace(txtCep.Text))
            {
                ExibirMensagem("O Campo CEP é Obrigatório");
                txtCep.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                ExibirMensagem("O Campo Endereço é Obrigatório");
                txtEndereco.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                ExibirMensagem("O Campo Número é Obrigatório");
                txtNumero.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                ExibirMensagem("O Campo Bairro é Obrigatório");
                txtBairro.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                ExibirMensagem("O Campo Cidade é Obrigatório");
                txtCidade.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbxEstado.Text))
            {
                ExibirMensagem("O Campo Estado é Obrigatório");
                cbxEstado.Focus();
                return false;
            }


            return true;
        }

        private void rdbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblCpfCnpj.Text = "CNPJ";
        }

        private void rdbFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCpfCnpj.Text = "CPF";
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;
            pnlTipoPessoa.Enabled = true;
            txtCpfCnpj.ReadOnly = false;
            txtCep.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtComplemento.ReadOnly = false;
            txtCidade.ReadOnly = false;
            txtBairro.ReadOnly = false;
            cbxEstado.Enabled = true;
            pnlSituacao.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtCep.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtCpfCnpj.Clear();
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
            pnlTipoPessoa.Enabled = false;
            txtCpfCnpj.ReadOnly = true;
            txtCep.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtComplemento.ReadOnly = true;
            txtCidade.ReadOnly = true;
            txtBairro.ReadOnly = true;
            cbxEstado.Enabled = false;
            pnlSituacao.Enabled = true;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
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
                rdbJuridica.Checked = linhaSelecionada.Cells["TipoPessoa"].Value.ToString() == "J";

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

            DialogResult resultado = MessageBox.Show("Deseja Excluir este Cliente?",
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

                cep = cep.Replace("-", "").Trim();

                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";

                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();

                        dynamic? dadosEndereco = JsonConvert.DeserializeObject(json);

                        if (dadosEndereco?.ContainsKey("erro") && (bool)dadosEndereco?.erro)
                        {
                            ExibirMensagem("CEP não encontrado. Verifique e tente novamente.");
                            return;
                        }

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
            if (!string.IsNullOrEmpty(txtCep.Text))
            {
                await BuscarEnderecoPorCep(txtCep.Text);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.Trim();
            _clienteController.ListarClientes(termo);
        }

        
    }
}
