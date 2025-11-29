namespace SistemaAtendimento.View
{
    partial class FrmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuario));
            grbListaUsuarios = new GroupBox();
            dgvUsuarios = new DataGridView();
            btnPesquisar = new Button();
            imageList1 = new ImageList(components);
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnNovo = new Button();
            grbDadosUsuario = new GroupBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            cbxPerfil = new ComboBox();
            lblPerfil = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            grbListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            grbDadosUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // grbListaUsuarios
            // 
            grbListaUsuarios.Controls.Add(dgvUsuarios);
            grbListaUsuarios.Location = new Point(17, 231);
            grbListaUsuarios.Name = "grbListaUsuarios";
            grbListaUsuarios.Size = new Size(767, 243);
            grbListaUsuarios.TabIndex = 44;
            grbListaUsuarios.TabStop = false;
            grbListaUsuarios.Text = "Lista de Usuários";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(6, 22);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(755, 215);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellMouseDoubleClick += dgvUsuarios_CellMouseDoubleClick;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = imageList1;
            btnPesquisar.Location = new Point(736, 191);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(48, 23);
            btnPesquisar.TabIndex = 51;
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
            txtPesquisar.Location = new Point(498, 191);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(231, 23);
            txtPesquisar.TabIndex = 50;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(498, 173);
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
            btnCancelar.ImageList = imageList1;
            btnCancelar.Location = new Point(340, 185);
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
            btnExcluir.ImageList = imageList1;
            btnExcluir.Location = new Point(259, 185);
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
            btnSalvar.ImageList = imageList1;
            btnSalvar.Location = new Point(178, 185);
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
            btnEditar.ImageList = imageList1;
            btnEditar.Location = new Point(97, 185);
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
            btnNovo.ImageList = imageList1;
            btnNovo.Location = new Point(16, 185);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 29);
            btnNovo.TabIndex = 45;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // grbDadosUsuario
            // 
            grbDadosUsuario.Controls.Add(txtSenha);
            grbDadosUsuario.Controls.Add(lblSenha);
            grbDadosUsuario.Controls.Add(cbxPerfil);
            grbDadosUsuario.Controls.Add(lblPerfil);
            grbDadosUsuario.Controls.Add(txtEmail);
            grbDadosUsuario.Controls.Add(lblEmail);
            grbDadosUsuario.Controls.Add(txtNome);
            grbDadosUsuario.Controls.Add(lblNome);
            grbDadosUsuario.Controls.Add(lblCodigo);
            grbDadosUsuario.Controls.Add(txtCodigo);
            grbDadosUsuario.Location = new Point(16, 12);
            grbDadosUsuario.Name = "grbDadosUsuario";
            grbDadosUsuario.Size = new Size(768, 141);
            grbDadosUsuario.TabIndex = 42;
            grbDadosUsuario.TabStop = false;
            grbDadosUsuario.Text = "Dados do Usuário";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(288, 93);
            txtSenha.Name = "txtSenha";
            txtSenha.ReadOnly = true;
            txtSenha.Size = new Size(234, 23);
            txtSenha.TabIndex = 10;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(288, 75);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 11;
            lblSenha.Text = "Senha";
            // 
            // cbxPerfil
            // 
            cbxPerfil.Enabled = false;
            cbxPerfil.FormattingEnabled = true;
            cbxPerfil.Items.AddRange(new object[] { "Usuário", "Administrador" });
            cbxPerfil.Location = new Point(526, 93);
            cbxPerfil.Name = "cbxPerfil";
            cbxPerfil.Size = new Size(218, 23);
            cbxPerfil.TabIndex = 9;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Location = new Point(526, 75);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(34, 15);
            lblPerfil.TabIndex = 8;
            lblPerfil.Text = "Perfil";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(15, 93);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(268, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(15, 75);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
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
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 489);
            Controls.Add(grbListaUsuarios);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosUsuario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Usuários";
            Load += FrmCadastroUsuario_Load;
            grbListaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            grbDadosUsuario.ResumeLayout(false);
            grbDadosUsuario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbListaUsuarios;
        private DataGridView dgvUsuarios;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private Label lblPesquisar;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnNovo;
        private GroupBox grbDadosUsuario;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private ComboBox cbxPerfil;
        private Label lblPerfil;
        private ImageList imageList1;
        private TextBox txtSenha;
        private Label lblSenha;
    }
}