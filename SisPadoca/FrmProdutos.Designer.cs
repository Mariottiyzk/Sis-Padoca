namespace SisPadoca
{
    partial class FrmProdutos
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
            LblNCM = new Label();
            TxtNCM = new TextBox();
            BtnNovo = new Button();
            ImgLista = new ImageList(components);
            CmbUnidade = new ComboBox();
            PbxImagem = new PictureBox();
            TxtDescricao = new TextBox();
            LblDescricao = new Label();
            TxtCodigoBarras = new TextBox();
            LblCodigoBarras = new Label();
            LblUnidade = new Label();
            TxtLote = new TextBox();
            LblLote = new Label();
            BtnEditar = new Button();
            BtnExcluir = new Button();
            BtnLimpar = new Button();
            BtnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)PbxImagem).BeginInit();
            SuspendLayout();
            // 
            // LblNCM
            // 
            LblNCM.AutoSize = true;
            LblNCM.Location = new Point(263, 47);
            LblNCM.Name = "LblNCM";
            LblNCM.Size = new Size(52, 25);
            LblNCM.TabIndex = 0;
            LblNCM.Text = "NCM";
            // 
            // TxtNCM
            // 
            TxtNCM.Location = new Point(263, 75);
            TxtNCM.Name = "TxtNCM";
            TxtNCM.Size = new Size(176, 31);
            TxtNCM.TabIndex = 1;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(53, 307);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(123, 66);
            BtnNovo.TabIndex = 2;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            // 
            // ImgLista
            // 
            ImgLista.ColorDepth = ColorDepth.Depth32Bit;
            ImgLista.ImageSize = new Size(16, 16);
            ImgLista.TransparentColor = Color.Transparent;
            // 
            // CmbUnidade
            // 
            CmbUnidade.FormattingEnabled = true;
            CmbUnidade.Items.AddRange(new object[] { "Unitário", "Kilo", "Dúzia" });
            CmbUnidade.Location = new Point(607, 155);
            CmbUnidade.Name = "CmbUnidade";
            CmbUnidade.Size = new Size(182, 33);
            CmbUnidade.TabIndex = 3;
            // 
            // PbxImagem
            // 
            PbxImagem.Image = Properties.Resources.w;
            PbxImagem.Location = new Point(53, 47);
            PbxImagem.Name = "PbxImagem";
            PbxImagem.Size = new Size(179, 222);
            PbxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            PbxImagem.TabIndex = 4;
            PbxImagem.TabStop = false;
            // 
            // TxtDescricao
            // 
            TxtDescricao.Location = new Point(263, 155);
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(290, 31);
            TxtDescricao.TabIndex = 6;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(263, 127);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(88, 25);
            LblDescricao.TabIndex = 5;
            LblDescricao.Text = "Descrição";
            // 
            // TxtCodigoBarras
            // 
            TxtCodigoBarras.Location = new Point(263, 238);
            TxtCodigoBarras.Name = "TxtCodigoBarras";
            TxtCodigoBarras.Size = new Size(290, 31);
            TxtCodigoBarras.TabIndex = 8;
            // 
            // LblCodigoBarras
            // 
            LblCodigoBarras.AutoSize = true;
            LblCodigoBarras.Location = new Point(263, 210);
            LblCodigoBarras.Name = "LblCodigoBarras";
            LblCodigoBarras.Size = new Size(149, 25);
            LblCodigoBarras.TabIndex = 7;
            LblCodigoBarras.Text = "Codigo de Barras";
            // 
            // LblUnidade
            // 
            LblUnidade.AutoSize = true;
            LblUnidade.Location = new Point(607, 127);
            LblUnidade.Name = "LblUnidade";
            LblUnidade.Size = new Size(139, 25);
            LblUnidade.TabIndex = 9;
            LblUnidade.Text = "Und. de Medida";
            // 
            // TxtLote
            // 
            TxtLote.Location = new Point(607, 238);
            TxtLote.Name = "TxtLote";
            TxtLote.Size = new Size(182, 31);
            TxtLote.TabIndex = 11;
            // 
            // LblLote
            // 
            LblLote.AutoSize = true;
            LblLote.Location = new Point(607, 210);
            LblLote.Name = "LblLote";
            LblLote.Size = new Size(46, 25);
            LblLote.TabIndex = 10;
            LblLote.Text = "Lote";
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(199, 307);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(123, 66);
            BtnEditar.TabIndex = 12;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(356, 307);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(123, 66);
            BtnExcluir.TabIndex = 13;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(509, 307);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(123, 66);
            BtnLimpar.TabIndex = 14;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(666, 307);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(123, 66);
            BtnFechar.TabIndex = 15;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 450);
            Controls.Add(BtnFechar);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(TxtLote);
            Controls.Add(LblLote);
            Controls.Add(LblUnidade);
            Controls.Add(TxtCodigoBarras);
            Controls.Add(LblCodigoBarras);
            Controls.Add(TxtDescricao);
            Controls.Add(LblDescricao);
            Controls.Add(PbxImagem);
            Controls.Add(CmbUnidade);
            Controls.Add(BtnNovo);
            Controls.Add(TxtNCM);
            Controls.Add(LblNCM);
            Name = "FrmProdutos";
            Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)PbxImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNCM;
        private TextBox TxtNCM;
        private Button BtnNovo;
        private ImageList ImgLista;
        private ComboBox CmbUnidade;
        private PictureBox PbxImagem;
        private TextBox TxtDescricao;
        private Label LblDescricao;
        private TextBox TxtCodigoBarras;
        private Label LblCodigoBarras;
        private Label LblUnidade;
        private TextBox TxtLote;
        private Label LblLote;
        private Button BtnEditar;
        private Button BtnExcluir;
        private Button BtnLimpar;
        private Button BtnFechar;
    }
}