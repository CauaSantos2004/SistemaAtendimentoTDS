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
            string condicao = cbxFiltro.Text.Trim();
            _consultaAtendimentoController.ListarAtendimento(termo, condicao);
        }

        private void dgvConsultaAtendimento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         

            if (e.RowIndex >= 0)
            {
                int id  = (int)dgvConsultaAtendimento.Rows[e.RowIndex].Cells["Id"].Value;

                //MessageBox.Show(id.ToString());
                this.Close();
                var atendimento = new FrmAtendimento(id);
                atendimento.Show();
             }
           
        }
    }
}
