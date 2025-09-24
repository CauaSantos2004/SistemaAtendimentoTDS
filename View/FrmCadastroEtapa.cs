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
        public FrmCadastroEtapa()
        {
            InitializeComponent();
        }

        private void rdbInativo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadastroEtapa_Load(object sender, EventArgs e)
        {
            
        }

        private void grbListaEtapas_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
        private void FrmCadastroEtapas_Load(object sender, EventArgs e)
        {

        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        // Método para exibir as etapas no DataGridView
        public void ExibirEtapas(List<Etapas> etapas)
        {
            dgvEtapas.DataSource = etapas;
            // 🔹 Atenção: verifique se o seu DataGridView realmente se chama "dgvEtapas".
            // Se o nome for outro (ex: dgvListaEtapas), troque aqui também.
        }


        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtOrdem.ReadOnly = false;

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
    }
}
