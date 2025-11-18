namespace SistemaAtendimento.View
{
    partial class FrmConsultaAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaAtendimento));
            dgvConsultaAtendimento = new DataGridView();
            txtFiltro = new TextBox();
            btnPesquisar = new Button();
            imageList1 = new ImageList(components);
            cbxFiltro = new ComboBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvConsultaAtendimento
            // 
            dgvConsultaAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaAtendimento.Location = new Point(12, 97);
            dgvConsultaAtendimento.Name = "dgvConsultaAtendimento";
            dgvConsultaAtendimento.ReadOnly = true;
            dgvConsultaAtendimento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultaAtendimento.Size = new Size(776, 327);
            dgvConsultaAtendimento.TabIndex = 0;
            dgvConsultaAtendimento.CellDoubleClick += dgvConsultaAtendimento_CellDoubleClick;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(192, 19);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(458, 23);
            txtFiltro.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisar.ImageAlign = ContentAlignment.MiddleRight;
            btnPesquisar.ImageIndex = 5;
            btnPesquisar.ImageList = imageList1;
            btnPesquisar.Location = new Point(673, 13);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(97, 31);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Finalizar.png");
            imageList1.Images.SetKeyName(1, "icone-cancelar.png");
            imageList1.Images.SetKeyName(2, "icone-editar.png");
            imageList1.Images.SetKeyName(3, "icone-excluir.png");
            imageList1.Images.SetKeyName(4, "icone-novo.png");
            imageList1.Images.SetKeyName(5, "icone-pesquisar.png");
            imageList1.Images.SetKeyName(6, "icone-salvar.png");
            // 
            // cbxFiltro
            // 
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Items.AddRange(new object[] { "Código do Atendimento", "Nome do Cliente", "CPF", "CNPJ" });
            cbxFiltro.Location = new Point(6, 19);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(169, 23);
            cbxFiltro.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFiltro);
            groupBox1.Controls.Add(cbxFiltro);
            groupBox1.Controls.Add(btnPesquisar);
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 50);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar Por:";
            // 
            // FrmConsultaAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvConsultaAtendimento);
            Name = "FrmConsultaAtendimento";
            Text = "Consultas de Atendimentos";
            Load += FrmConsultaAtendimento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvConsultaAtendimento;
        private TextBox txtFiltro;
        private Button btnPesquisar;
        private ComboBox cbxFiltro;
        private ImageList imageList1;
        private GroupBox groupBox1;
    }
}