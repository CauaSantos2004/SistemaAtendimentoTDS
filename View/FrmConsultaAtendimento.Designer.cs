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
            dgvConsultaAtendimento.Location = new Point(22, 85);
            dgvConsultaAtendimento.Name = "dgvConsultaAtendimento";
            dgvConsultaAtendimento.ReadOnly = true;
            dgvConsultaAtendimento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultaAtendimento.Size = new Size(641, 265);
            dgvConsultaAtendimento.TabIndex = 0;
            dgvConsultaAtendimento.CellDoubleClick += dgvConsultaAtendimento_CellDoubleClick;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(174, 22);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(359, 23);
            txtFiltro.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.ImageIndex = 0;
            btnPesquisar.ImageList = imageList1;
            btnPesquisar.Location = new Point(539, 21);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(87, 23);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icone-pesquisar.png");
            // 
            // cbxFiltro
            // 
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Items.AddRange(new object[] { "Código do Atendimento", "Nome do Cliente", "CPF", "CNPJ" });
            cbxFiltro.Location = new Point(6, 22);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(162, 23);
            cbxFiltro.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxFiltro);
            groupBox1.Controls.Add(txtFiltro);
            groupBox1.Controls.Add(btnPesquisar);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(641, 55);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar Por:";
            // 
            // FrmConsultaAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 378);
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