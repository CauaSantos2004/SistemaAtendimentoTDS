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
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            imlIcones = new ImageList(components);
            btnExcluir = new Button();
            btnSalvar = new Button();
            label4 = new Label();
            btnFinalizar = new Button();
            btnNovo = new Button();
            txtObservacaoAtendimento = new TextBox();
            label6 = new Label();
            cbxSituacaoAtendimento = new ComboBox();
            label5 = new Label();
            dtpAberturaAtendimento = new DateTimePicker();
            label3 = new Label();
            cbxNomeCliente = new ComboBox();
            label2 = new Label();
            txtCodigoCliente = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnExcluirEtapa = new Button();
            cbxEtapaAtendimento = new ComboBox();
            btnAdicionarEtapa = new Button();
            label8 = new Label();
            txtEtapaObservacao = new TextBox();
            label7 = new Label();
            dgvEtapasAtendimento = new DataGridView();
            label9 = new Label();
            txtCodigoAtendimento = new TextBox();
            btnPesquisarAtendimento = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapasAtendimento).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnFinalizar);
            groupBox1.Controls.Add(btnNovo);
            groupBox1.Controls.Add(txtObservacaoAtendimento);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbxSituacaoAtendimento);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpAberturaAtendimento);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbxNomeCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCodigoCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(742, 263);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(290, 211);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 33);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
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
            imlIcones.Images.SetKeyName(6, "finalizar.png");
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(197, 211);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 33);
            btnExcluir.TabIndex = 26;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(106, 211);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 33);
            btnSalvar.TabIndex = 25;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, -12);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 23;
            label4.Text = "Cód. Cliente";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Enabled = false;
            btnFinalizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinalizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizar.ImageIndex = 6;
            btnFinalizar.ImageList = imlIcones;
            btnFinalizar.Location = new Point(566, 211);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.RightToLeft = RightToLeft.No;
            btnFinalizar.Size = new Size(163, 33);
            btnFinalizar.TabIndex = 22;
            btnFinalizar.Text = "Finalizar Atendimento";
            btnFinalizar.TextAlign = ContentAlignment.MiddleRight;
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(15, 211);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 33);
            btnNovo.TabIndex = 21;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // txtObservacaoAtendimento
            // 
            txtObservacaoAtendimento.Location = new Point(226, 110);
            txtObservacaoAtendimento.Multiline = true;
            txtObservacaoAtendimento.Name = "txtObservacaoAtendimento";
            txtObservacaoAtendimento.ReadOnly = true;
            txtObservacaoAtendimento.Size = new Size(493, 68);
            txtObservacaoAtendimento.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(226, 92);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 10;
            label6.Text = "Observações";
            // 
            // cbxSituacaoAtendimento
            // 
            cbxSituacaoAtendimento.Enabled = false;
            cbxSituacaoAtendimento.FormattingEnabled = true;
            cbxSituacaoAtendimento.Location = new Point(15, 110);
            cbxSituacaoAtendimento.Name = "cbxSituacaoAtendimento";
            cbxSituacaoAtendimento.Size = new Size(196, 23);
            cbxSituacaoAtendimento.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 92);
            label5.Name = "label5";
            label5.Size = new Size(142, 15);
            label5.TabIndex = 8;
            label5.Text = "Situação do Atendimento";
            // 
            // dtpAberturaAtendimento
            // 
            dtpAberturaAtendimento.Enabled = false;
            dtpAberturaAtendimento.Location = new Point(520, 49);
            dtpAberturaAtendimento.Name = "dtpAberturaAtendimento";
            dtpAberturaAtendimento.Size = new Size(199, 23);
            dtpAberturaAtendimento.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 31);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 4;
            label3.Text = "Data Abertura";
            // 
            // cbxNomeCliente
            // 
            cbxNomeCliente.Enabled = false;
            cbxNomeCliente.FormattingEnabled = true;
            cbxNomeCliente.Location = new Point(115, 49);
            cbxNomeCliente.Name = "cbxNomeCliente";
            cbxNomeCliente.Size = new Size(382, 23);
            cbxNomeCliente.TabIndex = 3;
            cbxNomeCliente.SelectedIndexChanged += cbxNomeCliente_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 31);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(15, 49);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.ReadOnly = true;
            txtCodigoCliente.Size = new Size(83, 23);
            txtCodigoCliente.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Cód. Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExcluirEtapa);
            groupBox2.Controls.Add(cbxEtapaAtendimento);
            groupBox2.Controls.Add(btnAdicionarEtapa);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtEtapaObservacao);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(dgvEtapasAtendimento);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(12, 317);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(742, 290);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Etapas do Atendimento";
            // 
            // btnExcluirEtapa
            // 
            btnExcluirEtapa.Enabled = false;
            btnExcluirEtapa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluirEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirEtapa.ImageIndex = 0;
            btnExcluirEtapa.ImageList = imlIcones;
            btnExcluirEtapa.Location = new Point(172, 225);
            btnExcluirEtapa.Name = "btnExcluirEtapa";
            btnExcluirEtapa.RightToLeft = RightToLeft.No;
            btnExcluirEtapa.Size = new Size(122, 33);
            btnExcluirEtapa.TabIndex = 25;
            btnExcluirEtapa.Text = "Excluir Etapa";
            btnExcluirEtapa.TextAlign = ContentAlignment.MiddleRight;
            btnExcluirEtapa.UseVisualStyleBackColor = true;
            // 
            // cbxEtapaAtendimento
            // 
            cbxEtapaAtendimento.FormattingEnabled = true;
            cbxEtapaAtendimento.Location = new Point(15, 47);
            cbxEtapaAtendimento.Name = "cbxEtapaAtendimento";
            cbxEtapaAtendimento.Size = new Size(285, 23);
            cbxEtapaAtendimento.TabIndex = 13;
            // 
            // btnAdicionarEtapa
            // 
            btnAdicionarEtapa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionarEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarEtapa.ImageIndex = 3;
            btnAdicionarEtapa.ImageList = imlIcones;
            btnAdicionarEtapa.Location = new Point(22, 225);
            btnAdicionarEtapa.Name = "btnAdicionarEtapa";
            btnAdicionarEtapa.Size = new Size(133, 34);
            btnAdicionarEtapa.TabIndex = 23;
            btnAdicionarEtapa.Text = "Adicionar Etapa";
            btnAdicionarEtapa.TextAlign = ContentAlignment.MiddleRight;
            btnAdicionarEtapa.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 29);
            label8.Name = "label8";
            label8.Size = new Size(126, 15);
            label8.TabIndex = 12;
            label8.Text = "Etapa do Atendimento";
            // 
            // txtEtapaObservacao
            // 
            txtEtapaObservacao.Location = new Point(15, 103);
            txtEtapaObservacao.Multiline = true;
            txtEtapaObservacao.Name = "txtEtapaObservacao";
            txtEtapaObservacao.Size = new Size(285, 116);
            txtEtapaObservacao.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 85);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 12;
            label7.Text = "Observações";
            // 
            // dgvEtapasAtendimento
            // 
            dgvEtapasAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEtapasAtendimento.Location = new Point(318, 22);
            dgvEtapasAtendimento.Name = "dgvEtapasAtendimento";
            dgvEtapasAtendimento.Size = new Size(401, 234);
            dgvEtapasAtendimento.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(485, 15);
            label9.Name = "label9";
            label9.Size = new Size(163, 32);
            label9.TabIndex = 24;
            label9.Text = "Atendimento:";
            // 
            // txtCodigoAtendimento
            // 
            txtCodigoAtendimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigoAtendimento.Location = new Point(654, 18);
            txtCodigoAtendimento.Name = "txtCodigoAtendimento";
            txtCodigoAtendimento.ReadOnly = true;
            txtCodigoAtendimento.Size = new Size(100, 29);
            txtCodigoAtendimento.TabIndex = 25;
            // 
            // btnPesquisarAtendimento
            // 
            btnPesquisarAtendimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisarAtendimento.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisarAtendimento.ImageIndex = 4;
            btnPesquisarAtendimento.ImageList = imlIcones;
            btnPesquisarAtendimento.Location = new Point(12, 12);
            btnPesquisarAtendimento.Name = "btnPesquisarAtendimento";
            btnPesquisarAtendimento.RightToLeft = RightToLeft.No;
            btnPesquisarAtendimento.Size = new Size(172, 33);
            btnPesquisarAtendimento.TabIndex = 24;
            btnPesquisarAtendimento.Text = "Pesquisar Atendimento";
            btnPesquisarAtendimento.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisarAtendimento.UseVisualStyleBackColor = true;
            btnPesquisarAtendimento.Click += btnPesquisarAtendimento_Click;
            // 
            // FrmAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 619);
            Controls.Add(btnPesquisarAtendimento);
            Controls.Add(txtCodigoAtendimento);
            Controls.Add(label9);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmAtendimento";
            Text = "Atendimento";
            Load += FrmAtendimento_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapasAtendimento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private ComboBox cbxNomeCliente;
        private Label label2;
        private TextBox txtCodigoCliente;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtObservacaoAtendimento;
        private Label label6;
        private ComboBox cbxSituacaoAtendimento;
        private Label label5;
        private DateTimePicker dtpAberturaAtendimento;
        private ComboBox cbxEtapaAtendimento;
        private Label label8;
        private TextBox txtEtapaObservacao;
        private Label label7;
        private DataGridView dgvEtapasAtendimento;
        private Button btnFinalizar;
        private ImageList imlIcones;
        private Button btnNovo;
        private Button btnExcluirEtapa;
        private Button btnAdicionarEtapa;
        private Label label4;
        private Label label9;
        private TextBox txtCodigoAtendimento;
        private Button btnPesquisarAtendimento;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSalvar;
    }
}