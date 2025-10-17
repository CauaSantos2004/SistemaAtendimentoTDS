namespace SistemaAtendimento.View
{
    partial class FrmCadastroEtapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroEtapa));
            grdDadosEtapas = new GroupBox();
            pnlSituacao = new Panel();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblSituacao = new Label();
            lblOrdem = new Label();
            lblNome = new Label();
            lblCodigo = new Label();
            txtOrdem = new TextBox();
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            btnExcluir = new Button();
            ImlIcones = new ImageList(components);
            btnCancelar = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            lblPesquisar = new Label();
            grbListaEtapas = new GroupBox();
            dgvEtapas = new DataGridView();
            grdDadosEtapas.SuspendLayout();
            pnlSituacao.SuspendLayout();
            grbListaEtapas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapas).BeginInit();
            SuspendLayout();
            // 
            // grdDadosEtapas
            // 
            grdDadosEtapas.Controls.Add(pnlSituacao);
            grdDadosEtapas.Controls.Add(lblSituacao);
            grdDadosEtapas.Controls.Add(lblOrdem);
            grdDadosEtapas.Controls.Add(lblNome);
            grdDadosEtapas.Controls.Add(lblCodigo);
            grdDadosEtapas.Controls.Add(txtOrdem);
            grdDadosEtapas.Controls.Add(txtNome);
            grdDadosEtapas.Controls.Add(txtCodigo);
            grdDadosEtapas.Location = new Point(12, 21);
            grdDadosEtapas.Name = "grdDadosEtapas";
            grdDadosEtapas.Size = new Size(776, 150);
            grdDadosEtapas.TabIndex = 0;
            grdDadosEtapas.TabStop = false;
            grdDadosEtapas.Text = "Dados da Etapa";
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbInativo);
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Location = new Point(332, 95);
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
            rdbAtivo.Location = new Point(3, 4);
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
            lblSituacao.Location = new Point(332, 77);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 6;
            lblSituacao.Text = "Situação";
            // 
            // lblOrdem
            // 
            lblOrdem.AutoSize = true;
            lblOrdem.Location = new Point(20, 77);
            lblOrdem.Name = "lblOrdem";
            lblOrdem.Size = new Size(44, 15);
            lblOrdem.TabIndex = 5;
            lblOrdem.Text = "Ordem";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(182, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(20, 19);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Código";
            // 
            // txtOrdem
            // 
            txtOrdem.Location = new Point(20, 95);
            txtOrdem.Name = "txtOrdem";
            txtOrdem.Size = new Size(274, 23);
            txtOrdem.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(182, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(577, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(20, 37);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = ImlIcones;
            btnExcluir.Location = new Point(289, 207);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(69, 37);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // ImlIcones
            // 
            ImlIcones.ColorDepth = ColorDepth.Depth32Bit;
            ImlIcones.ImageStream = (ImageListStreamer)resources.GetObject("ImlIcones.ImageStream");
            ImlIcones.TransparentColor = Color.Transparent;
            ImlIcones.Images.SetKeyName(0, "icone-cancelar.png");
            ImlIcones.Images.SetKeyName(1, "icone-editar.png");
            ImlIcones.Images.SetKeyName(2, "icone-excluir.png");
            ImlIcones.Images.SetKeyName(3, "icone-novo.png");
            ImlIcones.Images.SetKeyName(4, "icone-pesquisar.png");
            ImlIcones.Images.SetKeyName(5, "icone-salvar.png");
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = ImlIcones;
            btnCancelar.Location = new Point(386, 207);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 37);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = ImlIcones;
            btnEditar.Location = new Point(104, 207);
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
            btnSalvar.ImageList = ImlIcones;
            btnSalvar.Location = new Point(194, 207);
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
            btnNovo.ImageList = ImlIcones;
            btnNovo.Location = new Point(12, 207);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(63, 37);
            btnNovo.TabIndex = 5;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(520, 221);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(218, 23);
            txtPesquisar.TabIndex = 10;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = ImlIcones;
            btnPesquisar.Location = new Point(744, 219);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(44, 25);
            btnPesquisar.TabIndex = 11;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(520, 203);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 31;
            lblPesquisar.Text = "Pesquisar";
            // 
            // grbListaEtapas
            // 
            grbListaEtapas.Controls.Add(dgvEtapas);
            grbListaEtapas.Location = new Point(12, 276);
            grbListaEtapas.Name = "grbListaEtapas";
            grbListaEtapas.Size = new Size(776, 162);
            grbListaEtapas.TabIndex = 32;
            grbListaEtapas.TabStop = false;
            grbListaEtapas.Text = "Lista de Etapas";
            // 
            // dgvEtapas
            // 
            dgvEtapas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEtapas.Location = new Point(6, 22);
            dgvEtapas.Name = "dgvEtapas";
            dgvEtapas.Size = new Size(764, 142);
            dgvEtapas.TabIndex = 0;
            dgvEtapas.CellDoubleClick += dgvEtapas_CellDoubleClick;
            // 
            // FrmCadastroEtapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbListaEtapas);
            Controls.Add(lblPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnNovo);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(grdDadosEtapas);
            Name = "FrmCadastroEtapa";
            Text = "Cadastro de Etapa";
            Load += FrmCadastroEtapa_Load;
            grdDadosEtapas.ResumeLayout(false);
            grdDadosEtapas.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            grbListaEtapas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEtapas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grdDadosEtapas;
        private TextBox txtOrdem;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private Label lblSituacao;
        private Label lblOrdem;
        private Label lblNome;
        private Label lblCodigo;
        private Panel pnlSituacao;
        private RadioButton rdbAtivo;
        private RadioButton rdbInativo;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnNovo;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Label lblPesquisar;
        private ImageList ImlIcones;
        private GroupBox grbListaEtapas;
        private DataGridView dgvEtapas;
    }
}