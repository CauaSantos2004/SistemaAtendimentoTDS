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
            grbListaSituacoesAtendimento = new GroupBox();
            dgvSituacoesAtendimento = new DataGridView();
            btnPesquisar = new Button();
            imlIcones = new ImageList(components);
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnNovo = new Button();
            grbDadosSituacaoAtendimento = new GroupBox();
            pnlSituacao = new Panel();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblSituacao = new Label();
            txtCor = new TextBox();
            lblCor = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            grbListaSituacoesAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSituacoesAtendimento).BeginInit();
            grbDadosSituacaoAtendimento.SuspendLayout();
            pnlSituacao.SuspendLayout();
            SuspendLayout();
            // 
            // grbListaSituacoesAtendimento
            // 
            grbListaSituacoesAtendimento.Controls.Add(dgvSituacoesAtendimento);
            grbListaSituacoesAtendimento.Location = new Point(17, 237);
            grbListaSituacoesAtendimento.Name = "grbListaSituacoesAtendimento";
            grbListaSituacoesAtendimento.Size = new Size(767, 243);
            grbListaSituacoesAtendimento.TabIndex = 44;
            grbListaSituacoesAtendimento.TabStop = false;
            grbListaSituacoesAtendimento.Text = "Lista de Situações do Atendimento";
            // 
            // dgvSituacoesAtendimento
            // 
            dgvSituacoesAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSituacoesAtendimento.Location = new Point(6, 22);
            dgvSituacoesAtendimento.MultiSelect = false;
            dgvSituacoesAtendimento.Name = "dgvSituacoesAtendimento";
            dgvSituacoesAtendimento.ReadOnly = true;
            dgvSituacoesAtendimento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSituacoesAtendimento.Size = new Size(755, 215);
            dgvSituacoesAtendimento.TabIndex = 0;
            dgvSituacoesAtendimento.CellMouseDoubleClick += dgvSituacoesAtendimento_CellMouseDoubleClick;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = imlIcones;
            btnPesquisar.Location = new Point(736, 197);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(48, 23);
            btnPesquisar.TabIndex = 51;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // imlIcones
            // 
            imlIcones.ColorDepth = ColorDepth.Depth32Bit;
            imlIcones.ImageStream = (ImageListStreamer)resources.GetObject("imlIcones.ImageStream");
            imlIcones.TransparentColor = Color.Transparent;
            imlIcones.Images.SetKeyName(0, "icone-cancelar.png");
            imlIcones.Images.SetKeyName(1, "icone-editar.png");
            imlIcones.Images.SetKeyName(2, "icone-excluir.png");
            imlIcones.Images.SetKeyName(3, "icone-novo.png");
            imlIcones.Images.SetKeyName(4, "icone-pesquisar.png");
            imlIcones.Images.SetKeyName(5, "icone-salvar.png");
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(498, 197);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(231, 23);
            txtPesquisar.TabIndex = 50;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(498, 179);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 43;
            lblPesquisar.Text = "Pesquisar";
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(340, 191);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 29);
            btnCancelar.TabIndex = 49;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(259, 191);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 29);
            btnExcluir.TabIndex = 48;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(178, 191);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 29);
            btnSalvar.TabIndex = 47;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(97, 191);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 29);
            btnEditar.TabIndex = 46;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(16, 191);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 29);
            btnNovo.TabIndex = 45;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // grbDadosSituacaoAtendimento
            // 
            grbDadosSituacaoAtendimento.Controls.Add(pnlSituacao);
            grbDadosSituacaoAtendimento.Controls.Add(lblSituacao);
            grbDadosSituacaoAtendimento.Controls.Add(txtCor);
            grbDadosSituacaoAtendimento.Controls.Add(lblCor);
            grbDadosSituacaoAtendimento.Controls.Add(txtNome);
            grbDadosSituacaoAtendimento.Controls.Add(lblNome);
            grbDadosSituacaoAtendimento.Controls.Add(lblCodigo);
            grbDadosSituacaoAtendimento.Controls.Add(txtCodigo);
            grbDadosSituacaoAtendimento.Location = new Point(16, 18);
            grbDadosSituacaoAtendimento.Name = "grbDadosSituacaoAtendimento";
            grbDadosSituacaoAtendimento.Size = new Size(768, 141);
            grbDadosSituacaoAtendimento.TabIndex = 42;
            grbDadosSituacaoAtendimento.TabStop = false;
            grbDadosSituacaoAtendimento.Text = "Dados da Situação do Atendimento";
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbInativo);
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Enabled = false;
            pnlSituacao.Location = new Point(619, 87);
            pnlSituacao.Name = "pnlSituacao";
            pnlSituacao.Size = new Size(130, 36);
            pnlSituacao.TabIndex = 14;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(63, 8);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Checked = true;
            rdbAtivo.Location = new Point(3, 8);
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
            lblSituacao.Location = new Point(622, 75);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 12;
            lblSituacao.Text = "Situação";
            // 
            // txtCor
            // 
            txtCor.Location = new Point(15, 93);
            txtCor.Name = "txtCor";
            txtCor.ReadOnly = true;
            txtCor.Size = new Size(146, 23);
            txtCor.TabIndex = 3;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Location = new Point(15, 75);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(26, 15);
            lblCor.TabIndex = 6;
            lblCor.Text = "Cor";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(121, 37);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(627, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(121, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(15, 19);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(15, 37);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // FrmCadastroSituacaoAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 515);
            Controls.Add(grbListaSituacoesAtendimento);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosSituacaoAtendimento);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadastroSituacaoAtendimento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCadastroSituacaoAtendimento";
            Load += FrmCadastroSituacaoAtendimento_Load;
            grbListaSituacoesAtendimento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSituacoesAtendimento).EndInit();
            grbDadosSituacaoAtendimento.ResumeLayout(false);
            grbDadosSituacaoAtendimento.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbListaSituacoesAtendimento;
        private DataGridView dgvSituacoesAtendimento;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private Label lblPesquisar;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnNovo;
        private GroupBox grbDadosSituacaoAtendimento;
        private Panel pnlSituacao;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Label lblSituacao;
        private TextBox txtCor;
        private Label lblCor;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private ImageList imlIcones;
    }
}