namespace LocadoraDeVeiculos.WinFormsApp.ModuloAluguel
{
    partial class TelaGerarPdfForm
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
            rdbDevolucao = new RadioButton();
            rdbLocacao = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            btnDiretorio = new Button();
            txtDiretorio = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // rdbDevolucao
            // 
            rdbDevolucao.AutoSize = true;
            rdbDevolucao.Location = new Point(173, 47);
            rdbDevolucao.Name = "rdbDevolucao";
            rdbDevolucao.Size = new Size(81, 19);
            rdbDevolucao.TabIndex = 113;
            rdbDevolucao.TabStop = true;
            rdbDevolucao.Text = "Devolução";
            rdbDevolucao.UseVisualStyleBackColor = true;
            // 
            // rdbLocacao
            // 
            rdbLocacao.AutoSize = true;
            rdbLocacao.Location = new Point(173, 22);
            rdbLocacao.Name = "rdbLocacao";
            rdbLocacao.Size = new Size(72, 19);
            rdbLocacao.TabIndex = 112;
            rdbLocacao.TabStop = true;
            rdbLocacao.Text = "Locação ";
            rdbLocacao.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(11, 22);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 111;
            label2.Text = "Escolha uma das opções:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 88);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 110;
            label1.Text = "Escolha um diretorio:";
            // 
            // btnDiretorio
            // 
            btnDiretorio.BackColor = Color.IndianRed;
            btnDiretorio.Location = new Point(149, 82);
            btnDiretorio.Name = "btnDiretorio";
            btnDiretorio.Size = new Size(140, 31);
            btnDiretorio.TabIndex = 109;
            btnDiretorio.Text = "Diretório";
            btnDiretorio.UseVisualStyleBackColor = false;
            // 
            // txtDiretorio
            // 
            txtDiretorio.Location = new Point(11, 119);
            txtDiretorio.Name = "txtDiretorio";
            txtDiretorio.ReadOnly = true;
            txtDiretorio.Size = new Size(278, 23);
            txtDiretorio.TabIndex = 108;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.IndianRed;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(131, 162);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(76, 34);
            btnGravar.TabIndex = 115;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(213, 162);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(76, 34);
            btnCancelar.TabIndex = 114;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // TelaGerarPdfForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 208);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(rdbDevolucao);
            Controls.Add(rdbLocacao);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDiretorio);
            Controls.Add(txtDiretorio);
            Name = "TelaGerarPdfForm";
            Text = "Gerar PDF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdbDevolucao;
        private RadioButton rdbLocacao;
        private Label label2;
        private Label label1;
        private Button btnDiretorio;
        private TextBox txtDiretorio;
        private Button btnGravar;
        private Button btnCancelar;
    }
}