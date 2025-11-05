namespace SistemaAtendimento.View
{
    partial class FrmAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtendimento));
            lblCodigoCliente = new Label();
            lblNome = new Label();
            lblDataAbertura = new Label();
            lblSituacaoAtendimento = new Label();
            lblObservacoes = new Label();
            cbxNomeCliente = new ComboBox();
            txtCodigoCliente = new TextBox();
            cbxSituacaoAtendimento = new ComboBox();
            txtCodigoAtendimento = new TextBox();
            btnNovo = new Button();
            imageList1 = new ImageList(components);
            btnCancelar = new Button();
            btnPesquisarAtendimento = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnFinalizar = new Button();
            lblAtendimento = new Label();
            dtpAberturaAtendimento = new DateTimePicker();
            txtObservacaoAtendimento = new TextBox();
            grbEtapaAtendimento = new GroupBox();
            dgvEtapasAtendimento = new DataGridView();
            btnExcluirEtapa = new Button();
            btnAdicionarEtapa = new Button();
            txtEtapaObservacoes = new TextBox();
            cbxEtapaAtendimento = new ComboBox();
            lblObservacoes2 = new Label();
            lblEtapaAtendimento = new Label();
            lblEtapasAtendiemento = new Label();
            grbEtapaAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapasAtendimento).BeginInit();
            SuspendLayout();
            // 
            // lblCodigoCliente
            // 
            lblCodigoCliente.AutoSize = true;
            lblCodigoCliente.Location = new Point(12, 75);
            lblCodigoCliente.Name = "lblCodigoCliente";
            lblCodigoCliente.Size = new Size(72, 15);
            lblCodigoCliente.TabIndex = 1;
            lblCodigoCliente.Text = "Cód. Cliente";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(114, 75);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // lblDataAbertura
            // 
            lblDataAbertura.AutoSize = true;
            lblDataAbertura.Location = new Point(598, 75);
            lblDataAbertura.Name = "lblDataAbertura";
            lblDataAbertura.Size = new Size(80, 15);
            lblDataAbertura.TabIndex = 3;
            lblDataAbertura.Text = "Data Abertura";
            // 
            // lblSituacaoAtendimento
            // 
            lblSituacaoAtendimento.AutoSize = true;
            lblSituacaoAtendimento.Location = new Point(12, 131);
            lblSituacaoAtendimento.Name = "lblSituacaoAtendimento";
            lblSituacaoAtendimento.Size = new Size(142, 15);
            lblSituacaoAtendimento.TabIndex = 4;
            lblSituacaoAtendimento.Text = "Situação do Atendimento";
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Location = new Point(259, 131);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(74, 15);
            lblObservacoes.TabIndex = 5;
            lblObservacoes.Text = "Observações";
            // 
            // cbxNomeCliente
            // 
            cbxNomeCliente.Enabled = false;
            cbxNomeCliente.FormattingEnabled = true;
            cbxNomeCliente.Location = new Point(114, 93);
            cbxNomeCliente.Name = "cbxNomeCliente";
            cbxNomeCliente.Size = new Size(457, 23);
            cbxNomeCliente.TabIndex = 9;
            cbxNomeCliente.SelectedIndexChanged += cbxNomeCliente_SelectedIndexChanged;
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(12, 93);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.ReadOnly = true;
            txtCodigoCliente.Size = new Size(83, 23);
            txtCodigoCliente.TabIndex = 10;
            // 
            // cbxSituacaoAtendimento
            // 
            cbxSituacaoAtendimento.Enabled = false;
            cbxSituacaoAtendimento.FormattingEnabled = true;
            cbxSituacaoAtendimento.Location = new Point(12, 149);
            cbxSituacaoAtendimento.Name = "cbxSituacaoAtendimento";
            cbxSituacaoAtendimento.Size = new Size(214, 23);
            cbxSituacaoAtendimento.TabIndex = 12;
            // 
            // txtCodigoAtendimento
            // 
            txtCodigoAtendimento.Location = new Point(671, 29);
            txtCodigoAtendimento.Name = "txtCodigoAtendimento";
            txtCodigoAtendimento.ReadOnly = true;
            txtCodigoAtendimento.Size = new Size(117, 23);
            txtCodigoAtendimento.TabIndex = 16;
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageKey = "icone-novo.png";
            btnNovo.ImageList = imageList1;
            btnNovo.Location = new Point(25, 245);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(70, 37);
            btnNovo.TabIndex = 17;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "cancelar.png");
            imageList1.Images.SetKeyName(1, "Salvar.png");
            imageList1.Images.SetKeyName(2, "icone-cancelar.png");
            imageList1.Images.SetKeyName(3, "icone-editar.png");
            imageList1.Images.SetKeyName(4, "icone-excluir.png");
            imageList1.Images.SetKeyName(5, "icone-novo.png");
            imageList1.Images.SetKeyName(6, "icone-pesquisar.png");
            imageList1.Images.SetKeyName(7, "icone-salvar.png");
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageKey = "cancelar.png";
            btnCancelar.ImageList = imageList1;
            btnCancelar.Location = new Point(290, 245);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 37);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnPesquisarAtendimento
            // 
            btnPesquisarAtendimento.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisarAtendimento.ImageKey = "icone-pesquisar.png";
            btnPesquisarAtendimento.ImageList = imageList1;
            btnPesquisarAtendimento.Location = new Point(12, 28);
            btnPesquisarAtendimento.Name = "btnPesquisarAtendimento";
            btnPesquisarAtendimento.Size = new Size(160, 28);
            btnPesquisarAtendimento.TabIndex = 24;
            btnPesquisarAtendimento.Text = "Pesquisar Atendimento";
            btnPesquisarAtendimento.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisarAtendimento.UseVisualStyleBackColor = true;
            btnPesquisarAtendimento.Click += btnPesquisarAtendimento_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageKey = "icone-excluir.png";
            btnExcluir.ImageList = imageList1;
            btnExcluir.Location = new Point(202, 245);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(70, 37);
            btnExcluir.TabIndex = 25;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageKey = "icone-salvar.png";
            btnSalvar.ImageList = imageList1;
            btnSalvar.Location = new Point(114, 245);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(70, 37);
            btnSalvar.TabIndex = 26;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Enabled = false;
            btnFinalizar.Image = (Image)resources.GetObject("btnFinalizar.Image");
            btnFinalizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizar.Location = new Point(611, 240);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(177, 46);
            btnFinalizar.TabIndex = 28;
            btnFinalizar.Text = "Finalizar Atendimento";
            btnFinalizar.TextAlign = ContentAlignment.MiddleRight;
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // lblAtendimento
            // 
            lblAtendimento.AutoSize = true;
            lblAtendimento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAtendimento.Location = new Point(531, 27);
            lblAtendimento.Name = "lblAtendimento";
            lblAtendimento.Size = new Size(134, 25);
            lblAtendimento.TabIndex = 29;
            lblAtendimento.Text = "Atendimento:";
            lblAtendimento.Click += label1_Click;
            // 
            // dtpAberturaAtendimento
            // 
            dtpAberturaAtendimento.Enabled = false;
            dtpAberturaAtendimento.Location = new Point(598, 93);
            dtpAberturaAtendimento.Name = "dtpAberturaAtendimento";
            dtpAberturaAtendimento.Size = new Size(190, 23);
            dtpAberturaAtendimento.TabIndex = 30;
            // 
            // txtObservacaoAtendimento
            // 
            txtObservacaoAtendimento.Location = new Point(259, 149);
            txtObservacaoAtendimento.Multiline = true;
            txtObservacaoAtendimento.Name = "txtObservacaoAtendimento";
            txtObservacaoAtendimento.Size = new Size(529, 85);
            txtObservacaoAtendimento.TabIndex = 31;
            // 
            // grbEtapaAtendimento
            // 
            grbEtapaAtendimento.Controls.Add(dgvEtapasAtendimento);
            grbEtapaAtendimento.Controls.Add(btnExcluirEtapa);
            grbEtapaAtendimento.Controls.Add(btnAdicionarEtapa);
            grbEtapaAtendimento.Controls.Add(txtEtapaObservacoes);
            grbEtapaAtendimento.Controls.Add(cbxEtapaAtendimento);
            grbEtapaAtendimento.Controls.Add(lblObservacoes2);
            grbEtapaAtendimento.Controls.Add(lblEtapaAtendimento);
            grbEtapaAtendimento.Controls.Add(lblEtapasAtendiemento);
            grbEtapaAtendimento.Location = new Point(12, 304);
            grbEtapaAtendimento.Name = "grbEtapaAtendimento";
            grbEtapaAtendimento.Size = new Size(776, 272);
            grbEtapaAtendimento.TabIndex = 32;
            grbEtapaAtendimento.TabStop = false;
            grbEtapaAtendimento.Text = "Etapas do Atendimento";
            grbEtapaAtendimento.Enter += groupBox1_Enter;
            // 
            // dgvEtapasAtendimento
            // 
            dgvEtapasAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEtapasAtendimento.Location = new Point(348, 30);
            dgvEtapasAtendimento.Name = "dgvEtapasAtendimento";
            dgvEtapasAtendimento.Size = new Size(414, 222);
            dgvEtapasAtendimento.TabIndex = 31;
            // 
            // btnExcluirEtapa
            // 
            btnExcluirEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirEtapa.ImageKey = "cancelar.png";
            btnExcluirEtapa.ImageList = imageList1;
            btnExcluirEtapa.Location = new Point(172, 228);
            btnExcluirEtapa.Name = "btnExcluirEtapa";
            btnExcluirEtapa.Size = new Size(106, 37);
            btnExcluirEtapa.TabIndex = 30;
            btnExcluirEtapa.Text = "Excluir Etapa";
            btnExcluirEtapa.TextAlign = ContentAlignment.MiddleRight;
            btnExcluirEtapa.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarEtapa
            // 
            btnAdicionarEtapa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionarEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarEtapa.ImageKey = "icone-novo.png";
            btnAdicionarEtapa.ImageList = imageList1;
            btnAdicionarEtapa.Location = new Point(21, 228);
            btnAdicionarEtapa.Name = "btnAdicionarEtapa";
            btnAdicionarEtapa.Size = new Size(121, 37);
            btnAdicionarEtapa.TabIndex = 29;
            btnAdicionarEtapa.Text = "Adicionar Etapa";
            btnAdicionarEtapa.TextAlign = ContentAlignment.MiddleRight;
            btnAdicionarEtapa.UseVisualStyleBackColor = true;
            // 
            // txtEtapaObservacoes
            // 
            txtEtapaObservacoes.Location = new Point(13, 84);
            txtEtapaObservacoes.Multiline = true;
            txtEtapaObservacoes.Name = "txtEtapaObservacoes";
            txtEtapaObservacoes.Size = new Size(299, 138);
            txtEtapaObservacoes.TabIndex = 28;
            // 
            // cbxEtapaAtendimento
            // 
            cbxEtapaAtendimento.FormattingEnabled = true;
            cbxEtapaAtendimento.Location = new Point(13, 40);
            cbxEtapaAtendimento.Name = "cbxEtapaAtendimento";
            cbxEtapaAtendimento.Size = new Size(299, 23);
            cbxEtapaAtendimento.TabIndex = 27;
            // 
            // lblObservacoes2
            // 
            lblObservacoes2.AutoSize = true;
            lblObservacoes2.Location = new Point(13, 66);
            lblObservacoes2.Name = "lblObservacoes2";
            lblObservacoes2.Size = new Size(74, 15);
            lblObservacoes2.TabIndex = 26;
            lblObservacoes2.Text = "Observações";
            lblObservacoes2.Click += lblObservacoes2_Click;
            // 
            // lblEtapaAtendimento
            // 
            lblEtapaAtendimento.AutoSize = true;
            lblEtapaAtendimento.Location = new Point(13, 22);
            lblEtapaAtendimento.Name = "lblEtapaAtendimento";
            lblEtapaAtendimento.Size = new Size(126, 15);
            lblEtapaAtendimento.TabIndex = 25;
            lblEtapaAtendimento.Text = "Etapa do Atendimento";
            // 
            // lblEtapasAtendiemento
            // 
            lblEtapasAtendiemento.AutoSize = true;
            lblEtapasAtendiemento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEtapasAtendiemento.Location = new Point(62, -17);
            lblEtapasAtendiemento.Name = "lblEtapasAtendiemento";
            lblEtapasAtendiemento.Size = new Size(152, 17);
            lblEtapasAtendiemento.TabIndex = 24;
            lblEtapasAtendiemento.Text = "Etapas do Atendimento";
            // 
            // FrmAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 588);
            Controls.Add(grbEtapaAtendimento);
            Controls.Add(txtObservacaoAtendimento);
            Controls.Add(dtpAberturaAtendimento);
            Controls.Add(lblAtendimento);
            Controls.Add(btnFinalizar);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisarAtendimento);
            Controls.Add(btnCancelar);
            Controls.Add(btnNovo);
            Controls.Add(txtCodigoAtendimento);
            Controls.Add(cbxSituacaoAtendimento);
            Controls.Add(txtCodigoCliente);
            Controls.Add(cbxNomeCliente);
            Controls.Add(lblObservacoes);
            Controls.Add(lblSituacaoAtendimento);
            Controls.Add(lblDataAbertura);
            Controls.Add(lblNome);
            Controls.Add(lblCodigoCliente);
            Name = "FrmAtendimento";
            Text = "Atendiemnto";
            Load += FrmAtendimento_Load;
            grbEtapaAtendimento.ResumeLayout(false);
            grbEtapaAtendimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapasAtendimento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigoCliente;
        private Label lblNome;
        private Label lblDataAbertura;
        private Label lblSituacaoAtendimento;
        private Label lblObservacoes;
        private ComboBox cbxNomeCliente;
        private TextBox txtCodigoCliente;
        private ComboBox cbxSituacaoAtendimento;
        private DateTimePicker dtpAberturaAtendimento; // Mantenha apenas uma vez
        private TextBox txtObservacaoAtendimento;
        private Label lblAtendimento; // Mantenha apenas uma vez
        private TextBox txtCodigoAtendimento;
        private Button btnNovo;
        private Button btnCancelar;
        private ImageList imageList1;
        private Button btnPesquisarAtendimento;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnFinalizar;
        private GroupBox grbEtapaAtendimento;
        private DataGridView dgvEtapasAtendimento;
        private Button btnExcluirEtapa;
        private Button btnAdicionarEtapa;
        private TextBox txtEtapaObservacoes;
        private ComboBox cbxEtapaAtendimento;
        private Label lblObservacoes2;
        private Label lblEtapaAtendimento;
        private Label lblEtapasAtendiemento;
    }
}