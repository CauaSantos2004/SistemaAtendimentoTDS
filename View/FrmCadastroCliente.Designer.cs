namespace SistemaAtendimento
{
    partial class FrmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroCliente));
            grbDadosCliente = new GroupBox();
            lblEstado = new Label();
            cbxEstado = new ComboBox();
            pnlSituacao = new Panel();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblSituacao = new Label();
            txtCidade = new TextBox();
            lblCidade = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtNumero = new TextBox();
            lblNumero = new Label();
            txtEndereco = new TextBox();
            label2 = new Label();
            txtCep = new TextBox();
            lblCep = new Label();
            txtCpfCnpj = new TextBox();
            lblCpfCnpj = new Label();
            pnlTipoPessoa = new Panel();
            rdbJuridica = new RadioButton();
            rdbFisica = new RadioButton();
            lblTipoPessoa = new Label();
            txtCelular = new TextBox();
            lblCelular = new Label();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnNovo = new Button();
            imlIcones = new ImageList(components);
            btnEditar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            btnPesquisar = new Button();
            grbListaClientes = new GroupBox();
            dgvClientes = new DataGridView();
            grbDadosCliente.SuspendLayout();
            pnlSituacao.SuspendLayout();
            pnlTipoPessoa.SuspendLayout();
            grbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // grbDadosCliente
            // 
            grbDadosCliente.Controls.Add(lblEstado);
            grbDadosCliente.Controls.Add(cbxEstado);
            grbDadosCliente.Controls.Add(pnlSituacao);
            grbDadosCliente.Controls.Add(lblSituacao);
            grbDadosCliente.Controls.Add(txtCidade);
            grbDadosCliente.Controls.Add(lblCidade);
            grbDadosCliente.Controls.Add(txtComplemento);
            grbDadosCliente.Controls.Add(lblComplemento);
            grbDadosCliente.Controls.Add(txtBairro);
            grbDadosCliente.Controls.Add(lblBairro);
            grbDadosCliente.Controls.Add(txtNumero);
            grbDadosCliente.Controls.Add(lblNumero);
            grbDadosCliente.Controls.Add(txtEndereco);
            grbDadosCliente.Controls.Add(label2);
            grbDadosCliente.Controls.Add(txtCep);
            grbDadosCliente.Controls.Add(lblCep);
            grbDadosCliente.Controls.Add(txtCpfCnpj);
            grbDadosCliente.Controls.Add(lblCpfCnpj);
            grbDadosCliente.Controls.Add(pnlTipoPessoa);
            grbDadosCliente.Controls.Add(lblTipoPessoa);
            grbDadosCliente.Controls.Add(txtCelular);
            grbDadosCliente.Controls.Add(lblCelular);
            grbDadosCliente.Controls.Add(txtTelefone);
            grbDadosCliente.Controls.Add(lblTelefone);
            grbDadosCliente.Controls.Add(txtEmail);
            grbDadosCliente.Controls.Add(lblEmail);
            grbDadosCliente.Controls.Add(txtNome);
            grbDadosCliente.Controls.Add(lblNome);
            grbDadosCliente.Controls.Add(txtCodigo);
            grbDadosCliente.Controls.Add(lblCodigo);
            grbDadosCliente.Location = new Point(12, 12);
            grbDadosCliente.Name = "grbDadosCliente";
            grbDadosCliente.Size = new Size(787, 316);
            grbDadosCliente.TabIndex = 0;
            grbDadosCliente.TabStop = false;
            grbDadosCliente.Text = "Dados do Cliente";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(24, 251);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 27;
            lblEstado.Text = "Estado";
            // 
            // cbxEstado
            // 
            cbxEstado.Enabled = false;
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PR", "PB", "PA", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SE", "SP", "TO" });
            cbxEstado.Location = new Point(24, 272);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(136, 23);
            cbxEstado.TabIndex = 13;
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbInativo);
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Enabled = false;
            pnlSituacao.Location = new Point(205, 269);
            pnlSituacao.Name = "pnlSituacao";
            pnlSituacao.Size = new Size(144, 28);
            pnlSituacao.TabIndex = 14;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(63, 3);
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
            lblSituacao.Location = new Point(205, 251);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 12;
            lblSituacao.Text = "Situacao";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(519, 216);
            txtCidade.Name = "txtCidade";
            txtCidade.ReadOnly = true;
            txtCidade.Size = new Size(253, 23);
            txtCidade.TabIndex = 12;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(519, 198);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 24;
            lblCidade.Text = "Cidade";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(196, 216);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.ReadOnly = true;
            txtComplemento.Size = new Size(295, 23);
            txtComplemento.TabIndex = 11;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(196, 198);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 22;
            lblComplemento.Text = "Complemento";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(21, 216);
            txtBairro.Name = "txtBairro";
            txtBairro.ReadOnly = true;
            txtBairro.Size = new Size(153, 23);
            txtBairro.TabIndex = 10;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(21, 198);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 20;
            lblBairro.Text = "Bairro";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(546, 157);
            txtNumero.Name = "txtNumero";
            txtNumero.ReadOnly = true;
            txtNumero.Size = new Size(226, 23);
            txtNumero.TabIndex = 9;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(546, 139);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 18;
            lblNumero.Text = "Número";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(196, 157);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.ReadOnly = true;
            txtEndereco.Size = new Size(331, 23);
            txtEndereco.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 139);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 16;
            label2.Text = "Endereço";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(21, 157);
            txtCep.Name = "txtCep";
            txtCep.ReadOnly = true;
            txtCep.Size = new Size(153, 23);
            txtCep.TabIndex = 7;
            txtCep.Leave += txtCep_Leave;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(21, 139);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 14;
            lblCep.Text = "CEP";
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Location = new Point(546, 102);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.ReadOnly = true;
            txtCpfCnpj.Size = new Size(226, 23);
            txtCpfCnpj.TabIndex = 6;
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.AutoSize = true;
            lblCpfCnpj.Location = new Point(546, 84);
            lblCpfCnpj.Name = "lblCpfCnpj";
            lblCpfCnpj.Size = new Size(28, 15);
            lblCpfCnpj.TabIndex = 12;
            lblCpfCnpj.Text = "CPF";
            // 
            // pnlTipoPessoa
            // 
            pnlTipoPessoa.Controls.Add(rdbJuridica);
            pnlTipoPessoa.Controls.Add(rdbFisica);
            pnlTipoPessoa.Enabled = false;
            pnlTipoPessoa.Location = new Point(383, 100);
            pnlTipoPessoa.Name = "pnlTipoPessoa";
            pnlTipoPessoa.Size = new Size(144, 28);
            pnlTipoPessoa.TabIndex = 5;
            // 
            // rdbJuridica
            // 
            rdbJuridica.AutoSize = true;
            rdbJuridica.Location = new Point(63, 3);
            rdbJuridica.Name = "rdbJuridica";
            rdbJuridica.Size = new Size(65, 19);
            rdbJuridica.TabIndex = 1;
            rdbJuridica.Text = "Jurídica";
            rdbJuridica.UseVisualStyleBackColor = true;
            rdbJuridica.CheckedChanged += rdbJuridica_CheckedChanged;
            // 
            // rdbFisica
            // 
            rdbFisica.AutoSize = true;
            rdbFisica.Checked = true;
            rdbFisica.Location = new Point(3, 3);
            rdbFisica.Name = "rdbFisica";
            rdbFisica.Size = new Size(54, 19);
            rdbFisica.TabIndex = 0;
            rdbFisica.TabStop = true;
            rdbFisica.Text = "Física";
            rdbFisica.UseVisualStyleBackColor = true;
            rdbFisica.CheckedChanged += rdbFisica_CheckedChanged;
            // 
            // lblTipoPessoa
            // 
            lblTipoPessoa.AutoSize = true;
            lblTipoPessoa.Location = new Point(383, 82);
            lblTipoPessoa.Name = "lblTipoPessoa";
            lblTipoPessoa.Size = new Size(74, 15);
            lblTipoPessoa.TabIndex = 10;
            lblTipoPessoa.Text = "Tipo Pesssoa";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(196, 99);
            txtCelular.Name = "txtCelular";
            txtCelular.ReadOnly = true;
            txtCelular.Size = new Size(153, 23);
            txtCelular.TabIndex = 4;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(196, 81);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(44, 15);
            lblCelular.TabIndex = 8;
            lblCelular.Text = "Celular";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(21, 99);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.ReadOnly = true;
            txtTelefone.Size = new Size(153, 23);
            txtTelefone.TabIndex = 3;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(21, 81);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(442, 43);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(330, 23);
            txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(442, 25);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(151, 43);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(266, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(151, 25);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(21, 43);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(21, 25);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(27, 344);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(76, 34);
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
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(109, 345);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 33);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(198, 346);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 33);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(280, 346);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 33);
            btnExcluir.TabIndex = 18;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(361, 346);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.RightToLeft = RightToLeft.No;
            btnCancelar.Size = new Size(87, 33);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisar.Location = new Point(486, 355);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(233, 25);
            txtPesquisar.TabIndex = 20;
            
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(486, 337);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 28;
            lblPesquisar.Text = "Pesquisar";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = imlIcones;
            btnPesquisar.Location = new Point(747, 350);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(52, 32);
            btnPesquisar.TabIndex = 21;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // grbListaClientes
            // 
            grbListaClientes.Controls.Add(dgvClientes);
            grbListaClientes.Location = new Point(27, 400);
            grbListaClientes.Name = "grbListaClientes";
            grbListaClientes.Size = new Size(773, 225);
            grbListaClientes.TabIndex = 31;
            grbListaClientes.TabStop = false;
            grbListaClientes.Text = "Lista de Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(9, 22);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(748, 188);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            // 
            // FrmCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 645);
            Controls.Add(grbListaClientes);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosCliente);
            Name = "FrmCadastroCliente";
            Text = "Cadastro de Clientes";
            Load += FrmCadastroCliente_Load;
            grbDadosCliente.ResumeLayout(false);
            grbDadosCliente.PerformLayout();
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

        private GroupBox grbDadosCliente;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtCelular;
        private Label lblCelular;
        private Label lblTipoPessoa;
        private Panel pnlTipoPessoa;
        private RadioButton rdbJuridica;
        private RadioButton rdbFisica;
        private TextBox txtCidade;
        private Label lblCidade;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtNumero;
        private Label lblNumero;
        private TextBox txtEndereco;
        private Label label2;
        private TextBox txtCep;
        private Label lblCep;
        private TextBox txtCpfCnpj;
        private Label lblCpfCnpj;
        private Panel pnlSituacao;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Label lblSituacao;
        private Label lblEstado;
        private ComboBox cbxEstado;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnCancelar;
        private TextBox txtPesquisar;
        private Label lblPesquisar;
        private Button btnPesquisar;
        private GroupBox grbListaClientes;
        private DataGridView dgvClientes;
        private ImageList imlIcones;
    }
}