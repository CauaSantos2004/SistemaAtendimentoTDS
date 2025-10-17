namespace SistemaAtendimento.View
{
    partial class FrmCadastroSituacaoAtendimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroSituacaoAtendimento));
            lblCodigo = new Label();
            lblCor = new Label();
            label3 = new Label();
            lblPesquisar = new Label();
            lblNome = new Label();
            grbDadosSituacaoAtendimento = new GroupBox();
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            txtCor = new TextBox();
            pnlSituacao = new Panel();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblSituacao = new Label();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            imageList1 = new ImageList(components);
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            grbListaSituacoesAtendimento = new GroupBox();
            dgvListaSituacaoAtendimento = new DataGridView();
            grbDadosSituacaoAtendimento.SuspendLayout();
            pnlSituacao.SuspendLayout();
            grbListaSituacoesAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaSituacaoAtendimento).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(21, 30);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Location = new Point(22, 88);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(26, 15);
            lblCor.TabIndex = 1;
            lblCor.Text = "Cor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(500, 294);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(518, 204);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 3;
            lblPesquisar.Text = "Pesquisar";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(185, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // grbDadosSituacaoAtendimento
            // 
            grbDadosSituacaoAtendimento.Controls.Add(txtNome);
            grbDadosSituacaoAtendimento.Controls.Add(txtCodigo);
            grbDadosSituacaoAtendimento.Controls.Add(txtCor);
            grbDadosSituacaoAtendimento.Controls.Add(pnlSituacao);
            grbDadosSituacaoAtendimento.Controls.Add(lblSituacao);
            grbDadosSituacaoAtendimento.Controls.Add(lblCodigo);
            grbDadosSituacaoAtendimento.Controls.Add(lblNome);
            grbDadosSituacaoAtendimento.Controls.Add(lblCor);
            grbDadosSituacaoAtendimento.Location = new Point(12, 12);
            grbDadosSituacaoAtendimento.Name = "grbDadosSituacaoAtendimento";
            grbDadosSituacaoAtendimento.Size = new Size(776, 159);
            grbDadosSituacaoAtendimento.TabIndex = 5;
            grbDadosSituacaoAtendimento.TabStop = false;
            grbDadosSituacaoAtendimento.Text = "Dados da Situação do Atendimento";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(185, 48);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(569, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(22, 48);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(22, 105);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(270, 23);
            txtCor.TabIndex = 3;
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbInativo);
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Location = new Point(317, 105);
            pnlSituacao.Name = "pnlSituacao";
            pnlSituacao.Size = new Size(141, 31);
            pnlSituacao.TabIndex = 4;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(60, 3);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(3, 3);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(317, 88);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 7;
            lblSituacao.Text = "Situação";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(518, 222);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(220, 23);
            txtPesquisar.TabIndex = 10;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = imageList1;
            btnPesquisar.Location = new Point(744, 222);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(44, 25);
            btnPesquisar.TabIndex = 11;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icone-cancelar.png");
            imageList1.Images.SetKeyName(1, "icone-editar.png");
            imageList1.Images.SetKeyName(2, "icone-excluir.png");
            imageList1.Images.SetKeyName(3, "icone-novo.png");
            imageList1.Images.SetKeyName(4, "icone-pesquisar.png");
            imageList1.Images.SetKeyName(5, "icone-salvar.png");
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imageList1;
            btnCancelar.Location = new Point(398, 208);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 37);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imageList1;
            btnExcluir.Location = new Point(300, 208);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(70, 37);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imageList1;
            btnEditar.Location = new Point(108, 208);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(63, 37);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imageList1;
            btnSalvar.Location = new Point(210, 208);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(63, 37);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imageList1;
            btnNovo.Location = new Point(12, 208);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(63, 37);
            btnNovo.TabIndex = 5;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // grbListaSituacoesAtendimento
            // 
            grbListaSituacoesAtendimento.Controls.Add(dgvListaSituacaoAtendimento);
            grbListaSituacoesAtendimento.Location = new Point(12, 276);
            grbListaSituacoesAtendimento.Name = "grbListaSituacoesAtendimento";
            grbListaSituacoesAtendimento.Size = new Size(776, 170);
            grbListaSituacoesAtendimento.TabIndex = 37;
            grbListaSituacoesAtendimento.TabStop = false;
            grbListaSituacoesAtendimento.Text = "Lista de Situações do Atendimento";
            // 
            // dgvListaSituacaoAtendimento
            // 
            dgvListaSituacaoAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaSituacaoAtendimento.Location = new Point(6, 22);
            dgvListaSituacaoAtendimento.Name = "dgvListaSituacaoAtendimento";
            dgvListaSituacaoAtendimento.Size = new Size(764, 139);
            dgvListaSituacaoAtendimento.TabIndex = 0;
            dgvListaSituacaoAtendimento.CellDoubleClick += dgvListaSituacoesAtendimento_CellDoubleClick;
            // 
            // FrmCadastroSituacaoAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbListaSituacoesAtendimento);
            Controls.Add(txtPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosSituacaoAtendimento);
            Controls.Add(lblPesquisar);
            Controls.Add(label3);
            Name = "FrmCadastroSituacaoAtendimento";
            Text = "Cadastro de Status de Atendimentos";
            Load += FrmCadastroSituacaoAtendimento_Load;
            grbDadosSituacaoAtendimento.ResumeLayout(false);
            grbDadosSituacaoAtendimento.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            grbListaSituacoesAtendimento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaSituacaoAtendimento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblCor;
        private Label label3;
        private Label lblPesquisar;
        private Label lblNome;
        private GroupBox grbDadosSituacaoAtendimento;
        private Label lblSituacao;
        private Panel pnlSituacao;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private TextBox txtCor;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnCancelar;
        private GroupBox grbListaSituacoesAtendimento;
        private DataGridView dgvListaSituacaoAtendimento;
        private ImageList imageList1;
    }
}