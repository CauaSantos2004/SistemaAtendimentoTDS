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
    public partial class FrmConsultaAtendimento : Form
    {
        private ConsultaAtendimentoController _consultaAtendimentoController;

        public FrmConsultaAtendimento()
        {
            InitializeComponent();
            _consultaAtendimentoController = new ConsultaAtendimentoController(this);
        }

        private void FrmConsultaAtendimento_Load(object sender, EventArgs e)
        {
            _consultaAtendimentoController.ListarAtendimento();
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void ExibirAtendimentos(List<Atendimentos> atendimentos)
        {
            dgvConsultaAtendimento.DataSource = atendimentos;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtFiltro.Text.Trim();
            _consultaAtendimentoController.ListarAtendimento(termo);
        }
    }
}
