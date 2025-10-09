using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAtendimento.View
{
    public partial class FrmAtendimento : Form
    {
        public FrmAtendimento()
        {
            InitializeComponent();
        }

        private void btnPesquisarAtendimento_Click(object sender, EventArgs e)
        {
            FrmConsultaAtendimento frmConsultaAtendimento = new FrmConsultaAtendimento();
            frmConsultaAtendimento.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAtendimento_Load(object sender, EventArgs e)
        {

        }
    }
}
