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

        //função executada ao carregar o formulário
        private void FrmConsultaAtendimento_Load(object sender, EventArgs e)
        {
            _consultaAtendimentoController.ListarAtendimento(); //chama o controller para listar os atendimentos
        }

        //função para exibir mensagens na tela
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        //função para exibir os atendimentos na grid
        public void ExibirAtendimentos(List<Atendimentos> atendimentos)
        {  
            dgvConsultaAtendimento.DataSource = atendimentos;
            dgvConsultaAtendimento.Refresh();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //
            string termo = txtFiltro.Text.Trim(); //pega o texto do filtro
            string condicao = cbxFiltro.Text.Trim(); //pega a condição do filtro
            _consultaAtendimentoController.ListarAtendimento(termo, condicao); //chama o controller para listar os atendimentos com o filtro
        }

        private void dgvConsultaAtendimento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int Id = (int)dgvConsultaAtendimento.Rows[e.RowIndex].Cells["Id"].Value;

                FrmAtendimento frmAtendimento = new FrmAtendimento(Id);

                frmAtendimento.Show(); // 1. Abre a tela de atendimento
                this.Close();          // 2. Fecha a tela de consulta
            }
        }
    }
}
