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
            grbListaEtapas = new GroupBox();
            dgvEtapas = new DataGridView();
            btnPesquisar = new Button();
            imageList1 = new ImageList(components);
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnNovo = new Button();
            grbDadosEtapa = new GroupBox();
            pnlSituacao = new Panel();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblSituacao = new Label();
            txtOrdem = new TextBox();
            lblOrdem = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            grbListaEtapas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapas).BeginInit();
            grbDadosEtapa.SuspendLayout();
            pnlSituacao.SuspendLayout();
            SuspendLayout();
            // 
            // grbListaEtapas
            // 
            grbListaEtapas.Controls.Add(dgvEtapas);
            grbListaEtapas.Location = new Point(17, 240);
            grbListaEtapas.Name = "grbListaEtapas";
            grbListaEtapas.Size = new Size(767, 243);
            grbListaEtapas.TabIndex = 34;
            grbListaEtapas.TabStop = false;
            grbListaEtapas.Text = "Lista de Etapas";
            // 
            // dgvEtapas
            // 
            dgvEtapas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEtapas.Location = new Point(6, 22);
            dgvEtapas.MultiSelect = false;
            dgvEtapas.Name = "dgvEtapas";
            dgvEtapas.ReadOnly = true;
            dgvEtapas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEtapas.Size = new Size(755, 215);
            dgvEtapas.TabIndex = 0;
            dgvEtapas.CellMouseDoubleClick += dgvEtapas_CellMouseDoubleClick;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = imageList1;
            btnPesquisar.Location = new Point(736, 200);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(48, 23);
            btnPesquisar.TabIndex = 41;
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
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(498, 200);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(231, 23);
            txtPesquisar.TabIndex = 40;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(498, 182);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 33;
            lblPesquisar.Text = "Pesquisar";
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imageList1;
            btnCancelar.Location = new Point(340, 194);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 29);
            btnCancelar.TabIndex = 39;
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
            btnExcluir.ImageList = imageList1;
            btnExcluir.Location = new Point(259, 194);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 29);
            btnExcluir.TabIndex = 38;
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
            btnSalvar.ImageList = imageList1;
            btnSalvar.Location = new Point(178, 194);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 29);
            btnSalvar.TabIndex = 37;
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
            btnEditar.ImageList = imageList1;
            btnEditar.Location = new Point(97, 194);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 29);
            btnEditar.TabIndex = 36;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imageList1;
            btnNovo.Location = new Point(16, 194);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 29);
            btnNovo.TabIndex = 35;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // grbDadosEtapa
            // 
            grbDadosEtapa.Controls.Add(pnlSituacao);
            grbDadosEtapa.Controls.Add(lblSituacao);
            grbDadosEtapa.Controls.Add(txtOrdem);
            grbDadosEtapa.Controls.Add(lblOrdem);
            grbDadosEtapa.Controls.Add(txtNome);
            grbDadosEtapa.Controls.Add(lblNome);
            grbDadosEtapa.Controls.Add(lblCodigo);
            grbDadosEtapa.Controls.Add(txtCodigo);
            grbDadosEtapa.Location = new Point(16, 21);
            grbDadosEtapa.Name = "grbDadosEtapa";
            grbDadosEtapa.Size = new Size(768, 141);
            grbDadosEtapa.TabIndex = 32;
            grbDadosEtapa.TabStop = false;
            grbDadosEtapa.Text = "Dados da Etapa";
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
            // txtOrdem
            // 
            txtOrdem.Location = new Point(15, 93);
            txtOrdem.Name = "txtOrdem";
            txtOrdem.ReadOnly = true;
            txtOrdem.Size = new Size(146, 23);
            txtOrdem.TabIndex = 3;
            // 
            // lblOrdem
            // 
            lblOrdem.AutoSize = true;
            lblOrdem.Location = new Point(15, 75);
            lblOrdem.Name = "lblOrdem";
            lblOrdem.Size = new Size(44, 15);
            lblOrdem.TabIndex = 6;
            lblOrdem.Text = "Ordem";
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
            // FrmCadastroEtapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(grbListaEtapas);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosEtapa);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadastroEtapa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Etapas";
            Load += FrmCadastroEtapa_Load;
            grbListaEtapas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEtapas).EndInit();
            grbDadosEtapa.ResumeLayout(false);
            grbDadosEtapa.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbListaEtapas;
        private DataGridView dgvEtapas;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private Label lblPesquisar;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnNovo;
        private GroupBox grbDadosEtapa;
        private Panel pnlSituacao;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Label lblSituacao;
        private TextBox txtOrdem;
        private Label lblOrdem;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private ImageList imageList1;
    }
}