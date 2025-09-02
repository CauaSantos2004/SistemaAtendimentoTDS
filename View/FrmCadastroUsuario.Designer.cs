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
            lblNome = new Label();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            grbDadosUsuario = new GroupBox();
            cbxPerfil = new ComboBox();
            txtSenha = new TextBox();
            lblPerfil = new Label();
            lblSenha = new Label();
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            imlIcones = new ImageList(components);
            btnNovo = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnExcluir = new Button();
            grbListaUsuario = new GroupBox();
            dgvUsuario = new DataGridView();
            grbDadosUsuario.SuspendLayout();
            grbListaUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(169, 28);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(20, 28);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            lblCodigo.Click += lblCodigo_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(20, 46);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(169, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(588, 23);
            txtNome.TabIndex = 2;
            // 
            // grbDadosUsuario
            // 
            grbDadosUsuario.Controls.Add(cbxPerfil);
            grbDadosUsuario.Controls.Add(txtSenha);
            grbDadosUsuario.Controls.Add(lblPerfil);
            grbDadosUsuario.Controls.Add(lblSenha);
            grbDadosUsuario.Controls.Add(txtCodigo);
            grbDadosUsuario.Controls.Add(lblNome);
            grbDadosUsuario.Controls.Add(txtNome);
            grbDadosUsuario.Controls.Add(lblCodigo);
            grbDadosUsuario.Location = new Point(12, 12);
            grbDadosUsuario.Name = "grbDadosUsuario";
            grbDadosUsuario.Size = new Size(776, 164);
            grbDadosUsuario.TabIndex = 4;
            grbDadosUsuario.TabStop = false;
            grbDadosUsuario.Text = "Dados do Usúario";
            // 
            // cbxPerfil
            // 
            cbxPerfil.FormattingEnabled = true;
            cbxPerfil.Items.AddRange(new object[] { "Administrador", "Usúario" });
            cbxPerfil.Location = new Point(335, 102);
            cbxPerfil.Name = "cbxPerfil";
            cbxPerfil.Size = new Size(245, 23);
            cbxPerfil.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(20, 102);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(270, 23);
            txtSenha.TabIndex = 3;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Location = new Point(335, 84);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(34, 15);
            lblPerfil.TabIndex = 5;
            lblPerfil.Text = "Perfil";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(20, 84);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(512, 210);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 11;
            lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(512, 228);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(215, 23);
            txtPesquisar.TabIndex = 10;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = imlIcones;
            btnPesquisar.Location = new Point(741, 226);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(41, 25);
            btnPesquisar.TabIndex = 11;
            btnPesquisar.UseVisualStyleBackColor = true;
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
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(12, 214);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(63, 37);
            btnNovo.TabIndex = 5;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(190, 214);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(63, 37);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(101, 214);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(63, 37);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(374, 214);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 37);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(280, 214);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(69, 37);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // grbListaUsuario
            // 
            grbListaUsuario.Controls.Add(dgvUsuario);
            grbListaUsuario.Location = new Point(12, 277);
            grbListaUsuario.Name = "grbListaUsuario";
            grbListaUsuario.Size = new Size(776, 161);
            grbListaUsuario.TabIndex = 28;
            grbListaUsuario.TabStop = false;
            grbListaUsuario.Text = "Lista de Usúario";
            // 
            // dgvUsuario
            // 
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Location = new Point(6, 22);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.Size = new Size(764, 133);
            dgvUsuario.TabIndex = 0;
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbListaUsuario);
            Controls.Add(btnExcluir);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(grbDadosUsuario);
            Name = "FrmCadastroUsuario";
            Text = "Cadastro de Usúario";
            grbDadosUsuario.ResumeLayout(false);
            grbDadosUsuario.PerformLayout();
            grbListaUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private GroupBox grbDadosUsuario;
        private ComboBox cbxPerfil;
        private TextBox txtSenha;
        private Label lblPerfil;
        private Label lblSenha;
        private Label lblPesquisar;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnExcluir;
        private GroupBox grbListaUsuario;
        private DataGridView dgvUsuario;
        private ImageList imlIcones;
    }
}