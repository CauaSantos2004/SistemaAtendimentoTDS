namespace SistemaAtendimento
{
    partial class FrmCadastroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroClientes));
            grdDadosCliente = new GroupBox();
            cbxEstado = new ComboBox();
            pnlSituacao = new Panel();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblSituacao = new Label();
            lblEstado = new Label();
            txtCidade = new TextBox();
            lblCidade = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtNumero = new TextBox();
            txtEndereco = new TextBox();
            txtCep = new TextBox();
            lblNumero = new Label();
            lblEndereco = new Label();
            lblCep = new Label();
            pnlTipoPessoa = new Panel();
            rdbJuridico = new RadioButton();
            rdbFisica = new RadioButton();
            lblTipoPessoa = new Label();
            txtCpf = new TextBox();
            lblCpfCnpj = new Label();
            txtCelular = new TextBox();
            txtTelefone = new TextBox();
            lblCelular = new Label();
            lblTelefone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnNovo = new Button();
            imlIcones = new ImageList(components);
            btnSalvar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnExcluir = new Button();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            lblPesquisar = new Label();
            grbListaClientes = new GroupBox();
            dgvClientes = new DataGridView();
            grdDadosCliente.SuspendLayout();
            pnlSituacao.SuspendLayout();
            pnlTipoPessoa.SuspendLayout();
            grbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // grdDadosCliente
            // 
            grdDadosCliente.Controls.Add(cbxEstado);
            grdDadosCliente.Controls.Add(pnlSituacao);
            grdDadosCliente.Controls.Add(lblSituacao);
            grdDadosCliente.Controls.Add(lblEstado);
            grdDadosCliente.Controls.Add(txtCidade);
            grdDadosCliente.Controls.Add(lblCidade);
            grdDadosCliente.Controls.Add(txtComplemento);
            grdDadosCliente.Controls.Add(lblComplemento);
            grdDadosCliente.Controls.Add(txtBairro);
            grdDadosCliente.Controls.Add(lblBairro);
            grdDadosCliente.Controls.Add(txtNumero);
            grdDadosCliente.Controls.Add(txtEndereco);
            grdDadosCliente.Controls.Add(txtCep);
            grdDadosCliente.Controls.Add(lblNumero);
            grdDadosCliente.Controls.Add(lblEndereco);
            grdDadosCliente.Controls.Add(lblCep);
            grdDadosCliente.Controls.Add(pnlTipoPessoa);
            grdDadosCliente.Controls.Add(lblTipoPessoa);
            grdDadosCliente.Controls.Add(txtCpf);
            grdDadosCliente.Controls.Add(lblCpfCnpj);
            grdDadosCliente.Controls.Add(txtCelular);
            grdDadosCliente.Controls.Add(txtTelefone);
            grdDadosCliente.Controls.Add(lblCelular);
            grdDadosCliente.Controls.Add(lblTelefone);
            grdDadosCliente.Controls.Add(txtEmail);
            grdDadosCliente.Controls.Add(lblEmail);
            grdDadosCliente.Controls.Add(txtNome);
            grdDadosCliente.Controls.Add(lblNome);
            grdDadosCliente.Controls.Add(txtCodigo);
            grdDadosCliente.Controls.Add(lblCodigo);
            grdDadosCliente.Location = new Point(12, 12);
            grdDadosCliente.Name = "grdDadosCliente";
            grdDadosCliente.Size = new Size(838, 296);
            grdDadosCliente.TabIndex = 0;
            grdDadosCliente.TabStop = false;
            grdDadosCliente.Text = "Dados do Cliente";
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MS", "MT", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxEstado.Location = new Point(17, 262);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(163, 23);
            cbxEstado.TabIndex = 13;
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbInativo);
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Location = new Point(204, 262);
            pnlSituacao.Name = "pnlSituacao";
            pnlSituacao.Size = new Size(128, 25);
            pnlSituacao.TabIndex = 14;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(63, 3);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            rdbInativo.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(4, 2);
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
            lblSituacao.Location = new Point(201, 244);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 27;
            lblSituacao.Text = "Situação";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(22, 244);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 26;
            lblEstado.Text = "Estado";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(528, 208);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(289, 23);
            txtCidade.TabIndex = 12;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(528, 190);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 24;
            lblCidade.Text = "Cidade";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(267, 208);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(243, 23);
            txtComplemento.TabIndex = 11;
            txtComplemento.TextChanged += textBox1_TextChanged_2;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(267, 190);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 22;
            lblComplemento.Text = "Complemento";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(17, 208);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(228, 23);
            txtBairro.TabIndex = 10;
            txtBairro.TextChanged += textBox1_TextChanged_1;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(21, 190);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 20;
            lblBairro.Text = "Bairro";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(646, 159);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(171, 23);
            txtNumero.TabIndex = 9;
            txtNumero.TextChanged += textBox1_TextChanged;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(203, 159);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(418, 23);
            txtEndereco.TabIndex = 8;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(17, 159);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(165, 23);
            txtCep.TabIndex = 7;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(646, 144);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 16;
            lblNumero.Text = "Número";
            lblNumero.Click += label3_Click;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(203, 144);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(56, 15);
            lblEndereco.TabIndex = 15;
            lblEndereco.Text = "Endereço";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(21, 141);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 14;
            lblCep.Text = "CEP";
            // 
            // pnlTipoPessoa
            // 
            pnlTipoPessoa.Controls.Add(rdbJuridico);
            pnlTipoPessoa.Controls.Add(rdbFisica);
            pnlTipoPessoa.Location = new Point(427, 107);
            pnlTipoPessoa.Name = "pnlTipoPessoa";
            pnlTipoPessoa.Size = new Size(133, 29);
            pnlTipoPessoa.TabIndex = 5;
            // 
            // rdbJuridico
            // 
            rdbJuridico.AutoSize = true;
            rdbJuridico.Location = new Point(64, 4);
            rdbJuridico.Name = "rdbJuridico";
            rdbJuridico.Size = new Size(66, 19);
            rdbJuridico.TabIndex = 1;
            rdbJuridico.TabStop = true;
            rdbJuridico.Text = "Jurídico";
            rdbJuridico.UseVisualStyleBackColor = true;
            // 
            // rdbFisica
            // 
            rdbFisica.AutoSize = true;
            rdbFisica.Location = new Point(4, 4);
            rdbFisica.Name = "rdbFisica";
            rdbFisica.Size = new Size(54, 19);
            rdbFisica.TabIndex = 0;
            rdbFisica.TabStop = true;
            rdbFisica.Text = "Física";
            rdbFisica.UseVisualStyleBackColor = true;
            // 
            // lblTipoPessoa
            // 
            lblTipoPessoa.AutoSize = true;
            lblTipoPessoa.Location = new Point(427, 89);
            lblTipoPessoa.Name = "lblTipoPessoa";
            lblTipoPessoa.Size = new Size(69, 15);
            lblTipoPessoa.TabIndex = 12;
            lblTipoPessoa.Text = "Tipo Pessoa";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(602, 107);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(215, 23);
            txtCpf.TabIndex = 6;
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.AutoSize = true;
            lblCpfCnpj.Location = new Point(602, 89);
            lblCpfCnpj.Name = "lblCpfCnpj";
            lblCpfCnpj.Size = new Size(60, 15);
            lblCpfCnpj.TabIndex = 10;
            lblCpfCnpj.Text = "CPF/CNPJ";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(201, 107);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(190, 23);
            txtCelular.TabIndex = 4;
            txtCelular.TextChanged += txtCelular_TextChanged;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(17, 107);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(163, 23);
            txtTelefone.TabIndex = 3;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(201, 89);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(44, 15);
            lblCelular.TabIndex = 7;
            lblCelular.Text = "Celular";
            lblCelular.Click += lblCelular_Click;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(19, 89);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(510, 51);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(307, 23);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(510, 33);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail";
            lblEmail.Click += label2_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(142, 51);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(345, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(142, 33);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(17, 51);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(17, 33);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(12, 329);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(63, 37);
            btnNovo.TabIndex = 15;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
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
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(188, 329);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(69, 37);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(98, 329);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(66, 37);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(375, 329);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 37);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(279, 329);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 37);
            btnExcluir.TabIndex = 18;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(561, 337);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(218, 23);
            txtPesquisar.TabIndex = 20;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = imlIcones;
            btnPesquisar.Location = new Point(785, 335);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(44, 25);
            btnPesquisar.TabIndex = 21;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(561, 319);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 32;
            lblPesquisar.Text = "Pesquisar";
            lblPesquisar.Click += lblPesquisar_Click;
            // 
            // grbListaClientes
            // 
            grbListaClientes.Controls.Add(dgvClientes);
            grbListaClientes.Location = new Point(12, 378);
            grbListaClientes.Name = "grbListaClientes";
            grbListaClientes.Size = new Size(838, 121);
            grbListaClientes.TabIndex = 22;
            grbListaClientes.TabStop = false;
            grbListaClientes.Text = "Lista de Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(6, 22);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(826, 93);
            dgvClientes.TabIndex = 0;
            // 
            // FrmCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 511);
            Controls.Add(grbListaClientes);
            Controls.Add(lblPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(grdDadosCliente);
            Name = "FrmCadastroClientes";
            Text = "Cadastro de Clientes";
            Load += FrmCadastroClientes_Load;
            grdDadosCliente.ResumeLayout(false);
            grdDadosCliente.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            pnlTipoPessoa.ResumeLayout(false);
            pnlTipoPessoa.PerformLayout();
            grbListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grdDadosCliente;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtCelular;
        private TextBox txtTelefone;
        private Label lblCelular;
        private Label lblTelefone;
        private Label lblTipoPessoa;
        private TextBox txtCpf;
        private Label lblCpfCnpj;
        private Panel pnlTipoPessoa;
        private Label lblNumero;
        private Label lblEndereco;
        private Label lblCep;
        private RadioButton rdbJuridico;
        private RadioButton rdbFisica;
        private TextBox txtNumero;
        private TextBox txtEndereco;
        private TextBox txtCep;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private Label lblSituacao;
        private Label lblEstado;
        private TextBox txtCidade;
        private Label lblCidade;
        private Panel pnlSituacao;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private ComboBox cbxEstado;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnExcluir;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Label lblPesquisar;
        private GroupBox grbListaClientes;
        private DataGridView dgvClientes;
        private ImageList imlIcones;
    }
}