namespace SisPadoca
{
    partial class FrmClientes
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
            LblCPF = new Label();
            MtbCPF = new MaskedTextBox();
            LblNome = new Label();
            TxtNome = new TextBox();
            LblSexo = new Label();
            LblDatanasc = new Label();
            CmbSexo = new ComboBox();
            LblEndereco = new Label();
            LblBairro = new Label();
            LblCidade = new Label();
            TxtEndereco = new TextBox();
            TxtBairro = new TextBox();
            DtpDatanasc = new DateTimePicker();
            TxtCidade = new TextBox();
            LblEstado = new Label();
            this.LblObs = new Label();
            TxtObs = new TextBox();
            CmbEstado = new ComboBox();
            SuspendLayout();
            // 
            // LblCPF
            // 
            LblCPF.AutoSize = true;
            LblCPF.Location = new Point(151, 94);
            LblCPF.Name = "LblCPF";
            LblCPF.Size = new Size(42, 25);
            LblCPF.TabIndex = 0;
            LblCPF.Text = "CPF";
            // 
            // MtbCPF
            // 
            MtbCPF.Location = new Point(151, 139);
            MtbCPF.Mask = "###,###,###-##";
            MtbCPF.Name = "MtbCPF";
            MtbCPF.Size = new Size(150, 31);
            MtbCPF.TabIndex = 1;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(519, 94);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(61, 25);
            LblNome.TabIndex = 2;
            LblNome.Text = "Nome";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(519, 139);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(347, 31);
            TxtNome.TabIndex = 3;
            // 
            // LblSexo
            // 
            LblSexo.AutoSize = true;
            LblSexo.Location = new Point(151, 201);
            LblSexo.Name = "LblSexo";
            LblSexo.Size = new Size(50, 25);
            LblSexo.TabIndex = 4;
            LblSexo.Text = "Sexo";
            // 
            // LblDatanasc
            // 
            LblDatanasc.AutoSize = true;
            LblDatanasc.Location = new Point(519, 201);
            LblDatanasc.Name = "LblDatanasc";
            LblDatanasc.Size = new Size(173, 25);
            LblDatanasc.TabIndex = 6;
            LblDatanasc.Text = "Data de Nascimento";
            // 
            // CmbSexo
            // 
            CmbSexo.FormattingEnabled = true;
            CmbSexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            CmbSexo.Location = new Point(151, 231);
            CmbSexo.Name = "CmbSexo";
            CmbSexo.Size = new Size(182, 33);
            CmbSexo.TabIndex = 7;
            // 
            // LblEndereco
            // 
            LblEndereco.AutoSize = true;
            LblEndereco.Location = new Point(151, 306);
            LblEndereco.Name = "LblEndereco";
            LblEndereco.Size = new Size(85, 25);
            LblEndereco.TabIndex = 8;
            LblEndereco.Text = "Endereço";
            // 
            // LblBairro
            // 
            LblBairro.AutoSize = true;
            LblBairro.Location = new Point(361, 306);
            LblBairro.Name = "LblBairro";
            LblBairro.Size = new Size(58, 25);
            LblBairro.TabIndex = 9;
            LblBairro.Text = "Bairro";
            // 
            // LblCidade
            // 
            LblCidade.AutoSize = true;
            LblCidade.Location = new Point(608, 306);
            LblCidade.Name = "LblCidade";
            LblCidade.Size = new Size(67, 25);
            LblCidade.TabIndex = 10;
            LblCidade.Text = "Cidade";
            LblCidade.Click += label3_Click;
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(151, 352);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(150, 31);
            TxtEndereco.TabIndex = 11;
            // 
            // TxtBairro
            // 
            TxtBairro.Location = new Point(361, 352);
            TxtBairro.Name = "TxtBairro";
            TxtBairro.Size = new Size(150, 31);
            TxtBairro.TabIndex = 12;
            // 
            // DtpDatanasc
            // 
            DtpDatanasc.Location = new Point(519, 233);
            DtpDatanasc.Name = "DtpDatanasc";
            DtpDatanasc.Size = new Size(300, 31);
            DtpDatanasc.TabIndex = 13;
            // 
            // TxtCidade
            // 
            TxtCidade.Location = new Point(608, 352);
            TxtCidade.Name = "TxtCidade";
            TxtCidade.Size = new Size(150, 31);
            TxtCidade.TabIndex = 14;
            // 
            // LblEstado
            // 
            LblEstado.AutoSize = true;
            LblEstado.Location = new Point(871, 306);
            LblEstado.Name = "LblEstado";
            LblEstado.Size = new Size(66, 25);
            LblEstado.TabIndex = 16;
            LblEstado.Text = "Estado";
            // 
            // LblObs
            // 
            this.LblObs.AutoSize = true;
            this.LblObs.Location = new Point(151, 445);
            this.LblObs.Name = "LblObs";
            this.LblObs.Size = new Size(110, 25);
            this.LblObs.TabIndex = 17;
            this.LblObs.Text = "Observação:";
            // 
            // TxtObs
            // 
            TxtObs.Location = new Point(151, 505);
            TxtObs.Name = "TxtObs";
            TxtObs.Size = new Size(400, 31);
            TxtObs.TabIndex = 18;
            // 
            // CmbEstado
            // 
            CmbEstado.FormattingEnabled = true;
            CmbEstado.Location = new Point(871, 352);
            CmbEstado.Name = "CmbEstado";
            CmbEstado.Size = new Size(93, 33);
            CmbEstado.TabIndex = 19;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 629);
            Controls.Add(CmbEstado);
            Controls.Add(TxtObs);
            Controls.Add(this.LblObs);
            Controls.Add(LblEstado);
            Controls.Add(TxtCidade);
            Controls.Add(DtpDatanasc);
            Controls.Add(TxtBairro);
            Controls.Add(TxtEndereco);
            Controls.Add(LblCidade);
            Controls.Add(LblBairro);
            Controls.Add(LblEndereco);
            Controls.Add(CmbSexo);
            Controls.Add(LblDatanasc);
            Controls.Add(LblSexo);
            Controls.Add(TxtNome);
            Controls.Add(LblNome);
            Controls.Add(MtbCPF);
            Controls.Add(LblCPF);
            Name = "FrmClientes";
            Text = "Cadastro de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblCPF;
        private MaskedTextBox MtbCPF;
        private Label LblNome;
        private TextBox TxtNome;
        private Label LblSexo;
        private Label LblDatanasc;
        private ComboBox CmbSexo;
        private Label LblEndereco;
        private Label LblBairro;
        private Label LblCidade;
        private TextBox TxtEndereco;
        private TextBox TxtBairro;
        private DateTimePicker DtpDatanasc;
        private TextBox TxtCidade;
        private TextBox textBox5;
        private Label LblEstado;
        private Label label2;
        private TextBox TxtObs;
        private ComboBox CmbEstado;
    }
}