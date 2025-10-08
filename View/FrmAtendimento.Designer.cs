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
            lblDadosCliente = new Label();
            lblCodigoCliente = new Label();
            lblNome = new Label();
            lblDataAbertura = new Label();
            lblSituacaoAtendimento = new Label();
            lblObservacoes = new Label();
            lblEtapasAtendiemento = new Label();
            lblEtapaAtendimento = new Label();
            lblObservacoes2 = new Label();
            cbxNome = new ComboBox();
            txtCodigoCliente = new TextBox();
            cbxSituacaoAtendimento = new ComboBox();
            txtObservacoes = new TextBox();
            cbxDataAbertura = new DateTimePicker();
            lblAtendimento = new Label();
            txtAtendimento = new TextBox();
            btnSalvar = new Button();
            btnFinalizar = new Button();
            imageList1 = new ImageList(components);
            cbxEtapaAtendimento = new ComboBox();
            txtObservacoes2 = new TextBox();
            btnAdicionarEtapa = new Button();
            btnExcluirEtapa = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblDadosCliente
            // 
            lblDadosCliente.AutoSize = true;
            lblDadosCliente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDadosCliente.Location = new Point(11, 41);
            lblDadosCliente.Name = "lblDadosCliente";
            lblDadosCliente.Size = new Size(111, 17);
            lblDadosCliente.TabIndex = 0;
            lblDadosCliente.Text = "Dados do Cliente";            // 
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
            // lblEtapasAtendiemento
            // 
            lblEtapasAtendiemento.AutoSize = true;
            lblEtapasAtendiemento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEtapasAtendiemento.Location = new Point(49, 261);
            lblEtapasAtendiemento.Name = "lblEtapasAtendiemento";
            lblEtapasAtendiemento.Size = new Size(152, 17);
            lblEtapasAtendiemento.TabIndex = 6;
            lblEtapasAtendiemento.Text = "Etapas do Atendimento";
            // 
            // lblEtapaAtendimento
            // 
            lblEtapaAtendimento.AutoSize = true;
            lblEtapaAtendimento.Location = new Point(11, 287);
            lblEtapaAtendimento.Name = "lblEtapaAtendimento";
            lblEtapaAtendimento.Size = new Size(126, 15);
            lblEtapaAtendimento.TabIndex = 7;
            lblEtapaAtendimento.Text = "Etapa do Atendimento";
            // 
            // lblObservacoes2
            // 
            lblObservacoes2.AutoSize = true;
            lblObservacoes2.Location = new Point(12, 339);
            lblObservacoes2.Name = "lblObservacoes2";
            lblObservacoes2.Size = new Size(74, 15);
            lblObservacoes2.TabIndex = 8;
            lblObservacoes2.Text = "Observações";
            // 
            // cbxNome
            // 
            cbxNome.FormattingEnabled = true;
            cbxNome.Location = new Point(114, 93);
            cbxNome.Name = "cbxNome";
            cbxNome.Size = new Size(457, 23);
            cbxNome.TabIndex = 9;
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(12, 93);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(83, 23);
            txtCodigoCliente.TabIndex = 10;
            // 
            // cbxSituacaoAtendimento
            // 
            cbxSituacaoAtendimento.FormattingEnabled = true;
            cbxSituacaoAtendimento.Location = new Point(12, 149);
            cbxSituacaoAtendimento.Name = "cbxSituacaoAtendimento";
            cbxSituacaoAtendimento.Size = new Size(214, 23);
            cbxSituacaoAtendimento.TabIndex = 12;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(259, 149);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(529, 81);
            txtObservacoes.TabIndex = 13;
            // 
            // cbxDataAbertura
            // 
            cbxDataAbertura.Location = new Point(598, 93);
            cbxDataAbertura.Name = "cbxDataAbertura";
            cbxDataAbertura.Size = new Size(190, 23);
            cbxDataAbertura.TabIndex = 14;
            // 
            // lblAtendimento
            // 
            lblAtendimento.AutoSize = true;
            lblAtendimento.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAtendimento.Location = new Point(539, 29);
            lblAtendimento.Name = "lblAtendimento";
            lblAtendimento.Size = new Size(149, 30);
            lblAtendimento.TabIndex = 15;
            lblAtendimento.Text = "Atendimento:";
            // 
            // txtAtendimento
            // 
            txtAtendimento.Location = new Point(694, 36);
            txtAtendimento.Name = "txtAtendimento";
            txtAtendimento.Size = new Size(94, 23);
            txtAtendimento.TabIndex = 16;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageKey = "icone-salvar.png";
            btnSalvar.ImageList = imageList1;
            btnSalvar.Location = new Point(37, 193);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(70, 37);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            btnFinalizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizar.ImageKey = "cancelar.png";
            btnFinalizar.ImageList = imageList1;
            btnFinalizar.Location = new Point(125, 193);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(81, 37);
            btnFinalizar.TabIndex = 18;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.TextAlign = ContentAlignment.MiddleRight;
            btnFinalizar.UseVisualStyleBackColor = true;
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
            // cbxEtapaAtendimento
            // 
            cbxEtapaAtendimento.FormattingEnabled = true;
            cbxEtapaAtendimento.Location = new Point(12, 305);
            cbxEtapaAtendimento.Name = "cbxEtapaAtendimento";
            cbxEtapaAtendimento.Size = new Size(299, 23);
            cbxEtapaAtendimento.TabIndex = 19;
            // 
            // txtObservacoes2
            // 
            txtObservacoes2.Location = new Point(12, 357);
            txtObservacoes2.Multiline = true;
            txtObservacoes2.Name = "txtObservacoes2";
            txtObservacoes2.Size = new Size(299, 138);
            txtObservacoes2.TabIndex = 20;
            // 
            // btnAdicionarEtapa
            // 
            btnAdicionarEtapa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionarEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarEtapa.ImageKey = "icone-novo.png";
            btnAdicionarEtapa.ImageList = imageList1;
            btnAdicionarEtapa.Location = new Point(33, 501);
            btnAdicionarEtapa.Name = "btnAdicionarEtapa";
            btnAdicionarEtapa.Size = new Size(121, 37);
            btnAdicionarEtapa.TabIndex = 21;
            btnAdicionarEtapa.Text = "Adicionar Etapa";
            btnAdicionarEtapa.TextAlign = ContentAlignment.MiddleRight;
            btnAdicionarEtapa.UseVisualStyleBackColor = true;
            // 
            // btnExcluirEtapa
            // 
            btnExcluirEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirEtapa.ImageKey = "cancelar.png";
            btnExcluirEtapa.ImageList = imageList1;
            btnExcluirEtapa.Location = new Point(181, 501);
            btnExcluirEtapa.Name = "btnExcluirEtapa";
            btnExcluirEtapa.Size = new Size(106, 37);
            btnExcluirEtapa.TabIndex = 22;
            btnExcluirEtapa.Text = "Excluir Etapa";
            btnExcluirEtapa.TextAlign = ContentAlignment.MiddleRight;
            btnExcluirEtapa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(342, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(446, 215);
            dataGridView1.TabIndex = 23;
            // 
            // FrmAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 552);
            Controls.Add(dataGridView1);
            Controls.Add(btnExcluirEtapa);
            Controls.Add(btnAdicionarEtapa);
            Controls.Add(txtObservacoes2);
            Controls.Add(cbxEtapaAtendimento);
            Controls.Add(btnFinalizar);
            Controls.Add(btnSalvar);
            Controls.Add(txtAtendimento);
            Controls.Add(lblAtendimento);
            Controls.Add(cbxDataAbertura);
            Controls.Add(txtObservacoes);
            Controls.Add(cbxSituacaoAtendimento);
            Controls.Add(txtCodigoCliente);
            Controls.Add(cbxNome);
            Controls.Add(lblObservacoes2);
            Controls.Add(lblEtapaAtendimento);
            Controls.Add(lblEtapasAtendiemento);
            Controls.Add(lblObservacoes);
            Controls.Add(lblSituacaoAtendimento);
            Controls.Add(lblDataAbertura);
            Controls.Add(lblNome);
            Controls.Add(lblCodigoCliente);
            Controls.Add(lblDadosCliente);
            Name = "FrmAtendimento";
            Text = "Atendiemnto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDadosCliente;
        private Label lblCodigoCliente;
        private Label lblNome;
        private Label lblDataAbertura;
        private Label lblSituacaoAtendimento;
        private Label lblObservacoes;
        private Label lblEtapasAtendiemento;
        private Label lblEtapaAtendimento;
        private Label lblObservacoes2;
        private ComboBox cbxNome;
        private TextBox txtCodigoCliente;
        private ComboBox cbxSituacaoAtendimento;
        private TextBox txtObservacoes;
        private DateTimePicker cbxDataAbertura;
        private Label lblAtendimento;
        private TextBox txtAtendimento;
        private Button btnSalvar;
        private Button btnFinalizar;
        private ImageList imageList1;
        private ComboBox cbxEtapaAtendimento;
        private TextBox txtObservacoes2;
        private Button btnAdicionarEtapa;
        private Button btnExcluirEtapa;
        private DataGridView dataGridView1;
    }
}